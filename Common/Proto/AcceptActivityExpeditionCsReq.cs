// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AcceptActivityExpeditionCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from AcceptActivityExpeditionCsReq.proto</summary>
  public static partial class AcceptActivityExpeditionCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for AcceptActivityExpeditionCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AcceptActivityExpeditionCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNBY2NlcHRBY3Rpdml0eUV4cGVkaXRpb25Dc1JlcS5wcm90bxoYQWN0aXZp",
            "dHlFeHBlZGl0aW9uLnByb3RvIlEKHUFjY2VwdEFjdGl2aXR5RXhwZWRpdGlv",
            "bkNzUmVxEjAKE2FjdGl2aXR5X2V4cGVkaXRpb24YBCABKAsyEy5BY3Rpdml0",
            "eUV4cGVkaXRpb25CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ActivityExpeditionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.AcceptActivityExpeditionCsReq), global::EggLink.DanhengServer.Proto.AcceptActivityExpeditionCsReq.Parser, new[]{ "ActivityExpedition" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AcceptActivityExpeditionCsReq : pb::IMessage<AcceptActivityExpeditionCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AcceptActivityExpeditionCsReq> _parser = new pb::MessageParser<AcceptActivityExpeditionCsReq>(() => new AcceptActivityExpeditionCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AcceptActivityExpeditionCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.AcceptActivityExpeditionCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AcceptActivityExpeditionCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AcceptActivityExpeditionCsReq(AcceptActivityExpeditionCsReq other) : this() {
      activityExpedition_ = other.activityExpedition_ != null ? other.activityExpedition_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AcceptActivityExpeditionCsReq Clone() {
      return new AcceptActivityExpeditionCsReq(this);
    }

    /// <summary>Field number for the "activity_expedition" field.</summary>
    public const int ActivityExpeditionFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.ActivityExpedition activityExpedition_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ActivityExpedition ActivityExpedition {
      get { return activityExpedition_; }
      set {
        activityExpedition_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AcceptActivityExpeditionCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AcceptActivityExpeditionCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ActivityExpedition, other.ActivityExpedition)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (activityExpedition_ != null) hash ^= ActivityExpedition.GetHashCode();
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
      if (activityExpedition_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ActivityExpedition);
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
      if (activityExpedition_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ActivityExpedition);
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
      if (activityExpedition_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ActivityExpedition);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AcceptActivityExpeditionCsReq other) {
      if (other == null) {
        return;
      }
      if (other.activityExpedition_ != null) {
        if (activityExpedition_ == null) {
          ActivityExpedition = new global::EggLink.DanhengServer.Proto.ActivityExpedition();
        }
        ActivityExpedition.MergeFrom(other.ActivityExpedition);
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
          case 34: {
            if (activityExpedition_ == null) {
              ActivityExpedition = new global::EggLink.DanhengServer.Proto.ActivityExpedition();
            }
            input.ReadMessage(ActivityExpedition);
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
          case 34: {
            if (activityExpedition_ == null) {
              ActivityExpedition = new global::EggLink.DanhengServer.Proto.ActivityExpedition();
            }
            input.ReadMessage(ActivityExpedition);
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