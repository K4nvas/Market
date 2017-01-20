using K4nvas.Market.Model.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K4nvas.Market.Repository.Contract.Test
{
    public interface ITestRepository
    {
        List<TestData> GetTestData();
        int SaveTestData(TestData oTestData);
        string GetName();
    }
}
