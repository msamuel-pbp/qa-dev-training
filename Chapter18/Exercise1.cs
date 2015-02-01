using System;
using System.Windows.Forms;

namespace Chapter18 {
    public partial class Exercise1 : Form {
        public Exercise1() {
            InitializeComponent();
        }

        private void btnStatus_Click(object sender, EventArgs e) {
            lblStatus.Text = "GoodBye";
        }
    }
}