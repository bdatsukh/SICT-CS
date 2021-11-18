package bieDaalt;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.nio.file.StandardOpenOption;
import java.util.InputMismatchException;
import java.util.Scanner;

public class CommandLineInterface{
	Scanner sc;
	Registration reg;
	
	public CommandLineInterface() {
		sc = new Scanner(System.in);
		reg = new Registration();
		start();
	}
	
	void start() {
		int op = -1;
		
		while(op != 0) {
			
			op = 0;
			System.out.println("1: showAllSubjects\n2: showAllProfessions\n3: showTotalAverageGPA\n4: showStudents"
					+ "\n5: showScoreBySubject\n6: showScoreByMajor\n7: addExam\n8: expulsionStudent\n0: exit");
			System.out.print("\nEnter your choice: ");
			try {
				op = sc.nextInt();
			}
			catch(InputMismatchException e) {
				throw new InputMismatchException(e.getMessage());
			}
			
			operation(op);
			
			System.out.println("----------------");
		}
		
		System.out.println("...\nConsole app exited");
	}
	
	void operation(int op){
		
		switch(op) {
			case 1: 
				showAllSubjects();
				break;
			case 2:
				showAllProfessions();
				break;
			case 3: 
				showTotalAverageGPA();
				break;
			case 4: 
				showStudents();
				break;
			case 5: 
				showScoreBySubject();
				break;
			case 6: 
				showScoreByMajor();
				break;
			case 7: 
				addExam();
				break;
			case 8: 
				expulsionStudent();
				break;
			default: 
				break;
		}
		
	}
	
	void showAllSubjects(){
		System.out.println("\n\n---showAllSubject");
		
		for(int i = 0; i < reg.subjectList.size(); i++) {
			System.out.println(((Subject)reg.subjectList.get(i)).toString());
		}
		
		System.out.println("\n");
	}
	
	void showAllProfessions(){
		System.out.println("\n\n---showAllProfessions");
		
		for(int i = 0; i < reg.majorList.size(); i++) {
			System.out.println(((Major)reg.majorList.get(i)).toString());
		}
		
		System.out.println("\n");
	}
	
	void showTotalAverageGPA() {
		System.out.println("\n\n---showTotalAverageGPA");
		
		float totalAvg = 0.0f;
		
		for(int i = 0; i < reg.studentList.size(); i++) {
			totalAvg += ((Student)reg.studentList.get(i)).getGPA();
		}
		
		totalAvg /= reg.studentList.size();
		
		System.out.println("Total Average GPA: " + totalAvg);
		
		System.out.println("\n");
	}

	void showStudents() {
		System.out.println("\n\n---showAllStudents");
		
		for(int i = 0; i < reg.studentList.size(); i++) {
			System.out.println(((Student)reg.studentList.get(i)).toString());
		}
		
		System.out.println("\n");
	}
	
	void showScoreBySubject() {
		System.out.println("\n\n---showScoreBySubject");
		
		for(int i = 0; i < reg.subjectList.size(); i++) {
			System.out.println(i + 1 + ": " + ((Subject)reg.subjectList.get(i)).getCode());
		}
		
		System.out.print("\nEnter your choice: ");
		int index = sc.nextInt();
		
		System.out.println("\n---" + ((Subject)reg.subjectList.get(index - 1)) + "\n");
		
		for(int i = 0; i < reg.studentList.size(); i++) {
			
			for(int j = 0; j < ((Student)reg.studentList.get(i)).lessons.size(); j++) {
				if(((Lessons)((Student)reg.studentList.get(i)).lessons.get(j)).learned.equals(((Subject)reg.subjectList.get(index - 1)))) {
					System.out.println(((Student)reg.studentList.get(i)).getCode() + ": " + ((Lessons)((Student)reg.studentList.get(i)).lessons.get(j)).getScore());
				}
			}
			
		}
		
		System.out.println("\n");
	}
	
	void showScoreByMajor() {
		System.out.println("\n\n---showScoreByMajor");
		
		for(int i = 0; i < reg.majorList.size(); i++) {
			System.out.println(i + 1 + ": " + ((Major)reg.majorList.get(i)).getCode());
		}
		
		System.out.print("\nEnter your choice: ");
		int index = sc.nextInt();
		
		System.out.println("\n---" + ((Major)reg.majorList.get(index - 1)) + "\n");
		
		for(int i = 0; i < reg.studentList.size(); i++) {
			
			if(((Student)reg.studentList.get(i)).getCode().substring(0, 2).equals(((Major)reg.majorList.get(index - 1)).getCode())) {
				System.out.println(((Student)reg.studentList.get(i)).toString());
			}
			
		}
		
		System.out.println("\n");
	}
	
	void addExam() {
		System.out.println("\n\n---addExam");
		
		System.out.print("Student code: ");
		String code = sc.next();
		
		System.out.println("Lesson code:");
		for(int i = 0; i < reg.majorList.size(); i++) {
			System.out.println(i + 1 + ": " + ((Subject)reg.subjectList.get(i)).getCode());
		}
		
		System.out.print("\nEnter your choice: ");
		int index = sc.nextInt();
		System.out.println("Lesson code: " + ((Subject)reg.subjectList.get(index - 1)).getCode());
		
		System.out.print("Point: ");
		String score = sc.next();
		
		String data = "\n" + code + "/" + ((Subject)reg.subjectList.get(index - 1)).getCode() + "/" + score;
		
		String examsTxt = "C:\\Users\\ThinkPad\\eclipse-workspace\\Cs203\\src\\bieDaalt\\Exams.txt";
        
        try {
            Files.write(Paths.get(examsTxt), data.getBytes(), StandardOpenOption.APPEND);
        }catch (IOException e) {
            e.getMessage();
        }
        
        reg.refreshFile();
        
        System.out.println(data + " added");
	}
	
	void expulsionStudent() {
		System.out.println("\n\n---expulsionStudent");
		
		for(int i = 0; i < reg.studentList.size(); i++) {
			int count = 0;
			
			for(int j = 0; j < ((Student)reg.studentList.get(i)).lessons.size(); j++) {
				
				if(((Lessons)((Student)reg.studentList.get(i)).lessons.get(j)).getScore() < 60) {
					count++;
				}
				
			}
			
			if(count >= 3) {
				System.out.println("-" + ((Student)reg.studentList.get(i)).toString());
			}
			
		}
		
		System.out.println("\n");
	}
	
	public static void main(String[] args) {
		new CommandLineInterface();
	}
	
}