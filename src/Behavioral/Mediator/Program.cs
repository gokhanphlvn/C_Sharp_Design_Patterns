// See https://aka.ms/new-console-template for more information
using Mediator;

Console.Title = "Mediator Pattern!";

TeamChatRoom teamChatRoom = new();
AccountManager gokhan = new AccountManager("Gökhan"),
                aysun = new AccountManager("Aysun");
Lawyer elanur = new Lawyer("Elanur"),
       batuhan = new Lawyer("Batuhan");
teamChatRoom.Register(gokhan);
teamChatRoom.Register(elanur);
teamChatRoom.Register(batuhan);
teamChatRoom.Register(aysun);

gokhan.Send("Hi everyone, can some have a look at file ABC123? I need a compliance check.");
batuhan.Send("On it!");
batuhan.SendTo(elanur.Name, "Hi bro!");
aysun.SendTo<Lawyer>("Hi Lawyers");
Console.ReadKey();


