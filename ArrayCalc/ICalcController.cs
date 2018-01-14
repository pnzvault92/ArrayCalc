using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ArrayCalc
{
    [ServiceContract]
    public interface ICalcController
    {
        [OperationContract]
        Result Mean(string a);

        [OperationContract]
        Result Sum(string a);

        [OperationContract]
        Result Mul(string a);
    }
}
