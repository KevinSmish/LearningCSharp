using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170607_TestOpenExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            Type xlType = Type.GetTypeFromProgID("Excel.Application");
            dynamic xl = Activator.CreateInstance(xlType);

            xl.Visible = true;
            xl.Workbooks.Add();
            xl.Cells[1, 1].Value2 = "some data";
        }
    }
}
