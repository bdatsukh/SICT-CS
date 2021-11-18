package bieDaalt2;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

import dataStructures.ArrayLinearList;
import lab3.MyStack;

public class CarParking {

	MyStack park = new MyStack(10);
	
	public CarParking() {
	
	}
	
	public void process(Car car) {
		System.out.println(car.direction + " " + car.getCode());
		if(car.direction.equals("A")) {
			input(car);
		}
		else {
			output(car);
		}
	}
	
	public void input(Car car) {
		if(10 > park.size()) {
			park.push(car);
			
			System.out.println("Arrival " + car.getCode() + " -> there is room.");
		}
		else {
			System.out.println("Arrival " + car.getCode() + " -> Garage full, this car cannot enter.");
		}
		
		System.out.println(toString());
	}
	
	public void output(Car car) {
		MyStack copy = new MyStack();
		int index = -1, size = park.size();
		
		for(int i = 0; i < size; i++) {
			if(car.getCode().equals(((Car)park.peek()).getCode())) {
				park.pop();
				index = i;
				break;
			}
			
			copy.push(park.pop());
		}
		
		if(index != -1) {		
			System.out.println(index + " cars moved out.");
		}
		else {
			index = copy.size();
			System.out.println("Departure " + car.getCode() + " -> This car not in the garage.");
		}
		
		for(int i = 0; i < index; i++) {
			park.push(copy.pop());
		}
		
		System.out.println(toString());
	}
	
	public String toString() {
		Object[] array = park.toArray();

		StringBuffer s = new StringBuffer();
		s.append("----------Park from door----------\n");

		for(int i = array.length-1; i >= 0; i --) {
			s.append("\t" + (i + 1) + ": " + ((Car)array[i]).getCode() + "\n");
		}
		
		return new String(s);
	}
	
	
	public static void main(String[] args) {
		ArrayLinearList temp = new ArrayLinearList(10);
		
		try {
			String line = null;
			String array[];
			
			File carsTxt = new File("C:\\Users\\ThinkPad\\eclipse-workspace\\Cs203\\src\\bieDaalt2\\cars");
			Scanner sc = new Scanner(carsTxt);
			
			while(sc.hasNextLine()) {
				line = sc.nextLine();
				array = line.split(" ");
				temp.add(temp.size(), new Car(array[1], array[0]));
			}
			
			sc.close();
		}
		catch(FileNotFoundException e) {
			e.printStackTrace();
		}
		
		CarParking parking = new CarParking();
		
		for(int i = 0; i < temp.size(); i++) {
			parking.process(((Car)temp.get(i)));
		}
		
	}
	
}