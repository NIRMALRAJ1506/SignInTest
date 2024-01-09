namespace SignInLib
{
    public class SignIn
    {
        public static string Authenticate(string username, string password)
        {
            string result;
            if(string.IsNullOrEmpty(username)||string.IsNullOrEmpty(password))
            {
                result = "You must provide Username and Password";
            }
            else if(username=="sam"&&password=="sam@1256")
            {
                result = "authenticated user";
            }
            else
            {
                result = "Invalid User Credentials";
            }
            return result;
        }
    }
}