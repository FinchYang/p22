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
    public class FromShare// 于树红, 370602197912051347
    {
        public class rawres<T>
        {
            public int code { get; set; }
            public rawmessage<T> data { get; set; }
            public string message { get; set; }
        }
        public class rawmessage<T>
        {
            public string msg { get; set; }
            public string code { get; set; }
            public List<T> data { get; set; }
            public string error { get; set; }
        }

        public class shengyuall
        {
            public int code { get; set; }
            public string data { get; set; }
            public string message { get; set; }
        }
        public class shengyuinner
        {
            public int status { get; set; }
            public string message { get; set; }

            public List<shengyu> data { get; set; }
        }
        public class shengyu
        {
            public string mothername { get; set; }
            public string motherid { get; set; }
            public string motherdomicileaddress { get; set; }
            public string motherworkplace { get; set; }
            public string mothermaritalstatus { get; set; }
            public string fathername { get; set; }
            public string fatherid { get; set; }
            public string fatherdomicileaddress { get; set; }
            public string fatherworkplace { get; set; }
            public string fathermaritalstatus { get; set; }
            public string birthmanageplace { get; set; }
            public string childorder { get; set; }
            public string birthdate { get; set; }
            public string childsex { get; set; }
            public string polcyattribute { get; set; }
            public string birthrecordnumber { get; set; }
            public string registerplace { get; set; }
            public string ordernumber { get; set; }
            public string registtime { get; set; }
            public string marryregisttime { get; set; }
            public List<object> children { get; set; }
        }
        public static CommonReturn<shengyu> shengyusearch(string name, string sfzh)
        {
            Console.WriteLine("shengyusearch started..." + DateTime.Now);
            var ret = new CommonReturn<shengyu> { milliseconds = "7", dataid = dataid.shengyu, na = true, ok = true, remote = true, message = string.Empty, title = "生育服务", datalist = new List<shengyu>() };
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(sfzh))
            {
                Console.WriteLine("shengyusearch end for not suit conditions");
                return ret;
            }
            else ret.na = false;
            var stop = new Stopwatch();
            stop.Start();
            var url = string.Format("http://10.50.241.24:9009/SD.YTGA/03/SD.YTGA.YZ.GA.ZWZY.ZWSYSC?personName={0}&personId={1}",
            string.IsNullOrEmpty( name)?"":name.Trim(),
             string.IsNullOrEmpty(sfzh)?"":sfzh.Trim());
            try
            {
                var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip };
                using (var http = new HttpClient(handler))
                {
                    http.DefaultRequestHeaders.Add("collagen-out_parameters", "_ALL_");
                    http.DefaultRequestHeaders.Add("collagen-debug", "OFF");
                    http.DefaultRequestHeaders.Add("collagen-timeout", "140S");
                    http.DefaultRequestHeaders.Add("collagen-authorize_id", "2366747e909641f69afeabd6cf4a226a");
                    http.DefaultRequestHeaders.Add("apikey", "491523572267745280");
                    http.DefaultRequestHeaders.Add("collagen-proxy_flow_id", "SD.YTGA::01::FLOW_C3_CALL_RESTFUL_PROXY");
                    http.DefaultRequestHeaders.Add("collagen-session_id", "no-session");
                    http.DefaultRequestHeaders.Add("collagen-requester_id", "SD.YTGA.APP.GA.YTLD");
                    var response = http.GetByteArrayAsync(url).Result;
                    string srcString = Encoding.Default.GetString(response, 0, response.Length);
                    //  var rawstr = srcString.Replace("\\", "");
                    Console.WriteLine("response={0}", srcString);
                    var ress = JsonConvert.DeserializeObject<shengyuall>(srcString);
                    if (ress.code == 200)
                    {
                        Console.WriteLine("data={0}", ress.data);
                        var inner = JsonConvert.DeserializeObject<shengyuall>(ress.data);
                        Console.WriteLine("inner data={0}", inner.data);
                        if (inner.code == 200)
                        {
                            Console.WriteLine("three data={0}", inner.data);
                            var three = JsonConvert.DeserializeObject<shengyuinner>(inner.data);
                            foreach (var bb in three.data)
                            {
                                var aa = JsonConvert.SerializeObject(bb);
                                Console.WriteLine("one data={0}", aa);
                                ret.datalist.Add(bb);
                            }
                        }
                    }
                    else
                    {
                        ret.ok = false;
                        ret.message = ress.message + srcString;
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
            Console.WriteLine("shengyusearch end..." + DateTime.Now);
            return ret;
        }

        public static CommonReturn<birth> birthsearch(string fqxm, string mqxm, string fqsfzhm, string mqsfzhm, string xsexm)
        {
            Console.WriteLine("birthsearch started..." + DateTime.Now);
            var ret = new CommonReturn<birth> { milliseconds = "7", dataid = dataid.chushengzhengming, na = true, ok = true, remote = true, message = string.Empty, title = "出生医学证明", datalist = new List<birth>() };
            if (string.IsNullOrEmpty(fqxm) && string.IsNullOrEmpty(mqxm) && string.IsNullOrEmpty(fqsfzhm) && string.IsNullOrEmpty(mqsfzhm) && string.IsNullOrEmpty(xsexm))
            {
                Console.WriteLine("birthsearch end for not suit conditions");
                return ret;
            }
            else ret.na = false;
            var stop = new Stopwatch();
            stop.Start();
            var url = string.Format("http://10.50.241.24:9009/SD.YTGA/03/SD.YTGA.YZ.GA.ZWZY.WJWCSZM?fqxm={0}&mqxm={1}&fqsfzhm={2}&mqsfzhm={3}&xsexm={4}",
            string.IsNullOrEmpty(fqxm) ? "" : fqxm.Trim(), string.IsNullOrEmpty(mqxm) ? "" : mqxm.Trim(),
            string.IsNullOrEmpty(fqsfzhm) ? "" : fqsfzhm.Trim(), string.IsNullOrEmpty(mqsfzhm) ? "" : mqsfzhm.Trim(),
            string.IsNullOrEmpty(xsexm) ? "" : xsexm.Trim());
            try
            {
                var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip };
                using (var http = new HttpClient(handler))
                {
                    http.DefaultRequestHeaders.Add("collagen-out_parameters", "_ALL_");
                    http.DefaultRequestHeaders.Add("collagen-debug", "OFF");
                    http.DefaultRequestHeaders.Add("collagen-timeout", "140S");
                    http.DefaultRequestHeaders.Add("collagen-authorize_id", "2366747e909641f69afeabd6cf4a226a");
                    http.DefaultRequestHeaders.Add("apikey", "480051493735497728");
                    http.DefaultRequestHeaders.Add("collagen-proxy_flow_id", "SD.YTGA::01::FLOW_C3_CALL_RESTFUL_PROXY");
                    http.DefaultRequestHeaders.Add("collagen-session_id", "no-session");
                    http.DefaultRequestHeaders.Add("collagen-requester_id", "SD.YTGA.APP.GA.YTLD");
                    var response = http.GetByteArrayAsync(url).Result;
                    string srcString = Encoding.Default.GetString(response, 0, response.Length);
                    //  var rawstr = srcString.Replace("\\", "");
                    Console.WriteLine("response={0}", srcString);
                    var ress = JsonConvert.DeserializeObject<rawres<birth>>(srcString);
                    if (ress.code == 200)
                    {
                        Console.WriteLine("data={0}", ress.data);
                        // var inner = JsonConvert.DeserializeObject<rawmessage>(ress.data);
                        if (ress.data.code == "200")
                        {
                            foreach (var a in ress.data.data)
                            {
                                ret.datalist.Add(a);
                            }
                        }
                        else
                        {
                            ret.ok = false;
                            ret.message = ress.data.error + ress.data.msg + srcString;
                        }
                    }
                    else
                    {
                        ret.ok = false;
                        ret.message = ress.message + srcString;
                    }
                }
            }
            catch (Exception ex)
            {
                ret.ok = false;
                ret.message = tip + ex.Message;
            }
            stop.Stop();
            ret.milliseconds = stop.ElapsedMilliseconds.ToString();
            if (ret.datalist.Count < 1)
            {
                ret.message += "，没有相关记录";
                ret.ok = false;
            }
            Console.WriteLine("birthsearch end..." + DateTime.Now);
            return ret;
        }

        public class foreigner
        {
            public string GZXKZBH { get; set; }
            public string SQRX { get; set; }
            public string GJ { get; set; }
            public string YXQQSRQ { get; set; }
            public string SQRCSRQ { get; set; }
            public string YRDW { get; set; }
            public string YXQZZRQ { get; set; }
            public string SQRXB { get; set; }
            public string SQRM { get; set; }
        }
        public static CommonReturn<foreigner> search_foreigner(string name)
        {
            Console.WriteLine("search_foreigner started..." + DateTime.Now);
            var ret = new CommonReturn<foreigner> { milliseconds = "7", dataid = dataid.waiguoren, na = true, ok = true, remote = true, message = string.Empty, title = "外国人工作许可证", datalist = new List<foreigner>() };
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("search_foreigner end for not suit conditions");
                return ret;
            }
            else ret.na = false;

            var stop = new Stopwatch();
            stop.Start();

            var url = string.Format("http://10.50.241.24:9009/SD.YTGA/03/SD.YTGA.YZ.GA.ZWZY.ZWWGRXKZ?名字={0}", name.Trim());
            try
            {
                var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip };
                using (var http = new HttpClient(handler))
                {
                    http.DefaultRequestHeaders.Add("collagen-out_parameters", "_ALL_");
                    http.DefaultRequestHeaders.Add("collagen-debug", "OFF");
                    http.DefaultRequestHeaders.Add("collagen-timeout", "140S");
                    http.DefaultRequestHeaders.Add("collagen-authorize_id", "2366747e909641f69afeabd6cf4a226a");
                    http.DefaultRequestHeaders.Add("apikey", "491522724980588544");
                    http.DefaultRequestHeaders.Add("collagen-proxy_flow_id", "SD.YTGA::01::FLOW_C3_CALL_RESTFUL_PROXY");
                    http.DefaultRequestHeaders.Add("collagen-session_id", "no-session");
                    http.DefaultRequestHeaders.Add("collagen-requester_id", "SD.YTGA.APP.GA.YTLD");
                    var response = http.GetByteArrayAsync(url).Result;
                    string srcString = Encoding.Default.GetString(response, 0, response.Length);
                    //  var rawstr = srcString.Replace("\\", "");
                    Console.WriteLine("response={0}", srcString);
                    var ress = JsonConvert.DeserializeObject<rawres<foreigner>>(srcString);
                    if (ress.code == 200)
                    {
                        Console.WriteLine("data={0}", ress.data);
                        // var inner = JsonConvert.DeserializeObject<rawmessage>(ress.data);
                        if (ress.data.code == "200")
                        {
                            foreach (var a in ress.data.data)
                            {
                                ret.datalist.Add(new foreigner
                                {
                                    GZXKZBH = a.GZXKZBH,
                                    SQRX = a.SQRX,
                                    GJ = a.GJ,
                                    YXQQSRQ = a.YXQQSRQ,
                                    SQRCSRQ = a.SQRCSRQ,
                                    YRDW = a.YRDW,
                                    YXQZZRQ = a.YXQZZRQ,
                                    SQRXB = a.SQRXB,
                                    SQRM = a.SQRM
                                });
                            }
                        }
                        else
                        {
                            // Console.Error.WriteLine("{0},{1}--{2},{3},{4}", name, id, stop.ElapsedMilliseconds, DateTime.Now, rawstr);
                            ret.ok = false;
                            ret.message = ress.data.error + ress.data.msg + srcString;
                        }
                    }
                    else
                    {
                        // Console.Error.WriteLine("{0},{1}--{2},{3},{4}", name, id, stop.ElapsedMilliseconds, DateTime.Now, rawstr);
                        ret.ok = false;
                        ret.message = ress.message + srcString;
                    }
                }
            }
            catch (Exception ex)
            {
                //  stop.Stop();
                //  Console.Error.WriteLine("{0},{1}--{2},{3},{4}", name, id, stop.ElapsedMilliseconds, DateTime.Now, ex.Message);
                ret.ok = false;
                ret.message = tip + ex.Message;
            }
            stop.Stop();
            ret.milliseconds = stop.ElapsedMilliseconds.ToString();
            if (ret.datalist.Count < 1)
            {
                ret.message += "，没有相关记录";
                ret.ok = false;
            }
            Console.WriteLine("search_foreigner end..." + DateTime.Now);
            return ret;
        }
        static string tip = "上游接口没有给出正确结果，请联系管理员协调烟台市政务信息资源共享交换平台解决！";
    }
}