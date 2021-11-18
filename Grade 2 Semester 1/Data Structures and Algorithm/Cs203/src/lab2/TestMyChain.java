package lab2;

import java.util.Scanner;
import java.util.Arrays;
import java.util.InputMismatchException;
public class TestMyChain {
	
	Scanner sc = new Scanner(System.in);
	MyChain chain = new MyChain();
	
	void operation(int op){
		
		switch(op) {
			case 1: 
				System.out.println("Size: " + chain.size());
				break;
			case 2:
				addElement();
				break;
			case 3: 
				removeElement();
				break;
			case 4: 
				getElement();
				break;
			case 5: 
				indexOf();
				break;
			case 6: 
				addRange();
				break;
			case 7: 
				union();
				break;
			case 8: 
				intersection();
				break;
			case 9: 
				toArray();
				break;
			case 10: 
				ToString();
				break;
			default: 
				break;
		}
		
	}
	
	void addElement() {
		System.out.println("---Add Element option");
		System.out.print("How Many Element: ");
		int count = sc.nextInt();
		
		for(int i = 0; i < count; i++) {
			System.out.print("Index: ");
			int index = sc.nextInt();
			
			sc.nextLine();
			
			System.out.print("Element: ");
			Object element = sc.next();
			
			chain.add(index, element);
		}
		
		System.out.println("Added");
	}
	
	void removeElement() {
		System.out.println("---Remove Element option");
		System.out.print("Index: ");
		int index = sc.nextInt();
		chain.remove(index);
		System.out.println("Removed");
	}
	
	void getElement() {
		System.out.println("---get Element option");
		System.out.print("Index: ");
		int index = sc.nextInt();
		System.out.println("Element: " + chain.get(index));
	}
	
	void indexOf() {
		System.out.println("---Index of option");
		System.out.print("Element: ");
		sc.nextLine();
		Object element = sc.next();
		
		int index = chain.indexOf(element);
		
		if(index == -1) {
			System.out.println(element + " not found");
		}
		else {
			System.out.println("Index of " + element + ": " + index);
		}
	}
	
	void addRange() {
		System.out.println("---Add Range option");
		System.out.print("Enter Size of Array: ");
		int size = sc.nextInt();
		
		sc.nextLine();
		
		Object[] arr = new Object[size];
		
		for(int i = 0; i < size; i++) {
			System.out.print("Enter element " + i + ": ");
			arr[i] = sc.next();
		}
		
		System.out.println("Array: " + Arrays.toString(arr));
		
		chain.addRange(arr);
		
		System.out.println("Added");
		System.out.println("Chain: " + chain.toString());
	}

	
	void union() {
		System.out.println("---Union option");
		MyChain add = new MyChain();
		
		System.out.print("Enter size of add chain: ");
		int size = sc.nextInt();
		
		sc.nextLine();
		
		for(int i = 0; i < size; i++) {
			System.out.print("Enter element " + i + ": ");
			Object element = sc.next();
			add.add(i, element);
		}
		
		System.out.println("Add chain: " + add.toString());
		System.out.println("Chain: " + chain.toString());
		
		MyChain union = new MyChain();
		
		union = chain.union(add);
		
		System.out.println("Union chain: " + union.toString());
		System.out.println("Successfully");
	}
	
	void intersection() {
		System.out.println("---Intersection option");
		MyChain add = new MyChain();
		
		System.out.print("Enter size of add chain: ");
		int size = sc.nextInt();
		
		sc.nextLine();
		
		for(int i = 0; i < size; i++) {
			System.out.print("Enter element " + i + ": ");
			Object element = sc.next();
			add.add(i, element);
		}
		
		System.out.println("Add chain: " + add.toString());
		System.out.println("Chain: " + chain.toString());
		
		MyChain intersection = new MyChain();
		
		intersection = chain.intersection(add);  
		
		System.out.println("Intersection chain: " + intersection.toString());
		System.out.println("Successfully");
	}
	
	void toArray() {
		System.out.println("---To Array option");
		Object[] arr = chain.toArray();
		System.out.println("Array chain: " + Arrays.toString(arr));
		System.out.println("Succesfully");
	}
	
	void ToString(){
		System.out.println("---To String option");
		System.out.println(chain.toString());
	}
	
	void start() {
		int op = -1;
		while(op != 0) {
			op = 0;
			System.out.println("1: get Size\n2: Add Element\n3: Remove Element\n4: Get Element"
					+ "\n5: IndexOf\n6: Add Range\n7: Union\n8: Intersection\n9: ToArray\n10: ToString\n0: exit");
			System.out.print("Enter your choice: ");
			try {
				op = sc.nextInt();
			}
			catch(InputMismatchException e) {
				throw new InputMismatchException(e.getMessage());
			}
			
			System.out.println("----------------");
			
			operation(op);
			
			System.out.println("----------------");
		}
		
		System.out.println("...\nConsole app exited");
	}
	
	public static void main(String[] args) {
		
		TestMyChain app = new TestMyChain();
		app.start();
	
	}
	
}