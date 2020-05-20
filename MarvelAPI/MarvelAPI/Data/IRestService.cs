using MarvelAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarvelAPI.Data
{
   public interface IRestService
    {
        Task<List<Marvel>> RefreshDataAsync();
    }
}
