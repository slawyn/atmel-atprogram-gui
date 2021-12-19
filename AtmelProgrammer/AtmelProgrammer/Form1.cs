using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AtmelProgrammer;
using System.Drawing.Drawing2D;
using Microsoft.Win32;
using System.Security.AccessControl;
using System.Threading;

namespace AtmelProgrammer
{

    public partial class Form1 : Form
    {
        static string mAtprogramFullPath = "C:\\Program Files\\Atmel\\Atmel Studio 6.1\\atbackend\\atprogram.exe";
        static string mCurrentFullPathToElfFile;
        static string mCurrentAbsolutePath;
        static Boolean mCancelOperation;

        static Boolean mWorkerThreadIsRunning;
        enum Commands{ IDLE, FLASH, DUMP, PROGRAMFUSES, ERASE};

        static Commands mCommand;
        public Form1()
        {
            
            InitializeComponent();
            Region = new Region(RoundedRectangle.Create(new Rectangle(0, 0, Size.Width, Size.Height), 20, RoundedRectangle.RectangleCorners.TopRight | RoundedRectangle.RectangleCorners.TopLeft| RoundedRectangle.RectangleCorners.BottomLeft| RoundedRectangle.RectangleCorners.BottomRight));


            loadLastPath();


            mCancelOperation = false;
            Thread thr = new Thread(workerThread);
            thr.Start();




            //TopLeftPath = RoundedRectangle.Create(new Rectangle(0, 0, Size.Width, Size.Height), 8, RoundedRectangle.RectangleCorners.TopRight | RoundedRectangle.RectangleCorners.TopLeft, RoundedRectangle.WhichHalf.TopLeft);
            //BottomRightPath = RoundedRectangle.Create(new Rectangle(0, 0, Size.Width - 1, Size.Height - 1), 8, RoundedRectangle.RectangleCorners.TopRight | RoundedRectangle.RectangleCorners.TopLeft, RoundedRectangle.WhichHalf.BottomRight);
        }

        public delegate void delegatePrint(string s);

        public delegate void delegateExitCode(string s);

        private void programmingSuccess(string s) {
            labelExitCode.BackColor = Color.Green;
            labelExitCode.Text = s; 
        }

        private void programmingFailed(string s) {
            labelExitCode.BackColor = Color.Red;
            labelExitCode.Text = s; 
        }

        private void spawnProcessAndWait(string arguments) {

            mCancelOperation = false;

            System.Diagnostics.Process process = new System.Diagnostics.Process();

            //process.StartInfo.FileName = mAtprogramFullPath;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = arguments;

            BeginInvoke(new delegatePrint(appendToStatus), process.StartInfo.FileName + " " +process.StartInfo.Arguments);

           process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            while (!process.HasExited && !mCancelOperation)
            {
                string sl = process.StandardOutput.ReadLine();
                BeginInvoke(new delegatePrint(appendToStatus), sl);

                Thread.Sleep(40);
            }

            BeginInvoke(new delegatePrint(appendToStatus), process.StandardOutput.ReadToEnd());

            
            if (process.ExitCode == 0 && !mCancelOperation)
            {
                BeginInvoke(new delegateExitCode(programmingSuccess),"Alles paletti!");
            }
            else
            {
                BeginInvoke(new delegateExitCode(programmingFailed), "Fehler!"); 
            }
            

        }


        public void workerThread() {

            mWorkerThreadIsRunning = true;
            string arguments = "";
            while (mWorkerThreadIsRunning) {
                switch (mCommand) {
                    case Commands.FLASH:
                        try {
                            arguments =  "-i ISP -d atmega328p program -cl 125KHz -v -f \"" + mCurrentFullPathToElfFile + "\"";
                            spawnProcessAndWait(arguments);
                        }
                        catch (Exception e) {
                            BeginInvoke(new delegateExitCode(programmingFailed),"Fehler bei Programmierung!");
                            MessageBox.Show(e.ToString());
                         }

                        mCommand = Commands.IDLE;
                        break;
                    case Commands.PROGRAMFUSES:
                        mCommand = Commands.IDLE;
                        break;
                    case Commands.DUMP:
                        try
                        {
                            arguments = "-i ISP -d atmega328p read -cl 125KHz -ee";
                            spawnProcessAndWait(arguments);

                        }
                        catch (Exception e)
                        {
                            BeginInvoke(new delegateExitCode(programmingFailed), "Fehler beim Auslesen!");
                            MessageBox.Show(e.ToString());
                        }
                        mCommand = Commands.IDLE;
                        break;
                    case Commands.ERASE:
                        try
                        {
                            arguments = "-i ISP -d atmega328p read -cl 125KHz -ee";
                            spawnProcessAndWait(arguments);
                        }
                        catch (Exception e)
                        {
                            BeginInvoke(new delegateExitCode(programmingFailed), "Fehler beim Löschen!");
                            MessageBox.Show(e.ToString());
                        }
                        mCommand = Commands.IDLE;
                        break;
                    default:
                        break;
                
                }


         
                Thread.Sleep(100);
            }
        
        }


