
public class StudentManager {
	
	public void add(Student student, Logger logger) {
		System.out.println(student.firstName + " "+ student.lastName + " ��rencisi eklendi");
	}
	
	public void delete(Student student, Logger logger) {
		System.out.println(student.firstName + " "+ student.lastName + " ��rencisi silindi");
	}
	
	public void update(Student student, Logger logger) {
		System.out.println(student.firstName + " "+ student.lastName + " ��rencisi g�ncellendi");
	}
}