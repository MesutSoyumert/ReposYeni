
public class StudentManager {
	
	public void add(Student student, Logger logger) {
		System.out.println(student.firstName + " "+ student.lastName + " Öðrencisi eklendi");
	}
	
	public void delete(Student student, Logger logger) {
		System.out.println(student.firstName + " "+ student.lastName + " Öðrencisi silindi");
	}
	
	public void update(Student student, Logger logger) {
		System.out.println(student.firstName + " "+ student.lastName + " Öðrencisi güncellendi");
	}
}