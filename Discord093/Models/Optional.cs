namespace Discord093.Models;

public readonly struct Optional<T>(T? value)
{
	public bool HasValue { get; } = value != null;
	public T Value => this.HasValue ? value! : throw new InvalidOperationException("Optional has no value.");
}
