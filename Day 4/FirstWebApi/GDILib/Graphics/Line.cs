using cdac;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;
using printing;
public class Line:Shape,Iprinter
{

    public Point startPoint;
    public Point endPoint;
   Line(Point p1,Point p2,String color,int Width):base(color,Width){
    this.startPoint=p1;
    this.endPoint=p2;
   }

    public override void Draw()
    {
       Console.WriteLine("printing line");
    }

    public void print()
    {
        
    }

    
    
}