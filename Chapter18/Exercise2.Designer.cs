namespace Chapter18 {
    partial class Exercise2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnTimer = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tmrState = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.tmrCount = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(104, 126);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(75, 23);
            this.btnTimer.TabIndex = 0;
            this.btnTimer.Text = "Timer = off";
            this.btnTimer.UseVisualStyleBackColor = false;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(111, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 23);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Hello";
            // 
            // tmrState
            // 
            this.tmrState.Interval = 1000;
            this.tmrState.Tick += new System.EventHandler(this.tmrState_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(132, 152);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(13, 13);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "0";
            // 
            // tmrCount
            // 
            this.tmrCount.Enabled = true;
            this.tmrCount.Interval = 1;
            this.tmrCount.Tick += new System.EventHandler(this.tmrCount_Tick);
            // 
            // Exercise2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnTimer);
            this.Name = "Exercise2";
            this.Text = "Exercise2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer tmrState;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer tmrCount;
    }
}