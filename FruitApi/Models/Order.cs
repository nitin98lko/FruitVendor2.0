using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FruitUserApi.Models
{
    public class Order
    {
        [Key]
        public int oId { get; set; }
        [Required]
        public double amount { get; set; }
        [Required]
        public string date { get; set; }//check
        [Required]
        public string pm { get; set; }
        [Required]
        public string placeAddress { get; set; }
        [Required]
        public int fId { get; set; }//f.k
        [Required]
        public int aId { get; set; }//f.k
        //[Required]
        //public int qty { get; set; }//f.k

    }
}
/*
oId(p.k)=int
fId =int
amount=double
aId =int
date=date
pm=string
placeAddress=string
 
 */