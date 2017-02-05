using K4nvas.Market.Model.Test;
using K4nvas.Market.Repository.Contract.Test;
using System;
using System.Collections.Generic;
using System.Linq;

namespace K4nvas.Market.Repository.Test
{
    public class TestRepository : ITestRepository
    {

        public static List<TestData> oListTestData = new List<TestData>();

        public string GetName()
        {
            return "Richard Gómez Garcia";
        }

        public List<TestData> GetTestData()
        {
            for (int i = 0; i < 10; i++)
            {
                oListTestData.Add(new TestData
                {
                    IdTest = i,
                    DescriptionTest = string.Format($"Descripción {i}"),
                    DateTest = DateTime.Now
                });
            }

            return oListTestData;
        }

        public int SaveTestData(TestData oTestData)
        {
            oListTestData.Add(oTestData);
            return oListTestData.Count();
        }
    }
}
