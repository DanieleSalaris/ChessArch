namespace Application.Core
{
    public record Boundaries
    {
        public Position Min {  get; init; } = new Position { X = 0, Y = 0};
        public Position Max { get; init; } = new Position { X = 0, Y = 0 };
    }
}
