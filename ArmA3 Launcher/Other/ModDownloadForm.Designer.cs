namespace ArmA3_Launcher
{
    partial class ModDownloadForm
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
            this.Exile_Download = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cancel_Download_Btn0 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cancel_Download_Btn1 = new System.Windows.Forms.Button();
            this.A3_Epoch_Download = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exile_Download
            // 
            this.Exile_Download.Location = new System.Drawing.Point(602, 14);
            this.Exile_Download.Name = "Exile_Download";
            this.Exile_Download.Size = new System.Drawing.Size(75, 23);
            this.Exile_Download.TabIndex = 0;
            this.Exile_Download.Text = "Download";
            this.Exile_Download.UseVisualStyleBackColor = true;
            this.Exile_Download.Click += new System.EventHandler(this.Exile_Download_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(2, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(686, 26);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ExileMod - (0.9.18)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cancel_Download_Btn0);
            this.groupBox1.Controls.Add(this.Exile_Download);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 45);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Cancel_Download_Btn0
            // 
            this.Cancel_Download_Btn0.Location = new System.Drawing.Point(521, 14);
            this.Cancel_Download_Btn0.Name = "Cancel_Download_Btn0";
            this.Cancel_Download_Btn0.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Download_Btn0.TabIndex = 3;
            this.Cancel_Download_Btn0.Text = "Cancel";
            this.Cancel_Download_Btn0.UseVisualStyleBackColor = true;
            this.Cancel_Download_Btn0.Click += new System.EventHandler(this.Cancel_Download_Btn0_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Cancel_Download_Btn1);
            this.groupBox2.Controls.Add(this.A3_Epoch_Download);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(2, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 45);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // Cancel_Download_Btn1
            // 
            this.Cancel_Download_Btn1.Location = new System.Drawing.Point(521, 14);
            this.Cancel_Download_Btn1.Name = "Cancel_Download_Btn1";
            this.Cancel_Download_Btn1.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Download_Btn1.TabIndex = 2;
            this.Cancel_Download_Btn1.Text = "Cancel";
            this.Cancel_Download_Btn1.UseVisualStyleBackColor = true;
            this.Cancel_Download_Btn1.Click += new System.EventHandler(this.Cancel_Download_Btn1_Click);
            // 
            // A3_Epoch_Download
            // 
            this.A3_Epoch_Download.Location = new System.Drawing.Point(602, 14);
            this.A3_Epoch_Download.Name = "A3_Epoch_Download";
            this.A3_Epoch_Download.Size = new System.Drawing.Size(75, 23);
            this.A3_Epoch_Download.TabIndex = 0;
            this.A3_Epoch_Download.Text = "Download";
            this.A3_Epoch_Download.UseVisualStyleBackColor = true;
            this.A3_Epoch_Download.Click += new System.EventHandler(this.A3_Epoch_Download_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "A3 Epoch - (0.3.3.1)";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // ModDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(691, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.MaximizeBox = false;
            this.Name = "ModDownloadForm";
            this.Text = "ArmA3 Launcher";
            this.Load += new System.EventHandler(this.ModDownloadForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Exile_Download;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button A3_Epoch_Download;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Cancel_Download_Btn0;
        private System.Windows.Forms.Button Cancel_Download_Btn1;
    }
}