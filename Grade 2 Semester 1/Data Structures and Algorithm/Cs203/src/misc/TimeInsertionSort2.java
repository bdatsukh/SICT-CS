
/** more accurate way to find the worst-case run time of insertion sort */

package misc;

import applications.*;

public class TimeInsertionSort2
{
   public static void main(String [] args)
   {
      int step = 10;

      System.out.println("The worst-case times, in milliseconds, are");
      System.out.println("n \trepetitions \telapsed time \ttime/sort");
      for (int n = 0; n <= 1000; n += step)
      {
         // create element array
         Integer [] a = new Integer[n];

         long startTime = System.currentTimeMillis();
         long counter = 0;
         do
         {
            counter++;
            // initialize array
            for (int i = 0; i < n; i++)
               a[i] = new Integer(n - i);

            // sort the elements
            InsertionSort2.insertionSort(a);
         } while (System.currentTimeMillis( ) - startTime < 1000);

         long elapsedTime = System.currentTimeMillis() - startTime;
         System.out.println(n + "\t" + counter + "\t\t" 
            + elapsedTime + "\t\t" + ((float) elapsedTime)/counter);

         if (n == 100) step = 100;
      }
   }
}
