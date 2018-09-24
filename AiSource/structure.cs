using Microsoft.AspNetCore.SignalR;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace p22.AiSource
{
   public enum dataid{
       hunyi,zigezhengshu,yiyuanyaodian,nongbaocanbao,   chushengzhengming,
       canbaozhigong,binzanghuohua,yanglaolishi,waiguoren,shengyu,
       faren
       }
          public class birth
        {
            public string fqxm { get; set; }
            public string xsexm { get; set; }
            public string mqsfzhm { get; set; }
            public string bh { get; set; }
            public string xsecsrq { get; set; }
            public string mqxm { get; set; }
            public string qfjgmc { get; set; }
            public string fqsfzhm { get; set; }
        }
    public class CommonReturn<T>
    {
        public bool na { get; set; }
        public bool ok { get; set; }
        public bool remote { get; set; }
        public string title { get; set; }
         public dataid dataid { get; set; }
        public string message { get; set; }
        public string milliseconds { get; set; }
        public List<T> datalist { get; set; }
    }
}