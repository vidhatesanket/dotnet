namespace HR;

public sealed class Person{

    public string Firstname{get;set;}
    public string LastName{get;set;}
    public string [] titles;
    public static Person _ref=null;

    public Person(){

        // this.Firstname="Sanket";
        // this.LastName="Vidhate";

        titles=new string[5];

        this.titles[0]="somesh";
        this.titles[1]="kudal";
        this.titles[2]="how";
        this.titles[3]="are";
        this.titles[4]="you?";

    }

    public string this[int index]{
        get{return this.titles[index];}
        set{this.titles[index]=value;}
    }

    // public static Person createInstance(){

    //     if(_ref==null){
    //         _ref=new Person();
    //         Console.WriteLine("Object is created");
            
    //     }
    //     return _ref;
    // }

    // public static void display(int b,params object[] arr){
    //     Console.WriteLine("b: "+ b);
    //     foreach (var item in arr){
    //         Console.WriteLine(item);
    //     }
    // }

//   public static void show(ref int a,ref int b){
   
//     a=a+b;   
//     b=a-b;   
//     a=a-b;   
   
//   }

//   public static void calculate(int r,out double area,out double circumferance,out string temp){
//     float pi=3.14f;

//     area=pi*r*r;
//     circumferance=2*pi*r;
//     temp="Somesh";

//   }

//   public void Dispose(){

//     Console.WriteLine("Dispose is invoke");
//     // GC.SuppressFinalize(this);
//   }

//   ~Person(){

//     Console.WriteLine("Destructor is called...");
//   }


} 