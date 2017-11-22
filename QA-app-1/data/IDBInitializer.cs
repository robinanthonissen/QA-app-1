using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_app_1.data
{
    interface IDBInitializer
    {
        Task Initialize(ApplicationDBcontext context);
    }
}
