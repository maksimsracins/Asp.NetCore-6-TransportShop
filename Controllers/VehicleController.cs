using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportRent.Models;
using TransportRent.ViewModels;

namespace TransportRent.Controllers {
    public class VehicleController : Controller {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly ICategoryRepository _categoryRepository;

        public VehicleController(IVehicleRepository vehicleRepository, ICategoryRepository categoryRepository) {
            _vehicleRepository = vehicleRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List() {
            VehicleListViewModel vehicleListViewModel = new VehicleListViewModel(_vehicleRepository.GetVehicles, "AUTO");
            return View(vehicleListViewModel);
        }
    }
}
