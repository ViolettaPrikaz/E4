int n = new Random().Next(1, 10); 
Console.WriteLine(n);

        static string KO(int n)
{
        return (n == 1 ? "1" : KO(n - 1) + n);
}
 {
           
            Console.WriteLine(KO(n));
 
        }
