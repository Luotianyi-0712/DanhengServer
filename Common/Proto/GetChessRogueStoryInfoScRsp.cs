// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetChessRogueStoryInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetChessRogueStoryInfoScRsp.proto</summary>
  public static partial class GetChessRogueStoryInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetChessRogueStoryInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetChessRogueStoryInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFHZXRDaGVzc1JvZ3VlU3RvcnlJbmZvU2NSc3AucHJvdG8aEUhBRkhCQk5F",
            "QU9QLnByb3RvGhFPTkpCRkhBSlBBQi5wcm90byJ0ChtHZXRDaGVzc1JvZ3Vl",
            "U3RvcnlJbmZvU2NSc3ASIQoLTEdQQlBDQ0ZCR0wYBSADKAsyDC5IQUZIQkJO",
            "RUFPUBIPCgdyZXRjb2RlGA0gASgNEiEKC0dHSENPSEhPSkpIGA8gAygLMgwu",
            "T05KQkZIQUpQQUJCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HAFHBBNEAOPReflection.Descriptor, global::EggLink.DanhengServer.Proto.ONJBFHAJPABReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetChessRogueStoryInfoScRsp), global::EggLink.DanhengServer.Proto.GetChessRogueStoryInfoScRsp.Parser, new[]{ "LGPBPCCFBGL", "Retcode", "GGHCOHHOJJH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetChessRogueStoryInfoScRsp : pb::IMessage<GetChessRogueStoryInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetChessRogueStoryInfoScRsp> _parser = new pb::MessageParser<GetChessRogueStoryInfoScRsp>(() => new GetChessRogueStoryInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetChessRogueStoryInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetChessRogueStoryInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChessRogueStoryInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChessRogueStoryInfoScRsp(GetChessRogueStoryInfoScRsp other) : this() {
      lGPBPCCFBGL_ = other.lGPBPCCFBGL_.Clone();
      retcode_ = other.retcode_;
      gGHCOHHOJJH_ = other.gGHCOHHOJJH_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChessRogueStoryInfoScRsp Clone() {
      return new GetChessRogueStoryInfoScRsp(this);
    }

    /// <summary>Field number for the "LGPBPCCFBGL" field.</summary>
    public const int LGPBPCCFBGLFieldNumber = 5;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.HAFHBBNEAOP> _repeated_lGPBPCCFBGL_codec
        = pb::FieldCodec.ForMessage(42, global::EggLink.DanhengServer.Proto.HAFHBBNEAOP.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HAFHBBNEAOP> lGPBPCCFBGL_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HAFHBBNEAOP>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HAFHBBNEAOP> LGPBPCCFBGL {
      get { return lGPBPCCFBGL_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "GGHCOHHOJJH" field.</summary>
    public const int GGHCOHHOJJHFieldNumber = 15;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ONJBFHAJPAB> _repeated_gGHCOHHOJJH_codec
        = pb::FieldCodec.ForMessage(122, global::EggLink.DanhengServer.Proto.ONJBFHAJPAB.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ONJBFHAJPAB> gGHCOHHOJJH_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ONJBFHAJPAB>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ONJBFHAJPAB> GGHCOHHOJJH {
      get { return gGHCOHHOJJH_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetChessRogueStoryInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetChessRogueStoryInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!lGPBPCCFBGL_.Equals(other.lGPBPCCFBGL_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!gGHCOHHOJJH_.Equals(other.gGHCOHHOJJH_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= lGPBPCCFBGL_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= gGHCOHHOJJH_.GetHashCode();
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
      lGPBPCCFBGL_.WriteTo(output, _repeated_lGPBPCCFBGL_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      gGHCOHHOJJH_.WriteTo(output, _repeated_gGHCOHHOJJH_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      lGPBPCCFBGL_.WriteTo(ref output, _repeated_lGPBPCCFBGL_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      gGHCOHHOJJH_.WriteTo(ref output, _repeated_gGHCOHHOJJH_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += lGPBPCCFBGL_.CalculateSize(_repeated_lGPBPCCFBGL_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += gGHCOHHOJJH_.CalculateSize(_repeated_gGHCOHHOJJH_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetChessRogueStoryInfoScRsp other) {
      if (other == null) {
        return;
      }
      lGPBPCCFBGL_.Add(other.lGPBPCCFBGL_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      gGHCOHHOJJH_.Add(other.gGHCOHHOJJH_);
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
          case 42: {
            lGPBPCCFBGL_.AddEntriesFrom(input, _repeated_lGPBPCCFBGL_codec);
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 122: {
            gGHCOHHOJJH_.AddEntriesFrom(input, _repeated_gGHCOHHOJJH_codec);
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
          case 42: {
            lGPBPCCFBGL_.AddEntriesFrom(ref input, _repeated_lGPBPCCFBGL_codec);
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 122: {
            gGHCOHHOJJH_.AddEntriesFrom(ref input, _repeated_gGHCOHHOJJH_codec);
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
