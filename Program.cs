using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thread_example
{
    class Program
    {static int count = 1 ;
        static void Main(string[] args)
        {

            #region Example 1
            //    var Thread = new Thread(entry1);
            //    var Thread2 = new Thread(entry2);
            //    //Start in the backgroung 
            //    Thread.Start();
            //    Thread2.Start();
            //}
            //static void entry1() {
            //    Console.WriteLine("start from thread 1 ");
            //}
            //static void entry2() {
            //    Console.WriteLine("start from thread 2");

            //Output 
            //start from thread 1 
            //  start from thread 2 
            #endregion

            #region Example2(multi threads)
            //    for (int i = 0; i < 8; i++)
            //    {
            //        var Thread = new Thread(entry1);
            //        Thread.Start(i);
            //    }
            //}

            //    static void entry1(object ThreadID ) {
            //        while (true)
            //        {
            //            Console.WriteLine("start from thread  " + ThreadID);
            //        }

            //    }
            /*output 
             * start from thread 1
             *start from thread 2
             *start from thread 3 
             *start from thread 4 
             *start from thread 5 
             *start from thread 6 
             *start from thread 7 
             *etc ... 
         
             */
            #endregion

            #region Thread Synchronization

            var Thread1 = new Thread(ThreadCounted);
            var Thread2 = new Thread(ThreadCounted);
            Thread1.Start();
            //make thread1 sleep for 1 sec (eng anwar)
            Thread.Sleep(1000);
            Thread2.Start();
        }
        static void ThreadCounted ()
          {
            while (true)
	           {
	         int temp = count ; 
            Thread.Sleep(1000);
            count++;
                Console.WriteLine("thread id {0} that count {1} " ,Thread.CurrentThread.ManagedThreadId,count);
               }
           }
        }
    /*output 
     thread id 11 that count 2
     * thread id 12 that count 3
     * (sleep for a second )
     * thread id 11 that count 4
     * thread id 12 that count 5
     * etc .... 
     */
            #endregion
}
        

    
