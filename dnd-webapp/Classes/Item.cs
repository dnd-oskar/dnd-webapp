namespace dndwebapp.Classes
{
    public class Item
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Rarity Rarity { get; set; } = Rarity.Common;
    }

    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        VeryRare,
        Legendary,
        Artifact
    }
}
