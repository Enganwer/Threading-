# Threading-
threading is the ability to create applications that use more than one thread of execution (entry point)

Using in 
 
 1-Make more than one entry point (Main method)
 
 2-Make more than one process in the backgroud and the same time 
 
 3-make interactions between the Threads bs  Multiple Threads 
 
 There's more and more usage for it and different appereance for it  like Background and foreground thread .


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
