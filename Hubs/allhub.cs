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
using p22.Models;
using System.Linq;

namespace p22.Hubs
{
    public class allhub : Hub// 于树红, 370602197912051347
    {
        private readonly secondContext a;
        public allhub(secondContext b)
        {
            a = b;
        }
        public async Task faren(string cerno)
        {
            await Clients.Caller.SendAsync("SearchAllResult", AiSource.sheng_gong_shang.faren(cerno));
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllDone", "ok");
            dblog(string.Format("search 法定代表人所在企业信息查询, {0}", cerno));
        }
        public async Task search_shebao(string ryid)
        {
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllResult", AiSource.Ai.yang_lao_li_shi(ryid));
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllDone", "ok");
            dblog(string.Format("search 社保历史, {0}", ryid));
        }

        public async Task localbirth(string id, string name)
        {
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllResult", AiSource.Ai.chu_sheng_yi_xue_zheng_ming(name, id));
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllDone", "ok");
            dblog(string.Format("search localbirth,id={0},name={1}.", id, name));
        }

        public async Task localmarriage(string id, string name)
        {
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllResult", AiSource.Ai.LocalMarriageSearch(id, name));
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllDone", "ok");
            dblog(string.Format("search localmarriage,id={0},name={1}.", id, name));
        }

        public async Task localnongbao(string id, string name)//
        {
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllResult", AiSource.Ai.nong_bao_can_bao(name, id));
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllDone", "ok");
            dblog(string.Format("search localnongbao,id={0},name={1}.", id, name));
        }

        public async Task localcanbao(string id, string name, string phone)//canbao
        {
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllResult", AiSource.Ai.can_bao_zhi_gong(name, id, phone));
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllDone", "ok");
            dblog(string.Format("search localcanbao, id={0},name={1},phone={2}", id, name, phone));
        }

        public async Task localbinzang(string id, string name)
        {
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllResult", AiSource.Ai.bin_zang_huo_hua(name, id));
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllDone", "ok");
            dblog(string.Format("search localbinzang,id={0},name={1}.", id, name));
        }
        public async Task localzhiye(string name)
        {
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllResult", AiSource.Ai.LocalZhiYeZiGe(name));
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllDone", "ok");
            dblog(string.Format("search localzhiye,name={0}.", name));
        }
        public async Task SearchAll(string id, string name, string phone)
        {
            var b = Task.Run(() => { Clients.Client(Context.ConnectionId).SendAsync("SearchAllResult", AiSource.Ai.LocalMarriageSearch(id, name)); });
            var c = Task.Run(() => { Clients.Client(Context.ConnectionId).SendAsync("SearchAllResult", AiSource.Ai.LocalZhiYeZiGe(name)); });
            var d = Task.Run(() => { Clients.Client(Context.ConnectionId).SendAsync("SearchAllResult", AiSource.Ai.yi_yuan_yao_dian(name, phone)); });
            var e = Task.Run(() => { Clients.Client(Context.ConnectionId).SendAsync("SearchAllResult", AiSource.Ai.nong_bao_can_bao(name, id)); });

            var f = Task.Run(() => { Clients.Client(Context.ConnectionId).SendAsync("SearchAllResult", AiSource.Ai.chu_sheng_yi_xue_zheng_ming(name, id)); });
            var g = Task.Run(() => { Clients.Client(Context.ConnectionId).SendAsync("SearchAllResult", AiSource.Ai.can_bao_zhi_gong(name, id, phone)); });
            var h = Task.Run(() => { Clients.Client(Context.ConnectionId).SendAsync("SearchAllResult", AiSource.Ai.bin_zang_huo_hua(name, id)); });
            Task.WaitAll(b, c, d, e, f, g, h);
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllDone", "ok");
            dblog(string.Format("search 综合搜索, id={0},name={1},phone={2}", id, name, phone));
        }
        public async Task MarriageSearch(string id, string name)
        {
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllResult", AiSource.Ai.MarriageSearch(id, name));
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllDone", "ok");
            dblog(string.Format("search 婚姻登记信息, {0},{1}", id, name));
        }
        private void dblog(string operation)
        {
            try
            {
                Console.WriteLine(operation);
                a.dapp.Add(new logging
                {
                    username = Context.User.Identity.Name,
                    ip = Context.GetHttpContext().Connection.RemoteIpAddress.ToString(),
                    time = DateTime.Now.ToString(),
                    operation = operation
                });
                a.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public async Task birthsearch(string fqxm, string mqxm, string fqsfzhm, string mqsfzhm, string xsexm)
        {
            await Clients.Client(Context.ConnectionId).SendAsync("fromshareResult", AiSource.FromShare.birthsearch(fqxm, mqxm, fqsfzhm, mqsfzhm, xsexm));
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllDone", "ok");
            try
            {
                a.dapp.Add(new logging
                {
                    username = Context.User.Identity.Name,
                    ip = Context.GetHttpContext().Connection.RemoteIpAddress.ToString(),
                    time = DateTime.Now.ToString(),
                    operation = string.Format("search 出生医学证明, {0},{1},{2},{3},{4}", fqxm, mqxm, fqsfzhm, mqsfzhm, xsexm)
                });
                a.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public async Task shengyusearch(string fqxm, string mqxm)
        {
            await Clients.Client(Context.ConnectionId).SendAsync("fromshareResult", AiSource.FromShare.shengyusearch(fqxm, mqxm));
            await Clients.Client(Context.ConnectionId).SendAsync("SearchAllDone", "ok");
            try
            {
                a.dapp.Add(new logging
                {
                    username = Context.User.Identity.Name,
                    ip = Context.GetHttpContext().Connection.RemoteIpAddress.ToString(),
                    time = DateTime.Now.ToString(),
                    operation = string.Format("search 生育服务, {0},{1}", fqxm, mqxm)
                });
                a.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public async Task search_foreigner(string ryid)
        {
            await Clients.Client(Context.ConnectionId).SendAsync("fromshareResult", AiSource.FromShare.search_foreigner(ryid));
            await Clients.Caller.SendAsync("SearchAllDone", "ok");
            // Console.WriteLine("{0},items count", Context.GetHttpContext().Connection.RemoteIpAddress);

            // foreach (var b in Context.Items)
            // {
            //     Console.WriteLine("{0},{1}", b.Key, b.Value);
            // }
            try
            {
                a.dapp.Add(new logging
                {
                    username = Context.User.Identity.Name,
                    ip = Context.GetHttpContext().Connection.RemoteIpAddress.ToString(),
                    time = DateTime.Now.ToString(),
                    operation = string.Format("search foreigner, {0}", ryid)
                });
                a.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}