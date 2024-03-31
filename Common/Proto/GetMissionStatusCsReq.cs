// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetMissionStatusCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetMissionStatusCsReq.proto</summary>
  public static partial class GetMissionStatusCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for GetMissionStatusCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetMissionStatusCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtHZXRNaXNzaW9uU3RhdHVzQ3NSZXEucHJvdG8icQoVR2V0TWlzc2lvblN0",
            "YXR1c0NzUmVxEhwKFG1haW5fbWlzc2lvbl9pZF9saXN0GA0gAygNEhsKE3N1",
            "Yl9taXNzaW9uX2lkX2xpc3QYAiADKA0SHQoVbWlzc2lvbl9ldmVudF9pZF9s",
            "aXN0GAggAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetMissionStatusCsReq), global::EggLink.DanhengServer.Proto.GetMissionStatusCsReq.Parser, new[]{ "MainMissionIdList", "SubMissionIdList", "MissionEventIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetMissionStatusCsReq : pb::IMessage<GetMissionStatusCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetMissionStatusCsReq> _parser = new pb::MessageParser<GetMissionStatusCsReq>(() => new GetMissionStatusCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetMissionStatusCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetMissionStatusCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMissionStatusCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMissionStatusCsReq(GetMissionStatusCsReq other) : this() {
      mainMissionIdList_ = other.mainMissionIdList_.Clone();
      subMissionIdList_ = other.subMissionIdList_.Clone();
      missionEventIdList_ = other.missionEventIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMissionStatusCsReq Clone() {
      return new GetMissionStatusCsReq(this);
    }

    /// <summary>Field number for the "main_mission_id_list" field.</summary>
    public const int MainMissionIdListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_mainMissionIdList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> mainMissionIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MainMissionIdList {
      get { return mainMissionIdList_; }
    }

    /// <summary>Field number for the "sub_mission_id_list" field.</summary>
    public const int SubMissionIdListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_subMissionIdList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> subMissionIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SubMissionIdList {
      get { return subMissionIdList_; }
    }

    /// <summary>Field number for the "mission_event_id_list" field.</summary>
    public const int MissionEventIdListFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_missionEventIdList_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> missionEventIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MissionEventIdList {
      get { return missionEventIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetMissionStatusCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetMissionStatusCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!mainMissionIdList_.Equals(other.mainMissionIdList_)) return false;
      if(!subMissionIdList_.Equals(other.subMissionIdList_)) return false;
      if(!missionEventIdList_.Equals(other.missionEventIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= mainMissionIdList_.GetHashCode();
      hash ^= subMissionIdList_.GetHashCode();
      hash ^= missionEventIdList_.GetHashCode();
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
      subMissionIdList_.WriteTo(output, _repeated_subMissionIdList_codec);
      missionEventIdList_.WriteTo(output, _repeated_missionEventIdList_codec);
      mainMissionIdList_.WriteTo(output, _repeated_mainMissionIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      subMissionIdList_.WriteTo(ref output, _repeated_subMissionIdList_codec);
      missionEventIdList_.WriteTo(ref output, _repeated_missionEventIdList_codec);
      mainMissionIdList_.WriteTo(ref output, _repeated_mainMissionIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += mainMissionIdList_.CalculateSize(_repeated_mainMissionIdList_codec);
      size += subMissionIdList_.CalculateSize(_repeated_subMissionIdList_codec);
      size += missionEventIdList_.CalculateSize(_repeated_missionEventIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetMissionStatusCsReq other) {
      if (other == null) {
        return;
      }
      mainMissionIdList_.Add(other.mainMissionIdList_);
      subMissionIdList_.Add(other.subMissionIdList_);
      missionEventIdList_.Add(other.missionEventIdList_);
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
          case 18:
          case 16: {
            subMissionIdList_.AddEntriesFrom(input, _repeated_subMissionIdList_codec);
            break;
          }
          case 66:
          case 64: {
            missionEventIdList_.AddEntriesFrom(input, _repeated_missionEventIdList_codec);
            break;
          }
          case 106:
          case 104: {
            mainMissionIdList_.AddEntriesFrom(input, _repeated_mainMissionIdList_codec);
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
          case 18:
          case 16: {
            subMissionIdList_.AddEntriesFrom(ref input, _repeated_subMissionIdList_codec);
            break;
          }
          case 66:
          case 64: {
            missionEventIdList_.AddEntriesFrom(ref input, _repeated_missionEventIdList_codec);
            break;
          }
          case 106:
          case 104: {
            mainMissionIdList_.AddEntriesFrom(ref input, _repeated_mainMissionIdList_codec);
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