        private void loadLastPath() {
            new System.Security.Permissions.RegistryPermission(
                System.Security.Permissions.PermissionState.Unrestricted).Assert();
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);

                RegistryKey keyatmelp = key.OpenSubKey("AtmelProgrammer", true);
                if (keyatmelp != null)
                {

                    mCurrentAbsolutePath =  (string)keyatmelp.GetValue("Path");
                    mCurrentFullPathToElfFile = (string)keyatmelp.GetValue("File");

    
                    tboxFilePath.Text = mCurrentFullPathToElfFile;
                    tboxFilePath.Select(0, 0);
                    tboxStatus.Select(0, 0);
                }
            }
            finally
            {
                System.Security.Permissions.RegistryPermission.RevertAssert();
            }
        }

        private void saveLastPath() {


            new System.Security.Permissions.RegistryPermission(
            System.Security.Permissions.PermissionState.Unrestricted).Assert();
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);

                RegistryKey keyatmelp = key.OpenSubKey("AtmelProgrammer", true);
                if (keyatmelp == null)
                {

                    key.CreateSubKey("AtmelProgrammer");
                }


                keyatmelp.SetValue("Path", mCurrentAbsolutePath);
                keyatmelp.SetValue("File", mCurrentFullPathToElfFile);
            }
            finally
            {
                System.Security.Permissions.RegistryPermission.RevertAssert();
            }
           

        }

        private void appendToStatus(string s)
        {
            tboxStatus.AppendText(s);
            tboxStatus.AppendText(Environment.NewLine);
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoadElfHandler(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();

            dialog.InitialDirectory = mCurrentAbsolutePath;
            dialog.Filter = "elf files (*.elf)|*.elf|All files (*.*)|*.*";
            dialog.FilterIndex = 2;
            dialog.RestoreDirectory = true;
            //dialog.InitialDirectory = @"C:\";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                        if (dialog.CheckFileExists)
                    {
                        mCurrentFullPathToElfFile = dialog.FileName;
                        mCurrentAbsolutePath = System.IO.Path.GetDirectoryName(mCurrentFullPathToElfFile);

                        appendToStatus(mCurrentFullPathToElfFile);


                        tboxFilePath.Text = mCurrentFullPathToElfFile;


                        saveLastPath();
                        //appendToStatus(mCurrentAbsolutePath);
                    }

                }
                catch (Exception xe)
                {
                    MessageBox.Show(xe.ToString());
                }
            }
            // mFileDialog = new System.Windows.Forms.OpenFileDialog();
            // mFileDialog.ShowDialog();
            //string directoryPath = System.IO.Path.GetDirectoryName("");

        }

        private void clearExitCode() {
            labelExitCode.BackColor = Form1.DefaultBackColor;
            labelExitCode.Text = "";
        }

        private void buttonClearStatusHandler(object sender, EventArgs e)
        {
            clearExitCode();
            tboxStatus.Clear();
           
        }

        private void buttonFlashHandler(object sender, EventArgs e)
        {
            if (mCommand == Commands.IDLE) {

                if (mCurrentFullPathToElfFile!="") {
                    clearExitCode();
                    tboxStatus.Clear();
                    mCommand = Commands.FLASH;
                }
            }
        }

        private void buttonEraseHandler(object sender, EventArgs e)
        {
            if (mCommand == Commands.IDLE)
            {
                clearExitCode();
                mCommand = Commands.ERASE;
            }
        }

        private void buttonDumpHandler(object sender, EventArgs e)
        {
            if (mCommand == Commands.IDLE)
            {
                clearExitCode();
                mCommand = Commands.DUMP;
            }
        }

        private void buttonProgramFusesHandler(object sender, EventArgs e)
        {
            if (mCommand == Commands.IDLE)
            {
                clearExitCode();
                mCommand = Commands.PROGRAMFUSES;
            }
        }


        private void buttonCancelHandler(object sender, EventArgs e)
        {
            mCancelOperation = true;
        }

    }
}
