using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PostmanCloneLiblary
{
    public class ApiAccess
    {
       private readonly HttpClient client = new();

        public async Task<string> CallApiAsync(string url, 
            bool formatOutput = true,HttpAction action = HttpAction.GET)
        {

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                if (formatOutput)
                {
                    JsonElement jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                    json = JsonSerializer.Serialize(jsonElement,
                        new JsonSerializerOptions { WriteIndented = true });
                }
                return json;
            }   
            return $"Error + { response.StatusCode }";
        }
    }
}
