using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPRequests
{
    public class PostFormat
    {
        public uint userId { get; set; }
        public uint id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        public override string ToString() => $"{userId}\n{id}\n{title}\n{body}\n";
    }
}
