﻿namespace SimpleAbilityLeveling
{
    using System.Collections.Generic;

    internal class AbilityNames
    {
        public Dictionary<string, string> Names { get; } = new Dictionary<string, string>
        {
            { "Attribute Bonus", "attribute_bonus" },
            { "Mist Coil", "abaddon_death_coil" },
            { "Aphotic Shield", "abaddon_aphotic_shield" },
            { "Curse of Avernus", "abaddon_frostmourne" },
            { "Borrowed Time", "abaddon_borrowed_time" },
            { "Acid Spray", "alchemist_acid_spray" },
            { "Unstable Concoction", "alchemist_unstable_concoction" },
            { "Greevil's Greed", "alchemist_goblins_greed" },
            { "Chemical Rage", "alchemist_chemical_rage" },
            { "Cold Feet", "ancient_apparition_cold_feet" },
            { "Ice Vortex", "ancient_apparition_ice_vortex" },
            { "Chilling Touch", "ancient_apparition_chilling_touch" },
            { "Ice Blast", "ancient_apparition_ice_blast" },
            { "Mana Break", "antimage_mana_break" },
            { "Blink", "antimage_blink" },
            { "Spell Shield", "antimage_spell_shield" },
            { "Mana Void", "antimage_mana_void" },
            { "Flux", "arc_warden_flux" },
            { "Magnetic Field", "arc_warden_magnetic_field" },
            { "Spark Wraith", "arc_warden_spark_wraith" },
            { "Tempest Double", "arc_warden_tempest_double" },
            { "Berserker's Call", "axe_berserkers_call" },
            { "Battle Hunger", "axe_battle_hunger" },
            { "Counter Helix", "axe_counter_helix" },
            { "Culling Blade", "axe_culling_blade" },
            { "Enfeeble", "bane_enfeeble" },
            { "Brain Sap", "bane_brain_sap" },
            { "Nightmare", "bane_nightmare" },
            { "Fiend's Grip", "bane_fiends_grip" },
            { "Sticky Napalm", "batrider_sticky_napalm" },
            { "Flamebreak", "batrider_flamebreak" },
            { "Firefly", "batrider_firefly" },
            { "Flaming Lasso", "batrider_flaming_lasso" },
            { "Wild Axes", "beastmaster_wild_axes" },
            { "Call of the Wild", "beastmaster_call_of_the_wild" },
            { "Inner Beast", "beastmaster_inner_beast" },
            { "Primal Roar", "beastmaster_primal_roar" },
            { "Bloodrage", "bloodseeker_bloodrage" },
            { "Blood Rite", "bloodseeker_blood_bath" },
            { "Thirst", "bloodseeker_thirst" },
            { "Rupture", "bloodseeker_rupture" },
            { "Shuriken Toss", "bounty_hunter_shuriken_toss" },
            { "Jinada", "bounty_hunter_jinada" },
            { "Shadow Walk", "bounty_hunter_wind_walk" },
            { "Track", "bounty_hunter_track" },
            { "Thunder Clap", "brewmaster_thunder_clap" },
            { "Drunken Haze", "brewmaster_drunken_haze" },
            { "Drunken Brawler", "brewmaster_drunken_brawler" },
            { "Primal Split", "brewmaster_primal_split" },
            { "Viscous Nasal Goo", "bristleback_viscous_nasal_goo" },
            { "Quill Spray", "bristleback_quill_spray" },
            { "Bristleback", "bristleback_bristleback" },
            { "Warpath", "bristleback_warpath" },
            { "Spawn Spiderlings", "broodmother_spawn_spiderlings" },
            { "Spin Web", "broodmother_spin_web" },
            { "Incapacitating Bite", "broodmother_incapacitating_bite" },
            { "Insatiable Hunger", "broodmother_insatiable_hunger" },
            { "Hoof Stomp", "centaur_hoof_stomp" },
            { "Double Edge", "centaur_double_edge" },
            { "Return", "centaur_return" },
            { "Stampede", "centaur_stampede" },
            { "Chaos Bolt", "chaos_knight_chaos_bolt" },
            { "Reality Rift", "chaos_knight_reality_rift" },
            { "Chaos Strike", "chaos_knight_chaos_strike" },
            { "Phantasm", "chaos_knight_phantasm" },
            { "Penitence", "chen_penitence" },
            { "Test of Faith", "chen_test_of_faith" },
            { "Holy Persuasion", "chen_holy_persuasion" },
            { "Hand of God", "chen_hand_of_god" },
            { "Strafe", "clinkz_strafe" },
            { "Searing Arrows", "clinkz_searing_arrows" },
            { "Skeleton Walk", "clinkz_wind_walk" },
            { "Death Pact", "clinkz_death_pact" },
            { "Battery Assault", "rattletrap_battery_assault" },
            { "Power Cogs", "rattletrap_power_cogs" },
            { "Rocket Flare", "rattletrap_rocket_flare" },
            { "Hookshot", "rattletrap_hookshot" },
            { "Crystal Nova", "crystal_maiden_crystal_nova" },
            { "Frostbite", "crystal_maiden_frostbite" },
            { "Arcane Aura", "crystal_maiden_brilliance_aura" },
            { "Freezing Field", "crystal_maiden_freezing_field" },
            { "Vacuum", "dark_seer_vacuum" },
            { "Ion Shell", "dark_seer_ion_shell" },
            { "Surge", "dark_seer_surge" },
            { "Wall of Replica", "dark_seer_wall_of_replica" },
            { "Poison Touch", "dazzle_poison_touch" },
            { "Shallow Grave", "dazzle_shallow_grave" },
            { "Shadow Wave", "dazzle_shadow_wave" },
            { "Weave", "dazzle_weave" },
            { "Crypt Swarm", "death_prophet_carrion_swarm" },
            { "Silence", "death_prophet_silence" },
            { "Spirit Siphon", "death_prophet_spirit_siphon" },
            { "Exorcism", "death_prophet_exorcism" },
            { "Thunder Strike", "disruptor_thunder_strike" },
            { "Glimpse", "disruptor_glimpse" },
            { "Kinetic Field", "disruptor_kinetic_field" },
            { "Static Storm", "disruptor_static_storm" },
            { "Devour", "doom_bringer_devour" },
            { "Scorched Earth", "doom_bringer_scorched_earth" },
            { "Infernal Blade", "doom_bringer_infernal_blade" },
            { "Doom", "doom_bringer_doom" },
            { "Breathe Fire", "dragon_knight_breathe_fire" },
            { "Dragon Tail", "dragon_knight_dragon_tail" },
            { "Dragon Blood", "dragon_knight_dragon_blood" },
            { "Elder Dragon Form", "dragon_knight_elder_dragon_form" },
            { "Frost Arrows", "drow_ranger_frost_arrows" },
            { "Gust", "drow_ranger_wave_of_silence" },
            { "Precision Aura", "drow_ranger_trueshot" },
            { "Marksmanship", "drow_ranger_marksmanship" },
            { "Boulder Smash", "earth_spirit_boulder_smash" },
            { "Rolling Boulder", "earth_spirit_rolling_boulder" },
            { "Geomagnetic Grip", "earth_spirit_geomagnetic_grip" },
            { "Magnetize", "earth_spirit_magnetize" },
            { "Fissure", "earthshaker_fissure" },
            { "Enchant Totem", "earthshaker_enchant_totem" },
            { "Aftershock", "earthshaker_aftershock" },
            { "Echo Slam", "earthshaker_echo_slam" },
            { "Echo Stomp", "elder_titan_echo_stomp" },
            { "Astral Spirit", "elder_titan_ancestral_spirit" },
            { "Natural Order", "elder_titan_natural_order" },
            { "Earth Splitter", "elder_titan_earth_splitter" },
            { "Searing Chains", "ember_spirit_searing_chains" },
            { "Sleight of Fist", "ember_spirit_sleight_of_fist" },
            { "Flame Guard", "ember_spirit_flame_guard" },
            { "Fire Remnant", "ember_spirit_fire_remnant" },
            { "Untouchable", "enchantress_untouchable" },
            { "Enchant", "enchantress_enchant" },
            { "Nature's Attendants", "enchantress_natures_attendants" },
            { "Impetus", "enchantress_impetus" },
            { "Malefice", "enigma_malefice" },
            { "Demonic Conversion", "enigma_demonic_conversion" },
            { "Midnight Pulse", "enigma_midnight_pulse" },
            { "Black Hole", "enigma_black_hole" },
            { "Time Walk", "faceless_void_time_walk" },
            { "Time Dilation", "faceless_void_time_dilation" },
            { "Time Lock", "faceless_void_time_lock" },
            { "Chronosphere", "faceless_void_chronosphere" },
            { "Rocket Barrage", "gyrocopter_rocket_barrage" },
            { "Homing Missile", "gyrocopter_homing_missile" },
            { "Flak Cannon", "gyrocopter_flak_cannon" },
            { "Call Down", "gyrocopter_call_down" },
            { "Inner Vitality", "huskar_inner_vitality" },
            { "Burning Spear", "huskar_burning_spear" },
            { "Berserker's Blood", "huskar_berserkers_blood" },
            { "Life Break", "huskar_life_break" },
            { "Quas", "invoker_quas" },
            { "Wex", "invoker_wex" },
            { "Exort", "invoker_exort" },
            { "Invoke", "invoker_invoke" },
            { "Tether", "wisp_tether" },
            { "Spirits", "wisp_spirits" },
            { "Overcharge", "wisp_overcharge" },
            { "Relocate", "wisp_relocate" },
            { "Dual Breath", "jakiro_dual_breath" },
            { "Ice Path", "jakiro_ice_path" },
            { "Liquid Fire", "jakiro_liquid_fire" },
            { "Macropyre", "jakiro_macropyre" },
            { "Blade Fury", "juggernaut_blade_fury" },
            { "Healing Ward", "juggernaut_healing_ward" },
            { "Blade Dance", "juggernaut_blade_dance" },
            { "Omnislash", "juggernaut_omni_slash" },
            { "Illuminate", "keeper_of_the_light_illuminate" },
            { "Mana Leak", "keeper_of_the_light_mana_leak" },
            { "Chakra Magic", "keeper_of_the_light_chakra_magic" },
            { "Spirit Form", "keeper_of_the_light_spirit_form" },
            { "Torrent", "kunkka_torrent" },
            { "Tidebringer", "kunkka_tidebringer" },
            { "X Marks the Spot", "kunkka_x_marks_the_spot" },
            { "Ghostship", "kunkka_ghostship" },
            { "Overwhelming Odds", "legion_commander_overwhelming_odds" },
            { "Press The Attack", "legion_commander_press_the_attack" },
            { "Moment of Courage", "legion_commander_moment_of_courage" },
            { "Duel", "legion_commander_duel" },
            { "Split Earth", "leshrac_split_earth" },
            { "Diabolic Edict", "leshrac_diabolic_edict" },
            { "Lightning Storm", "leshrac_lightning_storm" },
            { "Pulse Nova", "leshrac_pulse_nova" },
            { "Frost Blast", "lich_frost_nova" },
            { "Ice Armor", "lich_frost_armor" },
            { "Sacrifice", "lich_dark_ritual" },
            { "Chain Frost", "lich_chain_frost" },
            { "Rage", "life_stealer_rage" },
            { "Feast", "life_stealer_feast" },
            { "Open Wounds", "life_stealer_open_wounds" },
            { "Infest", "life_stealer_infest" },
            { "Dragon Slave", "lina_dragon_slave" },
            { "Light Strike Array", "lina_light_strike_array" },
            { "Fiery Soul", "lina_fiery_soul" },
            { "Laguna Blade", "lina_laguna_blade" },
            { "Earth Spike", "lion_impale" },
            { "Hex", "lion_voodoo" },
            { "Mana Drain", "lion_mana_drain" },
            { "Finger of Death", "lion_finger_of_death" },
            { "Summon Spirit Bear", "lone_druid_spirit_bear" },
            { "Rabid", "lone_druid_rabid" },
            { "Savage Roar", "lone_druid_savage_roar" },
            { "True Form", "lone_druid_true_form" },
            { "Lucent Beam", "luna_lucent_beam" },
            { "Moon Glaive", "luna_moon_glaive" },
            { "Lunar Blessing", "luna_lunar_blessing" },
            { "Eclipse", "luna_eclipse" },
            { "Summon Wolves", "lycan_summon_wolves" },
            { "Howl", "lycan_howl" },
            { "Feral Impulse", "lycan_feral_impulse" },
            { "Shapeshift", "lycan_shapeshift" },
            { "Shockwave", "magnataur_shockwave" },
            { "Empower", "magnataur_empower" },
            { "Skewer", "magnataur_skewer" },
            { "Reverse Polarity", "magnataur_reverse_polarity" },
            { "Split Shot", "medusa_split_shot" },
            { "Mystic Snake", "medusa_mystic_snake" },
            { "Mana Shield", "medusa_mana_shield" },
            { "Stone Gaze", "medusa_stone_gaze" },
            { "Earthbind", "meepo_earthbind" },
            { "Poof", "meepo_poof" },
            { "Geostrike", "meepo_geostrike" },
            { "Divided We Stand", "meepo_divided_we_stand" },
            { "Starstorm", "mirana_starfall" },
            { "Sacred Arrow", "mirana_arrow" },
            { "Leap", "mirana_leap" },
            { "Moonlight Shadow", "mirana_invis" },
            { "Boundless Strike", "monkey_king_boundless_strike" },
            { "Tree Dance", "monkey_king_tree_dance" },
            { "Jingu Mastery", "monkey_king_jingu_mastery" },
            { "Wukong's Command", "monkey_king_wukongs_command" },
            { "Waveform", "morphling_waveform" },
            { "Adaptive Strike (Agility)", "morphling_adaptive_strike_agi" },
            { "Attribute Shift (Strength Gain)", "morphling_morph_str" },
            { "Attribute Shift (Agility Gain)", "morphling_morph_agi" },
            { "Morph", "morphling_morph" },
            { "Mirror Image", "naga_siren_mirror_image" },
            { "Ensnare", "naga_siren_ensnare" },
            { "Rip Tide", "naga_siren_rip_tide" },
            { "Song of the Siren", "naga_siren_song_of_the_siren" },
            { "Sprout", "furion_sprout" },
            { "Teleportation", "furion_teleportation" },
            { "Nature's Call", "furion_force_of_nature" },
            { "Wrath of Nature", "furion_wrath_of_nature" },
            { "Death Pulse", "necrolyte_death_pulse" },
            { "Heartstopper Aura", "necrolyte_heartstopper_aura" },
            { "Ghost Shroud", "necrolyte_sadist" },
            { "Reaper's Scythe", "necrolyte_reapers_scythe" },
            { "Void", "night_stalker_void" },
            { "Crippling Fear", "night_stalker_crippling_fear" },
            { "Hunter in the Night", "night_stalker_hunter_in_the_night" },
            { "Darkness", "night_stalker_darkness" },
            { "Impale", "nyx_assassin_impale" },
            { "Mana Burn", "nyx_assassin_mana_burn" },
            { "Spiked Carapace", "nyx_assassin_spiked_carapace" },
            { "Vendetta", "nyx_assassin_vendetta" },
            { "Fireblast", "ogre_magi_fireblast" },
            { "Ignite", "ogre_magi_ignite" },
            { "Bloodlust", "ogre_magi_bloodlust" },
            { "Multicast", "ogre_magi_multicast" },
            { "Purification", "omniknight_purification" },
            { "Repel", "omniknight_repel" },
            { "Degen Aura", "omniknight_degen_aura" },
            { "Guardian Angel", "omniknight_guardian_angel" },
            { "Fortune's End", "oracle_fortunes_end" },
            { "Fate's Edict", "oracle_fates_edict" },
            { "Purifying Flames", "oracle_purifying_flames" },
            { "False Promise", "oracle_false_promise" },
            { "Arcane Orb", "obsidian_destroyer_arcane_orb" },
            { "Astral Imprisonment", "obsidian_destroyer_astral_imprisonment" },
            { "Essence Aura", "obsidian_destroyer_essence_aura" },
            { "Sanity's Eclipse", "obsidian_destroyer_sanity_eclipse" },
            { "Stifling Dagger", "phantom_assassin_stifling_dagger" },
            { "Phantom Strike", "phantom_assassin_phantom_strike" },
            { "Blur", "phantom_assassin_blur" },
            { "Coup de Grace", "phantom_assassin_coup_de_grace" },
            { "Spirit Lance", "phantom_lancer_spirit_lance" },
            { "Doppelganger", "phantom_lancer_doppelwalk" },
            { "Phantom Rush", "phantom_lancer_phantom_edge" },
            { "Juxtapose", "phantom_lancer_juxtapose" },
            { "Icarus Dive", "phoenix_icarus_dive" },
            { "Fire Spirits", "phoenix_fire_spirits" },
            { "Sun Ray", "phoenix_sun_ray" },
            { "Supernova", "phoenix_supernova" },
            { "Illusory Orb", "puck_illusory_orb" },
            { "Waning Rift", "puck_waning_rift" },
            { "Phase Shift", "puck_phase_shift" },
            { "Dream Coil", "puck_dream_coil" },
            { "Meat Hook", "pudge_meat_hook" },
            { "Rot", "pudge_rot" },
            { "Flesh Heap", "pudge_flesh_heap" },
            { "Dismember", "pudge_dismember" },
            { "Nether Blast", "pugna_nether_blast" },
            { "Decrepify", "pugna_decrepify" },
            { "Nether Ward", "pugna_nether_ward" },
            { "Life Drain", "pugna_life_drain" },
            { "Shadow Strike", "queenofpain_shadow_strike" },
            { "Queen of Pain Blink", "queenofpain_blink" },
            { "Scream Of Pain", "queenofpain_scream_of_pain" },
            { "Sonic Wave", "queenofpain_sonic_wave" },
            { "Plasma Field", "razor_plasma_field" },
            { "Static Link", "razor_static_link" },
            { "Unstable Current", "razor_unstable_current" },
            { "Eye of the Storm", "razor_eye_of_the_storm" },
            { "Smoke Screen", "riki_smoke_screen" },
            { "Blink Strike", "riki_blink_strike" },
            { "Cloak and Dagger", "riki_permanent_invisibility" },
            { "Tricks of the Trade", "riki_tricks_of_the_trade" },
            { "Telekinesis", "rubick_telekinesis" },
            { "Fade Bolt", "rubick_fade_bolt" },
            { "Null Field", "rubick_null_field" },
            { "Spell Steal", "rubick_spell_steal" },
            { "Burrowstrike", "sandking_burrowstrike" },
            { "Sand Storm", "sandking_sand_storm" },
            { "Caustic Finale", "sandking_caustic_finale" },
            { "Epicenter", "sandking_epicenter" },
            { "Disruption", "shadow_demon_disruption" },
            { "Soul Catcher", "shadow_demon_soul_catcher" },
            { "Shadow Poison", "shadow_demon_shadow_poison" },
            { "Demonic Purge", "shadow_demon_demonic_purge" },
            { "Shadowraze", "nevermore_shadowraze1" },
            { "Necromastery", "nevermore_necromastery" },
            { "Presence of the Dark Lord", "nevermore_dark_lord" },
            { "Requiem of Souls", "nevermore_requiem" },
            { "Ether Shock", "shadow_shaman_ether_shock" },
            { "Shadow Shaman Hex", "shadow_shaman_voodoo" },
            { "Shackles", "shadow_shaman_shackles" },
            { "Mass Serpent Ward", "shadow_shaman_mass_serpent_ward" },
            { "Arcane Curse", "silencer_curse_of_the_silent" },
            { "Glaives of Wisdom", "silencer_glaives_of_wisdom" },
            { "Last Word", "silencer_last_word" },
            { "Global Silence", "silencer_global_silence" },
            { "Arcane Bolt", "skywrath_mage_arcane_bolt" },
            { "Concussive Shot", "skywrath_mage_concussive_shot" },
            { "Ancient Seal", "skywrath_mage_ancient_seal" },
            { "Mystic Flare", "skywrath_mage_mystic_flare" },
            { "Guardian Sprint", "slardar_sprint" },
            { "Slithereen Crush", "slardar_slithereen_crush" },
            { "Bash of the Deep", "slardar_bash" },
            { "Corrosive Haze", "slardar_amplify_damage" },
            { "Dark Pact", "slark_dark_pact" },
            { "Pounce", "slark_pounce" },
            { "Essence Shift", "slark_essence_shift" },
            { "Shadow Dance", "slark_shadow_dance" },
            { "Shrapnel", "sniper_shrapnel" },
            { "Headshot", "sniper_headshot" },
            { "Take Aim", "sniper_take_aim" },
            { "Assassinate", "sniper_assassinate" },
            { "Spectral Dagger", "spectre_spectral_dagger" },
            { "Desolate", "spectre_desolate" },
            { "Dispersion", "spectre_dispersion" },
            { "Haunt", "spectre_haunt" },
            { "Charge of Darkness", "spirit_breaker_charge_of_darkness" },
            { "Empowering Haste", "spirit_breaker_empowering_haste" },
            { "Greater Bash", "spirit_breaker_greater_bash" },
            { "Nether Strike", "spirit_breaker_nether_strike" },
            { "Static Remnant", "storm_spirit_static_remnant" },
            { "Electric Vortex", "storm_spirit_electric_vortex" },
            { "Overload", "storm_spirit_overload" },
            { "Ball Lightning", "storm_spirit_ball_lightning" },
            { "Storm Hammer", "sven_storm_bolt" },
            { "Great Cleave", "sven_great_cleave" },
            { "Warcry", "sven_warcry" },
            { "God's Strength", "sven_gods_strength" },
            { "Proximity Mines", "techies_land_mines" },
            { "Stasis Trap", "techies_stasis_trap" },
            { "Blast Off!", "techies_suicide" },
            { "Remote Mines", "techies_remote_mines" },
            { "Refraction", "templar_assassin_refraction" },
            { "Meld", "templar_assassin_meld" },
            { "Psi Blades", "templar_assassin_psi_blades" },
            { "Psionic Trap", "templar_assassin_psionic_trap" },
            { "Reflection", "terrorblade_reflection" },
            { "Conjure Image", "terrorblade_conjure_image" },
            { "Metamorphosis", "terrorblade_metamorphosis" },
            { "Sunder", "terrorblade_sunder" },
            { "Gush", "tidehunter_gush" },
            { "Kraken Shell", "tidehunter_kraken_shell" },
            { "Anchor Smash", "tidehunter_anchor_smash" },
            { "Ravage", "tidehunter_ravage" },
            { "Whirling Death", "shredder_whirling_death" },
            { "Timber Chain", "shredder_timber_chain" },
            { "Reactive Armor", "shredder_reactive_armor" },
            { "Chakram", "shredder_chakram" },
            { "Laser", "tinker_laser" },
            { "Heat-Seeking Missile", "tinker_heat_seeking_missile" },
            { "March of the Machines", "tinker_march_of_the_machines" },
            { "Rearm", "tinker_rearm" },
            { "Avalanche", "tiny_avalanche" },
            { "Toss", "tiny_toss" },
            { "Tree Grab", "tiny_craggy_exterior" },
            { "Grow", "tiny_grow" },
            { "Nature's Guise", "treant_natures_guise" },
            { "Leech Seed", "treant_leech_seed" },
            { "Living Armor", "treant_living_armor" },
            { "Overgrowth", "treant_overgrowth" },
            { "Berserker's Rage", "troll_warlord_berserkers_rage" },
            { "Whirling Axes (Ranged)", "troll_warlord_whirling_axes_melee" },
            { "Fervor", "troll_warlord_fervor" },
            { "Battle Trance", "troll_warlord_battle_trance" },
            { "Ice Shards", "tusk_ice_shards" },
            { "Snowball", "tusk_snowball" },
            { "Frozen Sigil", "tusk_frozen_sigil" },
            { "Walrus PUNCH!", "tusk_walrus_punch" },
            { "Firestorm", "abyssal_underlord_firestorm" },
            { "Pit of Malice", "abyssal_underlord_pit_of_malice" },
            { "Atrophy Aura", "abyssal_underlord_atrophy_aura" },
            { "Dark Rift", "abyssal_underlord_dark_rift" },
            { "Decay", "undying_decay" },
            { "Soul Rip", "undying_soul_rip" },
            { "Tombstone", "undying_tombstone" },
            { "Flesh Golem", "undying_flesh_golem" },
            { "Earthshock", "ursa_earthshock" },
            { "Overpower", "ursa_overpower" },
            { "Fury Swipes", "ursa_fury_swipes" },
            { "Enrage", "ursa_enrage" },
            { "Magic Missile", "vengefulspirit_magic_missile" },
            { "Wave of Terror", "vengefulspirit_wave_of_terror" },
            { "Vengeance Aura", "vengefulspirit_command_aura" },
            { "Nether Swap", "vengefulspirit_nether_swap" },
            { "Venomous Gale", "venomancer_venomous_gale" },
            { "Poison Sting", "venomancer_poison_sting" },
            { "Plague Ward", "venomancer_plague_ward" },
            { "Poison Nova", "venomancer_poison_nova" },
            { "Poison Attack", "viper_poison_attack" },
            { "Nethertoxin", "viper_nethertoxin" },
            { "Corrosive Skin", "viper_corrosive_skin" },
            { "Viper Strike", "viper_viper_strike" },
            { "Grave Chill", "visage_grave_chill" },
            { "Soul Assumption", "visage_soul_assumption" },
            { "Gravekeeper's Cloak", "visage_gravekeepers_cloak" },
            { "Summon Familiars", "visage_summon_familiars" },
            { "Fatal Bonds", "warlock_fatal_bonds" },
            { "Shadow Word", "warlock_shadow_word" },
            { "Upheaval", "warlock_upheaval" },
            { "Chaotic Offering", "warlock_rain_of_chaos" },
            { "The Swarm", "weaver_the_swarm" },
            { "Shukuchi", "weaver_shukuchi" },
            { "Geminate Attack", "weaver_geminate_attack" },
            { "Time Lapse", "weaver_time_lapse" },
            { "Shackleshot", "windrunner_shackleshot" },
            { "Powershot", "windrunner_powershot" },
            { "Windrun", "windrunner_windrun" },
            { "Focus Fire", "windrunner_focusfire" },
            { "Arctic Burn", "winter_wyvern_arctic_burn" },
            { "Splinter Blast", "winter_wyvern_splinter_blast" },
            { "Cold Embrace", "winter_wyvern_cold_embrace" },
            { "Winter's Curse", "winter_wyvern_winters_curse" },
            { "Paralyzing Cask", "witch_doctor_paralyzing_cask" },
            { "Voodoo Restoration", "witch_doctor_voodoo_restoration" },
            { "Maledict", "witch_doctor_maledict" },
            { "Death Ward", "witch_doctor_death_ward" },
            { "Wraithfire Blast", "skeleton_king_hellfire_blast" },
            { "Vampiric Aura", "skeleton_king_vampiric_aura" },
            { "Mortal Strike", "skeleton_king_mortal_strike" },
            { "Reincarnation", "skeleton_king_reincarnation" },
            { "Arc Lightning", "zuus_arc_lightning" },
            { "Lightning Bolt", "zuus_lightning_bolt" },
            { "Static Field", "zuus_static_field" },
            { "Thundergod's Wrath", "zuus_thundergods_wrath" },
            { "Bramble Maze", "dark_willow_bramble_maze" },
            { "Shadow Realm", "dark_willow_shadow_realm" },
            { "Cursed Crown", "dark_willow_cursed_crown" },
            { "Terrorize", "dark_willow_terrorize" },
            { "Swashbuckle", "pangolier_swashbuckle" },
            { "Shield Crash", "pangolier_shield_crash" },
            { "Heartpiercer", "pangolier_heartpiercer" },
            { "Rolling Thunder", "pangolier_gyroshell" },
        };
    }
}