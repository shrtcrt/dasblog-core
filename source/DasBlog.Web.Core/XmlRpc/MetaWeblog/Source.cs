﻿using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Text;

namespace DasBlog.Web.Core.XmlRpc.MetaWeblog
{
    [XmlRpcMissingMapping(MappingAction.Ignore)]
    public struct Source
    {
        public string name;

        public string url;
    }
}
