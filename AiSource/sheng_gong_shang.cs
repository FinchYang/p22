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
using Oracle.ManagedDataAccess.Client;
using Microsoft.Extensions.Configuration;

namespace p22.AiSource
{
    public class sheng_gong_shang
    {
        public class rawres
        {
            public int code { get; set; }
            public string data { get; set; }
            public string message { get; set; }
        }
        public class rawmessage
        {
            public int code { get; set; }
            public string data { get; set; }
            public string message { get; set; }
        }

        public class shengyuall
        {
            public List<farendata> baseinfos { get; set; }
            public List<object> cancelinfos { get; set; }
        }
        public class farendata
        {
            public string apprdate { get; set; }
            public string cerno { get; set; }
            public string certype { get; set; }
            public string dom { get; set; }
            public string entname { get; set; }
            public string enttype { get; set; }
            public string enttypecn { get; set; }
            public string estdate { get; set; }
            public string industryco { get; set; }
            public string industryphy { get; set; }
            public string lerep { get; set; }
            public string opfrom { get; set; }
            public string opscope { get; set; }
            public string opto { get; set; }
            public string regcap { get; set; }
            public string regcapcurcn { get; set; }
            public string regno { get; set; }
            public string regorg { get; set; }
            public string regorgcn { get; set; }
            public string regstatecn { get; set; }
            public string tel { get; set; }
            public string uniscid { get; set; }
        }

        public static CommonReturn<farendata> faren(string sfzh)//接口名称： 法定代表人所在企业信息查询//省工商局_企业注册登记信息_公安局
        {
            Console.WriteLine("faren started..." + DateTime.Now);
            var ret = new CommonReturn<farendata> { milliseconds = "7", dataid = dataid.faren, na = true, ok = true, remote = true, message = string.Empty, title = "法定代表人所在企业信息查询", datalist = new List<farendata>() };
            if (string.IsNullOrEmpty(sfzh))
            {
                Console.WriteLine("faren end for not suit conditions");
                return ret;
            }
            else ret.na = false;
            var stop = new Stopwatch();
            stop.Start();
            var url = string.Format("http://10.50.241.24:9009/SD.YTGA/03/SD.YTGA.YZ.GA.ZWZY.SQYZCXX?cerno={0}", sfzh.Trim());
            try
            {
                var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip };
                using (var http = new HttpClient(handler))
                {
                    http.DefaultRequestHeaders.Add("collagen-out_parameters", "_ALL_");
                    http.DefaultRequestHeaders.Add("collagen-debug", "OFF");
                    http.DefaultRequestHeaders.Add("collagen-timeout", "140S");
                    http.DefaultRequestHeaders.Add("collagen-authorize_id", "2366747e909641f69afeabd6cf4a226a");
                    http.DefaultRequestHeaders.Add("apikey", "477144687916875776");
                    http.DefaultRequestHeaders.Add("collagen-proxy_flow_id", "SD.YTGA::01::FLOW_C3_CALL_RESTFUL_PROXY");
                    http.DefaultRequestHeaders.Add("collagen-session_id", "no-session");
                    http.DefaultRequestHeaders.Add("collagen-requester_id", "SD.YTGA.APP.GA.YTLD");
                    var response = http.GetByteArrayAsync(url).Result;
                    string srcString = Encoding.Default.GetString(response, 0, response.Length);
                    //  var rawstr = srcString.Replace("\\", "");
                    Console.WriteLine("response={0}", srcString);
                    var ress = JsonConvert.DeserializeObject<rawres>(srcString);
                    if (ress.code == 200)
                    {
                        Console.WriteLine(ress.data);
                        var re = JsonConvert.DeserializeObject<rawmessage>(ress.data);
                        Console.WriteLine(re.data);//
                        var r = JsonConvert.DeserializeObject<shengyuall>(re.data);
                        if (r.baseinfos != null)
                        {
                            foreach (var a in r.baseinfos)
                            {
                                // var b = JsonConvert.SerializeObject(a);
                                ret.datalist.Add(a);
                                // Console.WriteLine(a);
                            }
                        }
                    }
                    else
                    {
                        ret.ok = false;
                        ret.message = tip + ress.code + ress.message + srcString;
                    }
                }
            }
            catch (Exception ex)
            {
                ret.ok = false;
                ret.message = tip + ex.Message;
                Console.WriteLine(ex);
            }
            stop.Stop();
            ret.milliseconds = stop.ElapsedMilliseconds.ToString();
            if (ret.datalist.Count < 1)
            {
                ret.message += "，没有相关记录";
                ret.ok = false;
            }
            Console.WriteLine("faren end..." + DateTime.Now);
            return ret;
        }
        static string tip = "上游接口没有给出正确结果，请联系管理员协调烟台市政务信息资源共享交换平台解决！";
    }
}