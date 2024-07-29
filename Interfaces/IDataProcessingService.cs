using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace components.Interfaces
{
    public interface IDataProcessingService
    {
       
        public Task ProcessFileAsync(string filePath); 
    }
}