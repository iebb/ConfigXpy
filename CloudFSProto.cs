// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CloudFSProto.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ConfigXpy {

  /// <summary>Holder for reflection information generated from CloudFSProto.proto</summary>
  public static partial class CloudFSProtoReflection {

    #region Descriptor
    /// <summary>File descriptor for CloudFSProto.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CloudFSProtoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJDbG91ZEZTUHJvdG8ucHJvdG8iaAoJQ2xvdWRGaWxlEhAKCGZpbGVuYW1l",
            "GAEgASgJEhAKCGZpbGV0eXBlGAIgASgJEhUKDXJlbGF0aXZlX3BhdGgYAyAB",
            "KAkSDgoGbGVuZ3RoGAYgASgFEhAKCGNvbnRlbnRzGAcgASgMIlQKDENsb3Vk",
            "U3RvcmFnZRIRCglzYXZlX3Nsb3QYASABKAkSGQoFZmlsZXMYBiADKAsyCi5D",
            "bG91ZEZpbGUSFgoObGF1bmNoX29wdGlvbnMYByABKAkiHwoJQ2xvdWRNZXRh",
            "EhIKCnNhdmVfc2xvdHMYASADKAlCDKoCCUNvbmZpZ1hweWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ConfigXpy.CloudFile), global::ConfigXpy.CloudFile.Parser, new[]{ "Filename", "Filetype", "RelativePath", "Length", "Contents" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ConfigXpy.CloudStorage), global::ConfigXpy.CloudStorage.Parser, new[]{ "SaveSlot", "Files", "LaunchOptions" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ConfigXpy.CloudMeta), global::ConfigXpy.CloudMeta.Parser, new[]{ "SaveSlots" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CloudFile : pb::IMessage<CloudFile>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CloudFile> _parser = new pb::MessageParser<CloudFile>(() => new CloudFile());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CloudFile> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ConfigXpy.CloudFSProtoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CloudFile() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CloudFile(CloudFile other) : this() {
      filename_ = other.filename_;
      filetype_ = other.filetype_;
      relativePath_ = other.relativePath_;
      length_ = other.length_;
      contents_ = other.contents_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CloudFile Clone() {
      return new CloudFile(this);
    }

    /// <summary>Field number for the "filename" field.</summary>
    public const int FilenameFieldNumber = 1;
    private string filename_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Filename {
      get { return filename_; }
      set {
        filename_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "filetype" field.</summary>
    public const int FiletypeFieldNumber = 2;
    private string filetype_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Filetype {
      get { return filetype_; }
      set {
        filetype_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "relative_path" field.</summary>
    public const int RelativePathFieldNumber = 3;
    private string relativePath_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RelativePath {
      get { return relativePath_; }
      set {
        relativePath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "length" field.</summary>
    public const int LengthFieldNumber = 6;
    private int length_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Length {
      get { return length_; }
      set {
        length_ = value;
      }
    }

    /// <summary>Field number for the "contents" field.</summary>
    public const int ContentsFieldNumber = 7;
    private pb::ByteString contents_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Contents {
      get { return contents_; }
      set {
        contents_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CloudFile);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CloudFile other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Filename != other.Filename) return false;
      if (Filetype != other.Filetype) return false;
      if (RelativePath != other.RelativePath) return false;
      if (Length != other.Length) return false;
      if (Contents != other.Contents) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Filename.Length != 0) hash ^= Filename.GetHashCode();
      if (Filetype.Length != 0) hash ^= Filetype.GetHashCode();
      if (RelativePath.Length != 0) hash ^= RelativePath.GetHashCode();
      if (Length != 0) hash ^= Length.GetHashCode();
      if (Contents.Length != 0) hash ^= Contents.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Filename.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Filename);
      }
      if (Filetype.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Filetype);
      }
      if (RelativePath.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RelativePath);
      }
      if (Length != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Length);
      }
      if (Contents.Length != 0) {
        output.WriteRawTag(58);
        output.WriteBytes(Contents);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Filename.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Filename);
      }
      if (Filetype.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Filetype);
      }
      if (RelativePath.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RelativePath);
      }
      if (Length != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Length);
      }
      if (Contents.Length != 0) {
        output.WriteRawTag(58);
        output.WriteBytes(Contents);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Filename.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Filename);
      }
      if (Filetype.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Filetype);
      }
      if (RelativePath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RelativePath);
      }
      if (Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Length);
      }
      if (Contents.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Contents);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CloudFile other) {
      if (other == null) {
        return;
      }
      if (other.Filename.Length != 0) {
        Filename = other.Filename;
      }
      if (other.Filetype.Length != 0) {
        Filetype = other.Filetype;
      }
      if (other.RelativePath.Length != 0) {
        RelativePath = other.RelativePath;
      }
      if (other.Length != 0) {
        Length = other.Length;
      }
      if (other.Contents.Length != 0) {
        Contents = other.Contents;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Filename = input.ReadString();
            break;
          }
          case 18: {
            Filetype = input.ReadString();
            break;
          }
          case 26: {
            RelativePath = input.ReadString();
            break;
          }
          case 48: {
            Length = input.ReadInt32();
            break;
          }
          case 58: {
            Contents = input.ReadBytes();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Filename = input.ReadString();
            break;
          }
          case 18: {
            Filetype = input.ReadString();
            break;
          }
          case 26: {
            RelativePath = input.ReadString();
            break;
          }
          case 48: {
            Length = input.ReadInt32();
            break;
          }
          case 58: {
            Contents = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class CloudStorage : pb::IMessage<CloudStorage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CloudStorage> _parser = new pb::MessageParser<CloudStorage>(() => new CloudStorage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CloudStorage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ConfigXpy.CloudFSProtoReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CloudStorage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CloudStorage(CloudStorage other) : this() {
      saveSlot_ = other.saveSlot_;
      files_ = other.files_.Clone();
      launchOptions_ = other.launchOptions_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CloudStorage Clone() {
      return new CloudStorage(this);
    }

    /// <summary>Field number for the "save_slot" field.</summary>
    public const int SaveSlotFieldNumber = 1;
    private string saveSlot_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SaveSlot {
      get { return saveSlot_; }
      set {
        saveSlot_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "files" field.</summary>
    public const int FilesFieldNumber = 6;
    private static readonly pb::FieldCodec<global::ConfigXpy.CloudFile> _repeated_files_codec
        = pb::FieldCodec.ForMessage(50, global::ConfigXpy.CloudFile.Parser);
    private readonly pbc::RepeatedField<global::ConfigXpy.CloudFile> files_ = new pbc::RepeatedField<global::ConfigXpy.CloudFile>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ConfigXpy.CloudFile> Files {
      get { return files_; }
    }

    /// <summary>Field number for the "launch_options" field.</summary>
    public const int LaunchOptionsFieldNumber = 7;
    private string launchOptions_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LaunchOptions {
      get { return launchOptions_; }
      set {
        launchOptions_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CloudStorage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CloudStorage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SaveSlot != other.SaveSlot) return false;
      if(!files_.Equals(other.files_)) return false;
      if (LaunchOptions != other.LaunchOptions) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SaveSlot.Length != 0) hash ^= SaveSlot.GetHashCode();
      hash ^= files_.GetHashCode();
      if (LaunchOptions.Length != 0) hash ^= LaunchOptions.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (SaveSlot.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SaveSlot);
      }
      files_.WriteTo(output, _repeated_files_codec);
      if (LaunchOptions.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(LaunchOptions);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (SaveSlot.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SaveSlot);
      }
      files_.WriteTo(ref output, _repeated_files_codec);
      if (LaunchOptions.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(LaunchOptions);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (SaveSlot.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SaveSlot);
      }
      size += files_.CalculateSize(_repeated_files_codec);
      if (LaunchOptions.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LaunchOptions);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CloudStorage other) {
      if (other == null) {
        return;
      }
      if (other.SaveSlot.Length != 0) {
        SaveSlot = other.SaveSlot;
      }
      files_.Add(other.files_);
      if (other.LaunchOptions.Length != 0) {
        LaunchOptions = other.LaunchOptions;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            SaveSlot = input.ReadString();
            break;
          }
          case 50: {
            files_.AddEntriesFrom(input, _repeated_files_codec);
            break;
          }
          case 58: {
            LaunchOptions = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            SaveSlot = input.ReadString();
            break;
          }
          case 50: {
            files_.AddEntriesFrom(ref input, _repeated_files_codec);
            break;
          }
          case 58: {
            LaunchOptions = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class CloudMeta : pb::IMessage<CloudMeta>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CloudMeta> _parser = new pb::MessageParser<CloudMeta>(() => new CloudMeta());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CloudMeta> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ConfigXpy.CloudFSProtoReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CloudMeta() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CloudMeta(CloudMeta other) : this() {
      saveSlots_ = other.saveSlots_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CloudMeta Clone() {
      return new CloudMeta(this);
    }

    /// <summary>Field number for the "save_slots" field.</summary>
    public const int SaveSlotsFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_saveSlots_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> saveSlots_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> SaveSlots {
      get { return saveSlots_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CloudMeta);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CloudMeta other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!saveSlots_.Equals(other.saveSlots_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= saveSlots_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      saveSlots_.WriteTo(output, _repeated_saveSlots_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      saveSlots_.WriteTo(ref output, _repeated_saveSlots_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += saveSlots_.CalculateSize(_repeated_saveSlots_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CloudMeta other) {
      if (other == null) {
        return;
      }
      saveSlots_.Add(other.saveSlots_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            saveSlots_.AddEntriesFrom(input, _repeated_saveSlots_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            saveSlots_.AddEntriesFrom(ref input, _repeated_saveSlots_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
