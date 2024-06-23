using Discord093.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Discord093.Utilities.JsonSerialization.JsonConverters;

public class OptionalJsonConverter : JsonConverterFactory
{
	public override bool CanConvert(Type type)
		=> type.IsGenericType && (type.GetGenericTypeDefinition() == typeof(Optional<>));

	public override JsonConverter CreateConverter(Type type, JsonSerializerOptions jsonSerializerOptions)
		=> (JsonConverter)Activator.CreateInstance(
			typeof(OptionalJsonConverterInner<>).MakeGenericType(type.GetGenericArguments()[0])
		)!;

	private class OptionalJsonConverterInner<T> : JsonConverter<Optional<T?>>
	{
		public override Optional<T?> Read(
			ref Utf8JsonReader utf8JsonReader,
			Type type,
			JsonSerializerOptions jsonSerializerOptions
		)
			=> new Optional<T?>(
				System.Text.Json.JsonSerializer.Deserialize<T?>(ref utf8JsonReader, jsonSerializerOptions)
			);

		public override void Write(
			Utf8JsonWriter utf8JsonWriter,
			Optional<T?> optional,
			JsonSerializerOptions jsonSerializerOptions
		)
			=> System.Text.Json.JsonSerializer.Serialize(utf8JsonWriter, optional.Value, jsonSerializerOptions);
	}
}
