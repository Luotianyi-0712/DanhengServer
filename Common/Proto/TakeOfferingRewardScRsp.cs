// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeOfferingRewardScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TakeOfferingRewardScRsp.proto</summary>
  public static partial class TakeOfferingRewardScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TakeOfferingRewardScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TakeOfferingRewardScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1UYWtlT2ZmZXJpbmdSZXdhcmRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJv",
            "dG8aEUlITEFBR01QTVBDLnByb3RvImgKF1Rha2VPZmZlcmluZ1Jld2FyZFNj",
            "UnNwEiEKC0xDRUNCRU9JUEVFGAogASgLMgwuSUhMQUFHTVBNUEMSDwoHcmV0",
            "Y29kZRgJIAEoDRIZCgZyZXdhcmQYByABKAsyCS5JdGVtTGlzdEIeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, global::EggLink.DanhengServer.Proto.IHLAAGMPMPCReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TakeOfferingRewardScRsp), global::EggLink.DanhengServer.Proto.TakeOfferingRewardScRsp.Parser, new[]{ "LCECBEOIPEE", "Retcode", "Reward" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TakeOfferingRewardScRsp : pb::IMessage<TakeOfferingRewardScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TakeOfferingRewardScRsp> _parser = new pb::MessageParser<TakeOfferingRewardScRsp>(() => new TakeOfferingRewardScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TakeOfferingRewardScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TakeOfferingRewardScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeOfferingRewardScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeOfferingRewardScRsp(TakeOfferingRewardScRsp other) : this() {
      lCECBEOIPEE_ = other.lCECBEOIPEE_ != null ? other.lCECBEOIPEE_.Clone() : null;
      retcode_ = other.retcode_;
      reward_ = other.reward_ != null ? other.reward_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeOfferingRewardScRsp Clone() {
      return new TakeOfferingRewardScRsp(this);
    }

    /// <summary>Field number for the "LCECBEOIPEE" field.</summary>
    public const int LCECBEOIPEEFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.IHLAAGMPMPC lCECBEOIPEE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.IHLAAGMPMPC LCECBEOIPEE {
      get { return lCECBEOIPEE_; }
      set {
        lCECBEOIPEE_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 9;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 7;
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
      return Equals(other as TakeOfferingRewardScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TakeOfferingRewardScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(LCECBEOIPEE, other.LCECBEOIPEE)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(Reward, other.Reward)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (lCECBEOIPEE_ != null) hash ^= LCECBEOIPEE.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (reward_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Reward);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
      }
      if (lCECBEOIPEE_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(LCECBEOIPEE);
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
      if (reward_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Reward);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
      }
      if (lCECBEOIPEE_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(LCECBEOIPEE);
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
      if (lCECBEOIPEE_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LCECBEOIPEE);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
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
    public void MergeFrom(TakeOfferingRewardScRsp other) {
      if (other == null) {
        return;
      }
      if (other.lCECBEOIPEE_ != null) {
        if (lCECBEOIPEE_ == null) {
          LCECBEOIPEE = new global::EggLink.DanhengServer.Proto.IHLAAGMPMPC();
        }
        LCECBEOIPEE.MergeFrom(other.LCECBEOIPEE);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 58: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 82: {
            if (lCECBEOIPEE_ == null) {
              LCECBEOIPEE = new global::EggLink.DanhengServer.Proto.IHLAAGMPMPC();
            }
            input.ReadMessage(LCECBEOIPEE);
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
          case 58: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 82: {
            if (lCECBEOIPEE_ == null) {
              LCECBEOIPEE = new global::EggLink.DanhengServer.Proto.IHLAAGMPMPC();
            }
            input.ReadMessage(LCECBEOIPEE);
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
