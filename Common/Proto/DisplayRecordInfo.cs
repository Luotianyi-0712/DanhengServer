// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DisplayRecordInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DisplayRecordInfo.proto</summary>
  public static partial class DisplayRecordInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for DisplayRecordInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DisplayRecordInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdEaXNwbGF5UmVjb3JkSW5mby5wcm90bxoaRGlzcGxheUNoYWxsZW5nZUlu",
            "Zm8ucHJvdG8ikwEKEURpc3BsYXlSZWNvcmRJbmZvEioKC1BPRkxPSEdISExM",
            "GAUgASgLMhUuRGlzcGxheUNoYWxsZW5nZUluZm8SEwoLQkFOTkVOREhBSkkY",
            "CyABKA0SEwoLS0hNREpOSUFNT00YASABKA0SEwoLSkJFRERKS0pJS0cYAyAB",
            "KA0SEwoLSUtBQkNFSk1QTUYYCCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.DisplayChallengeInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DisplayRecordInfo), global::EggLink.DanhengServer.Proto.DisplayRecordInfo.Parser, new[]{ "POFLOHGHHLL", "BANNENDHAJI", "KHMDJNIAMOM", "JBEDDJKJIKG", "IKABCEJMPMF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DisplayRecordInfo : pb::IMessage<DisplayRecordInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DisplayRecordInfo> _parser = new pb::MessageParser<DisplayRecordInfo>(() => new DisplayRecordInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DisplayRecordInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DisplayRecordInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayRecordInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayRecordInfo(DisplayRecordInfo other) : this() {
      pOFLOHGHHLL_ = other.pOFLOHGHHLL_ != null ? other.pOFLOHGHHLL_.Clone() : null;
      bANNENDHAJI_ = other.bANNENDHAJI_;
      kHMDJNIAMOM_ = other.kHMDJNIAMOM_;
      jBEDDJKJIKG_ = other.jBEDDJKJIKG_;
      iKABCEJMPMF_ = other.iKABCEJMPMF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayRecordInfo Clone() {
      return new DisplayRecordInfo(this);
    }

    /// <summary>Field number for the "POFLOHGHHLL" field.</summary>
    public const int POFLOHGHHLLFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.DisplayChallengeInfo pOFLOHGHHLL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DisplayChallengeInfo POFLOHGHHLL {
      get { return pOFLOHGHHLL_; }
      set {
        pOFLOHGHHLL_ = value;
      }
    }

    /// <summary>Field number for the "BANNENDHAJI" field.</summary>
    public const int BANNENDHAJIFieldNumber = 11;
    private uint bANNENDHAJI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BANNENDHAJI {
      get { return bANNENDHAJI_; }
      set {
        bANNENDHAJI_ = value;
      }
    }

    /// <summary>Field number for the "KHMDJNIAMOM" field.</summary>
    public const int KHMDJNIAMOMFieldNumber = 1;
    private uint kHMDJNIAMOM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KHMDJNIAMOM {
      get { return kHMDJNIAMOM_; }
      set {
        kHMDJNIAMOM_ = value;
      }
    }

    /// <summary>Field number for the "JBEDDJKJIKG" field.</summary>
    public const int JBEDDJKJIKGFieldNumber = 3;
    private uint jBEDDJKJIKG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JBEDDJKJIKG {
      get { return jBEDDJKJIKG_; }
      set {
        jBEDDJKJIKG_ = value;
      }
    }

    /// <summary>Field number for the "IKABCEJMPMF" field.</summary>
    public const int IKABCEJMPMFFieldNumber = 8;
    private uint iKABCEJMPMF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IKABCEJMPMF {
      get { return iKABCEJMPMF_; }
      set {
        iKABCEJMPMF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DisplayRecordInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DisplayRecordInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(POFLOHGHHLL, other.POFLOHGHHLL)) return false;
      if (BANNENDHAJI != other.BANNENDHAJI) return false;
      if (KHMDJNIAMOM != other.KHMDJNIAMOM) return false;
      if (JBEDDJKJIKG != other.JBEDDJKJIKG) return false;
      if (IKABCEJMPMF != other.IKABCEJMPMF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (pOFLOHGHHLL_ != null) hash ^= POFLOHGHHLL.GetHashCode();
      if (BANNENDHAJI != 0) hash ^= BANNENDHAJI.GetHashCode();
      if (KHMDJNIAMOM != 0) hash ^= KHMDJNIAMOM.GetHashCode();
      if (JBEDDJKJIKG != 0) hash ^= JBEDDJKJIKG.GetHashCode();
      if (IKABCEJMPMF != 0) hash ^= IKABCEJMPMF.GetHashCode();
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
      if (KHMDJNIAMOM != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KHMDJNIAMOM);
      }
      if (JBEDDJKJIKG != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(JBEDDJKJIKG);
      }
      if (pOFLOHGHHLL_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(POFLOHGHHLL);
      }
      if (IKABCEJMPMF != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(IKABCEJMPMF);
      }
      if (BANNENDHAJI != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(BANNENDHAJI);
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
      if (KHMDJNIAMOM != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KHMDJNIAMOM);
      }
      if (JBEDDJKJIKG != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(JBEDDJKJIKG);
      }
      if (pOFLOHGHHLL_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(POFLOHGHHLL);
      }
      if (IKABCEJMPMF != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(IKABCEJMPMF);
      }
      if (BANNENDHAJI != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(BANNENDHAJI);
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
      if (pOFLOHGHHLL_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(POFLOHGHHLL);
      }
      if (BANNENDHAJI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BANNENDHAJI);
      }
      if (KHMDJNIAMOM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KHMDJNIAMOM);
      }
      if (JBEDDJKJIKG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JBEDDJKJIKG);
      }
      if (IKABCEJMPMF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IKABCEJMPMF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DisplayRecordInfo other) {
      if (other == null) {
        return;
      }
      if (other.pOFLOHGHHLL_ != null) {
        if (pOFLOHGHHLL_ == null) {
          POFLOHGHHLL = new global::EggLink.DanhengServer.Proto.DisplayChallengeInfo();
        }
        POFLOHGHHLL.MergeFrom(other.POFLOHGHHLL);
      }
      if (other.BANNENDHAJI != 0) {
        BANNENDHAJI = other.BANNENDHAJI;
      }
      if (other.KHMDJNIAMOM != 0) {
        KHMDJNIAMOM = other.KHMDJNIAMOM;
      }
      if (other.JBEDDJKJIKG != 0) {
        JBEDDJKJIKG = other.JBEDDJKJIKG;
      }
      if (other.IKABCEJMPMF != 0) {
        IKABCEJMPMF = other.IKABCEJMPMF;
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
            KHMDJNIAMOM = input.ReadUInt32();
            break;
          }
          case 24: {
            JBEDDJKJIKG = input.ReadUInt32();
            break;
          }
          case 42: {
            if (pOFLOHGHHLL_ == null) {
              POFLOHGHHLL = new global::EggLink.DanhengServer.Proto.DisplayChallengeInfo();
            }
            input.ReadMessage(POFLOHGHHLL);
            break;
          }
          case 64: {
            IKABCEJMPMF = input.ReadUInt32();
            break;
          }
          case 88: {
            BANNENDHAJI = input.ReadUInt32();
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
            KHMDJNIAMOM = input.ReadUInt32();
            break;
          }
          case 24: {
            JBEDDJKJIKG = input.ReadUInt32();
            break;
          }
          case 42: {
            if (pOFLOHGHHLL_ == null) {
              POFLOHGHHLL = new global::EggLink.DanhengServer.Proto.DisplayChallengeInfo();
            }
            input.ReadMessage(POFLOHGHHLL);
            break;
          }
          case 64: {
            IKABCEJMPMF = input.ReadUInt32();
            break;
          }
          case 88: {
            BANNENDHAJI = input.ReadUInt32();
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
