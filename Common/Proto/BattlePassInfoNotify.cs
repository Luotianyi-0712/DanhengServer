// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattlePassInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BattlePassInfoNotify.proto</summary>
  public static partial class BattlePassInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for BattlePassInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattlePassInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpCYXR0bGVQYXNzSW5mb05vdGlmeS5wcm90bxoQQnBUaWVyVHlwZS5wcm90",
            "byKiAgoUQmF0dGxlUGFzc0luZm9Ob3RpZnkSEwoLRERKSERMTUhQREYYAiAB",
            "KAQSEwoLTkFESU5LSFBDRkEYByABKAQSEwoLQklCT0RKRUhFSkkYCSABKAQS",
            "DQoFbGV2ZWwYDyABKA0SEwoLTEZNQUFQREdLQlAYBCABKAQSEwoLSkZOTEVL",
            "RkVQUEcYASABKAQSEwoLRFBJTE9NUEZDSkkYCyABKAQSEwoLUEdLQUdHTE9G",
            "UEcYDSABKAQSEwoLS1BBTEtNRUxDTk8YBSABKA0SEwoLT0dPSktCT09OSE8Y",
            "DCABKAQSCwoDZXhwGAggASgNEhwKB2JwX3RpZXIYAyABKA4yCy5CcFRpZXJU",
            "eXBlEhMKC01MRkNIREZMS0lGGA4gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BpTierTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BattlePassInfoNotify), global::EggLink.DanhengServer.Proto.BattlePassInfoNotify.Parser, new[]{ "DDJHDLMHPDF", "NADINKHPCFA", "BIBODJEHEJI", "Level", "LFMAAPDGKBP", "JFNLEKFEPPG", "DPILOMPFCJI", "PGKAGGLOFPG", "KPALKMELCNO", "OGOJKBOONHO", "Exp", "BpTier", "MLFCHDFLKIF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BattlePassInfoNotify : pb::IMessage<BattlePassInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BattlePassInfoNotify> _parser = new pb::MessageParser<BattlePassInfoNotify>(() => new BattlePassInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BattlePassInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BattlePassInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassInfoNotify(BattlePassInfoNotify other) : this() {
      dDJHDLMHPDF_ = other.dDJHDLMHPDF_;
      nADINKHPCFA_ = other.nADINKHPCFA_;
      bIBODJEHEJI_ = other.bIBODJEHEJI_;
      level_ = other.level_;
      lFMAAPDGKBP_ = other.lFMAAPDGKBP_;
      jFNLEKFEPPG_ = other.jFNLEKFEPPG_;
      dPILOMPFCJI_ = other.dPILOMPFCJI_;
      pGKAGGLOFPG_ = other.pGKAGGLOFPG_;
      kPALKMELCNO_ = other.kPALKMELCNO_;
      oGOJKBOONHO_ = other.oGOJKBOONHO_;
      exp_ = other.exp_;
      bpTier_ = other.bpTier_;
      mLFCHDFLKIF_ = other.mLFCHDFLKIF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassInfoNotify Clone() {
      return new BattlePassInfoNotify(this);
    }

    /// <summary>Field number for the "DDJHDLMHPDF" field.</summary>
    public const int DDJHDLMHPDFFieldNumber = 2;
    private ulong dDJHDLMHPDF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong DDJHDLMHPDF {
      get { return dDJHDLMHPDF_; }
      set {
        dDJHDLMHPDF_ = value;
      }
    }

    /// <summary>Field number for the "NADINKHPCFA" field.</summary>
    public const int NADINKHPCFAFieldNumber = 7;
    private ulong nADINKHPCFA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong NADINKHPCFA {
      get { return nADINKHPCFA_; }
      set {
        nADINKHPCFA_ = value;
      }
    }

    /// <summary>Field number for the "BIBODJEHEJI" field.</summary>
    public const int BIBODJEHEJIFieldNumber = 9;
    private ulong bIBODJEHEJI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong BIBODJEHEJI {
      get { return bIBODJEHEJI_; }
      set {
        bIBODJEHEJI_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 15;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "LFMAAPDGKBP" field.</summary>
    public const int LFMAAPDGKBPFieldNumber = 4;
    private ulong lFMAAPDGKBP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong LFMAAPDGKBP {
      get { return lFMAAPDGKBP_; }
      set {
        lFMAAPDGKBP_ = value;
      }
    }

    /// <summary>Field number for the "JFNLEKFEPPG" field.</summary>
    public const int JFNLEKFEPPGFieldNumber = 1;
    private ulong jFNLEKFEPPG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong JFNLEKFEPPG {
      get { return jFNLEKFEPPG_; }
      set {
        jFNLEKFEPPG_ = value;
      }
    }

    /// <summary>Field number for the "DPILOMPFCJI" field.</summary>
    public const int DPILOMPFCJIFieldNumber = 11;
    private ulong dPILOMPFCJI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong DPILOMPFCJI {
      get { return dPILOMPFCJI_; }
      set {
        dPILOMPFCJI_ = value;
      }
    }

    /// <summary>Field number for the "PGKAGGLOFPG" field.</summary>
    public const int PGKAGGLOFPGFieldNumber = 13;
    private ulong pGKAGGLOFPG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong PGKAGGLOFPG {
      get { return pGKAGGLOFPG_; }
      set {
        pGKAGGLOFPG_ = value;
      }
    }

    /// <summary>Field number for the "KPALKMELCNO" field.</summary>
    public const int KPALKMELCNOFieldNumber = 5;
    private uint kPALKMELCNO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KPALKMELCNO {
      get { return kPALKMELCNO_; }
      set {
        kPALKMELCNO_ = value;
      }
    }

    /// <summary>Field number for the "OGOJKBOONHO" field.</summary>
    public const int OGOJKBOONHOFieldNumber = 12;
    private ulong oGOJKBOONHO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong OGOJKBOONHO {
      get { return oGOJKBOONHO_; }
      set {
        oGOJKBOONHO_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 8;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "bp_tier" field.</summary>
    public const int BpTierFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.BpTierType bpTier_ = global::EggLink.DanhengServer.Proto.BpTierType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BpTierType BpTier {
      get { return bpTier_; }
      set {
        bpTier_ = value;
      }
    }

    /// <summary>Field number for the "MLFCHDFLKIF" field.</summary>
    public const int MLFCHDFLKIFFieldNumber = 14;
    private uint mLFCHDFLKIF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MLFCHDFLKIF {
      get { return mLFCHDFLKIF_; }
      set {
        mLFCHDFLKIF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BattlePassInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BattlePassInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DDJHDLMHPDF != other.DDJHDLMHPDF) return false;
      if (NADINKHPCFA != other.NADINKHPCFA) return false;
      if (BIBODJEHEJI != other.BIBODJEHEJI) return false;
      if (Level != other.Level) return false;
      if (LFMAAPDGKBP != other.LFMAAPDGKBP) return false;
      if (JFNLEKFEPPG != other.JFNLEKFEPPG) return false;
      if (DPILOMPFCJI != other.DPILOMPFCJI) return false;
      if (PGKAGGLOFPG != other.PGKAGGLOFPG) return false;
      if (KPALKMELCNO != other.KPALKMELCNO) return false;
      if (OGOJKBOONHO != other.OGOJKBOONHO) return false;
      if (Exp != other.Exp) return false;
      if (BpTier != other.BpTier) return false;
      if (MLFCHDFLKIF != other.MLFCHDFLKIF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DDJHDLMHPDF != 0UL) hash ^= DDJHDLMHPDF.GetHashCode();
      if (NADINKHPCFA != 0UL) hash ^= NADINKHPCFA.GetHashCode();
      if (BIBODJEHEJI != 0UL) hash ^= BIBODJEHEJI.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (LFMAAPDGKBP != 0UL) hash ^= LFMAAPDGKBP.GetHashCode();
      if (JFNLEKFEPPG != 0UL) hash ^= JFNLEKFEPPG.GetHashCode();
      if (DPILOMPFCJI != 0UL) hash ^= DPILOMPFCJI.GetHashCode();
      if (PGKAGGLOFPG != 0UL) hash ^= PGKAGGLOFPG.GetHashCode();
      if (KPALKMELCNO != 0) hash ^= KPALKMELCNO.GetHashCode();
      if (OGOJKBOONHO != 0UL) hash ^= OGOJKBOONHO.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (BpTier != global::EggLink.DanhengServer.Proto.BpTierType.None) hash ^= BpTier.GetHashCode();
      if (MLFCHDFLKIF != 0) hash ^= MLFCHDFLKIF.GetHashCode();
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
      if (JFNLEKFEPPG != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(JFNLEKFEPPG);
      }
      if (DDJHDLMHPDF != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(DDJHDLMHPDF);
      }
      if (BpTier != global::EggLink.DanhengServer.Proto.BpTierType.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) BpTier);
      }
      if (LFMAAPDGKBP != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(LFMAAPDGKBP);
      }
      if (KPALKMELCNO != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(KPALKMELCNO);
      }
      if (NADINKHPCFA != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(NADINKHPCFA);
      }
      if (Exp != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Exp);
      }
      if (BIBODJEHEJI != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(BIBODJEHEJI);
      }
      if (DPILOMPFCJI != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(DPILOMPFCJI);
      }
      if (OGOJKBOONHO != 0UL) {
        output.WriteRawTag(96);
        output.WriteUInt64(OGOJKBOONHO);
      }
      if (PGKAGGLOFPG != 0UL) {
        output.WriteRawTag(104);
        output.WriteUInt64(PGKAGGLOFPG);
      }
      if (MLFCHDFLKIF != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MLFCHDFLKIF);
      }
      if (Level != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Level);
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
      if (JFNLEKFEPPG != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(JFNLEKFEPPG);
      }
      if (DDJHDLMHPDF != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(DDJHDLMHPDF);
      }
      if (BpTier != global::EggLink.DanhengServer.Proto.BpTierType.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) BpTier);
      }
      if (LFMAAPDGKBP != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(LFMAAPDGKBP);
      }
      if (KPALKMELCNO != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(KPALKMELCNO);
      }
      if (NADINKHPCFA != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(NADINKHPCFA);
      }
      if (Exp != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Exp);
      }
      if (BIBODJEHEJI != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(BIBODJEHEJI);
      }
      if (DPILOMPFCJI != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(DPILOMPFCJI);
      }
      if (OGOJKBOONHO != 0UL) {
        output.WriteRawTag(96);
        output.WriteUInt64(OGOJKBOONHO);
      }
      if (PGKAGGLOFPG != 0UL) {
        output.WriteRawTag(104);
        output.WriteUInt64(PGKAGGLOFPG);
      }
      if (MLFCHDFLKIF != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MLFCHDFLKIF);
      }
      if (Level != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Level);
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
      if (DDJHDLMHPDF != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DDJHDLMHPDF);
      }
      if (NADINKHPCFA != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(NADINKHPCFA);
      }
      if (BIBODJEHEJI != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(BIBODJEHEJI);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (LFMAAPDGKBP != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(LFMAAPDGKBP);
      }
      if (JFNLEKFEPPG != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(JFNLEKFEPPG);
      }
      if (DPILOMPFCJI != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DPILOMPFCJI);
      }
      if (PGKAGGLOFPG != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PGKAGGLOFPG);
      }
      if (KPALKMELCNO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KPALKMELCNO);
      }
      if (OGOJKBOONHO != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(OGOJKBOONHO);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (BpTier != global::EggLink.DanhengServer.Proto.BpTierType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BpTier);
      }
      if (MLFCHDFLKIF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MLFCHDFLKIF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BattlePassInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.DDJHDLMHPDF != 0UL) {
        DDJHDLMHPDF = other.DDJHDLMHPDF;
      }
      if (other.NADINKHPCFA != 0UL) {
        NADINKHPCFA = other.NADINKHPCFA;
      }
      if (other.BIBODJEHEJI != 0UL) {
        BIBODJEHEJI = other.BIBODJEHEJI;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.LFMAAPDGKBP != 0UL) {
        LFMAAPDGKBP = other.LFMAAPDGKBP;
      }
      if (other.JFNLEKFEPPG != 0UL) {
        JFNLEKFEPPG = other.JFNLEKFEPPG;
      }
      if (other.DPILOMPFCJI != 0UL) {
        DPILOMPFCJI = other.DPILOMPFCJI;
      }
      if (other.PGKAGGLOFPG != 0UL) {
        PGKAGGLOFPG = other.PGKAGGLOFPG;
      }
      if (other.KPALKMELCNO != 0) {
        KPALKMELCNO = other.KPALKMELCNO;
      }
      if (other.OGOJKBOONHO != 0UL) {
        OGOJKBOONHO = other.OGOJKBOONHO;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.BpTier != global::EggLink.DanhengServer.Proto.BpTierType.None) {
        BpTier = other.BpTier;
      }
      if (other.MLFCHDFLKIF != 0) {
        MLFCHDFLKIF = other.MLFCHDFLKIF;
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
            JFNLEKFEPPG = input.ReadUInt64();
            break;
          }
          case 16: {
            DDJHDLMHPDF = input.ReadUInt64();
            break;
          }
          case 24: {
            BpTier = (global::EggLink.DanhengServer.Proto.BpTierType) input.ReadEnum();
            break;
          }
          case 32: {
            LFMAAPDGKBP = input.ReadUInt64();
            break;
          }
          case 40: {
            KPALKMELCNO = input.ReadUInt32();
            break;
          }
          case 56: {
            NADINKHPCFA = input.ReadUInt64();
            break;
          }
          case 64: {
            Exp = input.ReadUInt32();
            break;
          }
          case 72: {
            BIBODJEHEJI = input.ReadUInt64();
            break;
          }
          case 88: {
            DPILOMPFCJI = input.ReadUInt64();
            break;
          }
          case 96: {
            OGOJKBOONHO = input.ReadUInt64();
            break;
          }
          case 104: {
            PGKAGGLOFPG = input.ReadUInt64();
            break;
          }
          case 112: {
            MLFCHDFLKIF = input.ReadUInt32();
            break;
          }
          case 120: {
            Level = input.ReadUInt32();
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
            JFNLEKFEPPG = input.ReadUInt64();
            break;
          }
          case 16: {
            DDJHDLMHPDF = input.ReadUInt64();
            break;
          }
          case 24: {
            BpTier = (global::EggLink.DanhengServer.Proto.BpTierType) input.ReadEnum();
            break;
          }
          case 32: {
            LFMAAPDGKBP = input.ReadUInt64();
            break;
          }
          case 40: {
            KPALKMELCNO = input.ReadUInt32();
            break;
          }
          case 56: {
            NADINKHPCFA = input.ReadUInt64();
            break;
          }
          case 64: {
            Exp = input.ReadUInt32();
            break;
          }
          case 72: {
            BIBODJEHEJI = input.ReadUInt64();
            break;
          }
          case 88: {
            DPILOMPFCJI = input.ReadUInt64();
            break;
          }
          case 96: {
            OGOJKBOONHO = input.ReadUInt64();
            break;
          }
          case 104: {
            PGKAGGLOFPG = input.ReadUInt64();
            break;
          }
          case 112: {
            MLFCHDFLKIF = input.ReadUInt32();
            break;
          }
          case 120: {
            Level = input.ReadUInt32();
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
