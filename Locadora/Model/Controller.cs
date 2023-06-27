using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Model
{
    internal class Controller
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\edmar.dduarte\source\repos\Locadora\Locadora\Model\Locadorabd.mdf;Integrated Security=True";
        }
    }
}
