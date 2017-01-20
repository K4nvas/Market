using K4nvas.Market.Domain.Contract.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K4nvas.Market.Model.Test;
using K4nvas.Market.Repository.Contract.Test;

namespace K4nvas.Market.Domain.Test
{
    public class TestDomain : ITestDomain
    {
        private readonly ITestRepository oITestRepository;
        public TestDomain(ITestRepository oITestRepositoryI)
        {
            oITestRepository = oITestRepositoryI;
        }

        public string GetName()
        {
            return oITestRepository.GetName();
        }

        public List<TestData> GetTestData()
        {
            return oITestRepository.GetTestData();
        }
    }
}
