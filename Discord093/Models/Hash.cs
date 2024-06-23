namespace Discord093.Models;

public readonly struct Hash(string value)
{
	public string Value { get; } = value;
}
