using System.IO;
using System;
using System.Collections;
using System.Text;

class Program
{
   public static void Main() 
   {
      BlockingCollection<int> vs = new BlockingCollection<int>(2);
      task.Run(() =>
      {
          while(!vs.IsCompleted)
          {
              int x = 0;
              try 
              {
                  x = vs.Take();
              }
              catch(InvalidOperationException)
              {
                  
              }
              if(x!=0)
              {
                  //process(x);
              }
          }
      })
      Task.Run(()=>
      while(some condition here)
      {
          int x =0;
          vs.Add(x);
      }
      
      })