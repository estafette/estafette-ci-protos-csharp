// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: estafette/ci/manifest/v1/estafette_semver_version.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.Ci.Manifest.V1 {

  /// <summary>Holder for reflection information generated from estafette/ci/manifest/v1/estafette_semver_version.proto</summary>
  public static partial class EstafetteSemverVersionReflection {

    #region Descriptor
    /// <summary>File descriptor for estafette/ci/manifest/v1/estafette_semver_version.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EstafetteSemverVersionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdlc3RhZmV0dGUvY2kvbWFuaWZlc3QvdjEvZXN0YWZldHRlX3NlbXZlcl92",
            "ZXJzaW9uLnByb3RvEhhlc3RhZmV0dGUuY2kubWFuaWZlc3QudjEaNWVzdGFm",
            "ZXR0ZS9jaS9tYW5pZmVzdC92MS9zdHJpbmdfb3Jfc3RyaW5nX2FycmF5LnBy",
            "b3RvIqQBChZFc3RhZmV0dGVTZW12ZXJWZXJzaW9uEg0KBW1ham9yGAEgASgD",
            "Eg0KBW1pbm9yGAIgASgDEg0KBXBhdGNoGAMgASgJEhYKDmxhYmVsX3RlbXBs",
            "YXRlGAQgASgJEkUKDnJlbGVhc2VfYnJhbmNoGAUgASgLMi0uZXN0YWZldHRl",
            "LmNpLm1hbmlmZXN0LnYxLlN0cmluZ09yU3RyaW5nQXJyYXlCeAocY29tLmVz",
            "dGFmZXR0ZS5jaS5tYW5pZmVzdC52MVABWjtnaXRodWIuY29tL2VzdGFmZXR0",
            "ZS9lc3RhZmV0dGUtY2ktcHJvdG9zLWdvbGFuZy9tYW5pZmVzdF92MaoCGEVz",
            "dGFmZXR0ZS5DaS5NYW5pZmVzdC5WMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Estafette.Ci.Manifest.V1.StringOrStringArrayReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.Ci.Manifest.V1.EstafetteSemverVersion), global::Estafette.Ci.Manifest.V1.EstafetteSemverVersion.Parser, new[]{ "Major", "Minor", "Patch", "LabelTemplate", "ReleaseBranch" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EstafetteSemverVersion : pb::IMessage<EstafetteSemverVersion> {
    private static readonly pb::MessageParser<EstafetteSemverVersion> _parser = new pb::MessageParser<EstafetteSemverVersion>(() => new EstafetteSemverVersion());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EstafetteSemverVersion> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.Ci.Manifest.V1.EstafetteSemverVersionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteSemverVersion() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteSemverVersion(EstafetteSemverVersion other) : this() {
      major_ = other.major_;
      minor_ = other.minor_;
      patch_ = other.patch_;
      labelTemplate_ = other.labelTemplate_;
      releaseBranch_ = other.releaseBranch_ != null ? other.releaseBranch_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteSemverVersion Clone() {
      return new EstafetteSemverVersion(this);
    }

    /// <summary>Field number for the "major" field.</summary>
    public const int MajorFieldNumber = 1;
    private long major_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Major {
      get { return major_; }
      set {
        major_ = value;
      }
    }

    /// <summary>Field number for the "minor" field.</summary>
    public const int MinorFieldNumber = 2;
    private long minor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Minor {
      get { return minor_; }
      set {
        minor_ = value;
      }
    }

    /// <summary>Field number for the "patch" field.</summary>
    public const int PatchFieldNumber = 3;
    private string patch_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Patch {
      get { return patch_; }
      set {
        patch_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "label_template" field.</summary>
    public const int LabelTemplateFieldNumber = 4;
    private string labelTemplate_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LabelTemplate {
      get { return labelTemplate_; }
      set {
        labelTemplate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "release_branch" field.</summary>
    public const int ReleaseBranchFieldNumber = 5;
    private global::Estafette.Ci.Manifest.V1.StringOrStringArray releaseBranch_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Estafette.Ci.Manifest.V1.StringOrStringArray ReleaseBranch {
      get { return releaseBranch_; }
      set {
        releaseBranch_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EstafetteSemverVersion);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EstafetteSemverVersion other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Major != other.Major) return false;
      if (Minor != other.Minor) return false;
      if (Patch != other.Patch) return false;
      if (LabelTemplate != other.LabelTemplate) return false;
      if (!object.Equals(ReleaseBranch, other.ReleaseBranch)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Major != 0L) hash ^= Major.GetHashCode();
      if (Minor != 0L) hash ^= Minor.GetHashCode();
      if (Patch.Length != 0) hash ^= Patch.GetHashCode();
      if (LabelTemplate.Length != 0) hash ^= LabelTemplate.GetHashCode();
      if (releaseBranch_ != null) hash ^= ReleaseBranch.GetHashCode();
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
      if (Major != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Major);
      }
      if (Minor != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Minor);
      }
      if (Patch.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Patch);
      }
      if (LabelTemplate.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LabelTemplate);
      }
      if (releaseBranch_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ReleaseBranch);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Major != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Major);
      }
      if (Minor != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Minor);
      }
      if (Patch.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Patch);
      }
      if (LabelTemplate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LabelTemplate);
      }
      if (releaseBranch_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReleaseBranch);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EstafetteSemverVersion other) {
      if (other == null) {
        return;
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
      if (other.LabelTemplate.Length != 0) {
        LabelTemplate = other.LabelTemplate;
      }
      if (other.releaseBranch_ != null) {
        if (releaseBranch_ == null) {
          ReleaseBranch = new global::Estafette.Ci.Manifest.V1.StringOrStringArray();
        }
        ReleaseBranch.MergeFrom(other.ReleaseBranch);
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
          case 8: {
            Major = input.ReadInt64();
            break;
          }
          case 16: {
            Minor = input.ReadInt64();
            break;
          }
          case 26: {
            Patch = input.ReadString();
            break;
          }
          case 34: {
            LabelTemplate = input.ReadString();
            break;
          }
          case 42: {
            if (releaseBranch_ == null) {
              ReleaseBranch = new global::Estafette.Ci.Manifest.V1.StringOrStringArray();
            }
            input.ReadMessage(ReleaseBranch);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
