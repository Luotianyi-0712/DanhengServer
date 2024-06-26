// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeActivityExpeditionRewardScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TakeActivityExpeditionRewardScRsp.proto</summary>
  public static partial class TakeActivityExpeditionRewardScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TakeActivityExpeditionRewardScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TakeActivityExpeditionRewardScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidUYWtlQWN0aXZpdHlFeHBlZGl0aW9uUmV3YXJkU2NSc3AucHJvdG8aDkl0",
            "ZW1MaXN0LnByb3RvIqIBCiFUYWtlQWN0aXZpdHlFeHBlZGl0aW9uUmV3YXJk",
            "U2NSc3ASDwoHcmV0Y29kZRgCIAEoDRIQCghzY29yZV9pZBgKIAEoDRIeChZh",
            "Y3Rpdml0eV9leHBlZGl0aW9uX2lkGAQgASgNEh8KDGJvbnVzX3Jld2FyZBgI",
            "IAEoCzIJLkl0ZW1MaXN0EhkKBnJld2FyZBgFIAEoCzIJLkl0ZW1MaXN0Qh6q",
            "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TakeActivityExpeditionRewardScRsp), global::EggLink.DanhengServer.Proto.TakeActivityExpeditionRewardScRsp.Parser, new[]{ "Retcode", "ScoreId", "ActivityExpeditionId", "BonusReward", "Reward" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TakeActivityExpeditionRewardScRsp : pb::IMessage<TakeActivityExpeditionRewardScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TakeActivityExpeditionRewardScRsp> _parser = new pb::MessageParser<TakeActivityExpeditionRewardScRsp>(() => new TakeActivityExpeditionRewardScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TakeActivityExpeditionRewardScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TakeActivityExpeditionRewardScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeActivityExpeditionRewardScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeActivityExpeditionRewardScRsp(TakeActivityExpeditionRewardScRsp other) : this() {
      retcode_ = other.retcode_;
      scoreId_ = other.scoreId_;
      activityExpeditionId_ = other.activityExpeditionId_;
      bonusReward_ = other.bonusReward_ != null ? other.bonusReward_.Clone() : null;
      reward_ = other.reward_ != null ? other.reward_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeActivityExpeditionRewardScRsp Clone() {
      return new TakeActivityExpeditionRewardScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 2;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "score_id" field.</summary>
    public const int ScoreIdFieldNumber = 10;
    private uint scoreId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScoreId {
      get { return scoreId_; }
      set {
        scoreId_ = value;
      }
    }

    /// <summary>Field number for the "activity_expedition_id" field.</summary>
    public const int ActivityExpeditionIdFieldNumber = 4;
    private uint activityExpeditionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ActivityExpeditionId {
      get { return activityExpeditionId_; }
      set {
        activityExpeditionId_ = value;
      }
    }

    /// <summary>Field number for the "bonus_reward" field.</summary>
    public const int BonusRewardFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.ItemList bonusReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList BonusReward {
      get { return bonusReward_; }
      set {
        bonusReward_ = value;
      }
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.ItemList reward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Reward {
      get { return reward_; }
      set {
        reward_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TakeActivityExpeditionRewardScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TakeActivityExpeditionRewardScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (ScoreId != other.ScoreId) return false;
      if (ActivityExpeditionId != other.ActivityExpeditionId) return false;
      if (!object.Equals(BonusReward, other.BonusReward)) return false;
      if (!object.Equals(Reward, other.Reward)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (ScoreId != 0) hash ^= ScoreId.GetHashCode();
      if (ActivityExpeditionId != 0) hash ^= ActivityExpeditionId.GetHashCode();
      if (bonusReward_ != null) hash ^= BonusReward.GetHashCode();
      if (reward_ != null) hash ^= Reward.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Retcode);
      }
      if (ActivityExpeditionId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ActivityExpeditionId);
      }
      if (reward_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Reward);
      }
      if (bonusReward_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(BonusReward);
      }
      if (ScoreId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ScoreId);
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
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Retcode);
      }
      if (ActivityExpeditionId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ActivityExpeditionId);
      }
      if (reward_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Reward);
      }
      if (bonusReward_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(BonusReward);
      }
      if (ScoreId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ScoreId);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (ScoreId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScoreId);
      }
      if (ActivityExpeditionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ActivityExpeditionId);
      }
      if (bonusReward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BonusReward);
      }
      if (reward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reward);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TakeActivityExpeditionRewardScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.ScoreId != 0) {
        ScoreId = other.ScoreId;
      }
      if (other.ActivityExpeditionId != 0) {
        ActivityExpeditionId = other.ActivityExpeditionId;
      }
      if (other.bonusReward_ != null) {
        if (bonusReward_ == null) {
          BonusReward = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        BonusReward.MergeFrom(other.BonusReward);
      }
      if (other.reward_ != null) {
        if (reward_ == null) {
          Reward = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Reward.MergeFrom(other.Reward);
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
          case 16: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 32: {
            ActivityExpeditionId = input.ReadUInt32();
            break;
          }
          case 42: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 66: {
            if (bonusReward_ == null) {
              BonusReward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(BonusReward);
            break;
          }
          case 80: {
            ScoreId = input.ReadUInt32();
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
          case 16: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 32: {
            ActivityExpeditionId = input.ReadUInt32();
            break;
          }
          case 42: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 66: {
            if (bonusReward_ == null) {
              BonusReward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(BonusReward);
            break;
          }
          case 80: {
            ScoreId = input.ReadUInt32();
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
