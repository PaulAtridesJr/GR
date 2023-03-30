using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterClient;


var httpHandler = new HttpClientHandler();
// Return `true` to allow certificates that are untrusted/invalid
httpHandler.ServerCertificateCustomValidationCallback = 
    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

using var channel = GrpcChannel.ForAddress("http://localhost:5214",
    new GrpcChannelOptions { HttpHandler = httpHandler });

//using var channel = GrpcChannel.ForAddress("https://localhost:7061");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "GreeterClient" });
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();