
namespace SimpleFileCopy
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceFolderText = new System.Windows.Forms.TextBox();
            this.targetFolderText = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.timeIntervalText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sourceOpenBtn = new System.Windows.Forms.Button();
            this.targetOpenBtn = new System.Windows.Forms.Button();
            this.runIndicatorPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.runIndicatorPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target folder:";
            // 
            // sourceFolderText
            // 
            this.sourceFolderText.Location = new System.Drawing.Point(91, 6);
            this.sourceFolderText.Name = "sourceFolderText";
            this.sourceFolderText.Size = new System.Drawing.Size(278, 20);
            this.sourceFolderText.TabIndex = 2;
            this.sourceFolderText.TextChanged += new System.EventHandler(this.sourceFolderText_TextChanged);
            // 
            // targetFolderText
            // 
            this.targetFolderText.Location = new System.Drawing.Point(91, 36);
            this.targetFolderText.Name = "targetFolderText";
            this.targetFolderText.Size = new System.Drawing.Size(278, 20);
            this.targetFolderText.TabIndex = 3;
            this.targetFolderText.TextChanged += new System.EventHandler(this.targetFolderText_TextChanged);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(375, 68);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 34);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // timeIntervalText
            // 
            this.timeIntervalText.Location = new System.Drawing.Point(133, 75);
            this.timeIntervalText.Name = "timeIntervalText";
            this.timeIntervalText.Size = new System.Drawing.Size(95, 20);
            this.timeIntervalText.TabIndex = 6;
            this.timeIntervalText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Copy time interval (ms):";
            // 
            // sourceOpenBtn
            // 
            this.sourceOpenBtn.Location = new System.Drawing.Point(375, 6);
            this.sourceOpenBtn.Name = "sourceOpenBtn";
            this.sourceOpenBtn.Size = new System.Drawing.Size(128, 20);
            this.sourceOpenBtn.TabIndex = 7;
            this.sourceOpenBtn.Text = "Select source folder";
            this.sourceOpenBtn.UseVisualStyleBackColor = true;
            this.sourceOpenBtn.Click += new System.EventHandler(this.sourceOpenBtn_Click);
            // 
            // targetOpenBtn
            // 
            this.targetOpenBtn.Location = new System.Drawing.Point(375, 36);
            this.targetOpenBtn.Name = "targetOpenBtn";
            this.targetOpenBtn.Size = new System.Drawing.Size(128, 20);
            this.targetOpenBtn.TabIndex = 8;
            this.targetOpenBtn.Text = "Select target folder";
            this.targetOpenBtn.UseVisualStyleBackColor = true;
            this.targetOpenBtn.Click += new System.EventHandler(this.targetOpenBtn_Click);
            // 
            // runIndicatorPic
            // 
            this.runIndicatorPic.BackColor = System.Drawing.Color.Tomato;
            this.runIndicatorPic.Location = new System.Drawing.Point(470, 77);
            this.runIndicatorPic.Name = "runIndicatorPic";
            this.runIndicatorPic.Size = new System.Drawing.Size(19, 18);
            this.runIndicatorPic.TabIndex = 9;
            this.runIndicatorPic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 112);
            this.Controls.Add(this.runIndicatorPic);
            this.Controls.Add(this.targetOpenBtn);
            this.Controls.Add(this.sourceOpenBtn);
            this.Controls.Add(this.timeIntervalText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.targetFolderText);
            this.Controls.Add(this.sourceFolderText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple File Copy";
            ((System.ComponentModel.ISupportInitialize)(this.runIndicatorPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sourceFolderText;
        private System.Windows.Forms.TextBox targetFolderText;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox timeIntervalText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sourceOpenBtn;
        private System.Windows.Forms.Button targetOpenBtn;
        private System.Windows.Forms.PictureBox runIndicatorPic;
    }
}

