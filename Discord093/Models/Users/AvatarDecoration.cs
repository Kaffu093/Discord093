namespace Discord093.Models.Users;

public record AvatarDecoration
{
	public Hash Asset { get; init; }
	public Snowflake SkuId { get; init; }
}
