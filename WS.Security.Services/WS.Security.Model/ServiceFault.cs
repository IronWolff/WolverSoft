﻿using System;

namespace WS.Security.Model
{
    public class ServiceFault
    {
        public string ErrorCode { get; set; }

        public string ErrorMessage { get; set; }

        public string ErrorDetail { get; set; }
    }
}
