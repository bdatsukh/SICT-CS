package bieDaalt;

import lab2.MyChain;

public class Student {
	private String code;
	private float GPA;
	public MyChain lessons;
	
	public Student(){}
	
	public Student(String code, Lessons lesson) {
		lessons = new MyChain();
		this.code = code;
		addLesson(lesson);
	}
	
	public boolean checkStudent(String code) {
		return (this.code.equals(code)) ? true : false;
	}
	
	public void calculateGPA() {
		float gpa = 0.0f;
		float credit = 0.0f;
		
		for(int i = 0; i < lessons.size(); i++) {
		
			credit += ((Lessons)lessons.get(i)).learned.getCredit();
			float converted = convert(((Lessons)lessons.get(i)).getScore());
			gpa += (converted * ((Lessons)lessons.get(i)).learned.getCredit());
			
		}
		
		gpa /= credit;
		
		
		this.GPA = gpa;
		
	}
	
	public float convert(int score) {
		float result;
		
		if(96 <= score && score <= 100)
			result = 4.0f;
		else if(91 <= score && score <= 95)
			result = 3.7f;
		else if(88 <= score && score <= 90)
			result = 3.4f;
		else if(84 <= score && score <= 87)
			result = 3.0f;
		else if(81 <= score && score <= 83)
			result = 2.7f;
		else if(78 <= score && score <= 80)
			result = 2.4f;
		else if(74 <= score && score <= 77)
			result = 2.0f;
		else if(71 <= score && score <= 73)
			result = 1.7f;
		else if(68 <= score && score <= 70)
			result = 1.3f;
		else if(64 <= score && score <= 67)
			result = 1.0f;
		else if(60 <= score && score <= 63)
			result = 0.7f;
		else
			result = 0.0f;
		
		return result;
	}
	
	public String getCode() {
		return this.code;
	}
	
	public float getGPA() {
		calculateGPA();
		return this.GPA;
	}
	
	public void addLesson(Lessons lesson) {
		lessons.add(lessons.size(), lesson);
	}
	
	public String toString() {
		calculateGPA();
		return "[" + this.code + " " + Float.toString(GPA) + " " + lessons.toString() + "]";
	}
}
