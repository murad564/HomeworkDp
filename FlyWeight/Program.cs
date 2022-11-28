interface Shape
{
    void draw();
}

public class Circle : Shape // implement
{
    private string color;
    private int x;
    private int y;
    private int radius;

    public Circle(String color)
    {
        this.color = color;
    }

    public void setX(int x)
    {
        this.x = x;
    }

    public void setY(int y)
    {
        this.y = y;
    }

    public void setRadius(int radius)
    {
        this.radius = radius;
    }

    
   public void draw() // override
    {
        Console.WriteLine("Circle: Draw() [Color : " + color + ", x : " + x + ", y :" + y + ", radius :" + radius);
    }
}

//public class ShapeFactory
//{

 
//    private static HashMap circleMap = new HashMap();

//    public static Shape getCircle(string color)
//    {
//        Circle circle = (Circle)circleMap.get(color);

//        if (circle == null)
//        {
//            circle = new Circle(color);
//            circleMap.put(color, circle);
//            Console.WriteLine("Creating circle of color : " + color);
//        }
//        return circle;
//    }
//}


//class Program
//{
//    private static string colors[] = { "Red", "Green", "Blue", "White", "Black" };
//   public static void main(String[] args)
//    {

//        for (int i = 0; i < 20; ++i)
//        {
//            Circle circle = (Circle)ShapeFactory.getCircle(getRandomColor());
//            circle.setX(getRandomX());
//            circle.setY(getRandomY());
//            circle.setRadius(100);
//            circle.draw();
//        }
//    }
//    private static string getRandomColor()
//    {
//        return colors[(int)(Math.random() * colors.length)];
//    }
//    private static int getRandomX()
//    {
//        return (int)(Math.random() * 100);
//    }
//    private static int getRandomY()
//    {
//        return (int)(Math.random() * 100);
//    }
//}



//class Program { 
//    public static void Main()
//    {
//        Shape shape = new Circle();
//        Console.WriteLine("");
//    }
//}