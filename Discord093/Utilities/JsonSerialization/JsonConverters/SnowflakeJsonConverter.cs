using Discord093.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Discord093.Utilities.JsonSerialization.JsonConverters;

public class SnowflakeJsonConverter : JsonConverter<Snowflake>
{
	public override Snowflake Read(
		ref Utf8JsonReader utf8JsonReader,
		Type type,
		JsonSerializerOptions jsonSerializerOptions
	)
		=> new Snowflake(
			UInt64.Parse(utf8JsonReader.GetString() ?? throw new JsonException("The value is not a valid snowflake."))
		);

	public override void Write(
		Utf8JsonWriter utf8JsonWriter,
		Snowflake snowflake,
		JsonSerializerOptions jsonSerializerOptions
	)
		=> utf8JsonWriter.WriteStringValue(snowflake.Value.ToString());
}
