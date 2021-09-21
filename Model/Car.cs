using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_Car.Model
{
    // models represents the information of car
    public class Car
    {
        public string Id { get; set; }
        // tells year of car in which manufactured
        [Required ]
        public int Year { get; set; }
        // tells the make of car
        [Required]
        public string Make { get; set; }
        // tells the of model of car
        [Required]
        public string Model { get; set; }
        // tells the price of car
        [Required]
        public decimal Price { get; set; }



    }
}
