// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HandleRogueCommonPendingActionCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HandleRogueCommonPendingActionCsReq.proto</summary>
  public static partial class HandleRogueCommonPendingActionCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for HandleRogueCommonPendingActionCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HandleRogueCommonPendingActionCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilIYW5kbGVSb2d1ZUNvbW1vblBlbmRpbmdBY3Rpb25Dc1JlcS5wcm90bxob",
            "Um9ndWVCdWZmUmVyb2xsUmVzdWx0LnByb3RvGhFGQ0NQSUVCSERKQS5wcm90",
            "bxobUm9ndWVCdWZmU2VsZWN0UmVzdWx0LnByb3RvGhFPTE5BTEJHTkNQRS5w",
            "cm90bxoRSk5KTEZHREtISkMucHJvdG8aEUpBQ0JJSEdIQkJILnByb3RvGh5S",
            "b2d1ZU1pcmFjbGVTZWxlY3RSZXN1bHQucHJvdG8aEUpGQ0dQQkhIS0xELnBy",
            "b3RvGhFESUFMTEpMSEtFSy5wcm90bxocUm9ndWVCb251c1NlbGVjdFJlc3Vs",
            "dC5wcm90byL3AwojSGFuZGxlUm9ndWVDb21tb25QZW5kaW5nQWN0aW9uQ3NS",
            "ZXESFgoOcXVldWVfbG9jYXRpb24YCCABKA0SMwoSYnVmZl9zZWxlY3RfcmVz",
            "dWx0GIoOIAEoCzIWLlJvZ3VlQnVmZlNlbGVjdFJlc3VsdBIiCgtHS0NGT0ZK",
            "Q0ZMTxiLByABKAsyDC5KTkpMRkdES0hKQxIiCgtOTE1GR05MTkhKTBjJCiAB",
            "KAsyDC5GQ0NQSUVCSERKQRI6ChlidWZmX3Jlcm9sbF9zZWxlY3RfcmVzdWx0",
            "GIYLIAEoCzIWLlJvZ3VlQnVmZlJlcm9sbFJlc3VsdBI5ChVtaXJhY2xlX3Nl",
            "bGVjdF9yZXN1bHQYlwkgASgLMhkuUm9ndWVNaXJhY2xlU2VsZWN0UmVzdWx0",
            "EiEKC0dJTkpBSE1OTE1OGBUgASgLMgwuSkFDQklIR0hCQkgSIgoLTkxDUENJ",
            "T0JIS04YkAsgASgLMgwuRElBTExKTEhLRUsSIgoLTkZQUE1CQk1NSkwY3g4g",
            "ASgLMgwuT0xOQUxCR05DUEUSIgoLRUZHTlBOUEVERUEY3AEgASgLMgwuSkZD",
            "R1BCSEhLTEQSNQoTYm9udXNfc2VsZWN0X3Jlc3VsdBjaCSABKAsyFy5Sb2d1",
            "ZUJvbnVzU2VsZWN0UmVzdWx0Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueBuffRerollResultReflection.Descriptor, global::EggLink.DanhengServer.Proto.FCCPIEBHDJAReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueBuffSelectResultReflection.Descriptor, global::EggLink.DanhengServer.Proto.OLNALBGNCPEReflection.Descriptor, global::EggLink.DanhengServer.Proto.JNJLFGDKHJCReflection.Descriptor, global::EggLink.DanhengServer.Proto.JACBIHGHBBHReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueMiracleSelectResultReflection.Descriptor, global::EggLink.DanhengServer.Proto.JFCGPBHHKLDReflection.Descriptor, global::EggLink.DanhengServer.Proto.DIALLJLHKEKReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueBonusSelectResultReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HandleRogueCommonPendingActionCsReq), global::EggLink.DanhengServer.Proto.HandleRogueCommonPendingActionCsReq.Parser, new[]{ "QueueLocation", "BuffSelectResult", "GKCFOFJCFLO", "NLMFGNLNHJL", "BuffRerollSelectResult", "MiracleSelectResult", "GINJAHMNLMN", "NLCPCIOBHKN", "NFPPMBBMMJL", "EFGNPNPEDEA", "BonusSelectResult" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HandleRogueCommonPendingActionCsReq : pb::IMessage<HandleRogueCommonPendingActionCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HandleRogueCommonPendingActionCsReq> _parser = new pb::MessageParser<HandleRogueCommonPendingActionCsReq>(() => new HandleRogueCommonPendingActionCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HandleRogueCommonPendingActionCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HandleRogueCommonPendingActionCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HandleRogueCommonPendingActionCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HandleRogueCommonPendingActionCsReq(HandleRogueCommonPendingActionCsReq other) : this() {
      queueLocation_ = other.queueLocation_;
      buffSelectResult_ = other.buffSelectResult_ != null ? other.buffSelectResult_.Clone() : null;
      gKCFOFJCFLO_ = other.gKCFOFJCFLO_ != null ? other.gKCFOFJCFLO_.Clone() : null;
      nLMFGNLNHJL_ = other.nLMFGNLNHJL_ != null ? other.nLMFGNLNHJL_.Clone() : null;
      buffRerollSelectResult_ = other.buffRerollSelectResult_ != null ? other.buffRerollSelectResult_.Clone() : null;
      miracleSelectResult_ = other.miracleSelectResult_ != null ? other.miracleSelectResult_.Clone() : null;
      gINJAHMNLMN_ = other.gINJAHMNLMN_ != null ? other.gINJAHMNLMN_.Clone() : null;
      nLCPCIOBHKN_ = other.nLCPCIOBHKN_ != null ? other.nLCPCIOBHKN_.Clone() : null;
      nFPPMBBMMJL_ = other.nFPPMBBMMJL_ != null ? other.nFPPMBBMMJL_.Clone() : null;
      eFGNPNPEDEA_ = other.eFGNPNPEDEA_ != null ? other.eFGNPNPEDEA_.Clone() : null;
      bonusSelectResult_ = other.bonusSelectResult_ != null ? other.bonusSelectResult_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HandleRogueCommonPendingActionCsReq Clone() {
      return new HandleRogueCommonPendingActionCsReq(this);
    }

    /// <summary>Field number for the "queue_location" field.</summary>
    public const int QueueLocationFieldNumber = 8;
    private uint queueLocation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint QueueLocation {
      get { return queueLocation_; }
      set {
        queueLocation_ = value;
      }
    }

    /// <summary>Field number for the "buff_select_result" field.</summary>
    public const int BuffSelectResultFieldNumber = 1802;
    private global::EggLink.DanhengServer.Proto.RogueBuffSelectResult buffSelectResult_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueBuffSelectResult BuffSelectResult {
      get { return buffSelectResult_; }
      set {
        buffSelectResult_ = value;
      }
    }

    /// <summary>Field number for the "GKCFOFJCFLO" field.</summary>
    public const int GKCFOFJCFLOFieldNumber = 907;
    private global::EggLink.DanhengServer.Proto.JNJLFGDKHJC gKCFOFJCFLO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.JNJLFGDKHJC GKCFOFJCFLO {
      get { return gKCFOFJCFLO_; }
      set {
        gKCFOFJCFLO_ = value;
      }
    }

    /// <summary>Field number for the "NLMFGNLNHJL" field.</summary>
    public const int NLMFGNLNHJLFieldNumber = 1353;
    private global::EggLink.DanhengServer.Proto.FCCPIEBHDJA nLMFGNLNHJL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FCCPIEBHDJA NLMFGNLNHJL {
      get { return nLMFGNLNHJL_; }
      set {
        nLMFGNLNHJL_ = value;
      }
    }

    /// <summary>Field number for the "buff_reroll_select_result" field.</summary>
    public const int BuffRerollSelectResultFieldNumber = 1414;
    private global::EggLink.DanhengServer.Proto.RogueBuffRerollResult buffRerollSelectResult_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueBuffRerollResult BuffRerollSelectResult {
      get { return buffRerollSelectResult_; }
      set {
        buffRerollSelectResult_ = value;
      }
    }

    /// <summary>Field number for the "miracle_select_result" field.</summary>
    public const int MiracleSelectResultFieldNumber = 1175;
    private global::EggLink.DanhengServer.Proto.RogueMiracleSelectResult miracleSelectResult_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueMiracleSelectResult MiracleSelectResult {
      get { return miracleSelectResult_; }
      set {
        miracleSelectResult_ = value;
      }
    }

    /// <summary>Field number for the "GINJAHMNLMN" field.</summary>
    public const int GINJAHMNLMNFieldNumber = 21;
    private global::EggLink.DanhengServer.Proto.JACBIHGHBBH gINJAHMNLMN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.JACBIHGHBBH GINJAHMNLMN {
      get { return gINJAHMNLMN_; }
      set {
        gINJAHMNLMN_ = value;
      }
    }

    /// <summary>Field number for the "NLCPCIOBHKN" field.</summary>
    public const int NLCPCIOBHKNFieldNumber = 1424;
    private global::EggLink.DanhengServer.Proto.DIALLJLHKEK nLCPCIOBHKN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DIALLJLHKEK NLCPCIOBHKN {
      get { return nLCPCIOBHKN_; }
      set {
        nLCPCIOBHKN_ = value;
      }
    }

    /// <summary>Field number for the "NFPPMBBMMJL" field.</summary>
    public const int NFPPMBBMMJLFieldNumber = 1886;
    private global::EggLink.DanhengServer.Proto.OLNALBGNCPE nFPPMBBMMJL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.OLNALBGNCPE NFPPMBBMMJL {
      get { return nFPPMBBMMJL_; }
      set {
        nFPPMBBMMJL_ = value;
      }
    }

    /// <summary>Field number for the "EFGNPNPEDEA" field.</summary>
    public const int EFGNPNPEDEAFieldNumber = 220;
    private global::EggLink.DanhengServer.Proto.JFCGPBHHKLD eFGNPNPEDEA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.JFCGPBHHKLD EFGNPNPEDEA {
      get { return eFGNPNPEDEA_; }
      set {
        eFGNPNPEDEA_ = value;
      }
    }

    /// <summary>Field number for the "bonus_select_result" field.</summary>
    public const int BonusSelectResultFieldNumber = 1242;
    private global::EggLink.DanhengServer.Proto.RogueBonusSelectResult bonusSelectResult_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueBonusSelectResult BonusSelectResult {
      get { return bonusSelectResult_; }
      set {
        bonusSelectResult_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HandleRogueCommonPendingActionCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HandleRogueCommonPendingActionCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (QueueLocation != other.QueueLocation) return false;
      if (!object.Equals(BuffSelectResult, other.BuffSelectResult)) return false;
      if (!object.Equals(GKCFOFJCFLO, other.GKCFOFJCFLO)) return false;
      if (!object.Equals(NLMFGNLNHJL, other.NLMFGNLNHJL)) return false;
      if (!object.Equals(BuffRerollSelectResult, other.BuffRerollSelectResult)) return false;
      if (!object.Equals(MiracleSelectResult, other.MiracleSelectResult)) return false;
      if (!object.Equals(GINJAHMNLMN, other.GINJAHMNLMN)) return false;
      if (!object.Equals(NLCPCIOBHKN, other.NLCPCIOBHKN)) return false;
      if (!object.Equals(NFPPMBBMMJL, other.NFPPMBBMMJL)) return false;
      if (!object.Equals(EFGNPNPEDEA, other.EFGNPNPEDEA)) return false;
      if (!object.Equals(BonusSelectResult, other.BonusSelectResult)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (QueueLocation != 0) hash ^= QueueLocation.GetHashCode();
      if (buffSelectResult_ != null) hash ^= BuffSelectResult.GetHashCode();
      if (gKCFOFJCFLO_ != null) hash ^= GKCFOFJCFLO.GetHashCode();
      if (nLMFGNLNHJL_ != null) hash ^= NLMFGNLNHJL.GetHashCode();
      if (buffRerollSelectResult_ != null) hash ^= BuffRerollSelectResult.GetHashCode();
      if (miracleSelectResult_ != null) hash ^= MiracleSelectResult.GetHashCode();
      if (gINJAHMNLMN_ != null) hash ^= GINJAHMNLMN.GetHashCode();
      if (nLCPCIOBHKN_ != null) hash ^= NLCPCIOBHKN.GetHashCode();
      if (nFPPMBBMMJL_ != null) hash ^= NFPPMBBMMJL.GetHashCode();
      if (eFGNPNPEDEA_ != null) hash ^= EFGNPNPEDEA.GetHashCode();
      if (bonusSelectResult_ != null) hash ^= BonusSelectResult.GetHashCode();
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
      if (QueueLocation != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(QueueLocation);
      }
      if (gINJAHMNLMN_ != null) {
        output.WriteRawTag(170, 1);
        output.WriteMessage(GINJAHMNLMN);
      }
      if (eFGNPNPEDEA_ != null) {
        output.WriteRawTag(226, 13);
        output.WriteMessage(EFGNPNPEDEA);
      }
      if (gKCFOFJCFLO_ != null) {
        output.WriteRawTag(218, 56);
        output.WriteMessage(GKCFOFJCFLO);
      }
      if (miracleSelectResult_ != null) {
        output.WriteRawTag(186, 73);
        output.WriteMessage(MiracleSelectResult);
      }
      if (bonusSelectResult_ != null) {
        output.WriteRawTag(210, 77);
        output.WriteMessage(BonusSelectResult);
      }
      if (nLMFGNLNHJL_ != null) {
        output.WriteRawTag(202, 84);
        output.WriteMessage(NLMFGNLNHJL);
      }
      if (buffRerollSelectResult_ != null) {
        output.WriteRawTag(178, 88);
        output.WriteMessage(BuffRerollSelectResult);
      }
      if (nLCPCIOBHKN_ != null) {
        output.WriteRawTag(130, 89);
        output.WriteMessage(NLCPCIOBHKN);
      }
      if (buffSelectResult_ != null) {
        output.WriteRawTag(210, 112);
        output.WriteMessage(BuffSelectResult);
      }
      if (nFPPMBBMMJL_ != null) {
        output.WriteRawTag(242, 117);
        output.WriteMessage(NFPPMBBMMJL);
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
      if (QueueLocation != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(QueueLocation);
      }
      if (gINJAHMNLMN_ != null) {
        output.WriteRawTag(170, 1);
        output.WriteMessage(GINJAHMNLMN);
      }
      if (eFGNPNPEDEA_ != null) {
        output.WriteRawTag(226, 13);
        output.WriteMessage(EFGNPNPEDEA);
      }
      if (gKCFOFJCFLO_ != null) {
        output.WriteRawTag(218, 56);
        output.WriteMessage(GKCFOFJCFLO);
      }
      if (miracleSelectResult_ != null) {
        output.WriteRawTag(186, 73);
        output.WriteMessage(MiracleSelectResult);
      }
      if (bonusSelectResult_ != null) {
        output.WriteRawTag(210, 77);
        output.WriteMessage(BonusSelectResult);
      }
      if (nLMFGNLNHJL_ != null) {
        output.WriteRawTag(202, 84);
        output.WriteMessage(NLMFGNLNHJL);
      }
      if (buffRerollSelectResult_ != null) {
        output.WriteRawTag(178, 88);
        output.WriteMessage(BuffRerollSelectResult);
      }
      if (nLCPCIOBHKN_ != null) {
        output.WriteRawTag(130, 89);
        output.WriteMessage(NLCPCIOBHKN);
      }
      if (buffSelectResult_ != null) {
        output.WriteRawTag(210, 112);
        output.WriteMessage(BuffSelectResult);
      }
      if (nFPPMBBMMJL_ != null) {
        output.WriteRawTag(242, 117);
        output.WriteMessage(NFPPMBBMMJL);
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
      if (QueueLocation != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QueueLocation);
      }
      if (buffSelectResult_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(BuffSelectResult);
      }
      if (gKCFOFJCFLO_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(GKCFOFJCFLO);
      }
      if (nLMFGNLNHJL_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(NLMFGNLNHJL);
      }
      if (buffRerollSelectResult_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(BuffRerollSelectResult);
      }
      if (miracleSelectResult_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(MiracleSelectResult);
      }
      if (gINJAHMNLMN_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(GINJAHMNLMN);
      }
      if (nLCPCIOBHKN_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(NLCPCIOBHKN);
      }
      if (nFPPMBBMMJL_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(NFPPMBBMMJL);
      }
      if (eFGNPNPEDEA_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(EFGNPNPEDEA);
      }
      if (bonusSelectResult_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(BonusSelectResult);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HandleRogueCommonPendingActionCsReq other) {
      if (other == null) {
        return;
      }
      if (other.QueueLocation != 0) {
        QueueLocation = other.QueueLocation;
      }
      if (other.buffSelectResult_ != null) {
        if (buffSelectResult_ == null) {
          BuffSelectResult = new global::EggLink.DanhengServer.Proto.RogueBuffSelectResult();
        }
        BuffSelectResult.MergeFrom(other.BuffSelectResult);
      }
      if (other.gKCFOFJCFLO_ != null) {
        if (gKCFOFJCFLO_ == null) {
          GKCFOFJCFLO = new global::EggLink.DanhengServer.Proto.JNJLFGDKHJC();
        }
        GKCFOFJCFLO.MergeFrom(other.GKCFOFJCFLO);
      }
      if (other.nLMFGNLNHJL_ != null) {
        if (nLMFGNLNHJL_ == null) {
          NLMFGNLNHJL = new global::EggLink.DanhengServer.Proto.FCCPIEBHDJA();
        }
        NLMFGNLNHJL.MergeFrom(other.NLMFGNLNHJL);
      }
      if (other.buffRerollSelectResult_ != null) {
        if (buffRerollSelectResult_ == null) {
          BuffRerollSelectResult = new global::EggLink.DanhengServer.Proto.RogueBuffRerollResult();
        }
        BuffRerollSelectResult.MergeFrom(other.BuffRerollSelectResult);
      }
      if (other.miracleSelectResult_ != null) {
        if (miracleSelectResult_ == null) {
          MiracleSelectResult = new global::EggLink.DanhengServer.Proto.RogueMiracleSelectResult();
        }
        MiracleSelectResult.MergeFrom(other.MiracleSelectResult);
      }
      if (other.gINJAHMNLMN_ != null) {
        if (gINJAHMNLMN_ == null) {
          GINJAHMNLMN = new global::EggLink.DanhengServer.Proto.JACBIHGHBBH();
        }
        GINJAHMNLMN.MergeFrom(other.GINJAHMNLMN);
      }
      if (other.nLCPCIOBHKN_ != null) {
        if (nLCPCIOBHKN_ == null) {
          NLCPCIOBHKN = new global::EggLink.DanhengServer.Proto.DIALLJLHKEK();
        }
        NLCPCIOBHKN.MergeFrom(other.NLCPCIOBHKN);
      }
      if (other.nFPPMBBMMJL_ != null) {
        if (nFPPMBBMMJL_ == null) {
          NFPPMBBMMJL = new global::EggLink.DanhengServer.Proto.OLNALBGNCPE();
        }
        NFPPMBBMMJL.MergeFrom(other.NFPPMBBMMJL);
      }
      if (other.eFGNPNPEDEA_ != null) {
        if (eFGNPNPEDEA_ == null) {
          EFGNPNPEDEA = new global::EggLink.DanhengServer.Proto.JFCGPBHHKLD();
        }
        EFGNPNPEDEA.MergeFrom(other.EFGNPNPEDEA);
      }
      if (other.bonusSelectResult_ != null) {
        if (bonusSelectResult_ == null) {
          BonusSelectResult = new global::EggLink.DanhengServer.Proto.RogueBonusSelectResult();
        }
        BonusSelectResult.MergeFrom(other.BonusSelectResult);
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
          case 64: {
            QueueLocation = input.ReadUInt32();
            break;
          }
          case 170: {
            if (gINJAHMNLMN_ == null) {
              GINJAHMNLMN = new global::EggLink.DanhengServer.Proto.JACBIHGHBBH();
            }
            input.ReadMessage(GINJAHMNLMN);
            break;
          }
          case 1762: {
            if (eFGNPNPEDEA_ == null) {
              EFGNPNPEDEA = new global::EggLink.DanhengServer.Proto.JFCGPBHHKLD();
            }
            input.ReadMessage(EFGNPNPEDEA);
            break;
          }
          case 7258: {
            if (gKCFOFJCFLO_ == null) {
              GKCFOFJCFLO = new global::EggLink.DanhengServer.Proto.JNJLFGDKHJC();
            }
            input.ReadMessage(GKCFOFJCFLO);
            break;
          }
          case 9402: {
            if (miracleSelectResult_ == null) {
              MiracleSelectResult = new global::EggLink.DanhengServer.Proto.RogueMiracleSelectResult();
            }
            input.ReadMessage(MiracleSelectResult);
            break;
          }
          case 9938: {
            if (bonusSelectResult_ == null) {
              BonusSelectResult = new global::EggLink.DanhengServer.Proto.RogueBonusSelectResult();
            }
            input.ReadMessage(BonusSelectResult);
            break;
          }
          case 10826: {
            if (nLMFGNLNHJL_ == null) {
              NLMFGNLNHJL = new global::EggLink.DanhengServer.Proto.FCCPIEBHDJA();
            }
            input.ReadMessage(NLMFGNLNHJL);
            break;
          }
          case 11314: {
            if (buffRerollSelectResult_ == null) {
              BuffRerollSelectResult = new global::EggLink.DanhengServer.Proto.RogueBuffRerollResult();
            }
            input.ReadMessage(BuffRerollSelectResult);
            break;
          }
          case 11394: {
            if (nLCPCIOBHKN_ == null) {
              NLCPCIOBHKN = new global::EggLink.DanhengServer.Proto.DIALLJLHKEK();
            }
            input.ReadMessage(NLCPCIOBHKN);
            break;
          }
          case 14418: {
            if (buffSelectResult_ == null) {
              BuffSelectResult = new global::EggLink.DanhengServer.Proto.RogueBuffSelectResult();
            }
            input.ReadMessage(BuffSelectResult);
            break;
          }
          case 15090: {
            if (nFPPMBBMMJL_ == null) {
              NFPPMBBMMJL = new global::EggLink.DanhengServer.Proto.OLNALBGNCPE();
            }
            input.ReadMessage(NFPPMBBMMJL);
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
          case 64: {
            QueueLocation = input.ReadUInt32();
            break;
          }
          case 170: {
            if (gINJAHMNLMN_ == null) {
              GINJAHMNLMN = new global::EggLink.DanhengServer.Proto.JACBIHGHBBH();
            }
            input.ReadMessage(GINJAHMNLMN);
            break;
          }
          case 1762: {
            if (eFGNPNPEDEA_ == null) {
              EFGNPNPEDEA = new global::EggLink.DanhengServer.Proto.JFCGPBHHKLD();
            }
            input.ReadMessage(EFGNPNPEDEA);
            break;
          }
          case 7258: {
            if (gKCFOFJCFLO_ == null) {
              GKCFOFJCFLO = new global::EggLink.DanhengServer.Proto.JNJLFGDKHJC();
            }
            input.ReadMessage(GKCFOFJCFLO);
            break;
          }
          case 9402: {
            if (miracleSelectResult_ == null) {
              MiracleSelectResult = new global::EggLink.DanhengServer.Proto.RogueMiracleSelectResult();
            }
            input.ReadMessage(MiracleSelectResult);
            break;
          }
          case 9938: {
            if (bonusSelectResult_ == null) {
              BonusSelectResult = new global::EggLink.DanhengServer.Proto.RogueBonusSelectResult();
            }
            input.ReadMessage(BonusSelectResult);
            break;
          }
          case 10826: {
            if (nLMFGNLNHJL_ == null) {
              NLMFGNLNHJL = new global::EggLink.DanhengServer.Proto.FCCPIEBHDJA();
            }
            input.ReadMessage(NLMFGNLNHJL);
            break;
          }
          case 11314: {
            if (buffRerollSelectResult_ == null) {
              BuffRerollSelectResult = new global::EggLink.DanhengServer.Proto.RogueBuffRerollResult();
            }
            input.ReadMessage(BuffRerollSelectResult);
            break;
          }
          case 11394: {
            if (nLCPCIOBHKN_ == null) {
              NLCPCIOBHKN = new global::EggLink.DanhengServer.Proto.DIALLJLHKEK();
            }
            input.ReadMessage(NLCPCIOBHKN);
            break;
          }
          case 14418: {
            if (buffSelectResult_ == null) {
              BuffSelectResult = new global::EggLink.DanhengServer.Proto.RogueBuffSelectResult();
            }
            input.ReadMessage(BuffSelectResult);
            break;
          }
          case 15090: {
            if (nFPPMBBMMJL_ == null) {
              NFPPMBBMMJL = new global::EggLink.DanhengServer.Proto.OLNALBGNCPE();
            }
            input.ReadMessage(NFPPMBBMMJL);
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
