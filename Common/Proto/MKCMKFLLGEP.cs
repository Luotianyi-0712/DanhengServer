// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MKCMKFLLGEP.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MKCMKFLLGEP.proto</summary>
  public static partial class MKCMKFLLGEPReflection {

    #region Descriptor
    /// <summary>File descriptor for MKCMKFLLGEP.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MKCMKFLLGEPReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFNS0NNS0ZMTEdFUC5wcm90bxoRTElHQUdISUFNRE4ucHJvdG8aH0NoZXNz",
            "Um9ndWVCb2FyZENlbGxTdGF0dXMucHJvdG8aEUFDSVBEREFKS0tOLnByb3Rv",
            "GhFIRkxOTUFLSUxERC5wcm90byLmAQoLTUtDTUtGTExHRVASIQoLTk9MRkdG",
            "T1BQR0EYBiADKAsyDC5IRkxOTUFLSUxERBIvCgtQUFBISFBDTU5PQxgKIAEo",
            "DjIaLkNoZXNzUm9ndWVCb2FyZENlbGxTdGF0dXMSIQoLR0hJQk9OQk9JTUYY",
            "AiABKAsyDC5MSUdBR0hJQU1EThITCgtISkNGRlBOSE9BSRgHIAMoDRITCgtN",
            "RUpGS0pJT0RFRxgDIAEoDRITCgtDRk1DRUJPR0dBRhgNIAEoDRIhCgtQT0RI",
            "SEhQS0JKTBgMIAEoCzIMLkFDSVBEREFKS0tOQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.LIGAGHIAMDNReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.ACIPDDAJKKNReflection.Descriptor, global::EggLink.DanhengServer.Proto.HFLNMAKILDDReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MKCMKFLLGEP), global::EggLink.DanhengServer.Proto.MKCMKFLLGEP.Parser, new[]{ "NOLFGFOPPGA", "PPPHHPCMNOC", "GHIBONBOIMF", "HJCFFPNHOAI", "MEJFKJIODEG", "CFMCEBOGGAF", "PODHHHPKBJL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MKCMKFLLGEP : pb::IMessage<MKCMKFLLGEP>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MKCMKFLLGEP> _parser = new pb::MessageParser<MKCMKFLLGEP>(() => new MKCMKFLLGEP());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MKCMKFLLGEP> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MKCMKFLLGEPReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MKCMKFLLGEP() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MKCMKFLLGEP(MKCMKFLLGEP other) : this() {
      nOLFGFOPPGA_ = other.nOLFGFOPPGA_.Clone();
      pPPHHPCMNOC_ = other.pPPHHPCMNOC_;
      gHIBONBOIMF_ = other.gHIBONBOIMF_ != null ? other.gHIBONBOIMF_.Clone() : null;
      hJCFFPNHOAI_ = other.hJCFFPNHOAI_.Clone();
      mEJFKJIODEG_ = other.mEJFKJIODEG_;
      cFMCEBOGGAF_ = other.cFMCEBOGGAF_;
      pODHHHPKBJL_ = other.pODHHHPKBJL_ != null ? other.pODHHHPKBJL_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MKCMKFLLGEP Clone() {
      return new MKCMKFLLGEP(this);
    }

    /// <summary>Field number for the "NOLFGFOPPGA" field.</summary>
    public const int NOLFGFOPPGAFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.HFLNMAKILDD> _repeated_nOLFGFOPPGA_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.HFLNMAKILDD.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HFLNMAKILDD> nOLFGFOPPGA_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HFLNMAKILDD>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HFLNMAKILDD> NOLFGFOPPGA {
      get { return nOLFGFOPPGA_; }
    }

    /// <summary>Field number for the "PPPHHPCMNOC" field.</summary>
    public const int PPPHHPCMNOCFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus pPPHHPCMNOC_ = global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus PPPHHPCMNOC {
      get { return pPPHHPCMNOC_; }
      set {
        pPPHHPCMNOC_ = value;
      }
    }

    /// <summary>Field number for the "GHIBONBOIMF" field.</summary>
    public const int GHIBONBOIMFFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.LIGAGHIAMDN gHIBONBOIMF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LIGAGHIAMDN GHIBONBOIMF {
      get { return gHIBONBOIMF_; }
      set {
        gHIBONBOIMF_ = value;
      }
    }

    /// <summary>Field number for the "HJCFFPNHOAI" field.</summary>
    public const int HJCFFPNHOAIFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_hJCFFPNHOAI_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> hJCFFPNHOAI_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HJCFFPNHOAI {
      get { return hJCFFPNHOAI_; }
    }

    /// <summary>Field number for the "MEJFKJIODEG" field.</summary>
    public const int MEJFKJIODEGFieldNumber = 3;
    private uint mEJFKJIODEG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MEJFKJIODEG {
      get { return mEJFKJIODEG_; }
      set {
        mEJFKJIODEG_ = value;
      }
    }

    /// <summary>Field number for the "CFMCEBOGGAF" field.</summary>
    public const int CFMCEBOGGAFFieldNumber = 13;
    private uint cFMCEBOGGAF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CFMCEBOGGAF {
      get { return cFMCEBOGGAF_; }
      set {
        cFMCEBOGGAF_ = value;
      }
    }

    /// <summary>Field number for the "PODHHHPKBJL" field.</summary>
    public const int PODHHHPKBJLFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.ACIPDDAJKKN pODHHHPKBJL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ACIPDDAJKKN PODHHHPKBJL {
      get { return pODHHHPKBJL_; }
      set {
        pODHHHPKBJL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MKCMKFLLGEP);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MKCMKFLLGEP other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!nOLFGFOPPGA_.Equals(other.nOLFGFOPPGA_)) return false;
      if (PPPHHPCMNOC != other.PPPHHPCMNOC) return false;
      if (!object.Equals(GHIBONBOIMF, other.GHIBONBOIMF)) return false;
      if(!hJCFFPNHOAI_.Equals(other.hJCFFPNHOAI_)) return false;
      if (MEJFKJIODEG != other.MEJFKJIODEG) return false;
      if (CFMCEBOGGAF != other.CFMCEBOGGAF) return false;
      if (!object.Equals(PODHHHPKBJL, other.PODHHHPKBJL)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= nOLFGFOPPGA_.GetHashCode();
      if (PPPHHPCMNOC != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) hash ^= PPPHHPCMNOC.GetHashCode();
      if (gHIBONBOIMF_ != null) hash ^= GHIBONBOIMF.GetHashCode();
      hash ^= hJCFFPNHOAI_.GetHashCode();
      if (MEJFKJIODEG != 0) hash ^= MEJFKJIODEG.GetHashCode();
      if (CFMCEBOGGAF != 0) hash ^= CFMCEBOGGAF.GetHashCode();
      if (pODHHHPKBJL_ != null) hash ^= PODHHHPKBJL.GetHashCode();
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
      if (gHIBONBOIMF_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GHIBONBOIMF);
      }
      if (MEJFKJIODEG != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(MEJFKJIODEG);
      }
      nOLFGFOPPGA_.WriteTo(output, _repeated_nOLFGFOPPGA_codec);
      hJCFFPNHOAI_.WriteTo(output, _repeated_hJCFFPNHOAI_codec);
      if (PPPHHPCMNOC != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        output.WriteRawTag(80);
        output.WriteEnum((int) PPPHHPCMNOC);
      }
      if (pODHHHPKBJL_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(PODHHHPKBJL);
      }
      if (CFMCEBOGGAF != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CFMCEBOGGAF);
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
      if (gHIBONBOIMF_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GHIBONBOIMF);
      }
      if (MEJFKJIODEG != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(MEJFKJIODEG);
      }
      nOLFGFOPPGA_.WriteTo(ref output, _repeated_nOLFGFOPPGA_codec);
      hJCFFPNHOAI_.WriteTo(ref output, _repeated_hJCFFPNHOAI_codec);
      if (PPPHHPCMNOC != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        output.WriteRawTag(80);
        output.WriteEnum((int) PPPHHPCMNOC);
      }
      if (pODHHHPKBJL_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(PODHHHPKBJL);
      }
      if (CFMCEBOGGAF != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CFMCEBOGGAF);
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
      size += nOLFGFOPPGA_.CalculateSize(_repeated_nOLFGFOPPGA_codec);
      if (PPPHHPCMNOC != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PPPHHPCMNOC);
      }
      if (gHIBONBOIMF_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GHIBONBOIMF);
      }
      size += hJCFFPNHOAI_.CalculateSize(_repeated_hJCFFPNHOAI_codec);
      if (MEJFKJIODEG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MEJFKJIODEG);
      }
      if (CFMCEBOGGAF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CFMCEBOGGAF);
      }
      if (pODHHHPKBJL_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PODHHHPKBJL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MKCMKFLLGEP other) {
      if (other == null) {
        return;
      }
      nOLFGFOPPGA_.Add(other.nOLFGFOPPGA_);
      if (other.PPPHHPCMNOC != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        PPPHHPCMNOC = other.PPPHHPCMNOC;
      }
      if (other.gHIBONBOIMF_ != null) {
        if (gHIBONBOIMF_ == null) {
          GHIBONBOIMF = new global::EggLink.DanhengServer.Proto.LIGAGHIAMDN();
        }
        GHIBONBOIMF.MergeFrom(other.GHIBONBOIMF);
      }
      hJCFFPNHOAI_.Add(other.hJCFFPNHOAI_);
      if (other.MEJFKJIODEG != 0) {
        MEJFKJIODEG = other.MEJFKJIODEG;
      }
      if (other.CFMCEBOGGAF != 0) {
        CFMCEBOGGAF = other.CFMCEBOGGAF;
      }
      if (other.pODHHHPKBJL_ != null) {
        if (pODHHHPKBJL_ == null) {
          PODHHHPKBJL = new global::EggLink.DanhengServer.Proto.ACIPDDAJKKN();
        }
        PODHHHPKBJL.MergeFrom(other.PODHHHPKBJL);
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
          case 18: {
            if (gHIBONBOIMF_ == null) {
              GHIBONBOIMF = new global::EggLink.DanhengServer.Proto.LIGAGHIAMDN();
            }
            input.ReadMessage(GHIBONBOIMF);
            break;
          }
          case 24: {
            MEJFKJIODEG = input.ReadUInt32();
            break;
          }
          case 50: {
            nOLFGFOPPGA_.AddEntriesFrom(input, _repeated_nOLFGFOPPGA_codec);
            break;
          }
          case 58:
          case 56: {
            hJCFFPNHOAI_.AddEntriesFrom(input, _repeated_hJCFFPNHOAI_codec);
            break;
          }
          case 80: {
            PPPHHPCMNOC = (global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus) input.ReadEnum();
            break;
          }
          case 98: {
            if (pODHHHPKBJL_ == null) {
              PODHHHPKBJL = new global::EggLink.DanhengServer.Proto.ACIPDDAJKKN();
            }
            input.ReadMessage(PODHHHPKBJL);
            break;
          }
          case 104: {
            CFMCEBOGGAF = input.ReadUInt32();
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
          case 18: {
            if (gHIBONBOIMF_ == null) {
              GHIBONBOIMF = new global::EggLink.DanhengServer.Proto.LIGAGHIAMDN();
            }
            input.ReadMessage(GHIBONBOIMF);
            break;
          }
          case 24: {
            MEJFKJIODEG = input.ReadUInt32();
            break;
          }
          case 50: {
            nOLFGFOPPGA_.AddEntriesFrom(ref input, _repeated_nOLFGFOPPGA_codec);
            break;
          }
          case 58:
          case 56: {
            hJCFFPNHOAI_.AddEntriesFrom(ref input, _repeated_hJCFFPNHOAI_codec);
            break;
          }
          case 80: {
            PPPHHPCMNOC = (global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus) input.ReadEnum();
            break;
          }
          case 98: {
            if (pODHHHPKBJL_ == null) {
              PODHHHPKBJL = new global::EggLink.DanhengServer.Proto.ACIPDDAJKKN();
            }
            input.ReadMessage(PODHHHPKBJL);
            break;
          }
          case 104: {
            CFMCEBOGGAF = input.ReadUInt32();
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
