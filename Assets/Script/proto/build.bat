#MyExternalMessage.proto生成的源文件中，使用ReadInt32而不是DEMO工程中的ReadSInt32，所以只是反编译了PB源文件，但生成的代码是不正确的。

@echo off
chcp 65001 > NUL

echo "compile proto to c#"
protoc *.proto --csharp_out=../entity/

pause

