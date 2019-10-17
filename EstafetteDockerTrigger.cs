// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: manifest.v1/estafette_docker_trigger.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.CI.Manifest.V1 {

  /// <summary>Holder for reflection information generated from manifest.v1/estafette_docker_trigger.proto</summary>
  public static partial class EstafetteDockerTriggerReflection {

    #region Descriptor
    /// <summary>File descriptor for manifest.v1/estafette_docker_trigger.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EstafetteDockerTriggerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiptYW5pZmVzdC52MS9lc3RhZmV0dGVfZG9ja2VyX3RyaWdnZXIucHJvdG8S",
            "C21hbmlmZXN0LnYxIkMKFkVzdGFmZXR0ZURvY2tlclRyaWdnZXISDQoFZXZl",
            "bnQYASABKAkSDQoFaW1hZ2UYAiABKAkSCwoDdGFnGAMgASgJQltaPmdpdGh1",
            "Yi5jb20vZXN0YWZldHRlL2VzdGFmZXR0ZS1jaS1jb250cmFjdHMtZ29sYW5n",
            "L21hbmlmZXN0X3YxqgIYRXN0YWZldHRlLkNJLk1hbmlmZXN0LlYxYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.CI.Manifest.V1.EstafetteDockerTrigger), global::Estafette.CI.Manifest.V1.EstafetteDockerTrigger.Parser, new[]{ "Event", "Image", "Tag" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EstafetteDockerTrigger : pb::IMessage<EstafetteDockerTrigger> {
    private static readonly pb::MessageParser<EstafetteDockerTrigger> _parser = new pb::MessageParser<EstafetteDockerTrigger>(() => new EstafetteDockerTrigger());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EstafetteDockerTrigger> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.CI.Manifest.V1.EstafetteDockerTriggerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteDockerTrigger() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteDockerTrigger(EstafetteDockerTrigger other) : this() {
      event_ = other.event_;
      image_ = other.image_;
      tag_ = other.tag_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteDockerTrigger Clone() {
      return new EstafetteDockerTrigger(this);
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

    /// <summary>Field number for the "image" field.</summary>
    public const int ImageFieldNumber = 2;
    private string image_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Image {
      get { return image_; }
      set {
        image_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tag" field.</summary>
    public const int TagFieldNumber = 3;
    private string tag_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Tag {
      get { return tag_; }
      set {
        tag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EstafetteDockerTrigger);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EstafetteDockerTrigger other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Event != other.Event) return false;
      if (Image != other.Image) return false;
      if (Tag != other.Tag) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Event.Length != 0) hash ^= Event.GetHashCode();
      if (Image.Length != 0) hash ^= Image.GetHashCode();
      if (Tag.Length != 0) hash ^= Tag.GetHashCode();
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
      if (Image.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Image);
      }
      if (Tag.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Tag);
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
      if (Image.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Image);
      }
      if (Tag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Tag);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EstafetteDockerTrigger other) {
      if (other == null) {
        return;
      }
      if (other.Event.Length != 0) {
        Event = other.Event;
      }
      if (other.Image.Length != 0) {
        Image = other.Image;
      }
      if (other.Tag.Length != 0) {
        Tag = other.Tag;
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
            Image = input.ReadString();
            break;
          }
          case 26: {
            Tag = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
