using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Enums
{
    public enum EntityState
    {
        Added = 0,
        Modified = 1,
        Deleted = 2,
        Unchanged = 3,
        Detached = 4,
    }

    public enum CopyOfEntityState
    {
        Added = 0,
        Modified = 1,
        Deleted = 2,
        Unchanged = 3,
        Detached = 4,
    }
}
