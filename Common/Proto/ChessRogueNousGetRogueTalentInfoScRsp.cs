// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueNousGetRogueTalentInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueNousGetRogueTalentInfoScRsp.proto</summary>
  public static partial class ChessRogueNousGetRogueTalentInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueNousGetRogueTalentInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueNousGetRogueTalentInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitDaGVzc1JvZ3VlTm91c0dldFJvZ3VlVGFsZW50SW5mb1NjUnNwLnByb3Rv",
            "GhVSb2d1ZVRhbGVudEluZm8ucHJvdG8iegolQ2hlc3NSb2d1ZU5vdXNHZXRS",
            "b2d1ZVRhbGVudEluZm9TY1JzcBIrChFyb2d1ZV90YWxlbnRfaW5mbxgOIAEo",
            "CzIQLlJvZ3VlVGFsZW50SW5mbxITCgtQQkxGTU5CQ0xNSBgDIAEoDRIPCgdy",
            "ZXRjb2RlGAEgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueTalentInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueNousGetRogueTalentInfoScRsp), global::EggLink.DanhengServer.Proto.ChessRogueNousGetRogueTalentInfoScRsp.Parser, new[]{ "RogueTalentInfo", "PBLFMNBCLMH", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueNousGetRogueTalentInfoScRsp : pb::IMessage<ChessRogueNousGetRogueTalentInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueNousGetRogueTalentInfoScRsp> _parser = new pb::MessageParser<ChessRogueNousGetRogueTalentInfoScRsp>(() => new ChessRogueNousGetRogueTalentInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueNousGetRogueTalentInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueNousGetRogueTalentInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueNousGetRogueTalentInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueNousGetRogueTalentInfoScRsp(ChessRogueNousGetRogueTalentInfoScRsp other) : this() {
      rogueTalentInfo_ = other.rogueTalentInfo_ != null ? other.rogueTalentInfo_.Clone() : null;
      pBLFMNBCLMH_ = other.pBLFMNBCLMH_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueNousGetRogueTalentInfoScRsp Clone() {
      return new ChessRogueNousGetRogueTalentInfoScRsp(this);
    }

    /// <summary>Field number for the "rogue_talent_info" field.</summary>
    public const int RogueTalentInfoFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.RogueTalentInfo rogueTalentInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTalentInfo RogueTalentInfo {
      get { return rogueTalentInfo_; }
      set {
        rogueTalentInfo_ = value;
      }
    }

    /// <summary>Field number for the "PBLFMNBCLMH" field.</summary>
    public const int PBLFMNBCLMHFieldNumber = 3;
    private uint pBLFMNBCLMH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PBLFMNBCLMH {
      get { return pBLFMNBCLMH_; }
      set {
        pBLFMNBCLMH_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
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
      return Equals(other as ChessRogueNousGetRogueTalentInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueNousGetRogueTalentInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueTalentInfo, other.RogueTalentInfo)) return false;
      if (PBLFMNBCLMH != other.PBLFMNBCLMH) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueTalentInfo_ != null) hash ^= RogueTalentInfo.GetHashCode();
      if (PBLFMNBCLMH != 0) hash ^= PBLFMNBCLMH.GetHashCode();
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
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      if (PBLFMNBCLMH != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PBLFMNBCLMH);
      }
      if (rogueTalentInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RogueTalentInfo);
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
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      if (PBLFMNBCLMH != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PBLFMNBCLMH);
      }
      if (rogueTalentInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RogueTalentInfo);
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
      if (rogueTalentInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTalentInfo);
      }
      if (PBLFMNBCLMH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PBLFMNBCLMH);
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
    public void MergeFrom(ChessRogueNousGetRogueTalentInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.rogueTalentInfo_ != null) {
        if (rogueTalentInfo_ == null) {
          RogueTalentInfo = new global::EggLink.DanhengServer.Proto.RogueTalentInfo();
        }
        RogueTalentInfo.MergeFrom(other.RogueTalentInfo);
      }
      if (other.PBLFMNBCLMH != 0) {
        PBLFMNBCLMH = other.PBLFMNBCLMH;
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
          case 8: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 24: {
            PBLFMNBCLMH = input.ReadUInt32();
            break;
          }
          case 114: {
            if (rogueTalentInfo_ == null) {
              RogueTalentInfo = new global::EggLink.DanhengServer.Proto.RogueTalentInfo();
            }
            input.ReadMessage(RogueTalentInfo);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 24: {
            PBLFMNBCLMH = input.ReadUInt32();
            break;
          }
          case 114: {
            if (rogueTalentInfo_ == null) {
              RogueTalentInfo = new global::EggLink.DanhengServer.Proto.RogueTalentInfo();
            }
            input.ReadMessage(RogueTalentInfo);
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
