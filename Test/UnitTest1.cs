using Discord093.Models;
using Discord093.Models.Users;
using Discord093.Rest;

namespace Test;

[TestClass]
public class UnitTest1
{
	[TestMethod]
	public async Task TestMethod1()
	{
		Discord093Rest discord093Rest = new Discord093Rest(
			new Token
			{
				Type = TokenType.Bot,
				Value = ""
			}
		);

		User user = await discord093Rest.Users.GetCurrentUserAsync() ?? throw new NullReferenceException();

		Console.WriteLine(user);
		Assert.IsNotNull(user);
	}
}
