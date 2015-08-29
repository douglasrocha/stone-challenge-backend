using Infrastructure.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class JsonService : IJsonService
    {
        public T GetObjectFromJson<T>(string jsonObject)
        {
            return JsonConvert.DeserializeObject<T>(jsonObject);
        }

        public string GetJsonFromObject<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public IEnumerable<string> GetJsonListFromObject<T>(IEnumerable<T> objList)
        {
            IList<string> outputList = new List<string>(objList.Count());

            foreach (var t in objList)
            {
                outputList.Add(JsonConvert.SerializeObject(t));
            }

            return outputList;
        }
    }
}
