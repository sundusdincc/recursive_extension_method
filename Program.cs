internal class Program
{
    private static void Main(string[] args)
    {

        //Rekürsif(Öz yinelemeli) Metot

        //3^x -for
        Console.Write("3^x için x değerini giriniz: ");
        int x = int.Parse(Console.ReadLine());
        int result = 1;
        for (int i = 0; i < x; i++)
        {
            result *= 3;
        }
        Console.WriteLine("3^{0} : {1}", x, result);

        //sayi^us- Rekürsif 1 exp
        Islemler ins = new();
        Console.WriteLine("3^5 : " + ins.expo(3, 5));


        //factorial-Rekürsif 2 exp
        Console.WriteLine("Please Enter a Number");
        int number = Convert.ToInt32(Console.ReadLine()); //read number from user    

        double factorial = Factorial(number); //invoke the static method  

        Console.WriteLine("factorial of " + number + " = " + factorial.ToString());  //print the factorial result    

        //extension method call   
        DateTime birthdate = new DateTime(1996, 04, 9);
        Console.WriteLine("Your age is: " + DateTime.Now.Age(birthdate));


        //extension method call   
        string sample1 = "This, is a, sample string";
        Console.WriteLine("output string : " + sample1.Remove(",")); 

        //extension methods call  
        string ifade= "SE Sündüs Dinç";
        bool sonuc=ifade.CheckSpaces();
        Console.WriteLine(sonuc);


        if(sonuc)
        {
            Console.WriteLine(ifade.RemoveWhiteSpaces());
        }

        Console.WriteLine(ifade.MakeUpperCase());
        Console.WriteLine(ifade.MakeLowerCase());

        int[] list={5,9,2,25,11,60,24};
        list.SortArray();
        list.EkranaYazdır();

        int a=5;
        Console.WriteLine(a.IsEvenNumber());
        Console.WriteLine(ifade.GetFirstCharacter());



    }

    //factorial-Rekürsif 2 exp
    public static double Factorial(int number)
    {
        if (number == 0)
            return 1;
        return number * Factorial(number - 1);//Recursive call    

    }


}


public class Islemler
{
    //sayi^us- Rekürsif 1 exp
    public int expo(int sayi, int us)
    {
        if (us < 2)
            return sayi;

        else
            return expo(sayi, us - 1) * sayi;
        /*expo(3,4)
          expo(3,3)*3
          expo(3,2)*3*3
          expo(3,1)*3*3*3
          3*3*3*3   */
    }


}


//extension method tanımlama
public static class Extensions //class: public ve static olmalı
{
    public static int Age(this DateTime date, DateTime birthDate) //metot: public ve static olmalı & parametre:1 this keyword 
    {
        int birthYear = birthDate.Year;
        int currentYear = DateTime.Now.Year;

        return currentYear - birthYear - 1;
    }

    public static string Remove(this string str1, string InputStr)
    {       
        return str1.Replace(InputStr,"");
    }

    public static bool  CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static  string RemoveWhiteSpaces(this string param)
    {
        string[] dizi=param.Split(" ");
        return string.Join("*",dizi);
    }

    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();

    }
    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();

    }

    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }
    
    public static void EkranaYazdır(this int[] param)
    {
        foreach (var item in param)
        {
            Console.Write(item + " ");
            
        }
    }

    public static bool IsEvenNumber(this int param)
    {
       return param%2==0;
    }

    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0,1);
    }



}





