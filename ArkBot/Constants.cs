﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkBot
{
    public class Constants : IConstants
    {
        public string DatabaseFilePath => ".\\Database\\Database.sdf";
        public string DatabaseConnectionString => $"Data Source={DatabaseFilePath};Max Database Size=4091";
        public string OpenidresponsetemplatePath => @"Resources\openidresponse.html";
        public string SavedStateFilePath => "savedstate.json";
        //todo: move this to config
        public string ServerIp => "85.227.28.132";
        public int ServerPort => 27003;
    }
}
