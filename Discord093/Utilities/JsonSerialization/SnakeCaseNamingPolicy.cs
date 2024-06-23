using System.Text.Json;

namespace Discord093.Utilities.JsonSerialization;

public class SnakeCaseNamingPolicy : JsonNamingPolicy
{
	public override string ConvertName(string name)
		=> String.Concat(
			name.Select((x, i) => (i > 0) && Char.IsUpper(x) ? "_" + x.ToString().ToLower() : x.ToString().ToLower())
		);
}
