﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace aliyun_ddns.IPGetter.IPv6Getter
{
    /// <summary>
    /// 获取所有网卡信息，返回最后一个IPv6地址。
    /// </summary>
    [Ignore]
    public sealed class LocalIPv6Getter : BaseLocalIPGetter, IIPv6Getter
    {
        public override string Description => "读取网卡IPv6设置";

        public override int Order => 200;

        protected override string IPNetworks => Options.Instance.IPv6Networks;

        protected override bool CheckIPAddressInformation(IPAddressInformation info)
        {
            return info.Address.AddressFamily == AddressFamily.InterNetworkV6;
        }
    }
}
