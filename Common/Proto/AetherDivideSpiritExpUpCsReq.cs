// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AetherDivideSpiritExpUpCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from AetherDivideSpiritExpUpCsReq.proto</summary>
  public static partial class AetherDivideSpiritExpUpCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for AetherDivideSpiritExpUpCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AetherDivideSpiritExpUpCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJBZXRoZXJEaXZpZGVTcGlyaXRFeHBVcENzUmVxLnByb3RvIl0KHEFldGhl",
            "ckRpdmlkZVNwaXJpdEV4cFVwQ3NSZXESEwoLQkpMQk5GREFQQkEYBSABKA0S",
            "EwoLRExGUE9ES0dCTEgYDyABKA0SEwoLQk9ET0lPUEJDQkQYDSABKA1CHqoC",
            "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.AetherDivideSpiritExpUpCsReq), global::EggLink.DanhengServer.Proto.AetherDivideSpiritExpUpCsReq.Parser, new[]{ "BJLBNFDAPBA", "DLFPODKGBLH", "BODOIOPBCBD" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AetherDivideSpiritExpUpCsReq : pb::IMessage<AetherDivideSpiritExpUpCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AetherDivideSpiritExpUpCsReq> _parser = new pb::MessageParser<AetherDivideSpiritExpUpCsReq>(() => new AetherDivideSpiritExpUpCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AetherDivideSpiritExpUpCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.AetherDivideSpiritExpUpCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritExpUpCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritExpUpCsReq(AetherDivideSpiritExpUpCsReq other) : this() {
      bJLBNFDAPBA_ = other.bJLBNFDAPBA_;
      dLFPODKGBLH_ = other.dLFPODKGBLH_;
      bODOIOPBCBD_ = other.bODOIOPBCBD_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritExpUpCsReq Clone() {
      return new AetherDivideSpiritExpUpCsReq(this);
    }

    /// <summary>Field number for the "BJLBNFDAPBA" field.</summary>
    public const int BJLBNFDAPBAFieldNumber = 5;
    private uint bJLBNFDAPBA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BJLBNFDAPBA {
      get { return bJLBNFDAPBA_; }
      set {
        bJLBNFDAPBA_ = value;
      }
    }

    /// <summary>Field number for the "DLFPODKGBLH" field.</summary>
    public const int DLFPODKGBLHFieldNumber = 15;
    private uint dLFPODKGBLH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DLFPODKGBLH {
      get { return dLFPODKGBLH_; }
      set {
        dLFPODKGBLH_ = value;
      }
    }

    /// <summary>Field number for the "BODOIOPBCBD" field.</summary>
    public const int BODOIOPBCBDFieldNumber = 13;
    private uint bODOIOPBCBD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BODOIOPBCBD {
      get { return bODOIOPBCBD_; }
      set {
        bODOIOPBCBD_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AetherDivideSpiritExpUpCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AetherDivideSpiritExpUpCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BJLBNFDAPBA != other.BJLBNFDAPBA) return false;
      if (DLFPODKGBLH != other.DLFPODKGBLH) return false;
      if (BODOIOPBCBD != other.BODOIOPBCBD) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BJLBNFDAPBA != 0) hash ^= BJLBNFDAPBA.GetHashCode();
      if (DLFPODKGBLH != 0) hash ^= DLFPODKGBLH.GetHashCode();
      if (BODOIOPBCBD != 0) hash ^= BODOIOPBCBD.GetHashCode();
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
      if (BJLBNFDAPBA != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(BJLBNFDAPBA);
      }
      if (BODOIOPBCBD != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(BODOIOPBCBD);
      }
      if (DLFPODKGBLH != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(DLFPODKGBLH);
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
      if (BJLBNFDAPBA != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(BJLBNFDAPBA);
      }
      if (BODOIOPBCBD != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(BODOIOPBCBD);
      }
      if (DLFPODKGBLH != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(DLFPODKGBLH);
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
      if (BJLBNFDAPBA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BJLBNFDAPBA);
      }
      if (DLFPODKGBLH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DLFPODKGBLH);
      }
      if (BODOIOPBCBD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BODOIOPBCBD);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AetherDivideSpiritExpUpCsReq other) {
      if (other == null) {
        return;
      }
      if (other.BJLBNFDAPBA != 0) {
        BJLBNFDAPBA = other.BJLBNFDAPBA;
      }
      if (other.DLFPODKGBLH != 0) {
        DLFPODKGBLH = other.DLFPODKGBLH;
      }
      if (other.BODOIOPBCBD != 0) {
        BODOIOPBCBD = other.BODOIOPBCBD;
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
          case 40: {
            BJLBNFDAPBA = input.ReadUInt32();
            break;
          }
          case 104: {
            BODOIOPBCBD = input.ReadUInt32();
            break;
          }
          case 120: {
            DLFPODKGBLH = input.ReadUInt32();
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
          case 40: {
            BJLBNFDAPBA = input.ReadUInt32();
            break;
          }
          case 104: {
            BODOIOPBCBD = input.ReadUInt32();
            break;
          }
          case 120: {
            DLFPODKGBLH = input.ReadUInt32();
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
