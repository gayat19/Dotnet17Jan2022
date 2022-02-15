using NUnit.Framework;
using SampleMVCTogetherApp.Models;
using SampleMVCTogetherApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace SampleMVCTogetherTest
{
    public class UserActionTest
    {
        [Test]
        public void SimpleTest()
        {
            //Arrange 
            //IRepo<string, User> repo = new UserRepo();

            //LoginService service = new LoginService(repo);
            //User user = new User() { Username = "abc", Password = "123" };
            ////Act
            //var resultuser = service.LoginCheck(user);
            ////Assert
            //Assert.Equals(user.Username, resultuser.Username);




            //Arrange 
            Mock<UserRepo> mockRepo = new Mock<UserRepo>();
            mockRepo.Setup(x => x.Get("Simsim")).Returns(new User { Username = "Simsim", Password = "sim123" });
            LoginService service = new LoginService(mockRepo.Object);
            User user = new User() { Username = "Simsim", Password = "sim123" };
            //Act
            var resultuser = service.LoginCheck(user);
            //Assert
            Assert.IsNotNull(resultuser);
        }
    }
}
