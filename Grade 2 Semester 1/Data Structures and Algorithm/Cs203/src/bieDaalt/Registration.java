package bieDaalt;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;
import lab.MyArrayLinearList;

public class Registration {
	public MyArrayLinearList studentList;
	public MyArrayLinearList subjectList;
	public MyArrayLinearList majorList;
	
	public Registration() {
		refreshFile();
	}
	
	public void refreshFile() {
		subjectList = null;
		majorList = null;
		studentList = null;
		readSubjectList();
		readMajorList();
		readStudentList();
	}
	
	private void readSubjectList() {
		File subjectsTxt = new File("C:\\Users\\ThinkPad\\eclipse-workspace\\Cs203\\src\\bieDaalt\\Subjects.txt");
		
		subjectList = new MyArrayLinearList();
		
        try {
	        Scanner sc = new Scanner(subjectsTxt);
	        
	        while(sc.hasNextLine()) {
	        	String str[] = sc.nextLine().split("/");
	        	subjectList.add(subjectList.size(), new Subject(str[0], str[1], Float.parseFloat(str[2])));
	        }
	   
	        sc.close();
	    }
		catch (FileNotFoundException e) {
	        e.printStackTrace();
	    }
	}
	
	private void readMajorList() {
		File professionsTxt = new File("C:\\Users\\ThinkPad\\eclipse-workspace\\Cs203\\src\\bieDaalt\\Professions.txt");
		
		majorList = new MyArrayLinearList();
		
        try {
	        Scanner sc = new Scanner(professionsTxt);
	        
	        while(sc.hasNextLine()) {
	        	String str[] = sc.nextLine().split("/");
	        	majorList.add(majorList.size(), new Major(str[0], str[1]));
	        }
	   
	        sc.close();
	    }
		catch (FileNotFoundException e) {
	        e.printStackTrace();
	    }
	}
	
	private void readStudentList() {
		File examsTxt = new File("C:\\Users\\ThinkPad\\eclipse-workspace\\Cs203\\src\\bieDaalt\\Exams.txt");
		
		studentList = new MyArrayLinearList();
		
        try {
	        Scanner sc = new Scanner(examsTxt);
	        
	        while(sc.hasNextLine()) {
	        	String str[] = sc.nextLine().split("/");
	        	String code = str[0];
	        	String lessonCode = str[1];
	        	String score = str[2];
	        	
	        	Lessons lesson = null;
	        	
	        	for(int i = 0; i < subjectList.size(); i++) {
	        		if(((Subject)subjectList.get(i)).checkCode(lessonCode)) {
	        			lesson = new Lessons((Subject)subjectList.get(i), Integer.parseInt(score));
	        			break;
	        		}
	        	}
	        	
	        	boolean newStudent = true;
	        	
	        	for(int i = 0; i < studentList.size(); i++) {
	        		if(((Student)studentList.get(i)).checkStudent(code)) {
	        			newStudent = false;
	        			((Student)studentList.get(i)).addLesson(lesson);
	        			break;
	        		}
	        	}
	        	
	        	if(newStudent) {
	        		studentList.add(studentList.size(), new Student(code, lesson));		
	        	}
	        }
	   
	        sc.close();
	    }
		catch (FileNotFoundException e) {
	        e.printStackTrace();
	    }
	}
}