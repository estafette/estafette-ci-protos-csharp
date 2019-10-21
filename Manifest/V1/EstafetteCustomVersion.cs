// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: manifest.v1/estafette_custom_version.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.CI.Manifest.V1 {

  /// <summary>Holder for reflection information generated from manifest.v1/estafette_custom_version.proto</summary>
  public static partial class EstafetteCustomVersionReflection {

    #region Descriptor
    /// <summary>File descriptor for manifest.v1/estafette_custom_version.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EstafetteCustomVersionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiptYW5pZmVzdC52MS9lc3RhZmV0dGVfY3VzdG9tX3ZlcnNpb24ucHJvdG8S",
            "C21hbmlmZXN0LnYxIjAKFkVzdGFmZXR0ZUN1c3RvbVZlcnNpb24SFgoObGFi",
            "ZWxfdGVtcGxhdGUYASABKAlCeAobaW8uZXN0YWZldHRlLmNpLm1hbmlmZXN0",
            "LnYxWj5naXRodWIuY29tL2VzdGFmZXR0ZS9lc3RhZmV0dGUtY2ktY29udHJh",
            "Y3RzLWdvbGFuZy9tYW5pZmVzdF92MaoCGEVzdGFmZXR0ZS5DSS5NYW5pZmVz",
            "dC5WMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.CI.Manifest.V1.EstafetteCustomVersion), global::Estafette.CI.Manifest.V1.EstafetteCustomVersion.Parser, new[]{ "LabelTemplate" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EstafetteCustomVersion : pb::IMessage<EstafetteCustomVersion> {
    private static readonly pb::MessageParser<EstafetteCustomVersion> _parser = new pb::MessageParser<EstafetteCustomVersion>(() => new EstafetteCustomVersion());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EstafetteCustomVersion> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.CI.Manifest.V1.EstafetteCustomVersionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteCustomVersion() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteCustomVersion(EstafetteCustomVersion other) : this() {
      labelTemplate_ = other.labelTemplate_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteCustomVersion Clone() {
      return new EstafetteCustomVersion(this);
    }

    /// <summary>Field number for the "label_template" field.</summary>
    public const int LabelTemplateFieldNumber = 1;
    private string labelTemplate_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LabelTemplate {
      get { return labelTemplate_; }
      set {
        labelTemplate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EstafetteCustomVersion);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EstafetteCustomVersion other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LabelTemplate != other.LabelTemplate) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (LabelTemplate.Length != 0) hash ^= LabelTemplate.GetHashCode();
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
      if (LabelTemplate.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LabelTemplate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (LabelTemplate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LabelTemplate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EstafetteCustomVersion other) {
      if (other == null) {
        return;
      }
      if (other.LabelTemplate.Length != 0) {
        LabelTemplate = other.LabelTemplate;
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
            LabelTemplate = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
