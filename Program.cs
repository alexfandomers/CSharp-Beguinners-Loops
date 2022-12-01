namespace LoopsBeguinners
{
    public class Program
    {
        static void Main(string[] args)
        {  
           Console.WriteLine("///////For Loop///////////");
           for (int i = 1; i <= 10; i++)
           {
              if (i%2 == 0)
              {
                Console.WriteLine(i);
              }
           }

          Console.WriteLine("//////////////////");
           for (int i = 10; i >= 1; i--)
           {
              if (i%2 == 0)
              {
                Console.WriteLine(i);
              }
           }
        
         Console.WriteLine("//////////////////");
           var name = "karl simon";
           for (int i = 0; i < name.Length; i++)
           {
                Console.WriteLine(name[i]);
           }

         Console.WriteLine("///////Foreach Loop///////////");
            var name2 = "timot Phillips";
            foreach (var n in name2)
            {
                Console.WriteLine(n);
            }

         Console.WriteLine("//////////////////");
            var lottery = new[] {4, 7, 2,9};
            foreach (var num in lottery)
            {
                Console.WriteLine(num);
            }  

         Console.WriteLine("///////While Loop///////////"); 
          //when we don't know how many iterations will be
          while(true)
          {
            Console.Write("Type your name: ");
            var input = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("@Echo: " + input);
                continue;
            }
            break;
          }  
       }
    }
}