// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SyncRogueCommonActionResultScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SyncRogueCommonActionResultScNotify.proto</summary>
  public static partial class SyncRogueCommonActionResultScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SyncRogueCommonActionResultScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SyncRogueCommonActionResultScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilTeW5jUm9ndWVDb21tb25BY3Rpb25SZXN1bHRTY05vdGlmeS5wcm90bxod",
            "Um9ndWVDb21tb25BY3Rpb25SZXN1bHQucHJvdG8aHFJvZ3VlQWN0aW9uRGlz",
            "cGxheVR5cGUucHJvdG8inwEKI1N5bmNSb2d1ZUNvbW1vbkFjdGlvblJlc3Vs",
            "dFNjTm90aWZ5EhgKEHJvZ3VlX3ZlcnNpb25faWQYDyABKA0SLwoNYWN0aW9u",
            "X3Jlc3VsdBgIIAMoCzIYLlJvZ3VlQ29tbW9uQWN0aW9uUmVzdWx0Ei0KDGRp",
            "c3BsYXlfdHlwZRgMIAEoDjIXLlJvZ3VlQWN0aW9uRGlzcGxheVR5cGVCHqoC",
            "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueCommonActionResultReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueActionDisplayTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SyncRogueCommonActionResultScNotify), global::EggLink.DanhengServer.Proto.SyncRogueCommonActionResultScNotify.Parser, new[]{ "RogueVersionId", "ActionResult", "DisplayType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SyncRogueCommonActionResultScNotify : pb::IMessage<SyncRogueCommonActionResultScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SyncRogueCommonActionResultScNotify> _parser = new pb::MessageParser<SyncRogueCommonActionResultScNotify>(() => new SyncRogueCommonActionResultScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SyncRogueCommonActionResultScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SyncRogueCommonActionResultScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncRogueCommonActionResultScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncRogueCommonActionResultScNotify(SyncRogueCommonActionResultScNotify other) : this() {
      rogueVersionId_ = other.rogueVersionId_;
      actionResult_ = other.actionResult_.Clone();
      displayType_ = other.displayType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncRogueCommonActionResultScNotify Clone() {
      return new SyncRogueCommonActionResultScNotify(this);
    }

    /// <summary>Field number for the "rogue_version_id" field.</summary>
    public const int RogueVersionIdFieldNumber = 15;
    private uint rogueVersionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RogueVersionId {
      get { return rogueVersionId_; }
      set {
        rogueVersionId_ = value;
      }
    }

    /// <summary>Field number for the "action_result" field.</summary>
    public const int ActionResultFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueCommonActionResult> _repeated_actionResult_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.RogueCommonActionResult.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonActionResult> actionResult_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonActionResult>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonActionResult> ActionResult {
      get { return actionResult_; }
    }

    /// <summary>Field number for the "display_type" field.</summary>
    public const int DisplayTypeFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.RogueActionDisplayType displayType_ = global::EggLink.DanhengServer.Proto.RogueActionDisplayType.RogueCommonActionResultDisplayTypeNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueActionDisplayType DisplayType {
      get { return displayType_; }
      set {
        displayType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SyncRogueCommonActionResultScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SyncRogueCommonActionResultScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RogueVersionId != other.RogueVersionId) return false;
      if(!actionResult_.Equals(other.actionResult_)) return false;
      if (DisplayType != other.DisplayType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RogueVersionId != 0) hash ^= RogueVersionId.GetHashCode();
      hash ^= actionResult_.GetHashCode();
      if (DisplayType != global::EggLink.DanhengServer.Proto.RogueActionDisplayType.RogueCommonActionResultDisplayTypeNone) hash ^= DisplayType.GetHashCode();
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
      actionResult_.WriteTo(output, _repeated_actionResult_codec);
      if (DisplayType != global::EggLink.DanhengServer.Proto.RogueActionDisplayType.RogueCommonActionResultDisplayTypeNone) {
        output.WriteRawTag(96);
        output.WriteEnum((int) DisplayType);
      }
      if (RogueVersionId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(RogueVersionId);
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
      actionResult_.WriteTo(ref output, _repeated_actionResult_codec);
      if (DisplayType != global::EggLink.DanhengServer.Proto.RogueActionDisplayType.RogueCommonActionResultDisplayTypeNone) {
        output.WriteRawTag(96);
        output.WriteEnum((int) DisplayType);
      }
      if (RogueVersionId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(RogueVersionId);
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
      if (RogueVersionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RogueVersionId);
      }
      size += actionResult_.CalculateSize(_repeated_actionResult_codec);
      if (DisplayType != global::EggLink.DanhengServer.Proto.RogueActionDisplayType.RogueCommonActionResultDisplayTypeNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DisplayType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SyncRogueCommonActionResultScNotify other) {
      if (other == null) {
        return;
      }
      if (other.RogueVersionId != 0) {
        RogueVersionId = other.RogueVersionId;
      }
      actionResult_.Add(other.actionResult_);
      if (other.DisplayType != global::EggLink.DanhengServer.Proto.RogueActionDisplayType.RogueCommonActionResultDisplayTypeNone) {
        DisplayType = other.DisplayType;
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
          case 66: {
            actionResult_.AddEntriesFrom(input, _repeated_actionResult_codec);
            break;
          }
          case 96: {
            DisplayType = (global::EggLink.DanhengServer.Proto.RogueActionDisplayType) input.ReadEnum();
            break;
          }
          case 120: {
            RogueVersionId = input.ReadUInt32();
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
          case 66: {
            actionResult_.AddEntriesFrom(ref input, _repeated_actionResult_codec);
            break;
          }
          case 96: {
            DisplayType = (global::EggLink.DanhengServer.Proto.RogueActionDisplayType) input.ReadEnum();
            break;
          }
          case 120: {
            RogueVersionId = input.ReadUInt32();
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
