// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SetPlayerInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SetPlayerInfoScRsp.proto</summary>
  public static partial class SetPlayerInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SetPlayerInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetPlayerInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhTZXRQbGF5ZXJJbmZvU2NSc3AucHJvdG8aE0hlcm9CYXNpY1R5cGUucHJv",
            "dG8idQoSU2V0UGxheWVySW5mb1NjUnNwEg8KB3JldGNvZGUYDyABKA0SJgoO",
            "Y3VyX2Jhc2ljX3R5cGUYAyABKA4yDi5IZXJvQmFzaWNUeXBlEhEKCWlzX21v",
            "ZGlmeRgJIAEoCBITCgtPS01QR0dLSk1ITRgHIAEoA0IeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HeroBasicTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SetPlayerInfoScRsp), global::EggLink.DanhengServer.Proto.SetPlayerInfoScRsp.Parser, new[]{ "Retcode", "CurBasicType", "IsModify", "OKMPGGKJMHM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SetPlayerInfoScRsp : pb::IMessage<SetPlayerInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SetPlayerInfoScRsp> _parser = new pb::MessageParser<SetPlayerInfoScRsp>(() => new SetPlayerInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SetPlayerInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SetPlayerInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetPlayerInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetPlayerInfoScRsp(SetPlayerInfoScRsp other) : this() {
      retcode_ = other.retcode_;
      curBasicType_ = other.curBasicType_;
      isModify_ = other.isModify_;
      oKMPGGKJMHM_ = other.oKMPGGKJMHM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetPlayerInfoScRsp Clone() {
      return new SetPlayerInfoScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 15;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "cur_basic_type" field.</summary>
    public const int CurBasicTypeFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.HeroBasicType curBasicType_ = global::EggLink.DanhengServer.Proto.HeroBasicType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HeroBasicType CurBasicType {
      get { return curBasicType_; }
      set {
        curBasicType_ = value;
      }
    }

    /// <summary>Field number for the "is_modify" field.</summary>
    public const int IsModifyFieldNumber = 9;
    private bool isModify_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsModify {
      get { return isModify_; }
      set {
        isModify_ = value;
      }
    }

    /// <summary>Field number for the "OKMPGGKJMHM" field.</summary>
    public const int OKMPGGKJMHMFieldNumber = 7;
    private long oKMPGGKJMHM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long OKMPGGKJMHM {
      get { return oKMPGGKJMHM_; }
      set {
        oKMPGGKJMHM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SetPlayerInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SetPlayerInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (CurBasicType != other.CurBasicType) return false;
      if (IsModify != other.IsModify) return false;
      if (OKMPGGKJMHM != other.OKMPGGKJMHM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) hash ^= CurBasicType.GetHashCode();
      if (IsModify != false) hash ^= IsModify.GetHashCode();
      if (OKMPGGKJMHM != 0L) hash ^= OKMPGGKJMHM.GetHashCode();
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
      if (CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) CurBasicType);
      }
      if (OKMPGGKJMHM != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(OKMPGGKJMHM);
      }
      if (IsModify != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsModify);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Retcode);
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
      if (CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) CurBasicType);
      }
      if (OKMPGGKJMHM != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(OKMPGGKJMHM);
      }
      if (IsModify != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsModify);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Retcode);
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
      if (CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CurBasicType);
      }
      if (IsModify != false) {
        size += 1 + 1;
      }
      if (OKMPGGKJMHM != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(OKMPGGKJMHM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SetPlayerInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        CurBasicType = other.CurBasicType;
      }
      if (other.IsModify != false) {
        IsModify = other.IsModify;
      }
      if (other.OKMPGGKJMHM != 0L) {
        OKMPGGKJMHM = other.OKMPGGKJMHM;
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
          case 24: {
            CurBasicType = (global::EggLink.DanhengServer.Proto.HeroBasicType) input.ReadEnum();
            break;
          }
          case 56: {
            OKMPGGKJMHM = input.ReadInt64();
            break;
          }
          case 72: {
            IsModify = input.ReadBool();
            break;
          }
          case 120: {
            Retcode = input.ReadUInt32();
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
          case 24: {
            CurBasicType = (global::EggLink.DanhengServer.Proto.HeroBasicType) input.ReadEnum();
            break;
          }
          case 56: {
            OKMPGGKJMHM = input.ReadInt64();
            break;
          }
          case 72: {
            IsModify = input.ReadBool();
            break;
          }
          case 120: {
            Retcode = input.ReadUInt32();
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