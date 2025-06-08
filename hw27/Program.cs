namespace hw27;

public delegate void Handler(MyMessage message);


class Program
{
    static void Main(string[] args)
    {
        MessageManager manager = new MessageManager();
        Phone phone = new Phone();
        Mail mail = new Mail();
        MyMessage msg1 = new MyMessage("sms", "sms.txt");
        MyMessage msg2 = new MyMessage("email", "email.txt");
        
        manager.NewMessage += phone.RecieveSMS;
        manager.NewMessage += mail.RecieveMail;
        
        manager.OnNewMessage(msg1);
        manager.OnNewMessage(msg2);
    }
}