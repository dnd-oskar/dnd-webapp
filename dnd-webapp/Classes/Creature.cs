using System.Drawing;

namespace dndwebapp.Classes
{
    public class Creature
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public CreatureCategory Category { get; set; } = CreatureCategory.Humanoid;
        public string? SubCategory { get; set; }
        public DndSize Size { get; set; } = DndSize.Medium;
        public Alignment Alignment { get; set; } = Alignment.Unaligned;
        public int ArmorClass { get; set; }
        public int MaxHp { get; set; }
        public int CurrentHp { get; set; }
        public int TemporaryHp { get; set; }
        public Speed Speed { get; set; } = new();
        public Sense Sense { get; set; } = new();

        public int ProficiencyBonus { get; set; }

        public DndAttribute Strength = new();
        public DndAttribute Dexterity = new();
        public DndAttribute Constitution = new();
        public DndAttribute Intelligence = new();
        public DndAttribute Wisdom = new();
        public DndAttribute Charisma = new();

        public List<string> Languages { get; set; } = [];
        public bool Telepathic { get; set; }

        public DamageBehavior DamageImmunities { get; set; } = new();
        public DamageBehavior DamageResistances { get; set; } = new();
        public DamageBehavior DamageVulnerabilities { get; set; } = new();

        public HashSet<Condition> ConditionImmunities { get; set; } = [];

        public HashSet<DndAttributeType> ProficientSavingThrows { get; set; } = [];

        public HashSet<Skill> ProficientSkills { get; set; } = [];

        public List<string> AdditionalTraits { get; set; } = [];

        public Abilities Abilities { get; set; } = new();

        public SpellAbilities? SpellAbilities { get; set; }

        public int? SpellCastingModifier { 
            get { 
                if (SpellAbilities != null)
                {
                    return GetAttribute(SpellAbilities.SpellCastingAttribute).Modifier + ProficiencyBonus;
                }

                return null;
            } 
        }

        private DndAttribute GetAttribute(DndAttributeType type)
        {
            switch (type)
            {
                case DndAttributeType.Strength: return Strength;
                case DndAttributeType.Dexterity: return Dexterity;
                case DndAttributeType.Constitution: return Constitution;
                case DndAttributeType.Intelligence: return Intelligence;
                case DndAttributeType.Wisdom: return Wisdom;
                case DndAttributeType.Charisma: return Charisma;
            }

            throw new ArgumentException("Attribute unknown");
        }
    }

    public enum CreatureCategory
    {
        Aberration,
        Animal,
        Celestial,
        Construct,
        Dragon,
        Elemental,
        Fey,
        Fiend,
        Giant,
        Humanoid,
        Monstrosity,
        Ooze,
        Plant,
        Undead
    }
}
