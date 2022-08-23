using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;
using RestSharp;

namespace RestClassLib
{
    public class APIClassLib
    {
        public static string GetMethod()
        {
            var client= new RestClient("https://reqres.in/");
            var request=new RestRequest();
            var response=client.Get(request);
            return(response.Content);
        }
        public static string PostMethod()
        {
            var client= new RestClient("https://reqres.in/");
            var request=new RestRequest();
            var response=client.Post(request);
            return(response.Content);
        }

        public static string PutMethod()
        {
            var client= new RestClient("https://reqres.in/");
            var request=new RestRequest();
            var response=client.Put(request);
            return(response.Content);
        }
    }
}
