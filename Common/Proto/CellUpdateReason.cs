// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CellUpdateReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CellUpdateReason.proto</summary>
  public static partial class CellUpdateReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for CellUpdateReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CellUpdateReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZDZWxsVXBkYXRlUmVhc29uLnByb3RvKmgKEENlbGxVcGRhdGVSZWFzb24S",
            "JwojQ0hFU1NfUk9HVUVfQ0VMTF9VUERBVEVfUkVBU09OX05PTkUQABIrCidD",
            "SEVTU19ST0dVRV9DRUxMX1VQREFURV9SRUFTT05fTU9ESUZJRVIQAUIeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.CellUpdateReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum CellUpdateReason {
    [pbr::OriginalName("CHESS_ROGUE_CELL_UPDATE_REASON_NONE")] ChessRogueCellUpdateReasonNone = 0,
    [pbr::OriginalName("CHESS_ROGUE_CELL_UPDATE_REASON_MODIFIER")] ChessRogueCellUpdateReasonModifier = 1,
  }

  #endregion

}

#endregion Designer generated code