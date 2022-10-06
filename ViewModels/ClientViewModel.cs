using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MOM.Model;

namespace MOM.ViewModels
{
    public class ClientViewModel : ViewModelBase
    {
        public Client clt { get; set; }

        public ICommand AddClientViewersCommand { get; }
        
        protected override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
