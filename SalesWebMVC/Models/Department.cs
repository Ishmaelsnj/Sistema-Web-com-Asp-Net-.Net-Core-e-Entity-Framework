using System.Collections.Generic;
using System;
using System.Linq;
using static SalesWebMVC.Models.ViewModels.ErrorViewModel;
using System.ComponentModel.DataAnnotations;
using SalesWebMVC.Models.ViewModels;


namespace SalesWebMVC.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers{ get; set; } = new List <Seller>();

        public Department()
        {
        
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)

        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)

        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
