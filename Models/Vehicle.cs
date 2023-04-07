using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportRent.Models {
    public class Vehicle {
        public int Id { get; set; }
        public string Model { get; set; }
        public decimal PricePerHour { get; set; }
        public int Seats { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescriptiong { get; set; }
        public string Image { get; set; }
        public bool IsAvailable { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
