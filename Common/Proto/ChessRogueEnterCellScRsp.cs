// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueEnterCellScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueEnterCellScRsp.proto</summary>
  public static partial class ChessRogueEnterCellScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueEnterCellScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueEnterCellScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5DaGVzc1JvZ3VlRW50ZXJDZWxsU2NSc3AucHJvdG8aEUVFUEdITEZOREtK",
            "LnByb3RvGhFBTk5OSk9MTkRIRS5wcm90bxoRQ05IR0pETEFFSEwucHJvdG8i",
            "pgEKGENoZXNzUm9ndWVFbnRlckNlbGxTY1JzcBIhCgtQQkhPSk5MS0tPTBgN",
            "IAEoCzIMLkNOSEdKRExBRUhMEg8KB3JldGNvZGUYAyABKA0SGgoEaW5mbxgL",
            "IAEoCzIMLkVFUEdITEZOREtKEiUKD3JvZ3VlX2dhbWVfaW5mbxgCIAEoCzIM",
            "LkFOTk5KT0xOREhFEhMKC09GQUtMRkxBT0xQGAwgASgNQh6qAhtFZ2dMaW5r",
            "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.EEPGHLFNDKJReflection.Descriptor, global::EggLink.DanhengServer.Proto.ANNNJOLNDHEReflection.Descriptor, global::EggLink.DanhengServer.Proto.CNHGJDLAEHLReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueEnterCellScRsp), global::EggLink.DanhengServer.Proto.ChessRogueEnterCellScRsp.Parser, new[]{ "PBHOJNLKKOL", "Retcode", "Info", "RogueGameInfo", "OFAKLFLAOLP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueEnterCellScRsp : pb::IMessage<ChessRogueEnterCellScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueEnterCellScRsp> _parser = new pb::MessageParser<ChessRogueEnterCellScRsp>(() => new ChessRogueEnterCellScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueEnterCellScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueEnterCellScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueEnterCellScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueEnterCellScRsp(ChessRogueEnterCellScRsp other) : this() {
      pBHOJNLKKOL_ = other.pBHOJNLKKOL_ != null ? other.pBHOJNLKKOL_.Clone() : null;
      retcode_ = other.retcode_;
      info_ = other.info_ != null ? other.info_.Clone() : null;
      rogueGameInfo_ = other.rogueGameInfo_ != null ? other.rogueGameInfo_.Clone() : null;
      oFAKLFLAOLP_ = other.oFAKLFLAOLP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueEnterCellScRsp Clone() {
      return new ChessRogueEnterCellScRsp(this);
    }

    /// <summary>Field number for the "PBHOJNLKKOL" field.</summary>
    public const int PBHOJNLKKOLFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.CNHGJDLAEHL pBHOJNLKKOL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CNHGJDLAEHL PBHOJNLKKOL {
      get { return pBHOJNLKKOL_; }
      set {
        pBHOJNLKKOL_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 3;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "info" field.</summary>
    public const int InfoFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ info_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ Info {
      get { return info_; }
      set {
        info_ = value;
      }
    }

    /// <summary>Field number for the "rogue_game_info" field.</summary>
    public const int RogueGameInfoFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.ANNNJOLNDHE rogueGameInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ANNNJOLNDHE RogueGameInfo {
      get { return rogueGameInfo_; }
      set {
        rogueGameInfo_ = value;
      }
    }

    /// <summary>Field number for the "OFAKLFLAOLP" field.</summary>
    public const int OFAKLFLAOLPFieldNumber = 12;
    private uint oFAKLFLAOLP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OFAKLFLAOLP {
      get { return oFAKLFLAOLP_; }
      set {
        oFAKLFLAOLP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueEnterCellScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueEnterCellScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PBHOJNLKKOL, other.PBHOJNLKKOL)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(Info, other.Info)) return false;
      if (!object.Equals(RogueGameInfo, other.RogueGameInfo)) return false;
      if (OFAKLFLAOLP != other.OFAKLFLAOLP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (pBHOJNLKKOL_ != null) hash ^= PBHOJNLKKOL.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (info_ != null) hash ^= Info.GetHashCode();
      if (rogueGameInfo_ != null) hash ^= RogueGameInfo.GetHashCode();
      if (OFAKLFLAOLP != 0) hash ^= OFAKLFLAOLP.GetHashCode();
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
      if (rogueGameInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RogueGameInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (info_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Info);
      }
      if (OFAKLFLAOLP != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(OFAKLFLAOLP);
      }
      if (pBHOJNLKKOL_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(PBHOJNLKKOL);
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
      if (rogueGameInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RogueGameInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (info_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Info);
      }
      if (OFAKLFLAOLP != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(OFAKLFLAOLP);
      }
      if (pBHOJNLKKOL_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(PBHOJNLKKOL);
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
      if (pBHOJNLKKOL_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PBHOJNLKKOL);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (info_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Info);
      }
      if (rogueGameInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueGameInfo);
      }
      if (OFAKLFLAOLP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OFAKLFLAOLP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueEnterCellScRsp other) {
      if (other == null) {
        return;
      }
      if (other.pBHOJNLKKOL_ != null) {
        if (pBHOJNLKKOL_ == null) {
          PBHOJNLKKOL = new global::EggLink.DanhengServer.Proto.CNHGJDLAEHL();
        }
        PBHOJNLKKOL.MergeFrom(other.PBHOJNLKKOL);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.info_ != null) {
        if (info_ == null) {
          Info = new global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ();
        }
        Info.MergeFrom(other.Info);
      }
      if (other.rogueGameInfo_ != null) {
        if (rogueGameInfo_ == null) {
          RogueGameInfo = new global::EggLink.DanhengServer.Proto.ANNNJOLNDHE();
        }
        RogueGameInfo.MergeFrom(other.RogueGameInfo);
      }
      if (other.OFAKLFLAOLP != 0) {
        OFAKLFLAOLP = other.OFAKLFLAOLP;
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
          case 18: {
            if (rogueGameInfo_ == null) {
              RogueGameInfo = new global::EggLink.DanhengServer.Proto.ANNNJOLNDHE();
            }
            input.ReadMessage(RogueGameInfo);
            break;
          }
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 90: {
            if (info_ == null) {
              Info = new global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ();
            }
            input.ReadMessage(Info);
            break;
          }
          case 96: {
            OFAKLFLAOLP = input.ReadUInt32();
            break;
          }
          case 106: {
            if (pBHOJNLKKOL_ == null) {
              PBHOJNLKKOL = new global::EggLink.DanhengServer.Proto.CNHGJDLAEHL();
            }
            input.ReadMessage(PBHOJNLKKOL);
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
          case 18: {
            if (rogueGameInfo_ == null) {
              RogueGameInfo = new global::EggLink.DanhengServer.Proto.ANNNJOLNDHE();
            }
            input.ReadMessage(RogueGameInfo);
            break;
          }
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 90: {
            if (info_ == null) {
              Info = new global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ();
            }
            input.ReadMessage(Info);
            break;
          }
          case 96: {
            OFAKLFLAOLP = input.ReadUInt32();
            break;
          }
          case 106: {
            if (pBHOJNLKKOL_ == null) {
              PBHOJNLKKOL = new global::EggLink.DanhengServer.Proto.CNHGJDLAEHL();
            }
            input.ReadMessage(PBHOJNLKKOL);
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
