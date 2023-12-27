using Banking;
using System.Threading;


Account acc4=new Account();

acc4.notification+=NotificationService.sendSms;
acc4.notification+=NotificationService.sendEmail;
acc4.balance=2300;
acc4.deposit(200);



Account acc=new Account();
acc.balance=2300;
acc.deposit(200);


// NotificationService obj2=new NotificationService();
// NotificationOperation proxy=new NotificationOperation(obj2.sendSms);
// proxy("Somesh","Kudal");


//single cast delegate
// NotificationOperation proxySmsSender=new NotificationOperation(NotificationService.sendSms);


// NotificationOperation proxyEmailSender = new NotificationOperation(NotificationService.sendEmail);  

// NotificationOperation proxyWhatsUpSender=new NotificationOperation(NotificationService.sendWhatsAppMsg);

// NotificationOperation proxy=null;



// //chaining
// proxy+=proxySmsSender;
// proxy+=proxyEmailSender;
// proxy+=proxyWhatsUpSender;

// proxy("somesh","amount deducted");




// proxy-=proxyEmailSender;

// proxy("sanket","amount deducted");

// IAsyncResult iResult=proxy.BeginInvoke("sarang","Thank you",null,null);System.PlatformNotSupportedException: Operation is not supported on this platform.