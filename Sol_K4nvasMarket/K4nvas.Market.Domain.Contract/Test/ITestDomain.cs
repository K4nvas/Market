using K4nvas.Market.Model.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K4nvas.Market.Domain.Contract.Test
{
    public interface ITestDomain
    {
        List<TestData> GetTestData();
        string GetName();
    }
}
