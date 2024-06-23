using Discord093.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Discord093.Utilities.JsonSerialization.JsonConverters;

public class HashJsonConverter : JsonConverter<Hash>
{
	public override Hash Read(ref Utf8JsonReader utf8JsonReader, Type type, JsonSerializerOptions jsonSerializerOptions)
		=> new Hash(utf8JsonReader.GetString() ?? throw new JsonException("The value is not a valid hash."));

	public override void Write(Utf8JsonWriter utf8JsonWriter, Hash hash, JsonSerializerOptions jsonSerializerOptions)
		=> utf8JsonWriter.WriteStringValue(hash.Value.ToString());
}
