// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: manifest.v1/estafette_cron_trigger.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Manifest.V1 {

  /// <summary>Holder for reflection information generated from manifest.v1/estafette_cron_trigger.proto</summary>
  public static partial class EstafetteCronTriggerReflection {

    #region Descriptor
    /// <summary>File descriptor for manifest.v1/estafette_cron_trigger.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EstafetteCronTriggerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihtYW5pZmVzdC52MS9lc3RhZmV0dGVfY3Jvbl90cmlnZ2VyLnByb3RvEgtt",
            "YW5pZmVzdC52MSIoChRFc3RhZmV0dGVDcm9uVHJpZ2dlchIQCghzY2hlZHVs",
            "ZRgBIAEoCUJAWj5naXRodWIuY29tL2VzdGFmZXR0ZS9lc3RhZmV0dGUtY2kt",
            "Y29udHJhY3RzLWdvbGFuZy9tYW5pZmVzdF92MWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Manifest.V1.EstafetteCronTrigger), global::Manifest.V1.EstafetteCronTrigger.Parser, new[]{ "Schedule" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EstafetteCronTrigger : pb::IMessage<EstafetteCronTrigger> {
    private static readonly pb::MessageParser<EstafetteCronTrigger> _parser = new pb::MessageParser<EstafetteCronTrigger>(() => new EstafetteCronTrigger());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EstafetteCronTrigger> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Manifest.V1.EstafetteCronTriggerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteCronTrigger() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteCronTrigger(EstafetteCronTrigger other) : this() {
      schedule_ = other.schedule_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteCronTrigger Clone() {
      return new EstafetteCronTrigger(this);
    }

    /// <summary>Field number for the "schedule" field.</summary>
    public const int ScheduleFieldNumber = 1;
    private string schedule_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Schedule {
      get { return schedule_; }
      set {
        schedule_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EstafetteCronTrigger);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EstafetteCronTrigger other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Schedule != other.Schedule) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Schedule.Length != 0) hash ^= Schedule.GetHashCode();
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
      if (Schedule.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Schedule);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Schedule.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Schedule);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EstafetteCronTrigger other) {
      if (other == null) {
        return;
      }
      if (other.Schedule.Length != 0) {
        Schedule = other.Schedule;
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
            Schedule = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code