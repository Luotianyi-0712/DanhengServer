// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueGetInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueGetInfo.proto</summary>
  public static partial class RogueGetInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueGetInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueGetInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJSb2d1ZUdldEluZm8ucHJvdG8aGlJvZ3VlVmlydHVhbEl0ZW1JbmZvLnBy",
            "b3RvGhpSb2d1ZVNjb3JlUmV3YXJkSW5mby5wcm90bxoTUm9ndWVBZW9uSW5m",
            "by5wcm90bxoTUm9ndWVBcmVhSW5mby5wcm90bxoVUm9ndWVTZWFzb25JbmZv",
            "LnByb3RvIv0BCgxSb2d1ZUdldEluZm8SNgoXcm9ndWVfc2NvcmVfcmV3YXJk",
            "X2luZm8YDyABKAsyFS5Sb2d1ZVNjb3JlUmV3YXJkSW5mbxInCg9yb2d1ZV9h",
            "ZW9uX2luZm8YCCABKAsyDi5Sb2d1ZUFlb25JbmZvEicKD3JvZ3VlX2FyZWFf",
            "aW5mbxgLIAEoCzIOLlJvZ3VlQXJlYUluZm8SNgoXcm9ndWVfdmlydHVhbF9p",
            "dGVtX2luZm8YCSABKAsyFS5Sb2d1ZVZpcnR1YWxJdGVtSW5mbxIrChFyb2d1",
            "ZV9zZWFzb25faW5mbxgMIAEoCzIQLlJvZ3VlU2Vhc29uSW5mb0IeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueVirtualItemInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueScoreRewardInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueAeonInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueAreaInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueSeasonInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueGetInfo), global::EggLink.DanhengServer.Proto.RogueGetInfo.Parser, new[]{ "RogueScoreRewardInfo", "RogueAeonInfo", "RogueAreaInfo", "RogueVirtualItemInfo", "RogueSeasonInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueGetInfo : pb::IMessage<RogueGetInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueGetInfo> _parser = new pb::MessageParser<RogueGetInfo>(() => new RogueGetInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueGetInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueGetInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueGetInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueGetInfo(RogueGetInfo other) : this() {
      rogueScoreRewardInfo_ = other.rogueScoreRewardInfo_ != null ? other.rogueScoreRewardInfo_.Clone() : null;
      rogueAeonInfo_ = other.rogueAeonInfo_ != null ? other.rogueAeonInfo_.Clone() : null;
      rogueAreaInfo_ = other.rogueAreaInfo_ != null ? other.rogueAreaInfo_.Clone() : null;
      rogueVirtualItemInfo_ = other.rogueVirtualItemInfo_ != null ? other.rogueVirtualItemInfo_.Clone() : null;
      rogueSeasonInfo_ = other.rogueSeasonInfo_ != null ? other.rogueSeasonInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueGetInfo Clone() {
      return new RogueGetInfo(this);
    }

    /// <summary>Field number for the "rogue_score_reward_info" field.</summary>
    public const int RogueScoreRewardInfoFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo rogueScoreRewardInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo RogueScoreRewardInfo {
      get { return rogueScoreRewardInfo_; }
      set {
        rogueScoreRewardInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_aeon_info" field.</summary>
    public const int RogueAeonInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.RogueAeonInfo rogueAeonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueAeonInfo RogueAeonInfo {
      get { return rogueAeonInfo_; }
      set {
        rogueAeonInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_area_info" field.</summary>
    public const int RogueAreaInfoFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.RogueAreaInfo rogueAreaInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueAreaInfo RogueAreaInfo {
      get { return rogueAreaInfo_; }
      set {
        rogueAreaInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_virtual_item_info" field.</summary>
    public const int RogueVirtualItemInfoFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.RogueVirtualItemInfo rogueVirtualItemInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueVirtualItemInfo RogueVirtualItemInfo {
      get { return rogueVirtualItemInfo_; }
      set {
        rogueVirtualItemInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_season_info" field.</summary>
    public const int RogueSeasonInfoFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.RogueSeasonInfo rogueSeasonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueSeasonInfo RogueSeasonInfo {
      get { return rogueSeasonInfo_; }
      set {
        rogueSeasonInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueGetInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueGetInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueScoreRewardInfo, other.RogueScoreRewardInfo)) return false;
      if (!object.Equals(RogueAeonInfo, other.RogueAeonInfo)) return false;
      if (!object.Equals(RogueAreaInfo, other.RogueAreaInfo)) return false;
      if (!object.Equals(RogueVirtualItemInfo, other.RogueVirtualItemInfo)) return false;
      if (!object.Equals(RogueSeasonInfo, other.RogueSeasonInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueScoreRewardInfo_ != null) hash ^= RogueScoreRewardInfo.GetHashCode();
      if (rogueAeonInfo_ != null) hash ^= RogueAeonInfo.GetHashCode();
      if (rogueAreaInfo_ != null) hash ^= RogueAreaInfo.GetHashCode();
      if (rogueVirtualItemInfo_ != null) hash ^= RogueVirtualItemInfo.GetHashCode();
      if (rogueSeasonInfo_ != null) hash ^= RogueSeasonInfo.GetHashCode();
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
      if (rogueAeonInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RogueAeonInfo);
      }
      if (rogueVirtualItemInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RogueVirtualItemInfo);
      }
      if (rogueAreaInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueAreaInfo);
      }
      if (rogueSeasonInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(RogueSeasonInfo);
      }
      if (rogueScoreRewardInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueScoreRewardInfo);
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
      if (rogueAeonInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RogueAeonInfo);
      }
      if (rogueVirtualItemInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RogueVirtualItemInfo);
      }
      if (rogueAreaInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueAreaInfo);
      }
      if (rogueSeasonInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(RogueSeasonInfo);
      }
      if (rogueScoreRewardInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueScoreRewardInfo);
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
      if (rogueScoreRewardInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueScoreRewardInfo);
      }
      if (rogueAeonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueAeonInfo);
      }
      if (rogueAreaInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueAreaInfo);
      }
      if (rogueVirtualItemInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueVirtualItemInfo);
      }
      if (rogueSeasonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueSeasonInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueGetInfo other) {
      if (other == null) {
        return;
      }
      if (other.rogueScoreRewardInfo_ != null) {
        if (rogueScoreRewardInfo_ == null) {
          RogueScoreRewardInfo = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
        }
        RogueScoreRewardInfo.MergeFrom(other.RogueScoreRewardInfo);
      }
      if (other.rogueAeonInfo_ != null) {
        if (rogueAeonInfo_ == null) {
          RogueAeonInfo = new global::EggLink.DanhengServer.Proto.RogueAeonInfo();
        }
        RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
      }
      if (other.rogueAreaInfo_ != null) {
        if (rogueAreaInfo_ == null) {
          RogueAreaInfo = new global::EggLink.DanhengServer.Proto.RogueAreaInfo();
        }
        RogueAreaInfo.MergeFrom(other.RogueAreaInfo);
      }
      if (other.rogueVirtualItemInfo_ != null) {
        if (rogueVirtualItemInfo_ == null) {
          RogueVirtualItemInfo = new global::EggLink.DanhengServer.Proto.RogueVirtualItemInfo();
        }
        RogueVirtualItemInfo.MergeFrom(other.RogueVirtualItemInfo);
      }
      if (other.rogueSeasonInfo_ != null) {
        if (rogueSeasonInfo_ == null) {
          RogueSeasonInfo = new global::EggLink.DanhengServer.Proto.RogueSeasonInfo();
        }
        RogueSeasonInfo.MergeFrom(other.RogueSeasonInfo);
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
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.RogueAeonInfo();
            }
            input.ReadMessage(RogueAeonInfo);
            break;
          }
          case 74: {
            if (rogueVirtualItemInfo_ == null) {
              RogueVirtualItemInfo = new global::EggLink.DanhengServer.Proto.RogueVirtualItemInfo();
            }
            input.ReadMessage(RogueVirtualItemInfo);
            break;
          }
          case 90: {
            if (rogueAreaInfo_ == null) {
              RogueAreaInfo = new global::EggLink.DanhengServer.Proto.RogueAreaInfo();
            }
            input.ReadMessage(RogueAreaInfo);
            break;
          }
          case 98: {
            if (rogueSeasonInfo_ == null) {
              RogueSeasonInfo = new global::EggLink.DanhengServer.Proto.RogueSeasonInfo();
            }
            input.ReadMessage(RogueSeasonInfo);
            break;
          }
          case 122: {
            if (rogueScoreRewardInfo_ == null) {
              RogueScoreRewardInfo = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
            }
            input.ReadMessage(RogueScoreRewardInfo);
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
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.RogueAeonInfo();
            }
            input.ReadMessage(RogueAeonInfo);
            break;
          }
          case 74: {
            if (rogueVirtualItemInfo_ == null) {
              RogueVirtualItemInfo = new global::EggLink.DanhengServer.Proto.RogueVirtualItemInfo();
            }
            input.ReadMessage(RogueVirtualItemInfo);
            break;
          }
          case 90: {
            if (rogueAreaInfo_ == null) {
              RogueAreaInfo = new global::EggLink.DanhengServer.Proto.RogueAreaInfo();
            }
            input.ReadMessage(RogueAreaInfo);
            break;
          }
          case 98: {
            if (rogueSeasonInfo_ == null) {
              RogueSeasonInfo = new global::EggLink.DanhengServer.Proto.RogueSeasonInfo();
            }
            input.ReadMessage(RogueSeasonInfo);
            break;
          }
          case 122: {
            if (rogueScoreRewardInfo_ == null) {
              RogueScoreRewardInfo = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
            }
            input.ReadMessage(RogueScoreRewardInfo);
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
