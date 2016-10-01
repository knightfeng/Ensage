﻿namespace Evader.UsableAbilities.Abilities
{
    using Base;

    using Core;

    using Ensage;
    using Ensage.Common.Extensions;

    using AbilityType = Core.AbilityType;

    internal class EchoSlam : NotTargetable
    {
        #region Fields

        private readonly float aftershockRadius;

        #endregion

        #region Constructors and Destructors

        public EchoSlam(Ability ability, AbilityType type, AbilityFlags flags = AbilityFlags.None)
            : base(ability, type, flags)
        {
            aftershockRadius = Ability.GetCastRange("earthshaker_aftershock") + 50;
        }

        #endregion

        #region Public Methods and Operators

        public override bool CanBeCasted(Unit unit)
        {
            // todo: fix ally check

            return !Sleeper.Sleeping && Ability.CanBeCasted() && (IsItem || Hero.CanCast())
                   && Hero.Distance2D(unit) <= aftershockRadius && CheckEnemy(unit);
        }

        #endregion
    }
}