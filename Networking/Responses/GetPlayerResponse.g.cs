// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Responses/GetPlayerResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/GetPlayerResponse.proto</summary>
  public static partial class GetPlayerResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/GetPlayerResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetPlayerResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjdQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0dldFBsYXllclJl",
            "c3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2Vz",
            "GiBQT0dPUHJvdG9zL0RhdGEvUGxheWVyRGF0YS5wcm90byJ0ChFHZXRQbGF5",
            "ZXJSZXNwb25zZRIPCgdzdWNjZXNzGAEgASgIEjAKC3BsYXllcl9kYXRhGAIg",
            "ASgLMhsuUE9HT1Byb3Rvcy5EYXRhLlBsYXllckRhdGESDgoGYmFubmVkGAMg",
            "ASgIEgwKBHdhcm4YBCABKAhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.PlayerDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.GetPlayerResponse), global::POGOProtos.Networking.Responses.GetPlayerResponse.Parser, new[]{ "Success", "PlayerData", "Banned", "Warn" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetPlayerResponse : pb::IMessage<GetPlayerResponse> {
    private static readonly pb::MessageParser<GetPlayerResponse> _parser = new pb::MessageParser<GetPlayerResponse>(() => new GetPlayerResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetPlayerResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.GetPlayerResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPlayerResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPlayerResponse(GetPlayerResponse other) : this() {
      success_ = other.success_;
      PlayerData = other.playerData_ != null ? other.PlayerData.Clone() : null;
      banned_ = other.banned_;
      warn_ = other.warn_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPlayerResponse Clone() {
      return new GetPlayerResponse(this);
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 1;
    private bool success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    /// <summary>Field number for the "player_data" field.</summary>
    public const int PlayerDataFieldNumber = 2;
    private global::POGOProtos.Data.PlayerData playerData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.PlayerData PlayerData {
      get { return playerData_; }
      set {
        playerData_ = value;
      }
    }

    /// <summary>Field number for the "banned" field.</summary>
    public const int BannedFieldNumber = 3;
    private bool banned_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Banned {
      get { return banned_; }
      set {
        banned_ = value;
      }
    }

    /// <summary>Field number for the "warn" field.</summary>
    public const int WarnFieldNumber = 4;
    private bool warn_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Warn {
      get { return warn_; }
      set {
        warn_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetPlayerResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetPlayerResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Success != other.Success) return false;
      if (!object.Equals(PlayerData, other.PlayerData)) return false;
      if (Banned != other.Banned) return false;
      if (Warn != other.Warn) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Success != false) hash ^= Success.GetHashCode();
      if (playerData_ != null) hash ^= PlayerData.GetHashCode();
      if (Banned != false) hash ^= Banned.GetHashCode();
      if (Warn != false) hash ^= Warn.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Success != false) {
        output.WriteRawTag(8);
        output.WriteBool(Success);
      }
      if (playerData_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PlayerData);
      }
      if (Banned != false) {
        output.WriteRawTag(24);
        output.WriteBool(Banned);
      }
      if (Warn != false) {
        output.WriteRawTag(32);
        output.WriteBool(Warn);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Success != false) {
        size += 1 + 1;
      }
      if (playerData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerData);
      }
      if (Banned != false) {
        size += 1 + 1;
      }
      if (Warn != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetPlayerResponse other) {
      if (other == null) {
        return;
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      if (other.playerData_ != null) {
        if (playerData_ == null) {
          playerData_ = new global::POGOProtos.Data.PlayerData();
        }
        PlayerData.MergeFrom(other.PlayerData);
      }
      if (other.Banned != false) {
        Banned = other.Banned;
      }
      if (other.Warn != false) {
        Warn = other.Warn;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Success = input.ReadBool();
            break;
          }
          case 18: {
            if (playerData_ == null) {
              playerData_ = new global::POGOProtos.Data.PlayerData();
            }
            input.ReadMessage(playerData_);
            break;
          }
          case 24: {
            Banned = input.ReadBool();
            break;
          }
          case 32: {
            Warn = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
