using System.Threading.Tasks;
using Grpc.Net.Client;
using Xfs;
using Grpc.Core;

var httpHandler = new HttpClientHandler();
// Return `true` to allow certificates that are untrusted/invalid
httpHandler.ServerCertificateCustomValidationCallback = 
    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

using var channel = GrpcChannel.ForAddress("http://localhost:5214",
    new GrpcChannelOptions { HttpHandler = httpHandler });

//using var channel = GrpcChannel.ForAddress("https://localhost:7061");
var client = new Xfs.XFSEmulatorSPI.XFSEmulatorSPIClient(channel);
try
{
    var reply = await client.WFSEventAsync(new Xfs.WFSEventRequest() { EventId = 1, ServiceName = "SIU" } );
    Console.WriteLine("XFS event sent");
}
catch (RpcException ex) 
{
    Console.WriteLine($"Failed to send XFS event - {ex}");
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
