using Discord093.Models;
using Discord093.Models.Users;
using Discord093.Utilities.JsonSerialization;

namespace Discord093.Rest.Endpoints;

public class UsersEndpoint(Discord093Rest discord093Rest)
{
	public async Task<User> GetCurrentUserAsync()
	{
		HttpResponseMessage response = await discord093Rest.HttpClient.GetAsync("users/@me");

		if (!response.IsSuccessStatusCode)
		{
			throw await JsonSerializer.DeserializeAsync<DiscordApiException>(await response.Content.ReadAsStringAsync())
				?? throw new DiscordApiException()
				{
					HttpStatusCode = response.StatusCode,
					Message = await response.Content.ReadAsStringAsync()
				};
		}

		return await JsonSerializer.DeserializeAsync<User>(await response.Content.ReadAsStringAsync())
			?? throw new NullReferenceException();
	}
}
