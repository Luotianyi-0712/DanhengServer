// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AnnounceData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from AnnounceData.proto</summary>
  public static partial class AnnounceDataReflection {

    #region Descriptor
    /// <summary>File descriptor for AnnounceData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AnnounceDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJBbm5vdW5jZURhdGEucHJvdG8ixQEKDEFubm91bmNlRGF0YRITCgtNUEFD",
            "Q0lFREFDThgFIAEoCRITCgtHT0VPT0RFS0pESBgMIAEoCRITCgtISkJETEVE",
            "QktPUBgIIAEoDRIRCgljb25maWdfaWQYBiABKA0SEwoLSUlLTEdOSU1QQ0wY",
            "DSABKAkSEwoLSE5GQU1BS0xESEQYCSABKAgSEAoIZW5kX3RpbWUYCyABKAMS",
            "EgoKYmVnaW5fdGltZRgBIAEoAxITCgtITkdCSU5GQ0dDRhgCIAEoDUIeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.AnnounceData), global::EggLink.DanhengServer.Proto.AnnounceData.Parser, new[]{ "MPACCIEDACN", "GOEOODEKJDH", "HJBDLEDBKOP", "ConfigId", "IIKLGNIMPCL", "HNFAMAKLDHD", "EndTime", "BeginTime", "HNGBINFCGCF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AnnounceData : pb::IMessage<AnnounceData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AnnounceData> _parser = new pb::MessageParser<AnnounceData>(() => new AnnounceData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AnnounceData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.AnnounceDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnnounceData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnnounceData(AnnounceData other) : this() {
      mPACCIEDACN_ = other.mPACCIEDACN_;
      gOEOODEKJDH_ = other.gOEOODEKJDH_;
      hJBDLEDBKOP_ = other.hJBDLEDBKOP_;
      configId_ = other.configId_;
      iIKLGNIMPCL_ = other.iIKLGNIMPCL_;
      hNFAMAKLDHD_ = other.hNFAMAKLDHD_;
      endTime_ = other.endTime_;
      beginTime_ = other.beginTime_;
      hNGBINFCGCF_ = other.hNGBINFCGCF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnnounceData Clone() {
      return new AnnounceData(this);
    }

    /// <summary>Field number for the "MPACCIEDACN" field.</summary>
    public const int MPACCIEDACNFieldNumber = 5;
    private string mPACCIEDACN_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MPACCIEDACN {
      get { return mPACCIEDACN_; }
      set {
        mPACCIEDACN_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "GOEOODEKJDH" field.</summary>
    public const int GOEOODEKJDHFieldNumber = 12;
    private string gOEOODEKJDH_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GOEOODEKJDH {
      get { return gOEOODEKJDH_; }
      set {
        gOEOODEKJDH_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "HJBDLEDBKOP" field.</summary>
    public const int HJBDLEDBKOPFieldNumber = 8;
    private uint hJBDLEDBKOP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HJBDLEDBKOP {
      get { return hJBDLEDBKOP_; }
      set {
        hJBDLEDBKOP_ = value;
      }
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 6;
    private uint configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "IIKLGNIMPCL" field.</summary>
    public const int IIKLGNIMPCLFieldNumber = 13;
    private string iIKLGNIMPCL_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string IIKLGNIMPCL {
      get { return iIKLGNIMPCL_; }
      set {
        iIKLGNIMPCL_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "HNFAMAKLDHD" field.</summary>
    public const int HNFAMAKLDHDFieldNumber = 9;
    private bool hNFAMAKLDHD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HNFAMAKLDHD {
      get { return hNFAMAKLDHD_; }
      set {
        hNFAMAKLDHD_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 11;
    private long endTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "begin_time" field.</summary>
    public const int BeginTimeFieldNumber = 1;
    private long beginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long BeginTime {
      get { return beginTime_; }
      set {
        beginTime_ = value;
      }
    }

    /// <summary>Field number for the "HNGBINFCGCF" field.</summary>
    public const int HNGBINFCGCFFieldNumber = 2;
    private uint hNGBINFCGCF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HNGBINFCGCF {
      get { return hNGBINFCGCF_; }
      set {
        hNGBINFCGCF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AnnounceData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AnnounceData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MPACCIEDACN != other.MPACCIEDACN) return false;
      if (GOEOODEKJDH != other.GOEOODEKJDH) return false;
      if (HJBDLEDBKOP != other.HJBDLEDBKOP) return false;
      if (ConfigId != other.ConfigId) return false;
      if (IIKLGNIMPCL != other.IIKLGNIMPCL) return false;
      if (HNFAMAKLDHD != other.HNFAMAKLDHD) return false;
      if (EndTime != other.EndTime) return false;
      if (BeginTime != other.BeginTime) return false;
      if (HNGBINFCGCF != other.HNGBINFCGCF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MPACCIEDACN.Length != 0) hash ^= MPACCIEDACN.GetHashCode();
      if (GOEOODEKJDH.Length != 0) hash ^= GOEOODEKJDH.GetHashCode();
      if (HJBDLEDBKOP != 0) hash ^= HJBDLEDBKOP.GetHashCode();
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (IIKLGNIMPCL.Length != 0) hash ^= IIKLGNIMPCL.GetHashCode();
      if (HNFAMAKLDHD != false) hash ^= HNFAMAKLDHD.GetHashCode();
      if (EndTime != 0L) hash ^= EndTime.GetHashCode();
      if (BeginTime != 0L) hash ^= BeginTime.GetHashCode();
      if (HNGBINFCGCF != 0) hash ^= HNGBINFCGCF.GetHashCode();
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
      if (BeginTime != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(BeginTime);
      }
      if (HNGBINFCGCF != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(HNGBINFCGCF);
      }
      if (MPACCIEDACN.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(MPACCIEDACN);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ConfigId);
      }
      if (HJBDLEDBKOP != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(HJBDLEDBKOP);
      }
      if (HNFAMAKLDHD != false) {
        output.WriteRawTag(72);
        output.WriteBool(HNFAMAKLDHD);
      }
      if (EndTime != 0L) {
        output.WriteRawTag(88);
        output.WriteInt64(EndTime);
      }
      if (GOEOODEKJDH.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(GOEOODEKJDH);
      }
      if (IIKLGNIMPCL.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(IIKLGNIMPCL);
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
      if (BeginTime != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(BeginTime);
      }
      if (HNGBINFCGCF != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(HNGBINFCGCF);
      }
      if (MPACCIEDACN.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(MPACCIEDACN);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ConfigId);
      }
      if (HJBDLEDBKOP != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(HJBDLEDBKOP);
      }
      if (HNFAMAKLDHD != false) {
        output.WriteRawTag(72);
        output.WriteBool(HNFAMAKLDHD);
      }
      if (EndTime != 0L) {
        output.WriteRawTag(88);
        output.WriteInt64(EndTime);
      }
      if (GOEOODEKJDH.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(GOEOODEKJDH);
      }
      if (IIKLGNIMPCL.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(IIKLGNIMPCL);
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
      if (MPACCIEDACN.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MPACCIEDACN);
      }
      if (GOEOODEKJDH.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GOEOODEKJDH);
      }
      if (HJBDLEDBKOP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HJBDLEDBKOP);
      }
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
      }
      if (IIKLGNIMPCL.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IIKLGNIMPCL);
      }
      if (HNFAMAKLDHD != false) {
        size += 1 + 1;
      }
      if (EndTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(EndTime);
      }
      if (BeginTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BeginTime);
      }
      if (HNGBINFCGCF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HNGBINFCGCF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AnnounceData other) {
      if (other == null) {
        return;
      }
      if (other.MPACCIEDACN.Length != 0) {
        MPACCIEDACN = other.MPACCIEDACN;
      }
      if (other.GOEOODEKJDH.Length != 0) {
        GOEOODEKJDH = other.GOEOODEKJDH;
      }
      if (other.HJBDLEDBKOP != 0) {
        HJBDLEDBKOP = other.HJBDLEDBKOP;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.IIKLGNIMPCL.Length != 0) {
        IIKLGNIMPCL = other.IIKLGNIMPCL;
      }
      if (other.HNFAMAKLDHD != false) {
        HNFAMAKLDHD = other.HNFAMAKLDHD;
      }
      if (other.EndTime != 0L) {
        EndTime = other.EndTime;
      }
      if (other.BeginTime != 0L) {
        BeginTime = other.BeginTime;
      }
      if (other.HNGBINFCGCF != 0) {
        HNGBINFCGCF = other.HNGBINFCGCF;
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
            BeginTime = input.ReadInt64();
            break;
          }
          case 16: {
            HNGBINFCGCF = input.ReadUInt32();
            break;
          }
          case 42: {
            MPACCIEDACN = input.ReadString();
            break;
          }
          case 48: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 64: {
            HJBDLEDBKOP = input.ReadUInt32();
            break;
          }
          case 72: {
            HNFAMAKLDHD = input.ReadBool();
            break;
          }
          case 88: {
            EndTime = input.ReadInt64();
            break;
          }
          case 98: {
            GOEOODEKJDH = input.ReadString();
            break;
          }
          case 106: {
            IIKLGNIMPCL = input.ReadString();
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
            BeginTime = input.ReadInt64();
            break;
          }
          case 16: {
            HNGBINFCGCF = input.ReadUInt32();
            break;
          }
          case 42: {
            MPACCIEDACN = input.ReadString();
            break;
          }
          case 48: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 64: {
            HJBDLEDBKOP = input.ReadUInt32();
            break;
          }
          case 72: {
            HNFAMAKLDHD = input.ReadBool();
            break;
          }
          case 88: {
            EndTime = input.ReadInt64();
            break;
          }
          case 98: {
            GOEOODEKJDH = input.ReadString();
            break;
          }
          case 106: {
            IIKLGNIMPCL = input.ReadString();
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
