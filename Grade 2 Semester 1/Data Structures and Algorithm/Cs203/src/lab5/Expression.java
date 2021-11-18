package lab5;

import java.util.Scanner;

import dataStructures.BinaryTreeNode;
import dataStructures.LinkedBinaryTree;
import lab3.MyStack;

/*
 * !!!!!!!!!!!!!!!!!!!!!
 * LinkedBinaryTree class daa root iig butsaadag function bicij 
 * 2tiin modiig bodohdoo
 * haaltaar helberjsen infix helberiig gargaj avahdaa 
 * recursive baidlaar function aa bicsen tul
 * 
 * LinkedBinaryTree class-d 
 * 
 * public BinaryTreenode rootBinaryTreeNode(){
 *     return root;
 * }
 * 
 * function iig nemeed ogooroo. :)
 * 
 * !!!!!!!!!!!!!!!!!!!!!!
 * */

public class Expression extends LinkedBinaryTree{
	
	private int isOperation(char temp) 
    { 
        switch (temp) 
        { 
        	case '+': 
        	case '-': 
        		return 1; 
        	case '*': 
        	case '/': 
        		return 2;
        } 
        
        return -1; 
    } 
	
	public String infixToPostfix(String expression) {
		String result = "";
		MyStack stack = new MyStack();
	
		for(int i = 0; i < expression.length(); i++) {
			char temp = expression.charAt(i); 
            
            if (Character.isLetterOrDigit(temp)) {
                result += temp; 
            }
            else if (temp == '(') {
                stack.push(temp);
            }
            else if (temp == ')') { 
                while (!stack.empty() && (char)stack.peek() != '(') 
                	result += stack.pop(); 
                  
                stack.pop(); 
            }
            else { 
                while (!stack.empty() && isOperation(temp) <= isOperation((char)stack.peek())) {
                    result += stack.pop(); 
                } 
                
                stack.push(temp); 
            } 
		}
		
		while(!stack.empty()) {
			result += stack.pop();
		}
		
		return result;
	}
	
	public String prefixToPostfix(String expression) {
		String result = "";
		MyStack stack = new MyStack();
		
        for (int i = expression.length() - 1; i >= 0; i--) 
        {
        	char temp= expression.charAt(i);
        	
            if (0 < isOperation(expression.charAt(i))) 
            {
                String str = (String)stack.pop() + (String)stack.pop() + temp;
                
                stack.push(str);
            }
            else {
                stack.push(temp + "");	
            }
        }
        
        result = (String)stack.peek();
        
        return result;
	}
	
	public LinkedBinaryTree buildTreePrefix(String expression) {
		MyStack stack = new MyStack();
		
		for(int i = expression.length() - 1; i >= 0; i--) {
			char temp = expression.charAt(i);
			
			if(Character.isLetterOrDigit(temp)) {
				LinkedBinaryTree left = new LinkedBinaryTree();
				LinkedBinaryTree right = new LinkedBinaryTree();
				LinkedBinaryTree node = new LinkedBinaryTree();
				node.makeTree(temp, left, right);
				
				stack.push(node);
			}
			else if(0 < isOperation(temp)) {
				LinkedBinaryTree node = new LinkedBinaryTree();
				LinkedBinaryTree left = (LinkedBinaryTree)stack.pop();
				LinkedBinaryTree right = (LinkedBinaryTree)stack.pop();
				node.makeTree(temp, left, right);
				
				stack.push(node);
			}
		}
		
		return (LinkedBinaryTree)stack.pop();
	}
		
		

	public LinkedBinaryTree buildTree(String expression, int type) {
		
		//type 1: infix
		//type 2: prefix
		//type 3: postfix
		switch(type) {
			case 1:
				expression = infixToPostfix(expression);
				break;
			case 2:
				expression = prefixToPostfix(expression);
				break;
				default:
					break;
		}
		
		MyStack stack = new MyStack();
		
		for(int i = 0; i < expression.length(); i++) {
			char temp = expression.charAt(i);
			
			if(Character.isLetterOrDigit(temp)) {
				LinkedBinaryTree left = new LinkedBinaryTree();
				LinkedBinaryTree right = new LinkedBinaryTree();
				LinkedBinaryTree node = new LinkedBinaryTree();
				node.makeTree(temp, left, right);
				stack.push(node);
			}
			else if (0 < isOperation(temp)){
				LinkedBinaryTree right = (LinkedBinaryTree)stack.pop();
				LinkedBinaryTree left = (LinkedBinaryTree)stack.pop();
				LinkedBinaryTree node = new LinkedBinaryTree();
				node.makeTree(temp, left, right);
				stack.push(node);
			}
		}
		
		return (LinkedBinaryTree)stack.pop();
	}
	
