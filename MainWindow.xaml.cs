using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MOM.Model;

namespace MOM
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            
            
            Pizza p = new Pizza(Pizza.Size.Middle, Pizza.Kind.Ketchup, 34.3);
            Console.WriteLine(p.ToString());

            Order m = new Order(4, new DateTime(3, 4, 5), "coucou", "coucou", new List<Pizza>() { p,p,p }, new List<Boisson>() { Boisson.Coca });

            Console.WriteLine(m.ToString());
        }
    }
}
