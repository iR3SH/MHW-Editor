using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class ShellParam {
        public override string EncryptionKey => "FZoS8QLyOyeFmkdrz73P9Fh2N4NcTwy3QQPjc1YRII5KWovK6yFuU8SL";

        public partial class Shlp : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Shlp";

            protected uint Magic_1_raw;
            public const string Magic_1_displayName = "Magic 1";
            public const int Magic_1_sortIndex = 50;
            [SortOrder(Magic_1_sortIndex)]
            [DisplayName(Magic_1_displayName)]
            [IsReadOnly]
            public virtual uint Magic_1 {
                get => Magic_1_raw;
                set {
                    if (Magic_1_raw == value) return;
                    Magic_1_raw = value;
                    OnPropertyChanged(nameof(Magic_1));
                }
            }

            protected char[] SLP_raw;
            public const string SLP_displayName = "SLP";
            public const int SLP_sortIndex = 100;
            [SortOrder(SLP_sortIndex)]
            [DisplayName(SLP_displayName)]
            [IsReadOnly]
            public virtual string SLP {
                get => (string) new string(SLP_raw);
                set {
                    if ((string) new string(SLP_raw) == value) return;
                    SLP_raw = (char[]) value.ToCharArray(0, 3);
                    OnPropertyChanged(nameof(SLP));
                }
            }

            protected uint Magic_2_raw;
            public const string Magic_2_displayName = "Magic 2";
            public const int Magic_2_sortIndex = 150;
            [SortOrder(Magic_2_sortIndex)]
            [DisplayName(Magic_2_displayName)]
            [IsReadOnly]
            public virtual uint Magic_2 {
                get => Magic_2_raw;
                set {
                    if (Magic_2_raw == value) return;
                    Magic_2_raw = value;
                    OnPropertyChanged(nameof(Magic_2));
                }
            }

            public static Shlp LoadData(BinaryReader reader) {
                var data = new Shlp();
                data.Magic_1_raw = reader.ReadUInt32();
                data.SLP_raw = reader.ReadChars(4);
                data.Magic_2_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(SLP_raw);
                writer.Write(Magic_2_raw);
            }
        }

        public partial class Assets : MhwStructItem {
            public const ulong FixedSizeCount = 25;
            public const string GridName = "Assets";

            protected uint Header_raw;
            public const string Header_displayName = "Header";
            public const int Header_sortIndex = 50;
            [SortOrder(Header_sortIndex)]
            [DisplayName(Header_displayName)]
            public virtual uint Header {
                get => Header_raw;
                set {
                    if (Header_raw == value) return;
                    Header_raw = value;
                    OnPropertyChanged(nameof(Header));
                }
            }

            protected string Path_raw;
            public const string Path_displayName = "Path";
            public const int Path_sortIndex = 100;
            [SortOrder(Path_sortIndex)]
            [DisplayName(Path_displayName)]
            public virtual string Path {
                get => Path_raw;
                set {
                    if (Path_raw == value) return;
                    Path_raw = value;
                    OnPropertyChanged(nameof(Path));
                }
            }

            public static Assets LoadData(BinaryReader reader) {
                var data = new Assets();
                data.Header_raw = reader.ReadUInt32();
                if (data.Header_raw != 0) data.Path_raw = reader.ReadNullTermString();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Header_raw);
                if (Header_raw != 0) writer.Write(Path_raw.ToNullTermCharArray());
            }
        }

        public partial class Shlp_1_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Shlp (1)";

            protected uint Projectile_EPV_VFX_Group_Id_raw;
            public const string Projectile_EPV_VFX_Group_Id_displayName = "Projectile: EPV VFX Group Id";
            public const int Projectile_EPV_VFX_Group_Id_sortIndex = 50;
            [SortOrder(Projectile_EPV_VFX_Group_Id_sortIndex)]
            [DisplayName(Projectile_EPV_VFX_Group_Id_displayName)]
            public virtual uint Projectile_EPV_VFX_Group_Id {
                get => Projectile_EPV_VFX_Group_Id_raw;
                set {
                    if (Projectile_EPV_VFX_Group_Id_raw == value) return;
                    Projectile_EPV_VFX_Group_Id_raw = value;
                    OnPropertyChanged(nameof(Projectile_EPV_VFX_Group_Id));
                }
            }

            protected uint Projectile_EPV_VFX_Effect_Index_raw;
            public const string Projectile_EPV_VFX_Effect_Index_displayName = "Projectile: EPV VFX Effect Index";
            public const int Projectile_EPV_VFX_Effect_Index_sortIndex = 100;
            [SortOrder(Projectile_EPV_VFX_Effect_Index_sortIndex)]
            [DisplayName(Projectile_EPV_VFX_Effect_Index_displayName)]
            public virtual uint Projectile_EPV_VFX_Effect_Index {
                get => Projectile_EPV_VFX_Effect_Index_raw;
                set {
                    if (Projectile_EPV_VFX_Effect_Index_raw == value) return;
                    Projectile_EPV_VFX_Effect_Index_raw = value;
                    OnPropertyChanged(nameof(Projectile_EPV_VFX_Effect_Index));
                }
            }

            protected uint Muzzle_EPV_VFX_Group_Id_raw;
            public const string Muzzle_EPV_VFX_Group_Id_displayName = "Muzzle: EPV VFX Group Id";
            public const int Muzzle_EPV_VFX_Group_Id_sortIndex = 150;
            [SortOrder(Muzzle_EPV_VFX_Group_Id_sortIndex)]
            [DisplayName(Muzzle_EPV_VFX_Group_Id_displayName)]
            public virtual uint Muzzle_EPV_VFX_Group_Id {
                get => Muzzle_EPV_VFX_Group_Id_raw;
                set {
                    if (Muzzle_EPV_VFX_Group_Id_raw == value) return;
                    Muzzle_EPV_VFX_Group_Id_raw = value;
                    OnPropertyChanged(nameof(Muzzle_EPV_VFX_Group_Id));
                }
            }

            protected uint Muzzle_EPV_VFX_Effect_Index_raw;
            public const string Muzzle_EPV_VFX_Effect_Index_displayName = "Muzzle: EPV VFX Effect Index";
            public const int Muzzle_EPV_VFX_Effect_Index_sortIndex = 200;
            [SortOrder(Muzzle_EPV_VFX_Effect_Index_sortIndex)]
            [DisplayName(Muzzle_EPV_VFX_Effect_Index_displayName)]
            public virtual uint Muzzle_EPV_VFX_Effect_Index {
                get => Muzzle_EPV_VFX_Effect_Index_raw;
                set {
                    if (Muzzle_EPV_VFX_Effect_Index_raw == value) return;
                    Muzzle_EPV_VFX_Effect_Index_raw = value;
                    OnPropertyChanged(nameof(Muzzle_EPV_VFX_Effect_Index));
                }
            }

            protected int Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 250;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual int Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected uint Obj_Collision_Header_raw;
            public const string Obj_Collision_Header_displayName = "Obj Collision Header";
            public const int Obj_Collision_Header_sortIndex = 300;
            [SortOrder(Obj_Collision_Header_sortIndex)]
            [DisplayName(Obj_Collision_Header_displayName)]
            public virtual uint Obj_Collision_Header {
                get => Obj_Collision_Header_raw;
                set {
                    if (Obj_Collision_Header_raw == value) return;
                    Obj_Collision_Header_raw = value;
                    OnPropertyChanged(nameof(Obj_Collision_Header));
                }
            }

            protected string Obj_Collision_raw;
            public const string Obj_Collision_displayName = "Obj Collision";
            public const int Obj_Collision_sortIndex = 350;
            [SortOrder(Obj_Collision_sortIndex)]
            [DisplayName(Obj_Collision_displayName)]
            public virtual string Obj_Collision {
                get => Obj_Collision_raw;
                set {
                    if (Obj_Collision_raw == value) return;
                    Obj_Collision_raw = value;
                    OnPropertyChanged(nameof(Obj_Collision));
                }
            }

            protected uint Obj_Collision_Index_raw;
            public const string Obj_Collision_Index_displayName = "Obj Collision Index";
            public const int Obj_Collision_Index_sortIndex = 400;
            [SortOrder(Obj_Collision_Index_sortIndex)]
            [DisplayName(Obj_Collision_Index_displayName)]
            public virtual uint Obj_Collision_Index {
                get => Obj_Collision_Index_raw;
                set {
                    if (Obj_Collision_Index_raw == value) return;
                    Obj_Collision_Index_raw = value;
                    OnPropertyChanged(nameof(Obj_Collision_Index));
                }
            }

            protected uint Timeline_List_Header_raw;
            public const string Timeline_List_Header_displayName = "Timeline List Header";
            public const int Timeline_List_Header_sortIndex = 450;
            [SortOrder(Timeline_List_Header_sortIndex)]
            [DisplayName(Timeline_List_Header_displayName)]
            public virtual uint Timeline_List_Header {
                get => Timeline_List_Header_raw;
                set {
                    if (Timeline_List_Header_raw == value) return;
                    Timeline_List_Header_raw = value;
                    OnPropertyChanged(nameof(Timeline_List_Header));
                }
            }

            protected string Timeline_List_raw;
            public const string Timeline_List_displayName = "Timeline List";
            public const int Timeline_List_sortIndex = 500;
            [SortOrder(Timeline_List_sortIndex)]
            [DisplayName(Timeline_List_displayName)]
            public virtual string Timeline_List {
                get => Timeline_List_raw;
                set {
                    if (Timeline_List_raw == value) return;
                    Timeline_List_raw = value;
                    OnPropertyChanged(nameof(Timeline_List));
                }
            }

            protected uint Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 550;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual uint Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected uint Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 600;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual uint Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected uint Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 650;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual uint Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected uint Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 700;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual uint Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            protected uint Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 750;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual uint Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            public static Shlp_1_ LoadData(BinaryReader reader) {
                var data = new Shlp_1_();
                data.Projectile_EPV_VFX_Group_Id_raw = reader.ReadUInt32();
                data.Projectile_EPV_VFX_Effect_Index_raw = reader.ReadUInt32();
                data.Muzzle_EPV_VFX_Group_Id_raw = reader.ReadUInt32();
                data.Muzzle_EPV_VFX_Effect_Index_raw = reader.ReadUInt32();
                data.Unk_1_raw = reader.ReadInt32();
                data.Obj_Collision_Header_raw = reader.ReadUInt32();
                if (data.Obj_Collision_Header_raw != 0) data.Obj_Collision_raw = reader.ReadNullTermString();
                data.Obj_Collision_Index_raw = reader.ReadUInt32();
                data.Timeline_List_Header_raw = reader.ReadUInt32();
                if (data.Timeline_List_Header_raw != 0) data.Timeline_List_raw = reader.ReadNullTermString();
                data.Unk_2_raw = reader.ReadUInt32();
                data.Unk_3_raw = reader.ReadUInt32();
                data.Unk_4_raw = reader.ReadUInt32();
                data.Unk_5_raw = reader.ReadUInt32();
                data.Unk_6_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Projectile_EPV_VFX_Group_Id_raw);
                writer.Write(Projectile_EPV_VFX_Effect_Index_raw);
                writer.Write(Muzzle_EPV_VFX_Group_Id_raw);
                writer.Write(Muzzle_EPV_VFX_Effect_Index_raw);
                writer.Write(Unk_1_raw);
                writer.Write(Obj_Collision_Header_raw);
                if (Obj_Collision_Header_raw != 0) writer.Write(Obj_Collision_raw.ToNullTermCharArray());
                writer.Write(Obj_Collision_Index_raw);
                writer.Write(Timeline_List_Header_raw);
                if (Timeline_List_Header_raw != 0) writer.Write(Timeline_List_raw.ToNullTermCharArray());
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
                writer.Write(Unk_6_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Projectile: EPV VFX Group Id", "Projectile_EPV_VFX_Group_Id"),
                    new MultiStructItemCustomView(this, "Projectile: EPV VFX Effect Index", "Projectile_EPV_VFX_Effect_Index"),
                    new MultiStructItemCustomView(this, "Muzzle: EPV VFX Group Id", "Muzzle_EPV_VFX_Group_Id"),
                    new MultiStructItemCustomView(this, "Muzzle: EPV VFX Effect Index", "Muzzle_EPV_VFX_Effect_Index"),
                    new MultiStructItemCustomView(this, "Unk 1", "Unk_1"),
                    new MultiStructItemCustomView(this, "Obj Collision Header", "Obj_Collision_Header"),
                    new MultiStructItemCustomView(this, "Obj Collision", "Obj_Collision"),
                    new MultiStructItemCustomView(this, "Obj Collision Index", "Obj_Collision_Index"),
                    new MultiStructItemCustomView(this, "Timeline List Header", "Timeline_List_Header"),
                    new MultiStructItemCustomView(this, "Timeline List", "Timeline_List"),
                    new MultiStructItemCustomView(this, "Unk 2", "Unk_2"),
                    new MultiStructItemCustomView(this, "Unk 3", "Unk_3"),
                    new MultiStructItemCustomView(this, "Unk 4", "Unk_4"),
                    new MultiStructItemCustomView(this, "Unk 5", "Unk_5"),
                    new MultiStructItemCustomView(this, "Unk 6", "Unk_6"),
                };
            }
        }

        public partial class Number_of_Linked_Shell_Params_Holder : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Number of Linked Shell Params Holder";
            public const bool IsHidden = true;

            protected uint Number_of_Linked_Shell_Params_raw;
            public const string Number_of_Linked_Shell_Params_displayName = "Number of Linked Shell Params";
            public const int Number_of_Linked_Shell_Params_sortIndex = 50;
            [SortOrder(Number_of_Linked_Shell_Params_sortIndex)]
            [DisplayName(Number_of_Linked_Shell_Params_displayName)]
            [IsReadOnly]
            public virtual uint Number_of_Linked_Shell_Params {
                get => Number_of_Linked_Shell_Params_raw;
                set {
                    if (Number_of_Linked_Shell_Params_raw == value) return;
                    Number_of_Linked_Shell_Params_raw = value;
                    OnPropertyChanged(nameof(Number_of_Linked_Shell_Params));
                }
            }

            public static Number_of_Linked_Shell_Params_Holder LoadData(BinaryReader reader) {
                var data = new Number_of_Linked_Shell_Params_Holder();
                data.Number_of_Linked_Shell_Params_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Number_of_Linked_Shell_Params_raw);
            }
        }

        public partial class Linked_Shell_Params : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Linked Shell Params";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected uint Header_raw;
            public const string Header_displayName = "Header";
            public const int Header_sortIndex = 50;
            [SortOrder(Header_sortIndex)]
            [DisplayName(Header_displayName)]
            public virtual uint Header {
                get => Header_raw;
                set {
                    if (Header_raw == value) return;
                    Header_raw = value;
                    OnPropertyChanged(nameof(Header));
                }
            }

            protected string Path_raw;
            public const string Path_displayName = "Path";
            public const int Path_sortIndex = 100;
            [SortOrder(Path_sortIndex)]
            [DisplayName(Path_displayName)]
            public virtual string Path {
                get => Path_raw;
                set {
                    if (Path_raw == value) return;
                    Path_raw = value;
                    OnPropertyChanged(nameof(Path));
                }
            }

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 150;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual uint Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected uint Flags_raw;
            public const string Flags_displayName = "Flags";
            public const int Flags_sortIndex = 200;
            [SortOrder(Flags_sortIndex)]
            [DisplayName(Flags_displayName)]
            public virtual uint Flags {
                get => Flags_raw;
                set {
                    if (Flags_raw == value) return;
                    Flags_raw = value;
                    OnPropertyChanged(nameof(Flags));
                }
            }

            protected uint Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 250;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual uint Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            public static Linked_Shell_Params LoadData(BinaryReader reader) {
                var data = new Linked_Shell_Params();
                data.Header_raw = reader.ReadUInt32();
                data.Path_raw = reader.ReadNullTermString();
                data.Unk_1_raw = reader.ReadUInt32();
                data.Flags_raw = reader.ReadUInt32();
                data.Unk_3_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Header_raw);
                writer.Write(Path_raw.ToNullTermCharArray());
                writer.Write(Unk_1_raw);
                writer.Write(Flags_raw);
                writer.Write(Unk_3_raw);
            }
        }

        public partial class Shlp_2_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Shlp (2)";

            protected uint Ground_Decal_EPV_VFX_Group_Id_raw;
            public const string Ground_Decal_EPV_VFX_Group_Id_displayName = "Ground Decal: EPV_VFX_Group Id";
            public const int Ground_Decal_EPV_VFX_Group_Id_sortIndex = 50;
            [SortOrder(Ground_Decal_EPV_VFX_Group_Id_sortIndex)]
            [DisplayName(Ground_Decal_EPV_VFX_Group_Id_displayName)]
            public virtual uint Ground_Decal_EPV_VFX_Group_Id {
                get => Ground_Decal_EPV_VFX_Group_Id_raw;
                set {
                    if (Ground_Decal_EPV_VFX_Group_Id_raw == value) return;
                    Ground_Decal_EPV_VFX_Group_Id_raw = value;
                    OnPropertyChanged(nameof(Ground_Decal_EPV_VFX_Group_Id));
                }
            }

            protected uint Ground_Decal_EPV_VFX_Effect_Index_raw;
            public const string Ground_Decal_EPV_VFX_Effect_Index_displayName = "Ground Decal: EPV VFX Effect Index";
            public const int Ground_Decal_EPV_VFX_Effect_Index_sortIndex = 100;
            [SortOrder(Ground_Decal_EPV_VFX_Effect_Index_sortIndex)]
            [DisplayName(Ground_Decal_EPV_VFX_Effect_Index_displayName)]
            public virtual uint Ground_Decal_EPV_VFX_Effect_Index {
                get => Ground_Decal_EPV_VFX_Effect_Index_raw;
                set {
                    if (Ground_Decal_EPV_VFX_Effect_Index_raw == value) return;
                    Ground_Decal_EPV_VFX_Effect_Index_raw = value;
                    OnPropertyChanged(nameof(Ground_Decal_EPV_VFX_Effect_Index));
                }
            }

            protected uint Wall_Decal_EPV_VFX_Group_Id_raw;
            public const string Wall_Decal_EPV_VFX_Group_Id_displayName = "Wall Decal: EPV VFX Group Id";
            public const int Wall_Decal_EPV_VFX_Group_Id_sortIndex = 150;
            [SortOrder(Wall_Decal_EPV_VFX_Group_Id_sortIndex)]
            [DisplayName(Wall_Decal_EPV_VFX_Group_Id_displayName)]
            public virtual uint Wall_Decal_EPV_VFX_Group_Id {
                get => Wall_Decal_EPV_VFX_Group_Id_raw;
                set {
                    if (Wall_Decal_EPV_VFX_Group_Id_raw == value) return;
                    Wall_Decal_EPV_VFX_Group_Id_raw = value;
                    OnPropertyChanged(nameof(Wall_Decal_EPV_VFX_Group_Id));
                }
            }

            protected uint Wall_Decal_EPV_VFX_Effect_Index_raw;
            public const string Wall_Decal_EPV_VFX_Effect_Index_displayName = "Wall Decal: EPV VFX Effect Index";
            public const int Wall_Decal_EPV_VFX_Effect_Index_sortIndex = 200;
            [SortOrder(Wall_Decal_EPV_VFX_Effect_Index_sortIndex)]
            [DisplayName(Wall_Decal_EPV_VFX_Effect_Index_displayName)]
            public virtual uint Wall_Decal_EPV_VFX_Effect_Index {
                get => Wall_Decal_EPV_VFX_Effect_Index_raw;
                set {
                    if (Wall_Decal_EPV_VFX_Effect_Index_raw == value) return;
                    Wall_Decal_EPV_VFX_Effect_Index_raw = value;
                    OnPropertyChanged(nameof(Wall_Decal_EPV_VFX_Effect_Index));
                }
            }

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 250;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual uint Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected uint Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 300;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual uint Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected uint Obj_Hit_VFX_Group_Id_raw;
            public const string Obj_Hit_VFX_Group_Id_displayName = "Obj Hit: VFX Group Id";
            public const int Obj_Hit_VFX_Group_Id_sortIndex = 350;
            [SortOrder(Obj_Hit_VFX_Group_Id_sortIndex)]
            [DisplayName(Obj_Hit_VFX_Group_Id_displayName)]
            public virtual uint Obj_Hit_VFX_Group_Id {
                get => Obj_Hit_VFX_Group_Id_raw;
                set {
                    if (Obj_Hit_VFX_Group_Id_raw == value) return;
                    Obj_Hit_VFX_Group_Id_raw = value;
                    OnPropertyChanged(nameof(Obj_Hit_VFX_Group_Id));
                }
            }

            protected uint Obj_Hit_VFX_Effect_Index_raw;
            public const string Obj_Hit_VFX_Effect_Index_displayName = "Obj Hit: VFX Effect Index";
            public const int Obj_Hit_VFX_Effect_Index_sortIndex = 400;
            [SortOrder(Obj_Hit_VFX_Effect_Index_sortIndex)]
            [DisplayName(Obj_Hit_VFX_Effect_Index_displayName)]
            public virtual uint Obj_Hit_VFX_Effect_Index {
                get => Obj_Hit_VFX_Effect_Index_raw;
                set {
                    if (Obj_Hit_VFX_Effect_Index_raw == value) return;
                    Obj_Hit_VFX_Effect_Index_raw = value;
                    OnPropertyChanged(nameof(Obj_Hit_VFX_Effect_Index));
                }
            }

            protected byte Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 450;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual byte Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected byte Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 500;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual byte Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected byte Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 550;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual byte Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            protected byte Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 600;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual byte Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            protected byte Unk_7_raw;
            public const string Unk_7_displayName = "Unk 7";
            public const int Unk_7_sortIndex = 650;
            [SortOrder(Unk_7_sortIndex)]
            [DisplayName(Unk_7_displayName)]
            public virtual byte Unk_7 {
                get => Unk_7_raw;
                set {
                    if (Unk_7_raw == value) return;
                    Unk_7_raw = value;
                    OnPropertyChanged(nameof(Unk_7));
                }
            }

            protected byte Unk_8_raw;
            public const string Unk_8_displayName = "Unk 8";
            public const int Unk_8_sortIndex = 700;
            [SortOrder(Unk_8_sortIndex)]
            [DisplayName(Unk_8_displayName)]
            public virtual byte Unk_8 {
                get => Unk_8_raw;
                set {
                    if (Unk_8_raw == value) return;
                    Unk_8_raw = value;
                    OnPropertyChanged(nameof(Unk_8));
                }
            }

            protected byte Unk_9_raw;
            public const string Unk_9_displayName = "Unk 9";
            public const int Unk_9_sortIndex = 750;
            [SortOrder(Unk_9_sortIndex)]
            [DisplayName(Unk_9_displayName)]
            public virtual byte Unk_9 {
                get => Unk_9_raw;
                set {
                    if (Unk_9_raw == value) return;
                    Unk_9_raw = value;
                    OnPropertyChanged(nameof(Unk_9));
                }
            }

            protected byte Unk_10_raw;
            public const string Unk_10_displayName = "Unk 10";
            public const int Unk_10_sortIndex = 800;
            [SortOrder(Unk_10_sortIndex)]
            [DisplayName(Unk_10_displayName)]
            public virtual byte Unk_10 {
                get => Unk_10_raw;
                set {
                    if (Unk_10_raw == value) return;
                    Unk_10_raw = value;
                    OnPropertyChanged(nameof(Unk_10));
                }
            }

            protected byte Unk_11_raw;
            public const string Unk_11_displayName = "Unk 11";
            public const int Unk_11_sortIndex = 850;
            [SortOrder(Unk_11_sortIndex)]
            [DisplayName(Unk_11_displayName)]
            public virtual byte Unk_11 {
                get => Unk_11_raw;
                set {
                    if (Unk_11_raw == value) return;
                    Unk_11_raw = value;
                    OnPropertyChanged(nameof(Unk_11));
                }
            }

            protected byte Unk_12_raw;
            public const string Unk_12_displayName = "Unk 12";
            public const int Unk_12_sortIndex = 900;
            [SortOrder(Unk_12_sortIndex)]
            [DisplayName(Unk_12_displayName)]
            public virtual byte Unk_12 {
                get => Unk_12_raw;
                set {
                    if (Unk_12_raw == value) return;
                    Unk_12_raw = value;
                    OnPropertyChanged(nameof(Unk_12));
                }
            }

            protected byte Unk_13_raw;
            public const string Unk_13_displayName = "Unk 13";
            public const int Unk_13_sortIndex = 950;
            [SortOrder(Unk_13_sortIndex)]
            [DisplayName(Unk_13_displayName)]
            public virtual byte Unk_13 {
                get => Unk_13_raw;
                set {
                    if (Unk_13_raw == value) return;
                    Unk_13_raw = value;
                    OnPropertyChanged(nameof(Unk_13));
                }
            }

            protected byte Unk_14_raw;
            public const string Unk_14_displayName = "Unk 14";
            public const int Unk_14_sortIndex = 1000;
            [SortOrder(Unk_14_sortIndex)]
            [DisplayName(Unk_14_displayName)]
            public virtual byte Unk_14 {
                get => Unk_14_raw;
                set {
                    if (Unk_14_raw == value) return;
                    Unk_14_raw = value;
                    OnPropertyChanged(nameof(Unk_14));
                }
            }

            protected uint Unk_15_raw;
            public const string Unk_15_displayName = "Unk 15";
            public const int Unk_15_sortIndex = 1050;
            [SortOrder(Unk_15_sortIndex)]
            [DisplayName(Unk_15_displayName)]
            public virtual uint Unk_15 {
                get => Unk_15_raw;
                set {
                    if (Unk_15_raw == value) return;
                    Unk_15_raw = value;
                    OnPropertyChanged(nameof(Unk_15));
                }
            }

            protected uint Unk_16_raw;
            public const string Unk_16_displayName = "Unk 16";
            public const int Unk_16_sortIndex = 1100;
            [SortOrder(Unk_16_sortIndex)]
            [DisplayName(Unk_16_displayName)]
            public virtual uint Unk_16 {
                get => Unk_16_raw;
                set {
                    if (Unk_16_raw == value) return;
                    Unk_16_raw = value;
                    OnPropertyChanged(nameof(Unk_16));
                }
            }

            protected uint Unk_17_raw;
            public const string Unk_17_displayName = "Unk 17";
            public const int Unk_17_sortIndex = 1150;
            [SortOrder(Unk_17_sortIndex)]
            [DisplayName(Unk_17_displayName)]
            public virtual uint Unk_17 {
                get => Unk_17_raw;
                set {
                    if (Unk_17_raw == value) return;
                    Unk_17_raw = value;
                    OnPropertyChanged(nameof(Unk_17));
                }
            }

            protected byte Unk_18_raw;
            public const string Unk_18_displayName = "Unk 18";
            public const int Unk_18_sortIndex = 1200;
            [SortOrder(Unk_18_sortIndex)]
            [DisplayName(Unk_18_displayName)]
            public virtual byte Unk_18 {
                get => Unk_18_raw;
                set {
                    if (Unk_18_raw == value) return;
                    Unk_18_raw = value;
                    OnPropertyChanged(nameof(Unk_18));
                }
            }

            protected uint Unk_19_raw;
            public const string Unk_19_displayName = "Unk 19";
            public const int Unk_19_sortIndex = 1250;
            [SortOrder(Unk_19_sortIndex)]
            [DisplayName(Unk_19_displayName)]
            public virtual uint Unk_19 {
                get => Unk_19_raw;
                set {
                    if (Unk_19_raw == value) return;
                    Unk_19_raw = value;
                    OnPropertyChanged(nameof(Unk_19));
                }
            }

            protected uint Unk_20_raw;
            public const string Unk_20_displayName = "Unk 20";
            public const int Unk_20_sortIndex = 1300;
            [SortOrder(Unk_20_sortIndex)]
            [DisplayName(Unk_20_displayName)]
            public virtual uint Unk_20 {
                get => Unk_20_raw;
                set {
                    if (Unk_20_raw == value) return;
                    Unk_20_raw = value;
                    OnPropertyChanged(nameof(Unk_20));
                }
            }

            protected byte Unk_21_raw;
            public const string Unk_21_displayName = "Unk 21";
            public const int Unk_21_sortIndex = 1350;
            [SortOrder(Unk_21_sortIndex)]
            [DisplayName(Unk_21_displayName)]
            public virtual byte Unk_21 {
                get => Unk_21_raw;
                set {
                    if (Unk_21_raw == value) return;
                    Unk_21_raw = value;
                    OnPropertyChanged(nameof(Unk_21));
                }
            }

            protected int Unk_22_raw;
            public const string Unk_22_displayName = "Unk 22";
            public const int Unk_22_sortIndex = 1400;
            [SortOrder(Unk_22_sortIndex)]
            [DisplayName(Unk_22_displayName)]
            public virtual int Unk_22 {
                get => Unk_22_raw;
                set {
                    if (Unk_22_raw == value) return;
                    Unk_22_raw = value;
                    OnPropertyChanged(nameof(Unk_22));
                }
            }

            protected uint Unk_23_raw;
            public const string Unk_23_displayName = "Unk 23";
            public const int Unk_23_sortIndex = 1450;
            [SortOrder(Unk_23_sortIndex)]
            [DisplayName(Unk_23_displayName)]
            public virtual uint Unk_23 {
                get => Unk_23_raw;
                set {
                    if (Unk_23_raw == value) return;
                    Unk_23_raw = value;
                    OnPropertyChanged(nameof(Unk_23));
                }
            }

            protected uint Unk_24_raw;
            public const string Unk_24_displayName = "Unk 24";
            public const int Unk_24_sortIndex = 1500;
            [SortOrder(Unk_24_sortIndex)]
            [DisplayName(Unk_24_displayName)]
            public virtual uint Unk_24 {
                get => Unk_24_raw;
                set {
                    if (Unk_24_raw == value) return;
                    Unk_24_raw = value;
                    OnPropertyChanged(nameof(Unk_24));
                }
            }

            protected uint Unk_25_raw;
            public const string Unk_25_displayName = "Unk 25";
            public const int Unk_25_sortIndex = 1550;
            [SortOrder(Unk_25_sortIndex)]
            [DisplayName(Unk_25_displayName)]
            public virtual uint Unk_25 {
                get => Unk_25_raw;
                set {
                    if (Unk_25_raw == value) return;
                    Unk_25_raw = value;
                    OnPropertyChanged(nameof(Unk_25));
                }
            }

            protected uint Unk_26_raw;
            public const string Unk_26_displayName = "Unk 26";
            public const int Unk_26_sortIndex = 1600;
            [SortOrder(Unk_26_sortIndex)]
            [DisplayName(Unk_26_displayName)]
            public virtual uint Unk_26 {
                get => Unk_26_raw;
                set {
                    if (Unk_26_raw == value) return;
                    Unk_26_raw = value;
                    OnPropertyChanged(nameof(Unk_26));
                }
            }

            protected uint Gun_Fire_EPV_VFX_Group_Id_raw;
            public const string Gun_Fire_EPV_VFX_Group_Id_displayName = "Gun Fire: EPV VFX Group Id";
            public const int Gun_Fire_EPV_VFX_Group_Id_sortIndex = 1650;
            [SortOrder(Gun_Fire_EPV_VFX_Group_Id_sortIndex)]
            [DisplayName(Gun_Fire_EPV_VFX_Group_Id_displayName)]
            public virtual uint Gun_Fire_EPV_VFX_Group_Id {
                get => Gun_Fire_EPV_VFX_Group_Id_raw;
                set {
                    if (Gun_Fire_EPV_VFX_Group_Id_raw == value) return;
                    Gun_Fire_EPV_VFX_Group_Id_raw = value;
                    OnPropertyChanged(nameof(Gun_Fire_EPV_VFX_Group_Id));
                }
            }

            protected uint Gun_Fire_EPV_VFX_Effect_Index_raw;
            public const string Gun_Fire_EPV_VFX_Effect_Index_displayName = "Gun Fire: EPV VFX Effect Index";
            public const int Gun_Fire_EPV_VFX_Effect_Index_sortIndex = 1700;
            [SortOrder(Gun_Fire_EPV_VFX_Effect_Index_sortIndex)]
            [DisplayName(Gun_Fire_EPV_VFX_Effect_Index_displayName)]
            public virtual uint Gun_Fire_EPV_VFX_Effect_Index {
                get => Gun_Fire_EPV_VFX_Effect_Index_raw;
                set {
                    if (Gun_Fire_EPV_VFX_Effect_Index_raw == value) return;
                    Gun_Fire_EPV_VFX_Effect_Index_raw = value;
                    OnPropertyChanged(nameof(Gun_Fire_EPV_VFX_Effect_Index));
                }
            }

            protected uint Unk_27_raw;
            public const string Unk_27_displayName = "Unk 27";
            public const int Unk_27_sortIndex = 1750;
            [SortOrder(Unk_27_sortIndex)]
            [DisplayName(Unk_27_displayName)]
            public virtual uint Unk_27 {
                get => Unk_27_raw;
                set {
                    if (Unk_27_raw == value) return;
                    Unk_27_raw = value;
                    OnPropertyChanged(nameof(Unk_27));
                }
            }

            protected uint Unk_28_raw;
            public const string Unk_28_displayName = "Unk 28";
            public const int Unk_28_sortIndex = 1800;
            [SortOrder(Unk_28_sortIndex)]
            [DisplayName(Unk_28_displayName)]
            public virtual uint Unk_28 {
                get => Unk_28_raw;
                set {
                    if (Unk_28_raw == value) return;
                    Unk_28_raw = value;
                    OnPropertyChanged(nameof(Unk_28));
                }
            }

            protected uint Unk_29_raw;
            public const string Unk_29_displayName = "Unk 29";
            public const int Unk_29_sortIndex = 1850;
            [SortOrder(Unk_29_sortIndex)]
            [DisplayName(Unk_29_displayName)]
            public virtual uint Unk_29 {
                get => Unk_29_raw;
                set {
                    if (Unk_29_raw == value) return;
                    Unk_29_raw = value;
                    OnPropertyChanged(nameof(Unk_29));
                }
            }

            protected uint Unk_30_raw;
            public const string Unk_30_displayName = "Unk 30";
            public const int Unk_30_sortIndex = 1900;
            [SortOrder(Unk_30_sortIndex)]
            [DisplayName(Unk_30_displayName)]
            public virtual uint Unk_30 {
                get => Unk_30_raw;
                set {
                    if (Unk_30_raw == value) return;
                    Unk_30_raw = value;
                    OnPropertyChanged(nameof(Unk_30));
                }
            }

            protected uint Unk_31_raw;
            public const string Unk_31_displayName = "Unk 31";
            public const int Unk_31_sortIndex = 1950;
            [SortOrder(Unk_31_sortIndex)]
            [DisplayName(Unk_31_displayName)]
            public virtual uint Unk_31 {
                get => Unk_31_raw;
                set {
                    if (Unk_31_raw == value) return;
                    Unk_31_raw = value;
                    OnPropertyChanged(nameof(Unk_31));
                }
            }

            protected uint Unk_32_raw;
            public const string Unk_32_displayName = "Unk 32";
            public const int Unk_32_sortIndex = 2000;
            [SortOrder(Unk_32_sortIndex)]
            [DisplayName(Unk_32_displayName)]
            public virtual uint Unk_32 {
                get => Unk_32_raw;
                set {
                    if (Unk_32_raw == value) return;
                    Unk_32_raw = value;
                    OnPropertyChanged(nameof(Unk_32));
                }
            }

            protected uint Unk_33_raw;
            public const string Unk_33_displayName = "Unk 33";
            public const int Unk_33_sortIndex = 2050;
            [SortOrder(Unk_33_sortIndex)]
            [DisplayName(Unk_33_displayName)]
            public virtual uint Unk_33 {
                get => Unk_33_raw;
                set {
                    if (Unk_33_raw == value) return;
                    Unk_33_raw = value;
                    OnPropertyChanged(nameof(Unk_33));
                }
            }

            protected uint Unk_34_raw;
            public const string Unk_34_displayName = "Unk 34";
            public const int Unk_34_sortIndex = 2100;
            [SortOrder(Unk_34_sortIndex)]
            [DisplayName(Unk_34_displayName)]
            public virtual uint Unk_34 {
                get => Unk_34_raw;
                set {
                    if (Unk_34_raw == value) return;
                    Unk_34_raw = value;
                    OnPropertyChanged(nameof(Unk_34));
                }
            }

            protected uint Wwise_Container_Header_raw;
            public const string Wwise_Container_Header_displayName = "Wwise Container Header";
            public const int Wwise_Container_Header_sortIndex = 2150;
            [SortOrder(Wwise_Container_Header_sortIndex)]
            [DisplayName(Wwise_Container_Header_displayName)]
            public virtual uint Wwise_Container_Header {
                get => Wwise_Container_Header_raw;
                set {
                    if (Wwise_Container_Header_raw == value) return;
                    Wwise_Container_Header_raw = value;
                    OnPropertyChanged(nameof(Wwise_Container_Header));
                }
            }

            protected string Wwise_Container_raw;
            public const string Wwise_Container_displayName = "Wwise Container";
            public const int Wwise_Container_sortIndex = 2200;
            [SortOrder(Wwise_Container_sortIndex)]
            [DisplayName(Wwise_Container_displayName)]
            public virtual string Wwise_Container {
                get => Wwise_Container_raw;
                set {
                    if (Wwise_Container_raw == value) return;
                    Wwise_Container_raw = value;
                    OnPropertyChanged(nameof(Wwise_Container));
                }
            }

            protected int Sound_Gun_Fire_Header_raw;
            public const string Sound_Gun_Fire_Header_displayName = "Sound: Gun Fire Header";
            public const int Sound_Gun_Fire_Header_sortIndex = 2250;
            [SortOrder(Sound_Gun_Fire_Header_sortIndex)]
            [DisplayName(Sound_Gun_Fire_Header_displayName)]
            public virtual int Sound_Gun_Fire_Header {
                get => Sound_Gun_Fire_Header_raw;
                set {
                    if (Sound_Gun_Fire_Header_raw == value) return;
                    Sound_Gun_Fire_Header_raw = value;
                    OnPropertyChanged(nameof(Sound_Gun_Fire_Header));
                }
            }

            protected int Sound_Gun_Fire_raw;
            public const string Sound_Gun_Fire_displayName = "Sound: Gun Fire";
            public const int Sound_Gun_Fire_sortIndex = 2300;
            [SortOrder(Sound_Gun_Fire_sortIndex)]
            [DisplayName(Sound_Gun_Fire_displayName)]
            public virtual int Sound_Gun_Fire {
                get => Sound_Gun_Fire_raw;
                set {
                    if (Sound_Gun_Fire_raw == value) return;
                    Sound_Gun_Fire_raw = value;
                    OnPropertyChanged(nameof(Sound_Gun_Fire));
                }
            }

            protected int Sound_Bullet_Travel_Header_raw;
            public const string Sound_Bullet_Travel_Header_displayName = "Sound: Bullet Travel Header";
            public const int Sound_Bullet_Travel_Header_sortIndex = 2350;
            [SortOrder(Sound_Bullet_Travel_Header_sortIndex)]
            [DisplayName(Sound_Bullet_Travel_Header_displayName)]
            public virtual int Sound_Bullet_Travel_Header {
                get => Sound_Bullet_Travel_Header_raw;
                set {
                    if (Sound_Bullet_Travel_Header_raw == value) return;
                    Sound_Bullet_Travel_Header_raw = value;
                    OnPropertyChanged(nameof(Sound_Bullet_Travel_Header));
                }
            }

            protected int Sound_Bullet_Travel_raw;
            public const string Sound_Bullet_Travel_displayName = "Sound: Bullet Travel";
            public const int Sound_Bullet_Travel_sortIndex = 2400;
            [SortOrder(Sound_Bullet_Travel_sortIndex)]
            [DisplayName(Sound_Bullet_Travel_displayName)]
            public virtual int Sound_Bullet_Travel {
                get => Sound_Bullet_Travel_raw;
                set {
                    if (Sound_Bullet_Travel_raw == value) return;
                    Sound_Bullet_Travel_raw = value;
                    OnPropertyChanged(nameof(Sound_Bullet_Travel));
                }
            }

            protected int Sound_Explode_Header_raw;
            public const string Sound_Explode_Header_displayName = "Sound: Explode Header";
            public const int Sound_Explode_Header_sortIndex = 2450;
            [SortOrder(Sound_Explode_Header_sortIndex)]
            [DisplayName(Sound_Explode_Header_displayName)]
            public virtual int Sound_Explode_Header {
                get => Sound_Explode_Header_raw;
                set {
                    if (Sound_Explode_Header_raw == value) return;
                    Sound_Explode_Header_raw = value;
                    OnPropertyChanged(nameof(Sound_Explode_Header));
                }
            }

            protected int Sound_Explode_raw;
            public const string Sound_Explode_displayName = "Sound: Explode";
            public const int Sound_Explode_sortIndex = 2500;
            [SortOrder(Sound_Explode_sortIndex)]
            [DisplayName(Sound_Explode_displayName)]
            public virtual int Sound_Explode {
                get => Sound_Explode_raw;
                set {
                    if (Sound_Explode_raw == value) return;
                    Sound_Explode_raw = value;
                    OnPropertyChanged(nameof(Sound_Explode));
                }
            }

            protected int Sound_Hit_Wall_or_Ground_Header_raw;
            public const string Sound_Hit_Wall_or_Ground_Header_displayName = "Sound: Hit Wall or Ground Header";
            public const int Sound_Hit_Wall_or_Ground_Header_sortIndex = 2550;
            [SortOrder(Sound_Hit_Wall_or_Ground_Header_sortIndex)]
            [DisplayName(Sound_Hit_Wall_or_Ground_Header_displayName)]
            public virtual int Sound_Hit_Wall_or_Ground_Header {
                get => Sound_Hit_Wall_or_Ground_Header_raw;
                set {
                    if (Sound_Hit_Wall_or_Ground_Header_raw == value) return;
                    Sound_Hit_Wall_or_Ground_Header_raw = value;
                    OnPropertyChanged(nameof(Sound_Hit_Wall_or_Ground_Header));
                }
            }

            protected int Sound_Hit_Wall_or_Ground_raw;
            public const string Sound_Hit_Wall_or_Ground_displayName = "Sound: Hit Wall or Ground";
            public const int Sound_Hit_Wall_or_Ground_sortIndex = 2600;
            [SortOrder(Sound_Hit_Wall_or_Ground_sortIndex)]
            [DisplayName(Sound_Hit_Wall_or_Ground_displayName)]
            public virtual int Sound_Hit_Wall_or_Ground {
                get => Sound_Hit_Wall_or_Ground_raw;
                set {
                    if (Sound_Hit_Wall_or_Ground_raw == value) return;
                    Sound_Hit_Wall_or_Ground_raw = value;
                    OnPropertyChanged(nameof(Sound_Hit_Wall_or_Ground));
                }
            }

            protected int Sound_Hit_Obj_Hit_Header_raw;
            public const string Sound_Hit_Obj_Hit_Header_displayName = "Sound: Hit Obj Hit Header";
            public const int Sound_Hit_Obj_Hit_Header_sortIndex = 2650;
            [SortOrder(Sound_Hit_Obj_Hit_Header_sortIndex)]
            [DisplayName(Sound_Hit_Obj_Hit_Header_displayName)]
            public virtual int Sound_Hit_Obj_Hit_Header {
                get => Sound_Hit_Obj_Hit_Header_raw;
                set {
                    if (Sound_Hit_Obj_Hit_Header_raw == value) return;
                    Sound_Hit_Obj_Hit_Header_raw = value;
                    OnPropertyChanged(nameof(Sound_Hit_Obj_Hit_Header));
                }
            }

            protected int Sound_Hit_Obj_Hit_raw;
            public const string Sound_Hit_Obj_Hit_displayName = "Sound: Hit Obj Hit";
            public const int Sound_Hit_Obj_Hit_sortIndex = 2700;
            [SortOrder(Sound_Hit_Obj_Hit_sortIndex)]
            [DisplayName(Sound_Hit_Obj_Hit_displayName)]
            public virtual int Sound_Hit_Obj_Hit {
                get => Sound_Hit_Obj_Hit_raw;
                set {
                    if (Sound_Hit_Obj_Hit_raw == value) return;
                    Sound_Hit_Obj_Hit_raw = value;
                    OnPropertyChanged(nameof(Sound_Hit_Obj_Hit));
                }
            }

            protected int Sound_Condition_Header_1_raw;
            public const string Sound_Condition_Header_1_displayName = "Sound: Condition Header 1";
            public const int Sound_Condition_Header_1_sortIndex = 2750;
            [SortOrder(Sound_Condition_Header_1_sortIndex)]
            [DisplayName(Sound_Condition_Header_1_displayName)]
            public virtual int Sound_Condition_Header_1 {
                get => Sound_Condition_Header_1_raw;
                set {
                    if (Sound_Condition_Header_1_raw == value) return;
                    Sound_Condition_Header_1_raw = value;
                    OnPropertyChanged(nameof(Sound_Condition_Header_1));
                }
            }

            protected int Sound_Condition_1_raw;
            public const string Sound_Condition_1_displayName = "Sound: Condition 1";
            public const int Sound_Condition_1_sortIndex = 2800;
            [SortOrder(Sound_Condition_1_sortIndex)]
            [DisplayName(Sound_Condition_1_displayName)]
            public virtual int Sound_Condition_1 {
                get => Sound_Condition_1_raw;
                set {
                    if (Sound_Condition_1_raw == value) return;
                    Sound_Condition_1_raw = value;
                    OnPropertyChanged(nameof(Sound_Condition_1));
                }
            }

            protected int Sound_Slinger_Condition_Header_1_raw;
            public const string Sound_Slinger_Condition_Header_1_displayName = "Sound: Slinger Condition Header 1";
            public const int Sound_Slinger_Condition_Header_1_sortIndex = 2850;
            [SortOrder(Sound_Slinger_Condition_Header_1_sortIndex)]
            [DisplayName(Sound_Slinger_Condition_Header_1_displayName)]
            public virtual int Sound_Slinger_Condition_Header_1 {
                get => Sound_Slinger_Condition_Header_1_raw;
                set {
                    if (Sound_Slinger_Condition_Header_1_raw == value) return;
                    Sound_Slinger_Condition_Header_1_raw = value;
                    OnPropertyChanged(nameof(Sound_Slinger_Condition_Header_1));
                }
            }

            protected int Sound_Slinger_Condition_1_raw;
            public const string Sound_Slinger_Condition_1_displayName = "Sound: Slinger Condition 1";
            public const int Sound_Slinger_Condition_1_sortIndex = 2900;
            [SortOrder(Sound_Slinger_Condition_1_sortIndex)]
            [DisplayName(Sound_Slinger_Condition_1_displayName)]
            public virtual int Sound_Slinger_Condition_1 {
                get => Sound_Slinger_Condition_1_raw;
                set {
                    if (Sound_Slinger_Condition_1_raw == value) return;
                    Sound_Slinger_Condition_1_raw = value;
                    OnPropertyChanged(nameof(Sound_Slinger_Condition_1));
                }
            }

            protected int Sound_Slinger_Condition_Header_2_raw;
            public const string Sound_Slinger_Condition_Header_2_displayName = "Sound: Slinger Condition Header 2";
            public const int Sound_Slinger_Condition_Header_2_sortIndex = 2950;
            [SortOrder(Sound_Slinger_Condition_Header_2_sortIndex)]
            [DisplayName(Sound_Slinger_Condition_Header_2_displayName)]
            public virtual int Sound_Slinger_Condition_Header_2 {
                get => Sound_Slinger_Condition_Header_2_raw;
                set {
                    if (Sound_Slinger_Condition_Header_2_raw == value) return;
                    Sound_Slinger_Condition_Header_2_raw = value;
                    OnPropertyChanged(nameof(Sound_Slinger_Condition_Header_2));
                }
            }

            protected int Sound_Slinger_Condition_2_raw;
            public const string Sound_Slinger_Condition_2_displayName = "Sound: Slinger Condition 2";
            public const int Sound_Slinger_Condition_2_sortIndex = 3000;
            [SortOrder(Sound_Slinger_Condition_2_sortIndex)]
            [DisplayName(Sound_Slinger_Condition_2_displayName)]
            public virtual int Sound_Slinger_Condition_2 {
                get => Sound_Slinger_Condition_2_raw;
                set {
                    if (Sound_Slinger_Condition_2_raw == value) return;
                    Sound_Slinger_Condition_2_raw = value;
                    OnPropertyChanged(nameof(Sound_Slinger_Condition_2));
                }
            }

            protected int Sound_Condition_Header_2_raw;
            public const string Sound_Condition_Header_2_displayName = "Sound: Condition Header 2";
            public const int Sound_Condition_Header_2_sortIndex = 3050;
            [SortOrder(Sound_Condition_Header_2_sortIndex)]
            [DisplayName(Sound_Condition_Header_2_displayName)]
            public virtual int Sound_Condition_Header_2 {
                get => Sound_Condition_Header_2_raw;
                set {
                    if (Sound_Condition_Header_2_raw == value) return;
                    Sound_Condition_Header_2_raw = value;
                    OnPropertyChanged(nameof(Sound_Condition_Header_2));
                }
            }

            protected int Sound_Condition_2_raw;
            public const string Sound_Condition_2_displayName = "Sound: Condition 2";
            public const int Sound_Condition_2_sortIndex = 3100;
            [SortOrder(Sound_Condition_2_sortIndex)]
            [DisplayName(Sound_Condition_2_displayName)]
            public virtual int Sound_Condition_2 {
                get => Sound_Condition_2_raw;
                set {
                    if (Sound_Condition_2_raw == value) return;
                    Sound_Condition_2_raw = value;
                    OnPropertyChanged(nameof(Sound_Condition_2));
                }
            }

            protected int Sound_Condition_Header_3_raw;
            public const string Sound_Condition_Header_3_displayName = "Sound: Condition Header 3";
            public const int Sound_Condition_Header_3_sortIndex = 3150;
            [SortOrder(Sound_Condition_Header_3_sortIndex)]
            [DisplayName(Sound_Condition_Header_3_displayName)]
            public virtual int Sound_Condition_Header_3 {
                get => Sound_Condition_Header_3_raw;
                set {
                    if (Sound_Condition_Header_3_raw == value) return;
                    Sound_Condition_Header_3_raw = value;
                    OnPropertyChanged(nameof(Sound_Condition_Header_3));
                }
            }

            protected int Sound_Condition_3_raw;
            public const string Sound_Condition_3_displayName = "Sound: Condition 3";
            public const int Sound_Condition_3_sortIndex = 3200;
            [SortOrder(Sound_Condition_3_sortIndex)]
            [DisplayName(Sound_Condition_3_displayName)]
            public virtual int Sound_Condition_3 {
                get => Sound_Condition_3_raw;
                set {
                    if (Sound_Condition_3_raw == value) return;
                    Sound_Condition_3_raw = value;
                    OnPropertyChanged(nameof(Sound_Condition_3));
                }
            }

            protected int Sound_Condition_Header_4_raw;
            public const string Sound_Condition_Header_4_displayName = "Sound: Condition Header 4";
            public const int Sound_Condition_Header_4_sortIndex = 3250;
            [SortOrder(Sound_Condition_Header_4_sortIndex)]
            [DisplayName(Sound_Condition_Header_4_displayName)]
            public virtual int Sound_Condition_Header_4 {
                get => Sound_Condition_Header_4_raw;
                set {
                    if (Sound_Condition_Header_4_raw == value) return;
                    Sound_Condition_Header_4_raw = value;
                    OnPropertyChanged(nameof(Sound_Condition_Header_4));
                }
            }

            protected int Sound_Condition_4_raw;
            public const string Sound_Condition_4_displayName = "Sound: Condition 4";
            public const int Sound_Condition_4_sortIndex = 3300;
            [SortOrder(Sound_Condition_4_sortIndex)]
            [DisplayName(Sound_Condition_4_displayName)]
            public virtual int Sound_Condition_4 {
                get => Sound_Condition_4_raw;
                set {
                    if (Sound_Condition_4_raw == value) return;
                    Sound_Condition_4_raw = value;
                    OnPropertyChanged(nameof(Sound_Condition_4));
                }
            }

            protected int Sound_Condition_Header_5_raw;
            public const string Sound_Condition_Header_5_displayName = "Sound: Condition Header 5";
            public const int Sound_Condition_Header_5_sortIndex = 3350;
            [SortOrder(Sound_Condition_Header_5_sortIndex)]
            [DisplayName(Sound_Condition_Header_5_displayName)]
            public virtual int Sound_Condition_Header_5 {
                get => Sound_Condition_Header_5_raw;
                set {
                    if (Sound_Condition_Header_5_raw == value) return;
                    Sound_Condition_Header_5_raw = value;
                    OnPropertyChanged(nameof(Sound_Condition_Header_5));
                }
            }

            protected int Sound_Condition_5_raw;
            public const string Sound_Condition_5_displayName = "Sound: Condition 5";
            public const int Sound_Condition_5_sortIndex = 3400;
            [SortOrder(Sound_Condition_5_sortIndex)]
            [DisplayName(Sound_Condition_5_displayName)]
            public virtual int Sound_Condition_5 {
                get => Sound_Condition_5_raw;
                set {
                    if (Sound_Condition_5_raw == value) return;
                    Sound_Condition_5_raw = value;
                    OnPropertyChanged(nameof(Sound_Condition_5));
                }
            }

            protected uint Header_raw;
            public const string Header_displayName = "Header";
            public const int Header_sortIndex = 3450;
            [SortOrder(Header_sortIndex)]
            [DisplayName(Header_displayName)]
            public virtual uint Header {
                get => Header_raw;
                set {
                    if (Header_raw == value) return;
                    Header_raw = value;
                    OnPropertyChanged(nameof(Header));
                }
            }

            protected uint Projectile_Entity_Collider_raw;
            public const string Projectile_Entity_Collider_displayName = "Projectile: Entity Collider";
            public const int Projectile_Entity_Collider_sortIndex = 3500;
            [SortOrder(Projectile_Entity_Collider_sortIndex)]
            [DisplayName(Projectile_Entity_Collider_displayName)]
            public virtual uint Projectile_Entity_Collider {
                get => Projectile_Entity_Collider_raw;
                set {
                    if (Projectile_Entity_Collider_raw == value) return;
                    Projectile_Entity_Collider_raw = value;
                    OnPropertyChanged(nameof(Projectile_Entity_Collider));
                }
            }

            protected float Projectile_Model_Lifespan_raw;
            public const string Projectile_Model_Lifespan_displayName = "Projectile: Model Lifespan";
            public const int Projectile_Model_Lifespan_sortIndex = 3550;
            [SortOrder(Projectile_Model_Lifespan_sortIndex)]
            [DisplayName(Projectile_Model_Lifespan_displayName)]
            public virtual float Projectile_Model_Lifespan {
                get => Projectile_Model_Lifespan_raw;
                set {
                    if (Projectile_Model_Lifespan_raw == value) return;
                    Projectile_Model_Lifespan_raw = value;
                    OnPropertyChanged(nameof(Projectile_Model_Lifespan));
                }
            }

            protected uint Projectile_Distance_Range_raw;
            public const string Projectile_Distance_Range_displayName = "Projectile: Distance Range";
            public const int Projectile_Distance_Range_sortIndex = 3600;
            [SortOrder(Projectile_Distance_Range_sortIndex)]
            [DisplayName(Projectile_Distance_Range_displayName)]
            public virtual uint Projectile_Distance_Range {
                get => Projectile_Distance_Range_raw;
                set {
                    if (Projectile_Distance_Range_raw == value) return;
                    Projectile_Distance_Range_raw = value;
                    OnPropertyChanged(nameof(Projectile_Distance_Range));
                }
            }

            protected byte Unk_35_raw;
            public const string Unk_35_displayName = "Unk 35";
            public const int Unk_35_sortIndex = 3650;
            [SortOrder(Unk_35_sortIndex)]
            [DisplayName(Unk_35_displayName)]
            public virtual byte Unk_35 {
                get => Unk_35_raw;
                set {
                    if (Unk_35_raw == value) return;
                    Unk_35_raw = value;
                    OnPropertyChanged(nameof(Unk_35));
                }
            }

            protected byte Unk_36_raw;
            public const string Unk_36_displayName = "Unk 36";
            public const int Unk_36_sortIndex = 3700;
            [SortOrder(Unk_36_sortIndex)]
            [DisplayName(Unk_36_displayName)]
            public virtual byte Unk_36 {
                get => Unk_36_raw;
                set {
                    if (Unk_36_raw == value) return;
                    Unk_36_raw = value;
                    OnPropertyChanged(nameof(Unk_36));
                }
            }

            protected byte Unk_37_raw;
            public const string Unk_37_displayName = "Unk 37";
            public const int Unk_37_sortIndex = 3750;
            [SortOrder(Unk_37_sortIndex)]
            [DisplayName(Unk_37_displayName)]
            public virtual byte Unk_37 {
                get => Unk_37_raw;
                set {
                    if (Unk_37_raw == value) return;
                    Unk_37_raw = value;
                    OnPropertyChanged(nameof(Unk_37));
                }
            }

            protected byte Unk_38_raw;
            public const string Unk_38_displayName = "Unk 38";
            public const int Unk_38_sortIndex = 3800;
            [SortOrder(Unk_38_sortIndex)]
            [DisplayName(Unk_38_displayName)]
            public virtual byte Unk_38 {
                get => Unk_38_raw;
                set {
                    if (Unk_38_raw == value) return;
                    Unk_38_raw = value;
                    OnPropertyChanged(nameof(Unk_38));
                }
            }

            protected uint Unk_39_raw;
            public const string Unk_39_displayName = "Unk 39";
            public const int Unk_39_sortIndex = 3850;
            [SortOrder(Unk_39_sortIndex)]
            [DisplayName(Unk_39_displayName)]
            public virtual uint Unk_39 {
                get => Unk_39_raw;
                set {
                    if (Unk_39_raw == value) return;
                    Unk_39_raw = value;
                    OnPropertyChanged(nameof(Unk_39));
                }
            }

            protected uint Unk_40_raw;
            public const string Unk_40_displayName = "Unk 40";
            public const int Unk_40_sortIndex = 3900;
            [SortOrder(Unk_40_sortIndex)]
            [DisplayName(Unk_40_displayName)]
            public virtual uint Unk_40 {
                get => Unk_40_raw;
                set {
                    if (Unk_40_raw == value) return;
                    Unk_40_raw = value;
                    OnPropertyChanged(nameof(Unk_40));
                }
            }

            protected uint Unk_41_raw;
            public const string Unk_41_displayName = "Unk 41";
            public const int Unk_41_sortIndex = 3950;
            [SortOrder(Unk_41_sortIndex)]
            [DisplayName(Unk_41_displayName)]
            public virtual uint Unk_41 {
                get => Unk_41_raw;
                set {
                    if (Unk_41_raw == value) return;
                    Unk_41_raw = value;
                    OnPropertyChanged(nameof(Unk_41));
                }
            }

            protected float Projectile_Spawn_Pos_Y_raw;
            public const string Projectile_Spawn_Pos_Y_displayName = "Projectile: Spawn Pos Y";
            public const int Projectile_Spawn_Pos_Y_sortIndex = 4000;
            [SortOrder(Projectile_Spawn_Pos_Y_sortIndex)]
            [DisplayName(Projectile_Spawn_Pos_Y_displayName)]
            public virtual float Projectile_Spawn_Pos_Y {
                get => Projectile_Spawn_Pos_Y_raw;
                set {
                    if (Projectile_Spawn_Pos_Y_raw == value) return;
                    Projectile_Spawn_Pos_Y_raw = value;
                    OnPropertyChanged(nameof(Projectile_Spawn_Pos_Y));
                }
            }

            protected float Projectile_Spawn_Pos_X_raw;
            public const string Projectile_Spawn_Pos_X_displayName = "Projectile: Spawn Pos X";
            public const int Projectile_Spawn_Pos_X_sortIndex = 4050;
            [SortOrder(Projectile_Spawn_Pos_X_sortIndex)]
            [DisplayName(Projectile_Spawn_Pos_X_displayName)]
            public virtual float Projectile_Spawn_Pos_X {
                get => Projectile_Spawn_Pos_X_raw;
                set {
                    if (Projectile_Spawn_Pos_X_raw == value) return;
                    Projectile_Spawn_Pos_X_raw = value;
                    OnPropertyChanged(nameof(Projectile_Spawn_Pos_X));
                }
            }

            protected float Projectile_Velocity_raw;
            public const string Projectile_Velocity_displayName = "Projectile: Velocity";
            public const int Projectile_Velocity_sortIndex = 4100;
            [SortOrder(Projectile_Velocity_sortIndex)]
            [DisplayName(Projectile_Velocity_displayName)]
            public virtual float Projectile_Velocity {
                get => Projectile_Velocity_raw;
                set {
                    if (Projectile_Velocity_raw == value) return;
                    Projectile_Velocity_raw = value;
                    OnPropertyChanged(nameof(Projectile_Velocity));
                }
            }

            protected float Projectile_Falloff_raw;
            public const string Projectile_Falloff_displayName = "Projectile: Falloff";
            public const int Projectile_Falloff_sortIndex = 4150;
            [SortOrder(Projectile_Falloff_sortIndex)]
            [DisplayName(Projectile_Falloff_displayName)]
            public virtual float Projectile_Falloff {
                get => Projectile_Falloff_raw;
                set {
                    if (Projectile_Falloff_raw == value) return;
                    Projectile_Falloff_raw = value;
                    OnPropertyChanged(nameof(Projectile_Falloff));
                }
            }

            protected float Unk_42_raw;
            public const string Unk_42_displayName = "Unk 42";
            public const int Unk_42_sortIndex = 4200;
            [SortOrder(Unk_42_sortIndex)]
            [DisplayName(Unk_42_displayName)]
            public virtual float Unk_42 {
                get => Unk_42_raw;
                set {
                    if (Unk_42_raw == value) return;
                    Unk_42_raw = value;
                    OnPropertyChanged(nameof(Unk_42));
                }
            }

            protected float Unk_43_raw;
            public const string Unk_43_displayName = "Unk 43";
            public const int Unk_43_sortIndex = 4250;
            [SortOrder(Unk_43_sortIndex)]
            [DisplayName(Unk_43_displayName)]
            public virtual float Unk_43 {
                get => Unk_43_raw;
                set {
                    if (Unk_43_raw == value) return;
                    Unk_43_raw = value;
                    OnPropertyChanged(nameof(Unk_43));
                }
            }

            protected float Unk_44_raw;
            public const string Unk_44_displayName = "Unk 44";
            public const int Unk_44_sortIndex = 4300;
            [SortOrder(Unk_44_sortIndex)]
            [DisplayName(Unk_44_displayName)]
            public virtual float Unk_44 {
                get => Unk_44_raw;
                set {
                    if (Unk_44_raw == value) return;
                    Unk_44_raw = value;
                    OnPropertyChanged(nameof(Unk_44));
                }
            }

            protected float Unk_45_raw;
            public const string Unk_45_displayName = "Unk 45";
            public const int Unk_45_sortIndex = 4350;
            [SortOrder(Unk_45_sortIndex)]
            [DisplayName(Unk_45_displayName)]
            public virtual float Unk_45 {
                get => Unk_45_raw;
                set {
                    if (Unk_45_raw == value) return;
                    Unk_45_raw = value;
                    OnPropertyChanged(nameof(Unk_45));
                }
            }

            protected float Unk_46_raw;
            public const string Unk_46_displayName = "Unk 46";
            public const int Unk_46_sortIndex = 4400;
            [SortOrder(Unk_46_sortIndex)]
            [DisplayName(Unk_46_displayName)]
            public virtual float Unk_46 {
                get => Unk_46_raw;
                set {
                    if (Unk_46_raw == value) return;
                    Unk_46_raw = value;
                    OnPropertyChanged(nameof(Unk_46));
                }
            }

            protected float Unk_47_raw;
            public const string Unk_47_displayName = "Unk 47";
            public const int Unk_47_sortIndex = 4450;
            [SortOrder(Unk_47_sortIndex)]
            [DisplayName(Unk_47_displayName)]
            public virtual float Unk_47 {
                get => Unk_47_raw;
                set {
                    if (Unk_47_raw == value) return;
                    Unk_47_raw = value;
                    OnPropertyChanged(nameof(Unk_47));
                }
            }

            protected float Unk_48_raw;
            public const string Unk_48_displayName = "Unk 48";
            public const int Unk_48_sortIndex = 4500;
            [SortOrder(Unk_48_sortIndex)]
            [DisplayName(Unk_48_displayName)]
            public virtual float Unk_48 {
                get => Unk_48_raw;
                set {
                    if (Unk_48_raw == value) return;
                    Unk_48_raw = value;
                    OnPropertyChanged(nameof(Unk_48));
                }
            }

            protected float Projectile_Hitbox_Range_raw;
            public const string Projectile_Hitbox_Range_displayName = "Projectile: Hitbox Range";
            public const int Projectile_Hitbox_Range_sortIndex = 4550;
            [SortOrder(Projectile_Hitbox_Range_sortIndex)]
            [DisplayName(Projectile_Hitbox_Range_displayName)]
            public virtual float Projectile_Hitbox_Range {
                get => Projectile_Hitbox_Range_raw;
                set {
                    if (Projectile_Hitbox_Range_raw == value) return;
                    Projectile_Hitbox_Range_raw = value;
                    OnPropertyChanged(nameof(Projectile_Hitbox_Range));
                }
            }

            protected uint Unk_49_raw;
            public const string Unk_49_displayName = "Unk 49";
            public const int Unk_49_sortIndex = 4600;
            [SortOrder(Unk_49_sortIndex)]
            [DisplayName(Unk_49_displayName)]
            public virtual uint Unk_49 {
                get => Unk_49_raw;
                set {
                    if (Unk_49_raw == value) return;
                    Unk_49_raw = value;
                    OnPropertyChanged(nameof(Unk_49));
                }
            }

            protected uint Insta_Kill_Trigger_raw;
            public const string Insta_Kill_Trigger_displayName = "Insta-Kill Trigger";
            public const int Insta_Kill_Trigger_sortIndex = 4650;
            [SortOrder(Insta_Kill_Trigger_sortIndex)]
            [DisplayName(Insta_Kill_Trigger_displayName)]
            public virtual uint Insta_Kill_Trigger {
                get => Insta_Kill_Trigger_raw;
                set {
                    if (Insta_Kill_Trigger_raw == value) return;
                    Insta_Kill_Trigger_raw = value;
                    OnPropertyChanged(nameof(Insta_Kill_Trigger));
                }
            }

            protected uint Unk_50_raw;
            public const string Unk_50_displayName = "Unk 50";
            public const int Unk_50_sortIndex = 4700;
            [SortOrder(Unk_50_sortIndex)]
            [DisplayName(Unk_50_displayName)]
            public virtual uint Unk_50 {
                get => Unk_50_raw;
                set {
                    if (Unk_50_raw == value) return;
                    Unk_50_raw = value;
                    OnPropertyChanged(nameof(Unk_50));
                }
            }

            protected ushort Unk_51_raw;
            public const string Unk_51_displayName = "Unk 51";
            public const int Unk_51_sortIndex = 4750;
            [SortOrder(Unk_51_sortIndex)]
            [DisplayName(Unk_51_displayName)]
            public virtual ushort Unk_51 {
                get => Unk_51_raw;
                set {
                    if (Unk_51_raw == value) return;
                    Unk_51_raw = value;
                    OnPropertyChanged(nameof(Unk_51));
                }
            }

            protected float Entity_Collide_1_raw;
            public const string Entity_Collide_1_displayName = "Entity: Collide 1";
            public const int Entity_Collide_1_sortIndex = 4800;
            [SortOrder(Entity_Collide_1_sortIndex)]
            [DisplayName(Entity_Collide_1_displayName)]
            public virtual float Entity_Collide_1 {
                get => Entity_Collide_1_raw;
                set {
                    if (Entity_Collide_1_raw == value) return;
                    Entity_Collide_1_raw = value;
                    OnPropertyChanged(nameof(Entity_Collide_1));
                }
            }

            protected float Unk_52_raw;
            public const string Unk_52_displayName = "Unk 52";
            public const int Unk_52_sortIndex = 4850;
            [SortOrder(Unk_52_sortIndex)]
            [DisplayName(Unk_52_displayName)]
            public virtual float Unk_52 {
                get => Unk_52_raw;
                set {
                    if (Unk_52_raw == value) return;
                    Unk_52_raw = value;
                    OnPropertyChanged(nameof(Unk_52));
                }
            }

            protected float Unk_53_raw;
            public const string Unk_53_displayName = "Unk 53";
            public const int Unk_53_sortIndex = 4900;
            [SortOrder(Unk_53_sortIndex)]
            [DisplayName(Unk_53_displayName)]
            public virtual float Unk_53 {
                get => Unk_53_raw;
                set {
                    if (Unk_53_raw == value) return;
                    Unk_53_raw = value;
                    OnPropertyChanged(nameof(Unk_53));
                }
            }

            protected byte Entity_Collide_2_raw;
            public const string Entity_Collide_2_displayName = "Entity: Collide 2";
            public const int Entity_Collide_2_sortIndex = 4950;
            [SortOrder(Entity_Collide_2_sortIndex)]
            [DisplayName(Entity_Collide_2_displayName)]
            public virtual byte Entity_Collide_2 {
                get => Entity_Collide_2_raw;
                set {
                    if (Entity_Collide_2_raw == value) return;
                    Entity_Collide_2_raw = value;
                    OnPropertyChanged(nameof(Entity_Collide_2));
                }
            }

            protected byte Unk_54_raw;
            public const string Unk_54_displayName = "Unk 54";
            public const int Unk_54_sortIndex = 5000;
            [SortOrder(Unk_54_sortIndex)]
            [DisplayName(Unk_54_displayName)]
            public virtual byte Unk_54 {
                get => Unk_54_raw;
                set {
                    if (Unk_54_raw == value) return;
                    Unk_54_raw = value;
                    OnPropertyChanged(nameof(Unk_54));
                }
            }

            protected byte Entity_Spawn_Location_raw;
            public const string Entity_Spawn_Location_displayName = "Entity: Spawn Location";
            public const int Entity_Spawn_Location_sortIndex = 5050;
            [SortOrder(Entity_Spawn_Location_sortIndex)]
            [DisplayName(Entity_Spawn_Location_displayName)]
            public virtual byte Entity_Spawn_Location {
                get => Entity_Spawn_Location_raw;
                set {
                    if (Entity_Spawn_Location_raw == value) return;
                    Entity_Spawn_Location_raw = value;
                    OnPropertyChanged(nameof(Entity_Spawn_Location));
                }
            }

            protected byte Entity_Range_raw;
            public const string Entity_Range_displayName = "Entity: Range";
            public const int Entity_Range_sortIndex = 5100;
            [SortOrder(Entity_Range_sortIndex)]
            [DisplayName(Entity_Range_displayName)]
            public virtual byte Entity_Range {
                get => Entity_Range_raw;
                set {
                    if (Entity_Range_raw == value) return;
                    Entity_Range_raw = value;
                    OnPropertyChanged(nameof(Entity_Range));
                }
            }

            protected byte Unk_55_raw;
            public const string Unk_55_displayName = "Unk 55";
            public const int Unk_55_sortIndex = 5150;
            [SortOrder(Unk_55_sortIndex)]
            [DisplayName(Unk_55_displayName)]
            public virtual byte Unk_55 {
                get => Unk_55_raw;
                set {
                    if (Unk_55_raw == value) return;
                    Unk_55_raw = value;
                    OnPropertyChanged(nameof(Unk_55));
                }
            }

            protected byte Unk_56_raw;
            public const string Unk_56_displayName = "Unk 56";
            public const int Unk_56_sortIndex = 5200;
            [SortOrder(Unk_56_sortIndex)]
            [DisplayName(Unk_56_displayName)]
            public virtual byte Unk_56 {
                get => Unk_56_raw;
                set {
                    if (Unk_56_raw == value) return;
                    Unk_56_raw = value;
                    OnPropertyChanged(nameof(Unk_56));
                }
            }

            protected ushort Unk_57_raw;
            public const string Unk_57_displayName = "Unk 57";
            public const int Unk_57_sortIndex = 5250;
            [SortOrder(Unk_57_sortIndex)]
            [DisplayName(Unk_57_displayName)]
            public virtual ushort Unk_57 {
                get => Unk_57_raw;
                set {
                    if (Unk_57_raw == value) return;
                    Unk_57_raw = value;
                    OnPropertyChanged(nameof(Unk_57));
                }
            }

            protected uint Unk_58_raw;
            public const string Unk_58_displayName = "Unk 58";
            public const int Unk_58_sortIndex = 5300;
            [SortOrder(Unk_58_sortIndex)]
            [DisplayName(Unk_58_displayName)]
            public virtual uint Unk_58 {
                get => Unk_58_raw;
                set {
                    if (Unk_58_raw == value) return;
                    Unk_58_raw = value;
                    OnPropertyChanged(nameof(Unk_58));
                }
            }

            public static Shlp_2_ LoadData(BinaryReader reader) {
                var data = new Shlp_2_();
                data.Ground_Decal_EPV_VFX_Group_Id_raw = reader.ReadUInt32();
                data.Ground_Decal_EPV_VFX_Effect_Index_raw = reader.ReadUInt32();
                data.Wall_Decal_EPV_VFX_Group_Id_raw = reader.ReadUInt32();
                data.Wall_Decal_EPV_VFX_Effect_Index_raw = reader.ReadUInt32();
                data.Unk_1_raw = reader.ReadUInt32();
                data.Unk_2_raw = reader.ReadUInt32();
                data.Obj_Hit_VFX_Group_Id_raw = reader.ReadUInt32();
                data.Obj_Hit_VFX_Effect_Index_raw = reader.ReadUInt32();
                data.Unk_3_raw = reader.ReadByte();
                data.Unk_4_raw = reader.ReadByte();
                data.Unk_5_raw = reader.ReadByte();
                data.Unk_6_raw = reader.ReadByte();
                data.Unk_7_raw = reader.ReadByte();
                data.Unk_8_raw = reader.ReadByte();
                data.Unk_9_raw = reader.ReadByte();
                data.Unk_10_raw = reader.ReadByte();
                data.Unk_11_raw = reader.ReadByte();
                data.Unk_12_raw = reader.ReadByte();
                data.Unk_13_raw = reader.ReadByte();
                data.Unk_14_raw = reader.ReadByte();
                data.Unk_15_raw = reader.ReadUInt32();
                data.Unk_16_raw = reader.ReadUInt32();
                data.Unk_17_raw = reader.ReadUInt32();
                data.Unk_18_raw = reader.ReadByte();
                data.Unk_19_raw = reader.ReadUInt32();
                data.Unk_20_raw = reader.ReadUInt32();
                data.Unk_21_raw = reader.ReadByte();
                data.Unk_22_raw = reader.ReadInt32();
                data.Unk_23_raw = reader.ReadUInt32();
                data.Unk_24_raw = reader.ReadUInt32();
                data.Unk_25_raw = reader.ReadUInt32();
                data.Unk_26_raw = reader.ReadUInt32();
                data.Gun_Fire_EPV_VFX_Group_Id_raw = reader.ReadUInt32();
                data.Gun_Fire_EPV_VFX_Effect_Index_raw = reader.ReadUInt32();
                data.Unk_27_raw = reader.ReadUInt32();
                data.Unk_28_raw = reader.ReadUInt32();
                data.Unk_29_raw = reader.ReadUInt32();
                data.Unk_30_raw = reader.ReadUInt32();
                data.Unk_31_raw = reader.ReadUInt32();
                data.Unk_32_raw = reader.ReadUInt32();
                data.Unk_33_raw = reader.ReadUInt32();
                data.Unk_34_raw = reader.ReadUInt32();
                data.Wwise_Container_Header_raw = reader.ReadUInt32();
                if (data.Wwise_Container_Header_raw != 0) data.Wwise_Container_raw = reader.ReadNullTermString();
                data.Sound_Gun_Fire_Header_raw = reader.ReadInt32();
                data.Sound_Gun_Fire_raw = reader.ReadInt32();
                data.Sound_Bullet_Travel_Header_raw = reader.ReadInt32();
                data.Sound_Bullet_Travel_raw = reader.ReadInt32();
                data.Sound_Explode_Header_raw = reader.ReadInt32();
                data.Sound_Explode_raw = reader.ReadInt32();
                data.Sound_Hit_Wall_or_Ground_Header_raw = reader.ReadInt32();
                data.Sound_Hit_Wall_or_Ground_raw = reader.ReadInt32();
                data.Sound_Hit_Obj_Hit_Header_raw = reader.ReadInt32();
                data.Sound_Hit_Obj_Hit_raw = reader.ReadInt32();
                data.Sound_Condition_Header_1_raw = reader.ReadInt32();
                data.Sound_Condition_1_raw = reader.ReadInt32();
                data.Sound_Slinger_Condition_Header_1_raw = reader.ReadInt32();
                data.Sound_Slinger_Condition_1_raw = reader.ReadInt32();
                data.Sound_Slinger_Condition_Header_2_raw = reader.ReadInt32();
                data.Sound_Slinger_Condition_2_raw = reader.ReadInt32();
                data.Sound_Condition_Header_2_raw = reader.ReadInt32();
                data.Sound_Condition_2_raw = reader.ReadInt32();
                data.Sound_Condition_Header_3_raw = reader.ReadInt32();
                data.Sound_Condition_3_raw = reader.ReadInt32();
                data.Sound_Condition_Header_4_raw = reader.ReadInt32();
                data.Sound_Condition_4_raw = reader.ReadInt32();
                data.Sound_Condition_Header_5_raw = reader.ReadInt32();
                data.Sound_Condition_5_raw = reader.ReadInt32();
                data.Header_raw = reader.ReadUInt32();
                data.Projectile_Entity_Collider_raw = reader.ReadUInt32();
                data.Projectile_Model_Lifespan_raw = reader.ReadSingle();
                data.Projectile_Distance_Range_raw = reader.ReadUInt32();
                data.Unk_35_raw = reader.ReadByte();
                data.Unk_36_raw = reader.ReadByte();
                data.Unk_37_raw = reader.ReadByte();
                data.Unk_38_raw = reader.ReadByte();
                data.Unk_39_raw = reader.ReadUInt32();
                data.Unk_40_raw = reader.ReadUInt32();
                data.Unk_41_raw = reader.ReadUInt32();
                data.Projectile_Spawn_Pos_Y_raw = reader.ReadSingle();
                data.Projectile_Spawn_Pos_X_raw = reader.ReadSingle();
                data.Projectile_Velocity_raw = reader.ReadSingle();
                data.Projectile_Falloff_raw = reader.ReadSingle();
                data.Unk_42_raw = reader.ReadSingle();
                data.Unk_43_raw = reader.ReadSingle();
                data.Unk_44_raw = reader.ReadSingle();
                data.Unk_45_raw = reader.ReadSingle();
                data.Unk_46_raw = reader.ReadSingle();
                data.Unk_47_raw = reader.ReadSingle();
                data.Unk_48_raw = reader.ReadSingle();
                data.Projectile_Hitbox_Range_raw = reader.ReadSingle();
                data.Unk_49_raw = reader.ReadUInt32();
                data.Insta_Kill_Trigger_raw = reader.ReadUInt32();
                data.Unk_50_raw = reader.ReadUInt32();
                data.Unk_51_raw = reader.ReadUInt16();
                data.Entity_Collide_1_raw = reader.ReadSingle();
                data.Unk_52_raw = reader.ReadSingle();
                data.Unk_53_raw = reader.ReadSingle();
                data.Entity_Collide_2_raw = reader.ReadByte();
                data.Unk_54_raw = reader.ReadByte();
                data.Entity_Spawn_Location_raw = reader.ReadByte();
                data.Entity_Range_raw = reader.ReadByte();
                data.Unk_55_raw = reader.ReadByte();
                data.Unk_56_raw = reader.ReadByte();
                data.Unk_57_raw = reader.ReadUInt16();
                data.Unk_58_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Ground_Decal_EPV_VFX_Group_Id_raw);
                writer.Write(Ground_Decal_EPV_VFX_Effect_Index_raw);
                writer.Write(Wall_Decal_EPV_VFX_Group_Id_raw);
                writer.Write(Wall_Decal_EPV_VFX_Effect_Index_raw);
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Obj_Hit_VFX_Group_Id_raw);
                writer.Write(Obj_Hit_VFX_Effect_Index_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
                writer.Write(Unk_6_raw);
                writer.Write(Unk_7_raw);
                writer.Write(Unk_8_raw);
                writer.Write(Unk_9_raw);
                writer.Write(Unk_10_raw);
                writer.Write(Unk_11_raw);
                writer.Write(Unk_12_raw);
                writer.Write(Unk_13_raw);
                writer.Write(Unk_14_raw);
                writer.Write(Unk_15_raw);
                writer.Write(Unk_16_raw);
                writer.Write(Unk_17_raw);
                writer.Write(Unk_18_raw);
                writer.Write(Unk_19_raw);
                writer.Write(Unk_20_raw);
                writer.Write(Unk_21_raw);
                writer.Write(Unk_22_raw);
                writer.Write(Unk_23_raw);
                writer.Write(Unk_24_raw);
                writer.Write(Unk_25_raw);
                writer.Write(Unk_26_raw);
                writer.Write(Gun_Fire_EPV_VFX_Group_Id_raw);
                writer.Write(Gun_Fire_EPV_VFX_Effect_Index_raw);
                writer.Write(Unk_27_raw);
                writer.Write(Unk_28_raw);
                writer.Write(Unk_29_raw);
                writer.Write(Unk_30_raw);
                writer.Write(Unk_31_raw);
                writer.Write(Unk_32_raw);
                writer.Write(Unk_33_raw);
                writer.Write(Unk_34_raw);
                writer.Write(Wwise_Container_Header_raw);
                if (Wwise_Container_Header_raw != 0) writer.Write(Wwise_Container_raw.ToNullTermCharArray());
                writer.Write(Sound_Gun_Fire_Header_raw);
                writer.Write(Sound_Gun_Fire_raw);
                writer.Write(Sound_Bullet_Travel_Header_raw);
                writer.Write(Sound_Bullet_Travel_raw);
                writer.Write(Sound_Explode_Header_raw);
                writer.Write(Sound_Explode_raw);
                writer.Write(Sound_Hit_Wall_or_Ground_Header_raw);
                writer.Write(Sound_Hit_Wall_or_Ground_raw);
                writer.Write(Sound_Hit_Obj_Hit_Header_raw);
                writer.Write(Sound_Hit_Obj_Hit_raw);
                writer.Write(Sound_Condition_Header_1_raw);
                writer.Write(Sound_Condition_1_raw);
                writer.Write(Sound_Slinger_Condition_Header_1_raw);
                writer.Write(Sound_Slinger_Condition_1_raw);
                writer.Write(Sound_Slinger_Condition_Header_2_raw);
                writer.Write(Sound_Slinger_Condition_2_raw);
                writer.Write(Sound_Condition_Header_2_raw);
                writer.Write(Sound_Condition_2_raw);
                writer.Write(Sound_Condition_Header_3_raw);
                writer.Write(Sound_Condition_3_raw);
                writer.Write(Sound_Condition_Header_4_raw);
                writer.Write(Sound_Condition_4_raw);
                writer.Write(Sound_Condition_Header_5_raw);
                writer.Write(Sound_Condition_5_raw);
                writer.Write(Header_raw);
                writer.Write(Projectile_Entity_Collider_raw);
                writer.Write(Projectile_Model_Lifespan_raw);
                writer.Write(Projectile_Distance_Range_raw);
                writer.Write(Unk_35_raw);
                writer.Write(Unk_36_raw);
                writer.Write(Unk_37_raw);
                writer.Write(Unk_38_raw);
                writer.Write(Unk_39_raw);
                writer.Write(Unk_40_raw);
                writer.Write(Unk_41_raw);
                writer.Write(Projectile_Spawn_Pos_Y_raw);
                writer.Write(Projectile_Spawn_Pos_X_raw);
                writer.Write(Projectile_Velocity_raw);
                writer.Write(Projectile_Falloff_raw);
                writer.Write(Unk_42_raw);
                writer.Write(Unk_43_raw);
                writer.Write(Unk_44_raw);
                writer.Write(Unk_45_raw);
                writer.Write(Unk_46_raw);
                writer.Write(Unk_47_raw);
                writer.Write(Unk_48_raw);
                writer.Write(Projectile_Hitbox_Range_raw);
                writer.Write(Unk_49_raw);
                writer.Write(Insta_Kill_Trigger_raw);
                writer.Write(Unk_50_raw);
                writer.Write(Unk_51_raw);
                writer.Write(Entity_Collide_1_raw);
                writer.Write(Unk_52_raw);
                writer.Write(Unk_53_raw);
                writer.Write(Entity_Collide_2_raw);
                writer.Write(Unk_54_raw);
                writer.Write(Entity_Spawn_Location_raw);
                writer.Write(Entity_Range_raw);
                writer.Write(Unk_55_raw);
                writer.Write(Unk_56_raw);
                writer.Write(Unk_57_raw);
                writer.Write(Unk_58_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Ground Decal: EPV_VFX_Group Id", "Ground_Decal_EPV_VFX_Group_Id"),
                    new MultiStructItemCustomView(this, "Ground Decal: EPV VFX Effect Index", "Ground_Decal_EPV_VFX_Effect_Index"),
                    new MultiStructItemCustomView(this, "Wall Decal: EPV VFX Group Id", "Wall_Decal_EPV_VFX_Group_Id"),
                    new MultiStructItemCustomView(this, "Wall Decal: EPV VFX Effect Index", "Wall_Decal_EPV_VFX_Effect_Index"),
                    new MultiStructItemCustomView(this, "Unk 1", "Unk_1"),
                    new MultiStructItemCustomView(this, "Unk 2", "Unk_2"),
                    new MultiStructItemCustomView(this, "Obj Hit: VFX Group Id", "Obj_Hit_VFX_Group_Id"),
                    new MultiStructItemCustomView(this, "Obj Hit: VFX Effect Index", "Obj_Hit_VFX_Effect_Index"),
                    new MultiStructItemCustomView(this, "Unk 3", "Unk_3"),
                    new MultiStructItemCustomView(this, "Unk 4", "Unk_4"),
                    new MultiStructItemCustomView(this, "Unk 5", "Unk_5"),
                    new MultiStructItemCustomView(this, "Unk 6", "Unk_6"),
                    new MultiStructItemCustomView(this, "Unk 7", "Unk_7"),
                    new MultiStructItemCustomView(this, "Unk 8", "Unk_8"),
                    new MultiStructItemCustomView(this, "Unk 9", "Unk_9"),
                    new MultiStructItemCustomView(this, "Unk 10", "Unk_10"),
                    new MultiStructItemCustomView(this, "Unk 11", "Unk_11"),
                    new MultiStructItemCustomView(this, "Unk 12", "Unk_12"),
                    new MultiStructItemCustomView(this, "Unk 13", "Unk_13"),
                    new MultiStructItemCustomView(this, "Unk 14", "Unk_14"),
                    new MultiStructItemCustomView(this, "Unk 15", "Unk_15"),
                    new MultiStructItemCustomView(this, "Unk 16", "Unk_16"),
                    new MultiStructItemCustomView(this, "Unk 17", "Unk_17"),
                    new MultiStructItemCustomView(this, "Unk 18", "Unk_18"),
                    new MultiStructItemCustomView(this, "Unk 19", "Unk_19"),
                    new MultiStructItemCustomView(this, "Unk 20", "Unk_20"),
                    new MultiStructItemCustomView(this, "Unk 21", "Unk_21"),
                    new MultiStructItemCustomView(this, "Unk 22", "Unk_22"),
                    new MultiStructItemCustomView(this, "Unk 23", "Unk_23"),
                    new MultiStructItemCustomView(this, "Unk 24", "Unk_24"),
                    new MultiStructItemCustomView(this, "Unk 25", "Unk_25"),
                    new MultiStructItemCustomView(this, "Unk 26", "Unk_26"),
                    new MultiStructItemCustomView(this, "Gun Fire: EPV VFX Group Id", "Gun_Fire_EPV_VFX_Group_Id"),
                    new MultiStructItemCustomView(this, "Gun Fire: EPV VFX Effect Index", "Gun_Fire_EPV_VFX_Effect_Index"),
                    new MultiStructItemCustomView(this, "Unk 27", "Unk_27"),
                    new MultiStructItemCustomView(this, "Unk 28", "Unk_28"),
                    new MultiStructItemCustomView(this, "Unk 29", "Unk_29"),
                    new MultiStructItemCustomView(this, "Unk 30", "Unk_30"),
                    new MultiStructItemCustomView(this, "Unk 31", "Unk_31"),
                    new MultiStructItemCustomView(this, "Unk 32", "Unk_32"),
                    new MultiStructItemCustomView(this, "Unk 33", "Unk_33"),
                    new MultiStructItemCustomView(this, "Unk 34", "Unk_34"),
                    new MultiStructItemCustomView(this, "Wwise Container Header", "Wwise_Container_Header"),
                    new MultiStructItemCustomView(this, "Wwise Container", "Wwise_Container"),
                    new MultiStructItemCustomView(this, "Sound: Gun Fire Header", "Sound_Gun_Fire_Header"),
                    new MultiStructItemCustomView(this, "Sound: Gun Fire", "Sound_Gun_Fire"),
                    new MultiStructItemCustomView(this, "Sound: Bullet Travel Header", "Sound_Bullet_Travel_Header"),
                    new MultiStructItemCustomView(this, "Sound: Bullet Travel", "Sound_Bullet_Travel"),
                    new MultiStructItemCustomView(this, "Sound: Explode Header", "Sound_Explode_Header"),
                    new MultiStructItemCustomView(this, "Sound: Explode", "Sound_Explode"),
                    new MultiStructItemCustomView(this, "Sound: Hit Wall or Ground Header", "Sound_Hit_Wall_or_Ground_Header"),
                    new MultiStructItemCustomView(this, "Sound: Hit Wall or Ground", "Sound_Hit_Wall_or_Ground"),
                    new MultiStructItemCustomView(this, "Sound: Hit Obj Hit Header", "Sound_Hit_Obj_Hit_Header"),
                    new MultiStructItemCustomView(this, "Sound: Hit Obj Hit", "Sound_Hit_Obj_Hit"),
                    new MultiStructItemCustomView(this, "Sound: Condition Header 1", "Sound_Condition_Header_1"),
                    new MultiStructItemCustomView(this, "Sound: Condition 1", "Sound_Condition_1"),
                    new MultiStructItemCustomView(this, "Sound: Slinger Condition Header 1", "Sound_Slinger_Condition_Header_1"),
                    new MultiStructItemCustomView(this, "Sound: Slinger Condition 1", "Sound_Slinger_Condition_1"),
                    new MultiStructItemCustomView(this, "Sound: Slinger Condition Header 2", "Sound_Slinger_Condition_Header_2"),
                    new MultiStructItemCustomView(this, "Sound: Slinger Condition 2", "Sound_Slinger_Condition_2"),
                    new MultiStructItemCustomView(this, "Sound: Condition Header 2", "Sound_Condition_Header_2"),
                    new MultiStructItemCustomView(this, "Sound: Condition 2", "Sound_Condition_2"),
                    new MultiStructItemCustomView(this, "Sound: Condition Header 3", "Sound_Condition_Header_3"),
                    new MultiStructItemCustomView(this, "Sound: Condition 3", "Sound_Condition_3"),
                    new MultiStructItemCustomView(this, "Sound: Condition Header 4", "Sound_Condition_Header_4"),
                    new MultiStructItemCustomView(this, "Sound: Condition 4", "Sound_Condition_4"),
                    new MultiStructItemCustomView(this, "Sound: Condition Header 5", "Sound_Condition_Header_5"),
                    new MultiStructItemCustomView(this, "Sound: Condition 5", "Sound_Condition_5"),
                    new MultiStructItemCustomView(this, "Header", "Header"),
                    new MultiStructItemCustomView(this, "Projectile: Entity Collider", "Projectile_Entity_Collider"),
                    new MultiStructItemCustomView(this, "Projectile: Model Lifespan", "Projectile_Model_Lifespan"),
                    new MultiStructItemCustomView(this, "Projectile: Distance Range", "Projectile_Distance_Range"),
                    new MultiStructItemCustomView(this, "Unk 35", "Unk_35"),
                    new MultiStructItemCustomView(this, "Unk 36", "Unk_36"),
                    new MultiStructItemCustomView(this, "Unk 37", "Unk_37"),
                    new MultiStructItemCustomView(this, "Unk 38", "Unk_38"),
                    new MultiStructItemCustomView(this, "Unk 39", "Unk_39"),
                    new MultiStructItemCustomView(this, "Unk 40", "Unk_40"),
                    new MultiStructItemCustomView(this, "Unk 41", "Unk_41"),
                    new MultiStructItemCustomView(this, "Projectile: Spawn Pos Y", "Projectile_Spawn_Pos_Y"),
                    new MultiStructItemCustomView(this, "Projectile: Spawn Pos X", "Projectile_Spawn_Pos_X"),
                    new MultiStructItemCustomView(this, "Projectile: Velocity", "Projectile_Velocity"),
                    new MultiStructItemCustomView(this, "Projectile: Falloff", "Projectile_Falloff"),
                    new MultiStructItemCustomView(this, "Unk 42", "Unk_42"),
                    new MultiStructItemCustomView(this, "Unk 43", "Unk_43"),
                    new MultiStructItemCustomView(this, "Unk 44", "Unk_44"),
                    new MultiStructItemCustomView(this, "Unk 45", "Unk_45"),
                    new MultiStructItemCustomView(this, "Unk 46", "Unk_46"),
                    new MultiStructItemCustomView(this, "Unk 47", "Unk_47"),
                    new MultiStructItemCustomView(this, "Unk 48", "Unk_48"),
                    new MultiStructItemCustomView(this, "Projectile: Hitbox Range", "Projectile_Hitbox_Range"),
                    new MultiStructItemCustomView(this, "Unk 49", "Unk_49"),
                    new MultiStructItemCustomView(this, "Insta-Kill Trigger", "Insta_Kill_Trigger"),
                    new MultiStructItemCustomView(this, "Unk 50", "Unk_50"),
                    new MultiStructItemCustomView(this, "Unk 51", "Unk_51"),
                    new MultiStructItemCustomView(this, "Entity: Collide 1", "Entity_Collide_1"),
                    new MultiStructItemCustomView(this, "Unk 52", "Unk_52"),
                    new MultiStructItemCustomView(this, "Unk 53", "Unk_53"),
                    new MultiStructItemCustomView(this, "Entity: Collide 2", "Entity_Collide_2"),
                    new MultiStructItemCustomView(this, "Unk 54", "Unk_54"),
                    new MultiStructItemCustomView(this, "Entity: Spawn Location", "Entity_Spawn_Location"),
                    new MultiStructItemCustomView(this, "Entity: Range", "Entity_Range"),
                    new MultiStructItemCustomView(this, "Unk 55", "Unk_55"),
                    new MultiStructItemCustomView(this, "Unk 56", "Unk_56"),
                    new MultiStructItemCustomView(this, "Unk 57", "Unk_57"),
                    new MultiStructItemCustomView(this, "Unk 58", "Unk_58"),
                };
            }
        }

        public partial class Number_of_Modifiers_Holder : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Number of Modifiers Holder";
            public const bool IsHidden = true;

            protected uint Number_of_Modifiers_raw;
            public const string Number_of_Modifiers_displayName = "Number of Modifiers";
            public const int Number_of_Modifiers_sortIndex = 50;
            [SortOrder(Number_of_Modifiers_sortIndex)]
            [DisplayName(Number_of_Modifiers_displayName)]
            [IsReadOnly]
            public virtual uint Number_of_Modifiers {
                get => Number_of_Modifiers_raw;
                set {
                    if (Number_of_Modifiers_raw == value) return;
                    Number_of_Modifiers_raw = value;
                    OnPropertyChanged(nameof(Number_of_Modifiers));
                }
            }

            public static Number_of_Modifiers_Holder LoadData(BinaryReader reader) {
                var data = new Number_of_Modifiers_Holder();
                data.Number_of_Modifiers_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Number_of_Modifiers_raw);
            }
        }

        public partial class Modifiers : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Modifiers";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected uint Header_raw;
            public const string Header_displayName = "Header";
            public const int Header_sortIndex = 50;
            [SortOrder(Header_sortIndex)]
            [DisplayName(Header_displayName)]
            public virtual uint Header {
                get => Header_raw;
                set {
                    if (Header_raw == value) return;
                    Header_raw = value;
                    OnPropertyChanged(nameof(Header));
                }
            }

            protected sbyte Value_1_if_412627386__raw;
            public const string Value_1_if_412627386__displayName = "Value 1 (if 412627386)";
            public const int Value_1_if_412627386__sortIndex = 100;
            [SortOrder(Value_1_if_412627386__sortIndex)]
            [DisplayName(Value_1_if_412627386__displayName)]
            public virtual sbyte Value_1_if_412627386_ {
                get => Value_1_if_412627386__raw;
                set {
                    if (Value_1_if_412627386__raw == value) return;
                    Value_1_if_412627386__raw = value;
                    OnPropertyChanged(nameof(Value_1_if_412627386_));
                }
            }

            protected sbyte Value_2_if_412627386__raw;
            public const string Value_2_if_412627386__displayName = "Value 2 (if 412627386)";
            public const int Value_2_if_412627386__sortIndex = 150;
            [SortOrder(Value_2_if_412627386__sortIndex)]
            [DisplayName(Value_2_if_412627386__displayName)]
            public virtual sbyte Value_2_if_412627386_ {
                get => Value_2_if_412627386__raw;
                set {
                    if (Value_2_if_412627386__raw == value) return;
                    Value_2_if_412627386__raw = value;
                    OnPropertyChanged(nameof(Value_2_if_412627386_));
                }
            }

            protected sbyte Value_3_if_412627386__raw;
            public const string Value_3_if_412627386__displayName = "Value 3 (if 412627386)";
            public const int Value_3_if_412627386__sortIndex = 200;
            [SortOrder(Value_3_if_412627386__sortIndex)]
            [DisplayName(Value_3_if_412627386__displayName)]
            public virtual sbyte Value_3_if_412627386_ {
                get => Value_3_if_412627386__raw;
                set {
                    if (Value_3_if_412627386__raw == value) return;
                    Value_3_if_412627386__raw = value;
                    OnPropertyChanged(nameof(Value_3_if_412627386_));
                }
            }

            protected sbyte Value_4_if_412627386__raw;
            public const string Value_4_if_412627386__displayName = "Value 4 (if 412627386)";
            public const int Value_4_if_412627386__sortIndex = 250;
            [SortOrder(Value_4_if_412627386__sortIndex)]
            [DisplayName(Value_4_if_412627386__displayName)]
            public virtual sbyte Value_4_if_412627386_ {
                get => Value_4_if_412627386__raw;
                set {
                    if (Value_4_if_412627386__raw == value) return;
                    Value_4_if_412627386__raw = value;
                    OnPropertyChanged(nameof(Value_4_if_412627386_));
                }
            }

            protected int Value_if_3289971__raw;
            public const string Value_if_3289971__displayName = "Value (if 3289971)";
            public const int Value_if_3289971__sortIndex = 300;
            [SortOrder(Value_if_3289971__sortIndex)]
            [DisplayName(Value_if_3289971__displayName)]
            public virtual int Value_if_3289971_ {
                get => Value_if_3289971__raw;
                set {
                    if (Value_if_3289971__raw == value) return;
                    Value_if_3289971__raw = value;
                    OnPropertyChanged(nameof(Value_if_3289971_));
                }
            }

            protected float Value_if_79120377__raw;
            public const string Value_if_79120377__displayName = "Value (if 79120377)";
            public const int Value_if_79120377__sortIndex = 350;
            [SortOrder(Value_if_79120377__sortIndex)]
            [DisplayName(Value_if_79120377__displayName)]
            public virtual float Value_if_79120377_ {
                get => Value_if_79120377__raw;
                set {
                    if (Value_if_79120377__raw == value) return;
                    Value_if_79120377__raw = value;
                    OnPropertyChanged(nameof(Value_if_79120377_));
                }
            }

            protected sbyte Value_if_306780182__raw;
            public const string Value_if_306780182__displayName = "Value (if 306780182)";
            public const int Value_if_306780182__sortIndex = 400;
            [SortOrder(Value_if_306780182__sortIndex)]
            [DisplayName(Value_if_306780182__displayName)]
            public virtual sbyte Value_if_306780182_ {
                get => Value_if_306780182__raw;
                set {
                    if (Value_if_306780182__raw == value) return;
                    Value_if_306780182__raw = value;
                    OnPropertyChanged(nameof(Value_if_306780182_));
                }
            }

            protected float Value_X_if_1335056316__raw;
            public const string Value_X_if_1335056316__displayName = "Value X (if 1335056316)";
            public const int Value_X_if_1335056316__sortIndex = 450;
            [SortOrder(Value_X_if_1335056316__sortIndex)]
            [DisplayName(Value_X_if_1335056316__displayName)]
            public virtual float Value_X_if_1335056316_ {
                get => Value_X_if_1335056316__raw;
                set {
                    if (Value_X_if_1335056316__raw == value) return;
                    Value_X_if_1335056316__raw = value;
                    OnPropertyChanged(nameof(Value_X_if_1335056316_));
                }
            }

            protected float Value_Y_if_1335056316__raw;
            public const string Value_Y_if_1335056316__displayName = "Value Y (if 1335056316)";
            public const int Value_Y_if_1335056316__sortIndex = 500;
            [SortOrder(Value_Y_if_1335056316__sortIndex)]
            [DisplayName(Value_Y_if_1335056316__displayName)]
            public virtual float Value_Y_if_1335056316_ {
                get => Value_Y_if_1335056316__raw;
                set {
                    if (Value_Y_if_1335056316__raw == value) return;
                    Value_Y_if_1335056316__raw = value;
                    OnPropertyChanged(nameof(Value_Y_if_1335056316_));
                }
            }

            protected float Value_Z_if_1335056316__raw;
            public const string Value_Z_if_1335056316__displayName = "Value Z (if 1335056316)";
            public const int Value_Z_if_1335056316__sortIndex = 550;
            [SortOrder(Value_Z_if_1335056316__sortIndex)]
            [DisplayName(Value_Z_if_1335056316__displayName)]
            public virtual float Value_Z_if_1335056316_ {
                get => Value_Z_if_1335056316__raw;
                set {
                    if (Value_Z_if_1335056316__raw == value) return;
                    Value_Z_if_1335056316__raw = value;
                    OnPropertyChanged(nameof(Value_Z_if_1335056316_));
                }
            }

            protected float Value_Unk_if_1335056316__raw;
            public const string Value_Unk_if_1335056316__displayName = "Value Unk (if 1335056316)";
            public const int Value_Unk_if_1335056316__sortIndex = 600;
            [SortOrder(Value_Unk_if_1335056316__sortIndex)]
            [DisplayName(Value_Unk_if_1335056316__displayName)]
            public virtual float Value_Unk_if_1335056316_ {
                get => Value_Unk_if_1335056316__raw;
                set {
                    if (Value_Unk_if_1335056316__raw == value) return;
                    Value_Unk_if_1335056316__raw = value;
                    OnPropertyChanged(nameof(Value_Unk_if_1335056316_));
                }
            }

            protected string Name_raw;
            public const string Name_displayName = "Name";
            public const int Name_sortIndex = 650;
            [SortOrder(Name_sortIndex)]
            [DisplayName(Name_displayName)]
            public virtual string Name {
                get => Name_raw;
                set {
                    if (Name_raw == value) return;
                    Name_raw = value;
                    OnPropertyChanged(nameof(Name));
                }
            }

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 700;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual uint Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected string DataType_raw;
            public const string DataType_displayName = "DataType";
            public const int DataType_sortIndex = 750;
            [SortOrder(DataType_sortIndex)]
            [DisplayName(DataType_displayName)]
            public virtual string DataType {
                get => DataType_raw;
                set {
                    if (DataType_raw == value) return;
                    DataType_raw = value;
                    OnPropertyChanged(nameof(DataType));
                }
            }

            protected uint Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 800;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual uint Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected uint Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 850;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual uint Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected uint Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 900;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual uint Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected byte Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 950;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual byte Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            public static Modifiers LoadData(BinaryReader reader) {
                var data = new Modifiers();
                data.Header_raw = reader.ReadUInt32();
                if (data.Header_raw == 412627386) data.Value_1_if_412627386__raw = reader.ReadSByte();
                if (data.Header_raw == 412627386) data.Value_2_if_412627386__raw = reader.ReadSByte();
                if (data.Header_raw == 412627386) data.Value_3_if_412627386__raw = reader.ReadSByte();
                if (data.Header_raw == 412627386) data.Value_4_if_412627386__raw = reader.ReadSByte();
                if (data.Header_raw == 3289971) data.Value_if_3289971__raw = reader.ReadInt32();
                if (data.Header_raw == 79120377) data.Value_if_79120377__raw = reader.ReadSingle();
                if (data.Header_raw == 306780182) data.Value_if_306780182__raw = reader.ReadSByte();
                if (data.Header_raw == 1335056316) data.Value_X_if_1335056316__raw = reader.ReadSingle();
                if (data.Header_raw == 1335056316) data.Value_Y_if_1335056316__raw = reader.ReadSingle();
                if (data.Header_raw == 1335056316) data.Value_Z_if_1335056316__raw = reader.ReadSingle();
                if (data.Header_raw == 1335056316) data.Value_Unk_if_1335056316__raw = reader.ReadSingle();
                data.Name_raw = reader.ReadNullTermString();
                data.Unk_1_raw = reader.ReadUInt32();
                data.DataType_raw = reader.ReadNullTermString();
                data.Unk_2_raw = reader.ReadUInt32();
                data.Unk_3_raw = reader.ReadUInt32();
                data.Unk_4_raw = reader.ReadUInt32();
                data.Unk_5_raw = reader.ReadByte();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Header_raw);
                if (Header_raw == 412627386) writer.Write(Value_1_if_412627386__raw);
                if (Header_raw == 412627386) writer.Write(Value_2_if_412627386__raw);
                if (Header_raw == 412627386) writer.Write(Value_3_if_412627386__raw);
                if (Header_raw == 412627386) writer.Write(Value_4_if_412627386__raw);
                if (Header_raw == 3289971) writer.Write(Value_if_3289971__raw);
                if (Header_raw == 79120377) writer.Write(Value_if_79120377__raw);
                if (Header_raw == 306780182) writer.Write(Value_if_306780182__raw);
                if (Header_raw == 1335056316) writer.Write(Value_X_if_1335056316__raw);
                if (Header_raw == 1335056316) writer.Write(Value_Y_if_1335056316__raw);
                if (Header_raw == 1335056316) writer.Write(Value_Z_if_1335056316__raw);
                if (Header_raw == 1335056316) writer.Write(Value_Unk_if_1335056316__raw);
                writer.Write(Name_raw.ToNullTermCharArray());
                writer.Write(Unk_1_raw);
                writer.Write(DataType_raw.ToNullTermCharArray());
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
            }
        }

        public partial class Unknown : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Unknown";

            protected uint Unk_59_raw;
            public const string Unk_59_displayName = "Unk 59";
            public const int Unk_59_sortIndex = 50;
            [SortOrder(Unk_59_sortIndex)]
            [DisplayName(Unk_59_displayName)]
            public virtual uint Unk_59 {
                get => Unk_59_raw;
                set {
                    if (Unk_59_raw == value) return;
                    Unk_59_raw = value;
                    OnPropertyChanged(nameof(Unk_59));
                }
            }

            public static Unknown LoadData(BinaryReader reader) {
                var data = new Unknown();
                data.Unk_59_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Unk_59_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey));
            data = new List<MhwStructDataContainer>();
            dataByType = new Dictionary<Type, MhwStructDataContainer>();

            var Shlp_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Shlp)); i++) {
                var item = Shlp.LoadData(reader);
                item.Index = i;
                Shlp_list.Add(item);
            }
            var Shlp_container = new MhwStructDataContainer(Shlp_list, typeof(Shlp));
            data.Add(Shlp_container);
            dataByType[typeof(Shlp)] = Shlp_container;

            var Assets_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Assets)); i++) {
                var item = Assets.LoadData(reader);
                item.Index = i;
                Assets_list.Add(item);
            }
            var Assets_container = new MhwStructDataContainer(Assets_list, typeof(Assets));
            data.Add(Assets_container);
            dataByType[typeof(Assets)] = Assets_container;

            var Shlp_1__list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Shlp_1_)); i++) {
                var item = Shlp_1_.LoadData(reader);
                item.Index = i;
                Shlp_1__list.Add(item);
            }
            var Shlp_1__container = new MhwStructDataContainer(Shlp_1__list, typeof(Shlp_1_));
            data.Add(Shlp_1__container);
            dataByType[typeof(Shlp_1_)] = Shlp_1__container;

            var Number_of_Linked_Shell_Params_Holder_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Number_of_Linked_Shell_Params_Holder)); i++) {
                var item = Number_of_Linked_Shell_Params_Holder.LoadData(reader);
                item.Index = i;
                Number_of_Linked_Shell_Params_Holder_list.Add(item);
            }
            var Number_of_Linked_Shell_Params_Holder_container = new MhwStructDataContainer(Number_of_Linked_Shell_Params_Holder_list, typeof(Number_of_Linked_Shell_Params_Holder));
            data.Add(Number_of_Linked_Shell_Params_Holder_container);
            dataByType[typeof(Number_of_Linked_Shell_Params_Holder)] = Number_of_Linked_Shell_Params_Holder_container;

            var Linked_Shell_Params_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Linked_Shell_Params)); i++) {
                var item = Linked_Shell_Params.LoadData(reader);
                item.Index = i;
                Linked_Shell_Params_list.Add(item);
            }
            var Linked_Shell_Params_container = new MhwStructDataContainer(Linked_Shell_Params_list, typeof(Linked_Shell_Params));
            data.Add(Linked_Shell_Params_container);
            dataByType[typeof(Linked_Shell_Params)] = Linked_Shell_Params_container;

            var Shlp_2__list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Shlp_2_)); i++) {
                var item = Shlp_2_.LoadData(reader);
                item.Index = i;
                Shlp_2__list.Add(item);
            }
            var Shlp_2__container = new MhwStructDataContainer(Shlp_2__list, typeof(Shlp_2_));
            data.Add(Shlp_2__container);
            dataByType[typeof(Shlp_2_)] = Shlp_2__container;

            var Number_of_Modifiers_Holder_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Number_of_Modifiers_Holder)); i++) {
                var item = Number_of_Modifiers_Holder.LoadData(reader);
                item.Index = i;
                Number_of_Modifiers_Holder_list.Add(item);
            }
            var Number_of_Modifiers_Holder_container = new MhwStructDataContainer(Number_of_Modifiers_Holder_list, typeof(Number_of_Modifiers_Holder));
            data.Add(Number_of_Modifiers_Holder_container);
            dataByType[typeof(Number_of_Modifiers_Holder)] = Number_of_Modifiers_Holder_container;

            var Modifiers_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Modifiers)); i++) {
                var item = Modifiers.LoadData(reader);
                item.Index = i;
                Modifiers_list.Add(item);
            }
            var Modifiers_container = new MhwStructDataContainer(Modifiers_list, typeof(Modifiers));
            data.Add(Modifiers_container);
            dataByType[typeof(Modifiers)] = Modifiers_container;

            var Unknown_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Unknown)); i++) {
                var item = Unknown.LoadData(reader);
                item.Index = i;
                Unknown_list.Add(item);
            }
            var Unknown_container = new MhwStructDataContainer(Unknown_list, typeof(Unknown));
            data.Add(Unknown_container);
            dataByType[typeof(Unknown)] = Unknown_container;
        }
    }
}