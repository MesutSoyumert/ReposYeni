
public class InstructorManager {
	
	public void add(Instructor instructor, Logger logger) {
		System.out.println(instructor.firstName + " "+ instructor.lastName + " E�itimcisi eklendi");
		logger.log();
	}
	
	public void delete(Instructor instructor, Logger logger) {
		System.out.println(instructor.firstName + " "+ instructor.lastName + " E�itimcisi silindi");
		logger.log();
	}
	
	public void update(Instructor instructor, Logger logger) {
		System.out.println(instructor.firstName + " "+ instructor.lastName + " E�itimcisi g�ncellendi");
		logger.log();
	}
}