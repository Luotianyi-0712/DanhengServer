// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HeliobusSnsCommentCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HeliobusSnsCommentCsReq.proto</summary>
  public static partial class HeliobusSnsCommentCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for HeliobusSnsCommentCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeliobusSnsCommentCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1IZWxpb2J1c1Nuc0NvbW1lbnRDc1JlcS5wcm90byJYChdIZWxpb2J1c1Nu",
            "c0NvbW1lbnRDc1JlcRITCgtMQU5CTExCSUFBThgCIAEoDRITCgtDREJJR0ZN",
            "T05MTxgGIAEoDRITCgtPQ0NIRkpLSU9KUBgEIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HeliobusSnsCommentCsReq), global::EggLink.DanhengServer.Proto.HeliobusSnsCommentCsReq.Parser, new[]{ "LANBLLBIAAN", "CDBIGFMONLO", "OCCHFJKIOJP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HeliobusSnsCommentCsReq : pb::IMessage<HeliobusSnsCommentCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HeliobusSnsCommentCsReq> _parser = new pb::MessageParser<HeliobusSnsCommentCsReq>(() => new HeliobusSnsCommentCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HeliobusSnsCommentCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HeliobusSnsCommentCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeliobusSnsCommentCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeliobusSnsCommentCsReq(HeliobusSnsCommentCsReq other) : this() {
      lANBLLBIAAN_ = other.lANBLLBIAAN_;
      cDBIGFMONLO_ = other.cDBIGFMONLO_;
      oCCHFJKIOJP_ = other.oCCHFJKIOJP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeliobusSnsCommentCsReq Clone() {
      return new HeliobusSnsCommentCsReq(this);
    }

    /// <summary>Field number for the "LANBLLBIAAN" field.</summary>
    public const int LANBLLBIAANFieldNumber = 2;
    private uint lANBLLBIAAN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LANBLLBIAAN {
      get { return lANBLLBIAAN_; }
      set {
        lANBLLBIAAN_ = value;
      }
    }

    /// <summary>Field number for the "CDBIGFMONLO" field.</summary>
    public const int CDBIGFMONLOFieldNumber = 6;
    private uint cDBIGFMONLO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CDBIGFMONLO {
      get { return cDBIGFMONLO_; }
      set {
        cDBIGFMONLO_ = value;
      }
    }

    /// <summary>Field number for the "OCCHFJKIOJP" field.</summary>
    public const int OCCHFJKIOJPFieldNumber = 4;
    private uint oCCHFJKIOJP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OCCHFJKIOJP {
      get { return oCCHFJKIOJP_; }
      set {
        oCCHFJKIOJP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HeliobusSnsCommentCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HeliobusSnsCommentCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LANBLLBIAAN != other.LANBLLBIAAN) return false;
      if (CDBIGFMONLO != other.CDBIGFMONLO) return false;
      if (OCCHFJKIOJP != other.OCCHFJKIOJP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LANBLLBIAAN != 0) hash ^= LANBLLBIAAN.GetHashCode();
      if (CDBIGFMONLO != 0) hash ^= CDBIGFMONLO.GetHashCode();
      if (OCCHFJKIOJP != 0) hash ^= OCCHFJKIOJP.GetHashCode();
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
      if (LANBLLBIAAN != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LANBLLBIAAN);
      }
      if (OCCHFJKIOJP != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OCCHFJKIOJP);
      }
      if (CDBIGFMONLO != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CDBIGFMONLO);
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
      if (LANBLLBIAAN != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LANBLLBIAAN);
      }
      if (OCCHFJKIOJP != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OCCHFJKIOJP);
      }
      if (CDBIGFMONLO != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CDBIGFMONLO);
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
      if (LANBLLBIAAN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LANBLLBIAAN);
      }
      if (CDBIGFMONLO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CDBIGFMONLO);
      }
      if (OCCHFJKIOJP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OCCHFJKIOJP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HeliobusSnsCommentCsReq other) {
      if (other == null) {
        return;
      }
      if (other.LANBLLBIAAN != 0) {
        LANBLLBIAAN = other.LANBLLBIAAN;
      }
      if (other.CDBIGFMONLO != 0) {
        CDBIGFMONLO = other.CDBIGFMONLO;
      }
      if (other.OCCHFJKIOJP != 0) {
        OCCHFJKIOJP = other.OCCHFJKIOJP;
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
            LANBLLBIAAN = input.ReadUInt32();
            break;
          }
          case 32: {
            OCCHFJKIOJP = input.ReadUInt32();
            break;
          }
          case 48: {
            CDBIGFMONLO = input.ReadUInt32();
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
            LANBLLBIAAN = input.ReadUInt32();
            break;
          }
          case 32: {
            OCCHFJKIOJP = input.ReadUInt32();
            break;
          }
          case 48: {
            CDBIGFMONLO = input.ReadUInt32();
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
