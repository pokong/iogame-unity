// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LoginVerify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from LoginVerify.proto</summary>
public static partial class LoginVerifyReflection {

  #region Descriptor
  /// <summary>File descriptor for LoginVerify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static LoginVerifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChFMb2dpblZlcmlmeS5wcm90byJACg5SZXFMb2dpblZlcmlmeRILCgNhZ2UY",
          "ASABKAUSCwoDand0GAIgASgJEhQKDGxvZ2luQml6Q29kZRgDIAEoBSJVCgtS",
          "ZXNVc2VySW5mbxIKCgJpZBgBIAEoAxIMCgRuYW1lGAIgASgJEg8KB3RlbXBJ",
          "bnQYAyABKAUSDAoEdGltZRgEIAEoAxINCgV0aW1lMhgFIAEoA2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ReqLoginVerify), global::ReqLoginVerify.Parser, new[]{ "Age", "Jwt", "LoginBizCode" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ResUserInfo), global::ResUserInfo.Parser, new[]{ "Id", "Name", "TempInt", "Time", "Time2" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class ReqLoginVerify : pb::IMessage<ReqLoginVerify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ReqLoginVerify> _parser = new pb::MessageParser<ReqLoginVerify>(() => new ReqLoginVerify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ReqLoginVerify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::LoginVerifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReqLoginVerify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReqLoginVerify(ReqLoginVerify other) : this() {
    age_ = other.age_;
    jwt_ = other.jwt_;
    loginBizCode_ = other.loginBizCode_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReqLoginVerify Clone() {
    return new ReqLoginVerify(this);
  }

  /// <summary>Field number for the "age" field.</summary>
  public const int AgeFieldNumber = 1;
  private int age_;
  /// <summary>
  ///* age 测试用的 
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Age {
    get { return age_; }
    set {
      age_ = value;
    }
  }

