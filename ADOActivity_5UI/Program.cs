using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOActivity_5DAL;

namespace ADOActivity_5UI
{
    class Program
    {
        static void Main(string[] args)
        {
            act5 obj = new act5();
            Console.WriteLine(obj.GetFullName(1));
        }
    }
}
