// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetLineupAvatarDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetLineupAvatarDataScRsp.proto</summary>
  public static partial class GetLineupAvatarDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetLineupAvatarDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetLineupAvatarDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5HZXRMaW5ldXBBdmF0YXJEYXRhU2NSc3AucHJvdG8aFkxpbmV1cEF2YXRh",
            "ckRhdGEucHJvdG8iWAoYR2V0TGluZXVwQXZhdGFyRGF0YVNjUnNwEg8KB3Jl",
            "dGNvZGUYCCABKA0SKwoQYXZhdGFyX2RhdGFfbGlzdBgMIAMoCzIRLkxpbmV1",
            "cEF2YXRhckRhdGFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.LineupAvatarDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetLineupAvatarDataScRsp), global::EggLink.DanhengServer.Proto.GetLineupAvatarDataScRsp.Parser, new[]{ "Retcode", "AvatarDataList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetLineupAvatarDataScRsp : pb::IMessage<GetLineupAvatarDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetLineupAvatarDataScRsp> _parser = new pb::MessageParser<GetLineupAvatarDataScRsp>(() => new GetLineupAvatarDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetLineupAvatarDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetLineupAvatarDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetLineupAvatarDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetLineupAvatarDataScRsp(GetLineupAvatarDataScRsp other) : this() {
      retcode_ = other.retcode_;
      avatarDataList_ = other.avatarDataList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetLineupAvatarDataScRsp Clone() {
      return new GetLineupAvatarDataScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "avatar_data_list" field.</summary>
    public const int AvatarDataListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.LineupAvatarData> _repeated_avatarDataList_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.LineupAvatarData.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LineupAvatarData> avatarDataList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LineupAvatarData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LineupAvatarData> AvatarDataList {
      get { return avatarDataList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetLineupAvatarDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetLineupAvatarDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if(!avatarDataList_.Equals(other.avatarDataList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= avatarDataList_.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      avatarDataList_.WriteTo(output, _repeated_avatarDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      avatarDataList_.WriteTo(ref output, _repeated_avatarDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += avatarDataList_.CalculateSize(_repeated_avatarDataList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetLineupAvatarDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      avatarDataList_.Add(other.avatarDataList_);
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
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            avatarDataList_.AddEntriesFrom(input, _repeated_avatarDataList_codec);
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
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            avatarDataList_.AddEntriesFrom(ref input, _repeated_avatarDataList_codec);
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
