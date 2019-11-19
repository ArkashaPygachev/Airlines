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
    public partial class FormSearchRes : Form {
        Airport airport;
        public FormSearchRes(string destination) {
            InitializeComponent();
            airport = new Airport(SaveLoadXML.LoadData());
            airport.Planes = airport.GetPlanesByDestination(destination);
            airport.SortPlanesByTime();
            foreach (var plane in airport.Planes) {
                ListViewItem lvi = new ListViewItem(Convert.ToString(plane.FlightNumber));
                lvi.SubItems.Add(plane.Destination);
                lvi.SubItems.Add(plane.DepartureTime.ToString());
                lvSearchRes.Items.Add(lvi);
            }
        }
        public FormSearchRes(uint flightNumber) {
            InitializeComponent();
            airport = new Airport(SaveLoadXML.LoadData());
            Airplane plane = airport.GetPlaneByNumber(flightNumber);

            ListViewItem lvi = new ListViewItem(Convert.ToString(plane.FlightNumber));
            lvi.SubItems.Add(plane.Destination);
            lvi.SubItems.Add(plane.DepartureTime.ToString());
            lvSearchRes.Items.Add(lvi);
        }
        public FormSearchRes(DateTime departureTime) {
            InitializeComponent();
            airport = new Airport(SaveLoadXML.LoadData());
            airport.Planes = airport.GetPlanesByTime(departureTime);
            airport.SortPlanesByTime();
            foreach (var plane in airport.Planes) {
                ListViewItem lvi = new ListViewItem(Convert.ToString(plane.FlightNumber));
                lvi.SubItems.Add(plane.Destination);
                lvi.SubItems.Add(plane.DepartureTime.ToString());
                lvSearchRes.Items.Add(lvi);
            }
        }
    }
}
