﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons.Collision.Models {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public struct Clnd {
        [DisplayName("Magic 1")]
        [SortOrder(10)]
        public uint magic1 { get; set; }

        [DisplayName("Type")]
        [SortOrder(20)]
        public string name { get; set; } // Exactly 4 chars in length.

        [DisplayName("Magic 2")]
        [SortOrder(30)]
        public uint magic2 { get; set; }

        [DisplayName("Array Count")]
        [SortOrder(40)]
        public uint count { get; set; }

        [SortOrder(50)]
        public uint unk1 { get; set; }

        [SortOrder(50)]
        public byte unk2 { get; set; }

        [DisplayName("CLGM[]")]
        [SortOrder(60)]
        public List<Clgm> clgm { get; set; } // count

        [SortOrder(70)]
        public byte unk3 { get; set; }

        [SortOrder(80)]
        public byte unk4 { get; set; }

        [SortOrder(90)]
        public byte unk5 { get; set; }
    }
}