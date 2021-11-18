package lab1;

public class Student {
	String code;
	String name;
	int dateOfEntry;
	String major;
	
	public Student(String code, String name, int dateOfEntry, String major) {
		this.code = code;
		this.name = name;
		this.dateOfEntry = dateOfEntry;
		this.major = major;
	}
	
	public String getCode() {
		return this.code;
	}
	
	public String getName() {
		return this.name;
	}
	
	public int getDateOfEntry() {
		return this.dateOfEntry;
	}
	
	public String getMajor() {
		return this.major;
	}
	
	public String getInfo() {
		String studentInfo = "Оюутаны код: " + getCode()
		+ "\nОюутны нэр: " + getName()
		+ "\nЭлссэн огноо: " + getDateOfEntry()
		+ "\nСуралцах мэргэжил: " + getMajor();
		return studentInfo;
	}
	
}
