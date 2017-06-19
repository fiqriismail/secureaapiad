using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SecureAPIDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public async Task<ActionResult> Index()
        {
            int answer = await AddTwoNumbers(10, 20);
            ViewBag.Answer = answer;
            return View();
        }

        private async Task<int> AddTwoNumbers(int number1, int number2)
        {
           
            string demoServiceUrl = "http://localhost:50447/";
            int answer = 0;


            var calculator = new List<KeyValuePair<string, string>>();
            calculator.Add(new KeyValuePair<string, string>("number1", number1.ToString()));
            calculator.Add(new KeyValuePair<string, string>("number2", number1.ToString()));

            using (var apiClient = new HttpClient())
            {
                string requestUri = String.Format("{0}api/Calculator/Add", demoServiceUrl);
                apiClient.DefaultRequestHeaders.Accept.Clear();
                apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage apiResponse = await apiClient.PostAsync(new Uri(requestUri), new FormUrlEncodedContent(calculator));
                string response = await apiResponse.Content.ReadAsStringAsync();
                answer = int.Parse(response);
                
            }

            return answer;
        }


        private async Task<int> SubstractTwoNumbers(int number1, int number2)
        {

            string demoServiceUrl = "http://localhost:50447/";
            int answer = 0;


            var calculator = new List<KeyValuePair<string, string>>();
            calculator.Add(new KeyValuePair<string, string>("number1", number1.ToString()));
            calculator.Add(new KeyValuePair<string, string>("number2", number1.ToString()));

            using (var apiClient = new HttpClient())
            {
                string requestUri = String.Format("{0}api/Calculator/Substract", demoServiceUrl);
                apiClient.DefaultRequestHeaders.Accept.Clear();
                apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage apiResponse = await apiClient.PostAsync(new Uri(requestUri), new FormUrlEncodedContent(calculator));
                string response = await apiResponse.Content.ReadAsStringAsync();
                answer = int.Parse(response);

            }

            return answer;
        }
    }
}