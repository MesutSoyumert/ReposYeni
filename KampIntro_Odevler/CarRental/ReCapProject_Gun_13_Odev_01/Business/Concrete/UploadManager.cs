using Business.Abstract;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UploadManager : IUploadService
    {
        public IDataResult<string> ImageUpload(IFormFile file)
        {
            return FileHelper.ImageUpload(file);
        }
    }
}
