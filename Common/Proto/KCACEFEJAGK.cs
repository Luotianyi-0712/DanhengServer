// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: KCACEFEJAGK.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from KCACEFEJAGK.proto</summary>
  public static partial class KCACEFEJAGKReflection {

    #region Descriptor
    /// <summary>File descriptor for KCACEFEJAGK.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KCACEFEJAGKReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFLQ0FDRUZFSkFHSy5wcm90byI3CgtLQ0FDRUZFSkFHSxITCgtKRk9CSkhD",
            "TUxDQxgPIAEoDRITCgtLS0ZHSkFBR1BJSRgBIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.KCACEFEJAGK), global::EggLink.DanhengServer.Proto.KCACEFEJAGK.Parser, new[]{ "JFOBJHCMLCC", "KKFGJAAGPII" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class KCACEFEJAGK : pb::IMessage<KCACEFEJAGK>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KCACEFEJAGK> _parser = new pb::MessageParser<KCACEFEJAGK>(() => new KCACEFEJAGK());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KCACEFEJAGK> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.KCACEFEJAGKReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KCACEFEJAGK() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KCACEFEJAGK(KCACEFEJAGK other) : this() {
      jFOBJHCMLCC_ = other.jFOBJHCMLCC_;
      kKFGJAAGPII_ = other.kKFGJAAGPII_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KCACEFEJAGK Clone() {
      return new KCACEFEJAGK(this);
    }

    /// <summary>Field number for the "JFOBJHCMLCC" field.</summary>
    public const int JFOBJHCMLCCFieldNumber = 15;
    private uint jFOBJHCMLCC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JFOBJHCMLCC {
      get { return jFOBJHCMLCC_; }
      set {
        jFOBJHCMLCC_ = value;
      }
    }

    /// <summary>Field number for the "KKFGJAAGPII" field.</summary>
    public const int KKFGJAAGPIIFieldNumber = 1;
    private uint kKFGJAAGPII_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KKFGJAAGPII {
      get { return kKFGJAAGPII_; }
      set {
        kKFGJAAGPII_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KCACEFEJAGK);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KCACEFEJAGK other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JFOBJHCMLCC != other.JFOBJHCMLCC) return false;
      if (KKFGJAAGPII != other.KKFGJAAGPII) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (JFOBJHCMLCC != 0) hash ^= JFOBJHCMLCC.GetHashCode();
      if (KKFGJAAGPII != 0) hash ^= KKFGJAAGPII.GetHashCode();
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
      if (KKFGJAAGPII != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KKFGJAAGPII);
      }
      if (JFOBJHCMLCC != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(JFOBJHCMLCC);
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
      if (KKFGJAAGPII != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KKFGJAAGPII);
      }
      if (JFOBJHCMLCC != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(JFOBJHCMLCC);
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
      if (JFOBJHCMLCC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JFOBJHCMLCC);
      }
      if (KKFGJAAGPII != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KKFGJAAGPII);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(KCACEFEJAGK other) {
      if (other == null) {
        return;
      }
      if (other.JFOBJHCMLCC != 0) {
        JFOBJHCMLCC = other.JFOBJHCMLCC;
      }
      if (other.KKFGJAAGPII != 0) {
        KKFGJAAGPII = other.KKFGJAAGPII;
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
            KKFGJAAGPII = input.ReadUInt32();
            break;
          }
          case 120: {
            JFOBJHCMLCC = input.ReadUInt32();
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
            KKFGJAAGPII = input.ReadUInt32();
            break;
          }
          case 120: {
            JFOBJHCMLCC = input.ReadUInt32();
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
