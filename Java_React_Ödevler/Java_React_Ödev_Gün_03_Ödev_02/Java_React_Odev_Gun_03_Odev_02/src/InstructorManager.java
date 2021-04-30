
public class InstructorManager {
	
	public void add(Instructor instructor, Logger logger) {
		System.out.println(instructor.firstName + " "+ instructor.lastName + " Eðitimcisi eklendi");
		logger.log();
	}
	
	public void delete(Instructor instructor, Logger logger) {
		System.out.println(instructor.firstName + " "+ instructor.lastName + " Eðitimcisi silindi");
		logger.log();
	}
	
	public void update(Instructor instructor, Logger logger) {
		System.out.println(instructor.firstName + " "+ instructor.lastName + " Eðitimcisi güncellendi");
		logger.log();
	}
}