using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        string Test(string input);
    }
}
