package lab;

import dataStructures.ArrayLinearList;

public class MyArrayLinearList extends ArrayLinearList{

	public void sort() {
		
		for(int i = 0; i < size; i++) {
			
			int min = i;
			
			for(int j = i + 1; j < size; j++) {
				 
				if((int)element[min] > (int)element[j]) {
					min = j;
				}
				
			}
			
			int temp = (int)element[i];
			element[i] = element[min];
			element[min] = temp;
			
		}
		
	}
	
	public void removeOdd() {
		
		for(int i = 0; i < size; i++) {
			
			if((int)element[i] % 2 != 0) {
				remove(i);
				i -= 1;
			}
			
		}
		
	}
	
	public int max() {
		
		if(isEmpty())
			return 0;
		
		int max = (int)element[0];
		
		for(int i = 1; i < size; i++) {
			
			if(max < (int)element[i]) {
				
				max = (int)element[i];
				
			}
			
		}
		
		return max;
	}
	
	public String min() {
		
		if(isEmpty())
			return "";
		
		int min = (int)element[0];
		
		for(int i = 1; i < size; i++) {
			
			if(min > (int)element[i]) {
				
				min = (int)element[i];
				
			}
			
		}
		
		return Integer.toString(min);
	}
	
	public String sum() {
		if(isEmpty())
			return "";
		int sum = 0;
		
		for(int i = 0; i < size; i++) {
			
			sum += (int)element[i];
			
		}
		
		return Integer.toString(sum);
	}
	
	public String average() {
		
		if(isEmpty())
			return "";
		
		return Double.toString((Double.parseDouble(sum()) / size));
	}
	
}
