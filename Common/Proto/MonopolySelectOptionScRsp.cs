// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonopolySelectOptionScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonopolySelectOptionScRsp.proto</summary>
  public static partial class MonopolySelectOptionScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for MonopolySelectOptionScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonopolySelectOptionScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Nb25vcG9seVNlbGVjdE9wdGlvblNjUnNwLnByb3RvGhFEQUNDQkJETkVI",
            "Ti5wcm90bxoRRElFTEdLTEFKTkwucHJvdG8imQEKGU1vbm9wb2x5U2VsZWN0",
            "T3B0aW9uU2NSc3ASDwoHcmV0Y29kZRgMIAEoDRIQCghldmVudF9pZBgBIAEo",
            "DRIhCgtJREJCQUdJTUlOTRgOIAEoCzIMLkRJRUxHS0xBSk5MEhMKC01CQURE",
            "S0pLTEtFGA0gASgNEiEKC0xNT0ZKSEJLSkxKGAogAygLMgwuREFDQ0JCRE5F",
            "SE5CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.DACCBBDNEHNReflection.Descriptor, global::EggLink.DanhengServer.Proto.DIELGKLAJNLReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MonopolySelectOptionScRsp), global::EggLink.DanhengServer.Proto.MonopolySelectOptionScRsp.Parser, new[]{ "Retcode", "EventId", "IDBBAGIMINM", "MBADDKJKLKE", "LMOFJHBKJLJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MonopolySelectOptionScRsp : pb::IMessage<MonopolySelectOptionScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonopolySelectOptionScRsp> _parser = new pb::MessageParser<MonopolySelectOptionScRsp>(() => new MonopolySelectOptionScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonopolySelectOptionScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MonopolySelectOptionScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolySelectOptionScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolySelectOptionScRsp(MonopolySelectOptionScRsp other) : this() {
      retcode_ = other.retcode_;
      eventId_ = other.eventId_;
      iDBBAGIMINM_ = other.iDBBAGIMINM_ != null ? other.iDBBAGIMINM_.Clone() : null;
      mBADDKJKLKE_ = other.mBADDKJKLKE_;
      lMOFJHBKJLJ_ = other.lMOFJHBKJLJ_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolySelectOptionScRsp Clone() {
      return new MonopolySelectOptionScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "event_id" field.</summary>
    public const int EventIdFieldNumber = 1;
    private uint eventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventId {
      get { return eventId_; }
      set {
        eventId_ = value;
      }
    }

    /// <summary>Field number for the "IDBBAGIMINM" field.</summary>
    public const int IDBBAGIMINMFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.DIELGKLAJNL iDBBAGIMINM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DIELGKLAJNL IDBBAGIMINM {
      get { return iDBBAGIMINM_; }
      set {
        iDBBAGIMINM_ = value;
      }
    }

    /// <summary>Field number for the "MBADDKJKLKE" field.</summary>
    public const int MBADDKJKLKEFieldNumber = 13;
    private uint mBADDKJKLKE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MBADDKJKLKE {
      get { return mBADDKJKLKE_; }
      set {
        mBADDKJKLKE_ = value;
      }
    }

    /// <summary>Field number for the "LMOFJHBKJLJ" field.</summary>
    public const int LMOFJHBKJLJFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DACCBBDNEHN> _repeated_lMOFJHBKJLJ_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.DACCBBDNEHN.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DACCBBDNEHN> lMOFJHBKJLJ_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DACCBBDNEHN>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DACCBBDNEHN> LMOFJHBKJLJ {
      get { return lMOFJHBKJLJ_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonopolySelectOptionScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonopolySelectOptionScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (EventId != other.EventId) return false;
      if (!object.Equals(IDBBAGIMINM, other.IDBBAGIMINM)) return false;
      if (MBADDKJKLKE != other.MBADDKJKLKE) return false;
      if(!lMOFJHBKJLJ_.Equals(other.lMOFJHBKJLJ_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (EventId != 0) hash ^= EventId.GetHashCode();
      if (iDBBAGIMINM_ != null) hash ^= IDBBAGIMINM.GetHashCode();
      if (MBADDKJKLKE != 0) hash ^= MBADDKJKLKE.GetHashCode();
      hash ^= lMOFJHBKJLJ_.GetHashCode();
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
      if (EventId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EventId);
      }
      lMOFJHBKJLJ_.WriteTo(output, _repeated_lMOFJHBKJLJ_codec);
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
      }
      if (MBADDKJKLKE != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MBADDKJKLKE);
      }
      if (iDBBAGIMINM_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(IDBBAGIMINM);
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
      if (EventId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EventId);
      }
      lMOFJHBKJLJ_.WriteTo(ref output, _repeated_lMOFJHBKJLJ_codec);
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
      }
      if (MBADDKJKLKE != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MBADDKJKLKE);
      }
      if (iDBBAGIMINM_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(IDBBAGIMINM);
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
      if (EventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventId);
      }
      if (iDBBAGIMINM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IDBBAGIMINM);
      }
      if (MBADDKJKLKE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MBADDKJKLKE);
      }
      size += lMOFJHBKJLJ_.CalculateSize(_repeated_lMOFJHBKJLJ_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonopolySelectOptionScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.EventId != 0) {
        EventId = other.EventId;
      }
      if (other.iDBBAGIMINM_ != null) {
        if (iDBBAGIMINM_ == null) {
          IDBBAGIMINM = new global::EggLink.DanhengServer.Proto.DIELGKLAJNL();
        }
        IDBBAGIMINM.MergeFrom(other.IDBBAGIMINM);
      }
      if (other.MBADDKJKLKE != 0) {
        MBADDKJKLKE = other.MBADDKJKLKE;
      }
      lMOFJHBKJLJ_.Add(other.lMOFJHBKJLJ_);
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
            EventId = input.ReadUInt32();
            break;
          }
          case 82: {
            lMOFJHBKJLJ_.AddEntriesFrom(input, _repeated_lMOFJHBKJLJ_codec);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 104: {
            MBADDKJKLKE = input.ReadUInt32();
            break;
          }
          case 114: {
            if (iDBBAGIMINM_ == null) {
              IDBBAGIMINM = new global::EggLink.DanhengServer.Proto.DIELGKLAJNL();
            }
            input.ReadMessage(IDBBAGIMINM);
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
            EventId = input.ReadUInt32();
            break;
          }
          case 82: {
            lMOFJHBKJLJ_.AddEntriesFrom(ref input, _repeated_lMOFJHBKJLJ_codec);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 104: {
            MBADDKJKLKE = input.ReadUInt32();
            break;
          }
          case 114: {
            if (iDBBAGIMINM_ == null) {
              IDBBAGIMINM = new global::EggLink.DanhengServer.Proto.DIELGKLAJNL();
            }
            input.ReadMessage(IDBBAGIMINM);
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
