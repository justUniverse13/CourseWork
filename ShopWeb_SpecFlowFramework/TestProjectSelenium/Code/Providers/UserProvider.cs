using TestProjectSelenium.Code.Dto;

namespace TestProjectSelenium.Code.Providers
{
    class UserProvider
    {
        public static UserDto Admin => new UserDto()
        {
            Login = "automationtesting",
            Password = "automationtesting123",
            Name = "Admin",
            LastName = "Testovich"
        };
    }
}
