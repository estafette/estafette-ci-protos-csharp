// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: estafette/ci/manifest/v1/estafette_manifest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.Ci.Manifest.V1 {

  /// <summary>Holder for reflection information generated from estafette/ci/manifest/v1/estafette_manifest.proto</summary>
  public static partial class EstafetteManifestReflection {

    #region Descriptor
    /// <summary>File descriptor for estafette/ci/manifest/v1/estafette_manifest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EstafetteManifestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFlc3RhZmV0dGUvY2kvbWFuaWZlc3QvdjEvZXN0YWZldHRlX21hbmlmZXN0",
            "LnByb3RvEhhlc3RhZmV0dGUuY2kubWFuaWZlc3QudjEaMGVzdGFmZXR0ZS9j",
            "aS9tYW5pZmVzdC92MS9lc3RhZmV0dGVfYnVpbGRlci5wcm90bxowZXN0YWZl",
            "dHRlL2NpL21hbmlmZXN0L3YxL2VzdGFmZXR0ZV9yZWxlYXNlLnByb3RvGi5l",
            "c3RhZmV0dGUvY2kvbWFuaWZlc3QvdjEvZXN0YWZldHRlX3N0YWdlLnByb3Rv",
            "GjBlc3RhZmV0dGUvY2kvbWFuaWZlc3QvdjEvZXN0YWZldHRlX3RyaWdnZXIu",
            "cHJvdG8aMGVzdGFmZXR0ZS9jaS9tYW5pZmVzdC92MS9lc3RhZmV0dGVfdmVy",
            "c2lvbi5wcm90byLKBAoRRXN0YWZldHRlTWFuaWZlc3QSOwoHYnVpbGRlchgB",
            "IAEoCzIqLmVzdGFmZXR0ZS5jaS5tYW5pZmVzdC52MS5Fc3RhZmV0dGVCdWls",
            "ZGVyEkcKBmxhYmVscxgCIAMoCzI3LmVzdGFmZXR0ZS5jaS5tYW5pZmVzdC52",
            "MS5Fc3RhZmV0dGVNYW5pZmVzdC5MYWJlbHNFbnRyeRI7Cgd2ZXJzaW9uGAMg",
            "ASgLMiouZXN0YWZldHRlLmNpLm1hbmlmZXN0LnYxLkVzdGFmZXR0ZVZlcnNp",
            "b24SVwoPZ2xvYmFsX2Vudl92YXJzGAQgAygLMj4uZXN0YWZldHRlLmNpLm1h",
            "bmlmZXN0LnYxLkVzdGFmZXR0ZU1hbmlmZXN0Lkdsb2JhbEVudlZhcnNFbnRy",
            "eRI8Cgh0cmlnZ2VycxgFIAMoCzIqLmVzdGFmZXR0ZS5jaS5tYW5pZmVzdC52",
            "MS5Fc3RhZmV0dGVUcmlnZ2VyEjgKBnN0YWdlcxgGIAMoCzIoLmVzdGFmZXR0",
            "ZS5jaS5tYW5pZmVzdC52MS5Fc3RhZmV0dGVTdGFnZRI8CghyZWxlYXNlcxgH",
            "IAMoCzIqLmVzdGFmZXR0ZS5jaS5tYW5pZmVzdC52MS5Fc3RhZmV0dGVSZWxl",
            "YXNlGi0KC0xhYmVsc0VudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEo",
            "CToCOAEaNAoSR2xvYmFsRW52VmFyc0VudHJ5EgsKA2tleRgBIAEoCRINCgV2",
            "YWx1ZRgCIAEoCToCOAFCeAocY29tLmVzdGFmZXR0ZS5jaS5tYW5pZmVzdC52",
            "MVABWjtnaXRodWIuY29tL2VzdGFmZXR0ZS9lc3RhZmV0dGUtY2ktcHJvdG9z",
            "LWdvbGFuZy9tYW5pZmVzdF92MaoCGEVzdGFmZXR0ZS5DaS5NYW5pZmVzdC5W",
            "MWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Estafette.Ci.Manifest.V1.EstafetteBuilderReflection.Descriptor, global::Estafette.Ci.Manifest.V1.EstafetteReleaseReflection.Descriptor, global::Estafette.Ci.Manifest.V1.EstafetteStageReflection.Descriptor, global::Estafette.Ci.Manifest.V1.EstafetteTriggerReflection.Descriptor, global::Estafette.Ci.Manifest.V1.EstafetteVersionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.Ci.Manifest.V1.EstafetteManifest), global::Estafette.Ci.Manifest.V1.EstafetteManifest.Parser, new[]{ "Builder", "Labels", "Version", "GlobalEnvVars", "Triggers", "Stages", "Releases" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EstafetteManifest : pb::IMessage<EstafetteManifest> {
    private static readonly pb::MessageParser<EstafetteManifest> _parser = new pb::MessageParser<EstafetteManifest>(() => new EstafetteManifest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EstafetteManifest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.Ci.Manifest.V1.EstafetteManifestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteManifest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteManifest(EstafetteManifest other) : this() {
      builder_ = other.builder_ != null ? other.builder_.Clone() : null;
      labels_ = other.labels_.Clone();
      version_ = other.version_ != null ? other.version_.Clone() : null;
      globalEnvVars_ = other.globalEnvVars_.Clone();
      triggers_ = other.triggers_.Clone();
      stages_ = other.stages_.Clone();
      releases_ = other.releases_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteManifest Clone() {
      return new EstafetteManifest(this);
    }

    /// <summary>Field number for the "builder" field.</summary>
    public const int BuilderFieldNumber = 1;
    private global::Estafette.Ci.Manifest.V1.EstafetteBuilder builder_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Estafette.Ci.Manifest.V1.EstafetteBuilder Builder {
      get { return builder_; }
      set {
        builder_ = value;
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 2;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 18);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 3;
    private global::Estafette.Ci.Manifest.V1.EstafetteVersion version_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Estafette.Ci.Manifest.V1.EstafetteVersion Version {
      get { return version_; }
      set {
        version_ = value;
      }
    }

    /// <summary>Field number for the "global_env_vars" field.</summary>
    public const int GlobalEnvVarsFieldNumber = 4;
    private static readonly pbc::MapField<string, string>.Codec _map_globalEnvVars_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 34);
    private readonly pbc::MapField<string, string> globalEnvVars_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> GlobalEnvVars {
      get { return globalEnvVars_; }
    }

    /// <summary>Field number for the "triggers" field.</summary>
    public const int TriggersFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Estafette.Ci.Manifest.V1.EstafetteTrigger> _repeated_triggers_codec
        = pb::FieldCodec.ForMessage(42, global::Estafette.Ci.Manifest.V1.EstafetteTrigger.Parser);
    private readonly pbc::RepeatedField<global::Estafette.Ci.Manifest.V1.EstafetteTrigger> triggers_ = new pbc::RepeatedField<global::Estafette.Ci.Manifest.V1.EstafetteTrigger>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Estafette.Ci.Manifest.V1.EstafetteTrigger> Triggers {
      get { return triggers_; }
    }

    /// <summary>Field number for the "stages" field.</summary>
    public const int StagesFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Estafette.Ci.Manifest.V1.EstafetteStage> _repeated_stages_codec
        = pb::FieldCodec.ForMessage(50, global::Estafette.Ci.Manifest.V1.EstafetteStage.Parser);
    private readonly pbc::RepeatedField<global::Estafette.Ci.Manifest.V1.EstafetteStage> stages_ = new pbc::RepeatedField<global::Estafette.Ci.Manifest.V1.EstafetteStage>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Estafette.Ci.Manifest.V1.EstafetteStage> Stages {
      get { return stages_; }
    }

    /// <summary>Field number for the "releases" field.</summary>
    public const int ReleasesFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Estafette.Ci.Manifest.V1.EstafetteRelease> _repeated_releases_codec
        = pb::FieldCodec.ForMessage(58, global::Estafette.Ci.Manifest.V1.EstafetteRelease.Parser);
    private readonly pbc::RepeatedField<global::Estafette.Ci.Manifest.V1.EstafetteRelease> releases_ = new pbc::RepeatedField<global::Estafette.Ci.Manifest.V1.EstafetteRelease>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Estafette.Ci.Manifest.V1.EstafetteRelease> Releases {
      get { return releases_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EstafetteManifest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EstafetteManifest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Builder, other.Builder)) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (!object.Equals(Version, other.Version)) return false;
      if (!GlobalEnvVars.Equals(other.GlobalEnvVars)) return false;
      if(!triggers_.Equals(other.triggers_)) return false;
      if(!stages_.Equals(other.stages_)) return false;
      if(!releases_.Equals(other.releases_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (builder_ != null) hash ^= Builder.GetHashCode();
      hash ^= Labels.GetHashCode();
      if (version_ != null) hash ^= Version.GetHashCode();
      hash ^= GlobalEnvVars.GetHashCode();
      hash ^= triggers_.GetHashCode();
      hash ^= stages_.GetHashCode();
      hash ^= releases_.GetHashCode();
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
      if (builder_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Builder);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (version_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Version);
      }
      globalEnvVars_.WriteTo(output, _map_globalEnvVars_codec);
      triggers_.WriteTo(output, _repeated_triggers_codec);
      stages_.WriteTo(output, _repeated_stages_codec);
      releases_.WriteTo(output, _repeated_releases_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (builder_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Builder);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (version_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Version);
      }
      size += globalEnvVars_.CalculateSize(_map_globalEnvVars_codec);
      size += triggers_.CalculateSize(_repeated_triggers_codec);
      size += stages_.CalculateSize(_repeated_stages_codec);
      size += releases_.CalculateSize(_repeated_releases_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EstafetteManifest other) {
      if (other == null) {
        return;
      }
      if (other.builder_ != null) {
        if (builder_ == null) {
          Builder = new global::Estafette.Ci.Manifest.V1.EstafetteBuilder();
        }
        Builder.MergeFrom(other.Builder);
      }
      labels_.Add(other.labels_);
      if (other.version_ != null) {
        if (version_ == null) {
          Version = new global::Estafette.Ci.Manifest.V1.EstafetteVersion();
        }
        Version.MergeFrom(other.Version);
      }
      globalEnvVars_.Add(other.globalEnvVars_);
      triggers_.Add(other.triggers_);
      stages_.Add(other.stages_);
      releases_.Add(other.releases_);
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
            if (builder_ == null) {
              Builder = new global::Estafette.Ci.Manifest.V1.EstafetteBuilder();
            }
            input.ReadMessage(Builder);
            break;
          }
          case 18: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 26: {
            if (version_ == null) {
              Version = new global::Estafette.Ci.Manifest.V1.EstafetteVersion();
            }
            input.ReadMessage(Version);
            break;
          }
          case 34: {
            globalEnvVars_.AddEntriesFrom(input, _map_globalEnvVars_codec);
            break;
          }
          case 42: {
            triggers_.AddEntriesFrom(input, _repeated_triggers_codec);
            break;
          }
          case 50: {
            stages_.AddEntriesFrom(input, _repeated_stages_codec);
            break;
          }
          case 58: {
            releases_.AddEntriesFrom(input, _repeated_releases_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
