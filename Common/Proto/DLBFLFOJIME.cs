// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DLBFLFOJIME.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DLBFLFOJIME.proto</summary>
  public static partial class DLBFLFOJIMEReflection {

    #region Descriptor
    /// <summary>File descriptor for DLBFLFOJIME.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DLBFLFOJIMEReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFETEJGTEZPSklNRS5wcm90bxofQ2hlc3NSb2d1ZUJvYXJkQ2VsbFN0YXR1",
            "cy5wcm90bxoRTEZEQ0xCUEROREYucHJvdG8aH0NoZXNzUm9ndWVDZWxsU3Bl",
            "Y2lhbFR5cGUucHJvdG8iwgIKC0RMQkZMRk9KSU1FEhMKC0xJQktIUEpITkdM",
            "GA0gASgNEg8KB3Jvb21faWQYCCABKA0SCgoCaWQYCSABKA0SEwoLTElMQkRC",
            "Rk9HRFAYBiADKA0SEwoLUEdMS09DTUxERkkYASABKAgSLwoLT0VNQUNOT0lK",
            "Tk0YAiABKA4yGi5DaGVzc1JvZ3VlQ2VsbFNwZWNpYWxUeXBlEhMKC0NOSUJL",
            "SlBNTENHGAQgASgNEhMKC0RHQkZJR0tIQVBOGAMgASgIEiEKC1BCSE9KTkxL",
            "S09MGAogASgLMgwuTEZEQ0xCUEROREYSEwoLR05CTkRKQk5QTU8YDiABKA0S",
            "LwoLRE9GRktHTUhDTUoYBSABKA4yGi5DaGVzc1JvZ3VlQm9hcmRDZWxsU3Rh",
            "dHVzEhMKC0RCSEtJQUFBQkFPGAsgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.LFDCLBPDNDFReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DLBFLFOJIME), global::EggLink.DanhengServer.Proto.DLBFLFOJIME.Parser, new[]{ "LIBKHPJHNGL", "RoomId", "Id", "LILBDBFOGDP", "PGLKOCMLDFI", "OEMACNOIJNM", "CNIBKJPMLCG", "DGBFIGKHAPN", "PBHOJNLKKOL", "GNBNDJBNPMO", "DOFFKGMHCMJ", "DBHKIAAABAO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DLBFLFOJIME : pb::IMessage<DLBFLFOJIME>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DLBFLFOJIME> _parser = new pb::MessageParser<DLBFLFOJIME>(() => new DLBFLFOJIME());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DLBFLFOJIME> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DLBFLFOJIMEReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DLBFLFOJIME() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DLBFLFOJIME(DLBFLFOJIME other) : this() {
      lIBKHPJHNGL_ = other.lIBKHPJHNGL_;
      roomId_ = other.roomId_;
      id_ = other.id_;
      lILBDBFOGDP_ = other.lILBDBFOGDP_.Clone();
      pGLKOCMLDFI_ = other.pGLKOCMLDFI_;
      oEMACNOIJNM_ = other.oEMACNOIJNM_;
      cNIBKJPMLCG_ = other.cNIBKJPMLCG_;
      dGBFIGKHAPN_ = other.dGBFIGKHAPN_;
      pBHOJNLKKOL_ = other.pBHOJNLKKOL_ != null ? other.pBHOJNLKKOL_.Clone() : null;
      gNBNDJBNPMO_ = other.gNBNDJBNPMO_;
      dOFFKGMHCMJ_ = other.dOFFKGMHCMJ_;
      dBHKIAAABAO_ = other.dBHKIAAABAO_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DLBFLFOJIME Clone() {
      return new DLBFLFOJIME(this);
    }

    /// <summary>Field number for the "LIBKHPJHNGL" field.</summary>
    public const int LIBKHPJHNGLFieldNumber = 13;
    private uint lIBKHPJHNGL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LIBKHPJHNGL {
      get { return lIBKHPJHNGL_; }
      set {
        lIBKHPJHNGL_ = value;
      }
    }

    /// <summary>Field number for the "room_id" field.</summary>
    public const int RoomIdFieldNumber = 8;
    private uint roomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 9;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "LILBDBFOGDP" field.</summary>
    public const int LILBDBFOGDPFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_lILBDBFOGDP_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> lILBDBFOGDP_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LILBDBFOGDP {
      get { return lILBDBFOGDP_; }
    }

    /// <summary>Field number for the "PGLKOCMLDFI" field.</summary>
    public const int PGLKOCMLDFIFieldNumber = 1;
    private bool pGLKOCMLDFI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PGLKOCMLDFI {
      get { return pGLKOCMLDFI_; }
      set {
        pGLKOCMLDFI_ = value;
      }
    }

    /// <summary>Field number for the "OEMACNOIJNM" field.</summary>
    public const int OEMACNOIJNMFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType oEMACNOIJNM_ = global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType OEMACNOIJNM {
      get { return oEMACNOIJNM_; }
      set {
        oEMACNOIJNM_ = value;
      }
    }

    /// <summary>Field number for the "CNIBKJPMLCG" field.</summary>
    public const int CNIBKJPMLCGFieldNumber = 4;
    private uint cNIBKJPMLCG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CNIBKJPMLCG {
      get { return cNIBKJPMLCG_; }
      set {
        cNIBKJPMLCG_ = value;
      }
    }

    /// <summary>Field number for the "DGBFIGKHAPN" field.</summary>
    public const int DGBFIGKHAPNFieldNumber = 3;
    private bool dGBFIGKHAPN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool DGBFIGKHAPN {
      get { return dGBFIGKHAPN_; }
      set {
        dGBFIGKHAPN_ = value;
      }
    }

    /// <summary>Field number for the "PBHOJNLKKOL" field.</summary>
    public const int PBHOJNLKKOLFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.LFDCLBPDNDF pBHOJNLKKOL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LFDCLBPDNDF PBHOJNLKKOL {
      get { return pBHOJNLKKOL_; }
      set {
        pBHOJNLKKOL_ = value;
      }
    }

    /// <summary>Field number for the "GNBNDJBNPMO" field.</summary>
    public const int GNBNDJBNPMOFieldNumber = 14;
    private uint gNBNDJBNPMO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GNBNDJBNPMO {
      get { return gNBNDJBNPMO_; }
      set {
        gNBNDJBNPMO_ = value;
      }
    }

    /// <summary>Field number for the "DOFFKGMHCMJ" field.</summary>
    public const int DOFFKGMHCMJFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus dOFFKGMHCMJ_ = global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus DOFFKGMHCMJ {
      get { return dOFFKGMHCMJ_; }
      set {
        dOFFKGMHCMJ_ = value;
      }
    }

    /// <summary>Field number for the "DBHKIAAABAO" field.</summary>
    public const int DBHKIAAABAOFieldNumber = 11;
    private uint dBHKIAAABAO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DBHKIAAABAO {
      get { return dBHKIAAABAO_; }
      set {
        dBHKIAAABAO_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DLBFLFOJIME);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DLBFLFOJIME other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LIBKHPJHNGL != other.LIBKHPJHNGL) return false;
      if (RoomId != other.RoomId) return false;
      if (Id != other.Id) return false;
      if(!lILBDBFOGDP_.Equals(other.lILBDBFOGDP_)) return false;
      if (PGLKOCMLDFI != other.PGLKOCMLDFI) return false;
      if (OEMACNOIJNM != other.OEMACNOIJNM) return false;
      if (CNIBKJPMLCG != other.CNIBKJPMLCG) return false;
      if (DGBFIGKHAPN != other.DGBFIGKHAPN) return false;
      if (!object.Equals(PBHOJNLKKOL, other.PBHOJNLKKOL)) return false;
      if (GNBNDJBNPMO != other.GNBNDJBNPMO) return false;
      if (DOFFKGMHCMJ != other.DOFFKGMHCMJ) return false;
      if (DBHKIAAABAO != other.DBHKIAAABAO) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LIBKHPJHNGL != 0) hash ^= LIBKHPJHNGL.GetHashCode();
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      hash ^= lILBDBFOGDP_.GetHashCode();
      if (PGLKOCMLDFI != false) hash ^= PGLKOCMLDFI.GetHashCode();
      if (OEMACNOIJNM != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) hash ^= OEMACNOIJNM.GetHashCode();
      if (CNIBKJPMLCG != 0) hash ^= CNIBKJPMLCG.GetHashCode();
      if (DGBFIGKHAPN != false) hash ^= DGBFIGKHAPN.GetHashCode();
      if (pBHOJNLKKOL_ != null) hash ^= PBHOJNLKKOL.GetHashCode();
      if (GNBNDJBNPMO != 0) hash ^= GNBNDJBNPMO.GetHashCode();
      if (DOFFKGMHCMJ != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) hash ^= DOFFKGMHCMJ.GetHashCode();
      if (DBHKIAAABAO != 0) hash ^= DBHKIAAABAO.GetHashCode();
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
      if (PGLKOCMLDFI != false) {
        output.WriteRawTag(8);
        output.WriteBool(PGLKOCMLDFI);
      }
      if (OEMACNOIJNM != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) OEMACNOIJNM);
      }
      if (DGBFIGKHAPN != false) {
        output.WriteRawTag(24);
        output.WriteBool(DGBFIGKHAPN);
      }
      if (CNIBKJPMLCG != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CNIBKJPMLCG);
      }
      if (DOFFKGMHCMJ != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DOFFKGMHCMJ);
      }
      lILBDBFOGDP_.WriteTo(output, _repeated_lILBDBFOGDP_codec);
      if (RoomId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(RoomId);
      }
      if (Id != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Id);
      }
      if (pBHOJNLKKOL_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(PBHOJNLKKOL);
      }
      if (DBHKIAAABAO != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DBHKIAAABAO);
      }
      if (LIBKHPJHNGL != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(LIBKHPJHNGL);
      }
      if (GNBNDJBNPMO != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GNBNDJBNPMO);
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
      if (PGLKOCMLDFI != false) {
        output.WriteRawTag(8);
        output.WriteBool(PGLKOCMLDFI);
      }
      if (OEMACNOIJNM != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) OEMACNOIJNM);
      }
      if (DGBFIGKHAPN != false) {
        output.WriteRawTag(24);
        output.WriteBool(DGBFIGKHAPN);
      }
      if (CNIBKJPMLCG != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CNIBKJPMLCG);
      }
      if (DOFFKGMHCMJ != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DOFFKGMHCMJ);
      }
      lILBDBFOGDP_.WriteTo(ref output, _repeated_lILBDBFOGDP_codec);
      if (RoomId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(RoomId);
      }
      if (Id != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Id);
      }
      if (pBHOJNLKKOL_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(PBHOJNLKKOL);
      }
      if (DBHKIAAABAO != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DBHKIAAABAO);
      }
      if (LIBKHPJHNGL != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(LIBKHPJHNGL);
      }
      if (GNBNDJBNPMO != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GNBNDJBNPMO);
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
      if (LIBKHPJHNGL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LIBKHPJHNGL);
      }
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoomId);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      size += lILBDBFOGDP_.CalculateSize(_repeated_lILBDBFOGDP_codec);
      if (PGLKOCMLDFI != false) {
        size += 1 + 1;
      }
      if (OEMACNOIJNM != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OEMACNOIJNM);
      }
      if (CNIBKJPMLCG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CNIBKJPMLCG);
      }
      if (DGBFIGKHAPN != false) {
        size += 1 + 1;
      }
      if (pBHOJNLKKOL_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PBHOJNLKKOL);
      }
      if (GNBNDJBNPMO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GNBNDJBNPMO);
      }
      if (DOFFKGMHCMJ != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DOFFKGMHCMJ);
      }
      if (DBHKIAAABAO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DBHKIAAABAO);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DLBFLFOJIME other) {
      if (other == null) {
        return;
      }
      if (other.LIBKHPJHNGL != 0) {
        LIBKHPJHNGL = other.LIBKHPJHNGL;
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      lILBDBFOGDP_.Add(other.lILBDBFOGDP_);
      if (other.PGLKOCMLDFI != false) {
        PGLKOCMLDFI = other.PGLKOCMLDFI;
      }
      if (other.OEMACNOIJNM != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) {
        OEMACNOIJNM = other.OEMACNOIJNM;
      }
      if (other.CNIBKJPMLCG != 0) {
        CNIBKJPMLCG = other.CNIBKJPMLCG;
      }
      if (other.DGBFIGKHAPN != false) {
        DGBFIGKHAPN = other.DGBFIGKHAPN;
      }
      if (other.pBHOJNLKKOL_ != null) {
        if (pBHOJNLKKOL_ == null) {
          PBHOJNLKKOL = new global::EggLink.DanhengServer.Proto.LFDCLBPDNDF();
        }
        PBHOJNLKKOL.MergeFrom(other.PBHOJNLKKOL);
      }
      if (other.GNBNDJBNPMO != 0) {
        GNBNDJBNPMO = other.GNBNDJBNPMO;
      }
      if (other.DOFFKGMHCMJ != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        DOFFKGMHCMJ = other.DOFFKGMHCMJ;
      }
      if (other.DBHKIAAABAO != 0) {
        DBHKIAAABAO = other.DBHKIAAABAO;
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
            PGLKOCMLDFI = input.ReadBool();
            break;
          }
          case 16: {
            OEMACNOIJNM = (global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType) input.ReadEnum();
            break;
          }
          case 24: {
            DGBFIGKHAPN = input.ReadBool();
            break;
          }
          case 32: {
            CNIBKJPMLCG = input.ReadUInt32();
            break;
          }
          case 40: {
            DOFFKGMHCMJ = (global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus) input.ReadEnum();
            break;
          }
          case 50:
          case 48: {
            lILBDBFOGDP_.AddEntriesFrom(input, _repeated_lILBDBFOGDP_codec);
            break;
          }
          case 64: {
            RoomId = input.ReadUInt32();
            break;
          }
          case 72: {
            Id = input.ReadUInt32();
            break;
          }
          case 82: {
            if (pBHOJNLKKOL_ == null) {
              PBHOJNLKKOL = new global::EggLink.DanhengServer.Proto.LFDCLBPDNDF();
            }
            input.ReadMessage(PBHOJNLKKOL);
            break;
          }
          case 88: {
            DBHKIAAABAO = input.ReadUInt32();
            break;
          }
          case 104: {
            LIBKHPJHNGL = input.ReadUInt32();
            break;
          }
          case 112: {
            GNBNDJBNPMO = input.ReadUInt32();
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
            PGLKOCMLDFI = input.ReadBool();
            break;
          }
          case 16: {
            OEMACNOIJNM = (global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType) input.ReadEnum();
            break;
          }
          case 24: {
            DGBFIGKHAPN = input.ReadBool();
            break;
          }
          case 32: {
            CNIBKJPMLCG = input.ReadUInt32();
            break;
          }
          case 40: {
            DOFFKGMHCMJ = (global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus) input.ReadEnum();
            break;
          }
          case 50:
          case 48: {
            lILBDBFOGDP_.AddEntriesFrom(ref input, _repeated_lILBDBFOGDP_codec);
            break;
          }
          case 64: {
            RoomId = input.ReadUInt32();
            break;
          }
          case 72: {
            Id = input.ReadUInt32();
            break;
          }
          case 82: {
            if (pBHOJNLKKOL_ == null) {
              PBHOJNLKKOL = new global::EggLink.DanhengServer.Proto.LFDCLBPDNDF();
            }
            input.ReadMessage(PBHOJNLKKOL);
            break;
          }
          case 88: {
            DBHKIAAABAO = input.ReadUInt32();
            break;
          }
          case 104: {
            LIBKHPJHNGL = input.ReadUInt32();
            break;
          }
          case 112: {
            GNBNDJBNPMO = input.ReadUInt32();
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
