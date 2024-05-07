using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmanCloneLiblary
{
    public class ApiAccess
    {
        public async Task<string> CallApi(string url)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(url);
            string responseBody = await response.Content.ReadAsStringAsync();

            return responseBody;
        }
    }
}
