// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: manifest.v1/estafette_pipeline_trigger.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.CI.Manifest.V1 {

  /// <summary>Holder for reflection information generated from manifest.v1/estafette_pipeline_trigger.proto</summary>
  public static partial class EstafettePipelineTriggerReflection {

    #region Descriptor
    /// <summary>File descriptor for manifest.v1/estafette_pipeline_trigger.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EstafettePipelineTriggerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixtYW5pZmVzdC52MS9lc3RhZmV0dGVfcGlwZWxpbmVfdHJpZ2dlci5wcm90",
            "bxILbWFuaWZlc3QudjEiVwoYRXN0YWZldHRlUGlwZWxpbmVUcmlnZ2VyEg0K",
            "BWV2ZW50GAEgASgJEg4KBnN0YXR1cxgCIAEoCRIMCgRuYW1lGAMgASgJEg4K",
            "BmJyYW5jaBgEIAEoCUJ1Chtpby5lc3RhZmV0dGUuY2kubWFuaWZlc3QudjFa",
            "O2dpdGh1Yi5jb20vZXN0YWZldHRlL2VzdGFmZXR0ZS1jaS1wcm90b3MtZ29s",
            "YW5nL21hbmlmZXN0X3YxqgIYRXN0YWZldHRlLkNJLk1hbmlmZXN0LlYxYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.CI.Manifest.V1.EstafettePipelineTrigger), global::Estafette.CI.Manifest.V1.EstafettePipelineTrigger.Parser, new[]{ "Event", "Status", "Name", "Branch" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EstafettePipelineTrigger : pb::IMessage<EstafettePipelineTrigger> {
    private static readonly pb::MessageParser<EstafettePipelineTrigger> _parser = new pb::MessageParser<EstafettePipelineTrigger>(() => new EstafettePipelineTrigger());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EstafettePipelineTrigger> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.CI.Manifest.V1.EstafettePipelineTriggerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafettePipelineTrigger() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafettePipelineTrigger(EstafettePipelineTrigger other) : this() {
      event_ = other.event_;
      status_ = other.status_;
      name_ = other.name_;
      branch_ = other.branch_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafettePipelineTrigger Clone() {
      return new EstafettePipelineTrigger(this);
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

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 2;
    private string status_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Status {
      get { return status_; }
      set {
        status_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "branch" field.</summary>
    public const int BranchFieldNumber = 4;
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
      return Equals(other as EstafettePipelineTrigger);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EstafettePipelineTrigger other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Event != other.Event) return false;
      if (Status != other.Status) return false;
      if (Name != other.Name) return false;
      if (Branch != other.Branch) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Event.Length != 0) hash ^= Event.GetHashCode();
      if (Status.Length != 0) hash ^= Status.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (Status.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Status);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Branch.Length != 0) {
        output.WriteRawTag(34);
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
      if (Status.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Status);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
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
    public void MergeFrom(EstafettePipelineTrigger other) {
      if (other == null) {
        return;
      }
      if (other.Event.Length != 0) {
        Event = other.Event;
      }
      if (other.Status.Length != 0) {
        Status = other.Status;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
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
            Status = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
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
