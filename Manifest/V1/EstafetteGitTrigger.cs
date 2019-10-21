// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: manifest.v1/estafette_git_trigger.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.CI.Manifest.V1 {

  /// <summary>Holder for reflection information generated from manifest.v1/estafette_git_trigger.proto</summary>
  public static partial class EstafetteGitTriggerReflection {

    #region Descriptor
    /// <summary>File descriptor for manifest.v1/estafette_git_trigger.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EstafetteGitTriggerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidtYW5pZmVzdC52MS9lc3RhZmV0dGVfZ2l0X3RyaWdnZXIucHJvdG8SC21h",
            "bmlmZXN0LnYxIkgKE0VzdGFmZXR0ZUdpdFRyaWdnZXISDQoFZXZlbnQYASAB",
            "KAkSEgoKcmVwb3NpdG9yeRgCIAEoCRIOCgZicmFuY2gYAyABKAlCeAobaW8u",
            "ZXN0YWZldHRlLmNpLm1hbmlmZXN0LnYxWj5naXRodWIuY29tL2VzdGFmZXR0",
            "ZS9lc3RhZmV0dGUtY2ktY29udHJhY3RzLWdvbGFuZy9tYW5pZmVzdF92MaoC",
            "GEVzdGFmZXR0ZS5DSS5NYW5pZmVzdC5WMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.CI.Manifest.V1.EstafetteGitTrigger), global::Estafette.CI.Manifest.V1.EstafetteGitTrigger.Parser, new[]{ "Event", "Repository", "Branch" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EstafetteGitTrigger : pb::IMessage<EstafetteGitTrigger> {
    private static readonly pb::MessageParser<EstafetteGitTrigger> _parser = new pb::MessageParser<EstafetteGitTrigger>(() => new EstafetteGitTrigger());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EstafetteGitTrigger> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.CI.Manifest.V1.EstafetteGitTriggerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteGitTrigger() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteGitTrigger(EstafetteGitTrigger other) : this() {
      event_ = other.event_;
      repository_ = other.repository_;
      branch_ = other.branch_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteGitTrigger Clone() {
      return new EstafetteGitTrigger(this);
    }

    /// <summary>Field number for the "event" field.</summary>
    public const int EventFieldNumber = 1;
    private string event_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Event {
      get { return event_; }
      set {
        event_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repository" field.</summary>
    public const int RepositoryFieldNumber = 2;
    private string repository_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Repository {
      get { return repository_; }
      set {
        repository_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "branch" field.</summary>
    public const int BranchFieldNumber = 3;
    private string branch_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Branch {
      get { return branch_; }
      set {
        branch_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EstafetteGitTrigger);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EstafetteGitTrigger other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Event != other.Event) return false;
      if (Repository != other.Repository) return false;
      if (Branch != other.Branch) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Event.Length != 0) hash ^= Event.GetHashCode();
      if (Repository.Length != 0) hash ^= Repository.GetHashCode();
      if (Branch.Length != 0) hash ^= Branch.GetHashCode();
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
      if (Event.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Event);
      }
      if (Repository.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Repository);
      }
      if (Branch.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Branch);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Event.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Event);
      }
      if (Repository.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Repository);
      }
      if (Branch.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Branch);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EstafetteGitTrigger other) {
      if (other == null) {
        return;
      }
      if (other.Event.Length != 0) {
        Event = other.Event;
      }
      if (other.Repository.Length != 0) {
        Repository = other.Repository;
      }
      if (other.Branch.Length != 0) {
        Branch = other.Branch;
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
            Event = input.ReadString();
            break;
          }
          case 18: {
            Repository = input.ReadString();
            break;
          }
          case 26: {
            Branch = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
