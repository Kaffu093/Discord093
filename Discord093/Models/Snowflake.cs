namespace Discord093.Models;

public readonly record struct Snowflake
{
	public Snowflake(ulong value)
	{
		this.Value = value;
		this.Timestamp = (long)((value >> 22) + 1420070400000L);
		this.InternalWorkerId = (byte)((value & 0x3E0000) >> 17);
		this.InternalProcessId = (byte)((value & 0x1F000) >> 12);
		this.Increment = (ushort)(value & 0xFFF);
		this.DateTime = DateTimeOffset.FromUnixTimeMilliseconds(this.Timestamp).DateTime;
	}

	public ulong Value { get; init; }
	public long Timestamp { get; init; }
	public byte InternalWorkerId { get; init; }
	public byte InternalProcessId { get; init; }
	public ushort Increment { get; init; }
	public DateTimeOffset DateTime { get; init; }
}
