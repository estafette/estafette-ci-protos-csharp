// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: contracts.v1/pipeline.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.CI.Contracts.V1 {

  /// <summary>Holder for reflection information generated from contracts.v1/pipeline.proto</summary>
  public static partial class PipelineReflection {

    #region Descriptor
    /// <summary>File descriptor for contracts.v1/pipeline.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PipelineReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chtjb250cmFjdHMudjEvcGlwZWxpbmUucHJvdG8SDGNvbnRyYWN0cy52MRoY",
            "Y29udHJhY3RzLnYxL2xhYmVsLnByb3RvGiFjb250cmFjdHMudjEvcmVsZWFz",
            "ZV90YXJnZXQucHJvdG8aHWNvbnRyYWN0cy52MS9naXRfY29tbWl0LnByb3Rv",
            "GiNtYW5pZmVzdC52MS9lc3RhZmV0dGVfdHJpZ2dlci5wcm90bxohbWFuaWZl",
            "c3QudjEvZXN0YWZldHRlX2V2ZW50LnByb3RvGh9nb29nbGUvcHJvdG9idWYv",
            "dGltZXN0YW1wLnByb3RvGh5nb29nbGUvcHJvdG9idWYvZHVyYXRpb24ucHJv",
            "dG8igwUKCFBpcGVsaW5lEgoKAmlkGAEgASgJEhMKC3JlcG9fc291cmNlGAIg",
            "ASgJEhIKCnJlcG9fb3duZXIYAyABKAkSEQoJcmVwb19uYW1lGAQgASgJEhMK",
            "C3JlcG9fYnJhbmNoGAUgASgJEhUKDXJlcG9fcmV2aXNpb24YBiABKAkSFQoN",
            "YnVpbGRfdmVyc2lvbhgHIAEoCRIUCgxidWlsZF9zdGF0dXMYCCABKAkSIwoG",
            "bGFiZWxzGAkgAygLMhMuY29udHJhY3RzLnYxLkxhYmVsEjQKD3JlbGVhc2Vf",
            "dGFyZ2V0cxgKIAMoCzIbLmNvbnRyYWN0cy52MS5SZWxlYXNlVGFyZ2V0EhAK",
            "CG1hbmlmZXN0GAsgASgJEh4KFm1hbmlmZXN0X3dpdGhfZGVmYXVsdHMYDCAB",
            "KAkSKAoHY29tbWl0cxgNIAMoCzIXLmNvbnRyYWN0cy52MS5HaXRDb21taXQS",
            "LwoIdHJpZ2dlcnMYDiADKAsyHS5tYW5pZmVzdC52MS5Fc3RhZmV0dGVUcmln",
            "Z2VyEisKBmV2ZW50cxgPIAMoCzIbLm1hbmlmZXN0LnYxLkVzdGFmZXR0ZUV2",
            "ZW50Ei8KC2luc2VydGVkX2F0GBAgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRp",
            "bWVzdGFtcBIuCgp1cGRhdGVkX2F0GBEgASgLMhouZ29vZ2xlLnByb3RvYnVm",
            "LlRpbWVzdGFtcBIrCghkdXJhdGlvbhgSIAEoCzIZLmdvb2dsZS5wcm90b2J1",
            "Zi5EdXJhdGlvbhIzCg9sYXN0X3VwZGF0ZWRfYXQYEyABKAsyGi5nb29nbGUu",
            "cHJvdG9idWYuVGltZXN0YW1wQl1aP2dpdGh1Yi5jb20vZXN0YWZldHRlL2Vz",
            "dGFmZXR0ZS1jaS1jb250cmFjdHMtZ29sYW5nL2NvbnRyYWN0c192MaoCGUVz",
            "dGFmZXR0ZS5DSS5Db250cmFjdHMuVjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Estafette.CI.Contracts.V1.LabelReflection.Descriptor, global::Estafette.CI.Contracts.V1.ReleaseTargetReflection.Descriptor, global::Estafette.CI.Contracts.V1.GitCommitReflection.Descriptor, global::Estafette.CI.Manifest.V1.EstafetteTriggerReflection.Descriptor, global::Estafette.CI.Manifest.V1.EstafetteEventReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.CI.Contracts.V1.Pipeline), global::Estafette.CI.Contracts.V1.Pipeline.Parser, new[]{ "Id", "RepoSource", "RepoOwner", "RepoName", "RepoBranch", "RepoRevision", "BuildVersion", "BuildStatus", "Labels", "ReleaseTargets", "Manifest", "ManifestWithDefaults", "Commits", "Triggers", "Events", "InsertedAt", "UpdatedAt", "Duration", "LastUpdatedAt" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Pipeline : pb::IMessage<Pipeline> {
    private static readonly pb::MessageParser<Pipeline> _parser = new pb::MessageParser<Pipeline>(() => new Pipeline());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Pipeline> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.CI.Contracts.V1.PipelineReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pipeline() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pipeline(Pipeline other) : this() {
      id_ = other.id_;
      repoSource_ = other.repoSource_;
      repoOwner_ = other.repoOwner_;
      repoName_ = other.repoName_;
      repoBranch_ = other.repoBranch_;
      repoRevision_ = other.repoRevision_;
      buildVersion_ = other.buildVersion_;
      buildStatus_ = other.buildStatus_;
      labels_ = other.labels_.Clone();
      releaseTargets_ = other.releaseTargets_.Clone();
      manifest_ = other.manifest_;
      manifestWithDefaults_ = other.manifestWithDefaults_;
      commits_ = other.commits_.Clone();
      triggers_ = other.triggers_.Clone();
      events_ = other.events_.Clone();
      insertedAt_ = other.insertedAt_ != null ? other.insertedAt_.Clone() : null;
      updatedAt_ = other.updatedAt_ != null ? other.updatedAt_.Clone() : null;
      duration_ = other.duration_ != null ? other.duration_.Clone() : null;
      lastUpdatedAt_ = other.lastUpdatedAt_ != null ? other.lastUpdatedAt_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pipeline Clone() {
      return new Pipeline(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_source" field.</summary>
    public const int RepoSourceFieldNumber = 2;
    private string repoSource_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoSource {
      get { return repoSource_; }
      set {
        repoSource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_owner" field.</summary>
    public const int RepoOwnerFieldNumber = 3;
    private string repoOwner_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoOwner {
      get { return repoOwner_; }
      set {
        repoOwner_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_name" field.</summary>
    public const int RepoNameFieldNumber = 4;
    private string repoName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoName {
      get { return repoName_; }
      set {
        repoName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_branch" field.</summary>
    public const int RepoBranchFieldNumber = 5;
    private string repoBranch_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoBranch {
      get { return repoBranch_; }
      set {
        repoBranch_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_revision" field.</summary>
    public const int RepoRevisionFieldNumber = 6;
    private string repoRevision_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoRevision {
      get { return repoRevision_; }
      set {
        repoRevision_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "build_version" field.</summary>
    public const int BuildVersionFieldNumber = 7;
    private string buildVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BuildVersion {
      get { return buildVersion_; }
      set {
        buildVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "build_status" field.</summary>
    public const int BuildStatusFieldNumber = 8;
    private string buildStatus_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BuildStatus {
      get { return buildStatus_; }
      set {
        buildStatus_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Estafette.CI.Contracts.V1.Label> _repeated_labels_codec
        = pb::FieldCodec.ForMessage(74, global::Estafette.CI.Contracts.V1.Label.Parser);
    private readonly pbc::RepeatedField<global::Estafette.CI.Contracts.V1.Label> labels_ = new pbc::RepeatedField<global::Estafette.CI.Contracts.V1.Label>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Estafette.CI.Contracts.V1.Label> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "release_targets" field.</summary>
    public const int ReleaseTargetsFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Estafette.CI.Contracts.V1.ReleaseTarget> _repeated_releaseTargets_codec
        = pb::FieldCodec.ForMessage(82, global::Estafette.CI.Contracts.V1.ReleaseTarget.Parser);
    private readonly pbc::RepeatedField<global::Estafette.CI.Contracts.V1.ReleaseTarget> releaseTargets_ = new pbc::RepeatedField<global::Estafette.CI.Contracts.V1.ReleaseTarget>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Estafette.CI.Contracts.V1.ReleaseTarget> ReleaseTargets {
      get { return releaseTargets_; }
    }

    /// <summary>Field number for the "manifest" field.</summary>
    public const int ManifestFieldNumber = 11;
    private string manifest_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Manifest {
      get { return manifest_; }
      set {
        manifest_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "manifest_with_defaults" field.</summary>
    public const int ManifestWithDefaultsFieldNumber = 12;
    private string manifestWithDefaults_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ManifestWithDefaults {
      get { return manifestWithDefaults_; }
      set {
        manifestWithDefaults_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "commits" field.</summary>
    public const int CommitsFieldNumber = 13;
    private static readonly pb::FieldCodec<global::Estafette.CI.Contracts.V1.GitCommit> _repeated_commits_codec
        = pb::FieldCodec.ForMessage(106, global::Estafette.CI.Contracts.V1.GitCommit.Parser);
    private readonly pbc::RepeatedField<global::Estafette.CI.Contracts.V1.GitCommit> commits_ = new pbc::RepeatedField<global::Estafette.CI.Contracts.V1.GitCommit>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Estafette.CI.Contracts.V1.GitCommit> Commits {
      get { return commits_; }
    }

    /// <summary>Field number for the "triggers" field.</summary>
    public const int TriggersFieldNumber = 14;
    private static readonly pb::FieldCodec<global::Estafette.CI.Manifest.V1.EstafetteTrigger> _repeated_triggers_codec
        = pb::FieldCodec.ForMessage(114, global::Estafette.CI.Manifest.V1.EstafetteTrigger.Parser);
    private readonly pbc::RepeatedField<global::Estafette.CI.Manifest.V1.EstafetteTrigger> triggers_ = new pbc::RepeatedField<global::Estafette.CI.Manifest.V1.EstafetteTrigger>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Estafette.CI.Manifest.V1.EstafetteTrigger> Triggers {
      get { return triggers_; }
    }

    /// <summary>Field number for the "events" field.</summary>
    public const int EventsFieldNumber = 15;
    private static readonly pb::FieldCodec<global::Estafette.CI.Manifest.V1.EstafetteEvent> _repeated_events_codec
        = pb::FieldCodec.ForMessage(122, global::Estafette.CI.Manifest.V1.EstafetteEvent.Parser);
    private readonly pbc::RepeatedField<global::Estafette.CI.Manifest.V1.EstafetteEvent> events_ = new pbc::RepeatedField<global::Estafette.CI.Manifest.V1.EstafetteEvent>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Estafette.CI.Manifest.V1.EstafetteEvent> Events {
      get { return events_; }
    }

    /// <summary>Field number for the "inserted_at" field.</summary>
    public const int InsertedAtFieldNumber = 16;
    private global::Google.Protobuf.WellKnownTypes.Timestamp insertedAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp InsertedAt {
      get { return insertedAt_; }
      set {
        insertedAt_ = value;
      }
    }

    /// <summary>Field number for the "updated_at" field.</summary>
    public const int UpdatedAtFieldNumber = 17;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updatedAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdatedAt {
      get { return updatedAt_; }
      set {
        updatedAt_ = value;
      }
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 18;
    private global::Google.Protobuf.WellKnownTypes.Duration duration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration Duration {
      get { return duration_; }
      set {
        duration_ = value;
      }
    }

    /// <summary>Field number for the "last_updated_at" field.</summary>
    public const int LastUpdatedAtFieldNumber = 19;
    private global::Google.Protobuf.WellKnownTypes.Timestamp lastUpdatedAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp LastUpdatedAt {
      get { return lastUpdatedAt_; }
      set {
        lastUpdatedAt_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Pipeline);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Pipeline other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (RepoSource != other.RepoSource) return false;
      if (RepoOwner != other.RepoOwner) return false;
      if (RepoName != other.RepoName) return false;
      if (RepoBranch != other.RepoBranch) return false;
      if (RepoRevision != other.RepoRevision) return false;
      if (BuildVersion != other.BuildVersion) return false;
      if (BuildStatus != other.BuildStatus) return false;
      if(!labels_.Equals(other.labels_)) return false;
      if(!releaseTargets_.Equals(other.releaseTargets_)) return false;
      if (Manifest != other.Manifest) return false;
      if (ManifestWithDefaults != other.ManifestWithDefaults) return false;
      if(!commits_.Equals(other.commits_)) return false;
      if(!triggers_.Equals(other.triggers_)) return false;
      if(!events_.Equals(other.events_)) return false;
      if (!object.Equals(InsertedAt, other.InsertedAt)) return false;
      if (!object.Equals(UpdatedAt, other.UpdatedAt)) return false;
      if (!object.Equals(Duration, other.Duration)) return false;
      if (!object.Equals(LastUpdatedAt, other.LastUpdatedAt)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (RepoSource.Length != 0) hash ^= RepoSource.GetHashCode();
      if (RepoOwner.Length != 0) hash ^= RepoOwner.GetHashCode();
      if (RepoName.Length != 0) hash ^= RepoName.GetHashCode();
      if (RepoBranch.Length != 0) hash ^= RepoBranch.GetHashCode();
      if (RepoRevision.Length != 0) hash ^= RepoRevision.GetHashCode();
      if (BuildVersion.Length != 0) hash ^= BuildVersion.GetHashCode();
      if (BuildStatus.Length != 0) hash ^= BuildStatus.GetHashCode();
      hash ^= labels_.GetHashCode();
      hash ^= releaseTargets_.GetHashCode();
      if (Manifest.Length != 0) hash ^= Manifest.GetHashCode();
      if (ManifestWithDefaults.Length != 0) hash ^= ManifestWithDefaults.GetHashCode();
      hash ^= commits_.GetHashCode();
      hash ^= triggers_.GetHashCode();
      hash ^= events_.GetHashCode();
      if (insertedAt_ != null) hash ^= InsertedAt.GetHashCode();
      if (updatedAt_ != null) hash ^= UpdatedAt.GetHashCode();
      if (duration_ != null) hash ^= Duration.GetHashCode();
      if (lastUpdatedAt_ != null) hash ^= LastUpdatedAt.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (RepoSource.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RepoSource);
      }
      if (RepoOwner.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RepoOwner);
      }
      if (RepoName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(RepoName);
      }
      if (RepoBranch.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(RepoBranch);
      }
      if (RepoRevision.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(RepoRevision);
      }
      if (BuildVersion.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(BuildVersion);
      }
      if (BuildStatus.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(BuildStatus);
      }
      labels_.WriteTo(output, _repeated_labels_codec);
      releaseTargets_.WriteTo(output, _repeated_releaseTargets_codec);
      if (Manifest.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Manifest);
      }
      if (ManifestWithDefaults.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(ManifestWithDefaults);
      }
      commits_.WriteTo(output, _repeated_commits_codec);
      triggers_.WriteTo(output, _repeated_triggers_codec);
      events_.WriteTo(output, _repeated_events_codec);
      if (insertedAt_ != null) {
        output.WriteRawTag(130, 1);
        output.WriteMessage(InsertedAt);
      }
      if (updatedAt_ != null) {
        output.WriteRawTag(138, 1);
        output.WriteMessage(UpdatedAt);
      }
      if (duration_ != null) {
        output.WriteRawTag(146, 1);
        output.WriteMessage(Duration);
      }
      if (lastUpdatedAt_ != null) {
        output.WriteRawTag(154, 1);
        output.WriteMessage(LastUpdatedAt);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (RepoSource.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RepoSource);
      }
      if (RepoOwner.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RepoOwner);
      }
      if (RepoName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RepoName);
      }
      if (RepoBranch.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RepoBranch);
      }
      if (RepoRevision.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RepoRevision);
      }
      if (BuildVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BuildVersion);
      }
      if (BuildStatus.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BuildStatus);
      }
      size += labels_.CalculateSize(_repeated_labels_codec);
      size += releaseTargets_.CalculateSize(_repeated_releaseTargets_codec);
      if (Manifest.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Manifest);
      }
      if (ManifestWithDefaults.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ManifestWithDefaults);
      }
      size += commits_.CalculateSize(_repeated_commits_codec);
      size += triggers_.CalculateSize(_repeated_triggers_codec);
      size += events_.CalculateSize(_repeated_events_codec);
      if (insertedAt_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(InsertedAt);
      }
      if (updatedAt_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(UpdatedAt);
      }
      if (duration_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Duration);
      }
      if (lastUpdatedAt_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(LastUpdatedAt);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Pipeline other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.RepoSource.Length != 0) {
        RepoSource = other.RepoSource;
      }
      if (other.RepoOwner.Length != 0) {
        RepoOwner = other.RepoOwner;
      }
      if (other.RepoName.Length != 0) {
        RepoName = other.RepoName;
      }
      if (other.RepoBranch.Length != 0) {
        RepoBranch = other.RepoBranch;
      }
      if (other.RepoRevision.Length != 0) {
        RepoRevision = other.RepoRevision;
      }
      if (other.BuildVersion.Length != 0) {
        BuildVersion = other.BuildVersion;
      }
      if (other.BuildStatus.Length != 0) {
        BuildStatus = other.BuildStatus;
      }
      labels_.Add(other.labels_);
      releaseTargets_.Add(other.releaseTargets_);
      if (other.Manifest.Length != 0) {
        Manifest = other.Manifest;
      }
      if (other.ManifestWithDefaults.Length != 0) {
        ManifestWithDefaults = other.ManifestWithDefaults;
      }
      commits_.Add(other.commits_);
      triggers_.Add(other.triggers_);
      events_.Add(other.events_);
      if (other.insertedAt_ != null) {
        if (insertedAt_ == null) {
          insertedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        InsertedAt.MergeFrom(other.InsertedAt);
      }
      if (other.updatedAt_ != null) {
        if (updatedAt_ == null) {
          updatedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdatedAt.MergeFrom(other.UpdatedAt);
      }
      if (other.duration_ != null) {
        if (duration_ == null) {
          duration_ = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        Duration.MergeFrom(other.Duration);
      }
      if (other.lastUpdatedAt_ != null) {
        if (lastUpdatedAt_ == null) {
          lastUpdatedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        LastUpdatedAt.MergeFrom(other.LastUpdatedAt);
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            RepoSource = input.ReadString();
            break;
          }
          case 26: {
            RepoOwner = input.ReadString();
            break;
          }
          case 34: {
            RepoName = input.ReadString();
            break;
          }
          case 42: {
            RepoBranch = input.ReadString();
            break;
          }
          case 50: {
            RepoRevision = input.ReadString();
            break;
          }
          case 58: {
            BuildVersion = input.ReadString();
            break;
          }
          case 66: {
            BuildStatus = input.ReadString();
            break;
          }
          case 74: {
            labels_.AddEntriesFrom(input, _repeated_labels_codec);
            break;
          }
          case 82: {
            releaseTargets_.AddEntriesFrom(input, _repeated_releaseTargets_codec);
            break;
          }
          case 90: {
            Manifest = input.ReadString();
            break;
          }
          case 98: {
            ManifestWithDefaults = input.ReadString();
            break;
          }
          case 106: {
            commits_.AddEntriesFrom(input, _repeated_commits_codec);
            break;
          }
          case 114: {
            triggers_.AddEntriesFrom(input, _repeated_triggers_codec);
            break;
          }
          case 122: {
            events_.AddEntriesFrom(input, _repeated_events_codec);
            break;
          }
          case 130: {
            if (insertedAt_ == null) {
              insertedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(insertedAt_);
            break;
          }
          case 138: {
            if (updatedAt_ == null) {
              updatedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(updatedAt_);
            break;
          }
          case 146: {
            if (duration_ == null) {
              duration_ = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(duration_);
            break;
          }
          case 154: {
            if (lastUpdatedAt_ == null) {
              lastUpdatedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(lastUpdatedAt_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
