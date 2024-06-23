using Discord093.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Discord093.Utilities.JsonSerialization.JsonConverters;

public class LocaleJsonConverter : JsonConverter<Locale>
{
	public override Locale Read(
		ref Utf8JsonReader utf8JsonReader,
		Type type,
		JsonSerializerOptions jsonSerializerOptions
	)
		=> utf8JsonReader.GetString() switch
		{
			"id" => Locale.Indonesian,
			"da" => Locale.Danish,
			"de" => Locale.German,
			"en-GB" => Locale.EnglishUk,
			"en-US" => Locale.EnglishUs,
			"es-ES" => Locale.Spanish,
			"es-419" => Locale.SpanishLatam,
			"fr" => Locale.French,
			"hr" => Locale.Croatian,
			"it" => Locale.Italian,
			"lt" => Locale.Lithuanian,
			"hu" => Locale.Hungarian,
			"nl" => Locale.Dutch,
			"no" => Locale.Norwegian,
			"pl" => Locale.Polish,
			"pt-BR" => Locale.PortugueseBrazilian,
			"ro" => Locale.RomanianRomania,
			"fi" => Locale.Finnish,
			"sv-SE" => Locale.Swedish,
			"vi" => Locale.Vietnamese,
			"tr" => Locale.Turkish,
			"cs" => Locale.Czech,
			"el" => Locale.Greek,
			"bg" => Locale.Bulgarian,
			"ru" => Locale.Russian,
			"uk" => Locale.Ukrainian,
			"hi" => Locale.Hindi,
			"th" => Locale.Thai,
			"zh-CN" => Locale.ChineseChina,
			"ja" => Locale.Japanese,
			"zh-TW" => Locale.ChineseTaiwan,
			"ko" => Locale.Korean,
			_ => throw new JsonException("The value is not a valid locale."),
		};

	public override void Write(
		Utf8JsonWriter utf8JsonWriter,
		Locale locale,
		JsonSerializerOptions jsonSerializerOptions
	)
	{
		string value = locale switch
		{
			Locale.Indonesian => "id",
			Locale.Danish => "da",
			Locale.German => "de",
			Locale.EnglishUk => "en-GB",
			Locale.EnglishUs => "en-US",
			Locale.Spanish => "es-ES",
			Locale.SpanishLatam => "es-419",
			Locale.French => "fr",
			Locale.Croatian => "hr",
			Locale.Italian => "it",
			Locale.Lithuanian => "lt",
			Locale.Hungarian => "hu",
			Locale.Dutch => "nl",
			Locale.Norwegian => "no",
			Locale.Polish => "pl",
			Locale.PortugueseBrazilian => "pt-BR",
			Locale.RomanianRomania => "ro",
			Locale.Finnish => "fi",
			Locale.Swedish => "sv-SE",
			Locale.Vietnamese => "vi",
			Locale.Turkish => "tr",
			Locale.Czech => "cs",
			Locale.Greek => "el",
			Locale.Bulgarian => "bg",
			Locale.Russian => "ru",
			Locale.Ukrainian => "uk",
			Locale.Hindi => "hi",
			Locale.Thai => "th",
			Locale.ChineseChina => "zh-CN",
			Locale.Japanese => "ja",
			Locale.ChineseTaiwan => "zh-TW",
			Locale.Korean => "ko",
			_ => throw new JsonException("The value is not a valid locale."),
		};

		utf8JsonWriter.WriteStringValue(value);
	}
}
