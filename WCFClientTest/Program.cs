using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFClientTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (TestService.Service1Client client = new TestService.Service1Client())
            {
                var value = client.Test("long string long string_END ");
                //client.DoWork();
            }
        }
    }
}
