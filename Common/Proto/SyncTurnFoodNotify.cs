// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SyncTurnFoodNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SyncTurnFoodNotify.proto</summary>
  public static partial class SyncTurnFoodNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SyncTurnFoodNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SyncTurnFoodNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhTeW5jVHVybkZvb2ROb3RpZnkucHJvdG8aFFR1cm5Gb29kU3dpdGNoLnBy",
            "b3RvIlQKElN5bmNUdXJuRm9vZE5vdGlmeRIpChB0dXJuX2Zvb2Rfc3dpdGNo",
            "GAsgAygOMg8uVHVybkZvb2RTd2l0Y2gSEwoLS0tDSE1MTVBOTkQYAiADKA1C",
            "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.TurnFoodSwitchReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SyncTurnFoodNotify), global::EggLink.DanhengServer.Proto.SyncTurnFoodNotify.Parser, new[]{ "TurnFoodSwitch", "KKCHMLMPNND" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SyncTurnFoodNotify : pb::IMessage<SyncTurnFoodNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SyncTurnFoodNotify> _parser = new pb::MessageParser<SyncTurnFoodNotify>(() => new SyncTurnFoodNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SyncTurnFoodNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SyncTurnFoodNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncTurnFoodNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncTurnFoodNotify(SyncTurnFoodNotify other) : this() {
      turnFoodSwitch_ = other.turnFoodSwitch_.Clone();
      kKCHMLMPNND_ = other.kKCHMLMPNND_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncTurnFoodNotify Clone() {
      return new SyncTurnFoodNotify(this);
    }

    /// <summary>Field number for the "turn_food_switch" field.</summary>
    public const int TurnFoodSwitchFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.TurnFoodSwitch> _repeated_turnFoodSwitch_codec
        = pb::FieldCodec.ForEnum(90, x => (int) x, x => (global::EggLink.DanhengServer.Proto.TurnFoodSwitch) x);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TurnFoodSwitch> turnFoodSwitch_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TurnFoodSwitch>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TurnFoodSwitch> TurnFoodSwitch {
      get { return turnFoodSwitch_; }
    }

    /// <summary>Field number for the "KKCHMLMPNND" field.</summary>
    public const int KKCHMLMPNNDFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_kKCHMLMPNND_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> kKCHMLMPNND_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> KKCHMLMPNND {
      get { return kKCHMLMPNND_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SyncTurnFoodNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SyncTurnFoodNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!turnFoodSwitch_.Equals(other.turnFoodSwitch_)) return false;
      if(!kKCHMLMPNND_.Equals(other.kKCHMLMPNND_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= turnFoodSwitch_.GetHashCode();
      hash ^= kKCHMLMPNND_.GetHashCode();
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
      kKCHMLMPNND_.WriteTo(output, _repeated_kKCHMLMPNND_codec);
      turnFoodSwitch_.WriteTo(output, _repeated_turnFoodSwitch_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      kKCHMLMPNND_.WriteTo(ref output, _repeated_kKCHMLMPNND_codec);
      turnFoodSwitch_.WriteTo(ref output, _repeated_turnFoodSwitch_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += turnFoodSwitch_.CalculateSize(_repeated_turnFoodSwitch_codec);
      size += kKCHMLMPNND_.CalculateSize(_repeated_kKCHMLMPNND_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SyncTurnFoodNotify other) {
      if (other == null) {
        return;
      }
      turnFoodSwitch_.Add(other.turnFoodSwitch_);
      kKCHMLMPNND_.Add(other.kKCHMLMPNND_);
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
          case 18:
          case 16: {
            kKCHMLMPNND_.AddEntriesFrom(input, _repeated_kKCHMLMPNND_codec);
            break;
          }
          case 90:
          case 88: {
            turnFoodSwitch_.AddEntriesFrom(input, _repeated_turnFoodSwitch_codec);
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
          case 18:
          case 16: {
            kKCHMLMPNND_.AddEntriesFrom(ref input, _repeated_kKCHMLMPNND_codec);
            break;
          }
          case 90:
          case 88: {
            turnFoodSwitch_.AddEntriesFrom(ref input, _repeated_turnFoodSwitch_codec);
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
