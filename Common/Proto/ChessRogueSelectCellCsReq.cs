// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueSelectCellCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueSelectCellCsReq.proto</summary>
  public static partial class ChessRogueSelectCellCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueSelectCellCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueSelectCellCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9DaGVzc1JvZ3VlU2VsZWN0Q2VsbENzUmVxLnByb3RvIkUKGUNoZXNzUm9n",
            "dWVTZWxlY3RDZWxsQ3NSZXESEwoLT0ZBS0xGTEFPTFAYAyABKA0SEwoLSEhN",
            "RUpER0dOSk4YDSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueSelectCellCsReq), global::EggLink.DanhengServer.Proto.ChessRogueSelectCellCsReq.Parser, new[]{ "OFAKLFLAOLP", "HHMEJDGGNJN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueSelectCellCsReq : pb::IMessage<ChessRogueSelectCellCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueSelectCellCsReq> _parser = new pb::MessageParser<ChessRogueSelectCellCsReq>(() => new ChessRogueSelectCellCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueSelectCellCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueSelectCellCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueSelectCellCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueSelectCellCsReq(ChessRogueSelectCellCsReq other) : this() {
      oFAKLFLAOLP_ = other.oFAKLFLAOLP_;
      hHMEJDGGNJN_ = other.hHMEJDGGNJN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueSelectCellCsReq Clone() {
      return new ChessRogueSelectCellCsReq(this);
    }

    /// <summary>Field number for the "OFAKLFLAOLP" field.</summary>
    public const int OFAKLFLAOLPFieldNumber = 3;
    private uint oFAKLFLAOLP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OFAKLFLAOLP {
      get { return oFAKLFLAOLP_; }
      set {
        oFAKLFLAOLP_ = value;
      }
    }

    /// <summary>Field number for the "HHMEJDGGNJN" field.</summary>
    public const int HHMEJDGGNJNFieldNumber = 13;
    private uint hHMEJDGGNJN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HHMEJDGGNJN {
      get { return hHMEJDGGNJN_; }
      set {
        hHMEJDGGNJN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueSelectCellCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueSelectCellCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OFAKLFLAOLP != other.OFAKLFLAOLP) return false;
      if (HHMEJDGGNJN != other.HHMEJDGGNJN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OFAKLFLAOLP != 0) hash ^= OFAKLFLAOLP.GetHashCode();
      if (HHMEJDGGNJN != 0) hash ^= HHMEJDGGNJN.GetHashCode();
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
      if (OFAKLFLAOLP != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OFAKLFLAOLP);
      }
      if (HHMEJDGGNJN != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(HHMEJDGGNJN);
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
      if (OFAKLFLAOLP != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OFAKLFLAOLP);
      }
      if (HHMEJDGGNJN != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(HHMEJDGGNJN);
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
      if (OFAKLFLAOLP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OFAKLFLAOLP);
      }
      if (HHMEJDGGNJN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HHMEJDGGNJN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueSelectCellCsReq other) {
      if (other == null) {
        return;
      }
      if (other.OFAKLFLAOLP != 0) {
        OFAKLFLAOLP = other.OFAKLFLAOLP;
      }
      if (other.HHMEJDGGNJN != 0) {
        HHMEJDGGNJN = other.HHMEJDGGNJN;
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
            OFAKLFLAOLP = input.ReadUInt32();
            break;
          }
          case 104: {
            HHMEJDGGNJN = input.ReadUInt32();
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
            OFAKLFLAOLP = input.ReadUInt32();
            break;
          }
          case 104: {
            HHMEJDGGNJN = input.ReadUInt32();
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
