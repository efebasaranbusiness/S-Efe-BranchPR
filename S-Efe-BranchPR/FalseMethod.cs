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
            bool İsSuccess = false;
            string StatusMessage = string.Empty;    
            Console.WriteLine($"Process Unsuccesfly.\n");
            Console.WriteLine(
                $"\n{Status}"+
                $"\n{data}"+
                $"\n{dateTime}"
                );
        }
    }
}
