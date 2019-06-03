using System;
using System.Net;
using Newtonsoft.Json;
//instalo desde la consola: dotnet add package Newtonsoft.Json

namespace myRest
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://localizacajero.firebaseio.com/cajeros.json";
            var json = new WebClient().DownloadString(url);
            dynamic m = JsonConvert.DeserializeObject(json);
            
            //Console.WriteLine(json); Retorna el objeto
                                 
            foreach(var i in m){
                Console.WriteLine(i.direccion);
            }                       
        }
    }
}