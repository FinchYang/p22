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
    public class Ai// 于树红, 370602197912051347
    {
        public static string dbsource = "Data Source = (DESCRIPTION =  (ADDRESS_LIST =  (ADDRESS = (PROTOCOL = TCP)(HOST = 10.50.129.61)(PORT = 1521)) )(CONNECT_DATA = (SID = jwkf1))); User ID = ryhy_temp; Password = rkhy_2018";
        public class yanglaolishi
        {
            public string dwmc { get; set; }
            public string jfrq { get; set; }
            public string ny { get; set; }
            public string fsyymc { get; set; }
            public string xzbzmc { get; set; }
        }
        public static CommonReturn<yanglaolishi> yang_lao_li_shi(string ryid)
        {
            Console.WriteLine("yang_lao_li_shi started");
            var ret = new CommonReturn<yanglaolishi> { milliseconds = "7", dataid = dataid.yanglaolishi, na = true, ok = true, remote = false, message = string.Empty, title = "养老缴费历史", datalist = new List<yanglaolishi>() };
            if (string.IsNullOrEmpty(ryid))
            {
                Console.WriteLine("yang_lao_li_shi end for not suit conditions");
                return ret;
            }
            else ret.na = false;
            var stop = new Stopwatch();
            stop.Start();
            try
            {
                using (var connection = new OracleConnection(dbsource))
                {
                    connection.Open();
                    using (var command = new OracleCommand("SELECT dwmc,jfrq,ny,fsyymc,xzbzmc from yang_lao_jiao_fei_li_shi where   ryid=:ryid", connection))
                    {
                        command.Parameters.Add("ryid", ryid);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var one = new yanglaolishi();
                                one.dwmc = reader.GetString(0);
                                one.jfrq = reader.GetString(1);
                                one.ny = reader.GetString(2);
                                one.fsyymc = reader.GetString(3);
                                one.xzbzmc = reader.GetString(4);
                                ret.datalist.Add(one);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ret.ok = false;
                ret.message = ex.Message;
            }
            stop.Stop();
            ret.milliseconds = stop.ElapsedMilliseconds.ToString();
            if (ret.datalist.Count < 1)
            {
                ret.message += "，没有记录";
                ret.ok = false;
            }
            Console.WriteLine("yang_lao_li_shi ended");
            return ret;
        }
        public class binzanghuohua
        {
            public string sex { get; set; }
            public string chapeln { get; set; }
            public string cremation_time { get; set; }
            public string id_card { get; set; }
            public string name { get; set; }
        }
        public static CommonReturn<binzanghuohua> bin_zang_huo_hua(string name, string id)
        {
            Console.WriteLine("bin_zang_huo_hua started");
            var ret = new CommonReturn<binzanghuohua> { milliseconds = "7", dataid = dataid.binzanghuohua, na = true, ok = true, remote = false, message = string.Empty, title = "殡葬火化", datalist = new List<binzanghuohua>() };
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(id))
            {
                Console.WriteLine("bin_zang_huo_hua end for not suit conditions");
                return ret;
            }
            else ret.na = false;
            var stop = new Stopwatch();
            stop.Start();
            try
            {
                using (var connection = new OracleConnection(dbsource))
                {
                    connection.Open();
                    using (var command = new OracleCommand("SELECT * from bin_zang_huo_hua where  instr(name,:name)!=0 or instr(id_card,:id)!=0 ", connection))
                    {
                        command.Parameters.Add("name", name);
                        command.Parameters.Add("id", id);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var one = new binzanghuohua();
                                one.sex = reader.GetString(0);
                                one.chapeln = reader.GetString(1);
                                one.cremation_time = reader.GetString(2);
                                one.id_card = reader.GetString(3);
                                one.name = reader.GetString(4);
                                ret.datalist.Add(one);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ret.ok = false;
                ret.message = ex.Message;
            }
            stop.Stop();
            ret.milliseconds = stop.ElapsedMilliseconds.ToString();
            if (ret.datalist.Count < 1)
            {
                ret.message += "，没有记录";
                ret.ok = false;
            }
            Console.WriteLine("bin_zang_huo_hua ended");
            return ret;
        }
        public class canbaozhigong
        {
            public string jbrq { get; set; }
            public string dwbh { get; set; }
            public string domicile { get; set; }
            public string lxdh { get; set; }
            public string xm { get; set; }
            public string sfzh { get; set; }
            public string ryid { get; set; }
        }
        public static CommonReturn<canbaozhigong> can_bao_zhi_gong(string name, string id, string phone)
        {
            Console.WriteLine("can_bao_zhi_gong started");
            var ret = new CommonReturn<canbaozhigong> { dataid = dataid.canbaozhigong, milliseconds = "7", na = true, ok = true, remote = false, message = string.Empty, title = "参保职工", datalist = new List<canbaozhigong>() };
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(id) && string.IsNullOrEmpty(phone))
            {
                Console.WriteLine("can_bao_zhi_gong end for not suit conditions");
                return ret;
            }
            else ret.na = false;
            var stop = new Stopwatch();
            stop.Start();
            try
            {
                using (var connection = new OracleConnection(dbsource))
                {
                    connection.Open();
                    using (var command = new OracleCommand("SELECT * from can_bao_zhi_gong where instr(lxdh,:phone)!=0 or xm=:name or instr(sfzh,:id)!=0 ", connection))
                    {
                        command.Parameters.Add("phone", name);
                        command.Parameters.Add("name", name);
                        command.Parameters.Add("id", id);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var one = new canbaozhigong();
                                one.jbrq = reader.GetString(0);
                                one.dwbh = reader.GetString(1);
                                one.domicile = reader.GetString(2).Replace("`", "");
                                one.lxdh = reader.GetString(3).Replace("`", "");
                                one.xm = reader.GetString(4);
                                one.sfzh = reader.GetString(5);
                                one.ryid = reader.GetString(6);
                                ret.datalist.Add(one);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ret.ok = false;
                ret.message = ex.Message;
            }
            stop.Stop();
            ret.milliseconds = stop.ElapsedMilliseconds.ToString();
            if (ret.datalist.Count < 1)
            {
                ret.message += "，没有记录";
                ret.ok = false;
            }
            Console.WriteLine("can_bao_zhi_gong ended");
            return ret;
        }

        public static CommonReturn<birth> chu_sheng_yi_xue_zheng_ming(string name, string id)
        {
            Console.WriteLine("chu_sheng_yi_xue_zheng_ming started");
            var ret = new CommonReturn<birth> { milliseconds = "7", dataid = dataid.chushengzhengming, na = true, ok = true, remote = false, message = string.Empty, title = "出生医学证明", datalist = new List<birth>() };
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(id))
            {
                Console.WriteLine("chu_sheng_yi_xue_zheng_ming end for not suit conditions");
                return ret;
            }
            else ret.na = false;
            var stop = new Stopwatch();
            stop.Start();
            try
            {
                using (var connection = new OracleConnection(dbsource))
                {
                    connection.Open();
                    using (var command = new OracleCommand("SELECT * from chu_sheng_yi_xue_zheng_ming where fqxm=:name or xsexm=:name or mqxm=:name or mqsfzh=:id or fqsfzh=:id", connection))
                    {
                        command.Parameters.Add("name", name);
                        command.Parameters.Add("name", name);
                        command.Parameters.Add("name", name);
                        command.Parameters.Add("id", id);
                        command.Parameters.Add("id", id);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var one = new birth();
                                one.fqxm = reader.GetString(0);
                                one.xsexm = reader.GetString(1);
                                one.mqsfzhm = reader.GetString(2).Replace("'", "");
                                one.bh = reader.GetString(3);
                                one.xsecsrq = reader.GetString(4);
                                one.mqxm = reader.GetString(5);
                                one.qfjgmc = reader.GetString(6);
                                one.fqsfzhm = reader.GetString(7).Replace("'", "");
                                ret.datalist.Add(one);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ret.ok = false;
                ret.message = ex.Message;
            }
            stop.Stop();
            ret.milliseconds = stop.ElapsedMilliseconds.ToString();
            if (ret.datalist.Count < 1)
            {
                ret.message += "，没有记录";
                ret.ok = false;
            }
            Console.WriteLine("chu_sheng_yi_xue_zheng_ming ended");
            return ret;
        }
        public class nbcb
        {
            public string jbsj { get; set; }
            public string jdmc { get; set; }
            public string sqmc { get; set; }
            public string xm { get; set; }
            public string sfzh { get; set; }
            public string ryid { get; set; }
            public string grbh { get; set; }
        }
        public static CommonReturn<nbcb> nong_bao_can_bao(string name, string id)
        {
            Console.WriteLine("nong_bao_can_bao started");
            var ret = new CommonReturn<nbcb> { milliseconds = "7", dataid = dataid.nongbaocanbao, na = true, ok = true, remote = false, message = string.Empty, title = "农保参保", datalist = new List<nbcb>() };
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(id))
            {
                Console.WriteLine("nong_bao_can_bao end for not suit conditions");
                return ret;
            }
            else ret.na = false;
            var stop = new Stopwatch();
            stop.Start();
            try
            {
                using (var connection = new OracleConnection(dbsource))
                {
                    connection.Open();
                    using (var command = new OracleCommand("SELECT jbsj,jdmc,sqmc,xm,sfzh,ryid,grbh from nong_bao_can_bao where instr(xm,:name)!=0 or instr(sfzh,:id)!=0", connection))
                    {
                        command.Parameters.Add("name", name);
                        command.Parameters.Add("id", id);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var one = new nbcb();
                                one.jbsj = reader.GetString(0);
                                one.jdmc = reader.GetString(1);
                                one.sqmc = reader.GetString(2);
                                one.xm = reader.GetString(3);
                                one.sfzh = reader.GetString(4);
                                one.ryid = reader.GetString(5);
                                one.grbh = reader.GetString(6);
                                ret.datalist.Add(one);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ret.ok = false;
                ret.message = ex.Message;
            }
            stop.Stop();
            ret.milliseconds = stop.ElapsedMilliseconds.ToString();
            if (ret.datalist.Count < 1)
            {
                ret.message += "，没有记录";
                ret.ok = false;
            }
            Console.WriteLine("nong_bao_can_bao ended");
            return ret;
        }
        public class yyyd
        {
            public string lxr { get; set; }
            public string dh { get; set; }
            public string yymc { get; set; }
        }
        public static CommonReturn<yyyd> yi_yuan_yao_dian(string name, string phone)
        {
            Console.WriteLine("yi_yuan_yao_dian started");
            var ret = new CommonReturn<yyyd> { milliseconds = "7", dataid = dataid.yiyuanyaodian, na = true, ok = true, remote = false, message = string.Empty, title = "医院药店", datalist = new List<yyyd>() };
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(phone))
            {
                Console.WriteLine("yi_yuan_yao_dian end for not suit conditions");
                return ret;
            }
            else ret.na = false;
            var stop = new Stopwatch();
            stop.Start();
            try
            {
                using (var connection = new OracleConnection(dbsource))
                {
                    connection.Open();
                    using (var command = new OracleCommand("SELECT lxr,dh,yymc from yi_yuan_yao_dian where instr(lxr,:name)!=0 or instr(dh,:phone)!=0", connection))
                    {
                        command.Parameters.Add("name", name);
                        command.Parameters.Add("phone", phone);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var one = new yyyd();
                                one.lxr = reader.GetString(0);
                                one.dh = reader.GetString(1);
                                one.yymc = reader.GetString(2);
                                ret.datalist.Add(one);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ret.ok = false;
                ret.message = ex.Message;
            }
            stop.Stop();
            ret.milliseconds = stop.ElapsedMilliseconds.ToString();
            if (ret.datalist.Count < 1)
            {
                ret.message += "，没有记录";
                ret.ok = false;
            }
            Console.WriteLine("yi_yuan_yao_dian ended");
            return ret;
        }
        public class zgzs
        {
            public string zy { get; set; }
            public string xm { get; set; }
            public string zsbh { get; set; }
            public string jdjb { get; set; }
            public string bzrq { get; set; }
        }
        public static CommonReturn<zgzs> LocalZhiYeZiGe(string name)
        {
            Console.WriteLine("LocalZhiYeZiGe started");
            var ret = new CommonReturn<zgzs> { milliseconds = "7", dataid = dataid.zigezhengshu, na = true, ok = true, remote = false, message = string.Empty, title = "职业资格证书", datalist = new List<zgzs>() };
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("LocalZhiYeZiGe end for not suit conditions");
                return ret;
            }
            else ret.na = false;

            var stop = new Stopwatch();
            stop.Start();

            try
            {
                using (var connection = new OracleConnection(dbsource))
                {
                    connection.Open();
                    using (var command = new OracleCommand("SELECT zy,zsbh,jdjb,bzrq，xm from zhi_ye_zi_ge_zheng_shu where xm= :a", connection))
                    {
                        command.Parameters.Add("a", name);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var one = new zgzs();
                                one.zy = reader.GetString(0);
                                one.zsbh = reader.GetString(1);
                                one.jdjb = reader.GetString(2);
                                one.bzrq = reader.GetString(3);
                                one.xm = reader.GetString(4);
                                ret.datalist.Add(one);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ret.ok = false;
                ret.message = ex.Message;
            }
            stop.Stop();
            ret.milliseconds = stop.ElapsedMilliseconds.ToString();
            if (ret.datalist.Count < 1)
            {
                ret.message += "，没有记录";
                ret.ok = false;
            }
            Console.WriteLine("LocalZhiYeZiGe ended");
            return ret;
        }

        public static CommonReturn<MarriageStatus> LocalMarriageSearch(string id, string name)
        {
            Console.WriteLine("LocalMarriageSearch started..." + DateTime.Now);
            var ret = new CommonReturn<MarriageStatus> { milliseconds = "7", dataid = dataid.hunyi, ok = true, remote = false, message = string.Empty, title = "婚姻登记信息", na = true, datalist = new List<MarriageStatus>() };
            if (string.IsNullOrEmpty(id) && string.IsNullOrEmpty(name))
            {
                Console.WriteLine("LocalMarriageSearch end for not suit conditions");
                return ret;
            }
            else ret.na = false;

            var stop = new Stopwatch();
            stop.Start();

            try
            {
                using (var connection = new OracleConnection(dbsource))
                {
                    connection.Open();
                    using (var command = new OracleCommand("SELECT cert_no,op_date,id_card,name from hun_yin_deng_ji_xin_xi where id_card= :a or name=:b", connection))
                    {
                        command.Parameters.Add("a", id);
                        command.Parameters.Add("b", name);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var one = new MarriageStatus();
                                one.cert_no = reader.GetString(0);
                                one.op_date = reader.GetString(1);
                                one.id_card = reader.GetString(2);
                                one.name = reader.GetString(3);
                                ret.datalist.Add(one);
                            }
                        }
                    }
                    var newadd=new List<MarriageStatus>();
                    foreach (var a in ret.datalist)
                    {
                        using (var command = new OracleCommand("SELECT cert_no,op_date,id_card,name from hun_yin_deng_ji_xin_xi where cert_no like :b", connection))
                        {
                            command.Parameters.Add("b","%"+ a.cert_no.Trim()+"%");
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var one = new MarriageStatus();
                                    one.cert_no = reader.GetString(0);
                                    one.op_date = reader.GetString(1);
                                    one.id_card = reader.GetString(2);
                                    one.name = reader.GetString(3);
                                    newadd.Add(one);
                                }
                            }
                        }
                    }
                    ret.datalist.AddRange(newadd);
                }
            }
            catch (Exception ex)
            {
                ret.ok = false;
                ret.message = ex.Message;
            }
            stop.Stop();
            ret.milliseconds = stop.ElapsedMilliseconds.ToString();
            if (ret.datalist.Count < 1)
            {
                ret.message += "，没有记录";
                ret.ok = false;
            }
            Console.WriteLine("LocalMarriageSearch ended");
            return ret;
        }
        public class MarriageStatus
        {
            public string cert_no { get; set; }
            public string op_date { get; set; }
            public string id_card { get; set; }
            public string name { get; set; }
        }

        public static CommonReturn<MarriageStatus> MarriageSearch(string id, string name)
        {
            Console.WriteLine("remote marriage started..." + DateTime.Now);
            var ret = new CommonReturn<MarriageStatus> { milliseconds = "7", dataid = dataid.hunyi, na = true, ok = true, remote = true, message = string.Empty, title = "婚姻登记信息", datalist = new List<MarriageStatus>() };
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name))
            {
                Console.WriteLine("MarriageSearch end for not suit conditions");
                return ret;
            }
            else ret.na = false;

            var stop = new Stopwatch();
            stop.Start();

            var url = string.Format("http://10.50.241.24:9009/SD.YTGA/03/SD.YTGA.YZ.GA.ZWZY.HYDJDR?name_man={0}&cert_num_man={1}&start=0&limit=500",
            string.IsNullOrEmpty(name) ? "" : name.Trim(), string.IsNullOrEmpty(id) ? "" : id.Trim());
            try
            {
                var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip };
                using (var http = new HttpClient(handler))
                {
                    http.DefaultRequestHeaders.Add("collagen-out_parameters", "_ALL_");
                    http.DefaultRequestHeaders.Add("collagen-debug", "OFF");
                    http.DefaultRequestHeaders.Add("collagen-timeout", "140S");
                    http.DefaultRequestHeaders.Add("collagen-authorize_id", "05515a8cae164e0ca63541dd4992d9aa");
                    http.DefaultRequestHeaders.Add("apikey", "476409455823552512");
                    http.DefaultRequestHeaders.Add("collagen-proxy_flow_id", "SD.YTGA::01::FLOW_C3_CALL_RESTFUL_PROXY");
                    http.DefaultRequestHeaders.Add("collagen-session_id", "no-session");
                    http.DefaultRequestHeaders.Add("collagen-requester_id", "SD.YTGA.APP.GA.YTLD");
                    var response = http.GetByteArrayAsync(url).Result;
                    string srcString = Encoding.Default.GetString(response, 0, response.Length - 1);
                    var rawstr = srcString.Replace("\\", "");
                    // stop.Stop();
                    if (rawstr.Contains("code\":200,"))
                    {
                        if (rawstr.Contains("count\":0"))
                        {
                            Console.Error.WriteLine("{0},{1}--{2},{3}",
                                name, id, "NoStatus", DateTime.Now);
                            // ret.message = "no record";
                        }
                        else
                        {
                            var temp = rawstr;
                            while (true)
                            {
                                var index = temp.IndexOf("cert_no");
                                // Console.WriteLine("index={0}",index);
                                var end = temp.IndexOf("op_date");
                                var cert_no = temp.Substring(index + 10, end - index - 13);
                                var op_date = temp.Substring(end + 10, 10);
                                temp = temp.Substring(end + 10);
                                Console.WriteLine("{0},{1},{2},{3},{4}",
                                  id, name, DateTime.Now.ToString("yyyyMMdd"),
                                   cert_no, op_date);
                                ret.datalist.Add(new MarriageStatus
                                {
                                    cert_no = cert_no,
                                    op_date = op_date,
                                    id_card = id,
                                    name = name
                                });
                                if (!temp.Contains("cert_no")) break;
                            }
                        }
                    }
                    else
                    {
                        ret.ok = false;
                        ret.message = rawstr;
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
                ret.message += "，共享平台没有相关记录";
                ret.ok = false;
            }
            Console.WriteLine("marriage end..." + DateTime.Now);
            return ret;
        }
        static string tip = "上游接口没有给出正确结果，请联系管理员协调烟台市政务信息资源共享交换平台解决";
    }
}