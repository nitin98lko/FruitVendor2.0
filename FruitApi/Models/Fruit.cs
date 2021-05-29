using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FruitUserApi.Models
{
    public class Fruit
    {
        [Key]
        public int fId { get; set; }
        public string fName { get; set; }
        public double fPrice { get; set; }
        public int fQty { get; set; }
        public string fImg { get; set; }
        public List<Cart> CartRel { get; set; }
    }
}
/*
 * 
 fId (p.k)=int
fName =string
fPrice =double
fQty =int
fImg =varBinary
 
 */