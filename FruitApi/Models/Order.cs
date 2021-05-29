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
        public double amount { get; set; }
        public string date { get; set; }//check
        public string pm { get; set; }
        public string placeAddress { get; set; }

        public int fId { get; set; }//f.k
        public int aId { get; set; }//f.k
       
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