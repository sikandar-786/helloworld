using System; 
  
namespace HelloWorldApp { 
      
    class Program
    {

        public static async Task Main(string[] args)
        {
            var a =await helloWordAsync();
            Console.WriteLine(a);
            
        }

        private static async Task<String> helloWordAsync()
        {
            return "Hello World";
        }
    }
} 
