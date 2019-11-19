using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airlines {
    public partial class Airlines : Form {
        public Airlines() {
            InitializeComponent();
        }

        private void btnAddNewFlightWindow_Click(object sender, EventArgs e) {
            FormAddFlight formAddFlight = new FormAddFlight();
            formAddFlight.Show();
        }

        private void btnAddFlight_Click(object sender, EventArgs e) {
            if(rdbSearchByDestination.Checked == true) {
                FormSearchRes formSearchRes = new FormSearchRes(tbSearchArg.Text);
                formSearchRes.Show();
            }
            if(rdbSearchByNumber.Checked == true) {
                FormSearchRes formSearchRes = new FormSearchRes(Convert.ToUInt32(tbSearchArg.Text));
                formSearchRes.Show();
            }
            if(rdbSearchByTime.Checked == true) {
                FormSearchRes formSearchRes = new FormSearchRes(dtpSearchArgs.Value);
                formSearchRes.Show();
            }
            tbSearchArg.Clear();
        }

        private void rdbSearchByTime_CheckedChanged(object sender, EventArgs e) {
            tbSearchArg.Visible = false;
            dtpSearchArgs.Visible = true;
        }

        private void rdbSearchByNumber_CheckedChanged(object sender, EventArgs e) {
            tbSearchArg.Visible = true;
            dtpSearchArgs.Visible = false;
        }

        private void rdbSearchByDestination_CheckedChanged(object sender, EventArgs e) {
            tbSearchArg.Visible = true;
            dtpSearchArgs.Visible = false;
        }
    }
}
