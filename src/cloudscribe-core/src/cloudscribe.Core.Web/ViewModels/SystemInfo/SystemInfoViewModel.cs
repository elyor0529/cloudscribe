﻿using System;
using System.Collections.Generic;
using System.Linq;
// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
//	Author:                 Joe Audette
//  Created:			    2011-08-20
//	Last Modified:		    2015-08-20
// 

using System.Threading.Tasks;

namespace cloudscribe.Core.Web.ViewModels.SystemInfo
{
    public class SystemInfoViewModel
    {
        public string Name { get; set; }
        public string LocalAddress { get; set; }
        public string OperatingSystem { get; set; }
        public string Runtime { get; set; }
        public string EnvironmentName { get; set; }
        public string DatabasePlatform { get; set; }
        public string CloudscribeCoreVersion { get; set; }
        public DateTime ServerTimeUtc { get; } = DateTime.UtcNow;
    }
}
