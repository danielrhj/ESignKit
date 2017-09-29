using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace CostErrDeal
{
    public class Command
    {
        /// <summary>
        /// 获取本机所有IPV4地址列表
        /// </summary>
        /// <returns>本机所有IPV4地址列表，以分号分隔</returns>
        public static string GetSelfIpv4List()
        {
            StringBuilder ips = new StringBuilder();
            try
            {
                IPHostEntry IpEntry = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ipa in IpEntry.AddressList)
                {
                    if (ipa.AddressFamily == AddressFamily.InterNetwork)
                        ips.AppendFormat("{0};", ipa.ToString());
                }
            }
            catch (Exception ex)
            {
                ips.Append("获取本地ip错误"+ex.Message.ToString());
            }
            return ips.ToString();
        }
    }
}
