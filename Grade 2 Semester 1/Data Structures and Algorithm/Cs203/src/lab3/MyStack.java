package lab3;


import dataStructures.ArrayStack;

public class MyStack extends ArrayStack{
	
	/*!!!From Batsukh not Sukhee!!!*/
	
	public MyStack() {
		 
	}
	
	public MyStack(int size) {
		super(size);
	}
	
	public int size() {
		return top + 1;
	}
	
	
	public Object[] toArray() {
		Object[] arr = new Object[size()]; 
		
		int j = this.size() - 1;
		
		while(!empty()) {
			arr[j--] = this.pop();
		}
		
		for(int i = 0; i < arr.length; i++) {
			this.push(arr[i]);
		}
		
		return arr;
	}
	
	public String printStack() {
		Object[] array = this.toArray();

		StringBuffer s = new StringBuffer();
		s.append("[===Stack from top===]\n");

		for(int i = array.length-1; i >= 0; i --) {
			s.append("\t" + array[i].toString() + "\n");
		}
		return new String(s);
}
	
	public MyStack splitStack() {
		MyStack splitted = new MyStack();
		
		for(int i = 0; i <= size() / 2; i++) {
			splitted.push(this.pop());
		}
		
		return splitted;
	}
	
	public void combineStack(MyStack add) {
		MyStack obj = new MyStack();
		
		int size = add.size();
		
		for(int i = 0; i < size; i++) {
			obj.push(add.pop());
		}
		
		int objSize = obj.size();
		
		for(int i = 0; i < objSize; i++) {
			this.push(obj.pop());
		}
	}

}
