using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelManagement.Service
{
    public class RedisCacheManager : ICacheManager
    {
        public T Get<T>(string key)
        {
            throw new NotImplementedException();
        }

        public bool IsExists(string key)
        {
            throw new NotImplementedException();
        }

        public void Set(string key, object value)
        {
            throw new NotImplementedException();
        }
    }
}
