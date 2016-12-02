# Threading-
threading is the ability to create applications that use more than one thread of execution (entry point)

Using 

  Example 1;
  
  =========================================
  
   static void Main(string[] args)
   
        {
            var Thread = new Thread(entry1);
            
            var Thread2 = new Thread(entry2);
            
            //Start in the backgroung 
            
            Thread.Start();
            
            Thread2.Start();
        }
        static void entry1() {
        
            Console.WriteLine("start from thread 1 ");
            
        }
        static void entry2() {
        
            Console.WriteLine("start from thread 2");
            
        }
        
        //output 
        
        //start from thread 1
        
        //start from thread 2

//both start at the same time 
