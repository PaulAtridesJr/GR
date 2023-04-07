using System.Threading.Tasks;
using Grpc.Net.Client;
using Xfs;

var httpHandler = new HttpClientHandler();
// Return `true` to allow certificates that are untrusted/invalid
httpHandler.ServerCertificateCustomValidationCallback = 
    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

using var channel = GrpcChannel.ForAddress("http://localhost:5214",
    new GrpcChannelOptions { HttpHandler = httpHandler });

//using var channel = GrpcChannel.ForAddress("https://localhost:7061");
var client = new Xfs.XFSEmulatorSPI.XFSEmulatorSPIClient(channel);
var reply = await client.WFSEventAsync(new Xfs.WFSEventRequest() { EventId = 1, ServiceName = "SIU" } );
Console.WriteLine("XFS event sent");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
