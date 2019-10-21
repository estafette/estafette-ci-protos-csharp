// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: manifest.v1/estafette_release_event.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.CI.Manifest.V1 {

  /// <summary>Holder for reflection information generated from manifest.v1/estafette_release_event.proto</summary>
  public static partial class EstafetteReleaseEventReflection {

    #region Descriptor
    /// <summary>File descriptor for manifest.v1/estafette_release_event.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EstafetteReleaseEventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiltYW5pZmVzdC52MS9lc3RhZmV0dGVfcmVsZWFzZV9ldmVudC5wcm90bxIL",
            "bWFuaWZlc3QudjEimwEKFUVzdGFmZXR0ZVJlbGVhc2VFdmVudBIXCg9yZWxl",
            "YXNlX3ZlcnNpb24YASABKAkSEwoLcmVwb19zb3VyY2UYAiABKAkSEgoKcmVw",
            "b19vd25lchgDIAEoCRIRCglyZXBvX25hbWUYBCABKAkSDgoGdGFyZ2V0GAUg",
            "ASgJEg4KBnN0YXR1cxgGIAEoCRINCgVldmVudBgHIAEoCUJ4Chtpby5lc3Rh",
            "ZmV0dGUuY2kubWFuaWZlc3QudjFaPmdpdGh1Yi5jb20vZXN0YWZldHRlL2Vz",
            "dGFmZXR0ZS1jaS1jb250cmFjdHMtZ29sYW5nL21hbmlmZXN0X3YxqgIYRXN0",
            "YWZldHRlLkNJLk1hbmlmZXN0LlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.CI.Manifest.V1.EstafetteReleaseEvent), global::Estafette.CI.Manifest.V1.EstafetteReleaseEvent.Parser, new[]{ "ReleaseVersion", "RepoSource", "RepoOwner", "RepoName", "Target", "Status", "Event" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EstafetteReleaseEvent : pb::IMessage<EstafetteReleaseEvent> {
    private static readonly pb::MessageParser<EstafetteReleaseEvent> _parser = new pb::MessageParser<EstafetteReleaseEvent>(() => new EstafetteReleaseEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EstafetteReleaseEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.CI.Manifest.V1.EstafetteReleaseEventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteReleaseEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteReleaseEvent(EstafetteReleaseEvent other) : this() {
      releaseVersion_ = other.releaseVersion_;
      repoSource_ = other.repoSource_;
      repoOwner_ = other.repoOwner_;
      repoName_ = other.repoName_;
      target_ = other.target_;
      status_ = other.status_;
      event_ = other.event_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteReleaseEvent Clone() {
      return new EstafetteReleaseEvent(this);
    }

    /// <summary>Field number for the "release_version" field.</summary>
    public const int ReleaseVersionFieldNumber = 1;
    private string releaseVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ReleaseVersion {
      get { return releaseVersion_; }
      set {
        releaseVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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

    /// <summary>Field number for the "target" field.</summary>
    public const int TargetFieldNumber = 5;
    private string target_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Target {
      get { return target_; }
      set {
        target_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 6;
    private string status_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Status {
      get { return status_; }
      set {
        status_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "event" field.</summary>
    public const int EventFieldNumber = 7;
    private string event_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Event {
      get { return event_; }
      set {
        event_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EstafetteReleaseEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EstafetteReleaseEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ReleaseVersion != other.ReleaseVersion) return false;
      if (RepoSource != other.RepoSource) return false;
      if (RepoOwner != other.RepoOwner) return false;
      if (RepoName != other.RepoName) return false;
      if (Target != other.Target) return false;
      if (Status != other.Status) return false;
      if (Event != other.Event) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ReleaseVersion.Length != 0) hash ^= ReleaseVersion.GetHashCode();
      if (RepoSource.Length != 0) hash ^= RepoSource.GetHashCode();
      if (RepoOwner.Length != 0) hash ^= RepoOwner.GetHashCode();
      if (RepoName.Length != 0) hash ^= RepoName.GetHashCode();
      if (Target.Length != 0) hash ^= Target.GetHashCode();
      if (Status.Length != 0) hash ^= Status.GetHashCode();
      if (Event.Length != 0) hash ^= Event.GetHashCode();
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
      if (ReleaseVersion.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ReleaseVersion);
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
      if (Target.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Target);
      }
      if (Status.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Status);
      }
      if (Event.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Event);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ReleaseVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReleaseVersion);
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
      if (Target.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Target);
      }
      if (Status.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Status);
      }
      if (Event.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Event);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EstafetteReleaseEvent other) {
      if (other == null) {
        return;
      }
      if (other.ReleaseVersion.Length != 0) {
        ReleaseVersion = other.ReleaseVersion;
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
      if (other.Target.Length != 0) {
        Target = other.Target;
      }
      if (other.Status.Length != 0) {
        Status = other.Status;
      }
      if (other.Event.Length != 0) {
        Event = other.Event;
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
            ReleaseVersion = input.ReadString();
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
            Target = input.ReadString();
            break;
          }
          case 50: {
            Status = input.ReadString();
            break;
          }
          case 58: {
            Event = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
