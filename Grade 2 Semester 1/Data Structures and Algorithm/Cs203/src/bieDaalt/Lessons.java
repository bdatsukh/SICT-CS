package bieDaalt;

public class Lessons {
	public Subject learned;
	private int score;
	
	public Lessons(Subject learned, int score) {
		this.learned = learned;
		setScore(score);
	}
	
	public int getScore() {
		return this.score;
	}
	
	void setScore(int score) {
		if(0 <= score && score <= 100)
			this.score = score;
		else
			System.out.println("0 <= score <= 100");
	}
	
	public Subject getSubject() {
		return learned;
	}
	
	public String toString() {
		int lastIndex = learned.toString().length() - 1;
		String str = learned.toString().substring(0, lastIndex);
		return str + " " + Integer.toString(score) + "]";
	}
}
