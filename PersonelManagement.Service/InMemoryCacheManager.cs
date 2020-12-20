using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelManagement.Service
{
    public class InMemoryCacheManager : ICacheManager
    {

        Dictionary<string, object> dict = new Dictionary<string, object>();

        public void Set(string key,object value)
        {
            var json = JsonConvert.SerializeObject(value);

            dict.Add(key, json);
        }

        public bool IsExists(string key)
        {
            return dict.ContainsKey(key);
        }

        public T Get<T>(string key)
        {
            var json = dict.GetValueOrDefault(key);

            var des = JsonConvert.DeserializeObject<T>(key);

            return des;
        }

    }
}
