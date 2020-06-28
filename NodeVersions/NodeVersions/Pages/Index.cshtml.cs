using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace NodeVersions.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string NodeVersion { get; set; }
        public string NpmVersion { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (!System.IO.File.Exists("node.txt"))
            {
                NodeVersion = "Unknown";
            }
            else
            {
                NodeVersion = System.IO.File.ReadAllText("node.txt");
            }

            if (!System.IO.File.Exists("npm.txt"))
            {
                NpmVersion = "Unknown";
            }
            else
            {
                NpmVersion = System.IO.File.ReadAllText("npm.txt");
            }

        }
    }
}
