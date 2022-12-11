namespace Mediator
{
    /// <summary>
    /// Colleague
    /// </summary>
    public abstract class TeamMember
    {
        private IChatRoom _chatRoom;
        public string Name { get; set; }
        public TeamMember(string name)
        {
            Name = name;
        }
        internal void SetChatroom(IChatRoom chatRoom)
        {
            _chatRoom = chatRoom;
        }

        public void Send(string message)
        {
            _chatRoom?.Send(Name, message);
        }
        public void SendTo(string to, string message)
        {
            _chatRoom?.Send(Name, to, message);
        }
        public void SendTo<T>(string message) where T : TeamMember
        {
            _chatRoom.Send<T>(Name, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"Message {from} to {Name}: {message}");
            Console.WriteLine();
        }

    }
}