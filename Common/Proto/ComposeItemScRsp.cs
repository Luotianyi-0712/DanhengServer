// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ComposeItemScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ComposeItemScRsp.proto</summary>
  public static partial class ComposeItemScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ComposeItemScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ComposeItemScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZDb21wb3NlSXRlbVNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90byJrChBD",
            "b21wb3NlSXRlbVNjUnNwEhIKCmNvbXBvc2VfaWQYCyABKA0SIwoQcmV0dXJu",
            "X2l0ZW1fbGlzdBgNIAEoCzIJLkl0ZW1MaXN0Eg0KBWNvdW50GAQgASgNEg8K",
            "B3JldGNvZGUYByABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ComposeItemScRsp), global::EggLink.DanhengServer.Proto.ComposeItemScRsp.Parser, new[]{ "ComposeId", "ReturnItemList", "Count", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ComposeItemScRsp : pb::IMessage<ComposeItemScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ComposeItemScRsp> _parser = new pb::MessageParser<ComposeItemScRsp>(() => new ComposeItemScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ComposeItemScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ComposeItemScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComposeItemScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComposeItemScRsp(ComposeItemScRsp other) : this() {
      composeId_ = other.composeId_;
      returnItemList_ = other.returnItemList_ != null ? other.returnItemList_.Clone() : null;
      count_ = other.count_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComposeItemScRsp Clone() {
      return new ComposeItemScRsp(this);
    }

    /// <summary>Field number for the "compose_id" field.</summary>
    public const int ComposeIdFieldNumber = 11;
    private uint composeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ComposeId {
      get { return composeId_; }
      set {
        composeId_ = value;
      }
    }

    /// <summary>Field number for the "return_item_list" field.</summary>
    public const int ReturnItemListFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.ItemList returnItemList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList ReturnItemList {
      get { return returnItemList_; }
      set {
        returnItemList_ = value;
      }
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 4;
    private uint count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
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
      return Equals(other as ComposeItemScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ComposeItemScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ComposeId != other.ComposeId) return false;
      if (!object.Equals(ReturnItemList, other.ReturnItemList)) return false;
      if (Count != other.Count) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ComposeId != 0) hash ^= ComposeId.GetHashCode();
      if (returnItemList_ != null) hash ^= ReturnItemList.GetHashCode();
      if (Count != 0) hash ^= Count.GetHashCode();
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
      if (Count != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Count);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      if (ComposeId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ComposeId);
      }
      if (returnItemList_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ReturnItemList);
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
      if (Count != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Count);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      if (ComposeId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ComposeId);
      }
      if (returnItemList_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ReturnItemList);
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
      if (ComposeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ComposeId);
      }
      if (returnItemList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReturnItemList);
      }
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Count);
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
    public void MergeFrom(ComposeItemScRsp other) {
      if (other == null) {
        return;
      }
      if (other.ComposeId != 0) {
        ComposeId = other.ComposeId;
      }
      if (other.returnItemList_ != null) {
        if (returnItemList_ == null) {
          ReturnItemList = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        ReturnItemList.MergeFrom(other.ReturnItemList);
      }
      if (other.Count != 0) {
        Count = other.Count;
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
            Count = input.ReadUInt32();
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 88: {
            ComposeId = input.ReadUInt32();
            break;
          }
          case 106: {
            if (returnItemList_ == null) {
              ReturnItemList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ReturnItemList);
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
            Count = input.ReadUInt32();
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 88: {
            ComposeId = input.ReadUInt32();
            break;
          }
          case 106: {
            if (returnItemList_ == null) {
              ReturnItemList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ReturnItemList);
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
