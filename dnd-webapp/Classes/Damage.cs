namespace dndwebapp.Classes
{
    public enum DamageType
    {
        Acid,
        Bludgeoning,
        Cold,
        Fire,
        Force,
        Lightning,
        Necrotic,
        Piercing,
        Poison,
        Psychic,
        Radiant,
        Slashing,
        Thunder
    }


    public class DamageBehavior
    {
        public Dictionary<DamageType, bool> DamageTypeMagicalDictionary { get; set; } = [];

        public bool Contains(DamageType damageType, bool magical)
        {
            if (DamageTypeMagicalDictionary.TryGetValue(damageType, out bool value)) {
                if (magical)
                {
                    return value;
                }

                return true;
            };

            return false;
        }
    }
}
