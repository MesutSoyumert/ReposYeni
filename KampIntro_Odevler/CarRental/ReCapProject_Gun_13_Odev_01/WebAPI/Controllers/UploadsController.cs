using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadsController : ControllerBase
    {
        //TODO: Resim olmayan dosyalar için IUploadService için ayrı bir metot kurulabilir.


        IUploadService _uploadService;

        public UploadsController(IUploadService uploadService)
        {
            _uploadService = uploadService;
        }

        [HttpPost("ImageUpload"), DisableRequestSizeLimit]
        public IActionResult ImageUpload()
        {
            var file = Request.Form.Files[0];
            var result = _uploadService.ImageUpload(file);
            return StatusCode(result.Success ? 200 : 400, result);
        }
    }
}
