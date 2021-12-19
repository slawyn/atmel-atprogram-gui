using System;

namespace AtmelProgrammer
{

    partial class Form1
    {
       
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                mWorkerThreadIsRunning = false;
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelExitCode = new System.Windows.Forms.Label();
            this.buttonFlash = new System.Windows.Forms.Button();
            this.buttonDump = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonLoadElf = new System.Windows.Forms.Button();
            this.tboxFilePath = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxLow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxHigh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxExtended = new System.Windows.Forms.TextBox();
            this.buttonProgramFuses = new System.Windows.Forms.Button();
            this.tboxStatus = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonClearStatus = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.labelExitCode);
            this.panel1.Controls.Add(this.buttonFlash);
            this.panel1.Controls.Add(this.buttonDump);
            this.panel1.Controls.Add(this.buttonErase);
            this.panel1.Controls.Add(this.buttonLoadElf);
            this.panel1.Controls.Add(this.tboxFilePath);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 140);
            this.panel1.TabIndex = 0;
            // 
            // labelExitCode
            // 
            this.labelExitCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelExitCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExitCode.Location = new System.Drawing.Point(450, 66);
            this.labelExitCode.Name = "labelExitCode";
            this.labelExitCode.Size = new System.Drawing.Size(377, 45);
            this.labelExitCode.TabIndex = 20;
            this.labelExitCode.Text = "                    ";
            this.labelExitCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFlash
            // 
            this.buttonFlash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonFlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlash.Location = new System.Drawing.Point(3, 41);
            this.buttonFlash.Name = "buttonFlash";
            this.buttonFlash.Size = new System.Drawing.Size(122, 82);
            this.buttonFlash.TabIndex = 10;
            this.buttonFlash.Text = "Firmware programmieren";
            this.buttonFlash.UseVisualStyleBackColor = false;
            this.buttonFlash.Click += new System.EventHandler(this.buttonFlashHandler);
            // 
            // buttonDump
            // 
            this.buttonDump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonDump.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDump.Location = new System.Drawing.Point(298, 41);
            this.buttonDump.Name = "buttonDump";
            this.buttonDump.Size = new System.Drawing.Size(131, 82);
            this.buttonDump.TabIndex = 9;
            this.buttonDump.Text = "Firmware auslesen";
            this.buttonDump.UseVisualStyleBackColor = false;
            this.buttonDump.Click += new System.EventHandler(this.buttonDumpHandler);
            // 
            // buttonErase
            // 
            this.buttonErase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErase.Location = new System.Drawing.Point(149, 41);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(124, 82);
            this.buttonErase.TabIndex = 10;
            this.buttonErase.Text = "Firmware löschen";
            this.buttonErase.UseVisualStyleBackColor = false;
            this.buttonErase.Click += new System.EventHandler(this.buttonEraseHandler);
            // 
            // buttonLoadElf
            // 
            this.buttonLoadElf.Location = new System.Drawing.Point(762, 13);
            this.buttonLoadElf.Name = "buttonLoadElf";
            this.buttonLoadElf.Size = new System.Drawing.Size(65, 20);
            this.buttonLoadElf.TabIndex = 1;
            this.buttonLoadElf.Text = ".elf laden";
            this.buttonLoadElf.UseVisualStyleBackColor = true;
            this.buttonLoadElf.Click += new System.EventHandler(this.buttonLoadElfHandler);
            // 
            // tboxFilePath
            // 
            this.tboxFilePath.Location = new System.Drawing.Point(3, 13);
            this.tboxFilePath.Name = "tboxFilePath";
            this.tboxFilePath.ReadOnly = true;
            this.tboxFilePath.Size = new System.Drawing.Size(753, 20);
            this.tboxFilePath.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tboxLow);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tboxHigh);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tboxExtended);
            this.panel2.Controls.Add(this.buttonProgramFuses);
            this.panel2.Location = new System.Drawing.Point(883, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 140);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Low";
            // 
            // tboxLow
            // 
            this.tboxLow.Location = new System.Drawing.Point(61, 74);
            this.tboxLow.MaxLength = 2;
            this.tboxLow.Name = "tboxLow";
            this.tboxLow.Size = new System.Drawing.Size(46, 20);
            this.tboxLow.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "High";
            // 
            // tboxHigh
            // 
            this.tboxHigh.Location = new System.Drawing.Point(61, 44);
            this.tboxHigh.MaxLength = 2;
            this.tboxHigh.Name = "tboxHigh";
            this.tboxHigh.Size = new System.Drawing.Size(46, 20);
            this.tboxHigh.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Extended";
            // 
            // tboxExtended
            // 
            this.tboxExtended.Location = new System.Drawing.Point(61, 18);
            this.tboxExtended.MaxLength = 2;
            this.tboxExtended.Name = "tboxExtended";
            this.tboxExtended.Size = new System.Drawing.Size(46, 20);
            this.tboxExtended.TabIndex = 3;
            // 
            // buttonProgramFuses
            // 
            this.buttonProgramFuses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonProgramFuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProgramFuses.Location = new System.Drawing.Point(184, 49);
            this.buttonProgramFuses.Name = "buttonProgramFuses";
            this.buttonProgramFuses.Size = new System.Drawing.Size(128, 74);
            this.buttonProgramFuses.TabIndex = 2;
            this.buttonProgramFuses.Text = "Fuses programmieren";
            this.buttonProgramFuses.UseVisualStyleBackColor = false;
            this.buttonProgramFuses.Click += new System.EventHandler(this.buttonProgramFusesHandler);
            // 
            // tboxStatus
            // 
            this.tboxStatus.Location = new System.Drawing.Point(3, 3);
            this.tboxStatus.Multiline = true;
            this.tboxStatus.Name = "tboxStatus";
            this.tboxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboxStatus.Size = new System.Drawing.Size(1204, 310);
            this.tboxStatus.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tboxStatus);
            this.panel3.Location = new System.Drawing.Point(12, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1210, 316);
            this.panel3.TabIndex = 3;
            // 
            // buttonClearStatus
            // 
            this.buttonClearStatus.Location = new System.Drawing.Point(12, 208);
            this.buttonClearStatus.Name = "buttonClearStatus";
            this.buttonClearStatus.Size = new System.Drawing.Size(61, 20);
            this.buttonClearStatus.TabIndex = 4;
            this.buttonClearStatus.Text = "Löschen";
            this.buttonClearStatus.UseVisualStyleBackColor = true;
            this.buttonClearStatus.Click += new System.EventHandler(this.buttonClearStatusHandler);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(79, 208);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(73, 20);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancelHandler);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1234, 562);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonClearStatus);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "m328p Programmer v0.1 13.02.2020";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tboxFilePath;
        private System.Windows.Forms.Button buttonLoadElf;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tboxStatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonClearStatus;
        private System.Windows.Forms.Button buttonProgramFuses;
        private System.Windows.Forms.TextBox tboxExtended;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxLow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxHigh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDump;
        private System.Windows.Forms.Button buttonFlash;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Label labelExitCode;
        private System.Windows.Forms.Button buttonCancel;
    }
}

