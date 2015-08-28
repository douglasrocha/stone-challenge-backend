using DomainModel.Entities;
using DomainModel.Repository.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Domain
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void DUser_Insert_Invalid_Element()
        {
            var a = Substitute.For<IUserRepository>();
            var obj = new User();

            a.Insert(obj).Returns(0);

            Assert.AreEqual(0, a.Insert(obj));
        }

        [TestMethod]
        public void DUser_Insert_1_Element()
        {
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void DUser_Insert_2_Elements()
        {
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void DUser_Insert_Null()
        {
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void DUser_Update_Invalid_Element()
        {
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void DUser_Update_1_Element()
        {
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void Update_2_Elements()
        {
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void DUser_Update_Null()
        {
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void DUser_Delete_1_Element()
        {
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void DUser_Delete_2_Elements()
        {
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void DUser_Delete_Null()
        {
            Assert.IsFalse(true);
        }
    }
}
