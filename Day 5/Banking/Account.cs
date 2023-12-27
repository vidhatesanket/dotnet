

namespace Banking;

public class Account{

 
public event NotificationOperation notification;

    public float balance{
        get;set;
    }

    public void deposit(float amount){
            this.balance+=amount;
            notification("Ayush","How are you");
            Console.WriteLine("Amount is credited successufully and your currenct balance is: "+this.balance);

         
    }

    
    public void withdraw(float amount){
            this.balance-=amount;
            Console.WriteLine("Rs." + amount + " is debited from your account and your currenct balance is: "+this.balance);
    }
    
}