// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetReplayTokenScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetReplayTokenScRsp.proto</summary>
  public static partial class GetReplayTokenScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetReplayTokenScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetReplayTokenScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlHZXRSZXBsYXlUb2tlblNjUnNwLnByb3RvGhBSZXBsYXlUeXBlLnByb3Rv",
            "In4KE0dldFJlcGxheVRva2VuU2NSc3ASDwoHcmV0Y29kZRgKIAEoDRITCgtD",
            "Q0dLRlBES0ZOQhgGIAEoCRIQCghzdGFnZV9pZBgBIAEoDRINCgV0b2tlbhgM",
            "IAEoCRIgCgtyZXBsYXlfdHlwZRgPIAEoDjILLlJlcGxheVR5cGVCHqoCG0Vn",
            "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ReplayTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetReplayTokenScRsp), global::EggLink.DanhengServer.Proto.GetReplayTokenScRsp.Parser, new[]{ "Retcode", "CCGKFPDKFNB", "StageId", "Token", "ReplayType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetReplayTokenScRsp : pb::IMessage<GetReplayTokenScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetReplayTokenScRsp> _parser = new pb::MessageParser<GetReplayTokenScRsp>(() => new GetReplayTokenScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetReplayTokenScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetReplayTokenScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetReplayTokenScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetReplayTokenScRsp(GetReplayTokenScRsp other) : this() {
      retcode_ = other.retcode_;
      cCGKFPDKFNB_ = other.cCGKFPDKFNB_;
      stageId_ = other.stageId_;
      token_ = other.token_;
      replayType_ = other.replayType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetReplayTokenScRsp Clone() {
      return new GetReplayTokenScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "CCGKFPDKFNB" field.</summary>
    public const int CCGKFPDKFNBFieldNumber = 6;
    private string cCGKFPDKFNB_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CCGKFPDKFNB {
      get { return cCGKFPDKFNB_; }
      set {
        cCGKFPDKFNB_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 1;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "token" field.</summary>
    public const int TokenFieldNumber = 12;
    private string token_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Token {
      get { return token_; }
      set {
        token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "replay_type" field.</summary>
    public const int ReplayTypeFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.ReplayType replayType_ = global::EggLink.DanhengServer.Proto.ReplayType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ReplayType ReplayType {
      get { return replayType_; }
      set {
        replayType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetReplayTokenScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetReplayTokenScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (CCGKFPDKFNB != other.CCGKFPDKFNB) return false;
      if (StageId != other.StageId) return false;
      if (Token != other.Token) return false;
      if (ReplayType != other.ReplayType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (CCGKFPDKFNB.Length != 0) hash ^= CCGKFPDKFNB.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (Token.Length != 0) hash ^= Token.GetHashCode();
      if (ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) hash ^= ReplayType.GetHashCode();
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
      if (StageId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(StageId);
      }
      if (CCGKFPDKFNB.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(CCGKFPDKFNB);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (Token.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(Token);
      }
      if (ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) ReplayType);
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
      if (StageId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(StageId);
      }
      if (CCGKFPDKFNB.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(CCGKFPDKFNB);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (Token.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(Token);
      }
      if (ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) ReplayType);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (CCGKFPDKFNB.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CCGKFPDKFNB);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (Token.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
      }
      if (ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ReplayType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetReplayTokenScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.CCGKFPDKFNB.Length != 0) {
        CCGKFPDKFNB = other.CCGKFPDKFNB;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.Token.Length != 0) {
        Token = other.Token;
      }
      if (other.ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) {
        ReplayType = other.ReplayType;
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
            StageId = input.ReadUInt32();
            break;
          }
          case 50: {
            CCGKFPDKFNB = input.ReadString();
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            Token = input.ReadString();
            break;
          }
          case 120: {
            ReplayType = (global::EggLink.DanhengServer.Proto.ReplayType) input.ReadEnum();
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
            StageId = input.ReadUInt32();
            break;
          }
          case 50: {
            CCGKFPDKFNB = input.ReadString();
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            Token = input.ReadString();
            break;
          }
          case 120: {
            ReplayType = (global::EggLink.DanhengServer.Proto.ReplayType) input.ReadEnum();
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
