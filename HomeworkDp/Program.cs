namespace Proxy;

interface Image
{
    void display();
}


public class RealImage : Image // implement Image
{

    private string fileName;

    public RealImage(string fileName)
    {
        this.fileName = fileName;
        loadFromDisk(fileName);
    }


    public void display()
    {
        Console.WriteLine("Displaying " + fileName); // Override
    }

    private void loadFromDisk(string fileName)
    {
        Console.WriteLine("Loading " + fileName);
    }
}

public class ProxyImage : Image{

   private RealImage realImage;
   private string fileName;

   public ProxyImage(string fileName){
      this.fileName = fileName;
   }

   
   public void display() {
      if(realImage == null){
         realImage = new RealImage(fileName); // Override
        }
      realImage.display();
   }
}

class Program
{

    public static void Main()
    {
        Image image = new ProxyImage("test_10mb.jpg");

        //image will be loaded from disk
        image.display();
        Console.WriteLine("");

        //image will not be loaded from disk
        image.display();
    }
}