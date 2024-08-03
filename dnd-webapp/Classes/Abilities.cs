namespace dndwebapp.Classes
{
    public class Abilities
    {
        public List<DndAction> Actions { get; set; } = [];

        public List<DndAction> BonusActions { get; set; } = [];

        public List<DndAction> Reactions { get; set; } = [];
    }

    public class DndAction
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class SpellAbilities
    {
        public List<Spell> spells { get; set; } = [];
        public Dictionary<int, int> SpellSlots { get; set; } = [];

        public DndAttributeType SpellCastingAttribute { get; set; }
    }

    public class Spell
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DndAttributeType? SavingThrow { get; set; }
        public bool AttackRoll { get; set; }
    }
}
