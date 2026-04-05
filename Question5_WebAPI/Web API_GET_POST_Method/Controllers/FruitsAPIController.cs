using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Web_API_GET_POST_Method.Controllers
{
    //5. Build a simple ASP.NET Core Web API with one GET and one POST method.

    [Route("api/[controller]")]
    [ApiController]
    public class FruitsAPIController : ControllerBase
    {
        public List<string> fruits = new List<string>()
        {
            "Apple",
            "Mango",
            "Guava",
            "Banana",
            "Watermelon"
        };
        //GET Method
        [HttpGet]
        public List<string> GetFruits()
        {
            return fruits;
        }

        //[HttpGet("{id}")]
        //public string GetFruitsByIndex(int id)
        //{
        //    return fruits.ElementAt(id);
        //}

        //POST Method
        [HttpPost]
        public IActionResult AddFruit([FromBody] string fruit)
        {
            fruits.Add(fruit);
            return Ok("Fruit Added Successfully");
        }


    }
}
