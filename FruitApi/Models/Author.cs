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
        [Required]
        public string uName { get; set; }
        [Required]
        public string pass { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
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