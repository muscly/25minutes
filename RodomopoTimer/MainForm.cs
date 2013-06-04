using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RodomopoTimer
{
    public partial class MainForm : Form
    {
        private DateTime finishTime;
        private Size sizeTopLeftBorder;
        private bool showUi;
        private Random rand = new Random();

        public MainForm()
        {
            InitializeComponent();

            sizeTopLeftBorder = GetTopLeftBorderSize();
            showUi = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            finishTime = DateTime.Now.AddMinutes( 25 );
            //finishTime = DateTime.Now.AddSeconds( 1 );
            timerUpdateLeftTime.Start();
            UpdateLeftTimeLabel();
            HideUi();
        }

        private void timerUpdateLeftTime_Tick(object sender, EventArgs e)
        {
            UpdateLeftTimeLabel();
        }

        private void UpdateLeftTimeLabel()
        {
            TimeSpan diff = 
                finishTime - DateTime.Now;

            if ( diff.Ticks < 0 )
            {
                //---------------------------------------------
                // Complete!!
                labelLeftTime.Text = "00:00";
                timerUpdateLeftTime.Stop();
                timerShake.Start();
                return;
            }

            labelLeftTime.Text = diff.Minutes.ToString("D2") + ":" + diff.Seconds.ToString("D2");
        }

        private void HideUi()
        {
            if (!showUi)
                return;

            this.SuspendLayout();

            this.FormBorderStyle        = FormBorderStyle.None;
            this.buttonStart.Visible    = false;
            this.AllowTransparency      = true;
            this.TransparencyKey        = SystemColors.Control;

            this.Left   += sizeTopLeftBorder.Width;
            this.Top    += sizeTopLeftBorder.Height;

            this.TopMost = true;

            this.ResumeLayout(true);

            showUi = false;
        }

        private void ShowUi()
        {
            if (showUi)
                return;

            this.SuspendLayout();

            this.FormBorderStyle        = FormBorderStyle.FixedToolWindow;
            this.buttonStart.Visible    = true;
            this.AllowTransparency      = false;

            this.Left   -= sizeTopLeftBorder.Width;
            this.Top    -= sizeTopLeftBorder.Height;

            this.TopMost = false;

            this.ResumeLayout(true);

            showUi = true;
        }

        private void labelLeftTime_MouseEnter(object sender, EventArgs e)
        {
            if (timerUpdateLeftTime.Enabled)
            {
                ShowUi();
                timerCheckMouseLeave.Start();
            }

            if (timerShake.Enabled)
            {
                ShowUi();
                timerShake.Stop();
                labelLeftTime.ForeColor = SystemColors.ControlText;
            }
        }

        // WARN: This emthod is not attached to MainForm.MouseLeave
        // because that event doesn't support non-client area.
        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
            if ( timerUpdateLeftTime.Enabled )
                HideUi();
        }

        private Size GetTopLeftBorderSize()
        {
            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            return new Size(screenRectangle.Left - this.Left, screenRectangle.Top - this.Top);
        }

        private void timerCheckMouseLeave_Tick(object sender, EventArgs e)
        {
            Point mousePosition = Cursor.Position;
            if ( mousePosition.X < this.Left || mousePosition.X > this.Right
                || mousePosition.Y < this.Top || mousePosition.Y > this.Bottom)
            {
                timerCheckMouseLeave.Stop();
                MainForm_MouseLeave(this, null);
            }
        }

        private void timerShake_Tick(object sender, EventArgs e)
        {
            this.SuspendLayout();

            Left += rand.Next(-20, 20);
            Top += rand.Next(-20, 20);

            labelLeftTime.ForeColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));

            this.ResumeLayout(true);
        }

    }
}
