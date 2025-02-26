﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Practice.Services
{
    internal interface IEngine
    {
        void start ();
        void stop ();

        void overtake();

    }
}
