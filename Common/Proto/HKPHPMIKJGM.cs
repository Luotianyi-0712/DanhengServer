// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HKPHPMIKJGM.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HKPHPMIKJGM.proto</summary>
  public static partial class HKPHPMIKJGMReflection {

    #region Descriptor
    /// <summary>File descriptor for HKPHPMIKJGM.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HKPHPMIKJGMReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFIS1BIUE1JS0pHTS5wcm90byI3CgtIS1BIUE1JS0pHTRITCgtKSktCTUdG",
            "Q0pKUBgEIAEoCBITCgtHSURDTkNDRUdMUBgLIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HKPHPMIKJGM), global::EggLink.DanhengServer.Proto.HKPHPMIKJGM.Parser, new[]{ "JJKBMGFCJJP", "GIDCNCCEGLP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HKPHPMIKJGM : pb::IMessage<HKPHPMIKJGM>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HKPHPMIKJGM> _parser = new pb::MessageParser<HKPHPMIKJGM>(() => new HKPHPMIKJGM());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HKPHPMIKJGM> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HKPHPMIKJGMReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HKPHPMIKJGM() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HKPHPMIKJGM(HKPHPMIKJGM other) : this() {
      jJKBMGFCJJP_ = other.jJKBMGFCJJP_;
      gIDCNCCEGLP_ = other.gIDCNCCEGLP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HKPHPMIKJGM Clone() {
      return new HKPHPMIKJGM(this);
    }

    /// <summary>Field number for the "JJKBMGFCJJP" field.</summary>
    public const int JJKBMGFCJJPFieldNumber = 4;
    private bool jJKBMGFCJJP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool JJKBMGFCJJP {
      get { return jJKBMGFCJJP_; }
      set {
        jJKBMGFCJJP_ = value;
      }
    }

    /// <summary>Field number for the "GIDCNCCEGLP" field.</summary>
    public const int GIDCNCCEGLPFieldNumber = 11;
    private uint gIDCNCCEGLP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GIDCNCCEGLP {
      get { return gIDCNCCEGLP_; }
      set {
        gIDCNCCEGLP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HKPHPMIKJGM);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HKPHPMIKJGM other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JJKBMGFCJJP != other.JJKBMGFCJJP) return false;
      if (GIDCNCCEGLP != other.GIDCNCCEGLP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (JJKBMGFCJJP != false) hash ^= JJKBMGFCJJP.GetHashCode();
      if (GIDCNCCEGLP != 0) hash ^= GIDCNCCEGLP.GetHashCode();
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
      if (JJKBMGFCJJP != false) {
        output.WriteRawTag(32);
        output.WriteBool(JJKBMGFCJJP);
      }
      if (GIDCNCCEGLP != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GIDCNCCEGLP);
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
      if (JJKBMGFCJJP != false) {
        output.WriteRawTag(32);
        output.WriteBool(JJKBMGFCJJP);
      }
      if (GIDCNCCEGLP != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GIDCNCCEGLP);
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
      if (JJKBMGFCJJP != false) {
        size += 1 + 1;
      }
      if (GIDCNCCEGLP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GIDCNCCEGLP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HKPHPMIKJGM other) {
      if (other == null) {
        return;
      }
      if (other.JJKBMGFCJJP != false) {
        JJKBMGFCJJP = other.JJKBMGFCJJP;
      }
      if (other.GIDCNCCEGLP != 0) {
        GIDCNCCEGLP = other.GIDCNCCEGLP;
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
            JJKBMGFCJJP = input.ReadBool();
            break;
          }
          case 88: {
            GIDCNCCEGLP = input.ReadUInt32();
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
            JJKBMGFCJJP = input.ReadBool();
            break;
          }
          case 88: {
            GIDCNCCEGLP = input.ReadUInt32();
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
