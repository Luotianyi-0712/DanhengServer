// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetMonsterResearchActivityDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetMonsterResearchActivityDataScRsp.proto</summary>
  public static partial class GetMonsterResearchActivityDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetMonsterResearchActivityDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetMonsterResearchActivityDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilHZXRNb25zdGVyUmVzZWFyY2hBY3Rpdml0eURhdGFTY1JzcC5wcm90bxoR",
            "TktQRE9DRU5LT0YucHJvdG8aEU1PT0hCUEhCTEdJLnByb3RvInwKI0dldE1v",
            "bnN0ZXJSZXNlYXJjaEFjdGl2aXR5RGF0YVNjUnNwEg8KB3JldGNvZGUYDyAB",
            "KA0SIQoLT05QSUNFS1BOREYYCyADKAsyDC5OS1BET0NFTktPRhIhCgtHQkNK",
            "T0VOTkRJSBgJIAMoCzIMLk1PT0hCUEhCTEdJQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.NKPDOCENKOFReflection.Descriptor, global::EggLink.DanhengServer.Proto.MOOHBPHBLGIReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetMonsterResearchActivityDataScRsp), global::EggLink.DanhengServer.Proto.GetMonsterResearchActivityDataScRsp.Parser, new[]{ "Retcode", "ONPICEKPNDF", "GBCJOENNDIH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetMonsterResearchActivityDataScRsp : pb::IMessage<GetMonsterResearchActivityDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetMonsterResearchActivityDataScRsp> _parser = new pb::MessageParser<GetMonsterResearchActivityDataScRsp>(() => new GetMonsterResearchActivityDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetMonsterResearchActivityDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetMonsterResearchActivityDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMonsterResearchActivityDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMonsterResearchActivityDataScRsp(GetMonsterResearchActivityDataScRsp other) : this() {
      retcode_ = other.retcode_;
      oNPICEKPNDF_ = other.oNPICEKPNDF_.Clone();
      gBCJOENNDIH_ = other.gBCJOENNDIH_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMonsterResearchActivityDataScRsp Clone() {
      return new GetMonsterResearchActivityDataScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 15;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "ONPICEKPNDF" field.</summary>
    public const int ONPICEKPNDFFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.NKPDOCENKOF> _repeated_oNPICEKPNDF_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.NKPDOCENKOF.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NKPDOCENKOF> oNPICEKPNDF_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NKPDOCENKOF>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NKPDOCENKOF> ONPICEKPNDF {
      get { return oNPICEKPNDF_; }
    }

    /// <summary>Field number for the "GBCJOENNDIH" field.</summary>
    public const int GBCJOENNDIHFieldNumber = 9;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MOOHBPHBLGI> _repeated_gBCJOENNDIH_codec
        = pb::FieldCodec.ForMessage(74, global::EggLink.DanhengServer.Proto.MOOHBPHBLGI.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MOOHBPHBLGI> gBCJOENNDIH_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MOOHBPHBLGI>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MOOHBPHBLGI> GBCJOENNDIH {
      get { return gBCJOENNDIH_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetMonsterResearchActivityDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetMonsterResearchActivityDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if(!oNPICEKPNDF_.Equals(other.oNPICEKPNDF_)) return false;
      if(!gBCJOENNDIH_.Equals(other.gBCJOENNDIH_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= oNPICEKPNDF_.GetHashCode();
      hash ^= gBCJOENNDIH_.GetHashCode();
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
      gBCJOENNDIH_.WriteTo(output, _repeated_gBCJOENNDIH_codec);
      oNPICEKPNDF_.WriteTo(output, _repeated_oNPICEKPNDF_codec);
      if (Retcode != 0) {
        output.WriteRawTag(120);
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
      gBCJOENNDIH_.WriteTo(ref output, _repeated_gBCJOENNDIH_codec);
      oNPICEKPNDF_.WriteTo(ref output, _repeated_oNPICEKPNDF_codec);
      if (Retcode != 0) {
        output.WriteRawTag(120);
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
      size += oNPICEKPNDF_.CalculateSize(_repeated_oNPICEKPNDF_codec);
      size += gBCJOENNDIH_.CalculateSize(_repeated_gBCJOENNDIH_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetMonsterResearchActivityDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      oNPICEKPNDF_.Add(other.oNPICEKPNDF_);
      gBCJOENNDIH_.Add(other.gBCJOENNDIH_);
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
          case 74: {
            gBCJOENNDIH_.AddEntriesFrom(input, _repeated_gBCJOENNDIH_codec);
            break;
          }
          case 90: {
            oNPICEKPNDF_.AddEntriesFrom(input, _repeated_oNPICEKPNDF_codec);
            break;
          }
          case 120: {
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
          case 74: {
            gBCJOENNDIH_.AddEntriesFrom(ref input, _repeated_gBCJOENNDIH_codec);
            break;
          }
          case 90: {
            oNPICEKPNDF_.AddEntriesFrom(ref input, _repeated_oNPICEKPNDF_codec);
            break;
          }
          case 120: {
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
