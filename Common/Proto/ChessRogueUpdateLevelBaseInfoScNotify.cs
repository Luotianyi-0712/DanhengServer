// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueUpdateLevelBaseInfoScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueUpdateLevelBaseInfoScNotify.proto</summary>
  public static partial class ChessRogueUpdateLevelBaseInfoScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueUpdateLevelBaseInfoScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueUpdateLevelBaseInfoScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitDaGVzc1JvZ3VlVXBkYXRlTGV2ZWxCYXNlSW5mb1NjTm90aWZ5LnByb3Rv",
            "GhFLREdKTUxKT0tFSy5wcm90bxoRTEpKUElES0RFR0YucHJvdG8iaAolQ2hl",
            "c3NSb2d1ZVVwZGF0ZUxldmVsQmFzZUluZm9TY05vdGlmeRIcCgZyZWFzb24Y",
            "AyABKA4yDC5MSkpQSURLREVHRhIhCgtITEVBTUtISkdQThgJIAEoDjIMLktE",
            "R0pNTEpPS0VLQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.KDGJMLJOKEKReflection.Descriptor, global::EggLink.DanhengServer.Proto.LJJPIDKDEGFReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueUpdateLevelBaseInfoScNotify), global::EggLink.DanhengServer.Proto.ChessRogueUpdateLevelBaseInfoScNotify.Parser, new[]{ "Reason", "HLEAMKHJGPN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueUpdateLevelBaseInfoScNotify : pb::IMessage<ChessRogueUpdateLevelBaseInfoScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueUpdateLevelBaseInfoScNotify> _parser = new pb::MessageParser<ChessRogueUpdateLevelBaseInfoScNotify>(() => new ChessRogueUpdateLevelBaseInfoScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueUpdateLevelBaseInfoScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueUpdateLevelBaseInfoScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueUpdateLevelBaseInfoScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueUpdateLevelBaseInfoScNotify(ChessRogueUpdateLevelBaseInfoScNotify other) : this() {
      reason_ = other.reason_;
      hLEAMKHJGPN_ = other.hLEAMKHJGPN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueUpdateLevelBaseInfoScNotify Clone() {
      return new ChessRogueUpdateLevelBaseInfoScNotify(this);
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.LJJPIDKDEGF reason_ = global::EggLink.DanhengServer.Proto.LJJPIDKDEGF.ChessRogueUpdateLevelStatusByNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LJJPIDKDEGF Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "HLEAMKHJGPN" field.</summary>
    public const int HLEAMKHJGPNFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.KDGJMLJOKEK hLEAMKHJGPN_ = global::EggLink.DanhengServer.Proto.KDGJMLJOKEK.ChessRogueLevelIdle;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.KDGJMLJOKEK HLEAMKHJGPN {
      get { return hLEAMKHJGPN_; }
      set {
        hLEAMKHJGPN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueUpdateLevelBaseInfoScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueUpdateLevelBaseInfoScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Reason != other.Reason) return false;
      if (HLEAMKHJGPN != other.HLEAMKHJGPN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Reason != global::EggLink.DanhengServer.Proto.LJJPIDKDEGF.ChessRogueUpdateLevelStatusByNone) hash ^= Reason.GetHashCode();
      if (HLEAMKHJGPN != global::EggLink.DanhengServer.Proto.KDGJMLJOKEK.ChessRogueLevelIdle) hash ^= HLEAMKHJGPN.GetHashCode();
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
      if (Reason != global::EggLink.DanhengServer.Proto.LJJPIDKDEGF.ChessRogueUpdateLevelStatusByNone) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Reason);
      }
      if (HLEAMKHJGPN != global::EggLink.DanhengServer.Proto.KDGJMLJOKEK.ChessRogueLevelIdle) {
        output.WriteRawTag(72);
        output.WriteEnum((int) HLEAMKHJGPN);
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
      if (Reason != global::EggLink.DanhengServer.Proto.LJJPIDKDEGF.ChessRogueUpdateLevelStatusByNone) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Reason);
      }
      if (HLEAMKHJGPN != global::EggLink.DanhengServer.Proto.KDGJMLJOKEK.ChessRogueLevelIdle) {
        output.WriteRawTag(72);
        output.WriteEnum((int) HLEAMKHJGPN);
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
      if (Reason != global::EggLink.DanhengServer.Proto.LJJPIDKDEGF.ChessRogueUpdateLevelStatusByNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (HLEAMKHJGPN != global::EggLink.DanhengServer.Proto.KDGJMLJOKEK.ChessRogueLevelIdle) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) HLEAMKHJGPN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueUpdateLevelBaseInfoScNotify other) {
      if (other == null) {
        return;
      }
      if (other.Reason != global::EggLink.DanhengServer.Proto.LJJPIDKDEGF.ChessRogueUpdateLevelStatusByNone) {
        Reason = other.Reason;
      }
      if (other.HLEAMKHJGPN != global::EggLink.DanhengServer.Proto.KDGJMLJOKEK.ChessRogueLevelIdle) {
        HLEAMKHJGPN = other.HLEAMKHJGPN;
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
          case 24: {
            Reason = (global::EggLink.DanhengServer.Proto.LJJPIDKDEGF) input.ReadEnum();
            break;
          }
          case 72: {
            HLEAMKHJGPN = (global::EggLink.DanhengServer.Proto.KDGJMLJOKEK) input.ReadEnum();
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
          case 24: {
            Reason = (global::EggLink.DanhengServer.Proto.LJJPIDKDEGF) input.ReadEnum();
            break;
          }
          case 72: {
            HLEAMKHJGPN = (global::EggLink.DanhengServer.Proto.KDGJMLJOKEK) input.ReadEnum();
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
