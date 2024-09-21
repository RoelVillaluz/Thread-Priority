namespace _04Task_Performance
{
    partial class FrmTrackThread
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblThread = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // lblThread
            // 
            lblThread.AutoSize = true;
            lblThread.Font = new Font("Segoe UI", 19F);
            lblThread.Location = new Point(99, 38);
            lblThread.Name = "lblThread";
            lblThread.Size = new Size(184, 36);
            lblThread.TabIndex = 0;
            lblThread.Text = "-Thread starts-";
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Segoe UI", 14F);
            btnRun.Location = new Point(139, 119);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(106, 41);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // FrmTrackThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 218);
            Controls.Add(btnRun);
            Controls.Add(lblThread);
            Name = "FrmTrackThread";
            Text = "FrmTrackThread";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThread;
        private Button btnRun;
    }
}
