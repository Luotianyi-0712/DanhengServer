// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CellInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CellInfo.proto</summary>
  public static partial class CellInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for CellInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CellInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5DZWxsSW5mby5wcm90bxofQ2hlc3NSb2d1ZUJvYXJkQ2VsbFN0YXR1cy5w",
            "cm90bxoVQ2VsbEFkdmFuY2VJbmZvLnByb3RvGh9DaGVzc1JvZ3VlQ2VsbFNw",
            "ZWNpYWxUeXBlLnByb3RvIrECCghDZWxsSW5mbxIRCgltYXJrX3R5cGUYDSAB",
            "KA0SDwoHcm9vbV9pZBgIIAEoDRIKCgJpZBgJIAEoDRITCgtMSUxCREJGT0dE",
            "UBgGIAMoDRIQCghpc192YWxpZBgBIAEoCBIwCgxzcGVjaWFsX3R5cGUYAiAB",
            "KA4yGi5DaGVzc1JvZ3VlQ2VsbFNwZWNpYWxUeXBlEg4KBmNvbHVtbhgEIAEo",
            "DRITCgtER0JGSUdLSEFQThgDIAEoCBImCgxhZHZhbmNlX2luZm8YCiABKAsy",
            "EC5DZWxsQWR2YW5jZUluZm8SCwoDcm93GA4gASgNEi8KC2NlbGxfc3RhdHVz",
            "GAUgASgOMhouQ2hlc3NSb2d1ZUJvYXJkQ2VsbFN0YXR1cxIRCgljZWxsX3R5",
            "cGUYCyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.CellAdvanceInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CellInfo), global::EggLink.DanhengServer.Proto.CellInfo.Parser, new[]{ "MarkType", "RoomId", "Id", "LILBDBFOGDP", "IsValid", "SpecialType", "Column", "DGBFIGKHAPN", "AdvanceInfo", "Row", "CellStatus", "CellType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CellInfo : pb::IMessage<CellInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CellInfo> _parser = new pb::MessageParser<CellInfo>(() => new CellInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CellInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CellInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CellInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CellInfo(CellInfo other) : this() {
      markType_ = other.markType_;
      roomId_ = other.roomId_;
      id_ = other.id_;
      lILBDBFOGDP_ = other.lILBDBFOGDP_.Clone();
      isValid_ = other.isValid_;
      specialType_ = other.specialType_;
      column_ = other.column_;
      dGBFIGKHAPN_ = other.dGBFIGKHAPN_;
      advanceInfo_ = other.advanceInfo_ != null ? other.advanceInfo_.Clone() : null;
      row_ = other.row_;
      cellStatus_ = other.cellStatus_;
      cellType_ = other.cellType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CellInfo Clone() {
      return new CellInfo(this);
    }

    /// <summary>Field number for the "mark_type" field.</summary>
    public const int MarkTypeFieldNumber = 13;
    private uint markType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MarkType {
      get { return markType_; }
      set {
        markType_ = value;
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

    /// <summary>Field number for the "is_valid" field.</summary>
    public const int IsValidFieldNumber = 1;
    private bool isValid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsValid {
      get { return isValid_; }
      set {
        isValid_ = value;
      }
    }

    /// <summary>Field number for the "special_type" field.</summary>
    public const int SpecialTypeFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType specialType_ = global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType SpecialType {
      get { return specialType_; }
      set {
        specialType_ = value;
      }
    }

    /// <summary>Field number for the "column" field.</summary>
    public const int ColumnFieldNumber = 4;
    private uint column_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Column {
      get { return column_; }
      set {
        column_ = value;
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

    /// <summary>Field number for the "advance_info" field.</summary>
    public const int AdvanceInfoFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.CellAdvanceInfo advanceInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CellAdvanceInfo AdvanceInfo {
      get { return advanceInfo_; }
      set {
        advanceInfo_ = value;
      }
    }

    /// <summary>Field number for the "row" field.</summary>
    public const int RowFieldNumber = 14;
    private uint row_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Row {
      get { return row_; }
      set {
        row_ = value;
      }
    }

    /// <summary>Field number for the "cell_status" field.</summary>
    public const int CellStatusFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus cellStatus_ = global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus CellStatus {
      get { return cellStatus_; }
      set {
        cellStatus_ = value;
      }
    }

    /// <summary>Field number for the "cell_type" field.</summary>
    public const int CellTypeFieldNumber = 11;
    private uint cellType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CellType {
      get { return cellType_; }
      set {
        cellType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CellInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CellInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MarkType != other.MarkType) return false;
      if (RoomId != other.RoomId) return false;
      if (Id != other.Id) return false;
      if(!lILBDBFOGDP_.Equals(other.lILBDBFOGDP_)) return false;
      if (IsValid != other.IsValid) return false;
      if (SpecialType != other.SpecialType) return false;
      if (Column != other.Column) return false;
      if (DGBFIGKHAPN != other.DGBFIGKHAPN) return false;
      if (!object.Equals(AdvanceInfo, other.AdvanceInfo)) return false;
      if (Row != other.Row) return false;
      if (CellStatus != other.CellStatus) return false;
      if (CellType != other.CellType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MarkType != 0) hash ^= MarkType.GetHashCode();
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      hash ^= lILBDBFOGDP_.GetHashCode();
      if (IsValid != false) hash ^= IsValid.GetHashCode();
      if (SpecialType != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) hash ^= SpecialType.GetHashCode();
      if (Column != 0) hash ^= Column.GetHashCode();
      if (DGBFIGKHAPN != false) hash ^= DGBFIGKHAPN.GetHashCode();
      if (advanceInfo_ != null) hash ^= AdvanceInfo.GetHashCode();
      if (Row != 0) hash ^= Row.GetHashCode();
      if (CellStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) hash ^= CellStatus.GetHashCode();
      if (CellType != 0) hash ^= CellType.GetHashCode();
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
      if (IsValid != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsValid);
      }
      if (SpecialType != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) SpecialType);
      }
      if (DGBFIGKHAPN != false) {
        output.WriteRawTag(24);
        output.WriteBool(DGBFIGKHAPN);
      }
      if (Column != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Column);
      }
      if (CellStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        output.WriteRawTag(40);
        output.WriteEnum((int) CellStatus);
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
      if (advanceInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(AdvanceInfo);
      }
      if (CellType != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CellType);
      }
      if (MarkType != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MarkType);
      }
      if (Row != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Row);
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
      if (IsValid != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsValid);
      }
      if (SpecialType != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) SpecialType);
      }
      if (DGBFIGKHAPN != false) {
        output.WriteRawTag(24);
        output.WriteBool(DGBFIGKHAPN);
      }
      if (Column != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Column);
      }
      if (CellStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        output.WriteRawTag(40);
        output.WriteEnum((int) CellStatus);
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
      if (advanceInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(AdvanceInfo);
      }
      if (CellType != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CellType);
      }
      if (MarkType != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MarkType);
      }
      if (Row != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Row);
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
      if (MarkType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MarkType);
      }
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoomId);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      size += lILBDBFOGDP_.CalculateSize(_repeated_lILBDBFOGDP_codec);
      if (IsValid != false) {
        size += 1 + 1;
      }
      if (SpecialType != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SpecialType);
      }
      if (Column != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Column);
      }
      if (DGBFIGKHAPN != false) {
        size += 1 + 1;
      }
      if (advanceInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AdvanceInfo);
      }
      if (Row != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Row);
      }
      if (CellStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CellStatus);
      }
      if (CellType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CellType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CellInfo other) {
      if (other == null) {
        return;
      }
      if (other.MarkType != 0) {
        MarkType = other.MarkType;
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      lILBDBFOGDP_.Add(other.lILBDBFOGDP_);
      if (other.IsValid != false) {
        IsValid = other.IsValid;
      }
      if (other.SpecialType != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) {
        SpecialType = other.SpecialType;
      }
      if (other.Column != 0) {
        Column = other.Column;
      }
      if (other.DGBFIGKHAPN != false) {
        DGBFIGKHAPN = other.DGBFIGKHAPN;
      }
      if (other.advanceInfo_ != null) {
        if (advanceInfo_ == null) {
          AdvanceInfo = new global::EggLink.DanhengServer.Proto.CellAdvanceInfo();
        }
        AdvanceInfo.MergeFrom(other.AdvanceInfo);
      }
      if (other.Row != 0) {
        Row = other.Row;
      }
      if (other.CellStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        CellStatus = other.CellStatus;
      }
      if (other.CellType != 0) {
        CellType = other.CellType;
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
            IsValid = input.ReadBool();
            break;
          }
          case 16: {
            SpecialType = (global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType) input.ReadEnum();
            break;
          }
          case 24: {
            DGBFIGKHAPN = input.ReadBool();
            break;
          }
          case 32: {
            Column = input.ReadUInt32();
            break;
          }
          case 40: {
            CellStatus = (global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus) input.ReadEnum();
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
            if (advanceInfo_ == null) {
              AdvanceInfo = new global::EggLink.DanhengServer.Proto.CellAdvanceInfo();
            }
            input.ReadMessage(AdvanceInfo);
            break;
          }
          case 88: {
            CellType = input.ReadUInt32();
            break;
          }
          case 104: {
            MarkType = input.ReadUInt32();
            break;
          }
          case 112: {
            Row = input.ReadUInt32();
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
            IsValid = input.ReadBool();
            break;
          }
          case 16: {
            SpecialType = (global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType) input.ReadEnum();
            break;
          }
          case 24: {
            DGBFIGKHAPN = input.ReadBool();
            break;
          }
          case 32: {
            Column = input.ReadUInt32();
            break;
          }
          case 40: {
            CellStatus = (global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus) input.ReadEnum();
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
            if (advanceInfo_ == null) {
              AdvanceInfo = new global::EggLink.DanhengServer.Proto.CellAdvanceInfo();
            }
            input.ReadMessage(AdvanceInfo);
            break;
          }
          case 88: {
            CellType = input.ReadUInt32();
            break;
          }
          case 104: {
            MarkType = input.ReadUInt32();
            break;
          }
          case 112: {
            Row = input.ReadUInt32();
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
