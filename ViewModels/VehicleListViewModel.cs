using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportRent.Models;

namespace TransportRent.ViewModels {
    public class VehicleListViewModel {
        public  IEnumerable<Vehicle> Vehicles;
        public  string? CurrentCategory;

        public VehicleListViewModel(IEnumerable<Vehicle> vehicleRepository, string? currentCategory) {
            Vehicles = vehicleRepository;
            CurrentCategory = currentCategory;
        }
    }
}
