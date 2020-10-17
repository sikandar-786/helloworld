using System; 
  
namespace HelloWorldApp { 
      
    class Program
    {

         public static async Task Main(string[] args)
        {
            var helloTask = helloAsync();
            var worldTask = WorldAsync();

            Task.WaitAll(helloTask, worldTask);
            Console.WriteLine(helloTask.Result);
            Console.WriteLine(worldTask.Result);

        }

        private static async Task<String> helloAsync()
        {
            return "Hello";
        }

        private static async Task<String> WorldAsync()
        {
            return "World";
        }
    }
} 
