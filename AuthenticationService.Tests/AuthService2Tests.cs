using Model;
using Model.CustomException;
using Model.Interface;
using Model.Service;
using NUnit.Framework;

namespace AuthenticationService.Tests
{
    public class AuthService2Tests
    {
        private readonly IAuthService _authService = new AuthService2();
        [Test]
        public void When_wuu_1234_Should_Login_Success()
        {
            Assert.True(_authService.Login("wuu", "1234"));
        }

        [Test]
        public void When_wuu_1235_Should_Login_Fail()
        {
            Assert.False(_authService.Login("wuu", "1235"));
        }

        [Test]
        public void When_username_is_empty_should_throw_exception()
        {
            Assert.Throws<InvalidParameterException>(() => _authService.Login("", "1234"));
        }

        [Test]
        public void When_password_is_empty_should_throw_exception()
        {
            Assert.Throws<InvalidParameterException>(() => _authService.Login("wuu", ""));
        }
    }
}
