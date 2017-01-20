using K4nvas.Market.Domain.Contract.Test;
using K4nvas.Market.Model.Test;
using K4nvas.Market.Service.Contract.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K4nvas.Market.Service.Test
{
    public class TestService : ITestService
    {
        private readonly ITestDomain oITestDomain;
        public TestService(ITestDomain oITestDomainI)
        {
            oITestDomain = oITestDomainI;
        }

        public string GetName()
        {
            return oITestDomain.GetName();
        }

        public List<TestData> GetTestData()
        {
            return oITestDomain.GetTestData();
        }
    }
}
