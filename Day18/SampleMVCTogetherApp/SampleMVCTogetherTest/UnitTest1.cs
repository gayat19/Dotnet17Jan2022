using NUnit.Framework;
using SampleMVCTogetherApp.Models;
using SampleMVCTogetherApp.Services;

namespace SampleMVCTogetherTest
{
    public class Tests
    {
        IRepo<string, User> _repo;
        [SetUp]
        public void Setup()
        {
            //Arrange
            _repo = new UserTempService();
        }

        [Test]
        public void SimpleTest()
        {
            //Act
            var result = _repo.Remove("3");
            //Assert
            Assert.IsTrue(result);
        }
    }
}