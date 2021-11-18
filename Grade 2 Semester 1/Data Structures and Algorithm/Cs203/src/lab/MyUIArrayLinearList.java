package lab;

import java.awt.Font;
import java.awt.event.*;
import java.text.DecimalFormat;
import java.util.regex.Pattern;

import javax.swing.*;

public class MyUIArrayLinearList implements ActionListener{
	private JTextField textFieldAddIndex, textFieldAddNumber, textFieldRemoveIndex, textFieldIndexOf;
	private JButton btnAdd, btnRemove, btnRemoveOdd, btnSort, btnIndexOf;
	private JLabel lbl, lbl1, lbl2, lbl3, lbl4, lblMax, lblMin, lblSum, lblAverage, lblIndexOf;
	private MyArrayLinearList list;
	
	public MyUIArrayLinearList() {
		JFrame obj = new JFrame("LINEAR LIST");
		list = new MyArrayLinearList();
		
		
		//view ArrayLinearList
		lbl = new JLabel("Size = [Index: Number]");
		lbl.setFont(new Font(Font.SERIF, 0, 18));
		lbl.setBounds(30, 10, 300, 30);
		lbl1 = new JLabel();
		lbl1.setFont(new Font(Font.SERIF, 0, 18));
		lbl1.setBounds(30, 30, 300, 30);
		
		//insert
		lbl2 = new JLabel("Index: ");
		lbl2.setBounds(30, 100, 80, 30);
		textFieldAddIndex = new JTextField();
		textFieldAddIndex.setBounds(30, 130, 80, 30);
		lbl3 = new JLabel("Number: ");
		lbl3.setBounds(120, 100, 80, 30);
		textFieldAddNumber = new JTextField();
		textFieldAddNumber.setBounds(120, 130, 80, 30);
		btnAdd = new JButton("Add");
		btnAdd.setBounds(210, 130, 85, 30);
	
		//remove
		lbl4 = new JLabel("Index: ");
		lbl4.setBounds(30, 160, 80, 30);
		textFieldRemoveIndex = new JTextField();
		textFieldRemoveIndex.setBounds(30, 190, 80, 30);
		btnRemove = new JButton("Remove");
		btnRemove.setBounds(210, 190, 85, 30);
		
		//Max, min, average, sum label
		lblMax = new JLabel();
		lblMax.setBounds(160, 295, 120, 30);
		lblMin = new JLabel();
		lblMin.setBounds(160, 335, 150, 30);
		lblSum = new JLabel();
		lblSum.setBounds(30, 295, 150, 30);
		lblAverage = new JLabel();
		lblAverage.setBounds(30, 335, 120, 30);
		
		//sort
		btnSort = new JButton("Sort");
		btnSort.setBounds(30, 390, 120, 30);
		
		//removeodd
		btnRemoveOdd = new JButton("Remove Odd");
		btnRemoveOdd.setBounds(160, 390, 120, 30);
		
		//index of
		lblIndexOf = new JLabel("Number: ");
		lblIndexOf.setBounds(30, 220, 80, 30);
		textFieldIndexOf = new JTextField();
		textFieldIndexOf.setBounds(30, 250, 80, 30);
		btnIndexOf = new JButton("Index of");
		btnIndexOf.setBounds(210, 250, 85, 30);
		
		
		
		//add
		obj.add(lbl);
		obj.add(lbl1);
		obj.add(lbl2);
		obj.add(lbl3);
		obj.add(lbl4);
		obj.add(lblIndexOf);
		obj.add(btnIndexOf);
		obj.add(textFieldIndexOf);
		obj.add(textFieldAddIndex);
		obj.add(textFieldAddNumber);
		obj.add(btnAdd);
		obj.add(textFieldRemoveIndex);
		obj.add(btnRemove);
		obj.add(lblMax);
		obj.add(lblMin);
		obj.add(lblAverage);
		obj.add(lblSum);
		obj.add(btnSort);
		obj.add(btnRemoveOdd);
		
		btnAdd.addActionListener(this);
		btnRemove.addActionListener(this);
		btnRemoveOdd.addActionListener(this);
		btnSort.addActionListener(this);
		btnIndexOf.addActionListener(this);
		
		restart();
		
		obj.setLayout(null);
		obj.setVisible(true);
		obj.setResizable(false);
		obj.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		obj.setBounds(500, 100, 400, 500);	
	}
					
