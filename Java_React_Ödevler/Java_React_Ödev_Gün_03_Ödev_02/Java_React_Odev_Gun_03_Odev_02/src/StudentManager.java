
public class StudentManager {
	
	public void add(Student student, Logger logger) {
		System.out.println(student.firstName + " "+ student.lastName + " ��rencisi eklendi");
		logger.log();
	}
	
	public void delete(Student student, Logger logger) {
		System.out.println(student.firstName + " "+ student.lastName + " ��rencisi silindi");
		logger.log();
	}
	
	public void update(Student student, Logger logger) {
		System.out.println(student.firstName + " "+ student.lastName + " ��rencisi g�ncellendi");
		logger.log();
	}
}