// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TrialActivityDataChangeScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TrialActivityDataChangeScNotify.proto</summary>
  public static partial class TrialActivityDataChangeScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for TrialActivityDataChangeScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrialActivityDataChangeScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVUcmlhbEFjdGl2aXR5RGF0YUNoYW5nZVNjTm90aWZ5LnByb3RvGhdUcmlh",
            "bEFjdGl2aXR5SW5mby5wcm90byJKCh9UcmlhbEFjdGl2aXR5RGF0YUNoYW5n",
            "ZVNjTm90aWZ5EicKC0VORUFGREdQRk5OGAUgASgLMhIuVHJpYWxBY3Rpdml0",
            "eUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.TrialActivityInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TrialActivityDataChangeScNotify), global::EggLink.DanhengServer.Proto.TrialActivityDataChangeScNotify.Parser, new[]{ "ENEAFDGPFNN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TrialActivityDataChangeScNotify : pb::IMessage<TrialActivityDataChangeScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TrialActivityDataChangeScNotify> _parser = new pb::MessageParser<TrialActivityDataChangeScNotify>(() => new TrialActivityDataChangeScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TrialActivityDataChangeScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TrialActivityDataChangeScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrialActivityDataChangeScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrialActivityDataChangeScNotify(TrialActivityDataChangeScNotify other) : this() {
      eNEAFDGPFNN_ = other.eNEAFDGPFNN_ != null ? other.eNEAFDGPFNN_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrialActivityDataChangeScNotify Clone() {
      return new TrialActivityDataChangeScNotify(this);
    }

    /// <summary>Field number for the "ENEAFDGPFNN" field.</summary>
    public const int ENEAFDGPFNNFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.TrialActivityInfo eNEAFDGPFNN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.TrialActivityInfo ENEAFDGPFNN {
      get { return eNEAFDGPFNN_; }
      set {
        eNEAFDGPFNN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TrialActivityDataChangeScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TrialActivityDataChangeScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ENEAFDGPFNN, other.ENEAFDGPFNN)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (eNEAFDGPFNN_ != null) hash ^= ENEAFDGPFNN.GetHashCode();
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
      if (eNEAFDGPFNN_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ENEAFDGPFNN);
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
      if (eNEAFDGPFNN_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ENEAFDGPFNN);
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
      if (eNEAFDGPFNN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ENEAFDGPFNN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TrialActivityDataChangeScNotify other) {
      if (other == null) {
        return;
      }
      if (other.eNEAFDGPFNN_ != null) {
        if (eNEAFDGPFNN_ == null) {
          ENEAFDGPFNN = new global::EggLink.DanhengServer.Proto.TrialActivityInfo();
        }
        ENEAFDGPFNN.MergeFrom(other.ENEAFDGPFNN);
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
            if (eNEAFDGPFNN_ == null) {
              ENEAFDGPFNN = new global::EggLink.DanhengServer.Proto.TrialActivityInfo();
            }
            input.ReadMessage(ENEAFDGPFNN);
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
            if (eNEAFDGPFNN_ == null) {
              ENEAFDGPFNN = new global::EggLink.DanhengServer.Proto.TrialActivityInfo();
            }
            input.ReadMessage(ENEAFDGPFNN);
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
