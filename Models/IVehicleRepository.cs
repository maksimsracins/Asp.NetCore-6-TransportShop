using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportRent.Models {
    public interface IVehicleRepository {
        IEnumerable<Vehicle> GetVehicles { get; }
        IEnumerable<Vehicle> AvailableVehicles { get; }
        Vehicle GetVehicleById(int vehicleId);
    }
}
