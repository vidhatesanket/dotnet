namespace Banking;

public static class NotificationService{

    public static void sendSms(string to,string content){
        Console.WriteLine("SMS Send successfully " + to +" "+content);
    }

    public static void sendEmail(string to,string content){
        Console.WriteLine("Send Mail Successfully "+ to +" "+content);
    }

    public static void sendWhatsAppMsg(string to,string content){
        Console.WriteLine("Send Whatsapp Message "+ to +"   "+content);

    }

}