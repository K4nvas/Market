using K4nvas.Market.Model.Test;
using System.Collections.Generic;

namespace K4nvas.Market.Domain.Contract.Test
{
    public interface ITestDomain
    {
        List<TestData> GetTestData();
        string GetName();
    }
}
