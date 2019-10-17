// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: manifest.v1/estafette_trigger_build_action.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.CI.Manifest.V1 {

  /// <summary>Holder for reflection information generated from manifest.v1/estafette_trigger_build_action.proto</summary>
  public static partial class EstafetteTriggerBuildActionReflection {

    #region Descriptor
    /// <summary>File descriptor for manifest.v1/estafette_trigger_build_action.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EstafetteTriggerBuildActionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBtYW5pZmVzdC52MS9lc3RhZmV0dGVfdHJpZ2dlcl9idWlsZF9hY3Rpb24u",
            "cHJvdG8SC21hbmlmZXN0LnYxIi0KG0VzdGFmZXR0ZVRyaWdnZXJCdWlsZEFj",
            "dGlvbhIOCgZicmFuY2gYASABKAlCW1o+Z2l0aHViLmNvbS9lc3RhZmV0dGUv",
            "ZXN0YWZldHRlLWNpLWNvbnRyYWN0cy1nb2xhbmcvbWFuaWZlc3RfdjGqAhhF",
            "c3RhZmV0dGUuQ0kuTWFuaWZlc3QuVjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.CI.Manifest.V1.EstafetteTriggerBuildAction), global::Estafette.CI.Manifest.V1.EstafetteTriggerBuildAction.Parser, new[]{ "Branch" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EstafetteTriggerBuildAction : pb::IMessage<EstafetteTriggerBuildAction> {
    private static readonly pb::MessageParser<EstafetteTriggerBuildAction> _parser = new pb::MessageParser<EstafetteTriggerBuildAction>(() => new EstafetteTriggerBuildAction());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EstafetteTriggerBuildAction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.CI.Manifest.V1.EstafetteTriggerBuildActionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteTriggerBuildAction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteTriggerBuildAction(EstafetteTriggerBuildAction other) : this() {
      branch_ = other.branch_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteTriggerBuildAction Clone() {
      return new EstafetteTriggerBuildAction(this);
    }

    /// <summary>Field number for the "branch" field.</summary>
    public const int BranchFieldNumber = 1;
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
      return Equals(other as EstafetteTriggerBuildAction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EstafetteTriggerBuildAction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Branch != other.Branch) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (Branch.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Branch);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Branch.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Branch);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EstafetteTriggerBuildAction other) {
      if (other == null) {
        return;
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
