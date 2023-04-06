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


Build and run greeter_client

In MSVS:
open folder \grpcc\greeter_client\
CMake auto generation should start.
If OK - Build -> Build all

Exe will be generated in \grpcc\greeter_client\out\build\x64-Debug\

-------------------------------------------------------------------------

VSCode:

GRPC C++

clean dev PC. no packages installed

git clone --recurse-submodules --depth 1 --shallow-submodules https://github.com/grpc/grpc
cd grpc
git submodule update --init

mkdir .build
cd .build

--> x64
cmake .. -G "Visual Studio 17 2022" -DgRPC_INSTALL=ON -DCMAKE_BUILD_TYPE=Release -DABSL_ENABLE_INSTALL=OFF  -A x64 -B "build64"
cmake --build build64 --config Release --target install
-->  creates c:\Program Files\grpc\     GRPC c++ is now installed in system

\XFS_grpc\cplus> mkdir .build
cd .build
cmake -G "Visual Studio 17 2022" -A x64 -S ..\greeter_client  -B "build64"
cmake --build build64 --config Release

--> creates exe in \XFS_grpc\CPlus\.build\build64\Release