using System;

using System.Linq;




namespace Revision

{
    
    class Program
    
    {
        

        static void Main(string[] args)
        
        {

            

             if (args.Any())
            
             {
                
                int numero1 = Convert.ToInt32(args[0]);
                
                string operacion = args[1];
                
                int numero2 = Convert.ToInt32(args[2]);


                
                Calculadora calculadora = new Calculadora();

 
               
                Console.WriteLine(calculadora.Operar(numero1, operacion, numero2));


                
                return;
            
             }

   
        
             Console.WriteLine("Bienvenidos a la calculdora estandar del Yairac");
            
            
             
             Console.ReadKey();
        
       }
    
   }


}
