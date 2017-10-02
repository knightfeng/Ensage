﻿namespace Debugger.Menu
{
    using Ensage.SDK.Menu;

    internal interface IMenu
    {
        MenuFactory GameEventsMenu { get; }

        MenuFactory InformationMenu { get; }

        MenuFactory OnAddRemoveMenu { get; }

        MenuFactory OnChangeMenu { get; }

        MenuFactory OnExecuteOrderMenu { get; }

        MenuFactory OverlaySettingsMenu { get; }
    }
}