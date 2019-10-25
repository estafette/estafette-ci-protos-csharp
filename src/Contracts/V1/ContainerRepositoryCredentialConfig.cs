// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: contracts.v1/container_repository_credential_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.CI.Contracts.V1 {

  /// <summary>Holder for reflection information generated from contracts.v1/container_repository_credential_config.proto</summary>
  public static partial class ContainerRepositoryCredentialConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for contracts.v1/container_repository_credential_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ContainerRepositoryCredentialConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjljb250cmFjdHMudjEvY29udGFpbmVyX3JlcG9zaXRvcnlfY3JlZGVudGlh",
            "bF9jb25maWcucHJvdG8SDGNvbnRyYWN0cy52MSJdCiNDb250YWluZXJSZXBv",
            "c2l0b3J5Q3JlZGVudGlhbENvbmZpZxISCgpyZXBvc2l0b3J5GAEgASgJEhAK",
            "CHVzZXJuYW1lGAIgASgJEhAKCHBhc3N3b3JkGAMgASgJQngKHGlvLmVzdGFm",
            "ZXR0ZS5jaS5jb250cmFjdHMudjFaPGdpdGh1Yi5jb20vZXN0YWZldHRlL2Vz",
            "dGFmZXR0ZS1jaS1wcm90b3MtZ29sYW5nL2NvbnRyYWN0c192MaoCGUVzdGFm",
            "ZXR0ZS5DSS5Db250cmFjdHMuVjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.CI.Contracts.V1.ContainerRepositoryCredentialConfig), global::Estafette.CI.Contracts.V1.ContainerRepositoryCredentialConfig.Parser, new[]{ "Repository", "Username", "Password" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ContainerRepositoryCredentialConfig : pb::IMessage<ContainerRepositoryCredentialConfig> {
    private static readonly pb::MessageParser<ContainerRepositoryCredentialConfig> _parser = new pb::MessageParser<ContainerRepositoryCredentialConfig>(() => new ContainerRepositoryCredentialConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ContainerRepositoryCredentialConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.CI.Contracts.V1.ContainerRepositoryCredentialConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContainerRepositoryCredentialConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContainerRepositoryCredentialConfig(ContainerRepositoryCredentialConfig other) : this() {
      repository_ = other.repository_;
      username_ = other.username_;
      password_ = other.password_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContainerRepositoryCredentialConfig Clone() {
      return new ContainerRepositoryCredentialConfig(this);
    }

    /// <summary>Field number for the "repository" field.</summary>
    public const int RepositoryFieldNumber = 1;
    private string repository_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Repository {
      get { return repository_; }
      set {
        repository_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "username" field.</summary>
    public const int UsernameFieldNumber = 2;
    private string username_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Username {
      get { return username_; }
      set {
        username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "password" field.</summary>
    public const int PasswordFieldNumber = 3;
    private string password_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Password {
      get { return password_; }
      set {
        password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ContainerRepositoryCredentialConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ContainerRepositoryCredentialConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Repository != other.Repository) return false;
      if (Username != other.Username) return false;
      if (Password != other.Password) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Repository.Length != 0) hash ^= Repository.GetHashCode();
      if (Username.Length != 0) hash ^= Username.GetHashCode();
      if (Password.Length != 0) hash ^= Password.GetHashCode();
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
      if (Repository.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Repository);
      }
      if (Username.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Username);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Password);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Repository.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Repository);
      }
      if (Username.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
      }
      if (Password.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ContainerRepositoryCredentialConfig other) {
      if (other == null) {
        return;
      }
      if (other.Repository.Length != 0) {
        Repository = other.Repository;
      }
      if (other.Username.Length != 0) {
        Username = other.Username;
      }
      if (other.Password.Length != 0) {
        Password = other.Password;
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
            Repository = input.ReadString();
            break;
          }
          case 18: {
            Username = input.ReadString();
            break;
          }
          case 26: {
            Password = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
