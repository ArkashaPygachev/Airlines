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
    public partial class FormAddFlight : Form {
        public FormAddFlight() {
            InitializeComponent();
        }

        private void FormAddFlight_Load(object sender, EventArgs e) {
            Random rnd = new Random();
            string flightNumber = Convert.ToString(rnd.Next(999999));
            tbFlightNumber.Text = flightNumber;
        }

        private void btnAddNewFlight_Click(object sender, EventArgs e) {
            List<Airplane> planes = new List<Airplane>();
            Airplane airplane = new Airplane(tbDestination.Text, Convert.ToUInt32(tbFlightNumber.Text), dtpDepartureTime.Value);
            planes.Add(airplane);
            SaveLoadXML.SaveData(planes);

            Random rnd = new Random();
            string flightNumber = Convert.ToString(rnd.Next(999999));
            tbFlightNumber.Text = flightNumber;
        }
    }
}
