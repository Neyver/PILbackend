using Newtonsoft.Json;
using PILBackend.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PILBackend.Collection
{
    public class ProductCollection
    {
        public List<Product> products { get; set; }

        public void updateList ()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "data.json");

            var jsonString = File.ReadAllText(@"C:\Users\Neyver\Documents\Visual Studio 2017\Backup Files\MOCK_DATA.json");
            this.products = (List<Product>)JsonConvert.DeserializeObject<List<Product>>(jsonString);
        }
    }
}