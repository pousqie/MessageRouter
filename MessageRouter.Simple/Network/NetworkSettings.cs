﻿using Sockets.Plugin.Abstractions;

namespace MessageRouter.Simple.Network
{
    public class NetworkSettings
    {
        public NetworkSettings()
        {
            MulticastPort = 30304;
            ListenPort = 30303;
            TTL = 5;
        }
        public int TTL { get; set; }

        public ICommsInterface Adaptes { get; set; }

        public int MulticastPort { get; private set; }

        public int ListenPort { get; set; }
        public string MulticastAddress { get; set; }
    }
}