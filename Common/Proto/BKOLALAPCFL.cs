// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BKOLALAPCFL.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BKOLALAPCFL.proto</summary>
  public static partial class BKOLALAPCFLReflection {

    #region Descriptor
    /// <summary>File descriptor for BKOLALAPCFL.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BKOLALAPCFLReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFCS09MQUxBUENGTC5wcm90byI3CgtCS09MQUxBUENGTBITCgtGT0RNT09Q",
            "SkJLUBgIIAEoDRITCgtPT0VKSUlBRFBQRRgHIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BKOLALAPCFL), global::EggLink.DanhengServer.Proto.BKOLALAPCFL.Parser, new[]{ "FODMOOPJBKP", "OOEJIIADPPE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BKOLALAPCFL : pb::IMessage<BKOLALAPCFL>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BKOLALAPCFL> _parser = new pb::MessageParser<BKOLALAPCFL>(() => new BKOLALAPCFL());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BKOLALAPCFL> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BKOLALAPCFLReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BKOLALAPCFL() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BKOLALAPCFL(BKOLALAPCFL other) : this() {
      fODMOOPJBKP_ = other.fODMOOPJBKP_;
      oOEJIIADPPE_ = other.oOEJIIADPPE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BKOLALAPCFL Clone() {
      return new BKOLALAPCFL(this);
    }

    /// <summary>Field number for the "FODMOOPJBKP" field.</summary>
    public const int FODMOOPJBKPFieldNumber = 8;
    private uint fODMOOPJBKP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FODMOOPJBKP {
      get { return fODMOOPJBKP_; }
      set {
        fODMOOPJBKP_ = value;
      }
    }

    /// <summary>Field number for the "OOEJIIADPPE" field.</summary>
    public const int OOEJIIADPPEFieldNumber = 7;
    private uint oOEJIIADPPE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OOEJIIADPPE {
      get { return oOEJIIADPPE_; }
      set {
        oOEJIIADPPE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BKOLALAPCFL);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BKOLALAPCFL other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FODMOOPJBKP != other.FODMOOPJBKP) return false;
      if (OOEJIIADPPE != other.OOEJIIADPPE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FODMOOPJBKP != 0) hash ^= FODMOOPJBKP.GetHashCode();
      if (OOEJIIADPPE != 0) hash ^= OOEJIIADPPE.GetHashCode();
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
      if (OOEJIIADPPE != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(OOEJIIADPPE);
      }
      if (FODMOOPJBKP != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(FODMOOPJBKP);
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
      if (OOEJIIADPPE != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(OOEJIIADPPE);
      }
      if (FODMOOPJBKP != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(FODMOOPJBKP);
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
      if (FODMOOPJBKP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FODMOOPJBKP);
      }
      if (OOEJIIADPPE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OOEJIIADPPE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BKOLALAPCFL other) {
      if (other == null) {
        return;
      }
      if (other.FODMOOPJBKP != 0) {
        FODMOOPJBKP = other.FODMOOPJBKP;
      }
      if (other.OOEJIIADPPE != 0) {
        OOEJIIADPPE = other.OOEJIIADPPE;
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
          case 56: {
            OOEJIIADPPE = input.ReadUInt32();
            break;
          }
          case 64: {
            FODMOOPJBKP = input.ReadUInt32();
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
          case 56: {
            OOEJIIADPPE = input.ReadUInt32();
            break;
          }
          case 64: {
            FODMOOPJBKP = input.ReadUInt32();
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