// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueGiveUpRollScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueGiveUpRollScRsp.proto</summary>
  public static partial class ChessRogueGiveUpRollScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueGiveUpRollScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueGiveUpRollScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9DaGVzc1JvZ3VlR2l2ZVVwUm9sbFNjUnNwLnByb3RvGhFFRU9HTk5HQUFJ",
            "Ty5wcm90bxoOSXRlbUxpc3QucHJvdG8ibwoZQ2hlc3NSb2d1ZUdpdmVVcFJv",
            "bGxTY1JzcBIPCgdyZXRjb2RlGAUgASgNEiEKC05MSEdHSUxCSU5QGAIgASgL",
            "MgwuRUVPR05OR0FBSU8SHgoLS05ETEpOSkVNSkUYCSABKAsyCS5JdGVtTGlz",
            "dEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.EEOGNNGAAIOReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueGiveUpRollScRsp), global::EggLink.DanhengServer.Proto.ChessRogueGiveUpRollScRsp.Parser, new[]{ "Retcode", "NLHGGILBINP", "KNDLJNJEMJE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueGiveUpRollScRsp : pb::IMessage<ChessRogueGiveUpRollScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueGiveUpRollScRsp> _parser = new pb::MessageParser<ChessRogueGiveUpRollScRsp>(() => new ChessRogueGiveUpRollScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueGiveUpRollScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueGiveUpRollScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueGiveUpRollScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueGiveUpRollScRsp(ChessRogueGiveUpRollScRsp other) : this() {
      retcode_ = other.retcode_;
      nLHGGILBINP_ = other.nLHGGILBINP_ != null ? other.nLHGGILBINP_.Clone() : null;
      kNDLJNJEMJE_ = other.kNDLJNJEMJE_ != null ? other.kNDLJNJEMJE_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueGiveUpRollScRsp Clone() {
      return new ChessRogueGiveUpRollScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 5;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "NLHGGILBINP" field.</summary>
    public const int NLHGGILBINPFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.EEOGNNGAAIO nLHGGILBINP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EEOGNNGAAIO NLHGGILBINP {
      get { return nLHGGILBINP_; }
      set {
        nLHGGILBINP_ = value;
      }
    }

    /// <summary>Field number for the "KNDLJNJEMJE" field.</summary>
    public const int KNDLJNJEMJEFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.ItemList kNDLJNJEMJE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList KNDLJNJEMJE {
      get { return kNDLJNJEMJE_; }
      set {
        kNDLJNJEMJE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueGiveUpRollScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueGiveUpRollScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(NLHGGILBINP, other.NLHGGILBINP)) return false;
      if (!object.Equals(KNDLJNJEMJE, other.KNDLJNJEMJE)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (nLHGGILBINP_ != null) hash ^= NLHGGILBINP.GetHashCode();
      if (kNDLJNJEMJE_ != null) hash ^= KNDLJNJEMJE.GetHashCode();
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
      if (nLHGGILBINP_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(NLHGGILBINP);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (kNDLJNJEMJE_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(KNDLJNJEMJE);
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
      if (nLHGGILBINP_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(NLHGGILBINP);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (kNDLJNJEMJE_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(KNDLJNJEMJE);
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
      if (nLHGGILBINP_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NLHGGILBINP);
      }
      if (kNDLJNJEMJE_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(KNDLJNJEMJE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueGiveUpRollScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.nLHGGILBINP_ != null) {
        if (nLHGGILBINP_ == null) {
          NLHGGILBINP = new global::EggLink.DanhengServer.Proto.EEOGNNGAAIO();
        }
        NLHGGILBINP.MergeFrom(other.NLHGGILBINP);
      }
      if (other.kNDLJNJEMJE_ != null) {
        if (kNDLJNJEMJE_ == null) {
          KNDLJNJEMJE = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        KNDLJNJEMJE.MergeFrom(other.KNDLJNJEMJE);
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
          case 18: {
            if (nLHGGILBINP_ == null) {
              NLHGGILBINP = new global::EggLink.DanhengServer.Proto.EEOGNNGAAIO();
            }
            input.ReadMessage(NLHGGILBINP);
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 74: {
            if (kNDLJNJEMJE_ == null) {
              KNDLJNJEMJE = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(KNDLJNJEMJE);
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
          case 18: {
            if (nLHGGILBINP_ == null) {
              NLHGGILBINP = new global::EggLink.DanhengServer.Proto.EEOGNNGAAIO();
            }
            input.ReadMessage(NLHGGILBINP);
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 74: {
            if (kNDLJNJEMJE_ == null) {
              KNDLJNJEMJE = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(KNDLJNJEMJE);
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
