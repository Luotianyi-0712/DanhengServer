// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TreasureDungeonActivityData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TreasureDungeonActivityData.proto</summary>
  public static partial class TreasureDungeonActivityDataReflection {

    #region Descriptor
    /// <summary>File descriptor for TreasureDungeonActivityData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TreasureDungeonActivityDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFUcmVhc3VyZUR1bmdlb25BY3Rpdml0eURhdGEucHJvdG8isAEKG1RyZWFz",
            "dXJlRHVuZ2VvbkFjdGl2aXR5RGF0YRITCgtNTkZET0lFTkZPQRgFIAEoDRIT",
            "CgtEREVQQkpFQVBBShgBIAEoDRITCgtNQ0ZIUElGSURQTRgDIAEoDRITCgtG",
            "RUlQS0RQRElCShgJIAEoDRITCgtDSEZERElOREpGRhgOIAEoCBITCgtpc19m",
            "aW5pc2hlZBgHIAEoCBITCgtHUE9OTUdEQUJERBgKIAEoDUIeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TreasureDungeonActivityData), global::EggLink.DanhengServer.Proto.TreasureDungeonActivityData.Parser, new[]{ "MNFDOIENFOA", "DDEPBJEAPAJ", "MCFHPIFIDPM", "FEIPKDPDIBJ", "CHFDDINDJFF", "IsFinished", "GPONMGDABDD" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TreasureDungeonActivityData : pb::IMessage<TreasureDungeonActivityData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TreasureDungeonActivityData> _parser = new pb::MessageParser<TreasureDungeonActivityData>(() => new TreasureDungeonActivityData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TreasureDungeonActivityData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TreasureDungeonActivityDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureDungeonActivityData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureDungeonActivityData(TreasureDungeonActivityData other) : this() {
      mNFDOIENFOA_ = other.mNFDOIENFOA_;
      dDEPBJEAPAJ_ = other.dDEPBJEAPAJ_;
      mCFHPIFIDPM_ = other.mCFHPIFIDPM_;
      fEIPKDPDIBJ_ = other.fEIPKDPDIBJ_;
      cHFDDINDJFF_ = other.cHFDDINDJFF_;
      isFinished_ = other.isFinished_;
      gPONMGDABDD_ = other.gPONMGDABDD_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureDungeonActivityData Clone() {
      return new TreasureDungeonActivityData(this);
    }

    /// <summary>Field number for the "MNFDOIENFOA" field.</summary>
    public const int MNFDOIENFOAFieldNumber = 5;
    private uint mNFDOIENFOA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MNFDOIENFOA {
      get { return mNFDOIENFOA_; }
      set {
        mNFDOIENFOA_ = value;
      }
    }

    /// <summary>Field number for the "DDEPBJEAPAJ" field.</summary>
    public const int DDEPBJEAPAJFieldNumber = 1;
    private uint dDEPBJEAPAJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DDEPBJEAPAJ {
      get { return dDEPBJEAPAJ_; }
      set {
        dDEPBJEAPAJ_ = value;
      }
    }

    /// <summary>Field number for the "MCFHPIFIDPM" field.</summary>
    public const int MCFHPIFIDPMFieldNumber = 3;
    private uint mCFHPIFIDPM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MCFHPIFIDPM {
      get { return mCFHPIFIDPM_; }
      set {
        mCFHPIFIDPM_ = value;
      }
    }

    /// <summary>Field number for the "FEIPKDPDIBJ" field.</summary>
    public const int FEIPKDPDIBJFieldNumber = 9;
    private uint fEIPKDPDIBJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FEIPKDPDIBJ {
      get { return fEIPKDPDIBJ_; }
      set {
        fEIPKDPDIBJ_ = value;
      }
    }

    /// <summary>Field number for the "CHFDDINDJFF" field.</summary>
    public const int CHFDDINDJFFFieldNumber = 14;
    private bool cHFDDINDJFF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CHFDDINDJFF {
      get { return cHFDDINDJFF_; }
      set {
        cHFDDINDJFF_ = value;
      }
    }

    /// <summary>Field number for the "is_finished" field.</summary>
    public const int IsFinishedFieldNumber = 7;
    private bool isFinished_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinished {
      get { return isFinished_; }
      set {
        isFinished_ = value;
      }
    }

    /// <summary>Field number for the "GPONMGDABDD" field.</summary>
    public const int GPONMGDABDDFieldNumber = 10;
    private uint gPONMGDABDD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GPONMGDABDD {
      get { return gPONMGDABDD_; }
      set {
        gPONMGDABDD_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TreasureDungeonActivityData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TreasureDungeonActivityData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MNFDOIENFOA != other.MNFDOIENFOA) return false;
      if (DDEPBJEAPAJ != other.DDEPBJEAPAJ) return false;
      if (MCFHPIFIDPM != other.MCFHPIFIDPM) return false;
      if (FEIPKDPDIBJ != other.FEIPKDPDIBJ) return false;
      if (CHFDDINDJFF != other.CHFDDINDJFF) return false;
      if (IsFinished != other.IsFinished) return false;
      if (GPONMGDABDD != other.GPONMGDABDD) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MNFDOIENFOA != 0) hash ^= MNFDOIENFOA.GetHashCode();
      if (DDEPBJEAPAJ != 0) hash ^= DDEPBJEAPAJ.GetHashCode();
      if (MCFHPIFIDPM != 0) hash ^= MCFHPIFIDPM.GetHashCode();
      if (FEIPKDPDIBJ != 0) hash ^= FEIPKDPDIBJ.GetHashCode();
      if (CHFDDINDJFF != false) hash ^= CHFDDINDJFF.GetHashCode();
      if (IsFinished != false) hash ^= IsFinished.GetHashCode();
      if (GPONMGDABDD != 0) hash ^= GPONMGDABDD.GetHashCode();
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
      if (DDEPBJEAPAJ != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DDEPBJEAPAJ);
      }
      if (MCFHPIFIDPM != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(MCFHPIFIDPM);
      }
      if (MNFDOIENFOA != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MNFDOIENFOA);
      }
      if (IsFinished != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsFinished);
      }
      if (FEIPKDPDIBJ != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(FEIPKDPDIBJ);
      }
      if (GPONMGDABDD != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GPONMGDABDD);
      }
      if (CHFDDINDJFF != false) {
        output.WriteRawTag(112);
        output.WriteBool(CHFDDINDJFF);
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
      if (DDEPBJEAPAJ != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DDEPBJEAPAJ);
      }
      if (MCFHPIFIDPM != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(MCFHPIFIDPM);
      }
      if (MNFDOIENFOA != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MNFDOIENFOA);
      }
      if (IsFinished != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsFinished);
      }
      if (FEIPKDPDIBJ != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(FEIPKDPDIBJ);
      }
      if (GPONMGDABDD != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GPONMGDABDD);
      }
      if (CHFDDINDJFF != false) {
        output.WriteRawTag(112);
        output.WriteBool(CHFDDINDJFF);
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
      if (MNFDOIENFOA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MNFDOIENFOA);
      }
      if (DDEPBJEAPAJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DDEPBJEAPAJ);
      }
      if (MCFHPIFIDPM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MCFHPIFIDPM);
      }
      if (FEIPKDPDIBJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FEIPKDPDIBJ);
      }
      if (CHFDDINDJFF != false) {
        size += 1 + 1;
      }
      if (IsFinished != false) {
        size += 1 + 1;
      }
      if (GPONMGDABDD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GPONMGDABDD);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TreasureDungeonActivityData other) {
      if (other == null) {
        return;
      }
      if (other.MNFDOIENFOA != 0) {
        MNFDOIENFOA = other.MNFDOIENFOA;
      }
      if (other.DDEPBJEAPAJ != 0) {
        DDEPBJEAPAJ = other.DDEPBJEAPAJ;
      }
      if (other.MCFHPIFIDPM != 0) {
        MCFHPIFIDPM = other.MCFHPIFIDPM;
      }
      if (other.FEIPKDPDIBJ != 0) {
        FEIPKDPDIBJ = other.FEIPKDPDIBJ;
      }
      if (other.CHFDDINDJFF != false) {
        CHFDDINDJFF = other.CHFDDINDJFF;
      }
      if (other.IsFinished != false) {
        IsFinished = other.IsFinished;
      }
      if (other.GPONMGDABDD != 0) {
        GPONMGDABDD = other.GPONMGDABDD;
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
            DDEPBJEAPAJ = input.ReadUInt32();
            break;
          }
          case 24: {
            MCFHPIFIDPM = input.ReadUInt32();
            break;
          }
          case 40: {
            MNFDOIENFOA = input.ReadUInt32();
            break;
          }
          case 56: {
            IsFinished = input.ReadBool();
            break;
          }
          case 72: {
            FEIPKDPDIBJ = input.ReadUInt32();
            break;
          }
          case 80: {
            GPONMGDABDD = input.ReadUInt32();
            break;
          }
          case 112: {
            CHFDDINDJFF = input.ReadBool();
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
            DDEPBJEAPAJ = input.ReadUInt32();
            break;
          }
          case 24: {
            MCFHPIFIDPM = input.ReadUInt32();
            break;
          }
          case 40: {
            MNFDOIENFOA = input.ReadUInt32();
            break;
          }
          case 56: {
            IsFinished = input.ReadBool();
            break;
          }
          case 72: {
            FEIPKDPDIBJ = input.ReadUInt32();
            break;
          }
          case 80: {
            GPONMGDABDD = input.ReadUInt32();
            break;
          }
          case 112: {
            CHFDDINDJFF = input.ReadBool();
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
