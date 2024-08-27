using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Efe_BranchPR
{
    public class FalseMethod
    {
        public void GetData()
        {
            bool Status = false;
            string data = null;
            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"İşlem Başarısız ");
            Console.WriteLine(
                $"\n{Status}"+
                $"\n{data}"+
                $"\n{dateTime}"
                );
        }
    }
}
