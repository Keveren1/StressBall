using Microsoft.VisualStudio.TestTools.UnitTesting;
using StressBall.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StressBall.Manager.Tests
{
    [TestClass()]
    public class StressBallDBManagerTests
    {
        private StressBallDBManager _manager;

        [TestInitialize]
        public void SetUp()
        {
            var optionsBuilder = new DbContextOptionsBuilder<StressBallContext>();
            optionsBuilder.UseSqlServer(StressBallContext.ConnectionString);


            StressBallContext dbContext = new StressBallContext(optionsBuilder.Options);

            _manager = new StressBallDBManager(dbContext);
        }
        [TestMethod()]
        public void GetAllTest()
        {

            Assert.IsNotNull(_manager.GetAll(1.1, DateTime.Now));
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            //Assert.IsNotNull(_manager.GetById(1));
            Assert.IsNull(_manager.GetById(0));

        }

        [TestMethod()]
        public void PostStressBallDataTest()
        {
            var stressBall = new StressBallData();
            StressBallData testStressBallData = _manager.Add(stressBall);
            Assert.IsNotNull(testStressBallData);
            Assert.AreEqual(stressBall, testStressBallData);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            _manager.Add(new StressBallData() { Id = 2, Speed = 1.1, DateTimeNow = DateTime.Now });
            StressBallData deleteStressBallData = _manager.Delete(2);
            Assert.IsNotNull(deleteStressBallData);
        }
    }
}