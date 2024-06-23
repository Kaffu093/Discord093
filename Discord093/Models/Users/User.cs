namespace Discord093.Models.Users;

public record User
{
	public required Snowflake Id { get; init; }
	public required string Username { get; init; }
	public required string Discriminator { get; init; }
	public required string? GlobalName { get; init; }
	public required Hash? Avatar { get; init; }
	public Optional<bool> Bot { get; init; }
	public Optional<bool> System { get; init; }
	public Optional<bool> MfaEnabled { get; init; }
	public Optional<Hash?> Banner { get; init; }
	public Optional<int?> AccentColor { get; init; }
	public Optional<Locale> Locale { get; init; }
	public Optional<bool> Verified { get; init; }
	public Optional<string?> Email { get; init; }
	public Optional<UserFlags> Flags { get; init; }
	public Optional<PremiumType> PremiumType { get; init; }
	public Optional<UserFlags> PublicFlags { get; init; }
	public Optional<AvatarDecoration> AvatarDecorationData { get; init; }
}
