
public class InstructorManager {
	
	public void add(Instructor instructor, Logger logger) {
		System.out.println(instructor.firstName + " "+ instructor.lastName + " Eğitimcisi eklendi");
	}
	
	public void delete(Instructor instructor, Logger logger) {
		System.out.println(instructor.firstName + " "+ instructor.lastName + " Eğitimcisi silindi");
	}
	
	public void update(Instructor instructor, Logger logger) {
		System.out.println(instructor.firstName + " "+ instructor.lastName + " Eğitimcisi güncellendi");
	}
}