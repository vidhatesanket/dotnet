


namespace cdac;

public abstract class Shape
{
    public string Color{
        get;set;
    }

    public int width{
        get;set;
    }

    public Shape(string c,int w){
           this.Color=c;
           this.width=w; 
    }

    public abstract void Draw();
    public String toString(){
        return "Color"+this.Color+"Width: "+this.width;
    }
}