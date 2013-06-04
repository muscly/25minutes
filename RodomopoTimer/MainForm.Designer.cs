namespace RodomopoTimer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.labelLeftTime = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerUpdateLeftTime = new System.Windows.Forms.Timer(this.components);
            this.timerCheckMouseLeave = new System.Windows.Forms.Timer(this.components);
            this.timerShake = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelLeftTime
            // 
            this.labelLeftTime.AutoSize = true;
            this.labelLeftTime.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeftTime.Location = new System.Drawing.Point(12, 9);
            this.labelLeftTime.Name = "labelLeftTime";
            this.labelLeftTime.Size = new System.Drawing.Size(112, 48);
            this.labelLeftTime.TabIndex = 0;
            this.labelLeftTime.Text = "00:00";
            this.labelLeftTime.MouseEnter += new System.EventHandler(this.labelLeftTime_MouseEnter);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(131, 9);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(83, 48);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "&Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerUpdateLeftTime
            // 
            this.timerUpdateLeftTime.Interval = 1000;
            this.timerUpdateLeftTime.Tick += new System.EventHandler(this.timerUpdateLeftTime_Tick);
            // 
            // timerCheckMouseLeave
            // 
            this.timerCheckMouseLeave.Interval = 300;
            this.timerCheckMouseLeave.Tick += new System.EventHandler(this.timerCheckMouseLeave_Tick);
            // 
            // timerShake
            // 
            this.timerShake.Interval = 50;
            this.timerShake.Tick += new System.EventHandler(this.timerShake_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 65);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelLeftTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Rodomopo Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLeftTime;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerUpdateLeftTime;
        private System.Windows.Forms.Timer timerCheckMouseLeave;
        private System.Windows.Forms.Timer timerShake;
    }
}

