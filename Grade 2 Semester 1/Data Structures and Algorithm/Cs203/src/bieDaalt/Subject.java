package bieDaalt;

public class Subject {
	private String code;
	public String name;
	private float credit;
	
	public Subject() {}
	
	public Subject(String code, String name, float credit) {
		this.code = code;
		this.name = name; 
		this.credit = credit;
	}
	
	public boolean checkCode(String code) {
		return (this.code.equals(code)) ? true : false;
	}
	
	public void setCode(String code) {
		this.code = code;
	}
	
	public String getCode() {
		return this.code;
	}
	
	public void setName(String name) {
		this.name = name;
	}
	
	public String getName() {
		return this.name;
	}
	
	public void setCredit(float credit) {
		this.credit = credit;
	}
	
	public float getCredit() {
		return this.credit;
	}
	
	public String toString() {
		return "[" + code + " "+ name + " " + Float.toString(credit) + "]";
	}
}
