﻿using Digital.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital.Schema.Dto.Token
{
    public class TokenResponse
    {
        public DateTime ExpireTime { get; set; }
        public string AccessToken { get; set; }
        public string Email { get; set; }

    }
}
