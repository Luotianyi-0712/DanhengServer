// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FightActivityDataChangeScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FightActivityDataChangeScNotify.proto</summary>
  public static partial class FightActivityDataChangeScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for FightActivityDataChangeScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FightActivityDataChangeScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVGaWdodEFjdGl2aXR5RGF0YUNoYW5nZVNjTm90aWZ5LnByb3RvGhhGaWdo",
            "dEFjdGl2aXR5R3JvdXAucHJvdG8ixwEKH0ZpZ2h0QWN0aXZpdHlEYXRhQ2hh",
            "bmdlU2NOb3RpZnkSRgoLT01KSERLSEZFR0YYDSADKAsyMS5GaWdodEFjdGl2",
            "aXR5RGF0YUNoYW5nZVNjTm90aWZ5Lk9NSkhES0hGRUdGRW50cnkSKAoLTU5Q",
            "SkVCQU1JTE8YBSADKAsyEy5GaWdodEFjdGl2aXR5R3JvdXAaMgoQT01KSERL",
            "SEZFR0ZFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06AjgBQh6q",
            "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FightActivityGroupReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FightActivityDataChangeScNotify), global::EggLink.DanhengServer.Proto.FightActivityDataChangeScNotify.Parser, new[]{ "OMJHDKHFEGF", "MNPJEBAMILO" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FightActivityDataChangeScNotify : pb::IMessage<FightActivityDataChangeScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FightActivityDataChangeScNotify> _parser = new pb::MessageParser<FightActivityDataChangeScNotify>(() => new FightActivityDataChangeScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FightActivityDataChangeScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FightActivityDataChangeScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightActivityDataChangeScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightActivityDataChangeScNotify(FightActivityDataChangeScNotify other) : this() {
      oMJHDKHFEGF_ = other.oMJHDKHFEGF_.Clone();
      mNPJEBAMILO_ = other.mNPJEBAMILO_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightActivityDataChangeScNotify Clone() {
      return new FightActivityDataChangeScNotify(this);
    }

    /// <summary>Field number for the "OMJHDKHFEGF" field.</summary>
    public const int OMJHDKHFEGFFieldNumber = 13;
    private static readonly pbc::MapField<uint, uint>.Codec _map_oMJHDKHFEGF_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 106);
    private readonly pbc::MapField<uint, uint> oMJHDKHFEGF_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> OMJHDKHFEGF {
      get { return oMJHDKHFEGF_; }
    }

    /// <summary>Field number for the "MNPJEBAMILO" field.</summary>
    public const int MNPJEBAMILOFieldNumber = 5;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.FightActivityGroup> _repeated_mNPJEBAMILO_codec
        = pb::FieldCodec.ForMessage(42, global::EggLink.DanhengServer.Proto.FightActivityGroup.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FightActivityGroup> mNPJEBAMILO_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FightActivityGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FightActivityGroup> MNPJEBAMILO {
      get { return mNPJEBAMILO_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FightActivityDataChangeScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FightActivityDataChangeScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!OMJHDKHFEGF.Equals(other.OMJHDKHFEGF)) return false;
      if(!mNPJEBAMILO_.Equals(other.mNPJEBAMILO_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= OMJHDKHFEGF.GetHashCode();
      hash ^= mNPJEBAMILO_.GetHashCode();
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
      mNPJEBAMILO_.WriteTo(output, _repeated_mNPJEBAMILO_codec);
      oMJHDKHFEGF_.WriteTo(output, _map_oMJHDKHFEGF_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      mNPJEBAMILO_.WriteTo(ref output, _repeated_mNPJEBAMILO_codec);
      oMJHDKHFEGF_.WriteTo(ref output, _map_oMJHDKHFEGF_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += oMJHDKHFEGF_.CalculateSize(_map_oMJHDKHFEGF_codec);
      size += mNPJEBAMILO_.CalculateSize(_repeated_mNPJEBAMILO_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FightActivityDataChangeScNotify other) {
      if (other == null) {
        return;
      }
      oMJHDKHFEGF_.MergeFrom(other.oMJHDKHFEGF_);
      mNPJEBAMILO_.Add(other.mNPJEBAMILO_);
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
          case 42: {
            mNPJEBAMILO_.AddEntriesFrom(input, _repeated_mNPJEBAMILO_codec);
            break;
          }
          case 106: {
            oMJHDKHFEGF_.AddEntriesFrom(input, _map_oMJHDKHFEGF_codec);
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
          case 42: {
            mNPJEBAMILO_.AddEntriesFrom(ref input, _repeated_mNPJEBAMILO_codec);
            break;
          }
          case 106: {
            oMJHDKHFEGF_.AddEntriesFrom(ref input, _map_oMJHDKHFEGF_codec);
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
