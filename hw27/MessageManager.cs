namespace hw27;

public class MessageManager
{
    public event Handler NewMessage;
    
    public void OnNewMessage(MyMessage message) => NewMessage?.Invoke(message);
}

public class MyMessage
{
    public string MessageType { get; set; }
    public string Message { get; set; }

    public MyMessage(string type, string message)
    {
        MessageType = type;
        Message = message;
    }
}

public class Phone
{
    public void RecieveSMS(MyMessage message)
    {
        if (message.MessageType == "sms")
        {
            Console.WriteLine($"Recieved sms {message.Message}");
        }
    }
}

public class Mail
{
    public void RecieveMail(MyMessage message)
    {
        if (message.MessageType == "email")
        {
            Console.WriteLine($"Recieved email {message.Message}");
        }
    }
}