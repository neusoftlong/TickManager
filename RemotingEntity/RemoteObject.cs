﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingEntity
{
    public class RemoteObject:MarshalByRefObject
    {
        public RemoteObject()
        {
            System.Console.WriteLine("New Referance Added!");
        }

        public int sum(int a, int b)
        {
            return a + b;
        }
    }
}
