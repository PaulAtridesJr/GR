GRPC C++

Docs:

API GRPC C++ - https://grpc.github.io/grpc/cpp/index.html

Proto - https://protobuf.dev/programming-guides/proto3/


Dev env:

Doc - https://github.com/grpc/grpc/blob/master/src/cpp/README.md

Install nasm and add it to PATH - https://www.nasm.us/

> git clone https://github.com/grpc/grpc
> cd grpc
> git submodule update --init

In MSVS open root folder with grpc. CMake auto generation should start. 
If error - some dependencies missing.
If OK - Build -> Build all
If OK - Build -> Install ... become enabled. Run it. GRPC shoul be installed then localy

Can install grpc in system via vcpkg

https://github.com/grpc/grpc/tree/master/src/cpp#install-using-vcpkg-package



Build and run greeter_client

In MSVS open folder \grpcc\greeter_client\
CMake auto generation should start.
If OK - Build -> Build all

Exe will be generated in \grpcc\greeter_client\out\build\x64-Debug\