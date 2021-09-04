using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetCSV.Intarfaces
{
    enum Results
    {
        OK,
        Error
    }

    interface ICSVWorker
    {

        System.Data.DataTable OpenTable(string path);

        Results SaveTable(string path, System.Data.DataTable data);

    }
}
