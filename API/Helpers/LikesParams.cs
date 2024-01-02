using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class LikesParams : PaginationParams
    {
        internal string Predicate;

        public int UserId { get; internal set; }
    }
}