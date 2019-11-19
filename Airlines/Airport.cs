using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines {
    class Airport {
        private List<Airplane> planes;

        public List<Airplane> Planes {
            get { return planes; }
            set { planes = value; }
        }

        public Airport(List<Airplane> planes) {
            this.planes = planes;
        }

        public Airplane GetPlaneByNumber(uint flightNumber) {
            Airplane foundPlane = null;
            foreach (var plane in planes) {
                if (plane.FlightNumber == flightNumber)
                    foundPlane = plane;
            }
            return foundPlane;
        }
        public List<Airplane> GetPlanesByTime(DateTime timeFrom) {
            DateTime timeTo = timeFrom.Add(TimeSpan.FromHours(1));
            List<Airplane> foundPlanes = new List<Airplane>();
            foreach (var plane in planes) {
                if (plane.DepartureTime >= timeFrom && plane.DepartureTime <= timeTo)
                    foundPlanes.Add(plane);
            }
            return foundPlanes;
        }
        public List<Airplane> GetPlanesByDestination(string destination) {
            List<Airplane> foundPlanes = new List<Airplane>();
            foreach (var plane in planes) {
                if (plane.Destination == destination)
                    foundPlanes.Add(plane);
            }
            return foundPlanes;
        }
        public bool IsFlightLater(Airplane plane1, Airplane plane2) {
            if (plane1.DepartureTime > plane2.DepartureTime)
                return true;
            else
                return false;
        }
        public void SortPlanesByTime() {
            for (int iterationIndex = 0; iterationIndex < planes.Count; iterationIndex++) {
                for (int planeIndex = 0; planeIndex < planes.Count-1; planeIndex++) {
                    if (IsFlightLater(planes[planeIndex], planes[planeIndex + 1])) {
                        Airplane swapPlane = planes[planeIndex];
                        planes[planeIndex] = planes[planeIndex + 1];
                        planes[planeIndex + 1] = swapPlane;
                    }
                }
            }
        }
        public List<Airplane> SortPlanesByTime(List<Airplane> planes) {
            for (int iterationIndex = 0; iterationIndex < planes.Count; iterationIndex++) {
                for (int planeIndex = 0; planeIndex < planes.Count; planeIndex++) {
                    if (IsFlightLater(planes[planeIndex], planes[planeIndex + 1])) {
                        Airplane swapPlane = planes[planeIndex];
                        planes[planeIndex] = planes[planeIndex + 1];
                        planes[planeIndex + 1] = swapPlane;
                    }
                }
            }
            return planes;
        }
    }
}
