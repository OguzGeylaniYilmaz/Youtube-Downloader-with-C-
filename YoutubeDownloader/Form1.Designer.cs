namespace YoutubeDownloader
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
            this.label3 = new System.Windows.Forms.Label();
            this.rdMp3 = new System.Windows.Forms.RadioButton();
            this.rdMp4 = new System.Windows.Forms.RadioButton();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(107, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Youtube MP3/MP4 Downloader";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Video URL :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Format :";
            // 
            // rdMp3
            // 
            this.rdMp3.AutoSize = true;
            this.rdMp3.Location = new System.Drawing.Point(171, 84);
            this.rdMp3.Name = "rdMp3";
            this.rdMp3.Size = new System.Drawing.Size(47, 17);
            this.rdMp3.TabIndex = 3;
            this.rdMp3.TabStop = true;
            this.rdMp3.Text = "MP3";
            this.rdMp3.UseVisualStyleBackColor = true;
            this.rdMp3.CheckedChanged += new System.EventHandler(this.rdMp3_CheckedChanged);
            // 
            // rdMp4
            // 
            this.rdMp4.AutoSize = true;
            this.rdMp4.Location = new System.Drawing.Point(238, 84);
            this.rdMp4.Name = "rdMp4";
            this.rdMp4.Size = new System.Drawing.Size(47, 17);
            this.rdMp4.TabIndex = 4;
            this.rdMp4.TabStop = true;
            this.rdMp4.Text = "MP4";
            this.rdMp4.UseVisualStyleBackColor = true;
            this.rdMp4.CheckedChanged += new System.EventHandler(this.rdMp4_CheckedChanged);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(99, 53);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(278, 20);
            this.txtUrl.TabIndex = 5;
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDownload.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDownload.Location = new System.Drawing.Point(147, 121);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(154, 27);
            this.btnDownload.TabIndex = 6;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(387, 23);
            this.label4.TabIndex = 7;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 191);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.rdMp4);
            this.Controls.Add(this.rdMp3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Youtube Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdMp3;
        private System.Windows.Forms.RadioButton rdMp4;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label4;
    }
}

