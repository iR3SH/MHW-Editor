﻿using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Multi;

namespace MHW_Generator.Monsters {
    public class MonsterClawGrab : IMultiStruct {
        public MultiStruct Generate() { // .dtt_clawc
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Monster Claw Grab", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Magic 2", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Number of Claggers", typeof(uint), true).@out(out var count)
                }, 1).@out(out var header),

                new MhwMultiStructData.StructData("Clagger Params", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Unk (f32)", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Normal", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Enraged", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Tired", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build by HP%: 90-100", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build by HP%: 80-90", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build by HP%: 70-80", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build by HP%: 60-70", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build by HP%: 50-60", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build by HP%: 40-50", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build by HP%: 30-40", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build by HP%: 20-30", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build by HP%: 10-20", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Build by HP%: 0-10", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Tenderize Lv State LR", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Tenderize Lv State HR", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Tenderize Lv State MR", typeof(float))
                }, canAddRows: true, _010Link: new MhwMultiStructData.ArrayLink(header, count)),

                new MhwMultiStructData.StructData("Claw Chance Params", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Gimmick Breaker Collision Unique Id Small", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Gimmick Breaker Collision Unique Id Middle", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Gimmick Breaker Collision Unique Id Large", typeof(uint))
                }, 1, showVertically: true)
            };

            return new MultiStruct("MHW_Editor.Monsters", "MonsterClawGrab", new MhwMultiStructData(structs, "dtt_clawc"));
        }
    }
}