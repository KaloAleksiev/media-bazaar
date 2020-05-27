using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MediaBazaarTest
{
    public enum Position
    {
        Administrator ,
        Manager,
        DepotWorker,
        Employee
    }
}
