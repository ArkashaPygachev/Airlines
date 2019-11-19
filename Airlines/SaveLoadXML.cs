using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Airlines {
    class SaveLoadXML {
        private static string fileName = "AirportData.xml";

        public static void SaveData(List<Airplane> planes) {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fileName);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (var plane in planes) {
                XmlElement airplaneElem = xDoc.CreateElement("plane");

                XmlElement flightNumberElem = xDoc.CreateElement("flightNumber");
                XmlElement destinationElem = xDoc.CreateElement("destination");
                XmlElement departureTimeElem = xDoc.CreateElement("departureTime");

                XmlText flightNumberText = xDoc.CreateTextNode(Convert.ToString(plane.FlightNumber));
                XmlText destinationText = xDoc.CreateTextNode(plane.Destination);
                XmlText departureTimeText = xDoc.CreateTextNode(plane.DepartureTime.ToString());

                flightNumberElem.AppendChild(flightNumberText);
                destinationElem.AppendChild(destinationText);
                departureTimeElem.AppendChild(departureTimeText);

                airplaneElem.AppendChild(flightNumberElem);
                airplaneElem.AppendChild(destinationElem);
                airplaneElem.AppendChild(departureTimeElem);

                xRoot.AppendChild(airplaneElem);
            }
            xDoc.Save(fileName);
        }
        public static List<Airplane> LoadData() {
            List<Airplane> planes = new List<Airplane>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fileName);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot) {
                string destination = null;
                uint flightNumber = new uint();
                DateTime departureTime = new DateTime();
                foreach (XmlNode childnode in xnode.ChildNodes) {
                    if (childnode.Name == "flightNumber") {
                        flightNumber = Convert.ToUInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "destination") {
                        destination = childnode.InnerText;
                    }
                    if (childnode.Name == "departureTime") {
                        departureTime = Convert.ToDateTime(childnode.InnerText);
                    }
                }
                Airplane plane = new Airplane(destination, flightNumber, departureTime);
                planes.Add(plane);
            }
            return planes;
        }
    }
}
