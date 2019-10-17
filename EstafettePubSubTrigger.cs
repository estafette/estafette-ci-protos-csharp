// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: manifest.v1/estafette_pub_sub_trigger.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.CI.Manifest.V1 {

  /// <summary>Holder for reflection information generated from manifest.v1/estafette_pub_sub_trigger.proto</summary>
  public static partial class EstafettePubSubTriggerReflection {

    #region Descriptor
    /// <summary>File descriptor for manifest.v1/estafette_pub_sub_trigger.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EstafettePubSubTriggerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CittYW5pZmVzdC52MS9lc3RhZmV0dGVfcHViX3N1Yl90cmlnZ2VyLnByb3Rv",
            "EgttYW5pZmVzdC52MSI4ChZFc3RhZmV0dGVQdWJTdWJUcmlnZ2VyEg8KB3By",
            "b2plY3QYASABKAkSDQoFdG9waWMYAiABKAlCW1o+Z2l0aHViLmNvbS9lc3Rh",
            "ZmV0dGUvZXN0YWZldHRlLWNpLWNvbnRyYWN0cy1nb2xhbmcvbWFuaWZlc3Rf",
            "djGqAhhFc3RhZmV0dGUuQ0kuTWFuaWZlc3QuVjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.CI.Manifest.V1.EstafettePubSubTrigger), global::Estafette.CI.Manifest.V1.EstafettePubSubTrigger.Parser, new[]{ "Project", "Topic" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EstafettePubSubTrigger : pb::IMessage<EstafettePubSubTrigger> {
    private static readonly pb::MessageParser<EstafettePubSubTrigger> _parser = new pb::MessageParser<EstafettePubSubTrigger>(() => new EstafettePubSubTrigger());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EstafettePubSubTrigger> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.CI.Manifest.V1.EstafettePubSubTriggerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafettePubSubTrigger() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafettePubSubTrigger(EstafettePubSubTrigger other) : this() {
      project_ = other.project_;
      topic_ = other.topic_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafettePubSubTrigger Clone() {
      return new EstafettePubSubTrigger(this);
    }

    /// <summary>Field number for the "project" field.</summary>
    public const int ProjectFieldNumber = 1;
    private string project_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Project {
      get { return project_; }
      set {
        project_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "topic" field.</summary>
    public const int TopicFieldNumber = 2;
    private string topic_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Topic {
      get { return topic_; }
      set {
        topic_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EstafettePubSubTrigger);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EstafettePubSubTrigger other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Project != other.Project) return false;
      if (Topic != other.Topic) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Project.Length != 0) hash ^= Project.GetHashCode();
      if (Topic.Length != 0) hash ^= Topic.GetHashCode();
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
      if (Project.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Project);
      }
      if (Topic.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Topic);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Project.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Project);
      }
      if (Topic.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Topic);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EstafettePubSubTrigger other) {
      if (other == null) {
        return;
      }
      if (other.Project.Length != 0) {
        Project = other.Project;
      }
      if (other.Topic.Length != 0) {
        Topic = other.Topic;
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
            Project = input.ReadString();
            break;
          }
          case 18: {
            Topic = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
