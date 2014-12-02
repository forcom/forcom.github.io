using System;
using System.Threading.Tasks;

namespace Itazuraya.Services
{
    public class MainService
    {
        public async Task<string> GetResult()
        {
            return await Task.FromResult("result");
        }
    }
}