	public void restart() {
		textFieldAddIndex.setText(null);
		textFieldAddNumber.setText(null);
		textFieldRemoveIndex.setText(null);
		lbl1.setText(list.size() + " = " + list.toString());
		
		if(list.max() == 0 && list.indexOf(0) == -1) {
			lblMax.setText("Max: ");
		}
		else
			lblMax.setText("Max: " + list.max());
	
		lblMin.setText("Min: " + list.min());
		lblSum.setText("Sum: " + list.sum());
		
		DecimalFormat df = new DecimalFormat("#.###");
		
		if(list.average().isEmpty())
			lblAverage.setText("Average: ");
		else
			lblAverage.setText("Average: " + df.format(Double.parseDouble(list.average())));
	}
	
	@Override
	public void actionPerformed(ActionEvent arg0) {
		
		if(arg0.getSource() == btnAdd) {
			String strIndex = textFieldAddIndex.getText().toString();
			String strNumber = textFieldAddNumber.getText().toString();
			
			if(!(strIndex.isBlank() && strNumber.isBlank()) && (onlyDigits(strIndex) && onlyDigits(strNumber))) {
				int index = Integer.parseInt(strIndex);
				int number = Integer.parseInt(strNumber);
				
				if (!(index < 0 || index > list.size())) {
					list.add(index, number);
					JOptionPane.showMessageDialog(btnAdd, index + "-д амжилттай нэмэгдлээ");
				}
				else
					JOptionPane.showMessageDialog(btnAdd, "Index-ийн утга буруу байна. Дахин оруулна уу");
				
			}
			else
				JOptionPane.showMessageDialog(btnAdd, "Та хоосон утга эсвэл үсэг оруулсан байна.");
				
			restart();
		}
		else if(arg0.getSource() == btnRemove){
			
			if(!list.isEmpty()) {
				
				String str = textFieldRemoveIndex.getText().toString();
				
				if(!(str.isBlank()) && onlyDigits(str)) {
					int index = Integer.parseInt(str);
		
					
					if (!(index < 0 || index >= list.size())) {
						list.remove(index);
						JOptionPane.showMessageDialog(btnRemove, index + "-тэй тоо амжилттай устгагдлаа");
					}
					else
						JOptionPane.showMessageDialog(btnRemove, "Таны оруулсан index буруу байна. Шалгаад дахин оруулна уу");
				
				}
				else
					JOptionPane.showMessageDialog(btnAdd, "Та хоосон утга эсвэл үсэг оруулсан байна.");
				
				restart();
			}
			else
				JOptionPane.showMessageDialog(btnRemove, "ArrayLinearList-д элемент алга байна. Элемент нэмнэ үү");
			
		}
		else if(arg0.getSource() == btnIndexOf) {
			if(!list.isEmpty()) {
				String str = textFieldIndexOf.getText().toString();
				
				if(!(str.isBlank()) && onlyDigits(str)) {
					int number = Integer.parseInt(str);
					int indexOf = list.indexOf(number);
					
					if (indexOf == -1)
						JOptionPane.showMessageDialog(btnIndexOf, "Таны оруулсан тоо ArrayLinerList-д алга байна.");
					else
						JOptionPane.showMessageDialog(btnIndexOf, "Таны оруулсан тооны index: " + indexOf);
					
				}
				else
					JOptionPane.showMessageDialog(btnAdd, "Та хоосон утга эсвэл үсэг оруулсан байна.");
				
				restart();
			}
			else
				JOptionPane.showMessageDialog(btnIndexOf, "ArrayLinearList хоосон байна.");
			
			textFieldIndexOf.setText(null);;
			
		}
		else if(arg0.getSource() == btnSort) {
			list.sort();
			restart();
		}
		else if(arg0.getSource() == btnRemoveOdd) {
			list.removeOdd();
			restart();
		}
	}

	boolean onlyDigits(String str) {
		if(str.contains("--"))
			return false;
		return Pattern.matches("[0-9-]+", str);
		
	}
	
}
