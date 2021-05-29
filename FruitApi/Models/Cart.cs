using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FruitUserApi.Models
{
    public class Cart
    {

        [Key]
        public int cId { get; set; }

        public int cQty { get; set; }

        public double amount { get; set; }

        public int fId { get; set; }//f.k
        public Fruit fruit { get; set; }


        public int aId { get; set; }//f.k
        public Author author { get; set; }

    }
}

/*
cId (p.k)=int
fId (F.k)=int
cQty =int
uid (F.k)=int
amount =double

 
 */