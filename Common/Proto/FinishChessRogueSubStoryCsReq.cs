// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FinishChessRogueSubStoryCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FinishChessRogueSubStoryCsReq.proto</summary>
  public static partial class FinishChessRogueSubStoryCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for FinishChessRogueSubStoryCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FinishChessRogueSubStoryCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNGaW5pc2hDaGVzc1JvZ3VlU3ViU3RvcnlDc1JlcS5wcm90byJeCh1GaW5p",
            "c2hDaGVzc1JvZ3VlU3ViU3RvcnlDc1JlcRITCgtIRUlFT0ZITUFDQRgCIAEo",
            "DRITCgtPR0FET0RLR0xOTBgEIAEoDRITCgtHS0FJT0dOQ0RORRgLIAEoDUIe",
            "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FinishChessRogueSubStoryCsReq), global::EggLink.DanhengServer.Proto.FinishChessRogueSubStoryCsReq.Parser, new[]{ "HEIEOFHMACA", "OGADODKGLNL", "GKAIOGNCDNE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FinishChessRogueSubStoryCsReq : pb::IMessage<FinishChessRogueSubStoryCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FinishChessRogueSubStoryCsReq> _parser = new pb::MessageParser<FinishChessRogueSubStoryCsReq>(() => new FinishChessRogueSubStoryCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FinishChessRogueSubStoryCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FinishChessRogueSubStoryCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishChessRogueSubStoryCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishChessRogueSubStoryCsReq(FinishChessRogueSubStoryCsReq other) : this() {
      hEIEOFHMACA_ = other.hEIEOFHMACA_;
      oGADODKGLNL_ = other.oGADODKGLNL_;
      gKAIOGNCDNE_ = other.gKAIOGNCDNE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishChessRogueSubStoryCsReq Clone() {
      return new FinishChessRogueSubStoryCsReq(this);
    }

    /// <summary>Field number for the "HEIEOFHMACA" field.</summary>
    public const int HEIEOFHMACAFieldNumber = 2;
    private uint hEIEOFHMACA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HEIEOFHMACA {
      get { return hEIEOFHMACA_; }
      set {
        hEIEOFHMACA_ = value;
      }
    }

    /// <summary>Field number for the "OGADODKGLNL" field.</summary>
    public const int OGADODKGLNLFieldNumber = 4;
    private uint oGADODKGLNL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OGADODKGLNL {
      get { return oGADODKGLNL_; }
      set {
        oGADODKGLNL_ = value;
      }
    }

    /// <summary>Field number for the "GKAIOGNCDNE" field.</summary>
    public const int GKAIOGNCDNEFieldNumber = 11;
    private uint gKAIOGNCDNE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GKAIOGNCDNE {
      get { return gKAIOGNCDNE_; }
      set {
        gKAIOGNCDNE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FinishChessRogueSubStoryCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FinishChessRogueSubStoryCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HEIEOFHMACA != other.HEIEOFHMACA) return false;
      if (OGADODKGLNL != other.OGADODKGLNL) return false;
      if (GKAIOGNCDNE != other.GKAIOGNCDNE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HEIEOFHMACA != 0) hash ^= HEIEOFHMACA.GetHashCode();
      if (OGADODKGLNL != 0) hash ^= OGADODKGLNL.GetHashCode();
      if (GKAIOGNCDNE != 0) hash ^= GKAIOGNCDNE.GetHashCode();
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
      if (HEIEOFHMACA != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(HEIEOFHMACA);
      }
      if (OGADODKGLNL != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OGADODKGLNL);
      }
      if (GKAIOGNCDNE != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GKAIOGNCDNE);
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
      if (HEIEOFHMACA != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(HEIEOFHMACA);
      }
      if (OGADODKGLNL != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OGADODKGLNL);
      }
      if (GKAIOGNCDNE != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GKAIOGNCDNE);
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
      if (HEIEOFHMACA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HEIEOFHMACA);
      }
      if (OGADODKGLNL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OGADODKGLNL);
      }
      if (GKAIOGNCDNE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GKAIOGNCDNE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FinishChessRogueSubStoryCsReq other) {
      if (other == null) {
        return;
      }
      if (other.HEIEOFHMACA != 0) {
        HEIEOFHMACA = other.HEIEOFHMACA;
      }
      if (other.OGADODKGLNL != 0) {
        OGADODKGLNL = other.OGADODKGLNL;
      }
      if (other.GKAIOGNCDNE != 0) {
        GKAIOGNCDNE = other.GKAIOGNCDNE;
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
            HEIEOFHMACA = input.ReadUInt32();
            break;
          }
          case 32: {
            OGADODKGLNL = input.ReadUInt32();
            break;
          }
          case 88: {
            GKAIOGNCDNE = input.ReadUInt32();
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
            HEIEOFHMACA = input.ReadUInt32();
            break;
          }
          case 32: {
            OGADODKGLNL = input.ReadUInt32();
            break;
          }
          case 88: {
            GKAIOGNCDNE = input.ReadUInt32();
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
