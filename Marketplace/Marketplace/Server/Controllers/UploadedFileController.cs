using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Marketplace.Shared;
using System.IO;
using System.Drawing;
using System.Net.Http;

namespace Marketplace.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadedFileController : ControllerBase
    {
        private readonly IWebHostEnvironment env;

        public UploadedFileController(IWebHostEnvironment env)
        {
            this.env = env;
        }

        [HttpPost]
        public void Post(UploadedFile uploadedFile)
        {
            var path = $"{env.WebRootPath}\\{uploadedFile.FileName}";
            var fs = System.IO.File.Create(path);
            fs.Write(uploadedFile.FileContent, 0,uploadedFile.FileContent.Length);
            fs.Close();
        }

        
        [HttpGet]
        public IActionResult Get([FromQuery]string imageName)
        {
            var path = $"{env.WebRootPath}\\{imageName}";
            Byte[] b = System.IO.File.ReadAllBytes(path);         
            return File(b, "image/png");
        }

    }
}
