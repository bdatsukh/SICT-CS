package lab3;

import java.util.Scanner;

public class TestStack {
	public static void main(String[] args) {
			// TODO Auto-generated method stub
			MyStack mystack = new MyStack();
			mystack.push(1);
			mystack.push(2);
			mystack.push(3);
			mystack.push(4);
			mystack.push(5);
			mystack.push(6);
			mystack.push(1);
			mystack.push(5);
			mystack.push(6);
			
			Scanner sc = new Scanner(System.in);
			
			System.out.println("============================================MENU============================================");
			System.out.println("empty\npeek\npush\npop");
			System.out.println("\n\nsize\ntoArray");
			System.out.println("\n\ninputStack\nprintStack\nsplitStack\ncombineStack");
			for(;;) {
				System.out.print("\nEnter your command: ");
				String songolt = sc.next();
				
				switch(songolt) {
				case "empty": System.out.println("Is empty: " + mystack.empty()); break;
				case "peek": System.out.println("Peek element: " + mystack.peek()); break;
				case "push": {
					System.out.print("Enter push element: ");
					try {
					mystack.push(sc.nextInt());
					} 
					catch(Exception e) {
						System.out.println("push case error!");
					}
					break;
				}
				case "pop": try {System.out.println("Pop: " + mystack.pop());} catch(Exception e) {System.out.println("pop case error!");} break; 
				case "size": System.out.println("Size: " + mystack.size()); break;
				case "toArray":
					Object[] array = mystack.toArray(); 
					System.out.print("Array >> "); 
					for(Object i : array) 
						System.out.print(i + " "); 
					break;
				case "printStack": System.out.println(mystack.printStack()); break;	
				case "combineStack":
					System.out.println("MyStack: " + mystack.printStack());
					MyStack add = new MyStack();
					for(int i = 0; i < 10; i++) {
						add.push(i);
					}
					System.out.println("add: " + add.printStack());
					mystack.combineStack(add);
					System.out.println("MyStack: " + mystack.printStack());
					break;
				
				case "splitStack":
					System.out.println("MyStack: " + mystack.printStack());
					MyStack split = mystack.splitStack();
					System.out.println("MyStack: " + mystack.printStack());
					System.out.println("split: " + split.printStack());
					
					break;
				

				
				case "exit": System.exit(0); sc.close(); break;
				default: System.out.println("Your command is wrong. Enter another command, please ..."); break;
				}
			}
	}
}
