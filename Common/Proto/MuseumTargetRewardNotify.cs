// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MuseumTargetRewardNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MuseumTargetRewardNotify.proto</summary>
  public static partial class MuseumTargetRewardNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for MuseumTargetRewardNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MuseumTargetRewardNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5NdXNldW1UYXJnZXRSZXdhcmROb3RpZnkucHJvdG8iVQoYTXVzZXVtVGFy",
            "Z2V0UmV3YXJkTm90aWZ5Eg8KB2l0ZW1faWQYAyABKA0SEwoLR0tBQlBFTkNO",
            "TkIYDiABKA0SEwoLTEpIRE5GTEhNTEwYCyABKA1CHqoCG0VnZ0xpbmsuRGFu",
            "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MuseumTargetRewardNotify), global::EggLink.DanhengServer.Proto.MuseumTargetRewardNotify.Parser, new[]{ "ItemId", "GKABPENCNNB", "LJHDNFLHMLL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MuseumTargetRewardNotify : pb::IMessage<MuseumTargetRewardNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MuseumTargetRewardNotify> _parser = new pb::MessageParser<MuseumTargetRewardNotify>(() => new MuseumTargetRewardNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MuseumTargetRewardNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MuseumTargetRewardNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuseumTargetRewardNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuseumTargetRewardNotify(MuseumTargetRewardNotify other) : this() {
      itemId_ = other.itemId_;
      gKABPENCNNB_ = other.gKABPENCNNB_;
      lJHDNFLHMLL_ = other.lJHDNFLHMLL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuseumTargetRewardNotify Clone() {
      return new MuseumTargetRewardNotify(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 3;
    private uint itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "GKABPENCNNB" field.</summary>
    public const int GKABPENCNNBFieldNumber = 14;
    private uint gKABPENCNNB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GKABPENCNNB {
      get { return gKABPENCNNB_; }
      set {
        gKABPENCNNB_ = value;
      }
    }

    /// <summary>Field number for the "LJHDNFLHMLL" field.</summary>
    public const int LJHDNFLHMLLFieldNumber = 11;
    private uint lJHDNFLHMLL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LJHDNFLHMLL {
      get { return lJHDNFLHMLL_; }
      set {
        lJHDNFLHMLL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MuseumTargetRewardNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MuseumTargetRewardNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (GKABPENCNNB != other.GKABPENCNNB) return false;
      if (LJHDNFLHMLL != other.LJHDNFLHMLL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (GKABPENCNNB != 0) hash ^= GKABPENCNNB.GetHashCode();
      if (LJHDNFLHMLL != 0) hash ^= LJHDNFLHMLL.GetHashCode();
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
      if (ItemId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ItemId);
      }
      if (LJHDNFLHMLL != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(LJHDNFLHMLL);
      }
      if (GKABPENCNNB != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GKABPENCNNB);
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
      if (ItemId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ItemId);
      }
      if (LJHDNFLHMLL != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(LJHDNFLHMLL);
      }
      if (GKABPENCNNB != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GKABPENCNNB);
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
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemId);
      }
      if (GKABPENCNNB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GKABPENCNNB);
      }
      if (LJHDNFLHMLL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LJHDNFLHMLL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MuseumTargetRewardNotify other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.GKABPENCNNB != 0) {
        GKABPENCNNB = other.GKABPENCNNB;
      }
      if (other.LJHDNFLHMLL != 0) {
        LJHDNFLHMLL = other.LJHDNFLHMLL;
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
            ItemId = input.ReadUInt32();
            break;
          }
          case 88: {
            LJHDNFLHMLL = input.ReadUInt32();
            break;
          }
          case 112: {
            GKABPENCNNB = input.ReadUInt32();
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
            ItemId = input.ReadUInt32();
            break;
          }
          case 88: {
            LJHDNFLHMLL = input.ReadUInt32();
            break;
          }
          case 112: {
            GKABPENCNNB = input.ReadUInt32();
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
