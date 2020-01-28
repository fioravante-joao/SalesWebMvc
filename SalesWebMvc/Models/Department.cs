using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        /***********Construtor Sem Argumentos**********/
        public Department()
        {

        }

        /*******Construtor Com Argumentos*******/
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /*Método que add um Vendedor ao departamento*/
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
