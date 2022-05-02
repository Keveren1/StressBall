using Microsoft.VisualStudio.TestTools.UnitTesting;
using StressBall.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StressBall.Manager.Tests
{
    [TestClass()]
    public class StressBallManagerTests
    {
        private StressBallManager _manager;

        [TestInitialize]
        public void SetUp()
        {
            _manager = new StressBallManager();
        }
        [TestMethod()]
        public void GetAllTest()
        {
            Assert.IsNotNull(_manager.GetAll(null, null));
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.IsNotNull(_manager.GetById(1));
            Assert.IsNull(_manager.GetById(0));

        }

        [TestMethod()]
        public void PostStressBallDataTest()
        {
            var stressBall = new StressBallData();
            StressBallData testStressBallData = _manager.PostStressBallData(stressBall);
            Assert.IsNotNull(testStressBallData);
            Assert.AreEqual(stressBall, testStressBallData);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            StressBallData deleteStressBallData = _manager.Delete(3);
            Assert.IsNotNull(deleteStressBallData);
        }
    }
}