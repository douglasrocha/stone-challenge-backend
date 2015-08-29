using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Interfaces
{
    public interface IJsonService
    {
        T GetObjectFromJson<T>(string jsonObject);

        string GetJsonFromObject<T>(T obj);

        IEnumerable<string> GetJsonListFromObject<T>(IEnumerable<T> objList);
    }
}
