// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Quest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from Quest.proto</summary>
  public static partial class QuestReflection {

    #region Descriptor
    /// <summary>File descriptor for Quest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtRdWVzdC5wcm90bxoRUXVlc3RTdGF0dXMucHJvdG8ibQoFUXVlc3QSEwoL",
            "ZmluaXNoX3RpbWUYAyABKAMSEAoIcHJvZ3Jlc3MYCCABKA0SCgoCaWQYASAB",
            "KA0SEwoLT0xCRkpNR0RCT0sYByADKA0SHAoGc3RhdHVzGA4gASgOMgwuUXVl",
            "c3RTdGF0dXNCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.QuestStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.Quest), global::EggLink.DanhengServer.Proto.Quest.Parser, new[]{ "FinishTime", "Progress", "Id", "OLBFJMGDBOK", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Quest : pb::IMessage<Quest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Quest> _parser = new pb::MessageParser<Quest>(() => new Quest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Quest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.QuestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Quest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Quest(Quest other) : this() {
      finishTime_ = other.finishTime_;
      progress_ = other.progress_;
      id_ = other.id_;
      oLBFJMGDBOK_ = other.oLBFJMGDBOK_.Clone();
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Quest Clone() {
      return new Quest(this);
    }

    /// <summary>Field number for the "finish_time" field.</summary>
    public const int FinishTimeFieldNumber = 3;
    private long finishTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long FinishTime {
      get { return finishTime_; }
      set {
        finishTime_ = value;
      }
    }

    /// <summary>Field number for the "progress" field.</summary>
    public const int ProgressFieldNumber = 8;
    private uint progress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Progress {
      get { return progress_; }
      set {
        progress_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "OLBFJMGDBOK" field.</summary>
    public const int OLBFJMGDBOKFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_oLBFJMGDBOK_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> oLBFJMGDBOK_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> OLBFJMGDBOK {
      get { return oLBFJMGDBOK_; }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.QuestStatus status_ = global::EggLink.DanhengServer.Proto.QuestStatus.QuestNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.QuestStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Quest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Quest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FinishTime != other.FinishTime) return false;
      if (Progress != other.Progress) return false;
      if (Id != other.Id) return false;
      if(!oLBFJMGDBOK_.Equals(other.oLBFJMGDBOK_)) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FinishTime != 0L) hash ^= FinishTime.GetHashCode();
      if (Progress != 0) hash ^= Progress.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      hash ^= oLBFJMGDBOK_.GetHashCode();
      if (Status != global::EggLink.DanhengServer.Proto.QuestStatus.QuestNone) hash ^= Status.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (FinishTime != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(FinishTime);
      }
      oLBFJMGDBOK_.WriteTo(output, _repeated_oLBFJMGDBOK_codec);
      if (Progress != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Progress);
      }
      if (Status != global::EggLink.DanhengServer.Proto.QuestStatus.QuestNone) {
        output.WriteRawTag(112);
        output.WriteEnum((int) Status);
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (FinishTime != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(FinishTime);
      }
      oLBFJMGDBOK_.WriteTo(ref output, _repeated_oLBFJMGDBOK_codec);
      if (Progress != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Progress);
      }
      if (Status != global::EggLink.DanhengServer.Proto.QuestStatus.QuestNone) {
        output.WriteRawTag(112);
        output.WriteEnum((int) Status);
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
      if (FinishTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(FinishTime);
      }
      if (Progress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      size += oLBFJMGDBOK_.CalculateSize(_repeated_oLBFJMGDBOK_codec);
      if (Status != global::EggLink.DanhengServer.Proto.QuestStatus.QuestNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Quest other) {
      if (other == null) {
        return;
      }
      if (other.FinishTime != 0L) {
        FinishTime = other.FinishTime;
      }
      if (other.Progress != 0) {
        Progress = other.Progress;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      oLBFJMGDBOK_.Add(other.oLBFJMGDBOK_);
      if (other.Status != global::EggLink.DanhengServer.Proto.QuestStatus.QuestNone) {
        Status = other.Status;
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
            Id = input.ReadUInt32();
            break;
          }
          case 24: {
            FinishTime = input.ReadInt64();
            break;
          }
          case 58:
          case 56: {
            oLBFJMGDBOK_.AddEntriesFrom(input, _repeated_oLBFJMGDBOK_codec);
            break;
          }
          case 64: {
            Progress = input.ReadUInt32();
            break;
          }
          case 112: {
            Status = (global::EggLink.DanhengServer.Proto.QuestStatus) input.ReadEnum();
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
            Id = input.ReadUInt32();
            break;
          }
          case 24: {
            FinishTime = input.ReadInt64();
            break;
          }
          case 58:
          case 56: {
            oLBFJMGDBOK_.AddEntriesFrom(ref input, _repeated_oLBFJMGDBOK_codec);
            break;
          }
          case 64: {
            Progress = input.ReadUInt32();
            break;
          }
          case 112: {
            Status = (global::EggLink.DanhengServer.Proto.QuestStatus) input.ReadEnum();
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
