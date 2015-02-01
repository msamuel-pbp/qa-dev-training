using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chapter18 {
    public partial class Exercise3 : Form {
        public Exercise3() {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            txtAmount.Text = String.Empty;
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            try {
                var amount = Convert.ToDecimal(txtAmount.Text);
                var tax = nudTax.Value;
                var taxamount = amount*tax/100;
                var total = amount + taxamount;

                lblResult.Text = String.Format("Tax on ${0} at {1}% is ${2:F}.\nThe total is ${3:F}.",
                    amount, tax, taxamount, total);
            }
            catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }
    }
}