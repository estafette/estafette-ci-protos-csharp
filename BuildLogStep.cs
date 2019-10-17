// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: contracts.v1/build_log_step.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.CI.Contracts.V1 {

  /// <summary>Holder for reflection information generated from contracts.v1/build_log_step.proto</summary>
  public static partial class BuildLogStepReflection {

    #region Descriptor
    /// <summary>File descriptor for contracts.v1/build_log_step.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BuildLogStepReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFjb250cmFjdHMudjEvYnVpbGRfbG9nX3N0ZXAucHJvdG8SDGNvbnRyYWN0",
            "cy52MRouY29udHJhY3RzLnYxL2J1aWxkX2xvZ19zdGVwX2RvY2tlcl9pbWFn",
            "ZS5wcm90bxohY29udHJhY3RzLnYxL2J1aWxkX2xvZ19saW5lLnByb3RvGh5n",
            "b29nbGUvcHJvdG9idWYvZHVyYXRpb24ucHJvdG8i+wEKDEJ1aWxkTG9nU3Rl",
            "cBIMCgRzdGVwGAEgASgJEjQKBWltYWdlGAIgASgLMiUuY29udHJhY3RzLnYx",
            "LkJ1aWxkTG9nU3RlcERvY2tlckltYWdlEhEKCXJ1bl9pbmRleBgDIAEoAxIr",
            "CghkdXJhdGlvbhgEIAEoCzIZLmdvb2dsZS5wcm90b2J1Zi5EdXJhdGlvbhIt",
            "Cglsb2dfbGluZXMYBSADKAsyGi5jb250cmFjdHMudjEuQnVpbGRMb2dMaW5l",
            "EhEKCWV4aXRfY29kZRgGIAEoAxIOCgZzdGF0dXMYByABKAkSFQoNYXV0b19p",
            "bmplY3RlZBgIIAEoCEJdWj9naXRodWIuY29tL2VzdGFmZXR0ZS9lc3RhZmV0",
            "dGUtY2ktY29udHJhY3RzLWdvbGFuZy9jb250cmFjdHNfdjGqAhlFc3RhZmV0",
            "dGUuQ0kuQ29udHJhY3RzLlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Estafette.CI.Contracts.V1.BuildLogStepDockerImageReflection.Descriptor, global::Estafette.CI.Contracts.V1.BuildLogLineReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.CI.Contracts.V1.BuildLogStep), global::Estafette.CI.Contracts.V1.BuildLogStep.Parser, new[]{ "Step", "Image", "RunIndex", "Duration", "LogLines", "ExitCode", "Status", "AutoInjected" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BuildLogStep : pb::IMessage<BuildLogStep> {
    private static readonly pb::MessageParser<BuildLogStep> _parser = new pb::MessageParser<BuildLogStep>(() => new BuildLogStep());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BuildLogStep> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.CI.Contracts.V1.BuildLogStepReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildLogStep() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildLogStep(BuildLogStep other) : this() {
      step_ = other.step_;
      image_ = other.image_ != null ? other.image_.Clone() : null;
      runIndex_ = other.runIndex_;
      duration_ = other.duration_ != null ? other.duration_.Clone() : null;
      logLines_ = other.logLines_.Clone();
      exitCode_ = other.exitCode_;
      status_ = other.status_;
      autoInjected_ = other.autoInjected_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildLogStep Clone() {
      return new BuildLogStep(this);
    }

    /// <summary>Field number for the "step" field.</summary>
    public const int StepFieldNumber = 1;
    private string step_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Step {
      get { return step_; }
      set {
        step_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "image" field.</summary>
    public const int ImageFieldNumber = 2;
    private global::Estafette.CI.Contracts.V1.BuildLogStepDockerImage image_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Estafette.CI.Contracts.V1.BuildLogStepDockerImage Image {
      get { return image_; }
      set {
        image_ = value;
      }
    }

    /// <summary>Field number for the "run_index" field.</summary>
    public const int RunIndexFieldNumber = 3;
    private long runIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RunIndex {
      get { return runIndex_; }
      set {
        runIndex_ = value;
      }
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Duration duration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration Duration {
      get { return duration_; }
      set {
        duration_ = value;
      }
    }

    /// <summary>Field number for the "log_lines" field.</summary>
    public const int LogLinesFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Estafette.CI.Contracts.V1.BuildLogLine> _repeated_logLines_codec
        = pb::FieldCodec.ForMessage(42, global::Estafette.CI.Contracts.V1.BuildLogLine.Parser);
    private readonly pbc::RepeatedField<global::Estafette.CI.Contracts.V1.BuildLogLine> logLines_ = new pbc::RepeatedField<global::Estafette.CI.Contracts.V1.BuildLogLine>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Estafette.CI.Contracts.V1.BuildLogLine> LogLines {
      get { return logLines_; }
    }

    /// <summary>Field number for the "exit_code" field.</summary>
    public const int ExitCodeFieldNumber = 6;
    private long exitCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExitCode {
      get { return exitCode_; }
      set {
        exitCode_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 7;
    private string status_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Status {
      get { return status_; }
      set {
        status_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "auto_injected" field.</summary>
    public const int AutoInjectedFieldNumber = 8;
    private bool autoInjected_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool AutoInjected {
      get { return autoInjected_; }
      set {
        autoInjected_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BuildLogStep);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BuildLogStep other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Step != other.Step) return false;
      if (!object.Equals(Image, other.Image)) return false;
      if (RunIndex != other.RunIndex) return false;
      if (!object.Equals(Duration, other.Duration)) return false;
      if(!logLines_.Equals(other.logLines_)) return false;
      if (ExitCode != other.ExitCode) return false;
      if (Status != other.Status) return false;
      if (AutoInjected != other.AutoInjected) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Step.Length != 0) hash ^= Step.GetHashCode();
      if (image_ != null) hash ^= Image.GetHashCode();
      if (RunIndex != 0L) hash ^= RunIndex.GetHashCode();
      if (duration_ != null) hash ^= Duration.GetHashCode();
      hash ^= logLines_.GetHashCode();
      if (ExitCode != 0L) hash ^= ExitCode.GetHashCode();
      if (Status.Length != 0) hash ^= Status.GetHashCode();
      if (AutoInjected != false) hash ^= AutoInjected.GetHashCode();
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
      if (Step.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Step);
      }
      if (image_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Image);
      }
      if (RunIndex != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(RunIndex);
      }
      if (duration_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Duration);
      }
      logLines_.WriteTo(output, _repeated_logLines_codec);
      if (ExitCode != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(ExitCode);
      }
      if (Status.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Status);
      }
      if (AutoInjected != false) {
        output.WriteRawTag(64);
        output.WriteBool(AutoInjected);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Step.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Step);
      }
      if (image_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Image);
      }
      if (RunIndex != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RunIndex);
      }
      if (duration_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Duration);
      }
      size += logLines_.CalculateSize(_repeated_logLines_codec);
      if (ExitCode != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExitCode);
      }
      if (Status.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Status);
      }
      if (AutoInjected != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BuildLogStep other) {
      if (other == null) {
        return;
      }
      if (other.Step.Length != 0) {
        Step = other.Step;
      }
      if (other.image_ != null) {
        if (image_ == null) {
          image_ = new global::Estafette.CI.Contracts.V1.BuildLogStepDockerImage();
        }
        Image.MergeFrom(other.Image);
      }
      if (other.RunIndex != 0L) {
        RunIndex = other.RunIndex;
      }
      if (other.duration_ != null) {
        if (duration_ == null) {
          duration_ = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        Duration.MergeFrom(other.Duration);
      }
      logLines_.Add(other.logLines_);
      if (other.ExitCode != 0L) {
        ExitCode = other.ExitCode;
      }
      if (other.Status.Length != 0) {
        Status = other.Status;
      }
      if (other.AutoInjected != false) {
        AutoInjected = other.AutoInjected;
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
            Step = input.ReadString();
            break;
          }
          case 18: {
            if (image_ == null) {
              image_ = new global::Estafette.CI.Contracts.V1.BuildLogStepDockerImage();
            }
            input.ReadMessage(image_);
            break;
          }
          case 24: {
            RunIndex = input.ReadInt64();
            break;
          }
          case 34: {
            if (duration_ == null) {
              duration_ = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(duration_);
            break;
          }
          case 42: {
            logLines_.AddEntriesFrom(input, _repeated_logLines_codec);
            break;
          }
          case 48: {
            ExitCode = input.ReadInt64();
            break;
          }
          case 58: {
            Status = input.ReadString();
            break;
          }
          case 64: {
            AutoInjected = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
