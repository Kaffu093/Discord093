using System.Net;
using System.Text.Json.Serialization;

namespace Discord093.Models;

public class DiscordApiException : Exception
{
	[JsonPropertyName("code")]
	public required HttpStatusCode HttpStatusCode { get; init; }

	[JsonPropertyName("message")]
	public new required string Message { get; init; }
}
