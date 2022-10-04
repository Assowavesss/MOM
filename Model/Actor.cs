using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Model
{
    public abstract class Actor : IActor
    {

        public bool IsReceived { get; set; }
        
        
        public abstract void MessageReceived();
    }
}
