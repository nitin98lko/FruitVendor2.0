using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FruitUserApi.Models
{
    public class Author
    {
        [Key]
        public int aId { get; set; }
        public string uName { get; set; }
        public string pass { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public long mobNum { get; set; }
        //public string roles { get; set; }
        public List<Cart> CartRel { get; set; }
    }
}
/*
aId(p.k)=int
uName=string
pass=string
gender=string
email=string
mobNum=long
 */