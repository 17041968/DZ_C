Console.Write("Ввести начало интервала: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Ввести конец интервала: ");
int b = int.Parse(Console.ReadLine());
   for (int i = a; i <= b; i++)
   {
      if (i % 2 == 0) 
      {
         Console.Write(i + " ");
      }
   }
