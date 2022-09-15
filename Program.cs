Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int summs = Sum(num);
Console.WriteLine(summs);




int Sum(int A)
    {
        int length = Convert.ToString(A).Length;
        int resultat = 0;
            for (int i = 0; i < length; i++)
            {
                resultat = resultat + A%10;
                A = A/10;
            }
        return resultat;
        
    }
       