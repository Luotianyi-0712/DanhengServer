// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HKJIDCGMKOG.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HKJIDCGMKOG.proto</summary>
  public static partial class HKJIDCGMKOGReflection {

    #region Descriptor
    /// <summary>File descriptor for HKJIDCGMKOG.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HKJIDCGMKOGReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFIS0pJRENHTUtPRy5wcm90bxoRQUFLT0FJTk5HSEsucHJvdG8aEUxKR0VD",
            "UEZKTk5ELnByb3RvIlMKC0hLSklEQ0dNS09HEiEKC0lPSE1NT01NR0FQGAYg",
            "ASgLMgwuQUFLT0FJTk5HSEsSIQoLRk9KSUNORUhES0wYBSABKAsyDC5MSkdF",
            "Q1BGSk5OREIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AAKOAINNGHKReflection.Descriptor, global::EggLink.DanhengServer.Proto.LJGECPFJNNDReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HKJIDCGMKOG), global::EggLink.DanhengServer.Proto.HKJIDCGMKOG.Parser, new[]{ "IOHMMOMMGAP", "FOJICNEHDKL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HKJIDCGMKOG : pb::IMessage<HKJIDCGMKOG>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HKJIDCGMKOG> _parser = new pb::MessageParser<HKJIDCGMKOG>(() => new HKJIDCGMKOG());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HKJIDCGMKOG> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HKJIDCGMKOGReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HKJIDCGMKOG() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HKJIDCGMKOG(HKJIDCGMKOG other) : this() {
      iOHMMOMMGAP_ = other.iOHMMOMMGAP_ != null ? other.iOHMMOMMGAP_.Clone() : null;
      fOJICNEHDKL_ = other.fOJICNEHDKL_ != null ? other.fOJICNEHDKL_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HKJIDCGMKOG Clone() {
      return new HKJIDCGMKOG(this);
    }

    /// <summary>Field number for the "IOHMMOMMGAP" field.</summary>
    public const int IOHMMOMMGAPFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.AAKOAINNGHK iOHMMOMMGAP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AAKOAINNGHK IOHMMOMMGAP {
      get { return iOHMMOMMGAP_; }
      set {
        iOHMMOMMGAP_ = value;
      }
    }

    /// <summary>Field number for the "FOJICNEHDKL" field.</summary>
    public const int FOJICNEHDKLFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.LJGECPFJNND fOJICNEHDKL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LJGECPFJNND FOJICNEHDKL {
      get { return fOJICNEHDKL_; }
      set {
        fOJICNEHDKL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HKJIDCGMKOG);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HKJIDCGMKOG other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(IOHMMOMMGAP, other.IOHMMOMMGAP)) return false;
      if (!object.Equals(FOJICNEHDKL, other.FOJICNEHDKL)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (iOHMMOMMGAP_ != null) hash ^= IOHMMOMMGAP.GetHashCode();
      if (fOJICNEHDKL_ != null) hash ^= FOJICNEHDKL.GetHashCode();
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
      if (fOJICNEHDKL_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(FOJICNEHDKL);
      }
      if (iOHMMOMMGAP_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(IOHMMOMMGAP);
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
      if (fOJICNEHDKL_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(FOJICNEHDKL);
      }
      if (iOHMMOMMGAP_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(IOHMMOMMGAP);
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
      if (iOHMMOMMGAP_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IOHMMOMMGAP);
      }
      if (fOJICNEHDKL_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FOJICNEHDKL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HKJIDCGMKOG other) {
      if (other == null) {
        return;
      }
      if (other.iOHMMOMMGAP_ != null) {
        if (iOHMMOMMGAP_ == null) {
          IOHMMOMMGAP = new global::EggLink.DanhengServer.Proto.AAKOAINNGHK();
        }
        IOHMMOMMGAP.MergeFrom(other.IOHMMOMMGAP);
      }
      if (other.fOJICNEHDKL_ != null) {
        if (fOJICNEHDKL_ == null) {
          FOJICNEHDKL = new global::EggLink.DanhengServer.Proto.LJGECPFJNND();
        }
        FOJICNEHDKL.MergeFrom(other.FOJICNEHDKL);
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
          case 42: {
            if (fOJICNEHDKL_ == null) {
              FOJICNEHDKL = new global::EggLink.DanhengServer.Proto.LJGECPFJNND();
            }
            input.ReadMessage(FOJICNEHDKL);
            break;
          }
          case 50: {
            if (iOHMMOMMGAP_ == null) {
              IOHMMOMMGAP = new global::EggLink.DanhengServer.Proto.AAKOAINNGHK();
            }
            input.ReadMessage(IOHMMOMMGAP);
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
          case 42: {
            if (fOJICNEHDKL_ == null) {
              FOJICNEHDKL = new global::EggLink.DanhengServer.Proto.LJGECPFJNND();
            }
            input.ReadMessage(FOJICNEHDKL);
            break;
          }
          case 50: {
            if (iOHMMOMMGAP_ == null) {
              IOHMMOMMGAP = new global::EggLink.DanhengServer.Proto.AAKOAINNGHK();
            }
            input.ReadMessage(IOHMMOMMGAP);
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
