// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneMapInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneMapInfo.proto</summary>
  public static partial class SceneMapInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneMapInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneMapInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJTY2VuZU1hcEluZm8ucHJvdG8aD0NoZXN0SW5mby5wcm90bxoRQUpLRkJD",
            "TE5NTEMucHJvdG8aD01hemVHcm91cC5wcm90bxoTTWF6ZVByb3BTdGF0ZS5w",
            "cm90byKsAgoMU2NlbmVNYXBJbmZvEiMKD21hemVfZ3JvdXBfbGlzdBgBIAMo",
            "CzIKLk1hemVHcm91cBImCg5tYXplX3Byb3BfbGlzdBgKIAMoCzIOLk1hemVQ",
            "cm9wU3RhdGUSHAoUbGlnaHRlbl9zZWN0aW9uX2xpc3QYCSADKA0SGAoQY3Vy",
            "X21hcF9lbnRyeV9pZBgOIAEoDRIQCghlbnRyeV9pZBgPIAEoDRIPCgdyZXRj",
            "b2RlGAsgASgNEiEKC0lLQktQSkNBTkVBGAggAygLMgwuQUpLRkJDTE5NTEMS",
            "EwoLS0lHTExLSUJOTEkYBCABKA0SHAoUdW5sb2NrX3RlbGVwb3J0X2xpc3QY",
            "AiADKA0SHgoKY2hlc3RfbGlzdBgNIAMoCzIKLkNoZXN0SW5mb0IeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChestInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.AJKFBCLNMLCReflection.Descriptor, global::EggLink.DanhengServer.Proto.MazeGroupReflection.Descriptor, global::EggLink.DanhengServer.Proto.MazePropStateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneMapInfo), global::EggLink.DanhengServer.Proto.SceneMapInfo.Parser, new[]{ "MazeGroupList", "MazePropList", "LightenSectionList", "CurMapEntryId", "EntryId", "Retcode", "IKBKPJCANEA", "KIGLLKIBNLI", "UnlockTeleportList", "ChestList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneMapInfo : pb::IMessage<SceneMapInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneMapInfo> _parser = new pb::MessageParser<SceneMapInfo>(() => new SceneMapInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneMapInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneMapInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneMapInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneMapInfo(SceneMapInfo other) : this() {
      mazeGroupList_ = other.mazeGroupList_.Clone();
      mazePropList_ = other.mazePropList_.Clone();
      lightenSectionList_ = other.lightenSectionList_.Clone();
      curMapEntryId_ = other.curMapEntryId_;
      entryId_ = other.entryId_;
      retcode_ = other.retcode_;
      iKBKPJCANEA_ = other.iKBKPJCANEA_.Clone();
      kIGLLKIBNLI_ = other.kIGLLKIBNLI_;
      unlockTeleportList_ = other.unlockTeleportList_.Clone();
      chestList_ = other.chestList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneMapInfo Clone() {
      return new SceneMapInfo(this);
    }

    /// <summary>Field number for the "maze_group_list" field.</summary>
    public const int MazeGroupListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MazeGroup> _repeated_mazeGroupList_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.MazeGroup.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeGroup> mazeGroupList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeGroup> MazeGroupList {
      get { return mazeGroupList_; }
    }

    /// <summary>Field number for the "maze_prop_list" field.</summary>
    public const int MazePropListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MazePropState> _repeated_mazePropList_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.MazePropState.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazePropState> mazePropList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazePropState>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazePropState> MazePropList {
      get { return mazePropList_; }
    }

    /// <summary>Field number for the "lighten_section_list" field.</summary>
    public const int LightenSectionListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_lightenSectionList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> lightenSectionList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LightenSectionList {
      get { return lightenSectionList_; }
    }

    /// <summary>Field number for the "cur_map_entry_id" field.</summary>
    public const int CurMapEntryIdFieldNumber = 14;
    private uint curMapEntryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurMapEntryId {
      get { return curMapEntryId_; }
      set {
        curMapEntryId_ = value;
      }
    }

    /// <summary>Field number for the "entry_id" field.</summary>
    public const int EntryIdFieldNumber = 15;
    private uint entryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntryId {
      get { return entryId_; }
      set {
        entryId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "IKBKPJCANEA" field.</summary>
    public const int IKBKPJCANEAFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AJKFBCLNMLC> _repeated_iKBKPJCANEA_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.AJKFBCLNMLC.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AJKFBCLNMLC> iKBKPJCANEA_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AJKFBCLNMLC>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AJKFBCLNMLC> IKBKPJCANEA {
      get { return iKBKPJCANEA_; }
    }

    /// <summary>Field number for the "KIGLLKIBNLI" field.</summary>
    public const int KIGLLKIBNLIFieldNumber = 4;
    private uint kIGLLKIBNLI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KIGLLKIBNLI {
      get { return kIGLLKIBNLI_; }
      set {
        kIGLLKIBNLI_ = value;
      }
    }

    /// <summary>Field number for the "unlock_teleport_list" field.</summary>
    public const int UnlockTeleportListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_unlockTeleportList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> unlockTeleportList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockTeleportList {
      get { return unlockTeleportList_; }
    }

    /// <summary>Field number for the "chest_list" field.</summary>
    public const int ChestListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChestInfo> _repeated_chestList_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.ChestInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChestInfo> chestList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChestInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChestInfo> ChestList {
      get { return chestList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneMapInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneMapInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!mazeGroupList_.Equals(other.mazeGroupList_)) return false;
      if(!mazePropList_.Equals(other.mazePropList_)) return false;
      if(!lightenSectionList_.Equals(other.lightenSectionList_)) return false;
      if (CurMapEntryId != other.CurMapEntryId) return false;
      if (EntryId != other.EntryId) return false;
      if (Retcode != other.Retcode) return false;
      if(!iKBKPJCANEA_.Equals(other.iKBKPJCANEA_)) return false;
      if (KIGLLKIBNLI != other.KIGLLKIBNLI) return false;
      if(!unlockTeleportList_.Equals(other.unlockTeleportList_)) return false;
      if(!chestList_.Equals(other.chestList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= mazeGroupList_.GetHashCode();
      hash ^= mazePropList_.GetHashCode();
      hash ^= lightenSectionList_.GetHashCode();
      if (CurMapEntryId != 0) hash ^= CurMapEntryId.GetHashCode();
      if (EntryId != 0) hash ^= EntryId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= iKBKPJCANEA_.GetHashCode();
      if (KIGLLKIBNLI != 0) hash ^= KIGLLKIBNLI.GetHashCode();
      hash ^= unlockTeleportList_.GetHashCode();
      hash ^= chestList_.GetHashCode();
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
      mazeGroupList_.WriteTo(output, _repeated_mazeGroupList_codec);
      unlockTeleportList_.WriteTo(output, _repeated_unlockTeleportList_codec);
      if (KIGLLKIBNLI != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(KIGLLKIBNLI);
      }
      iKBKPJCANEA_.WriteTo(output, _repeated_iKBKPJCANEA_codec);
      lightenSectionList_.WriteTo(output, _repeated_lightenSectionList_codec);
      mazePropList_.WriteTo(output, _repeated_mazePropList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      chestList_.WriteTo(output, _repeated_chestList_codec);
      if (CurMapEntryId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(CurMapEntryId);
      }
      if (EntryId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(EntryId);
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
      mazeGroupList_.WriteTo(ref output, _repeated_mazeGroupList_codec);
      unlockTeleportList_.WriteTo(ref output, _repeated_unlockTeleportList_codec);
      if (KIGLLKIBNLI != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(KIGLLKIBNLI);
      }
      iKBKPJCANEA_.WriteTo(ref output, _repeated_iKBKPJCANEA_codec);
      lightenSectionList_.WriteTo(ref output, _repeated_lightenSectionList_codec);
      mazePropList_.WriteTo(ref output, _repeated_mazePropList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      chestList_.WriteTo(ref output, _repeated_chestList_codec);
      if (CurMapEntryId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(CurMapEntryId);
      }
      if (EntryId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(EntryId);
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
      size += mazeGroupList_.CalculateSize(_repeated_mazeGroupList_codec);
      size += mazePropList_.CalculateSize(_repeated_mazePropList_codec);
      size += lightenSectionList_.CalculateSize(_repeated_lightenSectionList_codec);
      if (CurMapEntryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurMapEntryId);
      }
      if (EntryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntryId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += iKBKPJCANEA_.CalculateSize(_repeated_iKBKPJCANEA_codec);
      if (KIGLLKIBNLI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KIGLLKIBNLI);
      }
      size += unlockTeleportList_.CalculateSize(_repeated_unlockTeleportList_codec);
      size += chestList_.CalculateSize(_repeated_chestList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneMapInfo other) {
      if (other == null) {
        return;
      }
      mazeGroupList_.Add(other.mazeGroupList_);
      mazePropList_.Add(other.mazePropList_);
      lightenSectionList_.Add(other.lightenSectionList_);
      if (other.CurMapEntryId != 0) {
        CurMapEntryId = other.CurMapEntryId;
      }
      if (other.EntryId != 0) {
        EntryId = other.EntryId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      iKBKPJCANEA_.Add(other.iKBKPJCANEA_);
      if (other.KIGLLKIBNLI != 0) {
        KIGLLKIBNLI = other.KIGLLKIBNLI;
      }
      unlockTeleportList_.Add(other.unlockTeleportList_);
      chestList_.Add(other.chestList_);
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
          case 10: {
            mazeGroupList_.AddEntriesFrom(input, _repeated_mazeGroupList_codec);
            break;
          }
          case 18:
          case 16: {
            unlockTeleportList_.AddEntriesFrom(input, _repeated_unlockTeleportList_codec);
            break;
          }
          case 32: {
            KIGLLKIBNLI = input.ReadUInt32();
            break;
          }
          case 66: {
            iKBKPJCANEA_.AddEntriesFrom(input, _repeated_iKBKPJCANEA_codec);
            break;
          }
          case 74:
          case 72: {
            lightenSectionList_.AddEntriesFrom(input, _repeated_lightenSectionList_codec);
            break;
          }
          case 82: {
            mazePropList_.AddEntriesFrom(input, _repeated_mazePropList_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 106: {
            chestList_.AddEntriesFrom(input, _repeated_chestList_codec);
            break;
          }
          case 112: {
            CurMapEntryId = input.ReadUInt32();
            break;
          }
          case 120: {
            EntryId = input.ReadUInt32();
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
          case 10: {
            mazeGroupList_.AddEntriesFrom(ref input, _repeated_mazeGroupList_codec);
            break;
          }
          case 18:
          case 16: {
            unlockTeleportList_.AddEntriesFrom(ref input, _repeated_unlockTeleportList_codec);
            break;
          }
          case 32: {
            KIGLLKIBNLI = input.ReadUInt32();
            break;
          }
          case 66: {
            iKBKPJCANEA_.AddEntriesFrom(ref input, _repeated_iKBKPJCANEA_codec);
            break;
          }
          case 74:
          case 72: {
            lightenSectionList_.AddEntriesFrom(ref input, _repeated_lightenSectionList_codec);
            break;
          }
          case 82: {
            mazePropList_.AddEntriesFrom(ref input, _repeated_mazePropList_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 106: {
            chestList_.AddEntriesFrom(ref input, _repeated_chestList_codec);
            break;
          }
          case 112: {
            CurMapEntryId = input.ReadUInt32();
            break;
          }
          case 120: {
            EntryId = input.ReadUInt32();
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
