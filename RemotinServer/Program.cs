using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using RemotingEntity;

namespace RemotinServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpServerChannel channel = new TcpServerChannel(6666);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteObject),
                "RemoteObject", WellKnownObjectMode.SingleCall);
            System.Console.WriteLine("Press Any Key");
            System.Console.ReadLine();
            Console.Read();
        }
    }
}
