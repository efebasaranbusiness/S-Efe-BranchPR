using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Efe_BranchPR
{
    public class XMethodClass
    {
        public void GetUserData()
        {
            string UserName = "Efe";
            string Mail = "efe.basaran@sekompos.com";
            string Phone = "05413659874";
            Console.WriteLine($"İsminiz: {UserName}");
            Console.WriteLine($"E-Posta Adresiniz : {Mail}");
            Console.WriteLine($"Telefon Numaranız: {Phone}");
        }
    }
}