	Scanner scan = new Scanner(System.in);
	
	public double calculate(BinaryTreeNode t) {
		if(t == null)
			return 0;
		
		if(Character.isLetter(t.toString().charAt(0))) {
			System.out.print("Гараас тоон утга оруулна уу\n" + t.toString() + ": ");
			Object temp = scan.next();
			t.setElement(temp);
		}
		else if(0 < isOperation(t.toString().charAt(0))) {
			switch(t.toString().charAt(0)) {
				case '+':
					return (calculate(t.getLeftChild()) + calculate(t.getRightChild()));
				case '-':
					return (calculate(t.getLeftChild()) - calculate(t.getRightChild()));
				case '*':
					return (calculate(t.getLeftChild()) * calculate(t.getRightChild()));
				case '/':
					return (calculate(t.getLeftChild()) / calculate(t.getRightChild()));
			}
		}
		
		return Double.parseDouble(t.toString());
	}
	
	public String infix(BinaryTreeNode t) {
		if(t == null)
			return "";
		
		String result = "(";
		result += infix(t.getLeftChild());
		result += t.toString();
		result += infix(t.getRightChild());
		result += ")";
		
		return result;
	}
	
	public static void main(String[] args) {
		Expression build = new Expression();
		LinkedBinaryTree root = new LinkedBinaryTree();
		Scanner sc = new Scanner(System.in);
		
		boolean exit = false;
		
		while(!exit) {
			System.out.print("\n"
					+ ">> 1: Шинэ мод байгуулах\n"
					+ ">> 2: Илэрхийллийн модоор түүнийг бодох\n"
					+ ">> 3: Хаалтуудаар бүрэн хэлбэржсэн infix хэлбэрийг хэвлэх\n"
					+ ">> 4: Модны prefix хэлбэрийг харах\n"
					+ ">> 5: Модны postfix хэлбэрийг харах\n"
					+ ">> 6: Гарах"
					+ "\n<< ");
			
			int n = sc.nextInt();
			
			switch(n) {
				case 1:{
					System.out.print("\n\t>> Төрөлөө оруулна уу:\n"
							+ "\t>> 1: Infix\n"
							+ "\t>> 2: Prefix\n"
							+ "\t>> 3: Postfix\n\t<< ");
					int type = sc.nextInt();
					
					System.out.print("\n\t>> Илэрхийллээ оруулна уу Зайгүй!!\n\t<< ");
					String expression = sc.next();
					
					root = build.buildTree(expression, type);	
					System.out.print("\t>> postorder: ");
					root.postOrderOutput();
					System.out.print("\n\t>> preorder: ");
					root.preOrderOutput();
					System.out.print("\n\t>> inorder: ");
					root.inOrderOutput();
					System.out.print("\n\t>> levelorder: ");
					root.levelOrderOutput();
					System.out.println("\n\t>> Мод байгууллагдлаа");
					break;
				}
				case 2:
					System.out.println("\t>> Result: " + build.calculate(root.rootBinaryTreeNode()));
					break;
				case 3:
					System.out.println("\t>> infix: " + build.infix(root.rootBinaryTreeNode()));
					break;
				case 4:
					System.out.print("\n\t>> prefix: ");
					root.preOrderOutput();
					System.out.println();
					break;
				case 5:
					System.out.print("\t>> postfix: ");
					root.postOrderOutput();
					break;
				case 6:
					exit = true;
					break;
				default:
					System.out.println("\n\t>> Буруу утга оруулсан байна!!");
					break;
			}
		}
		
		sc.close();
	}

}
