using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Git_Data.Pages.Api
{
    public class Git : PageModel
    {
        private readonly ILogger<Git> _logger;

        public Git(ILogger<Git> logger)
        {
            _logger = logger;
        }

        // get http request from github api
        public async Task OnGetAsync()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Git_data");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer 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");

            var response = await client.GetAsync("https://api.github.com/users/tckiprotich/repos", HttpCompletionOption.ResponseHeadersRead);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                ViewData["content"] = content;

                // convert the data to json
                var data = JsonConvert.DeserializeObject<List<Models.Repository>>(content);
                var json = JsonConvert.SerializeObject(data, Formatting.Indented);

                // log out the json data
                _logger.LogInformation(json);
            }
            else
            {
                // handle the error
                ViewData["content"] = "Error: " + response.StatusCode.ToString();
            }
        }
    }
}
