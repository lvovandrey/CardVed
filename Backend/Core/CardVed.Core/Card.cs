namespace CardVed.Core
{
    /// <summary>
    /// Card - a program object that is an approximate analogue of a paper card with an image.
    /// </summary>
    public class Card
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required string Image { get; set; }
        public required Guid Id { get; set; }
        public required DateTimeOffset CreatedAt { get; set; }
        public required string SoundUrl { get; set; }
    }
}