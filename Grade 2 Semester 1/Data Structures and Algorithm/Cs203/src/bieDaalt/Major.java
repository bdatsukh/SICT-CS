package bieDaalt;

public class Major {
	private String code;
	public String name;
	
	public Major() {}
	
	public Major(String code, String name) {
		this.code = code;
		this.name = name;
	}
	
	public String getCode() {
		return this.code;
	}
	
	public String getName() {
		return this.name;
	}
	
	public String toString() {
		return "[" + code + " " + name + "]";
	}
}
