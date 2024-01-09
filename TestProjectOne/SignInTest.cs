using SignInLib;
namespace TestProjectOne
{
    [TestClass]
    public class SignInTest
    {
        
        [TestMethod]
        public void SuccessMethod()
        {
            string expresult = "authenticated user";
            Assert.AreEqual(expresult, SignIn.Authenticate("sam","sam@1256"));
        }
        [TestMethod]
        public void FailMethod()
        {
            string expresult = "Invalid User Credentials";
            Assert.AreEqual(expresult, SignIn.Authenticate("ravi", "raj@1234"));
        }
        [TestMethod]
        public void AnonymousMethod()
        {
            string expresult = "You must provide Username and Password";
            Assert.AreEqual(expresult, SignIn.Authenticate(null, null));
        }
    }
}