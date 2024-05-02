// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EndDrinkMakerSequenceScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EndDrinkMakerSequenceScRsp.proto</summary>
  public static partial class EndDrinkMakerSequenceScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for EndDrinkMakerSequenceScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EndDrinkMakerSequenceScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBFbmREcmlua01ha2VyU2VxdWVuY2VTY1JzcC5wcm90bxoOSXRlbUxpc3Qu",
            "cHJvdG8aFURyaW5rTWFrZXJHdWVzdC5wcm90bxoRT01JSE9JQkdQUEkucHJv",
            "dG8i0QEKGkVuZERyaW5rTWFrZXJTZXF1ZW5jZVNjUnNwEg8KB3JldGNvZGUY",
            "ASABKA0SIgoMcmVxdWVzdF9saXN0GA4gAygLMgwuT01JSE9JQkdQUEkSHwoF",
            "Z3Vlc3QYBSABKAsyEC5Ecmlua01ha2VyR3Vlc3QSGAoQbmV4dF9zZXF1ZW5j",
            "ZV9pZBgLIAEoDRILCgNleHAYBCABKA0SDQoFbGV2ZWwYByABKA0SDAoEdGlw",
            "cxgPIAEoDRIZCgZyZXdhcmQYAyABKAsyCS5JdGVtTGlzdEIeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, global::EggLink.DanhengServer.Proto.DrinkMakerGuestReflection.Descriptor, global::EggLink.DanhengServer.Proto.OMIHOIBGPPIReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EndDrinkMakerSequenceScRsp), global::EggLink.DanhengServer.Proto.EndDrinkMakerSequenceScRsp.Parser, new[]{ "Retcode", "RequestList", "Guest", "NextSequenceId", "Exp", "Level", "Tips", "Reward" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EndDrinkMakerSequenceScRsp : pb::IMessage<EndDrinkMakerSequenceScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EndDrinkMakerSequenceScRsp> _parser = new pb::MessageParser<EndDrinkMakerSequenceScRsp>(() => new EndDrinkMakerSequenceScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EndDrinkMakerSequenceScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EndDrinkMakerSequenceScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EndDrinkMakerSequenceScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EndDrinkMakerSequenceScRsp(EndDrinkMakerSequenceScRsp other) : this() {
      retcode_ = other.retcode_;
      requestList_ = other.requestList_.Clone();
      guest_ = other.guest_ != null ? other.guest_.Clone() : null;
      nextSequenceId_ = other.nextSequenceId_;
      exp_ = other.exp_;
      level_ = other.level_;
      tips_ = other.tips_;
      reward_ = other.reward_ != null ? other.reward_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EndDrinkMakerSequenceScRsp Clone() {
      return new EndDrinkMakerSequenceScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "request_list" field.</summary>
    public const int RequestListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.OMIHOIBGPPI> _repeated_requestList_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.OMIHOIBGPPI.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.OMIHOIBGPPI> requestList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.OMIHOIBGPPI>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.OMIHOIBGPPI> RequestList {
      get { return requestList_; }
    }

    /// <summary>Field number for the "guest" field.</summary>
    public const int GuestFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.DrinkMakerGuest guest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DrinkMakerGuest Guest {
      get { return guest_; }
      set {
        guest_ = value;
      }
    }

    /// <summary>Field number for the "next_sequence_id" field.</summary>
    public const int NextSequenceIdFieldNumber = 11;
    private uint nextSequenceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextSequenceId {
      get { return nextSequenceId_; }
      set {
        nextSequenceId_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 4;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 7;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "tips" field.</summary>
    public const int TipsFieldNumber = 15;
    private uint tips_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Tips {
      get { return tips_; }
      set {
        tips_ = value;
      }
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 3;
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
      return Equals(other as EndDrinkMakerSequenceScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EndDrinkMakerSequenceScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if(!requestList_.Equals(other.requestList_)) return false;
      if (!object.Equals(Guest, other.Guest)) return false;
      if (NextSequenceId != other.NextSequenceId) return false;
      if (Exp != other.Exp) return false;
      if (Level != other.Level) return false;
      if (Tips != other.Tips) return false;
      if (!object.Equals(Reward, other.Reward)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= requestList_.GetHashCode();
      if (guest_ != null) hash ^= Guest.GetHashCode();
      if (NextSequenceId != 0) hash ^= NextSequenceId.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Tips != 0) hash ^= Tips.GetHashCode();
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
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      if (reward_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Reward);
      }
      if (Exp != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Exp);
      }
      if (guest_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Guest);
      }
      if (Level != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Level);
      }
      if (NextSequenceId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(NextSequenceId);
      }
      requestList_.WriteTo(output, _repeated_requestList_codec);
      if (Tips != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Tips);
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
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      if (reward_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Reward);
      }
      if (Exp != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Exp);
      }
      if (guest_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Guest);
      }
      if (Level != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Level);
      }
      if (NextSequenceId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(NextSequenceId);
      }
      requestList_.WriteTo(ref output, _repeated_requestList_codec);
      if (Tips != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Tips);
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
      size += requestList_.CalculateSize(_repeated_requestList_codec);
      if (guest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Guest);
      }
      if (NextSequenceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextSequenceId);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (Tips != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Tips);
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
    public void MergeFrom(EndDrinkMakerSequenceScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      requestList_.Add(other.requestList_);
      if (other.guest_ != null) {
        if (guest_ == null) {
          Guest = new global::EggLink.DanhengServer.Proto.DrinkMakerGuest();
        }
        Guest.MergeFrom(other.Guest);
      }
      if (other.NextSequenceId != 0) {
        NextSequenceId = other.NextSequenceId;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Tips != 0) {
        Tips = other.Tips;
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
          case 8: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 26: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 32: {
            Exp = input.ReadUInt32();
            break;
          }
          case 42: {
            if (guest_ == null) {
              Guest = new global::EggLink.DanhengServer.Proto.DrinkMakerGuest();
            }
            input.ReadMessage(Guest);
            break;
          }
          case 56: {
            Level = input.ReadUInt32();
            break;
          }
          case 88: {
            NextSequenceId = input.ReadUInt32();
            break;
          }
          case 114: {
            requestList_.AddEntriesFrom(input, _repeated_requestList_codec);
            break;
          }
          case 120: {
            Tips = input.ReadUInt32();
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
          case 8: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 26: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 32: {
            Exp = input.ReadUInt32();
            break;
          }
          case 42: {
            if (guest_ == null) {
              Guest = new global::EggLink.DanhengServer.Proto.DrinkMakerGuest();
            }
            input.ReadMessage(Guest);
            break;
          }
          case 56: {
            Level = input.ReadUInt32();
            break;
          }
          case 88: {
            NextSequenceId = input.ReadUInt32();
            break;
          }
          case 114: {
            requestList_.AddEntriesFrom(ref input, _repeated_requestList_codec);
            break;
          }
          case 120: {
            Tips = input.ReadUInt32();
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
