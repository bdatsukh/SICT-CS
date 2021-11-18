public class InsertionSortAlgorithm {
public static void main(String[] args) {
final int[] input = { 4, 10, 3, 1, 9, 15 };
System.out.println("Before Sorting - " + Arrays.toString(input));
insertionSort(input);
System.out.println("After Sorting - " + Arrays.toString(input));
}
public static void insertionSort(int array[]) {
int n = array.length;
for (int j = 1; j < n; j++) {
int key = array[j];
int i = j-1;
while ( (i > -1) && ( array [i] > key ) ) {
array [i+1] = array [i];
i--;
}
array[i+1] = key;
}
}
}