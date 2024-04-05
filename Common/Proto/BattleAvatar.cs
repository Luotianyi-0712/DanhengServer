// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattleAvatar.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BattleAvatar.proto</summary>
  public static partial class BattleAvatarReflection {

    #region Descriptor
    /// <summary>File descriptor for BattleAvatar.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattleAvatarReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJCYXR0bGVBdmF0YXIucHJvdG8aEEF2YXRhclR5cGUucHJvdG8aFUJhdHRs",
            "ZUVxdWlwbWVudC5wcm90bxoRRktJQUpOTUpQRE0ucHJvdG8aEUJhdHRsZVJl",
            "bGljLnByb3RvGg9TcEJhckluZm8ucHJvdG8aFUF2YXRhclNraWxsVHJlZS5w",
            "cm90byL6AgoMQmF0dGxlQXZhdGFyEiAKC2F2YXRhcl90eXBlGAEgASgOMgsu",
            "QXZhdGFyVHlwZRIKCgJpZBgCIAEoDRINCgVsZXZlbBgDIAEoDRIMCgRyYW5r",
            "GAQgASgNEg0KBWluZGV4GAUgASgNEigKDnNraWxsdHJlZV9saXN0GAYgAygL",
            "MhAuQXZhdGFyU2tpbGxUcmVlEigKDmVxdWlwbWVudF9saXN0GAcgAygLMhAu",
            "QmF0dGxlRXF1aXBtZW50EgoKAmhwGAggASgNEhEKCXByb21vdGlvbhgKIAEo",
            "DRIgCgpyZWxpY19saXN0GAsgAygLMgwuQmF0dGxlUmVsaWMSEwoLd29ybGRf",
            "bGV2ZWwYDCABKA0SEgoKYXNzaXN0X3VpZBgNIAEoDRIhCgtHTE9JRU1DSkJI",
            "RRgPIAEoCzIMLkZLSUFKTk1KUERNEhoKBnNwX2JhchgQIAEoCzIKLlNwQmFy",
            "SW5mbxITCgtPRkxKS0JFQk1BRRgRIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AvatarTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleEquipmentReflection.Descriptor, global::EggLink.DanhengServer.Proto.FKIAJNMJPDMReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleRelicReflection.Descriptor, global::EggLink.DanhengServer.Proto.SpBarInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.AvatarSkillTreeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BattleAvatar), global::EggLink.DanhengServer.Proto.BattleAvatar.Parser, new[]{ "AvatarType", "Id", "Level", "Rank", "Index", "SkilltreeList", "EquipmentList", "Hp", "Promotion", "RelicList", "WorldLevel", "AssistUid", "GLOIEMCJBHE", "SpBar", "OFLJKBEBMAE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BattleAvatar : pb::IMessage<BattleAvatar>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BattleAvatar> _parser = new pb::MessageParser<BattleAvatar>(() => new BattleAvatar());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BattleAvatar> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BattleAvatarReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleAvatar() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleAvatar(BattleAvatar other) : this() {
      avatarType_ = other.avatarType_;
      id_ = other.id_;
      level_ = other.level_;
      rank_ = other.rank_;
      index_ = other.index_;
      skilltreeList_ = other.skilltreeList_.Clone();
      equipmentList_ = other.equipmentList_.Clone();
      hp_ = other.hp_;
      promotion_ = other.promotion_;
      relicList_ = other.relicList_.Clone();
      worldLevel_ = other.worldLevel_;
      assistUid_ = other.assistUid_;
      gLOIEMCJBHE_ = other.gLOIEMCJBHE_ != null ? other.gLOIEMCJBHE_.Clone() : null;
      spBar_ = other.spBar_ != null ? other.spBar_.Clone() : null;
      oFLJKBEBMAE_ = other.oFLJKBEBMAE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleAvatar Clone() {
      return new BattleAvatar(this);
    }

    /// <summary>Field number for the "avatar_type" field.</summary>
    public const int AvatarTypeFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.AvatarType avatarType_ = global::EggLink.DanhengServer.Proto.AvatarType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AvatarType AvatarType {
      get { return avatarType_; }
      set {
        avatarType_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 3;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "rank" field.</summary>
    public const int RankFieldNumber = 4;
    private uint rank_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Rank {
      get { return rank_; }
      set {
        rank_ = value;
      }
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 5;
    private uint index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "skilltree_list" field.</summary>
    public const int SkilltreeListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AvatarSkillTree> _repeated_skilltreeList_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.AvatarSkillTree.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AvatarSkillTree> skilltreeList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AvatarSkillTree>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AvatarSkillTree> SkilltreeList {
      get { return skilltreeList_; }
    }

    /// <summary>Field number for the "equipment_list" field.</summary>
    public const int EquipmentListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BattleEquipment> _repeated_equipmentList_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.BattleEquipment.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleEquipment> equipmentList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleEquipment>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleEquipment> EquipmentList {
      get { return equipmentList_; }
    }

    /// <summary>Field number for the "hp" field.</summary>
    public const int HpFieldNumber = 8;
    private uint hp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Hp {
      get { return hp_; }
      set {
        hp_ = value;
      }
    }

    /// <summary>Field number for the "promotion" field.</summary>
    public const int PromotionFieldNumber = 10;
    private uint promotion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Promotion {
      get { return promotion_; }
      set {
        promotion_ = value;
      }
    }

    /// <summary>Field number for the "relic_list" field.</summary>
    public const int RelicListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BattleRelic> _repeated_relicList_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.BattleRelic.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleRelic> relicList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleRelic>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleRelic> RelicList {
      get { return relicList_; }
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 12;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    /// <summary>Field number for the "assist_uid" field.</summary>
    public const int AssistUidFieldNumber = 13;
    private uint assistUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AssistUid {
      get { return assistUid_; }
      set {
        assistUid_ = value;
      }
    }

    /// <summary>Field number for the "GLOIEMCJBHE" field.</summary>
    public const int GLOIEMCJBHEFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.FKIAJNMJPDM gLOIEMCJBHE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FKIAJNMJPDM GLOIEMCJBHE {
      get { return gLOIEMCJBHE_; }
      set {
        gLOIEMCJBHE_ = value;
      }
    }

    /// <summary>Field number for the "sp_bar" field.</summary>
    public const int SpBarFieldNumber = 16;
    private global::EggLink.DanhengServer.Proto.SpBarInfo spBar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SpBarInfo SpBar {
      get { return spBar_; }
      set {
        spBar_ = value;
      }
    }

    /// <summary>Field number for the "OFLJKBEBMAE" field.</summary>
    public const int OFLJKBEBMAEFieldNumber = 17;
    private uint oFLJKBEBMAE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OFLJKBEBMAE {
      get { return oFLJKBEBMAE_; }
      set {
        oFLJKBEBMAE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BattleAvatar);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BattleAvatar other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarType != other.AvatarType) return false;
      if (Id != other.Id) return false;
      if (Level != other.Level) return false;
      if (Rank != other.Rank) return false;
      if (Index != other.Index) return false;
      if(!skilltreeList_.Equals(other.skilltreeList_)) return false;
      if(!equipmentList_.Equals(other.equipmentList_)) return false;
      if (Hp != other.Hp) return false;
      if (Promotion != other.Promotion) return false;
      if(!relicList_.Equals(other.relicList_)) return false;
      if (WorldLevel != other.WorldLevel) return false;
      if (AssistUid != other.AssistUid) return false;
      if (!object.Equals(GLOIEMCJBHE, other.GLOIEMCJBHE)) return false;
      if (!object.Equals(SpBar, other.SpBar)) return false;
      if (OFLJKBEBMAE != other.OFLJKBEBMAE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) hash ^= AvatarType.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Rank != 0) hash ^= Rank.GetHashCode();
      if (Index != 0) hash ^= Index.GetHashCode();
      hash ^= skilltreeList_.GetHashCode();
      hash ^= equipmentList_.GetHashCode();
      if (Hp != 0) hash ^= Hp.GetHashCode();
      if (Promotion != 0) hash ^= Promotion.GetHashCode();
      hash ^= relicList_.GetHashCode();
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
      if (AssistUid != 0) hash ^= AssistUid.GetHashCode();
      if (gLOIEMCJBHE_ != null) hash ^= GLOIEMCJBHE.GetHashCode();
      if (spBar_ != null) hash ^= SpBar.GetHashCode();
      if (OFLJKBEBMAE != 0) hash ^= OFLJKBEBMAE.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) AvatarType);
      }
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Id);
      }
      if (Level != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Level);
      }
      if (Rank != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Rank);
      }
      if (Index != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Index);
      }
      skilltreeList_.WriteTo(output, _repeated_skilltreeList_codec);
      equipmentList_.WriteTo(output, _repeated_equipmentList_codec);
      if (Hp != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Hp);
      }
      if (Promotion != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Promotion);
      }
      relicList_.WriteTo(output, _repeated_relicList_codec);
      if (WorldLevel != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(WorldLevel);
      }
      if (AssistUid != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(AssistUid);
      }
      if (gLOIEMCJBHE_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(GLOIEMCJBHE);
      }
      if (spBar_ != null) {
        output.WriteRawTag(130, 1);
        output.WriteMessage(SpBar);
      }
      if (OFLJKBEBMAE != 0) {
        output.WriteRawTag(136, 1);
        output.WriteUInt32(OFLJKBEBMAE);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) AvatarType);
      }
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Id);
      }
      if (Level != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Level);
      }
      if (Rank != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Rank);
      }
      if (Index != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Index);
      }
      skilltreeList_.WriteTo(ref output, _repeated_skilltreeList_codec);
      equipmentList_.WriteTo(ref output, _repeated_equipmentList_codec);
      if (Hp != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Hp);
      }
      if (Promotion != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Promotion);
      }
      relicList_.WriteTo(ref output, _repeated_relicList_codec);
      if (WorldLevel != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(WorldLevel);
      }
      if (AssistUid != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(AssistUid);
      }
      if (gLOIEMCJBHE_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(GLOIEMCJBHE);
      }
      if (spBar_ != null) {
        output.WriteRawTag(130, 1);
        output.WriteMessage(SpBar);
      }
      if (OFLJKBEBMAE != 0) {
        output.WriteRawTag(136, 1);
        output.WriteUInt32(OFLJKBEBMAE);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AvatarType);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (Rank != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Rank);
      }
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Index);
      }
      size += skilltreeList_.CalculateSize(_repeated_skilltreeList_codec);
      size += equipmentList_.CalculateSize(_repeated_equipmentList_codec);
      if (Hp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Hp);
      }
      if (Promotion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Promotion);
      }
      size += relicList_.CalculateSize(_repeated_relicList_codec);
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      if (AssistUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AssistUid);
      }
      if (gLOIEMCJBHE_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GLOIEMCJBHE);
      }
      if (spBar_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(SpBar);
      }
      if (OFLJKBEBMAE != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(OFLJKBEBMAE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BattleAvatar other) {
      if (other == null) {
        return;
      }
      if (other.AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        AvatarType = other.AvatarType;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Rank != 0) {
        Rank = other.Rank;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      skilltreeList_.Add(other.skilltreeList_);
      equipmentList_.Add(other.equipmentList_);
      if (other.Hp != 0) {
        Hp = other.Hp;
      }
      if (other.Promotion != 0) {
        Promotion = other.Promotion;
      }
      relicList_.Add(other.relicList_);
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
      }
      if (other.AssistUid != 0) {
        AssistUid = other.AssistUid;
      }
      if (other.gLOIEMCJBHE_ != null) {
        if (gLOIEMCJBHE_ == null) {
          GLOIEMCJBHE = new global::EggLink.DanhengServer.Proto.FKIAJNMJPDM();
        }
        GLOIEMCJBHE.MergeFrom(other.GLOIEMCJBHE);
      }
      if (other.spBar_ != null) {
        if (spBar_ == null) {
          SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
        }
        SpBar.MergeFrom(other.SpBar);
      }
      if (other.OFLJKBEBMAE != 0) {
        OFLJKBEBMAE = other.OFLJKBEBMAE;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            AvatarType = (global::EggLink.DanhengServer.Proto.AvatarType) input.ReadEnum();
            break;
          }
          case 16: {
            Id = input.ReadUInt32();
            break;
          }
          case 24: {
            Level = input.ReadUInt32();
            break;
          }
          case 32: {
            Rank = input.ReadUInt32();
            break;
          }
          case 40: {
            Index = input.ReadUInt32();
            break;
          }
          case 50: {
            skilltreeList_.AddEntriesFrom(input, _repeated_skilltreeList_codec);
            break;
          }
          case 58: {
            equipmentList_.AddEntriesFrom(input, _repeated_equipmentList_codec);
            break;
          }
          case 64: {
            Hp = input.ReadUInt32();
            break;
          }
          case 80: {
            Promotion = input.ReadUInt32();
            break;
          }
          case 90: {
            relicList_.AddEntriesFrom(input, _repeated_relicList_codec);
            break;
          }
          case 96: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 104: {
            AssistUid = input.ReadUInt32();
            break;
          }
          case 122: {
            if (gLOIEMCJBHE_ == null) {
              GLOIEMCJBHE = new global::EggLink.DanhengServer.Proto.FKIAJNMJPDM();
            }
            input.ReadMessage(GLOIEMCJBHE);
            break;
          }
          case 130: {
            if (spBar_ == null) {
              SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
            }
            input.ReadMessage(SpBar);
            break;
          }
          case 136: {
            OFLJKBEBMAE = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            AvatarType = (global::EggLink.DanhengServer.Proto.AvatarType) input.ReadEnum();
            break;
          }
          case 16: {
            Id = input.ReadUInt32();
            break;
          }
          case 24: {
            Level = input.ReadUInt32();
            break;
          }
          case 32: {
            Rank = input.ReadUInt32();
            break;
          }
          case 40: {
            Index = input.ReadUInt32();
            break;
          }
          case 50: {
            skilltreeList_.AddEntriesFrom(ref input, _repeated_skilltreeList_codec);
            break;
          }
          case 58: {
            equipmentList_.AddEntriesFrom(ref input, _repeated_equipmentList_codec);
            break;
          }
          case 64: {
            Hp = input.ReadUInt32();
            break;
          }
          case 80: {
            Promotion = input.ReadUInt32();
            break;
          }
          case 90: {
            relicList_.AddEntriesFrom(ref input, _repeated_relicList_codec);
            break;
          }
          case 96: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 104: {
            AssistUid = input.ReadUInt32();
            break;
          }
          case 122: {
            if (gLOIEMCJBHE_ == null) {
              GLOIEMCJBHE = new global::EggLink.DanhengServer.Proto.FKIAJNMJPDM();
            }
            input.ReadMessage(GLOIEMCJBHE);
            break;
          }
          case 130: {
            if (spBar_ == null) {
              SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
            }
            input.ReadMessage(SpBar);
            break;
          }
          case 136: {
            OFLJKBEBMAE = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
