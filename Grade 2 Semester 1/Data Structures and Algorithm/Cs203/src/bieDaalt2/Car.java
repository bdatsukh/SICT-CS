package bieDaalt2;

public class Car {
	private String code;
	public String direction;
	
	public Car(String code, String dir) {
		this.code = code;
		this.direction = dir;
	}

	public String getCode() {
		return code;
	}

	public void setCode(String code) {
		this.code = code;
	}
	
}
