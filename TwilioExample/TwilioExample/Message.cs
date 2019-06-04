using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilioExample
{
    class Message
    {
        public string Id { get; set; }
        public string Sid { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public string RecipientPhone { get; set; }
    }
}
