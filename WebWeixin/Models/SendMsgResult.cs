﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebWeixin.Models
{
    public class SendMsgResult
    {
        public BaseResponse BaseResponse { get; set; }
        public string MsgID { get; set; }
        public string LocalID { get; set; }
    }
}
