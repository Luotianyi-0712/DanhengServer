// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetAetherDivideChallengeInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetAetherDivideChallengeInfoScRsp.proto</summary>
  public static partial class GetAetherDivideChallengeInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetAetherDivideChallengeInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetAetherDivideChallengeInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidHZXRBZXRoZXJEaXZpZGVDaGFsbGVuZ2VJbmZvU2NSc3AucHJvdG8icwoh",
            "R2V0QWV0aGVyRGl2aWRlQ2hhbGxlbmdlSW5mb1NjUnNwEhMKC0JETk9OSEtC",
            "QUpKGAwgASgNEhMKC0FKRUdPSktESU9MGAEgAygNEg8KB3JldGNvZGUYBCAB",
            "KA0SEwoLSUpOQ0xBSUVIT08YBSADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetAetherDivideChallengeInfoScRsp), global::EggLink.DanhengServer.Proto.GetAetherDivideChallengeInfoScRsp.Parser, new[]{ "BDNONHKBAJJ", "AJEGOJKDIOL", "Retcode", "IJNCLAIEHOO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetAetherDivideChallengeInfoScRsp : pb::IMessage<GetAetherDivideChallengeInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAetherDivideChallengeInfoScRsp> _parser = new pb::MessageParser<GetAetherDivideChallengeInfoScRsp>(() => new GetAetherDivideChallengeInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetAetherDivideChallengeInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetAetherDivideChallengeInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAetherDivideChallengeInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAetherDivideChallengeInfoScRsp(GetAetherDivideChallengeInfoScRsp other) : this() {
      bDNONHKBAJJ_ = other.bDNONHKBAJJ_;
      aJEGOJKDIOL_ = other.aJEGOJKDIOL_.Clone();
      retcode_ = other.retcode_;
      iJNCLAIEHOO_ = other.iJNCLAIEHOO_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAetherDivideChallengeInfoScRsp Clone() {
      return new GetAetherDivideChallengeInfoScRsp(this);
    }

    /// <summary>Field number for the "BDNONHKBAJJ" field.</summary>
    public const int BDNONHKBAJJFieldNumber = 12;
    private uint bDNONHKBAJJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BDNONHKBAJJ {
      get { return bDNONHKBAJJ_; }
      set {
        bDNONHKBAJJ_ = value;
      }
    }

    /// <summary>Field number for the "AJEGOJKDIOL" field.</summary>
    public const int AJEGOJKDIOLFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_aJEGOJKDIOL_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> aJEGOJKDIOL_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AJEGOJKDIOL {
      get { return aJEGOJKDIOL_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 4;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "IJNCLAIEHOO" field.</summary>
    public const int IJNCLAIEHOOFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_iJNCLAIEHOO_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> iJNCLAIEHOO_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> IJNCLAIEHOO {
      get { return iJNCLAIEHOO_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetAetherDivideChallengeInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetAetherDivideChallengeInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BDNONHKBAJJ != other.BDNONHKBAJJ) return false;
      if(!aJEGOJKDIOL_.Equals(other.aJEGOJKDIOL_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!iJNCLAIEHOO_.Equals(other.iJNCLAIEHOO_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BDNONHKBAJJ != 0) hash ^= BDNONHKBAJJ.GetHashCode();
      hash ^= aJEGOJKDIOL_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= iJNCLAIEHOO_.GetHashCode();
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
      aJEGOJKDIOL_.WriteTo(output, _repeated_aJEGOJKDIOL_codec);
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      iJNCLAIEHOO_.WriteTo(output, _repeated_iJNCLAIEHOO_codec);
      if (BDNONHKBAJJ != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BDNONHKBAJJ);
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
      aJEGOJKDIOL_.WriteTo(ref output, _repeated_aJEGOJKDIOL_codec);
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      iJNCLAIEHOO_.WriteTo(ref output, _repeated_iJNCLAIEHOO_codec);
      if (BDNONHKBAJJ != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BDNONHKBAJJ);
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
      if (BDNONHKBAJJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BDNONHKBAJJ);
      }
      size += aJEGOJKDIOL_.CalculateSize(_repeated_aJEGOJKDIOL_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += iJNCLAIEHOO_.CalculateSize(_repeated_iJNCLAIEHOO_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetAetherDivideChallengeInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.BDNONHKBAJJ != 0) {
        BDNONHKBAJJ = other.BDNONHKBAJJ;
      }
      aJEGOJKDIOL_.Add(other.aJEGOJKDIOL_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      iJNCLAIEHOO_.Add(other.iJNCLAIEHOO_);
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
          case 10:
          case 8: {
            aJEGOJKDIOL_.AddEntriesFrom(input, _repeated_aJEGOJKDIOL_codec);
            break;
          }
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            iJNCLAIEHOO_.AddEntriesFrom(input, _repeated_iJNCLAIEHOO_codec);
            break;
          }
          case 96: {
            BDNONHKBAJJ = input.ReadUInt32();
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
          case 10:
          case 8: {
            aJEGOJKDIOL_.AddEntriesFrom(ref input, _repeated_aJEGOJKDIOL_codec);
            break;
          }
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            iJNCLAIEHOO_.AddEntriesFrom(ref input, _repeated_iJNCLAIEHOO_codec);
            break;
          }
          case 96: {
            BDNONHKBAJJ = input.ReadUInt32();
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
