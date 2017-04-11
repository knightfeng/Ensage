﻿namespace ItemManager.Menus.Modules.GoldSpender
{
    using System.Collections.Generic;
    using System.Linq;

    using Ensage;
    using Ensage.Common.Menu;

    internal class GoldSpenderMenu
    {
        private AbilityToggler abilityToggler;

        private PriorityChanger priorityChanger;

        public GoldSpenderMenu(Menu mainMenu)
        {
            var menu = new Menu("Gold Spender", "goldSpender");

            var enabled = new MenuItem("spendGold", "Spend gold").SetValue(true);
            enabled.SetTooltip("Buy items when you are about to die");
            menu.AddItem(enabled);
            enabled.ValueChanged += (sender, args) => SpendGold = args.GetNewValue<bool>();
            SpendGold = enabled.IsActive();

            var hpThreshold = new MenuItem("hpThreshold", "HP threshold").SetValue(new Slider(150, 1, 500));
            hpThreshold.SetTooltip("Buy items if you have less HP");
            menu.AddItem(hpThreshold);
            hpThreshold.ValueChanged += (sender, args) => HpThreshold = args.GetNewValue<Slider>().Value;
            HpThreshold = hpThreshold.GetValue<Slider>().Value;

            var hpThresholdPct = new MenuItem("hpThresholdPct", "HP% threshold").SetValue(new Slider(20, 1, 40));
            hpThresholdPct.SetTooltip("Buy items if you have less HP in %");
            menu.AddItem(hpThresholdPct);
            hpThresholdPct.ValueChanged += (sender, args) => HpThresholdPct = args.GetNewValue<Slider>().Value;
            HpThresholdPct = hpThresholdPct.GetValue<Slider>().Value;

            var enemyDistance = new MenuItem("enemyDistance", "Enemy distance").SetValue(new Slider(600, 0, 2000));
            enemyDistance.SetTooltip("Check enemy in range before buying");
            menu.AddItem(enemyDistance);
            enemyDistance.ValueChanged += (sender, args) => EnemyDistance = args.GetNewValue<Slider>().Value;
            EnemyDistance = enemyDistance.GetValue<Slider>().Value;

            menu.AddItem(
                new MenuItem("itemsToggler", "Enabled items:").SetValue(
                    abilityToggler = new AbilityToggler(ItemsToBuy.ToDictionary(x => x.Key, x => true))));

            menu.AddItem(
                new MenuItem("itemsPriority", "Items priority:").SetValue(
                    priorityChanger = new PriorityChanger(ItemsToBuy.Select(x => x.Key).ToList())));

            var buyback = new MenuItem("buyback", "Save for buyback after (mins)").SetValue(new Slider(30, 0, 60));
            menu.AddItem(buyback);
            buyback.ValueChanged += (sender, args) => SaveForBuyback = args.GetNewValue<Slider>().Value;
            SaveForBuyback = buyback.GetValue<Slider>().Value;

            mainMenu.AddSubMenu(menu);
        }

        public int EnemyDistance { get; private set; }

        public int HpThreshold { get; private set; }

        public int HpThresholdPct { get; private set; }

        public Dictionary<string, AbilityId> ItemsToBuy { get; } = new Dictionary<string, AbilityId>
        {
            { "item_smoke_of_deceit", AbilityId.item_smoke_of_deceit },
            { "item_dust", AbilityId.item_dust },
            { "item_tome_of_knowledge", AbilityId.item_tome_of_knowledge },
            { "item_ward_sentry", AbilityId.item_ward_sentry },
            { "item_ward_observer", AbilityId.item_ward_observer },
            { "attribute_bonus", 0 },
            { "item_tpscroll", AbilityId.item_tpscroll }
        };

        public float SaveForBuyback { get; private set; }

        public bool SpendGold { get; private set; }

        public bool ItemEnabled(string itemName)
        {
            return abilityToggler.IsEnabled(itemName);
        }

        public uint ItemPriority(string itemName)
        {
            return priorityChanger.GetPriority(itemName);
        }
    }
}