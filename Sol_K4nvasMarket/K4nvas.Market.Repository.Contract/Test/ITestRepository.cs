using K4nvas.Market.Model.Test;
using System.Collections.Generic;

namespace K4nvas.Market.Repository.Contract.Test
{
    public interface ITestRepository
    {
        List<TestData> GetTestData();
        int SaveTestData(TestData oTestData);
        string GetName();
    }
}
