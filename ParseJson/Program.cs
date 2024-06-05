using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ParseJson;
using ParseJson.Models;

namespace JsonParseExample
{
    class Program
    {
        static void Main()
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "response.json");
            string jsonContent = File.ReadAllText(jsonFilePath);
            ReceiptData receiptData = JsonConvert.DeserializeObject<ReceiptData>(jsonContent);

            foreach (var item in receiptData.Description)
            {
                Console.WriteLine(item.Line + " " + item.Text);
            }
        }
    }
}