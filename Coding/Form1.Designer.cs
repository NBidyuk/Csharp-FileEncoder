namespace Coding
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
            this.FileFindBtn = new System.Windows.Forms.Button();
            this.PathText = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.EncodeBtn = new System.Windows.Forms.RadioButton();
            this.DecodeBtn = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.labelInformation = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileFindBtn
            // 
            this.FileFindBtn.Location = new System.Drawing.Point(55, 16);
            this.FileFindBtn.Name = "FileFindBtn";
            this.FileFindBtn.Size = new System.Drawing.Size(68, 25);
            this.FileFindBtn.TabIndex = 1;
            this.FileFindBtn.Text = "File ...";
            this.FileFindBtn.UseVisualStyleBackColor = true;
            this.FileFindBtn.Click += new System.EventHandler(this.FileFindBtn_Click);
            // 
            // PathText
            // 
            this.PathText.Location = new System.Drawing.Point(144, 21);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(421, 20);
            this.PathText.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(52, 70);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(144, 67);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(210, 20);
            this.PasswordText.TabIndex = 4;
            // 
            // EncodeBtn
            // 
            this.EncodeBtn.AutoSize = true;
            this.EncodeBtn.Checked = true;
            this.EncodeBtn.Location = new System.Drawing.Point(22, 19);
            this.EncodeBtn.Name = "EncodeBtn";
            this.EncodeBtn.Size = new System.Drawing.Size(62, 17);
            this.EncodeBtn.TabIndex = 5;
            this.EncodeBtn.TabStop = true;
            this.EncodeBtn.Text = "Encode";
            this.EncodeBtn.UseVisualStyleBackColor = true;
            this.EncodeBtn.CheckedChanged += new System.EventHandler(this.EncodeBtn_CheckedChanged);
            // 
            // DecodeBtn
            // 
            this.DecodeBtn.AutoSize = true;
            this.DecodeBtn.Location = new System.Drawing.Point(90, 19);
            this.DecodeBtn.Name = "DecodeBtn";
            this.DecodeBtn.Size = new System.Drawing.Size(63, 17);
            this.DecodeBtn.TabIndex = 6;
            this.DecodeBtn.TabStop = true;
            this.DecodeBtn.Text = "Decode";
            this.DecodeBtn.UseVisualStyleBackColor = true;
            this.DecodeBtn.CheckedChanged += new System.EventHandler(this.DecodeBtn_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(55, 117);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(510, 21);
            this.progressBar1.Step = 5;
            this.progressBar1.TabIndex = 7;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(348, 161);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(98, 30);
            this.StartBtn.TabIndex = 8;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Enabled = false;
            this.StopBtn.Location = new System.Drawing.Point(467, 161);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(98, 30);
            this.StopBtn.TabIndex = 9;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(167, 210);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(0, 13);
            this.labelInformation.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EncodeBtn);
            this.groupBox1.Controls.Add(this.DecodeBtn);
            this.groupBox1.Location = new System.Drawing.Point(397, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 51);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 227);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.FileFindBtn);
            this.Name = "Form1";
            this.Text = "Coding Text files";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileFindBtn;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.RadioButton EncodeBtn;
        private System.Windows.Forms.RadioButton DecodeBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

