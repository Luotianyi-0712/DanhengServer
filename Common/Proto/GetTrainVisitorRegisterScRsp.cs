// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetTrainVisitorRegisterScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetTrainVisitorRegisterScRsp.proto</summary>
  public static partial class GetTrainVisitorRegisterScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetTrainVisitorRegisterScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetTrainVisitorRegisterScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJHZXRUcmFpblZpc2l0b3JSZWdpc3RlclNjUnNwLnByb3RvGhZUcmFpblZp",
            "c2l0b3JJbmZvLnByb3RvImwKHEdldFRyYWluVmlzaXRvclJlZ2lzdGVyU2NS",
            "c3ASDwoHcmV0Y29kZRgOIAEoDRImCgtMR05PT0RPRk5LRxgLIAMoCzIRLlRy",
            "YWluVmlzaXRvckluZm8SEwoLS0JET0FKTk5PSE0YBCADKA1CHqoCG0VnZ0xp",
            "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.TrainVisitorInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetTrainVisitorRegisterScRsp), global::EggLink.DanhengServer.Proto.GetTrainVisitorRegisterScRsp.Parser, new[]{ "Retcode", "LGNOODOFNKG", "KBDOAJNNOHM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetTrainVisitorRegisterScRsp : pb::IMessage<GetTrainVisitorRegisterScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetTrainVisitorRegisterScRsp> _parser = new pb::MessageParser<GetTrainVisitorRegisterScRsp>(() => new GetTrainVisitorRegisterScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetTrainVisitorRegisterScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetTrainVisitorRegisterScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetTrainVisitorRegisterScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetTrainVisitorRegisterScRsp(GetTrainVisitorRegisterScRsp other) : this() {
      retcode_ = other.retcode_;
      lGNOODOFNKG_ = other.lGNOODOFNKG_.Clone();
      kBDOAJNNOHM_ = other.kBDOAJNNOHM_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetTrainVisitorRegisterScRsp Clone() {
      return new GetTrainVisitorRegisterScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 14;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "LGNOODOFNKG" field.</summary>
    public const int LGNOODOFNKGFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.TrainVisitorInfo> _repeated_lGNOODOFNKG_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.TrainVisitorInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TrainVisitorInfo> lGNOODOFNKG_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TrainVisitorInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TrainVisitorInfo> LGNOODOFNKG {
      get { return lGNOODOFNKG_; }
    }

    /// <summary>Field number for the "KBDOAJNNOHM" field.</summary>
    public const int KBDOAJNNOHMFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_kBDOAJNNOHM_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> kBDOAJNNOHM_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> KBDOAJNNOHM {
      get { return kBDOAJNNOHM_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetTrainVisitorRegisterScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetTrainVisitorRegisterScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if(!lGNOODOFNKG_.Equals(other.lGNOODOFNKG_)) return false;
      if(!kBDOAJNNOHM_.Equals(other.kBDOAJNNOHM_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= lGNOODOFNKG_.GetHashCode();
      hash ^= kBDOAJNNOHM_.GetHashCode();
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
      kBDOAJNNOHM_.WriteTo(output, _repeated_kBDOAJNNOHM_codec);
      lGNOODOFNKG_.WriteTo(output, _repeated_lGNOODOFNKG_codec);
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Retcode);
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
      kBDOAJNNOHM_.WriteTo(ref output, _repeated_kBDOAJNNOHM_codec);
      lGNOODOFNKG_.WriteTo(ref output, _repeated_lGNOODOFNKG_codec);
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Retcode);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += lGNOODOFNKG_.CalculateSize(_repeated_lGNOODOFNKG_codec);
      size += kBDOAJNNOHM_.CalculateSize(_repeated_kBDOAJNNOHM_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetTrainVisitorRegisterScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      lGNOODOFNKG_.Add(other.lGNOODOFNKG_);
      kBDOAJNNOHM_.Add(other.kBDOAJNNOHM_);
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
          case 34:
          case 32: {
            kBDOAJNNOHM_.AddEntriesFrom(input, _repeated_kBDOAJNNOHM_codec);
            break;
          }
          case 90: {
            lGNOODOFNKG_.AddEntriesFrom(input, _repeated_lGNOODOFNKG_codec);
            break;
          }
          case 112: {
            Retcode = input.ReadUInt32();
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
          case 34:
          case 32: {
            kBDOAJNNOHM_.AddEntriesFrom(ref input, _repeated_kBDOAJNNOHM_codec);
            break;
          }
          case 90: {
            lGNOODOFNKG_.AddEntriesFrom(ref input, _repeated_lGNOODOFNKG_codec);
            break;
          }
          case 112: {
            Retcode = input.ReadUInt32();
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
