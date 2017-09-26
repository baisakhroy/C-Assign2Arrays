using System;

namespace C_assignment2_a
{
    public class Arr {
        int i;
        int sum1,sum2;
        public int initialize(int n){
        
        
         
         
        int[] A = new int[n];


        for(i=0;i<n;i++){
            A[i]=i+1;
            if(i%2==0){
                sum1=sum1+A[i];
            }
            if (i%2 != 0){
                sum2=sum2+A[i];
            }
            if(i==11){
                Console.WriteLine("The Array has gone beyond size 10");
            }
            Console.WriteLine(A[i]);
            
        }
        Console.WriteLine(sum1-sum2);
        return (sum1-sum2);
    }
    }
    class Program   
    { 
        static void Main()
        {
         Arr Yo = new Arr();
         int n;
         Console.WriteLine("Enter the size of your array");
         n=int.Parse(Console.ReadLine());

        Yo.initialize(n);
       
        
        }
    }

}
