using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelManagement.Service
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        bool IsExists(string key);
        void Set(string key, object value);

    }
}
