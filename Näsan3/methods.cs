
public class Functions{
    public void Hello32()
    {
        for (int i = 0; i < 32; i++)
        {
            System.Console.WriteLine("hello world!");
        }

    }

    public int Square()
    {
        int n = (int)GetNumberInput();


        return n * n;
        

    }

    public float Multi(){

        float x = GetNumberInput();
        float y = GetNumberInput();
        return x * y;
    }
    public float RightTriangleArea(){

        float x = GetNumberInput();
        float y = GetNumberInput();
        return (x * y)/2;
    }

    public float GetNumberInput()
    {   
        bool isNum = false;
        float num;
        do
        { 
            System.Console.WriteLine("write a number:");
            string ans = Console.ReadLine();
            isNum = float.TryParse(ans, out num);
            
            if(!isNum)
            {
                System.Console.WriteLine("Not a computable number, try again:");
            }
        } while (!isNum);

        return num;
    }

}