// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueEndlessLayerInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueEndlessLayerInfo.proto</summary>
  public static partial class RogueEndlessLayerInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueEndlessLayerInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueEndlessLayerInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtSb2d1ZUVuZGxlc3NMYXllckluZm8ucHJvdG8ivQEKFVJvZ3VlRW5kbGVz",
            "c0xheWVySW5mbxITCgtDTklGRURFRE5LSxgHIAEoDRITCgtKR0NISkdHTEhH",
            "RhgBIAEoDRITCgtMTk1NSFBLQ0RJQRgFIAEoCBITCgtOTUxDTkZIRUJEUBgN",
            "IAEoDRIRCgliYXR0bGVfaWQYCSABKA0SEwoLTEZHTkVCS09JUE0YCyABKA0S",
            "EwoLQkVKQ1BJTUFQQkYYBCABKA0SEwoLTkdMT0FITFBHTEgYCiABKA1CHqoC",
            "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueEndlessLayerInfo), global::EggLink.DanhengServer.Proto.RogueEndlessLayerInfo.Parser, new[]{ "CNIFEDEDNKK", "JGCHJGGLHGF", "LNMMHPKCDIA", "NMLCNFHEBDP", "BattleId", "LFGNEBKOIPM", "BEJCPIMAPBF", "NGLOAHLPGLH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueEndlessLayerInfo : pb::IMessage<RogueEndlessLayerInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueEndlessLayerInfo> _parser = new pb::MessageParser<RogueEndlessLayerInfo>(() => new RogueEndlessLayerInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueEndlessLayerInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueEndlessLayerInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueEndlessLayerInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueEndlessLayerInfo(RogueEndlessLayerInfo other) : this() {
      cNIFEDEDNKK_ = other.cNIFEDEDNKK_;
      jGCHJGGLHGF_ = other.jGCHJGGLHGF_;
      lNMMHPKCDIA_ = other.lNMMHPKCDIA_;
      nMLCNFHEBDP_ = other.nMLCNFHEBDP_;
      battleId_ = other.battleId_;
      lFGNEBKOIPM_ = other.lFGNEBKOIPM_;
      bEJCPIMAPBF_ = other.bEJCPIMAPBF_;
      nGLOAHLPGLH_ = other.nGLOAHLPGLH_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueEndlessLayerInfo Clone() {
      return new RogueEndlessLayerInfo(this);
    }

    /// <summary>Field number for the "CNIFEDEDNKK" field.</summary>
    public const int CNIFEDEDNKKFieldNumber = 7;
    private uint cNIFEDEDNKK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CNIFEDEDNKK {
      get { return cNIFEDEDNKK_; }
      set {
        cNIFEDEDNKK_ = value;
      }
    }

    /// <summary>Field number for the "JGCHJGGLHGF" field.</summary>
    public const int JGCHJGGLHGFFieldNumber = 1;
    private uint jGCHJGGLHGF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JGCHJGGLHGF {
      get { return jGCHJGGLHGF_; }
      set {
        jGCHJGGLHGF_ = value;
      }
    }

    /// <summary>Field number for the "LNMMHPKCDIA" field.</summary>
    public const int LNMMHPKCDIAFieldNumber = 5;
    private bool lNMMHPKCDIA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool LNMMHPKCDIA {
      get { return lNMMHPKCDIA_; }
      set {
        lNMMHPKCDIA_ = value;
      }
    }

    /// <summary>Field number for the "NMLCNFHEBDP" field.</summary>
    public const int NMLCNFHEBDPFieldNumber = 13;
    private uint nMLCNFHEBDP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NMLCNFHEBDP {
      get { return nMLCNFHEBDP_; }
      set {
        nMLCNFHEBDP_ = value;
      }
    }

    /// <summary>Field number for the "battle_id" field.</summary>
    public const int BattleIdFieldNumber = 9;
    private uint battleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BattleId {
      get { return battleId_; }
      set {
        battleId_ = value;
      }
    }

    /// <summary>Field number for the "LFGNEBKOIPM" field.</summary>
    public const int LFGNEBKOIPMFieldNumber = 11;
    private uint lFGNEBKOIPM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LFGNEBKOIPM {
      get { return lFGNEBKOIPM_; }
      set {
        lFGNEBKOIPM_ = value;
      }
    }

    /// <summary>Field number for the "BEJCPIMAPBF" field.</summary>
    public const int BEJCPIMAPBFFieldNumber = 4;
    private uint bEJCPIMAPBF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BEJCPIMAPBF {
      get { return bEJCPIMAPBF_; }
      set {
        bEJCPIMAPBF_ = value;
      }
    }

    /// <summary>Field number for the "NGLOAHLPGLH" field.</summary>
    public const int NGLOAHLPGLHFieldNumber = 10;
    private uint nGLOAHLPGLH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NGLOAHLPGLH {
      get { return nGLOAHLPGLH_; }
      set {
        nGLOAHLPGLH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueEndlessLayerInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueEndlessLayerInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CNIFEDEDNKK != other.CNIFEDEDNKK) return false;
      if (JGCHJGGLHGF != other.JGCHJGGLHGF) return false;
      if (LNMMHPKCDIA != other.LNMMHPKCDIA) return false;
      if (NMLCNFHEBDP != other.NMLCNFHEBDP) return false;
      if (BattleId != other.BattleId) return false;
      if (LFGNEBKOIPM != other.LFGNEBKOIPM) return false;
      if (BEJCPIMAPBF != other.BEJCPIMAPBF) return false;
      if (NGLOAHLPGLH != other.NGLOAHLPGLH) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CNIFEDEDNKK != 0) hash ^= CNIFEDEDNKK.GetHashCode();
      if (JGCHJGGLHGF != 0) hash ^= JGCHJGGLHGF.GetHashCode();
      if (LNMMHPKCDIA != false) hash ^= LNMMHPKCDIA.GetHashCode();
      if (NMLCNFHEBDP != 0) hash ^= NMLCNFHEBDP.GetHashCode();
      if (BattleId != 0) hash ^= BattleId.GetHashCode();
      if (LFGNEBKOIPM != 0) hash ^= LFGNEBKOIPM.GetHashCode();
      if (BEJCPIMAPBF != 0) hash ^= BEJCPIMAPBF.GetHashCode();
      if (NGLOAHLPGLH != 0) hash ^= NGLOAHLPGLH.GetHashCode();
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
      if (JGCHJGGLHGF != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(JGCHJGGLHGF);
      }
      if (BEJCPIMAPBF != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(BEJCPIMAPBF);
      }
      if (LNMMHPKCDIA != false) {
        output.WriteRawTag(40);
        output.WriteBool(LNMMHPKCDIA);
      }
      if (CNIFEDEDNKK != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CNIFEDEDNKK);
      }
      if (BattleId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(BattleId);
      }
      if (NGLOAHLPGLH != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(NGLOAHLPGLH);
      }
      if (LFGNEBKOIPM != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(LFGNEBKOIPM);
      }
      if (NMLCNFHEBDP != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(NMLCNFHEBDP);
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
      if (JGCHJGGLHGF != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(JGCHJGGLHGF);
      }
      if (BEJCPIMAPBF != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(BEJCPIMAPBF);
      }
      if (LNMMHPKCDIA != false) {
        output.WriteRawTag(40);
        output.WriteBool(LNMMHPKCDIA);
      }
      if (CNIFEDEDNKK != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CNIFEDEDNKK);
      }
      if (BattleId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(BattleId);
      }
      if (NGLOAHLPGLH != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(NGLOAHLPGLH);
      }
      if (LFGNEBKOIPM != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(LFGNEBKOIPM);
      }
      if (NMLCNFHEBDP != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(NMLCNFHEBDP);
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
      if (CNIFEDEDNKK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CNIFEDEDNKK);
      }
      if (JGCHJGGLHGF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JGCHJGGLHGF);
      }
      if (LNMMHPKCDIA != false) {
        size += 1 + 1;
      }
      if (NMLCNFHEBDP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NMLCNFHEBDP);
      }
      if (BattleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BattleId);
      }
      if (LFGNEBKOIPM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LFGNEBKOIPM);
      }
      if (BEJCPIMAPBF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BEJCPIMAPBF);
      }
      if (NGLOAHLPGLH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NGLOAHLPGLH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueEndlessLayerInfo other) {
      if (other == null) {
        return;
      }
      if (other.CNIFEDEDNKK != 0) {
        CNIFEDEDNKK = other.CNIFEDEDNKK;
      }
      if (other.JGCHJGGLHGF != 0) {
        JGCHJGGLHGF = other.JGCHJGGLHGF;
      }
      if (other.LNMMHPKCDIA != false) {
        LNMMHPKCDIA = other.LNMMHPKCDIA;
      }
      if (other.NMLCNFHEBDP != 0) {
        NMLCNFHEBDP = other.NMLCNFHEBDP;
      }
      if (other.BattleId != 0) {
        BattleId = other.BattleId;
      }
      if (other.LFGNEBKOIPM != 0) {
        LFGNEBKOIPM = other.LFGNEBKOIPM;
      }
      if (other.BEJCPIMAPBF != 0) {
        BEJCPIMAPBF = other.BEJCPIMAPBF;
      }
      if (other.NGLOAHLPGLH != 0) {
        NGLOAHLPGLH = other.NGLOAHLPGLH;
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
            JGCHJGGLHGF = input.ReadUInt32();
            break;
          }
          case 32: {
            BEJCPIMAPBF = input.ReadUInt32();
            break;
          }
          case 40: {
            LNMMHPKCDIA = input.ReadBool();
            break;
          }
          case 56: {
            CNIFEDEDNKK = input.ReadUInt32();
            break;
          }
          case 72: {
            BattleId = input.ReadUInt32();
            break;
          }
          case 80: {
            NGLOAHLPGLH = input.ReadUInt32();
            break;
          }
          case 88: {
            LFGNEBKOIPM = input.ReadUInt32();
            break;
          }
          case 104: {
            NMLCNFHEBDP = input.ReadUInt32();
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
            JGCHJGGLHGF = input.ReadUInt32();
            break;
          }
          case 32: {
            BEJCPIMAPBF = input.ReadUInt32();
            break;
          }
          case 40: {
            LNMMHPKCDIA = input.ReadBool();
            break;
          }
          case 56: {
            CNIFEDEDNKK = input.ReadUInt32();
            break;
          }
          case 72: {
            BattleId = input.ReadUInt32();
            break;
          }
          case 80: {
            NGLOAHLPGLH = input.ReadUInt32();
            break;
          }
          case 88: {
            LFGNEBKOIPM = input.ReadUInt32();
            break;
          }
          case 104: {
            NMLCNFHEBDP = input.ReadUInt32();
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
