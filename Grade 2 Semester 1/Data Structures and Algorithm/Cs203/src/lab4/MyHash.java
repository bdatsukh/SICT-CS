package lab4;

import java.util.*;
import dataStructures.HashTable;

public class MyHash extends HashTable {	

	public MyHash(int theDivisor) {
		super(theDivisor);
		// TODO Auto-generated constructor stub
	}
	
	public void delete(Object theKey) {
		table[search(theKey)] = null;
	}
	
	public Object updateElement(Object theKey, Object theElement) {
		Object elementToUpdate = get(theKey);
		
		put(theKey, theElement);
		
		return elementToUpdate;
	}
	
	public Object updateKey(Object theKey, Object theNewKey) {
		Object elementToUpdate = get(theKey);
		
		delete(theKey);
		put(theNewKey, elementToUpdate);
		
		return elementToUpdate;
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		MyHash myhash = new MyHash(5);
		
		Scanner sc = new Scanner(System.in);
		System.out.println("=============== MENU ================");
		System.out.println("isEmpty\nsize\nget\nput\noutput\nexit\n\n");
		System.out.println("updateElement\nupdateKey\ndelete");
		System.out.println("=====================================");
		for(;;) {
			System.out.println("\nEnter command: ");
			String songolt = sc.next();
			
			switch(songolt) {
			case "isEmpty": {System.out.println("is empty >>> " + myhash.isEmpty());break;}
			case "size": {System.out.println("size >>> " + myhash.size());break;}
			case "get": {
				System.out.print("Enter key: "); 
				String myhash_key = sc.next();
				if(myhash.get(myhash_key) != null)
					System.out.println("Key>>> " + myhash_key + "\tElement>>> " + myhash.get(myhash_key));
				else
					System.out.println("There is no element with such key.");
				break;
			}
			case "put": {				
				System.out.print("Enter key: "); 
				String myhash_key = sc.next(); 
				
				System.out.print("Enter element: "); 
				String myhash_element = sc.next(); 
				try {
					myhash.put(myhash_key, myhash_element);
				} 
				catch(Exception e) {System.out.println("Error!!!");}
				break;
			}
			case "output": {myhash.output();break;}
			
			case "updateElement": {				
				System.out.print("Enter key: "); 
				String myhash_key = sc.next();
				System.out.print("Enter element: "); 
				String myhash_element = sc.next();
				
				if(myhash.get(myhash_key) != null) {
					Object bef = myhash.updateElement(myhash_key, myhash_element);
					System.out.println("Before: Key>>> " + myhash_key + "\tElement>>> " + bef);	
					System.out.println("Now: Key>>> " + myhash_key + "\tElement>>> " + myhash.get(myhash_key));	
				}
				else
					System.out.println("There is no element with such key.");
				break;
			}
			
			case "updateKey": {	
				System.out.print("Enter key: "); 
				String myhash_key = sc.next();
				System.out.print("Enter new key: "); 
				String myhash_NewKey = sc.next();
				
				if(myhash.get(myhash_key) != null) {
					myhash.updateKey(myhash_key, myhash_NewKey);
					System.out.println("Key>>> " + myhash_NewKey + "\tElement>>> " + myhash.get(myhash_NewKey));
				}
				else
					System.out.println("There is no element with such key.");
				break;
			}
			
			case "delete": {
				System.out.print("Enter key: "); 
				String myhash_key = sc.next();
				
				if(myhash.get(myhash_key) != null) {
					myhash.delete(myhash_key);
					System.out.println("deleted");
				}
				else
					System.out.println("There is no element with such key.");
				
				break;
			}
			
			case "exit": {System.exit(0);break;}
			default: {System.out.println("Your command is wrong! Enter another command.");break;}
			}
		}		
	}

}
