// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueEnterNextLayerScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueEnterNextLayerScRsp.proto</summary>
  public static partial class ChessRogueEnterNextLayerScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueEnterNextLayerScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueEnterNextLayerScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNDaGVzc1JvZ3VlRW50ZXJOZXh0TGF5ZXJTY1JzcC5wcm90bxoRT0RGSUdO",
            "TUFESUYucHJvdG8aEUFOTk5KT0xOREhFLnByb3RvGhFFRVBHSExGTkRLSi5w",
            "cm90bxoRQ05IR0pETEFFSEwucHJvdG8ivwEKHUNoZXNzUm9ndWVFbnRlck5l",
            "eHRMYXllclNjUnNwEiUKD3JvZ3VlX2dhbWVfaW5mbxgOIAEoCzIMLkFOTk5K",
            "T0xOREhFEiEKC1BBQUZBTE5KTEROGA8gASgLMgwuT0RGSUdOTUFESUYSIAoK",
            "cm9ndWVfaW5mbxgIIAEoCzIMLkVFUEdITEZOREtKEiEKC1BCSE9KTkxLS09M",
            "GAsgASgLMgwuQ05IR0pETEFFSEwSDwoHcmV0Y29kZRgEIAEoDUIeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ODFIGNMADIFReflection.Descriptor, global::EggLink.DanhengServer.Proto.ANNNJOLNDHEReflection.Descriptor, global::EggLink.DanhengServer.Proto.EEPGHLFNDKJReflection.Descriptor, global::EggLink.DanhengServer.Proto.CNHGJDLAEHLReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueEnterNextLayerScRsp), global::EggLink.DanhengServer.Proto.ChessRogueEnterNextLayerScRsp.Parser, new[]{ "RogueGameInfo", "PAAFALNJLDN", "RogueInfo", "PBHOJNLKKOL", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueEnterNextLayerScRsp : pb::IMessage<ChessRogueEnterNextLayerScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueEnterNextLayerScRsp> _parser = new pb::MessageParser<ChessRogueEnterNextLayerScRsp>(() => new ChessRogueEnterNextLayerScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueEnterNextLayerScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueEnterNextLayerScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueEnterNextLayerScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueEnterNextLayerScRsp(ChessRogueEnterNextLayerScRsp other) : this() {
      rogueGameInfo_ = other.rogueGameInfo_ != null ? other.rogueGameInfo_.Clone() : null;
      pAAFALNJLDN_ = other.pAAFALNJLDN_ != null ? other.pAAFALNJLDN_.Clone() : null;
      rogueInfo_ = other.rogueInfo_ != null ? other.rogueInfo_.Clone() : null;
      pBHOJNLKKOL_ = other.pBHOJNLKKOL_ != null ? other.pBHOJNLKKOL_.Clone() : null;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueEnterNextLayerScRsp Clone() {
      return new ChessRogueEnterNextLayerScRsp(this);
    }

    /// <summary>Field number for the "rogue_game_info" field.</summary>
    public const int RogueGameInfoFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.ANNNJOLNDHE rogueGameInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ANNNJOLNDHE RogueGameInfo {
      get { return rogueGameInfo_; }
      set {
        rogueGameInfo_ = value;
      }
    }

    /// <summary>Field number for the "PAAFALNJLDN" field.</summary>
    public const int PAAFALNJLDNFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.ODFIGNMADIF pAAFALNJLDN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ODFIGNMADIF PAAFALNJLDN {
      get { return pAAFALNJLDN_; }
      set {
        pAAFALNJLDN_ = value;
      }
    }

    /// <summary>Field number for the "rogue_info" field.</summary>
    public const int RogueInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ rogueInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ RogueInfo {
      get { return rogueInfo_; }
      set {
        rogueInfo_ = value;
      }
    }

    /// <summary>Field number for the "PBHOJNLKKOL" field.</summary>
    public const int PBHOJNLKKOLFieldNumber = 11;
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
    public const int RetcodeFieldNumber = 4;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueEnterNextLayerScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueEnterNextLayerScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueGameInfo, other.RogueGameInfo)) return false;
      if (!object.Equals(PAAFALNJLDN, other.PAAFALNJLDN)) return false;
      if (!object.Equals(RogueInfo, other.RogueInfo)) return false;
      if (!object.Equals(PBHOJNLKKOL, other.PBHOJNLKKOL)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueGameInfo_ != null) hash ^= RogueGameInfo.GetHashCode();
      if (pAAFALNJLDN_ != null) hash ^= PAAFALNJLDN.GetHashCode();
      if (rogueInfo_ != null) hash ^= RogueInfo.GetHashCode();
      if (pBHOJNLKKOL_ != null) hash ^= PBHOJNLKKOL.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (rogueInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RogueInfo);
      }
      if (pBHOJNLKKOL_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(PBHOJNLKKOL);
      }
      if (rogueGameInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RogueGameInfo);
      }
      if (pAAFALNJLDN_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(PAAFALNJLDN);
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
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (rogueInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RogueInfo);
      }
      if (pBHOJNLKKOL_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(PBHOJNLKKOL);
      }
      if (rogueGameInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RogueGameInfo);
      }
      if (pAAFALNJLDN_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(PAAFALNJLDN);
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
      if (rogueGameInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueGameInfo);
      }
      if (pAAFALNJLDN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PAAFALNJLDN);
      }
      if (rogueInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueInfo);
      }
      if (pBHOJNLKKOL_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PBHOJNLKKOL);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueEnterNextLayerScRsp other) {
      if (other == null) {
        return;
      }
      if (other.rogueGameInfo_ != null) {
        if (rogueGameInfo_ == null) {
          RogueGameInfo = new global::EggLink.DanhengServer.Proto.ANNNJOLNDHE();
        }
        RogueGameInfo.MergeFrom(other.RogueGameInfo);
      }
      if (other.pAAFALNJLDN_ != null) {
        if (pAAFALNJLDN_ == null) {
          PAAFALNJLDN = new global::EggLink.DanhengServer.Proto.ODFIGNMADIF();
        }
        PAAFALNJLDN.MergeFrom(other.PAAFALNJLDN);
      }
      if (other.rogueInfo_ != null) {
        if (rogueInfo_ == null) {
          RogueInfo = new global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ();
        }
        RogueInfo.MergeFrom(other.RogueInfo);
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
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 66: {
            if (rogueInfo_ == null) {
              RogueInfo = new global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ();
            }
            input.ReadMessage(RogueInfo);
            break;
          }
          case 90: {
            if (pBHOJNLKKOL_ == null) {
              PBHOJNLKKOL = new global::EggLink.DanhengServer.Proto.CNHGJDLAEHL();
            }
            input.ReadMessage(PBHOJNLKKOL);
            break;
          }
          case 114: {
            if (rogueGameInfo_ == null) {
              RogueGameInfo = new global::EggLink.DanhengServer.Proto.ANNNJOLNDHE();
            }
            input.ReadMessage(RogueGameInfo);
            break;
          }
          case 122: {
            if (pAAFALNJLDN_ == null) {
              PAAFALNJLDN = new global::EggLink.DanhengServer.Proto.ODFIGNMADIF();
            }
            input.ReadMessage(PAAFALNJLDN);
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
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 66: {
            if (rogueInfo_ == null) {
              RogueInfo = new global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ();
            }
            input.ReadMessage(RogueInfo);
            break;
          }
          case 90: {
            if (pBHOJNLKKOL_ == null) {
              PBHOJNLKKOL = new global::EggLink.DanhengServer.Proto.CNHGJDLAEHL();
            }
            input.ReadMessage(PBHOJNLKKOL);
            break;
          }
          case 114: {
            if (rogueGameInfo_ == null) {
              RogueGameInfo = new global::EggLink.DanhengServer.Proto.ANNNJOLNDHE();
            }
            input.ReadMessage(RogueGameInfo);
            break;
          }
          case 122: {
            if (pAAFALNJLDN_ == null) {
              PAAFALNJLDN = new global::EggLink.DanhengServer.Proto.ODFIGNMADIF();
            }
            input.ReadMessage(PAAFALNJLDN);
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
