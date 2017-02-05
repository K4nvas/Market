using K4nvas.Market.Model.Test;
using System.Collections.Generic;
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
