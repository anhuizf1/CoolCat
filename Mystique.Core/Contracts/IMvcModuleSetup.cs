﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mystique.Core.Contracts
{
    public interface IMvcModuleSetup
    {
        void EnableModule(string moduleName);
    }
}
