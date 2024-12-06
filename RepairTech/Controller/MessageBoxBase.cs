using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PBO.Controller
{
    public interface IMessageBoxBase
    {
       void MessageBoxAdmin();
       void MessageBoxPelanggan(string username);
    }
}
