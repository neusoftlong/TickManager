using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using RemotingEntity;

namespace RemotingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelServices.RegisterChannel(new TcpClientChannel());
           RemoteObject remoteobj = (RemoteObject)Activator.GetObject(typeof(RemoteObject),
           "tcp://localhost:6666/RemoteObject");
           Console.WriteLine("1 + 2 = " + remoteobj.sum(1,2).ToString());
           Console.ReadLine();
        }
    }
}
