using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Light.Core
{
    public interface IConfigProvider
    {
        void Init();
        string GetValue(string key);
        string SetValue(string key, string value);
    }
}
