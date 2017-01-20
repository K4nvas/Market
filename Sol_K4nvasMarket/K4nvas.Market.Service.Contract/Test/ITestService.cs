using K4nvas.Market.Model.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace K4nvas.Market.Service.Contract.Test
{
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        List<TestData> GetTestData();
        [OperationContract]
        string GetName();
    }
}
