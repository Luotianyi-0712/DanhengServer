// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PGFCMDKKODD.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PGFCMDKKODD.proto</summary>
  public static partial class PGFCMDKKODDReflection {

    #region Descriptor
    /// <summary>File descriptor for PGFCMDKKODD.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PGFCMDKKODDReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQR0ZDTURLS09ERC5wcm90bxoXTWlzc2lvblN5bmNSZWNvcmQucHJvdG8i",
            "UAoLUEdGQ01ES0tPREQSCgoCaWQYBSABKA0SIAoEdHlwZRgJIAEoDjISLk1p",
            "c3Npb25TeW5jUmVjb3JkEhMKC0pESEdQTklHRUVHGAogASgNQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MissionSyncRecordReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PGFCMDKKODD), global::EggLink.DanhengServer.Proto.PGFCMDKKODD.Parser, new[]{ "Id", "Type", "JDHGPNIGEEG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PGFCMDKKODD : pb::IMessage<PGFCMDKKODD>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PGFCMDKKODD> _parser = new pb::MessageParser<PGFCMDKKODD>(() => new PGFCMDKKODD());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PGFCMDKKODD> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PGFCMDKKODDReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PGFCMDKKODD() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PGFCMDKKODD(PGFCMDKKODD other) : this() {
      id_ = other.id_;
      type_ = other.type_;
      jDHGPNIGEEG_ = other.jDHGPNIGEEG_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PGFCMDKKODD Clone() {
      return new PGFCMDKKODD(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 5;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.MissionSyncRecord type_ = global::EggLink.DanhengServer.Proto.MissionSyncRecord.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MissionSyncRecord Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "JDHGPNIGEEG" field.</summary>
    public const int JDHGPNIGEEGFieldNumber = 10;
    private uint jDHGPNIGEEG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JDHGPNIGEEG {
      get { return jDHGPNIGEEG_; }
      set {
        jDHGPNIGEEG_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PGFCMDKKODD);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PGFCMDKKODD other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Type != other.Type) return false;
      if (JDHGPNIGEEG != other.JDHGPNIGEEG) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Type != global::EggLink.DanhengServer.Proto.MissionSyncRecord.None) hash ^= Type.GetHashCode();
      if (JDHGPNIGEEG != 0) hash ^= JDHGPNIGEEG.GetHashCode();
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
        output.WriteRawTag(40);
        output.WriteUInt32(Id);
      }
      if (Type != global::EggLink.DanhengServer.Proto.MissionSyncRecord.None) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Type);
      }
      if (JDHGPNIGEEG != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(JDHGPNIGEEG);
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
        output.WriteRawTag(40);
        output.WriteUInt32(Id);
      }
      if (Type != global::EggLink.DanhengServer.Proto.MissionSyncRecord.None) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Type);
      }
      if (JDHGPNIGEEG != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(JDHGPNIGEEG);
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
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (Type != global::EggLink.DanhengServer.Proto.MissionSyncRecord.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (JDHGPNIGEEG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JDHGPNIGEEG);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PGFCMDKKODD other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Type != global::EggLink.DanhengServer.Proto.MissionSyncRecord.None) {
        Type = other.Type;
      }
      if (other.JDHGPNIGEEG != 0) {
        JDHGPNIGEEG = other.JDHGPNIGEEG;
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
          case 40: {
            Id = input.ReadUInt32();
            break;
          }
          case 72: {
            Type = (global::EggLink.DanhengServer.Proto.MissionSyncRecord) input.ReadEnum();
            break;
          }
          case 80: {
            JDHGPNIGEEG = input.ReadUInt32();
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
          case 40: {
            Id = input.ReadUInt32();
            break;
          }
          case 72: {
            Type = (global::EggLink.DanhengServer.Proto.MissionSyncRecord) input.ReadEnum();
            break;
          }
          case 80: {
            JDHGPNIGEEG = input.ReadUInt32();
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
