using System;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UVSApi.Models;

namespace SaikasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        // GET api/values
        public IActionResult Get(string city)
        {
            Serializer ser = new Serializer();
            root forecast = new root();

            var webRequest = (HttpWebRequest)WebRequest.Create("http://api.weatherapi.com/v1/forecast.xml?key=564cffa11f6c4c1797f210633200908&q=" + city + "&days=7");
            webRequest.Method = "GET";
            webRequest.UserAgent = "Mozilla/5.0 (Windows NT 5.1; rv:28.0) Gecko/20100101 Firefox/28.0";
            webRequest.ContentLength = 0; // added per comment
            try
            {
                var webResponse = (HttpWebResponse)webRequest.GetResponse();
                if (webResponse.StatusCode != HttpStatusCode.OK) Console.WriteLine("{0}", webResponse.Headers);
                using (StreamReader reader = new StreamReader(webResponse.GetResponseStream()))
                {
                    var xml = reader.ReadToEnd();
                    reader.Close();
                    forecast = ser.Deserialize<root>(xml);
                }
            }
            catch (WebException e)
            {
                using (WebResponse response = e.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;

                    if (httpResponse == null)
                    {
                        return StatusCode(500, "503 Service Unavailable");
                    }
                    using (Stream data = response.GetResponseStream())
                    using (var reader = new StreamReader(data))
                    {
                        string text = reader.ReadToEnd();
                    }
                }
            }
            
            return Ok(forecast); //"Tikiuosi API orų šį karta suveiks, nes dažanai būna nulūžęs ¯\\_(ツ)_/¯"
        }
          }

    internal class Serializer
    {
        public T Deserialize<T>(string input) where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }
    }
}
