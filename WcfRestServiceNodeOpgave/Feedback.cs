using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfRestServiceNodeOpgave
{
    public class Feedback
    {
        public int id { get; set; }
        public string title { get; set; }
        public string message { get; set; }
        public string name { get; set; }
    }
}