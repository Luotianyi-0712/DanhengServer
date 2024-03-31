// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueSyncContextBoardEvent.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueSyncContextBoardEvent.proto</summary>
  public static partial class RogueSyncContextBoardEventReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueSyncContextBoardEvent.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueSyncContextBoardEventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBSb2d1ZVN5bmNDb250ZXh0Qm9hcmRFdmVudC5wcm90byJSChpSb2d1ZVN5",
            "bmNDb250ZXh0Qm9hcmRFdmVudBIWCg5ib2FyZF9ldmVudF9pZBgNIAEoDRIc",
            "ChRtb2RpZmllcl9lZmZlY3RfdHlwZRgEIAEoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueSyncContextBoardEvent), global::EggLink.DanhengServer.Proto.RogueSyncContextBoardEvent.Parser, new[]{ "BoardEventId", "ModifierEffectType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueSyncContextBoardEvent : pb::IMessage<RogueSyncContextBoardEvent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueSyncContextBoardEvent> _parser = new pb::MessageParser<RogueSyncContextBoardEvent>(() => new RogueSyncContextBoardEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueSyncContextBoardEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueSyncContextBoardEventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueSyncContextBoardEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueSyncContextBoardEvent(RogueSyncContextBoardEvent other) : this() {
      boardEventId_ = other.boardEventId_;
      modifierEffectType_ = other.modifierEffectType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueSyncContextBoardEvent Clone() {
      return new RogueSyncContextBoardEvent(this);
    }

    /// <summary>Field number for the "board_event_id" field.</summary>
    public const int BoardEventIdFieldNumber = 13;
    private uint boardEventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BoardEventId {
      get { return boardEventId_; }
      set {
        boardEventId_ = value;
      }
    }

    /// <summary>Field number for the "modifier_effect_type" field.</summary>
    public const int ModifierEffectTypeFieldNumber = 4;
    private uint modifierEffectType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ModifierEffectType {
      get { return modifierEffectType_; }
      set {
        modifierEffectType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueSyncContextBoardEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueSyncContextBoardEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BoardEventId != other.BoardEventId) return false;
      if (ModifierEffectType != other.ModifierEffectType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BoardEventId != 0) hash ^= BoardEventId.GetHashCode();
      if (ModifierEffectType != 0) hash ^= ModifierEffectType.GetHashCode();
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
      if (ModifierEffectType != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ModifierEffectType);
      }
      if (BoardEventId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(BoardEventId);
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
      if (ModifierEffectType != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ModifierEffectType);
      }
      if (BoardEventId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(BoardEventId);
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
      if (BoardEventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BoardEventId);
      }
      if (ModifierEffectType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ModifierEffectType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueSyncContextBoardEvent other) {
      if (other == null) {
        return;
      }
      if (other.BoardEventId != 0) {
        BoardEventId = other.BoardEventId;
      }
      if (other.ModifierEffectType != 0) {
        ModifierEffectType = other.ModifierEffectType;
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
          case 32: {
            ModifierEffectType = input.ReadUInt32();
            break;
          }
          case 104: {
            BoardEventId = input.ReadUInt32();
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
          case 32: {
            ModifierEffectType = input.ReadUInt32();
            break;
          }
          case 104: {
            BoardEventId = input.ReadUInt32();
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
