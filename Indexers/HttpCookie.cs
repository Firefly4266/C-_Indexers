using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class HttpCookie
    {
        private readonly Dictionary<string, string> dictionary;
        
        public HttpCookie()
        {
            dictionary = new Dictionary<string, string>();
        }
        public string this[string key]
        {
            get { return dictionary[key]; }
            set { dictionary[key] = value; }

        }
    }
}
