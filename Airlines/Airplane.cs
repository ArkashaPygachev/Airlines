using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines {
    class Airplane {
        private string destination;
        private uint flightNumber;
        private DateTime departureTime;

        public string Destination {
            get { return destination; }
            set { destination = value; }
        }
        public uint FlightNumber {
            get { return flightNumber; }
            set {
                if (value <= 999999)
                    flightNumber = value;
                else
                    throw new System.ArgumentException("Flight number has a six-digit format");
            }
        }
        public DateTime DepartureTime {
            get { return departureTime; }
            set { departureTime = value; }
        }

        public Airplane(string destination, uint flightNumber, DateTime departureTime) {
            this.destination = destination;
            FlightNumber = flightNumber;
            this.departureTime = departureTime;
        }
    }
}
