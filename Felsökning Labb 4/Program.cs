namespace Felsökning_Labb_4
{
    internal class Program
    {// ===== Eddie Halling SUT23 =====
        static void Main(string[] args)
        {
            //Case 1
            int number = 2;

            if (number > 3)
            {
                Console.WriteLine("Talet är större än tre"); //inget semicolon ; i slutet av raden
            }
            else if (number < 3) //inget mellanslag mellan orden else if (tidigare elseif)
            {
                Console.WriteLine("Talet är mindre än tre");
            }


            //Case 2
            for (int i = 1; i <= 100; i++) //Räknade bara upp till att det var mindre än hundra, la till ett likamed tecken, alternativt ändra 100 till 101
            {
                Console.WriteLine(i);
            }


            //Case 3
            for (int i = 1; i <= 5; i++) //Saknades ++ på sista villkoret
            {
                for (int j = 1; j <= i; j++) //Saknades ++ på sista villkoret
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }


            //Case 4
            int i = 1;
            while (i <= 5)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j); //Saknades output inom paranteserna
                }

                Console.WriteLine();
                i++;
            }


            //Case 5
            int i = 1;

            switch (i)
            {
                case 1:
                    break; //Satt en break efter case 1
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }


            //Case 6
            int i = 10;

            if (i == 5) //Saknades ett likamed tecken
            {
                Console.WriteLine("i är 5");
            }
        }
    }
}