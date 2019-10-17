// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: contracts.v1/build_version_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.CI.Contracts.V1 {

  /// <summary>Holder for reflection information generated from contracts.v1/build_version_config.proto</summary>
  public static partial class BuildVersionConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for contracts.v1/build_version_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BuildVersionConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cidjb250cmFjdHMudjEvYnVpbGRfdmVyc2lvbl9jb25maWcucHJvdG8SDGNv",
            "bnRyYWN0cy52MSJ5ChJCdWlsZFZlcnNpb25Db25maWcSDwoHdmVyc2lvbhgB",
            "IAEoCRINCgVtYWpvchgCIAEoAxINCgVtaW5vchgDIAEoAxINCgVwYXRjaBgE",
            "IAEoCRINCgVsYWJlbBgFIAEoCRIWCg5hdXRvX2luY3JlbWVudBgGIAEoA0Jd",
            "Wj9naXRodWIuY29tL2VzdGFmZXR0ZS9lc3RhZmV0dGUtY2ktY29udHJhY3Rz",
            "LWdvbGFuZy9jb250cmFjdHNfdjGqAhlFc3RhZmV0dGUuQ0kuQ29udHJhY3Rz",
            "LlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.CI.Contracts.V1.BuildVersionConfig), global::Estafette.CI.Contracts.V1.BuildVersionConfig.Parser, new[]{ "Version", "Major", "Minor", "Patch", "Label", "AutoIncrement" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BuildVersionConfig : pb::IMessage<BuildVersionConfig> {
    private static readonly pb::MessageParser<BuildVersionConfig> _parser = new pb::MessageParser<BuildVersionConfig>(() => new BuildVersionConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BuildVersionConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.CI.Contracts.V1.BuildVersionConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildVersionConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildVersionConfig(BuildVersionConfig other) : this() {
      version_ = other.version_;
      major_ = other.major_;
      minor_ = other.minor_;
      patch_ = other.patch_;
      label_ = other.label_;
      autoIncrement_ = other.autoIncrement_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildVersionConfig Clone() {
      return new BuildVersionConfig(this);
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 1;
    private string version_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "major" field.</summary>
    public const int MajorFieldNumber = 2;
    private long major_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Major {
      get { return major_; }
      set {
        major_ = value;
      }
    }

    /// <summary>Field number for the "minor" field.</summary>
    public const int MinorFieldNumber = 3;
    private long minor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Minor {
      get { return minor_; }
      set {
        minor_ = value;
      }
    }

    /// <summary>Field number for the "patch" field.</summary>
    public const int PatchFieldNumber = 4;
    private string patch_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Patch {
      get { return patch_; }
      set {
        patch_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 5;
    private string label_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Label {
      get { return label_; }
      set {
        label_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "auto_increment" field.</summary>
    public const int AutoIncrementFieldNumber = 6;
    private long autoIncrement_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long AutoIncrement {
      get { return autoIncrement_; }
      set {
        autoIncrement_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BuildVersionConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BuildVersionConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Version != other.Version) return false;
      if (Major != other.Major) return false;
      if (Minor != other.Minor) return false;
      if (Patch != other.Patch) return false;
      if (Label != other.Label) return false;
      if (AutoIncrement != other.AutoIncrement) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Version.Length != 0) hash ^= Version.GetHashCode();
      if (Major != 0L) hash ^= Major.GetHashCode();
      if (Minor != 0L) hash ^= Minor.GetHashCode();
      if (Patch.Length != 0) hash ^= Patch.GetHashCode();
      if (Label.Length != 0) hash ^= Label.GetHashCode();
      if (AutoIncrement != 0L) hash ^= AutoIncrement.GetHashCode();
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
      if (Version.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Version);
      }
      if (Major != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Major);
      }
      if (Minor != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Minor);
      }
      if (Patch.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Patch);
      }
      if (Label.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Label);
      }
      if (AutoIncrement != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(AutoIncrement);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      if (Major != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Major);
      }
      if (Minor != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Minor);
      }
      if (Patch.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Patch);
      }
      if (Label.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Label);
      }
      if (AutoIncrement != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(AutoIncrement);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BuildVersionConfig other) {
      if (other == null) {
        return;
      }
      if (other.Version.Length != 0) {
        Version = other.Version;
      }
      if (other.Major != 0L) {
        Major = other.Major;
      }
      if (other.Minor != 0L) {
        Minor = other.Minor;
      }
      if (other.Patch.Length != 0) {
        Patch = other.Patch;
      }
      if (other.Label.Length != 0) {
        Label = other.Label;
      }
      if (other.AutoIncrement != 0L) {
        AutoIncrement = other.AutoIncrement;
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
            Version = input.ReadString();
            break;
          }
          case 16: {
            Major = input.ReadInt64();
            break;
          }
          case 24: {
            Minor = input.ReadInt64();
            break;
          }
          case 34: {
            Patch = input.ReadString();
            break;
          }
          case 42: {
            Label = input.ReadString();
            break;
          }
          case 48: {
            AutoIncrement = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
