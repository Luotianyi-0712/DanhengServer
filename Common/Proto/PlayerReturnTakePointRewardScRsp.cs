// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerReturnTakePointRewardScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerReturnTakePointRewardScRsp.proto</summary>
  public static partial class PlayerReturnTakePointRewardScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerReturnTakePointRewardScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerReturnTakePointRewardScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZQbGF5ZXJSZXR1cm5UYWtlUG9pbnRSZXdhcmRTY1JzcC5wcm90bxoOSXRl",
            "bUxpc3QucHJvdG8ifQogUGxheWVyUmV0dXJuVGFrZVBvaW50UmV3YXJkU2NS",
            "c3ASDwoHcmV0Y29kZRgIIAEoDRITCgtHQ0FLTEFNUEpPTBgPIAEoDRITCgtG",
            "QkhCRlBBQUdBUBgOIAEoDRIeCgtNSEhCREFOQ0ZFRRgFIAEoCzIJLkl0ZW1M",
            "aXN0Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerReturnTakePointRewardScRsp), global::EggLink.DanhengServer.Proto.PlayerReturnTakePointRewardScRsp.Parser, new[]{ "Retcode", "GCAKLAMPJOL", "FBHBFPAAGAP", "MHHBDANCFEE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerReturnTakePointRewardScRsp : pb::IMessage<PlayerReturnTakePointRewardScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerReturnTakePointRewardScRsp> _parser = new pb::MessageParser<PlayerReturnTakePointRewardScRsp>(() => new PlayerReturnTakePointRewardScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerReturnTakePointRewardScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerReturnTakePointRewardScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnTakePointRewardScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnTakePointRewardScRsp(PlayerReturnTakePointRewardScRsp other) : this() {
      retcode_ = other.retcode_;
      gCAKLAMPJOL_ = other.gCAKLAMPJOL_;
      fBHBFPAAGAP_ = other.fBHBFPAAGAP_;
      mHHBDANCFEE_ = other.mHHBDANCFEE_ != null ? other.mHHBDANCFEE_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnTakePointRewardScRsp Clone() {
      return new PlayerReturnTakePointRewardScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "GCAKLAMPJOL" field.</summary>
    public const int GCAKLAMPJOLFieldNumber = 15;
    private uint gCAKLAMPJOL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GCAKLAMPJOL {
      get { return gCAKLAMPJOL_; }
      set {
        gCAKLAMPJOL_ = value;
      }
    }

    /// <summary>Field number for the "FBHBFPAAGAP" field.</summary>
    public const int FBHBFPAAGAPFieldNumber = 14;
    private uint fBHBFPAAGAP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FBHBFPAAGAP {
      get { return fBHBFPAAGAP_; }
      set {
        fBHBFPAAGAP_ = value;
      }
    }

    /// <summary>Field number for the "MHHBDANCFEE" field.</summary>
    public const int MHHBDANCFEEFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.ItemList mHHBDANCFEE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList MHHBDANCFEE {
      get { return mHHBDANCFEE_; }
      set {
        mHHBDANCFEE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerReturnTakePointRewardScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerReturnTakePointRewardScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (GCAKLAMPJOL != other.GCAKLAMPJOL) return false;
      if (FBHBFPAAGAP != other.FBHBFPAAGAP) return false;
      if (!object.Equals(MHHBDANCFEE, other.MHHBDANCFEE)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (GCAKLAMPJOL != 0) hash ^= GCAKLAMPJOL.GetHashCode();
      if (FBHBFPAAGAP != 0) hash ^= FBHBFPAAGAP.GetHashCode();
      if (mHHBDANCFEE_ != null) hash ^= MHHBDANCFEE.GetHashCode();
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
      if (mHHBDANCFEE_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(MHHBDANCFEE);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      if (FBHBFPAAGAP != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FBHBFPAAGAP);
      }
      if (GCAKLAMPJOL != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(GCAKLAMPJOL);
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
      if (mHHBDANCFEE_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(MHHBDANCFEE);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      if (FBHBFPAAGAP != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FBHBFPAAGAP);
      }
      if (GCAKLAMPJOL != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(GCAKLAMPJOL);
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
      if (GCAKLAMPJOL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GCAKLAMPJOL);
      }
      if (FBHBFPAAGAP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FBHBFPAAGAP);
      }
      if (mHHBDANCFEE_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MHHBDANCFEE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerReturnTakePointRewardScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.GCAKLAMPJOL != 0) {
        GCAKLAMPJOL = other.GCAKLAMPJOL;
      }
      if (other.FBHBFPAAGAP != 0) {
        FBHBFPAAGAP = other.FBHBFPAAGAP;
      }
      if (other.mHHBDANCFEE_ != null) {
        if (mHHBDANCFEE_ == null) {
          MHHBDANCFEE = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        MHHBDANCFEE.MergeFrom(other.MHHBDANCFEE);
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
          case 42: {
            if (mHHBDANCFEE_ == null) {
              MHHBDANCFEE = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(MHHBDANCFEE);
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 112: {
            FBHBFPAAGAP = input.ReadUInt32();
            break;
          }
          case 120: {
            GCAKLAMPJOL = input.ReadUInt32();
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
          case 42: {
            if (mHHBDANCFEE_ == null) {
              MHHBDANCFEE = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(MHHBDANCFEE);
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 112: {
            FBHBFPAAGAP = input.ReadUInt32();
            break;
          }
          case 120: {
            GCAKLAMPJOL = input.ReadUInt32();
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