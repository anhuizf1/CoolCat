﻿using CoolCat.Core.DomainModel;
using System.Collections.Generic;
using System.IO;

namespace CoolCat.Core.Contracts
{
    public interface IReferenceContainer
    {
        List<CachedReferenceItemKey> GetAll();

        bool Exist(string name, string version);

        void SaveStream(string name, string version, Stream stream);

        Stream GetStream(string name, string version);
    }
}
