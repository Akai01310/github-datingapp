using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class MessageParams : PaginationParams
    {
        public string Username { get; set; }  = "";
        public string Container { get; set; } = "Unread";
        public int PageNumber { get; internal set; }
    }
}