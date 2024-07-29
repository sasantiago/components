using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace components.Interfaces
{
    public interface IFileUploadService
    {
         Task UploadFile(IFormFile file);
    }
}