using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetShop.Models
{
    public class Pet
    {
        public int ID { get; set; }

        [Display(Name = "Image URL")]
        [DataType(DataType.ImageUrl)]
        public String imageUrl { get; set; }
        [Display(Name = "Name")]
        public String name { get; set; }

        [Display(Name = "Date Recieved")]
        [DataType(DataType.Date)]
        public DateTime dateRecieved { get; set; }

        [Display(Name = "Short Description")]
        public String descriptionShort { get; set; }

        [Display(Name = "Full Description")]
        public String descriptionFull { get; set; }

        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public decimal price { get; set; }

        [Display(Name = "Quantity")]
        public int quantity { get; set; }
    }

    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
    }
}
