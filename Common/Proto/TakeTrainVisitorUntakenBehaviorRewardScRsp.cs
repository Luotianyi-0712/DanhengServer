// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeTrainVisitorUntakenBehaviorRewardScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TakeTrainVisitorUntakenBehaviorRewardScRsp.proto</summary>
  public static partial class TakeTrainVisitorUntakenBehaviorRewardScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TakeTrainVisitorUntakenBehaviorRewardScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TakeTrainVisitorUntakenBehaviorRewardScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBUYWtlVHJhaW5WaXNpdG9yVW50YWtlbkJlaGF2aW9yUmV3YXJkU2NSc3Au",
            "cHJvdG8iZwoqVGFrZVRyYWluVmlzaXRvclVudGFrZW5CZWhhdmlvclJld2Fy",
            "ZFNjUnNwEg8KB3JldGNvZGUYBCABKA0SEwoLSk9CTEJMQ09OQU0YBiABKA0S",
            "EwoLSkpJRENCSkpGSk0YDCADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
            "ci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TakeTrainVisitorUntakenBehaviorRewardScRsp), global::EggLink.DanhengServer.Proto.TakeTrainVisitorUntakenBehaviorRewardScRsp.Parser, new[]{ "Retcode", "JOBLBLCONAM", "JJIDCBJJFJM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TakeTrainVisitorUntakenBehaviorRewardScRsp : pb::IMessage<TakeTrainVisitorUntakenBehaviorRewardScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TakeTrainVisitorUntakenBehaviorRewardScRsp> _parser = new pb::MessageParser<TakeTrainVisitorUntakenBehaviorRewardScRsp>(() => new TakeTrainVisitorUntakenBehaviorRewardScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TakeTrainVisitorUntakenBehaviorRewardScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TakeTrainVisitorUntakenBehaviorRewardScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeTrainVisitorUntakenBehaviorRewardScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeTrainVisitorUntakenBehaviorRewardScRsp(TakeTrainVisitorUntakenBehaviorRewardScRsp other) : this() {
      retcode_ = other.retcode_;
      jOBLBLCONAM_ = other.jOBLBLCONAM_;
      jJIDCBJJFJM_ = other.jJIDCBJJFJM_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeTrainVisitorUntakenBehaviorRewardScRsp Clone() {
      return new TakeTrainVisitorUntakenBehaviorRewardScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 4;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "JOBLBLCONAM" field.</summary>
    public const int JOBLBLCONAMFieldNumber = 6;
    private uint jOBLBLCONAM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JOBLBLCONAM {
      get { return jOBLBLCONAM_; }
      set {
        jOBLBLCONAM_ = value;
      }
    }

    /// <summary>Field number for the "JJIDCBJJFJM" field.</summary>
    public const int JJIDCBJJFJMFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_jJIDCBJJFJM_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> jJIDCBJJFJM_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> JJIDCBJJFJM {
      get { return jJIDCBJJFJM_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TakeTrainVisitorUntakenBehaviorRewardScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TakeTrainVisitorUntakenBehaviorRewardScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (JOBLBLCONAM != other.JOBLBLCONAM) return false;
      if(!jJIDCBJJFJM_.Equals(other.jJIDCBJJFJM_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (JOBLBLCONAM != 0) hash ^= JOBLBLCONAM.GetHashCode();
      hash ^= jJIDCBJJFJM_.GetHashCode();
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
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (JOBLBLCONAM != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(JOBLBLCONAM);
      }
      jJIDCBJJFJM_.WriteTo(output, _repeated_jJIDCBJJFJM_codec);
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
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (JOBLBLCONAM != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(JOBLBLCONAM);
      }
      jJIDCBJJFJM_.WriteTo(ref output, _repeated_jJIDCBJJFJM_codec);
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
      if (JOBLBLCONAM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JOBLBLCONAM);
      }
      size += jJIDCBJJFJM_.CalculateSize(_repeated_jJIDCBJJFJM_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TakeTrainVisitorUntakenBehaviorRewardScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.JOBLBLCONAM != 0) {
        JOBLBLCONAM = other.JOBLBLCONAM;
      }
      jJIDCBJJFJM_.Add(other.jJIDCBJJFJM_);
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
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 48: {
            JOBLBLCONAM = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            jJIDCBJJFJM_.AddEntriesFrom(input, _repeated_jJIDCBJJFJM_codec);
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
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 48: {
            JOBLBLCONAM = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            jJIDCBJJFJM_.AddEntriesFrom(ref input, _repeated_jJIDCBJJFJM_codec);
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
