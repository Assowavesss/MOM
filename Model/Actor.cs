using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Model
{
    public abstract class Actor : IActor
    {

        bool IsReceived;
        
        
        public abstract void MessageReceived();
    }
}
