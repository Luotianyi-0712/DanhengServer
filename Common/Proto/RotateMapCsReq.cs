// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RotateMapCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RotateMapCsReq.proto</summary>
  public static partial class RotateMapCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for RotateMapCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RotateMapCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRSb3RhdGVNYXBDc1JlcS5wcm90bxoQTW90aW9uSW5mby5wcm90bxoRTkNQ",
            "Q09LQ0lCT0YucHJvdG8idAoOUm90YXRlTWFwQ3NSZXESEwoLRkhPQkhHSEtI",
            "UE0YDSABKA0SEAoIZ3JvdXBfaWQYBCABKA0SGwoGbW90aW9uGAogASgLMgsu",
            "TW90aW9uSW5mbxIeCghtYXBfaW5mbxgLIAEoCzIMLk5DUENPS0NJQk9GQh6q",
            "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MotionInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.NCPCOKCIBOFReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RotateMapCsReq), global::EggLink.DanhengServer.Proto.RotateMapCsReq.Parser, new[]{ "FHOBHGHKHPM", "GroupId", "Motion", "MapInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RotateMapCsReq : pb::IMessage<RotateMapCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RotateMapCsReq> _parser = new pb::MessageParser<RotateMapCsReq>(() => new RotateMapCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RotateMapCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RotateMapCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RotateMapCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RotateMapCsReq(RotateMapCsReq other) : this() {
      fHOBHGHKHPM_ = other.fHOBHGHKHPM_;
      groupId_ = other.groupId_;
      motion_ = other.motion_ != null ? other.motion_.Clone() : null;
      mapInfo_ = other.mapInfo_ != null ? other.mapInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RotateMapCsReq Clone() {
      return new RotateMapCsReq(this);
    }

    /// <summary>Field number for the "FHOBHGHKHPM" field.</summary>
    public const int FHOBHGHKHPMFieldNumber = 13;
    private uint fHOBHGHKHPM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FHOBHGHKHPM {
      get { return fHOBHGHKHPM_; }
      set {
        fHOBHGHKHPM_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 4;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "motion" field.</summary>
    public const int MotionFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.MotionInfo motion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MotionInfo Motion {
      get { return motion_; }
      set {
        motion_ = value;
      }
    }

    /// <summary>Field number for the "map_info" field.</summary>
    public const int MapInfoFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.NCPCOKCIBOF mapInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.NCPCOKCIBOF MapInfo {
      get { return mapInfo_; }
      set {
        mapInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RotateMapCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RotateMapCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FHOBHGHKHPM != other.FHOBHGHKHPM) return false;
      if (GroupId != other.GroupId) return false;
      if (!object.Equals(Motion, other.Motion)) return false;
      if (!object.Equals(MapInfo, other.MapInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FHOBHGHKHPM != 0) hash ^= FHOBHGHKHPM.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (motion_ != null) hash ^= Motion.GetHashCode();
      if (mapInfo_ != null) hash ^= MapInfo.GetHashCode();
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
      if (GroupId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GroupId);
      }
      if (motion_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Motion);
      }
      if (mapInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(MapInfo);
      }
      if (FHOBHGHKHPM != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FHOBHGHKHPM);
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
      if (GroupId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GroupId);
      }
      if (motion_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Motion);
      }
      if (mapInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(MapInfo);
      }
      if (FHOBHGHKHPM != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FHOBHGHKHPM);
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
      if (FHOBHGHKHPM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FHOBHGHKHPM);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (motion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Motion);
      }
      if (mapInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MapInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RotateMapCsReq other) {
      if (other == null) {
        return;
      }
      if (other.FHOBHGHKHPM != 0) {
        FHOBHGHKHPM = other.FHOBHGHKHPM;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.motion_ != null) {
        if (motion_ == null) {
          Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
        }
        Motion.MergeFrom(other.Motion);
      }
      if (other.mapInfo_ != null) {
        if (mapInfo_ == null) {
          MapInfo = new global::EggLink.DanhengServer.Proto.NCPCOKCIBOF();
        }
        MapInfo.MergeFrom(other.MapInfo);
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
          case 32: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
            break;
          }
          case 90: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.NCPCOKCIBOF();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 104: {
            FHOBHGHKHPM = input.ReadUInt32();
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
          case 32: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
            break;
          }
          case 90: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.NCPCOKCIBOF();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 104: {
            FHOBHGHKHPM = input.ReadUInt32();
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
