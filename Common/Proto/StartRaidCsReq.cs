// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartRaidCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StartRaidCsReq.proto</summary>
  public static partial class StartRaidCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for StartRaidCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartRaidCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRTdGFydFJhaWRDc1JlcS5wcm90byJ8Cg5TdGFydFJhaWRDc1JlcRITCgtI",
            "TERFT0tGS0NCRxgGIAEoDRITCgthdmF0YXJfbGlzdBgNIAMoDRITCgt3b3Js",
            "ZF9sZXZlbBgLIAEoDRIWCg5wcm9wX2VudGl0eV9pZBgMIAEoDRITCgtOQUhL",
            "S0ZFSE9DRhgFIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StartRaidCsReq), global::EggLink.DanhengServer.Proto.StartRaidCsReq.Parser, new[]{ "HLDEOKFKCBG", "AvatarList", "WorldLevel", "PropEntityId", "NAHKKFEHOCF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StartRaidCsReq : pb::IMessage<StartRaidCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartRaidCsReq> _parser = new pb::MessageParser<StartRaidCsReq>(() => new StartRaidCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartRaidCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StartRaidCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartRaidCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartRaidCsReq(StartRaidCsReq other) : this() {
      hLDEOKFKCBG_ = other.hLDEOKFKCBG_;
      avatarList_ = other.avatarList_.Clone();
      worldLevel_ = other.worldLevel_;
      propEntityId_ = other.propEntityId_;
      nAHKKFEHOCF_ = other.nAHKKFEHOCF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartRaidCsReq Clone() {
      return new StartRaidCsReq(this);
    }

    /// <summary>Field number for the "HLDEOKFKCBG" field.</summary>
    public const int HLDEOKFKCBGFieldNumber = 6;
    private uint hLDEOKFKCBG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HLDEOKFKCBG {
      get { return hLDEOKFKCBG_; }
      set {
        hLDEOKFKCBG_ = value;
      }
    }

    /// <summary>Field number for the "avatar_list" field.</summary>
    public const int AvatarListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_avatarList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> avatarList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AvatarList {
      get { return avatarList_; }
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 11;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    /// <summary>Field number for the "prop_entity_id" field.</summary>
    public const int PropEntityIdFieldNumber = 12;
    private uint propEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PropEntityId {
      get { return propEntityId_; }
      set {
        propEntityId_ = value;
      }
    }

    /// <summary>Field number for the "NAHKKFEHOCF" field.</summary>
    public const int NAHKKFEHOCFFieldNumber = 5;
    private uint nAHKKFEHOCF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NAHKKFEHOCF {
      get { return nAHKKFEHOCF_; }
      set {
        nAHKKFEHOCF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartRaidCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartRaidCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HLDEOKFKCBG != other.HLDEOKFKCBG) return false;
      if(!avatarList_.Equals(other.avatarList_)) return false;
      if (WorldLevel != other.WorldLevel) return false;
      if (PropEntityId != other.PropEntityId) return false;
      if (NAHKKFEHOCF != other.NAHKKFEHOCF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HLDEOKFKCBG != 0) hash ^= HLDEOKFKCBG.GetHashCode();
      hash ^= avatarList_.GetHashCode();
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
      if (PropEntityId != 0) hash ^= PropEntityId.GetHashCode();
      if (NAHKKFEHOCF != 0) hash ^= NAHKKFEHOCF.GetHashCode();
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
      if (NAHKKFEHOCF != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NAHKKFEHOCF);
      }
      if (HLDEOKFKCBG != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(HLDEOKFKCBG);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WorldLevel);
      }
      if (PropEntityId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PropEntityId);
      }
      avatarList_.WriteTo(output, _repeated_avatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (NAHKKFEHOCF != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NAHKKFEHOCF);
      }
      if (HLDEOKFKCBG != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(HLDEOKFKCBG);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WorldLevel);
      }
      if (PropEntityId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PropEntityId);
      }
      avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HLDEOKFKCBG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HLDEOKFKCBG);
      }
      size += avatarList_.CalculateSize(_repeated_avatarList_codec);
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      if (PropEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PropEntityId);
      }
      if (NAHKKFEHOCF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NAHKKFEHOCF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartRaidCsReq other) {
      if (other == null) {
        return;
      }
      if (other.HLDEOKFKCBG != 0) {
        HLDEOKFKCBG = other.HLDEOKFKCBG;
      }
      avatarList_.Add(other.avatarList_);
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
      }
      if (other.PropEntityId != 0) {
        PropEntityId = other.PropEntityId;
      }
      if (other.NAHKKFEHOCF != 0) {
        NAHKKFEHOCF = other.NAHKKFEHOCF;
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
          case 40: {
            NAHKKFEHOCF = input.ReadUInt32();
            break;
          }
          case 48: {
            HLDEOKFKCBG = input.ReadUInt32();
            break;
          }
          case 88: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 96: {
            PropEntityId = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            avatarList_.AddEntriesFrom(input, _repeated_avatarList_codec);
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
          case 40: {
            NAHKKFEHOCF = input.ReadUInt32();
            break;
          }
          case 48: {
            HLDEOKFKCBG = input.ReadUInt32();
            break;
          }
          case 88: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 96: {
            PropEntityId = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
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