using FruitUserApi.Models;
using FruitUserApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitUserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {

        UserRepository repo = null;
        public AuthorController()
        {
            repo = new UserRepository();
        }

        [HttpGet]
        public ActionResult GetAllFruits()
        {
            List<Author> list = repo.GetAll();
            return Ok(list);
        }
    }
}
