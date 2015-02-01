using System;
using System.Deployment.Internal;
using System.Windows.Forms;

namespace Chapter18 {
    public partial class Exercise2 : Form {
        private DateTime start = DateTime.Now;

        public Exercise2() {
            InitializeComponent();
        }

        private void tmrCount_Tick(object sender, EventArgs e) {
            if (tmrState.Enabled) {
                lblTimer.Text = Math.Round((DateTime.Now - start).TotalSeconds, 2, MidpointRounding.AwayFromZero).ToString("F2");
            }
            else {
                start = DateTime.Now;
            }
        }

        private void tmrState_Tick(object sender, EventArgs e) {
            if (lblStatus.Text.Equals("Hello")) {
                lblStatus.Text = "GoodBye";
            }
            else {
                lblStatus.Text = "Hello";
            }
        }

        private void btnTimer_Click(object sender, EventArgs e) {
            tmrState.Enabled = !tmrState.Enabled;
            btnTimer.Text = String.Format(tmrState.Enabled ? "Timer is on" : "Timer is off");
        }
    }
}