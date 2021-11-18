package lab1;

public class University {
	
	String name;
	Student[] students;
	static int count = 0;
	
	public University(String name, int size) {
		this.name = name;
		students = new Student[size];
	}
	
	void addStudent(Student student) {
		students[count++] = student;
	}
	
	public int studentCount() {
		return count;
	}
	

	public static void main(String[] args) {
		University sict = new University("Sict", 10);
		
		Student st1 = new Student("Bat", "B1809",2018, "Computer Science");
		Student st2 = new Student("Bold", "B1909",2019, "Software Developer");
		Student st3 = new Student("Suvd", "B1909",2019, "Cyber security");
		
		sict.addStudent(st1);
		sict.addStudent(st2);
		sict.addStudent(st3);
		
		System.out.println("Total student: " + sict.studentCount());
		
		for(int i = 0; i < sict.studentCount(); i++) {
			System.out.println("Student " + (i + 1) + " information: ");
			System.out.println(sict.students[i].getInfo());
			System.out.println();
		}
	}
	
}