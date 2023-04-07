using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportRent.Models {
    public class MockVehicleRepository : IVehicleRepository {

        private readonly ICategoryRepository _categoryVehicles = new MockCategoryRepository();

        public IEnumerable<Vehicle> GetVehicles =>
            new List<Vehicle> {
                new Vehicle() {
                    Id = 1,
                    Image = "https://cdn.pixabay.com/photo/2012/05/29/00/43/car-49278_960_720.jpg",
                    IsAvailable = true,
                    LongDescriptiong = "lorem",
                    Model = "Volvo",
                    ShortDescription = "Cool",
                    Seats = 2,
                    PricePerHour = 30m,
                    Category = _categoryVehicles.GetCategories.ToList()[0]
                },
                new Vehicle() {
                    Id = 2,
                    Image = "https://cdn.pixabay.com/photo/2016/09/11/10/02/renault-juvaquatre-1661009_960_720.jpg",
                    IsAvailable = true,
                    LongDescriptiong = "lorem",
                    Model = "Volvo",
                    ShortDescription = "Cool",
                    Seats = 2,
                    PricePerHour = 20m,
                    Category = _categoryVehicles.GetCategories.ToList()[1]
                },
                new Vehicle() {
                    Id = 3,
                    Image = "https://s.mediasalt.ru/cache/content/data/images/289/289256/original.jpg",
                    IsAvailable = true,
                    LongDescriptiong = "lorem",
                    Model = "Volvo",
                    ShortDescription = "Cool",
                    Seats = 2,
                    PricePerHour = 40m,
                    Category = _categoryVehicles.GetCategories.ToList()[2]
                },
            };

        public IEnumerable<Vehicle> AvailableVehicles => throw new NotImplementedException();

        public Vehicle GetVehicleById(int vehicleId) {
                return GetVehicles.FirstOrDefault(c => c.Id == vehicleId);
        }
            
    }
}
