// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: contracts.v1/tail_log_line.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.CI.Contracts.V1 {

  /// <summary>Holder for reflection information generated from contracts.v1/tail_log_line.proto</summary>
  public static partial class TailLogLineReflection {

    #region Descriptor
    /// <summary>File descriptor for contracts.v1/tail_log_line.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TailLogLineReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBjb250cmFjdHMudjEvdGFpbF9sb2dfbGluZS5wcm90bxIMY29udHJhY3Rz",
            "LnYxGiFjb250cmFjdHMudjEvYnVpbGRfbG9nX2xpbmUucHJvdG8aLmNvbnRy",
            "YWN0cy52MS9idWlsZF9sb2dfc3RlcF9kb2NrZXJfaW1hZ2UucHJvdG8aHmdv",
            "b2dsZS9wcm90b2J1Zi9kdXJhdGlvbi5wcm90byLmAQoLVGFpbExvZ0xpbmUS",
            "DAoEc3RlcBgBIAEoCRIsCghsb2dfbGluZRgCIAEoCzIaLmNvbnRyYWN0cy52",
            "MS5CdWlsZExvZ0xpbmUSNAoFaW1hZ2UYAyABKAsyJS5jb250cmFjdHMudjEu",
            "QnVpbGRMb2dTdGVwRG9ja2VySW1hZ2USKwoIZHVyYXRpb24YBCABKAsyGS5n",
            "b29nbGUucHJvdG9idWYuRHVyYXRpb24SEQoJZXhpdF9jb2RlGAUgASgDEg4K",
            "BnN0YXR1cxgGIAEoCRIVCg1hdXRvX2luamVjdGVkGAcgASgIQnsKHGlvLmVz",
            "dGFmZXR0ZS5jaS5jb250cmFjdHMudjFaP2dpdGh1Yi5jb20vZXN0YWZldHRl",
            "L2VzdGFmZXR0ZS1jaS1jb250cmFjdHMtZ29sYW5nL2NvbnRyYWN0c192MaoC",
            "GUVzdGFmZXR0ZS5DSS5Db250cmFjdHMuVjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Estafette.CI.Contracts.V1.BuildLogLineReflection.Descriptor, global::Estafette.CI.Contracts.V1.BuildLogStepDockerImageReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.CI.Contracts.V1.TailLogLine), global::Estafette.CI.Contracts.V1.TailLogLine.Parser, new[]{ "Step", "LogLine", "Image", "Duration", "ExitCode", "Status", "AutoInjected" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TailLogLine : pb::IMessage<TailLogLine> {
    private static readonly pb::MessageParser<TailLogLine> _parser = new pb::MessageParser<TailLogLine>(() => new TailLogLine());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TailLogLine> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.CI.Contracts.V1.TailLogLineReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TailLogLine() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TailLogLine(TailLogLine other) : this() {
      step_ = other.step_;
      logLine_ = other.logLine_ != null ? other.logLine_.Clone() : null;
      image_ = other.image_ != null ? other.image_.Clone() : null;
      duration_ = other.duration_ != null ? other.duration_.Clone() : null;
      exitCode_ = other.exitCode_;
      status_ = other.status_;
      autoInjected_ = other.autoInjected_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TailLogLine Clone() {
      return new TailLogLine(this);
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

    /// <summary>Field number for the "log_line" field.</summary>
    public const int LogLineFieldNumber = 2;
    private global::Estafette.CI.Contracts.V1.BuildLogLine logLine_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Estafette.CI.Contracts.V1.BuildLogLine LogLine {
      get { return logLine_; }
      set {
        logLine_ = value;
      }
    }

    /// <summary>Field number for the "image" field.</summary>
    public const int ImageFieldNumber = 3;
    private global::Estafette.CI.Contracts.V1.BuildLogStepDockerImage image_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Estafette.CI.Contracts.V1.BuildLogStepDockerImage Image {
      get { return image_; }
      set {
        image_ = value;
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

    /// <summary>Field number for the "exit_code" field.</summary>
    public const int ExitCodeFieldNumber = 5;
    private long exitCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExitCode {
      get { return exitCode_; }
      set {
        exitCode_ = value;
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

    /// <summary>Field number for the "auto_injected" field.</summary>
    public const int AutoInjectedFieldNumber = 7;
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
      return Equals(other as TailLogLine);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TailLogLine other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Step != other.Step) return false;
      if (!object.Equals(LogLine, other.LogLine)) return false;
      if (!object.Equals(Image, other.Image)) return false;
      if (!object.Equals(Duration, other.Duration)) return false;
      if (ExitCode != other.ExitCode) return false;
      if (Status != other.Status) return false;
      if (AutoInjected != other.AutoInjected) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Step.Length != 0) hash ^= Step.GetHashCode();
      if (logLine_ != null) hash ^= LogLine.GetHashCode();
      if (image_ != null) hash ^= Image.GetHashCode();
      if (duration_ != null) hash ^= Duration.GetHashCode();
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
      if (logLine_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LogLine);
      }
      if (image_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Image);
      }
      if (duration_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Duration);
      }
      if (ExitCode != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(ExitCode);
      }
      if (Status.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Status);
      }
      if (AutoInjected != false) {
        output.WriteRawTag(56);
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
      if (logLine_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LogLine);
      }
      if (image_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Image);
      }
      if (duration_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Duration);
      }
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
    public void MergeFrom(TailLogLine other) {
      if (other == null) {
        return;
      }
      if (other.Step.Length != 0) {
        Step = other.Step;
      }
      if (other.logLine_ != null) {
        if (logLine_ == null) {
          logLine_ = new global::Estafette.CI.Contracts.V1.BuildLogLine();
        }
        LogLine.MergeFrom(other.LogLine);
      }
      if (other.image_ != null) {
        if (image_ == null) {
          image_ = new global::Estafette.CI.Contracts.V1.BuildLogStepDockerImage();
        }
        Image.MergeFrom(other.Image);
      }
      if (other.duration_ != null) {
        if (duration_ == null) {
          duration_ = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        Duration.MergeFrom(other.Duration);
      }
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
            if (logLine_ == null) {
              logLine_ = new global::Estafette.CI.Contracts.V1.BuildLogLine();
            }
            input.ReadMessage(logLine_);
            break;
          }
          case 26: {
            if (image_ == null) {
              image_ = new global::Estafette.CI.Contracts.V1.BuildLogStepDockerImage();
            }
            input.ReadMessage(image_);
            break;
          }
          case 34: {
            if (duration_ == null) {
              duration_ = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(duration_);
            break;
          }
          case 40: {
            ExitCode = input.ReadInt64();
            break;
          }
          case 50: {
            Status = input.ReadString();
            break;
          }
          case 56: {
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
