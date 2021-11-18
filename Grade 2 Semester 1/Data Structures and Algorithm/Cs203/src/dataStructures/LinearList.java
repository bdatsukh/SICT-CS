
/** interface for linear lists */

package dataStructures;

public interface LinearList
{
   public boolean isEmpty();
   public int size();
   public Object get(int index);
   public int indexOf(Object theElement);
   public Object remove(int index);
   public void add(int index, Object theElement);
   public String toString();
   /*public void sort();
   public void removeOdd();
   public int max();
   public String min();
   public String sum();
   public String average();*/
}
