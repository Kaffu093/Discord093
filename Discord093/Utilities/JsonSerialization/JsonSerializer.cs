using Discord093.Utilities.JsonSerialization.JsonConverters;
using System.Text;
using System.Text.Json;

namespace Discord093.Utilities.JsonSerialization;

public class JsonSerializer
{
	private static readonly JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions
	{
		WriteIndented = true,
		Converters =
		{
			new SnowflakeJsonConverter(),
			new HashJsonConverter(),
			new LocaleJsonConverter(),
			new OptionalJsonConverter()
		},
		PropertyNamingPolicy = new SnakeCaseNamingPolicy()
	};

	public static async Task<string> SerializeAsync<T>(T obj)
	{
		using MemoryStream stream = new MemoryStream();
		await System.Text.Json.JsonSerializer.SerializeAsync(stream, obj, JsonSerializer.JsonSerializerOptions);
		stream.Position = 0;
		using StreamReader reader = new StreamReader(stream);
		return await reader.ReadToEndAsync();
	}

	public static async Task<T> DeserializeAsync<T>(string json)
	{
		using MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(json));
		return await System.Text.Json.JsonSerializer.DeserializeAsync<T>(stream, JsonSerializer.JsonSerializerOptions)
			?? throw new NullReferenceException();
	}
}
