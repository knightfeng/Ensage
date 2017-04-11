﻿namespace Kunkka.Abilities
{
    using Ensage;
    using Ensage.Common.Extensions;
    using Ensage.Common.Objects.UtilityObjects;

    using SharpDX;

    internal class GhostShip : IAbility
    {
        private readonly Sleeper sleeper = new Sleeper();

        public GhostShip(Ability ability)
        {
            Ability = ability;
            CastPoint = (float)ability.FindCastPoint();
            Radius = 560;
            Speed = ability.GetProjectileSpeed();
            AghanimSpeed = Speed * 4;
        }

        public float AghanimSpeed { get; private set; }

        public float CastRange => Ability.GetCastRange() + 150;

        public float Cooldown => Ability.Cooldown;

        public float GetSleepTime => CastPoint * 1000 + Game.Ping;

        public double HitTime { get; set; }

        public bool IsInPhase => Ability.IsInAbilityPhase;

        public bool JustCasted => Casted && Ability.Cooldown + 4 >= Ability.CooldownLength;

        public Vector3 Position { get; set; }

        public float Radius { get; }

        public float Speed { get; private set; }

        public Ability Ability { get; }

        public bool CanBeCasted => !sleeper.Sleeping && Ability.CanBeCasted();

        public bool Casted => Ability.AbilityState == AbilityState.OnCooldown;

        public float CastPoint { get; }

        public uint ManaCost => Ability.ManaCost;

        public void UseAbility(Vector3 targetPosition)
        {
            Ability.UseAbility(targetPosition);
            sleeper.Sleep(GetSleepTime + 300);
        }
    }
}