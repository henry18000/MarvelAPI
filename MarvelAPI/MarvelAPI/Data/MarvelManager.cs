using MarvelAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarvelAPI.Data
{
    public class MarvelManager
    {
        IRestService restService;
        public MarvelManager(IRestService service)
        {
            restService = service;
        }

        public Task<List<Marvel>> GetTasksAsync()
        {
            return restService.RefreshDataAsync();
        }
    }
}
