﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using WebAPI.CarImages;
using System.IO;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadsController : ControllerBase
    {
        public static IWebHostEnvironment _webHostEnvironment;

        public FileUploadsController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]

        public string Post([FromForm] FileUpload objectFile)
        {
            try
            {
                if(objectFile.files.Length>0)
                {
                    string path = _webHostEnvironment.WebRootPath + "\\uploads\\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (FileStream fileStream = System.IO.File.Create(path + objectFile.files.FileName ))
                    {
                        objectFile.files.CopyTo(fileStream);
                        fileStream.Flush();
                        return "Uploaded";
                    }
                }
                else
                {
                    return "Not Uploaded";
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
