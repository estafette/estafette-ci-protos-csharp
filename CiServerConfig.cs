// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: contracts.v1/ci_server_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.CI.Contracts.V1 {

  /// <summary>Holder for reflection information generated from contracts.v1/ci_server_config.proto</summary>
  public static partial class CiServerConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for contracts.v1/ci_server_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CiServerConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNjb250cmFjdHMudjEvY2lfc2VydmVyX2NvbmZpZy5wcm90bxIMY29udHJh",
            "Y3RzLnYxImYKDkNJU2VydmVyQ29uZmlnEhAKCGJhc2VfdXJsGAEgASgJEhoK",
            "EmJ1aWxkZXJfZXZlbnRzX3VybBgCIAEoCRIVCg1wb3N0X2xvZ3NfdXJsGAMg",
            "ASgJEg8KB2FwaV9rZXkYBCABKAlCXVo/Z2l0aHViLmNvbS9lc3RhZmV0dGUv",
            "ZXN0YWZldHRlLWNpLWNvbnRyYWN0cy1nb2xhbmcvY29udHJhY3RzX3YxqgIZ",
            "RXN0YWZldHRlLkNJLkNvbnRyYWN0cy5WMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.CI.Contracts.V1.CIServerConfig), global::Estafette.CI.Contracts.V1.CIServerConfig.Parser, new[]{ "BaseUrl", "BuilderEventsUrl", "PostLogsUrl", "ApiKey" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CIServerConfig : pb::IMessage<CIServerConfig> {
    private static readonly pb::MessageParser<CIServerConfig> _parser = new pb::MessageParser<CIServerConfig>(() => new CIServerConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CIServerConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.CI.Contracts.V1.CiServerConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CIServerConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CIServerConfig(CIServerConfig other) : this() {
      baseUrl_ = other.baseUrl_;
      builderEventsUrl_ = other.builderEventsUrl_;
      postLogsUrl_ = other.postLogsUrl_;
      apiKey_ = other.apiKey_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CIServerConfig Clone() {
      return new CIServerConfig(this);
    }

    /// <summary>Field number for the "base_url" field.</summary>
    public const int BaseUrlFieldNumber = 1;
    private string baseUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BaseUrl {
      get { return baseUrl_; }
      set {
        baseUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "builder_events_url" field.</summary>
    public const int BuilderEventsUrlFieldNumber = 2;
    private string builderEventsUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BuilderEventsUrl {
      get { return builderEventsUrl_; }
      set {
        builderEventsUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "post_logs_url" field.</summary>
    public const int PostLogsUrlFieldNumber = 3;
    private string postLogsUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PostLogsUrl {
      get { return postLogsUrl_; }
      set {
        postLogsUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "api_key" field.</summary>
    public const int ApiKeyFieldNumber = 4;
    private string apiKey_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ApiKey {
      get { return apiKey_; }
      set {
        apiKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CIServerConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CIServerConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BaseUrl != other.BaseUrl) return false;
      if (BuilderEventsUrl != other.BuilderEventsUrl) return false;
      if (PostLogsUrl != other.PostLogsUrl) return false;
      if (ApiKey != other.ApiKey) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BaseUrl.Length != 0) hash ^= BaseUrl.GetHashCode();
      if (BuilderEventsUrl.Length != 0) hash ^= BuilderEventsUrl.GetHashCode();
      if (PostLogsUrl.Length != 0) hash ^= PostLogsUrl.GetHashCode();
      if (ApiKey.Length != 0) hash ^= ApiKey.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (BaseUrl.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BaseUrl);
      }
      if (BuilderEventsUrl.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BuilderEventsUrl);
      }
      if (PostLogsUrl.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PostLogsUrl);
      }
      if (ApiKey.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ApiKey);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BaseUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BaseUrl);
      }
      if (BuilderEventsUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BuilderEventsUrl);
      }
      if (PostLogsUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PostLogsUrl);
      }
      if (ApiKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApiKey);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CIServerConfig other) {
      if (other == null) {
        return;
      }
      if (other.BaseUrl.Length != 0) {
        BaseUrl = other.BaseUrl;
      }
      if (other.BuilderEventsUrl.Length != 0) {
        BuilderEventsUrl = other.BuilderEventsUrl;
      }
      if (other.PostLogsUrl.Length != 0) {
        PostLogsUrl = other.PostLogsUrl;
      }
      if (other.ApiKey.Length != 0) {
        ApiKey = other.ApiKey;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            BaseUrl = input.ReadString();
            break;
          }
          case 18: {
            BuilderEventsUrl = input.ReadString();
            break;
          }
          case 26: {
            PostLogsUrl = input.ReadString();
            break;
          }
          case 34: {
            ApiKey = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
