package lab2;

import dataStructures.Chain;

public class MyChain extends Chain{

	public Object[] toArray() {
		Object[] array = new Object[size];
		
		for(int i = 0; i < size; i++) {
			array[i] = get(i);
		}
		
		return array;
	}
	
	public void addRange(Object[] elements) {
		
		for(int i = 0; i < elements.length; i++) {
			
			this.add(this.size, elements[i]);
			
		}
		
	}
	
	public MyChain union(MyChain chain) {
		MyChain result = new MyChain();
		
		for(int i = 0; i < this.size; i++) {
			result.add(i, this.get(i));
		}
		
		for(int i = this.size; i < this.size + chain.size; i++) {
			result.add(i, chain.get(i - this.size));
		}
		
		for(int i = 0; i < result.size(); i++) {
			
			for(int j = i + 1; j < result.size(); j++) {
				
				if(result.get(i).equals(result.get(j))) {
					result.remove(j);
					j--;
				}
				
			}
			
		}
		
		return result;
	}
	
	public MyChain intersection(MyChain chain) {
		MyChain result = new MyChain();
		
		for(int i = 0; i < this.size; i++) {
			result.add(i, this.get(i));
		}
		
		for(int i = this.size; i < this.size + chain.size; i++) {
			result.add(i, chain.get(i - this.size));
		}
		
		for(int i = 0; i < result.size; i++) {
			boolean check = false;
		
			for(int j = i + 1; j < result.size; j++) {
				
				if(result.get(i).equals(result.get(j))) {
					result.remove(j);
					j--;
					check = true;
				}
				
			}
			
			if(!check) {
				result.remove(i);
				i--;
			}
			
		}
		
		return result;
	}
	
}
