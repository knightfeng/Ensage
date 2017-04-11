﻿namespace Evader.EvadableAbilities.Units.AncientProwlerShaman
{
    using Base;
    using Base.Interfaces;

    using Ensage;

    using Modifiers;

    using static Data.AbilityNames;

    internal class Petrify : EvadableAbility, IModifier
    {
        public Petrify(Ability ability)
            : base(ability)
        {
            Modifier = new EvadableModifier(HeroTeam, EvadableModifier.GetHeroType.ModifierSource);

            Modifier.AllyCounterAbilities.Add(Lotus);
            Modifier.AllyCounterAbilities.Add(FortunesEnd);
            Modifier.AllyCounterAbilities.Add(Manta);
            Modifier.AllyCounterAbilities.Add(Eul);
            Modifier.AllyCounterAbilities.AddRange(AllyPurges);
        }

        public EvadableModifier Modifier { get; }

        public override void Check()
        {
        }

        public override void Draw()
        {
        }

        public override float GetRemainingTime(Hero hero = null)
        {
            return 0;
        }
    }
}