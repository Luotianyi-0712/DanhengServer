// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EGKMHKLMNKI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EGKMHKLMNKI.proto</summary>
  public static partial class EGKMHKLMNKIReflection {

    #region Descriptor
    /// <summary>File descriptor for EGKMHKLMNKI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EGKMHKLMNKIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFFR0tNSEtMTU5LSS5wcm90bxoRTUZHR01BREpMSU0ucHJvdG8iwwEKC0VH",
            "S01IS0xNTktJEiEKC0pQRElOTU9NRENJGAQgAygLMgwuTUZHR01BREpMSU0S",
            "EwoLTU5PSUVOSEJMRUMYASABKA0SEwoLSU5MSEhBSkdCSE4YByABKAgSEwoL",
            "SEZESEVLREVJRUoYCSABKA0SEwoLS0tCR0hIRUVMR0IYBiABKA0SEwoLSklF",
            "SUNNTUhMSUkYCiABKA0SEwoLQ0RCSUdGTU9OTE8YDyABKA0SEwoLRVBOREhO",
            "TE1LSEIYDiABKAhCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MFGGMADJLIMReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EGKMHKLMNKI), global::EggLink.DanhengServer.Proto.EGKMHKLMNKI.Parser, new[]{ "JPDINMOMDCI", "MNOIENHBLEC", "INLHHAJGBHN", "HFDHEKDEIEJ", "KKBGHHEELGB", "JIEICMMHLII", "CDBIGFMONLO", "EPNDHNLMKHB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EGKMHKLMNKI : pb::IMessage<EGKMHKLMNKI>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EGKMHKLMNKI> _parser = new pb::MessageParser<EGKMHKLMNKI>(() => new EGKMHKLMNKI());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EGKMHKLMNKI> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EGKMHKLMNKIReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EGKMHKLMNKI() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EGKMHKLMNKI(EGKMHKLMNKI other) : this() {
      jPDINMOMDCI_ = other.jPDINMOMDCI_.Clone();
      mNOIENHBLEC_ = other.mNOIENHBLEC_;
      iNLHHAJGBHN_ = other.iNLHHAJGBHN_;
      hFDHEKDEIEJ_ = other.hFDHEKDEIEJ_;
      kKBGHHEELGB_ = other.kKBGHHEELGB_;
      jIEICMMHLII_ = other.jIEICMMHLII_;
      cDBIGFMONLO_ = other.cDBIGFMONLO_;
      ePNDHNLMKHB_ = other.ePNDHNLMKHB_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EGKMHKLMNKI Clone() {
      return new EGKMHKLMNKI(this);
    }

    /// <summary>Field number for the "JPDINMOMDCI" field.</summary>
    public const int JPDINMOMDCIFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MFGGMADJLIM> _repeated_jPDINMOMDCI_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.MFGGMADJLIM.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MFGGMADJLIM> jPDINMOMDCI_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MFGGMADJLIM>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MFGGMADJLIM> JPDINMOMDCI {
      get { return jPDINMOMDCI_; }
    }

    /// <summary>Field number for the "MNOIENHBLEC" field.</summary>
    public const int MNOIENHBLECFieldNumber = 1;
    private uint mNOIENHBLEC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MNOIENHBLEC {
      get { return mNOIENHBLEC_; }
      set {
        mNOIENHBLEC_ = value;
      }
    }

    /// <summary>Field number for the "INLHHAJGBHN" field.</summary>
    public const int INLHHAJGBHNFieldNumber = 7;
    private bool iNLHHAJGBHN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool INLHHAJGBHN {
      get { return iNLHHAJGBHN_; }
      set {
        iNLHHAJGBHN_ = value;
      }
    }

    /// <summary>Field number for the "HFDHEKDEIEJ" field.</summary>
    public const int HFDHEKDEIEJFieldNumber = 9;
    private uint hFDHEKDEIEJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HFDHEKDEIEJ {
      get { return hFDHEKDEIEJ_; }
      set {
        hFDHEKDEIEJ_ = value;
      }
    }

    /// <summary>Field number for the "KKBGHHEELGB" field.</summary>
    public const int KKBGHHEELGBFieldNumber = 6;
    private uint kKBGHHEELGB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KKBGHHEELGB {
      get { return kKBGHHEELGB_; }
      set {
        kKBGHHEELGB_ = value;
      }
    }

    /// <summary>Field number for the "JIEICMMHLII" field.</summary>
    public const int JIEICMMHLIIFieldNumber = 10;
    private uint jIEICMMHLII_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JIEICMMHLII {
      get { return jIEICMMHLII_; }
      set {
        jIEICMMHLII_ = value;
      }
    }

    /// <summary>Field number for the "CDBIGFMONLO" field.</summary>
    public const int CDBIGFMONLOFieldNumber = 15;
    private uint cDBIGFMONLO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CDBIGFMONLO {
      get { return cDBIGFMONLO_; }
      set {
        cDBIGFMONLO_ = value;
      }
    }

    /// <summary>Field number for the "EPNDHNLMKHB" field.</summary>
    public const int EPNDHNLMKHBFieldNumber = 14;
    private bool ePNDHNLMKHB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EPNDHNLMKHB {
      get { return ePNDHNLMKHB_; }
      set {
        ePNDHNLMKHB_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EGKMHKLMNKI);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EGKMHKLMNKI other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!jPDINMOMDCI_.Equals(other.jPDINMOMDCI_)) return false;
      if (MNOIENHBLEC != other.MNOIENHBLEC) return false;
      if (INLHHAJGBHN != other.INLHHAJGBHN) return false;
      if (HFDHEKDEIEJ != other.HFDHEKDEIEJ) return false;
      if (KKBGHHEELGB != other.KKBGHHEELGB) return false;
      if (JIEICMMHLII != other.JIEICMMHLII) return false;
      if (CDBIGFMONLO != other.CDBIGFMONLO) return false;
      if (EPNDHNLMKHB != other.EPNDHNLMKHB) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= jPDINMOMDCI_.GetHashCode();
      if (MNOIENHBLEC != 0) hash ^= MNOIENHBLEC.GetHashCode();
      if (INLHHAJGBHN != false) hash ^= INLHHAJGBHN.GetHashCode();
      if (HFDHEKDEIEJ != 0) hash ^= HFDHEKDEIEJ.GetHashCode();
      if (KKBGHHEELGB != 0) hash ^= KKBGHHEELGB.GetHashCode();
      if (JIEICMMHLII != 0) hash ^= JIEICMMHLII.GetHashCode();
      if (CDBIGFMONLO != 0) hash ^= CDBIGFMONLO.GetHashCode();
      if (EPNDHNLMKHB != false) hash ^= EPNDHNLMKHB.GetHashCode();
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
      if (MNOIENHBLEC != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MNOIENHBLEC);
      }
      jPDINMOMDCI_.WriteTo(output, _repeated_jPDINMOMDCI_codec);
      if (KKBGHHEELGB != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(KKBGHHEELGB);
      }
      if (INLHHAJGBHN != false) {
        output.WriteRawTag(56);
        output.WriteBool(INLHHAJGBHN);
      }
      if (HFDHEKDEIEJ != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(HFDHEKDEIEJ);
      }
      if (JIEICMMHLII != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(JIEICMMHLII);
      }
      if (EPNDHNLMKHB != false) {
        output.WriteRawTag(112);
        output.WriteBool(EPNDHNLMKHB);
      }
      if (CDBIGFMONLO != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CDBIGFMONLO);
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
      if (MNOIENHBLEC != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MNOIENHBLEC);
      }
      jPDINMOMDCI_.WriteTo(ref output, _repeated_jPDINMOMDCI_codec);
      if (KKBGHHEELGB != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(KKBGHHEELGB);
      }
      if (INLHHAJGBHN != false) {
        output.WriteRawTag(56);
        output.WriteBool(INLHHAJGBHN);
      }
      if (HFDHEKDEIEJ != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(HFDHEKDEIEJ);
      }
      if (JIEICMMHLII != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(JIEICMMHLII);
      }
      if (EPNDHNLMKHB != false) {
        output.WriteRawTag(112);
        output.WriteBool(EPNDHNLMKHB);
      }
      if (CDBIGFMONLO != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CDBIGFMONLO);
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
      size += jPDINMOMDCI_.CalculateSize(_repeated_jPDINMOMDCI_codec);
      if (MNOIENHBLEC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MNOIENHBLEC);
      }
      if (INLHHAJGBHN != false) {
        size += 1 + 1;
      }
      if (HFDHEKDEIEJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HFDHEKDEIEJ);
      }
      if (KKBGHHEELGB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KKBGHHEELGB);
      }
      if (JIEICMMHLII != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JIEICMMHLII);
      }
      if (CDBIGFMONLO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CDBIGFMONLO);
      }
      if (EPNDHNLMKHB != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EGKMHKLMNKI other) {
      if (other == null) {
        return;
      }
      jPDINMOMDCI_.Add(other.jPDINMOMDCI_);
      if (other.MNOIENHBLEC != 0) {
        MNOIENHBLEC = other.MNOIENHBLEC;
      }
      if (other.INLHHAJGBHN != false) {
        INLHHAJGBHN = other.INLHHAJGBHN;
      }
      if (other.HFDHEKDEIEJ != 0) {
        HFDHEKDEIEJ = other.HFDHEKDEIEJ;
      }
      if (other.KKBGHHEELGB != 0) {
        KKBGHHEELGB = other.KKBGHHEELGB;
      }
      if (other.JIEICMMHLII != 0) {
        JIEICMMHLII = other.JIEICMMHLII;
      }
      if (other.CDBIGFMONLO != 0) {
        CDBIGFMONLO = other.CDBIGFMONLO;
      }
      if (other.EPNDHNLMKHB != false) {
        EPNDHNLMKHB = other.EPNDHNLMKHB;
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
          case 8: {
            MNOIENHBLEC = input.ReadUInt32();
            break;
          }
          case 34: {
            jPDINMOMDCI_.AddEntriesFrom(input, _repeated_jPDINMOMDCI_codec);
            break;
          }
          case 48: {
            KKBGHHEELGB = input.ReadUInt32();
            break;
          }
          case 56: {
            INLHHAJGBHN = input.ReadBool();
            break;
          }
          case 72: {
            HFDHEKDEIEJ = input.ReadUInt32();
            break;
          }
          case 80: {
            JIEICMMHLII = input.ReadUInt32();
            break;
          }
          case 112: {
            EPNDHNLMKHB = input.ReadBool();
            break;
          }
          case 120: {
            CDBIGFMONLO = input.ReadUInt32();
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
          case 8: {
            MNOIENHBLEC = input.ReadUInt32();
            break;
          }
          case 34: {
            jPDINMOMDCI_.AddEntriesFrom(ref input, _repeated_jPDINMOMDCI_codec);
            break;
          }
          case 48: {
            KKBGHHEELGB = input.ReadUInt32();
            break;
          }
          case 56: {
            INLHHAJGBHN = input.ReadBool();
            break;
          }
          case 72: {
            HFDHEKDEIEJ = input.ReadUInt32();
            break;
          }
          case 80: {
            JIEICMMHLII = input.ReadUInt32();
            break;
          }
          case 112: {
            EPNDHNLMKHB = input.ReadBool();
            break;
          }
          case 120: {
            CDBIGFMONLO = input.ReadUInt32();
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