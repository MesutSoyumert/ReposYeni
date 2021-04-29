
public class StudentManager {
	
	public void add(Student student, Logger logger) {
		System.out.println(student.firstName + " "+ student.lastName + " Öğrencisi eklendi");
	}
	
	public void delete(Student student, Logger logger) {
		System.out.println(student.firstName + " "+ student.lastName + " Öğrencisi silindi");
	}
	
	public void update(Student student, Logger logger) {
		System.out.println(student.firstName + " "+ student.lastName + " Öğrencisi güncellendi");
	}
}