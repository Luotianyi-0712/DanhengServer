// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MultipleDropInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MultipleDropInfoNotify.proto</summary>
  public static partial class MultipleDropInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for MultipleDropInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MultipleDropInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxNdWx0aXBsZURyb3BJbmZvTm90aWZ5LnByb3RvGhFFRUpKSVBKSEhETy5w",
            "cm90bxoRREtCS0lHSEhISkQucHJvdG8iXgoWTXVsdGlwbGVEcm9wSW5mb05v",
            "dGlmeRIhCgtGTk5ESkVLSkxOSxgIIAMoCzIMLkRLQktJR0hISEpEEiEKC0FD",
            "RktMSktHR0ZNGAEgAygLMgwuRUVKSklQSkhIRE9CHqoCG0VnZ0xpbmsuRGFu",
            "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.EEJJIPJHHDOReflection.Descriptor, global::EggLink.DanhengServer.Proto.DKBKIGHHHJDReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MultipleDropInfoNotify), global::EggLink.DanhengServer.Proto.MultipleDropInfoNotify.Parser, new[]{ "FNNDJEKJLNK", "ACFKLJKGGFM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MultipleDropInfoNotify : pb::IMessage<MultipleDropInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MultipleDropInfoNotify> _parser = new pb::MessageParser<MultipleDropInfoNotify>(() => new MultipleDropInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MultipleDropInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MultipleDropInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultipleDropInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultipleDropInfoNotify(MultipleDropInfoNotify other) : this() {
      fNNDJEKJLNK_ = other.fNNDJEKJLNK_.Clone();
      aCFKLJKGGFM_ = other.aCFKLJKGGFM_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultipleDropInfoNotify Clone() {
      return new MultipleDropInfoNotify(this);
    }

    /// <summary>Field number for the "FNNDJEKJLNK" field.</summary>
    public const int FNNDJEKJLNKFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DKBKIGHHHJD> _repeated_fNNDJEKJLNK_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.DKBKIGHHHJD.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DKBKIGHHHJD> fNNDJEKJLNK_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DKBKIGHHHJD>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DKBKIGHHHJD> FNNDJEKJLNK {
      get { return fNNDJEKJLNK_; }
    }

    /// <summary>Field number for the "ACFKLJKGGFM" field.</summary>
    public const int ACFKLJKGGFMFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.EEJJIPJHHDO> _repeated_aCFKLJKGGFM_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.EEJJIPJHHDO.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EEJJIPJHHDO> aCFKLJKGGFM_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EEJJIPJHHDO>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EEJJIPJHHDO> ACFKLJKGGFM {
      get { return aCFKLJKGGFM_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MultipleDropInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MultipleDropInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!fNNDJEKJLNK_.Equals(other.fNNDJEKJLNK_)) return false;
      if(!aCFKLJKGGFM_.Equals(other.aCFKLJKGGFM_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= fNNDJEKJLNK_.GetHashCode();
      hash ^= aCFKLJKGGFM_.GetHashCode();
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
      aCFKLJKGGFM_.WriteTo(output, _repeated_aCFKLJKGGFM_codec);
      fNNDJEKJLNK_.WriteTo(output, _repeated_fNNDJEKJLNK_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      aCFKLJKGGFM_.WriteTo(ref output, _repeated_aCFKLJKGGFM_codec);
      fNNDJEKJLNK_.WriteTo(ref output, _repeated_fNNDJEKJLNK_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += fNNDJEKJLNK_.CalculateSize(_repeated_fNNDJEKJLNK_codec);
      size += aCFKLJKGGFM_.CalculateSize(_repeated_aCFKLJKGGFM_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MultipleDropInfoNotify other) {
      if (other == null) {
        return;
      }
      fNNDJEKJLNK_.Add(other.fNNDJEKJLNK_);
      aCFKLJKGGFM_.Add(other.aCFKLJKGGFM_);
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
          case 10: {
            aCFKLJKGGFM_.AddEntriesFrom(input, _repeated_aCFKLJKGGFM_codec);
            break;
          }
          case 66: {
            fNNDJEKJLNK_.AddEntriesFrom(input, _repeated_fNNDJEKJLNK_codec);
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
          case 10: {
            aCFKLJKGGFM_.AddEntriesFrom(ref input, _repeated_aCFKLJKGGFM_codec);
            break;
          }
          case 66: {
            fNNDJEKJLNK_.AddEntriesFrom(ref input, _repeated_fNNDJEKJLNK_codec);
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