  /// <summary>Field number for the "jwt" field.</summary>
  public const int JwtFieldNumber = 2;
  private string jwt_ = "";
  /// <summary>
  ///* jwt 
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Jwt {
    get { return jwt_; }
    set {
      jwt_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "loginBizCode" field.</summary>
  public const int LoginBizCodeFieldNumber = 3;
  private int loginBizCode_;
  /// <summary>
  ///* 登录业务码 
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int LoginBizCode {
    get { return loginBizCode_; }
    set {
      loginBizCode_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ReqLoginVerify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ReqLoginVerify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Age != other.Age) return false;
    if (Jwt != other.Jwt) return false;
    if (LoginBizCode != other.LoginBizCode) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Age != 0) hash ^= Age.GetHashCode();
    if (Jwt.Length != 0) hash ^= Jwt.GetHashCode();
    if (LoginBizCode != 0) hash ^= LoginBizCode.GetHashCode();
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
    if (Age != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Age);
    }
    if (Jwt.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Jwt);
    }
    if (LoginBizCode != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(LoginBizCode);
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
    if (Age != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Age);
    }
    if (Jwt.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Jwt);
    }
    if (LoginBizCode != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(LoginBizCode);
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
    if (Age != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Age);
    }
    if (Jwt.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Jwt);
    }
    if (LoginBizCode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(LoginBizCode);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ReqLoginVerify other) {
    if (other == null) {
      return;
    }
    if (other.Age != 0) {
      Age = other.Age;
    }
    if (other.Jwt.Length != 0) {
      Jwt = other.Jwt;
    }
    if (other.LoginBizCode != 0) {
      LoginBizCode = other.LoginBizCode;
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
        case 8: {
          Age = input.ReadInt32();
          break;
        }
        case 18: {
          Jwt = input.ReadString();
          break;
        }
        case 24: {
          LoginBizCode = input.ReadInt32();
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
        case 8: {
          Age = input.ReadInt32();
          break;
        }
        case 18: {
          Jwt = input.ReadString();
          break;
        }
        case 24: {
          LoginBizCode = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class ResUserInfo : pb::IMessage<ResUserInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ResUserInfo> _parser = new pb::MessageParser<ResUserInfo>(() => new ResUserInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ResUserInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::LoginVerifyReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ResUserInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ResUserInfo(ResUserInfo other) : this() {
    id_ = other.id_;
    name_ = other.name_;
    tempInt_ = other.tempInt_;
    time_ = other.time_;
    time2_ = other.time2_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ResUserInfo Clone() {
    return new ResUserInfo(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private long id_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  /// <summary>Field number for the "name" field.</summary>
  public const int NameFieldNumber = 2;
  private string name_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Name {
    get { return name_; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "tempInt" field.</summary>
  public const int TempIntFieldNumber = 3;
  private int tempInt_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int TempInt {
    get { return tempInt_; }
    set {
      tempInt_ = value;
    }
  }

  /// <summary>Field number for the "time" field.</summary>
  public const int TimeFieldNumber = 4;
  private long time_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long Time {
    get { return time_; }
    set {
      time_ = value;
    }
  }

  /// <summary>Field number for the "time2" field.</summary>
  public const int Time2FieldNumber = 5;
  private long time2_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long Time2 {
    get { return time2_; }
    set {
      time2_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ResUserInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ResUserInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    if (Name != other.Name) return false;
    if (TempInt != other.TempInt) return false;
    if (Time != other.Time) return false;
    if (Time2 != other.Time2) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Id != 0L) hash ^= Id.GetHashCode();
    if (Name.Length != 0) hash ^= Name.GetHashCode();
    if (TempInt != 0) hash ^= TempInt.GetHashCode();
    if (Time != 0L) hash ^= Time.GetHashCode();
    if (Time2 != 0L) hash ^= Time2.GetHashCode();
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
    if (Id != 0L) {
      output.WriteRawTag(8);
      output.WriteInt64(Id);
    }
    if (Name.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Name);
    }
    if (TempInt != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(TempInt);
    }
    if (Time != 0L) {
      output.WriteRawTag(32);
      output.WriteInt64(Time);
    }
    if (Time2 != 0L) {
      output.WriteRawTag(40);
      output.WriteInt64(Time2);
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
    if (Id != 0L) {
      output.WriteRawTag(8);
      output.WriteInt64(Id);
    }
    if (Name.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Name);
    }
    if (TempInt != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(TempInt);
    }
    if (Time != 0L) {
      output.WriteRawTag(32);
      output.WriteInt64(Time);
    }
    if (Time2 != 0L) {
      output.WriteRawTag(40);
      output.WriteInt64(Time2);
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
    if (Id != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
    }
    if (Name.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
    }
    if (TempInt != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(TempInt);
    }
    if (Time != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time);
    }
    if (Time2 != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time2);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ResUserInfo other) {
    if (other == null) {
      return;
    }
    if (other.Id != 0L) {
      Id = other.Id;
    }
    if (other.Name.Length != 0) {
      Name = other.Name;
    }
    if (other.TempInt != 0) {
      TempInt = other.TempInt;
    }
    if (other.Time != 0L) {
      Time = other.Time;
    }
    if (other.Time2 != 0L) {
      Time2 = other.Time2;
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
        case 8: {
          Id = input.ReadInt64();
          break;
        }
        case 18: {
          Name = input.ReadString();
          break;
        }
        case 24: {
          TempInt = input.ReadInt32();
          break;
        }
        case 32: {
          Time = input.ReadInt64();
          break;
        }
        case 40: {
          Time2 = input.ReadInt64();
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
        case 8: {
          Id = input.ReadInt64();
          break;
        }
        case 18: {
          Name = input.ReadString();
          break;
        }
        case 24: {
          TempInt = input.ReadInt32();
          break;
        }
        case 32: {
          Time = input.ReadInt64();
          break;
        }
        case 40: {
          Time2 = input.ReadInt64();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
