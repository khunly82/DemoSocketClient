using Microsoft.AspNetCore.SignalR.Client;

// création de la connection au hub
HubConnection connection = new HubConnectionBuilder()
    .WithUrl("http://10.10.10.2:39539/ws/message?access_token=Khun")
    .Build();

// handshake
await connection.StartAsync();

// ecouter un evenement 
connection.On<string>("newUser", (user) =>
{
    Console.WriteLine($"{user} vient de se connecter");
});


// permet de gerder la console ouverte
while (true) ;