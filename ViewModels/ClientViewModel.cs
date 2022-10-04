using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOM.Model;

namespace MOM.ViewModels
{
    public class ClientViewModel : ViewModelBase
    {
        public Client clt { get; set; }
        
        protected override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
