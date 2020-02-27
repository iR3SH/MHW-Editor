﻿using System.Collections.Generic;
using MHW_Template;

namespace MHW_Generator {
    public static partial class Program {
        private const string SPACER = "------------------------------------------------------";

        private static void GenCommonPl() {
            GenPlItemParam();
            GenPlPlayerParam();
            GenPlMantleParam();
            GenPlSkillParam();
        }

        private static void GenPlSkillParam() {
            var entries = new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Speed Eating 1 Drink Motion Speed", 8, typeof(float)),
            };

            GeneratePlDataProps("MHW_Editor.PlData", "PlSkillParam", new MhwStructData { // .plsp
                size = 2256,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".plsp"],
                entries = entries
            });
        }

        private static void GenPlMantleParam() {
            // 'Unk' counters.
            ushort i = 1;
            ushort k = 1;
            ushort l = 1;
            ushort m = 1;
            ushort n = 1;

            var entries = new List<MhwStructData.Entry> {
                new MhwStructData.Entry($"Unk: Unk{i++}", 8, typeof(float)),
                new MhwStructData.Entry($"Unk: Unk{i++}", 12, typeof(float)),
                new MhwStructData.Entry($"Unk: Unk{i++}", 16, typeof(float)),
                new MhwStructData.Entry($"Unk: Unk{i++}", 20, typeof(float)),
                new MhwStructData.Entry($"Unk: Unk{i++}", 24, typeof(float)),
                new MhwStructData.Entry($"Unk: Unk{i++}", 28, typeof(uint)),
                new MhwStructData.Entry($"Unk: Unk{i++}", 32, typeof(float)),
                new MhwStructData.Entry($"Unk: Unk{i++}", 36, typeof(float)),
                new MhwStructData.Entry($"Unk: Unk{i++}", 40, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry("Ghillie Mantle: Cooldown", 44, typeof(float)),
                new MhwStructData.Entry("Ghillie Mantle: Duration", 48, typeof(float)),
                new MhwStructData.Entry("Ghillie Mantle: Unk1", 52, typeof(float)),
                new MhwStructData.Entry("Ghillie Mantle: Unk2", 56, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry("Temporal Mantle: Cooldown", 60, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Duration", 64, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk1", 68, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk2", 72, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk3", 76, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk4", 80, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk5", 84, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk6", 88, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk7", 92, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk8", 96, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk9", 100, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk10", 104, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk11", 108, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk12", 112, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Duration Decrease Per Hit", 116, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry("Health Booster: Cooldown", 120, typeof(float)),
                new MhwStructData.Entry("Health Booster: Duration", 124, typeof(float)),
                new MhwStructData.Entry("Health Booster: Upgraded Duration", 128, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry("Rocksteady Mantle: Cooldown", 132, typeof(float)),
                new MhwStructData.Entry("Rocksteady Mantle: Duration", 136, typeof(float)),
                new MhwStructData.Entry("Rocksteady Mantle: Unk1", 140, typeof(float)),
                new MhwStructData.Entry("Rocksteady Mantle: Damage Resist", 144, typeof(float)),
                new MhwStructData.Entry("Rocksteady Mantle: Unk2", 148, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry("Challenger Mantle: Cooldown", 152, typeof(float)),
                new MhwStructData.Entry("Challenger Mantle: Duration", 156, typeof(float)),
                new MhwStructData.Entry("Challenger Mantle: Unk1", 160, typeof(float)),
                new MhwStructData.Entry("Challenger Mantle: Unk2", 164, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry("Vitality Mantle: Cooldown", 168, typeof(float)),
                new MhwStructData.Entry("Vitality Mantle: Duration", 172, typeof(float)),
                new MhwStructData.Entry("Vitality Mantle: Mantle Health", 176, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true)
            };

            const ulong elementalStartOffset = 180;

            var elementMantles = new List<string> {
                "Fireproof Mantle",
                "Waterproof Mantle",
                "Iceproof Mantle",
                "Thunderproof Mantle"
            };

            for (var s = 0; s < elementMantles.Count; s++) {
                entries.AddRange(new List<MhwStructData.Entry> {
                    new MhwStructData.Entry($"{elementMantles[s]}: Cooldown", elementalStartOffset + (ulong) s * 12, typeof(float)),
                    new MhwStructData.Entry($"{elementMantles[s]}: Duration", elementalStartOffset + 4 + (ulong) s * 12, typeof(float)),
                    new MhwStructData.Entry($"{elementMantles[s]}: Damage Reduction %", elementalStartOffset + 8 + (ulong) s * 12, typeof(float)),

                    new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true)
                });
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Dragonproof Mantle: Cooldown", 228, typeof(float)),
                new MhwStructData.Entry("Dragonproof Mantle: Duration", 232, typeof(float)),
                new MhwStructData.Entry("Dragonproof Mantle: Damage Reduction %", 236, typeof(float)),
                new MhwStructData.Entry("Dragonproof Mantle: Dragon Damage Multiplier", 240, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry("Cleanser Booster: Cooldown", 244, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Duration", 248, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Upgraded Duration", 252, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Unk1", 256, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Unk2", 260, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Unk3", 264, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Unk4", 268, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry("Glider Mantle: Cooldown", 272, typeof(float)),
                new MhwStructData.Entry("Glider Mantle: Duration", 276, typeof(float)),
                new MhwStructData.Entry("Glider Mantle: Mount Multiplier", 280, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry("Evasion Mantle: Cooldown", 284, typeof(float)),
                new MhwStructData.Entry("Evasion Mantle: Duration", 288, typeof(float)),
                new MhwStructData.Entry("Evasion Mantle: Attack Boost Duration", 292, typeof(float)),
                new MhwStructData.Entry("Evasion Mantle: Evasion Multiplier", 296, typeof(float)),
                new MhwStructData.Entry($"Evasion Mantle: Unk{k++}", 300, typeof(float)),
                new MhwStructData.Entry($"Evasion Mantle: Unk{k++}", 304, typeof(byte)),
                new MhwStructData.Entry($"Evasion Mantle: Unk{k++}", 305, typeof(ushort)),
                new MhwStructData.Entry($"Evasion Mantle: Unk{k++}", 307, typeof(ushort)),
                new MhwStructData.Entry($"Evasion Mantle: Unk{k++}", 309, typeof(float)),
                new MhwStructData.Entry($"Evasion Mantle: Unk{k++}", 313, typeof(ushort)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry("Impact Mantle: Cooldown", 315, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Duration", 319, typeof(float)),
                new MhwStructData.Entry($"Impact Mantle: Unk{l++}", 323, typeof(float)),
                new MhwStructData.Entry($"Impact Mantle: Unk{l++}", 327, typeof(float)),
                new MhwStructData.Entry($"Impact Mantle: Unk{l++}", 331, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Stun Weak", 335, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Stun Medium", 339, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Stun Strong", 343, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Stun Extreme", 347, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Stun Multiplier", 351, typeof(float)),
                new MhwStructData.Entry($"Impact Mantle: Unk{l++}", 355, typeof(float)),
                new MhwStructData.Entry($"Impact Mantle: Unk{l++}", 359, typeof(float)),
                new MhwStructData.Entry($"Impact Mantle: Unk{l++}", 363, typeof(float)),
                new MhwStructData.Entry($"Impact Mantle: Unk{l++}", 367, typeof(float)),
                new MhwStructData.Entry($"Impact Mantle: Unk{l++}", 371, typeof(float)),
                new MhwStructData.Entry($"Impact Mantle: Unk{l++}", 375, typeof(float)),
                new MhwStructData.Entry($"Impact Mantle: Unk{l++}", 379, typeof(float)),
                new MhwStructData.Entry($"Impact Mantle: Unk{l++}", 383, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry("Apothecary Mantle: Cooldown", 387, typeof(float)),
                new MhwStructData.Entry("Apothecary Mantle: Duration", 391, typeof(float)),
                new MhwStructData.Entry("Apothecary Mantle: Status Multiplier: Poison", 395, typeof(float)),
                new MhwStructData.Entry("Apothecary Mantle: Status Multiplier: Para", 399, typeof(float)),
                new MhwStructData.Entry("Apothecary Mantle: Status Multiplier: Sleep", 403, typeof(float)),
                new MhwStructData.Entry("Apothecary Mantle: Status Multiplier: Blast", 407, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry("Immunity Mantle: Cooldown", 411, typeof(float)),
                new MhwStructData.Entry("Immunity Mantle: Duration", 415, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry("Affinity Booster: Cooldown", 419, typeof(float)),
                new MhwStructData.Entry("Affinity Booster: Duration", 423, typeof(float)),
                new MhwStructData.Entry("Affinity Booster: Buff Duration", 427, typeof(float)),
                new MhwStructData.Entry("Affinity Booster: Buff Affinity", 431, typeof(int)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry("Bandit Mantle: Cooldown", 435, typeof(float)),
                new MhwStructData.Entry("Bandit Mantle: Duration", 439, typeof(float)),
                new MhwStructData.Entry("Bandit Mantle: Hits to Drop Shiny", 443, typeof(float)),
                new MhwStructData.Entry($"Bandit Mantle: Unk{m++}", 447, typeof(sbyte)),
                new MhwStructData.Entry($"Bandit Mantle: Unk{m++}", 448, typeof(sbyte)),
                new MhwStructData.Entry($"Bandit Mantle: Unk{m++}", 449, typeof(sbyte)),
                new MhwStructData.Entry($"Bandit Mantle: Unk{m++}", 450, typeof(sbyte)),
                new MhwStructData.Entry($"Bandit Mantle: Unk{m++}", 451, typeof(sbyte)),
                new MhwStructData.Entry($"Bandit Mantle: Unk{m++}", 452, typeof(sbyte)),
                new MhwStructData.Entry($"Bandit Mantle: Unk{m++}", 453, typeof(sbyte)),
                new MhwStructData.Entry($"Bandit Mantle: Unk{m++}", 454, typeof(sbyte)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry("Assassin's Hood: Cooldown", 455, typeof(float)),
                new MhwStructData.Entry("Assassin's Hood: Duration", 459, typeof(float)),
                new MhwStructData.Entry("Assassin's Hood: Sneak Attack Multiplier", 463, typeof(float)),
                new MhwStructData.Entry("Assassin's Hood: Speed Multiplier 1", 467, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 471, typeof(float)),
                new MhwStructData.Entry("Assassin's Hood: Speed Multiplier 2", 475, typeof(float)),
                new MhwStructData.Entry("Assassin's Hood: Speed Multiplier 3", 479, typeof(float)),
                new MhwStructData.Entry("Assassin's Hood: Speed Multiplier 4", 483, typeof(float)),
                new MhwStructData.Entry("Assassin's Hood: Speed Multiplier 5", 487, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 491, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 495, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 499, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 503, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 507, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 511, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 515, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 519, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 523, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 527, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 531, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 535, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 539, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 543, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 547, typeof(float))
            });

            GeneratePlDataProps("MHW_Editor.PlData", "PlMantleParam", new MhwStructData { // .asp
                size = 560,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".asp"],
                entries = entries
            });
        }

        private static void GenPlPlayerParam() {
            // 'Unk' counters.
            ushort i = 1;
            ushort j = 1;
            ushort k = 1;
            ushort l = 1;
            ushort m = 1;
            ushort n = 1;

            var entries = new List<MhwStructData.Entry> {
                new MhwStructData.Entry($"Unk{i++}", 8, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 12, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 16, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 20, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 24, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 28, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 32, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 36, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 40, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 44, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 48, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 52, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 56, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 60, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 64, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 68, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 72, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 76, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 80, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 84, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 88, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 92, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 96, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 100, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 104, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 108, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 112, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 116, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 120, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 124, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 128, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 132, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 136, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 140, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 144, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 148, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 152, typeof(uint)),
                new MhwStructData.Entry($"Unk{i++}", 156, typeof(uint)),
                new MhwStructData.Entry($"Unk{i++}", 160, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 164, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 168, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 172, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 176, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 180, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 184, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 188, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 192, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 196, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 200, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 204, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 208, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 212, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 216, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 220, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 224, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 228, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 232, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 236, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 237, typeof(ushort)),
                new MhwStructData.Entry($"Unk{i++}", 239, typeof(ushort)),
                new MhwStructData.Entry($"Unk{i++}", 241, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 245, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 246, typeof(ushort)),
                new MhwStructData.Entry($"Unk{i++}", 248, typeof(ushort)),
                new MhwStructData.Entry($"Unk{i++}", 250, typeof(ushort)),
                new MhwStructData.Entry($"Unk{i++}", 252, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),
                new MhwStructData.Entry($"------Skipping ahead.", 3, typeof(byte), true, forceUnique: true),
                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry("Health Initial Value", 408, typeof(float)),
                new MhwStructData.Entry("Health Max Value", 412, typeof(float)),
                new MhwStructData.Entry("Health Damage Recovery Rate", 416, typeof(float)),
                new MhwStructData.Entry("Health Damage Recovery Wait Time", 420, typeof(float)),
                new MhwStructData.Entry("Health Damage Recovery Interval", 424, typeof(float)),
                new MhwStructData.Entry("Health Damage Recovery Value", 428, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry("Stamina Initial Value", 432, typeof(float)),
                new MhwStructData.Entry("Stamina Max Value", 436, typeof(float)),
                new MhwStructData.Entry("Stamina Min Value", 440, typeof(float)),
                new MhwStructData.Entry("Stamina Tired Value", 444, typeof(float)),
                new MhwStructData.Entry("Stamina Auto Recover", 448, typeof(float)),
                new MhwStructData.Entry("Stamina Auto Max Reduce", 452, typeof(float)),
                new MhwStructData.Entry("Stamina Auto Max Reduce Time", 456, typeof(float)),
                new MhwStructData.Entry("Stamina IB Unknown", 460, typeof(float)),
                new MhwStructData.Entry("Stamina Escape Dash Rate", 464, typeof(float)),
                new MhwStructData.Entry("Stamina Out of Battle Rate", 468, typeof(float)),
                new MhwStructData.Entry("Stamina Reduce Rate Limit Trigger", 472, typeof(float)),
                new MhwStructData.Entry("Stamina Reduce Rate Limit Time", 476, typeof(float)),
                new MhwStructData.Entry("Stamina Mount Endurance Rate", 480, typeof(float)),

                new MhwStructData.Entry("Stamina Consumption: Dodge", 484, typeof(float)),
                new MhwStructData.Entry("Stamina Consumption: LS Counter", 488, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 492, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 496, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 500, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 504, typeof(float)),
                new MhwStructData.Entry("Stamina Consumption: Bow Shoot", 508, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 512, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 516, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 520, typeof(float)),
                new MhwStructData.Entry("Stamina Consumption: Bow Charge Step", 524, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 528, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: IB Unk{j++}", 532, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: IB Unk{j++}", 536, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: IB Unk{j++}", 540, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: IB Unk{j++}", 544, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 548, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 552, typeof(float)),

                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 556, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 560, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 564, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 568, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 572, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 576, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 580, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 584, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 588, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 592, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 596, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 600, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 604, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 608, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 612, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 616, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 620, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 624, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry($"Mount Reduce Stamina mCore: Unk{l++}", 628, typeof(float)),
                new MhwStructData.Entry($"Mount Reduce Stamina mCore: Unk{l++}", 632, typeof(float)),

                new MhwStructData.Entry($"Mount Life Reduce Stamina mCore: Unk{m++}", 636, typeof(float)),
                new MhwStructData.Entry($"Mount Life Reduce Stamina mCore: Unk{m++}", 640, typeof(float)),
                new MhwStructData.Entry($"Mount Life Reduce Stamina mCore: Unk{m++}", 644, typeof(float)),
                new MhwStructData.Entry($"Mount Life Reduce Stamina mCore: Unk{m++}", 648, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                new MhwStructData.Entry($"Unk{i++}", 652, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 656, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 660, typeof(float)),
                new MhwStructData.Entry("Explosive HR Fixed Attack Rate", 664, typeof(float)),
                new MhwStructData.Entry("Explosive MR Fixed Attack Rate", 668, typeof(float)),
                new MhwStructData.Entry("Critical Attack Rate", 672, typeof(float)),
                new MhwStructData.Entry("Bad Critical Attack Rate", 676, typeof(float)),

                new MhwStructData.Entry("Sharpness Recoil Reduction %", 680, typeof(byte)),
                new MhwStructData.Entry("Sharpness Recoil Reduction Value", 681, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 682, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 686, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 690, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 694, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 698, typeof(uint)),
                new MhwStructData.Entry("Physical Attack Rate Limit", 702, typeof(float)),
                new MhwStructData.Entry("Elemental Attack Rate Limit", 706, typeof(float)),
                new MhwStructData.Entry("Condition Attack Flat Limit", 710, typeof(float)),
                new MhwStructData.Entry("Bowgun Elemental Attack Rate Limit", 714, typeof(float)),
                new MhwStructData.Entry("Condition Attack Rate Limit", 718, typeof(float)),
                new MhwStructData.Entry("Stun Attack Rate Limit", 722, typeof(float)),
                new MhwStructData.Entry("Stamina Attack Rate Limit", 726, typeof(float)),
                new MhwStructData.Entry("Mount Attack Rate Limit", 730, typeof(float)),
                new MhwStructData.Entry("Super Armor Stun Damage Rate", 734, typeof(float)),
                new MhwStructData.Entry("Hyper Armor Damage Rate", 738, typeof(float)),
                new MhwStructData.Entry("Hyper Armor Stun Damage Rate", 742, typeof(float)),
                new MhwStructData.Entry("Gunner Defense Rate", 746, typeof(float)),
                new MhwStructData.Entry("Gunner Elemental Resistance Bonus", 750, typeof(byte)),
                new MhwStructData.Entry("Lava Damage Interval Time", 751, typeof(float)),
                new MhwStructData.Entry("Lava Damage Damage", 755, typeof(float)),
                new MhwStructData.Entry("Acid Damage Interval Time", 759, typeof(float)),
                new MhwStructData.Entry("Acid Damage Damage", 763, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),
                new MhwStructData.Entry($"------Skipping ahead.", 3, typeof(byte), true, forceUnique: true),
                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true)
            };

            const ulong iFramesStartOffset = 1157;

            var iFrameEntries = new List<string> {
                "Normal",
                "Step",
                "Sword & Shield Back Step",
                "Dual Blades Demon Mode Step",
                "Long Sword Counter",
                "Bow Charge Step",
                "HBG Roll Dodge",
                "LBG Side Dodge",
                "Dual Blades Demon Mode Slinger Evade",
                "Dual Blades Slinger Evade"
            };

            var iFrameSubEntries = new List<string> {
                "Evasion 0",
                "Evasion 1",
                "Evasion 2",
                "Evasion 3",
                "Evasion 4",
                "Evasion 5",
                "Evasion Mantle"
            };

            for (var x = 0; x < iFrameEntries.Count; x++) {
                for (var s = 0; s < iFrameSubEntries.Count; s++) {
                    entries.Add(new MhwStructData.Entry($"Dodge IFrames: {iFrameEntries[x]}: {iFrameSubEntries[s]}", iFramesStartOffset + (ulong) s * 4 + (ulong) x * 28, typeof(float)));
                }
            }

            entries.Add(new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true));

            const ulong evadeDistanceStartOffset = 1437;

            var evadeDistanceEntries = new List<string> {
                "Normal",
                "Step",
                "Sword & Shield Back Step",
                "Dual Blades DemonMode Step",
                "Long Sword Counter",
                "Insect Glaive Air Dodge",
                "Bow Charge Step",
                "HBG Roll Dodge",
                "LBG Side Dodge",
                "Dual Blades Demon Mode Slinger Evade",
                "Dual Blades Slinger Evade"
            };

            var evadeDistanceSubEntries = new List<string> {
                "Distance 1",
                "Distance 2",
                "Distance 3"
            };

            for (var x = 0; x < evadeDistanceEntries.Count; x++) {
                for (var s = 0; s < evadeDistanceSubEntries.Count; s++) {
                    entries.Add(new MhwStructData.Entry($"Evade: {evadeDistanceEntries[x]}: {evadeDistanceSubEntries[s]}", evadeDistanceStartOffset + (ulong) s * 4 + (ulong) x * 12, typeof(float)));
                }
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),
                new MhwStructData.Entry($"------Skipping ahead.", 3, typeof(byte), true, forceUnique: true),
                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                // HR Augment.
                new MhwStructData.Entry("Wp HR Augment Attack Add (1)", 8571, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Attack Add (2)", 8572, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Attack Add (3)", 8573, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Critical Add (1)", 8574, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Critical Add (2)", 8575, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Critical Add (3)", 8576, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Defense Add (1)", 8577, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Defense Add (2)", 8578, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Defense Add (3)", 8579, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Divine Blessing Chance (1)", 8580, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Divine Blessing Chance (2)", 8581, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Divine Blessing Chance (3)", 8582, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Divine Blessing Reduction (1)", 8583, typeof(float)),
                new MhwStructData.Entry("Wp HR Augment Divine Blessing Reduction (2)", 8587, typeof(float)),
                new MhwStructData.Entry("Wp HR Augment Divine Blessing Reduction (3)", 8591, typeof(float)),
                new MhwStructData.Entry("Wp HR Augment Defense Heal Damage Rate (1)", 8595, typeof(float)),
                new MhwStructData.Entry("Wp HR Augment Defense Heal Damage Rate (2)", 8599, typeof(float)),
                new MhwStructData.Entry("Wp HR Augment Defense Heal Damage Rate (3)", 8603, typeof(float)),
                new MhwStructData.Entry("Wp HR Augment IB Unk", 8607, typeof(float)),
                new MhwStructData.Entry("Wp HR Augment Lifesteal Cooldown", 8611, typeof(float)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),

                // MR Augment now.
                new MhwStructData.Entry("Wp MR Augment Attack (1)", 8615, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Attack (2)", 8616, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Attack (3)", 8617, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Attack (4)", 8618, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Critical (1)", 8619, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Critical (2)", 8620, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Critical (3)", 8621, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Critical (4)", 8622, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Defense (1)", 8623, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Defense (2)", 8624, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Defense (3)", 8625, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Defense (4)", 8626, typeof(byte)),

                new MhwStructData.Entry($"IB Unk{n++}", 8627, typeof(byte)),
                new MhwStructData.Entry($"IB Unk{n++}", 8628, typeof(byte)),
                new MhwStructData.Entry($"IB Unk{n++}", 8629, typeof(byte)),
                new MhwStructData.Entry($"IB Unk{n++}", 8630, typeof(byte)),

                new MhwStructData.Entry("Wp MR Augment Defense Percent Reduction (1)", 8631, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Defense Percent Reduction (2)", 8635, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Defense Percent Reduction (3)", 8639, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Defense Percent Activation", 8643, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Health Percent (1)", 8647, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Health Percent (2)", 8651, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Health Percent (3)", 8655, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Health Percent (4)", 8659, typeof(float)),

                new MhwStructData.Entry($"IB Unk{n++}", 8663, typeof(float)),

                new MhwStructData.Entry("Wp MR Augment Lifesteal Cooldown", 8667, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Element (1)", 8671, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Element (2)", 8672, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Element (3)", 8673, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Element (4)", 8674, typeof(byte)),

                new MhwStructData.Entry($"{SPACER}", 3, typeof(byte), true, forceUnique: true),
                new MhwStructData.Entry($"------Skipping the rest.", 3, typeof(byte), true, forceUnique: true)
            });

            GeneratePlDataProps("MHW_Editor.PlData", "PlPlayerParam", new MhwStructData { // .plp
                size = 20640,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".plp"],
                entries = entries
            });
        }

        private static void GenPlItemParam() {
            GeneratePlDataProps("MHW_Editor.PlData", "PlItemParam", new MhwStructData { // .plip
                size = 512,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".plip"],
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Powder Radius", 8, typeof(float)),
                    new MhwStructData.Entry("Potion Power", 12, typeof(uint)),
                    new MhwStructData.Entry("Unk2", 16, typeof(float)),
                    new MhwStructData.Entry("Unk3", 20, typeof(float)),
                    new MhwStructData.Entry("Unk4", 24, typeof(float)),
                    new MhwStructData.Entry("Mega Potion Power", 28, typeof(uint)),
                    new MhwStructData.Entry("Unk5", 32, typeof(float)),
                    new MhwStructData.Entry("Unk6", 36, typeof(float)),
                    new MhwStructData.Entry("Unk7", 40, typeof(float)),
                    new MhwStructData.Entry("Nutrients Power", 44, typeof(byte)),
                    new MhwStructData.Entry("Mega Nutrients Power", 45, typeof(byte)),
                    new MhwStructData.Entry("Unk9", 46, typeof(byte)),
                    new MhwStructData.Entry("Mega Dash Juice Stamina Power", 47, typeof(float)),
                    new MhwStructData.Entry("Dash Juice Stamina Power", 51, typeof(float)),
                    new MhwStructData.Entry("Both Dash Juice Duration", 55, typeof(ushort)),
                    new MhwStructData.Entry("Both Dash Juice Power", 57, typeof(byte)),
                    new MhwStructData.Entry("Immunizer Power", 58, typeof(float)),
                    new MhwStructData.Entry("Immunizer Duration", 62, typeof(ushort)),
                    new MhwStructData.Entry("Astera Jerky Power", 64, typeof(float)),
                    new MhwStructData.Entry("Astera Jerky Duration", 68, typeof(ushort)),
                    new MhwStructData.Entry("Herbal Medicine Power", 70, typeof(ushort)),
                    new MhwStructData.Entry("Sushifish Scale Power", 72, typeof(uint)),
                    new MhwStructData.Entry("Great Sushifish Scale Power", 76, typeof(uint)),
                    new MhwStructData.Entry("Great Sushifish Scale Duration", 80, typeof(float)),
                    new MhwStructData.Entry("Cool Drink Duration", 84, typeof(ushort)),
                    new MhwStructData.Entry("Hot Drink Duration", 86, typeof(ushort)),
                    new MhwStructData.Entry("Might Seed Duration", 88, typeof(ushort)),
                    new MhwStructData.Entry("Might Seed Power", 90, typeof(ushort)),
                    new MhwStructData.Entry("Might Pill Duration", 92, typeof(ushort)),
                    new MhwStructData.Entry("Might Pill Power", 94, typeof(ushort)),
                    new MhwStructData.Entry("Adamant Seed Duration", 96, typeof(ushort)),
                    new MhwStructData.Entry("Adamant Seed Power", 98, typeof(ushort)),
                    new MhwStructData.Entry("Adamant Pill Duration", 100, typeof(ushort)),
                    new MhwStructData.Entry("Adamant Pill Power", 102, typeof(float)),
                    new MhwStructData.Entry("Demondrug Power", 106, typeof(byte)),
                    new MhwStructData.Entry("Mega Demondrug Power", 107, typeof(byte)),
                    new MhwStructData.Entry("Armorskin Power", 108, typeof(byte)),
                    new MhwStructData.Entry("Mega Armorskin Power", 109, typeof(byte)),
                    new MhwStructData.Entry("Unk16", 110, typeof(ushort)),
                    new MhwStructData.Entry("Lifepowder Power", 112, typeof(ushort)),
                    new MhwStructData.Entry("Dust of Life Power", 114, typeof(ushort)),
                    new MhwStructData.Entry("Herbal Powder Power", 116, typeof(ushort)),
                    new MhwStructData.Entry("Demon Powder Power", 118, typeof(ushort)),
                    new MhwStructData.Entry("Demon Powder Duration", 120, typeof(ushort)),
                    new MhwStructData.Entry("Hardshell Powder Power", 122, typeof(ushort)),
                    new MhwStructData.Entry("Hardshell Powder Duration", 124, typeof(ushort)),
                    new MhwStructData.Entry("Demon Ammo Power", 126, typeof(ushort)),
                    new MhwStructData.Entry("Demon Ammo Duration", 128, typeof(ushort)),
                    new MhwStructData.Entry("Armor Ammo Power", 130, typeof(ushort)),
                    new MhwStructData.Entry("Armor Ammo Duration", 132, typeof(ushort)),
                    new MhwStructData.Entry("Ration Power", 134, typeof(ushort)),
                    new MhwStructData.Entry("Well Done Steak Multiplier", 136, typeof(uint)),
                    new MhwStructData.Entry("Well Done Steak Stamina Bonus", 140, typeof(float)),
                    new MhwStructData.Entry("Unk23", 144, typeof(float)),
                    new MhwStructData.Entry("Unk24", 148, typeof(float)),
                    new MhwStructData.Entry("Burnt Meat Stamina Recovery", 152, typeof(ushort)),
                    new MhwStructData.Entry("Unk26", 154, typeof(short)),
                    new MhwStructData.Entry("Unk27", 156, typeof(byte)),
                    new MhwStructData.Entry("Unk28", 157, typeof(float)),
                    new MhwStructData.Entry("Unk29", 161, typeof(float)),
                    new MhwStructData.Entry("Unk30", 165, typeof(float)),
                    new MhwStructData.Entry("Unk31", 169, typeof(float)),
                    new MhwStructData.Entry("Unk32", 173, typeof(float)),
                    new MhwStructData.Entry("Unk33", 177, typeof(float)),
                    new MhwStructData.Entry("Unk34", 181, typeof(float)),
                    new MhwStructData.Entry("Unk35", 185, typeof(float)),
                    new MhwStructData.Entry("Unk36", 189, typeof(float)),
                    new MhwStructData.Entry("Unk37", 193, typeof(float)),
                    new MhwStructData.Entry("Unk38", 197, typeof(float)),
                    new MhwStructData.Entry("Whetstone Sharpness Restored", 201, typeof(uint)),
                    new MhwStructData.Entry("Whetstone Cycles", 205, typeof(uint)),
                    new MhwStructData.Entry("Whetfish Scale Sharpness Restored", 209, typeof(uint)),
                    new MhwStructData.Entry("Whetfish Scale Cycles", 213, typeof(byte)),
                    new MhwStructData.Entry("Whetfish Scale Plus Cycles", 214, typeof(byte)),
                    new MhwStructData.Entry("Whetfish Scale Consume %", 215, typeof(byte)),
                    new MhwStructData.Entry("Powertalon Power", 216, typeof(byte)),
                    new MhwStructData.Entry("Powercharm Power", 217, typeof(byte)),
                    new MhwStructData.Entry("Armortalon Power", 218, typeof(byte)),
                    new MhwStructData.Entry("Armorcharm Power", 219, typeof(byte)),
                    new MhwStructData.Entry("Unk49", 220, typeof(byte)),
                    new MhwStructData.Entry("Unk50", 221, typeof(float)),
                    new MhwStructData.Entry("Unk51", 225, typeof(float)),
                    new MhwStructData.Entry("Unk52", 229, typeof(float)),
                    new MhwStructData.Entry("Unk53", 233, typeof(float)),
                    new MhwStructData.Entry("Unk54", 237, typeof(float)),
                    new MhwStructData.Entry("Unk55", 241, typeof(float)),
                    new MhwStructData.Entry("Unk56", 245, typeof(float)),
                    new MhwStructData.Entry("Unk57", 249, typeof(float)),
                    new MhwStructData.Entry("Unk58", 253, typeof(float)),
                    new MhwStructData.Entry("Unk59", 257, typeof(float)),
                    new MhwStructData.Entry("Unk60", 261, typeof(float)),
                    new MhwStructData.Entry("Unk61", 265, typeof(float)),
                    new MhwStructData.Entry("Unk62", 269, typeof(float)),
                    new MhwStructData.Entry("Unk63", 273, typeof(float)),
                    new MhwStructData.Entry("Unk64", 277, typeof(float)),
                    new MhwStructData.Entry("Unk65", 281, typeof(float)),
                    new MhwStructData.Entry("Unk66", 285, typeof(float)),
                    new MhwStructData.Entry("Unk67", 289, typeof(float)),
                    new MhwStructData.Entry("Unk68", 293, typeof(float)),
                    new MhwStructData.Entry("Unk69", 297, typeof(float)),
                    new MhwStructData.Entry("Unk70", 301, typeof(float)),
                    new MhwStructData.Entry("Unk71", 305, typeof(float)),
                    new MhwStructData.Entry("Unk72", 309, typeof(float)),
                    new MhwStructData.Entry("Unk73", 313, typeof(float)),
                    new MhwStructData.Entry("Unk74", 317, typeof(float)),
                    new MhwStructData.Entry("Unk75", 321, typeof(float)),
                    new MhwStructData.Entry("Unk76", 325, typeof(float)),
                    new MhwStructData.Entry("Unk77", 329, typeof(float)),
                    new MhwStructData.Entry("Unk78", 337, typeof(float)),
                    new MhwStructData.Entry("Unk79", 341, typeof(float)),
                    new MhwStructData.Entry("Unk80", 345, typeof(float)),
                    new MhwStructData.Entry("Unk81", 349, typeof(float)),
                    new MhwStructData.Entry("Unk82", 353, typeof(float)),
                    new MhwStructData.Entry("Unk83", 357, typeof(float)),
                    new MhwStructData.Entry("Unk84", 361, typeof(float)),
                    new MhwStructData.Entry("Unk85", 365, typeof(float)),
                    new MhwStructData.Entry("Unk86", 369, typeof(float)),
                    new MhwStructData.Entry("Unk87", 373, typeof(float)),
                    new MhwStructData.Entry("Unk88", 377, typeof(float)),
                    new MhwStructData.Entry("Unk89", 381, typeof(float)),
                    new MhwStructData.Entry("Unk90", 385, typeof(float)),
                    new MhwStructData.Entry("Unk91", 389, typeof(float)),
                    new MhwStructData.Entry("Unk92", 393, typeof(float)),
                    new MhwStructData.Entry("Unk93", 397, typeof(float)),
                    new MhwStructData.Entry("Unk94", 401, typeof(float)),
                    new MhwStructData.Entry("Unk95", 405, typeof(float)),
                    new MhwStructData.Entry("Unk96", 409, typeof(float)),
                    new MhwStructData.Entry("Unk97", 413, typeof(float)),
                    new MhwStructData.Entry("Unk98", 417, typeof(float)),
                    new MhwStructData.Entry("Unk99", 417, typeof(float)),
                    new MhwStructData.Entry("Unk100", 421, typeof(float)),
                    new MhwStructData.Entry("Unk101", 425, typeof(float)),
                    new MhwStructData.Entry("Unk102", 429, typeof(float)),
                    new MhwStructData.Entry("Unk103", 433, typeof(float)),
                    new MhwStructData.Entry("Unk104", 437, typeof(float)),
                    new MhwStructData.Entry("Unk105", 441, typeof(float)),
                    new MhwStructData.Entry("Deathcream: 455-499 are fishing rumble", 445, typeof(byte)),
                    new MhwStructData.Entry("and skipped for now.", 446, typeof(uint)),
                    new MhwStructData.Entry("Unk106", 500, typeof(float)),
                    new MhwStructData.Entry("Unk107", 504, typeof(float)),
                    new MhwStructData.Entry("Unk108", 508, typeof(float))
                }
            });
        }

        public static void GeneratePlDataProps(string @namespace, string className, MhwStructData structData) {
            GenerateItemProps(@namespace, className, structData);

            WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, $"{className}Internal", new PlDataItemTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"structData", structData}
                }
            });
        }
    }
}