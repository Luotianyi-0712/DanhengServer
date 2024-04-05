// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterSceneByServerScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EnterSceneByServerScNotify.proto</summary>
  public static partial class EnterSceneByServerScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterSceneByServerScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterSceneByServerScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBFbnRlclNjZW5lQnlTZXJ2ZXJTY05vdGlmeS5wcm90bxocRW50ZXJTY2Vu",
            "ZVJlYXNvblN0YXR1cy5wcm90bxoQTGluZXVwSW5mby5wcm90bxoPU2NlbmVJ",
            "bmZvLnByb3RvIn0KGkVudGVyU2NlbmVCeVNlcnZlclNjTm90aWZ5EhkKBXNj",
            "ZW5lGAQgASgLMgouU2NlbmVJbmZvEicKBnJlYXNvbhgKIAEoDjIXLkVudGVy",
            "U2NlbmVSZWFzb25TdGF0dXMSGwoGbGluZXVwGAsgASgLMgsuTGluZXVwSW5m",
            "b0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.EnterSceneReasonStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.LineupInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EnterSceneByServerScNotify), global::EggLink.DanhengServer.Proto.EnterSceneByServerScNotify.Parser, new[]{ "Scene", "Reason", "Lineup" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EnterSceneByServerScNotify : pb::IMessage<EnterSceneByServerScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnterSceneByServerScNotify> _parser = new pb::MessageParser<EnterSceneByServerScNotify>(() => new EnterSceneByServerScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnterSceneByServerScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EnterSceneByServerScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterSceneByServerScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterSceneByServerScNotify(EnterSceneByServerScNotify other) : this() {
      scene_ = other.scene_ != null ? other.scene_.Clone() : null;
      reason_ = other.reason_;
      lineup_ = other.lineup_ != null ? other.lineup_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterSceneByServerScNotify Clone() {
      return new EnterSceneByServerScNotify(this);
    }

    /// <summary>Field number for the "scene" field.</summary>
    public const int SceneFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.SceneInfo scene_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneInfo Scene {
      get { return scene_; }
      set {
        scene_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.EnterSceneReasonStatus reason_ = global::EggLink.DanhengServer.Proto.EnterSceneReasonStatus.EnterSceneReasonNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EnterSceneReasonStatus Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "lineup" field.</summary>
    public const int LineupFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.LineupInfo lineup_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LineupInfo Lineup {
      get { return lineup_; }
      set {
        lineup_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnterSceneByServerScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnterSceneByServerScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Scene, other.Scene)) return false;
      if (Reason != other.Reason) return false;
      if (!object.Equals(Lineup, other.Lineup)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (scene_ != null) hash ^= Scene.GetHashCode();
      if (Reason != global::EggLink.DanhengServer.Proto.EnterSceneReasonStatus.EnterSceneReasonNone) hash ^= Reason.GetHashCode();
      if (lineup_ != null) hash ^= Lineup.GetHashCode();
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
      if (scene_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Scene);
      }
      if (Reason != global::EggLink.DanhengServer.Proto.EnterSceneReasonStatus.EnterSceneReasonNone) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Reason);
      }
      if (lineup_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Lineup);
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
      if (scene_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Scene);
      }
      if (Reason != global::EggLink.DanhengServer.Proto.EnterSceneReasonStatus.EnterSceneReasonNone) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Reason);
      }
      if (lineup_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Lineup);
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
      if (scene_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Scene);
      }
      if (Reason != global::EggLink.DanhengServer.Proto.EnterSceneReasonStatus.EnterSceneReasonNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (lineup_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Lineup);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnterSceneByServerScNotify other) {
      if (other == null) {
        return;
      }
      if (other.scene_ != null) {
        if (scene_ == null) {
          Scene = new global::EggLink.DanhengServer.Proto.SceneInfo();
        }
        Scene.MergeFrom(other.Scene);
      }
      if (other.Reason != global::EggLink.DanhengServer.Proto.EnterSceneReasonStatus.EnterSceneReasonNone) {
        Reason = other.Reason;
      }
      if (other.lineup_ != null) {
        if (lineup_ == null) {
          Lineup = new global::EggLink.DanhengServer.Proto.LineupInfo();
        }
        Lineup.MergeFrom(other.Lineup);
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
            if (scene_ == null) {
              Scene = new global::EggLink.DanhengServer.Proto.SceneInfo();
            }
            input.ReadMessage(Scene);
            break;
          }
          case 80: {
            Reason = (global::EggLink.DanhengServer.Proto.EnterSceneReasonStatus) input.ReadEnum();
            break;
          }
          case 90: {
            if (lineup_ == null) {
              Lineup = new global::EggLink.DanhengServer.Proto.LineupInfo();
            }
            input.ReadMessage(Lineup);
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
            if (scene_ == null) {
              Scene = new global::EggLink.DanhengServer.Proto.SceneInfo();
            }
            input.ReadMessage(Scene);
            break;
          }
          case 80: {
            Reason = (global::EggLink.DanhengServer.Proto.EnterSceneReasonStatus) input.ReadEnum();
            break;
          }
          case 90: {
            if (lineup_ == null) {
              Lineup = new global::EggLink.DanhengServer.Proto.LineupInfo();
            }
            input.ReadMessage(Lineup);
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
