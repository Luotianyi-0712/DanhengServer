// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerSimpleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerSimpleInfo.proto</summary>
  public static partial class PlayerSimpleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerSimpleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerSimpleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQbGF5ZXJTaW1wbGVJbmZvLnByb3RvGhJQbGF0Zm9ybVR5cGUucHJvdG8a",
            "FkFzc2lzdFNpbXBsZUluZm8ucHJvdG8aGEZyaWVuZE9ubGluZVN0YXR1cy5w",
            "cm90byLBAgoQUGxheWVyU2ltcGxlSW5mbxIfCghwbGF0Zm9ybRgOIAEoDjIN",
            "LlBsYXRmb3JtVHlwZRImCgtFTkNGSk1CUE9HTxgIIAMoCzIRLkFzc2lzdFNp",
            "bXBsZUluZm8SEQoJc2lnbmF0dXJlGAYgASgJEg0KBWxldmVsGAEgASgNEikK",
            "DG9ubGluZVN0YXR1cxgJIAEoDjITLkZyaWVuZE9ubGluZVN0YXR1cxIQCghu",
            "aWNrbmFtZRgHIAEoCRITCgtGSklMUE9KUEhCThgDIAEoCRITCgtCTkdHSEhF",
            "RENDRxgCIAEoCRILCgN1aWQYBCABKA0SEQoJaXNfYmFubmVkGA8gASgIEhMK",
            "C09DRUVEREhQT0pNGA0gASgDEhEKCWhlYWRfaWNvbhgFIAEoDRITCgtFTEhP",
            "QkJEQ0pDQRgLIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlatformTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.AssistSimpleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.FriendOnlineStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerSimpleInfo), global::EggLink.DanhengServer.Proto.PlayerSimpleInfo.Parser, new[]{ "Platform", "ENCFJMBPOGO", "Signature", "Level", "OnlineStatus", "Nickname", "FJILPOJPHBN", "BNGGHHEDCCG", "Uid", "IsBanned", "OCEEDDHPOJM", "HeadIcon", "ELHOBBDCJCA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerSimpleInfo : pb::IMessage<PlayerSimpleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerSimpleInfo> _parser = new pb::MessageParser<PlayerSimpleInfo>(() => new PlayerSimpleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerSimpleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerSimpleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerSimpleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerSimpleInfo(PlayerSimpleInfo other) : this() {
      platform_ = other.platform_;
      eNCFJMBPOGO_ = other.eNCFJMBPOGO_.Clone();
      signature_ = other.signature_;
      level_ = other.level_;
      onlineStatus_ = other.onlineStatus_;
      nickname_ = other.nickname_;
      fJILPOJPHBN_ = other.fJILPOJPHBN_;
      bNGGHHEDCCG_ = other.bNGGHHEDCCG_;
      uid_ = other.uid_;
      isBanned_ = other.isBanned_;
      oCEEDDHPOJM_ = other.oCEEDDHPOJM_;
      headIcon_ = other.headIcon_;
      eLHOBBDCJCA_ = other.eLHOBBDCJCA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerSimpleInfo Clone() {
      return new PlayerSimpleInfo(this);
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.PlatformType platform_ = global::EggLink.DanhengServer.Proto.PlatformType.Editor;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlatformType Platform {
      get { return platform_; }
      set {
        platform_ = value;
      }
    }

    /// <summary>Field number for the "ENCFJMBPOGO" field.</summary>
    public const int ENCFJMBPOGOFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AssistSimpleInfo> _repeated_eNCFJMBPOGO_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.AssistSimpleInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AssistSimpleInfo> eNCFJMBPOGO_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AssistSimpleInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AssistSimpleInfo> ENCFJMBPOGO {
      get { return eNCFJMBPOGO_; }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 6;
    private string signature_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Signature {
      get { return signature_; }
      set {
        signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 1;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "onlineStatus" field.</summary>
    public const int OnlineStatusFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.FriendOnlineStatus onlineStatus_ = global::EggLink.DanhengServer.Proto.FriendOnlineStatus.Offline;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FriendOnlineStatus OnlineStatus {
      get { return onlineStatus_; }
      set {
        onlineStatus_ = value;
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 7;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "FJILPOJPHBN" field.</summary>
    public const int FJILPOJPHBNFieldNumber = 3;
    private string fJILPOJPHBN_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FJILPOJPHBN {
      get { return fJILPOJPHBN_; }
      set {
        fJILPOJPHBN_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "BNGGHHEDCCG" field.</summary>
    public const int BNGGHHEDCCGFieldNumber = 2;
    private string bNGGHHEDCCG_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BNGGHHEDCCG {
      get { return bNGGHHEDCCG_; }
      set {
        bNGGHHEDCCG_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 4;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "is_banned" field.</summary>
    public const int IsBannedFieldNumber = 15;
    private bool isBanned_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsBanned {
      get { return isBanned_; }
      set {
        isBanned_ = value;
      }
    }

    /// <summary>Field number for the "OCEEDDHPOJM" field.</summary>
    public const int OCEEDDHPOJMFieldNumber = 13;
    private long oCEEDDHPOJM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long OCEEDDHPOJM {
      get { return oCEEDDHPOJM_; }
      set {
        oCEEDDHPOJM_ = value;
      }
    }

    /// <summary>Field number for the "head_icon" field.</summary>
    public const int HeadIconFieldNumber = 5;
    private uint headIcon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HeadIcon {
      get { return headIcon_; }
      set {
        headIcon_ = value;
      }
    }

    /// <summary>Field number for the "ELHOBBDCJCA" field.</summary>
    public const int ELHOBBDCJCAFieldNumber = 11;
    private uint eLHOBBDCJCA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ELHOBBDCJCA {
      get { return eLHOBBDCJCA_; }
      set {
        eLHOBBDCJCA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerSimpleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerSimpleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Platform != other.Platform) return false;
      if(!eNCFJMBPOGO_.Equals(other.eNCFJMBPOGO_)) return false;
      if (Signature != other.Signature) return false;
      if (Level != other.Level) return false;
      if (OnlineStatus != other.OnlineStatus) return false;
      if (Nickname != other.Nickname) return false;
      if (FJILPOJPHBN != other.FJILPOJPHBN) return false;
      if (BNGGHHEDCCG != other.BNGGHHEDCCG) return false;
      if (Uid != other.Uid) return false;
      if (IsBanned != other.IsBanned) return false;
      if (OCEEDDHPOJM != other.OCEEDDHPOJM) return false;
      if (HeadIcon != other.HeadIcon) return false;
      if (ELHOBBDCJCA != other.ELHOBBDCJCA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) hash ^= Platform.GetHashCode();
      hash ^= eNCFJMBPOGO_.GetHashCode();
      if (Signature.Length != 0) hash ^= Signature.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (OnlineStatus != global::EggLink.DanhengServer.Proto.FriendOnlineStatus.Offline) hash ^= OnlineStatus.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (FJILPOJPHBN.Length != 0) hash ^= FJILPOJPHBN.GetHashCode();
      if (BNGGHHEDCCG.Length != 0) hash ^= BNGGHHEDCCG.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (IsBanned != false) hash ^= IsBanned.GetHashCode();
      if (OCEEDDHPOJM != 0L) hash ^= OCEEDDHPOJM.GetHashCode();
      if (HeadIcon != 0) hash ^= HeadIcon.GetHashCode();
      if (ELHOBBDCJCA != 0) hash ^= ELHOBBDCJCA.GetHashCode();
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
      if (Level != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Level);
      }
      if (BNGGHHEDCCG.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BNGGHHEDCCG);
      }
      if (FJILPOJPHBN.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(FJILPOJPHBN);
      }
      if (Uid != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Uid);
      }
      if (HeadIcon != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(HeadIcon);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Signature);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Nickname);
      }
      eNCFJMBPOGO_.WriteTo(output, _repeated_eNCFJMBPOGO_codec);
      if (OnlineStatus != global::EggLink.DanhengServer.Proto.FriendOnlineStatus.Offline) {
        output.WriteRawTag(72);
        output.WriteEnum((int) OnlineStatus);
      }
      if (ELHOBBDCJCA != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ELHOBBDCJCA);
      }
      if (OCEEDDHPOJM != 0L) {
        output.WriteRawTag(104);
        output.WriteInt64(OCEEDDHPOJM);
      }
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        output.WriteRawTag(112);
        output.WriteEnum((int) Platform);
      }
      if (IsBanned != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsBanned);
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
      if (Level != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Level);
      }
      if (BNGGHHEDCCG.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BNGGHHEDCCG);
      }
      if (FJILPOJPHBN.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(FJILPOJPHBN);
      }
      if (Uid != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Uid);
      }
      if (HeadIcon != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(HeadIcon);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Signature);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Nickname);
      }
      eNCFJMBPOGO_.WriteTo(ref output, _repeated_eNCFJMBPOGO_codec);
      if (OnlineStatus != global::EggLink.DanhengServer.Proto.FriendOnlineStatus.Offline) {
        output.WriteRawTag(72);
        output.WriteEnum((int) OnlineStatus);
      }
      if (ELHOBBDCJCA != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ELHOBBDCJCA);
      }
      if (OCEEDDHPOJM != 0L) {
        output.WriteRawTag(104);
        output.WriteInt64(OCEEDDHPOJM);
      }
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        output.WriteRawTag(112);
        output.WriteEnum((int) Platform);
      }
      if (IsBanned != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsBanned);
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
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Platform);
      }
      size += eNCFJMBPOGO_.CalculateSize(_repeated_eNCFJMBPOGO_codec);
      if (Signature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Signature);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (OnlineStatus != global::EggLink.DanhengServer.Proto.FriendOnlineStatus.Offline) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OnlineStatus);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (FJILPOJPHBN.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FJILPOJPHBN);
      }
      if (BNGGHHEDCCG.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BNGGHHEDCCG);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (IsBanned != false) {
        size += 1 + 1;
      }
      if (OCEEDDHPOJM != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(OCEEDDHPOJM);
      }
      if (HeadIcon != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HeadIcon);
      }
      if (ELHOBBDCJCA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ELHOBBDCJCA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerSimpleInfo other) {
      if (other == null) {
        return;
      }
      if (other.Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        Platform = other.Platform;
      }
      eNCFJMBPOGO_.Add(other.eNCFJMBPOGO_);
      if (other.Signature.Length != 0) {
        Signature = other.Signature;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.OnlineStatus != global::EggLink.DanhengServer.Proto.FriendOnlineStatus.Offline) {
        OnlineStatus = other.OnlineStatus;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.FJILPOJPHBN.Length != 0) {
        FJILPOJPHBN = other.FJILPOJPHBN;
      }
      if (other.BNGGHHEDCCG.Length != 0) {
        BNGGHHEDCCG = other.BNGGHHEDCCG;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.IsBanned != false) {
        IsBanned = other.IsBanned;
      }
      if (other.OCEEDDHPOJM != 0L) {
        OCEEDDHPOJM = other.OCEEDDHPOJM;
      }
      if (other.HeadIcon != 0) {
        HeadIcon = other.HeadIcon;
      }
      if (other.ELHOBBDCJCA != 0) {
        ELHOBBDCJCA = other.ELHOBBDCJCA;
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
            Level = input.ReadUInt32();
            break;
          }
          case 18: {
            BNGGHHEDCCG = input.ReadString();
            break;
          }
          case 26: {
            FJILPOJPHBN = input.ReadString();
            break;
          }
          case 32: {
            Uid = input.ReadUInt32();
            break;
          }
          case 40: {
            HeadIcon = input.ReadUInt32();
            break;
          }
          case 50: {
            Signature = input.ReadString();
            break;
          }
          case 58: {
            Nickname = input.ReadString();
            break;
          }
          case 66: {
            eNCFJMBPOGO_.AddEntriesFrom(input, _repeated_eNCFJMBPOGO_codec);
            break;
          }
          case 72: {
            OnlineStatus = (global::EggLink.DanhengServer.Proto.FriendOnlineStatus) input.ReadEnum();
            break;
          }
          case 88: {
            ELHOBBDCJCA = input.ReadUInt32();
            break;
          }
          case 104: {
            OCEEDDHPOJM = input.ReadInt64();
            break;
          }
          case 112: {
            Platform = (global::EggLink.DanhengServer.Proto.PlatformType) input.ReadEnum();
            break;
          }
          case 120: {
            IsBanned = input.ReadBool();
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
            Level = input.ReadUInt32();
            break;
          }
          case 18: {
            BNGGHHEDCCG = input.ReadString();
            break;
          }
          case 26: {
            FJILPOJPHBN = input.ReadString();
            break;
          }
          case 32: {
            Uid = input.ReadUInt32();
            break;
          }
          case 40: {
            HeadIcon = input.ReadUInt32();
            break;
          }
          case 50: {
            Signature = input.ReadString();
            break;
          }
          case 58: {
            Nickname = input.ReadString();
            break;
          }
          case 66: {
            eNCFJMBPOGO_.AddEntriesFrom(ref input, _repeated_eNCFJMBPOGO_codec);
            break;
          }
          case 72: {
            OnlineStatus = (global::EggLink.DanhengServer.Proto.FriendOnlineStatus) input.ReadEnum();
            break;
          }
          case 88: {
            ELHOBBDCJCA = input.ReadUInt32();
            break;
          }
          case 104: {
            OCEEDDHPOJM = input.ReadInt64();
            break;
          }
          case 112: {
            Platform = (global::EggLink.DanhengServer.Proto.PlatformType) input.ReadEnum();
            break;
          }
          case 120: {
            IsBanned = input.ReadBool();
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
