// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterRogueEndlessActivityStageScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EnterRogueEndlessActivityStageScRsp.proto</summary>
  public static partial class EnterRogueEndlessActivityStageScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterRogueEndlessActivityStageScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterRogueEndlessActivityStageScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilFbnRlclJvZ3VlRW5kbGVzc0FjdGl2aXR5U3RhZ2VTY1JzcC5wcm90bxob",
            "Um9ndWVFbmRsZXNzTGF5ZXJJbmZvLnByb3RvGhVTY2VuZUJhdHRsZUluZm8u",
            "cHJvdG8iiQEKI0VudGVyUm9ndWVFbmRsZXNzQWN0aXZpdHlTdGFnZVNjUnNw",
            "EiUKC2JhdHRsZV9pbmZvGAkgASgLMhAuU2NlbmVCYXR0bGVJbmZvEioKCmxh",
            "eWVyX2luZm8YAiABKAsyFi5Sb2d1ZUVuZGxlc3NMYXllckluZm8SDwoHcmV0",
            "Y29kZRgKIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueEndlessLayerInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneBattleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EnterRogueEndlessActivityStageScRsp), global::EggLink.DanhengServer.Proto.EnterRogueEndlessActivityStageScRsp.Parser, new[]{ "BattleInfo", "LayerInfo", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EnterRogueEndlessActivityStageScRsp : pb::IMessage<EnterRogueEndlessActivityStageScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnterRogueEndlessActivityStageScRsp> _parser = new pb::MessageParser<EnterRogueEndlessActivityStageScRsp>(() => new EnterRogueEndlessActivityStageScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnterRogueEndlessActivityStageScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EnterRogueEndlessActivityStageScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterRogueEndlessActivityStageScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterRogueEndlessActivityStageScRsp(EnterRogueEndlessActivityStageScRsp other) : this() {
      battleInfo_ = other.battleInfo_ != null ? other.battleInfo_.Clone() : null;
      layerInfo_ = other.layerInfo_ != null ? other.layerInfo_.Clone() : null;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterRogueEndlessActivityStageScRsp Clone() {
      return new EnterRogueEndlessActivityStageScRsp(this);
    }

    /// <summary>Field number for the "battle_info" field.</summary>
    public const int BattleInfoFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.SceneBattleInfo battleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneBattleInfo BattleInfo {
      get { return battleInfo_; }
      set {
        battleInfo_ = value;
      }
    }

    /// <summary>Field number for the "layer_info" field.</summary>
    public const int LayerInfoFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.RogueEndlessLayerInfo layerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueEndlessLayerInfo LayerInfo {
      get { return layerInfo_; }
      set {
        layerInfo_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnterRogueEndlessActivityStageScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnterRogueEndlessActivityStageScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BattleInfo, other.BattleInfo)) return false;
      if (!object.Equals(LayerInfo, other.LayerInfo)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (battleInfo_ != null) hash ^= BattleInfo.GetHashCode();
      if (layerInfo_ != null) hash ^= LayerInfo.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (layerInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LayerInfo);
      }
      if (battleInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(BattleInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
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
      if (layerInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LayerInfo);
      }
      if (battleInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(BattleInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
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
      if (battleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleInfo);
      }
      if (layerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LayerInfo);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnterRogueEndlessActivityStageScRsp other) {
      if (other == null) {
        return;
      }
      if (other.battleInfo_ != null) {
        if (battleInfo_ == null) {
          BattleInfo = new global::EggLink.DanhengServer.Proto.SceneBattleInfo();
        }
        BattleInfo.MergeFrom(other.BattleInfo);
      }
      if (other.layerInfo_ != null) {
        if (layerInfo_ == null) {
          LayerInfo = new global::EggLink.DanhengServer.Proto.RogueEndlessLayerInfo();
        }
        LayerInfo.MergeFrom(other.LayerInfo);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 18: {
            if (layerInfo_ == null) {
              LayerInfo = new global::EggLink.DanhengServer.Proto.RogueEndlessLayerInfo();
            }
            input.ReadMessage(LayerInfo);
            break;
          }
          case 74: {
            if (battleInfo_ == null) {
              BattleInfo = new global::EggLink.DanhengServer.Proto.SceneBattleInfo();
            }
            input.ReadMessage(BattleInfo);
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
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
          case 18: {
            if (layerInfo_ == null) {
              LayerInfo = new global::EggLink.DanhengServer.Proto.RogueEndlessLayerInfo();
            }
            input.ReadMessage(LayerInfo);
            break;
          }
          case 74: {
            if (battleInfo_ == null) {
              BattleInfo = new global::EggLink.DanhengServer.Proto.SceneBattleInfo();
            }
            input.ReadMessage(BattleInfo);
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
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
