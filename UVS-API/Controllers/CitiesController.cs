using Microsoft.AspNetCore.Mvc;
using System.IO;
using Newtonsoft.Json;


namespace UVSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        // GET api/values
        public IActionResult Get()
        {
            using (StreamReader sr = System.IO.File.OpenText("./cities.json"))
            {
                var myObject = JsonConvert.DeserializeObject<object>(sr.ReadToEnd());
                return Ok(myObject);
            }
        }
    }
}
