
public class Main {

	public static void main(String[] args) {
		
		User user = new User();
		UserManager userManager = new UserManager();
		user.id = 1;
		user.firstName = "Mesut";
		user.lastName = "Soyumert";
		user.email = "mesut@soyumert.com";
		user.salary = 5000;
		user.lastLogin = "kodlama.io yönetim sayfasý";
		
		userManager.add(user, new EmailLogger());

		user.id = 1;
		user.firstName = "Mesut";
		user.lastName = "Soyumert";
		user.email = "mesut@soyumert.com";
		user.salary = 15000;
		user.lastLogin = "kodlama.io giriþ sayfasý";
		
		userManager.delete(user, new EmailLogger());
		
		user.id = 1;
		user.firstName = "Mesut";
		user.lastName = "Soyumert";
		user.email = "mesut@soyumert.com";
		user.salary = 15000;
		user.lastLogin = "kodlama.io giriþ sayfasý";
		
		userManager.update(user, new EmailLogger());
		
		
		Student student = new Student();
		StudentManager studentManager = new StudentManager();
		
		student.id = 10;
		student.firstName = "Mesut";
		student.lastName = "Soyumert";
		student.email = "mesut@soyumert.com";
		student.Address = "Ankara";
		student.activeMembership = "email";
		student.cardInfo = "1234 5678 9012 3456";
		student.informationPreference = "dont sent email";
		student.trainingName = "Yazýlým Geliþtirici Yetiþtirme Kampý (JAVA + REACT)";
		student.trainingCompletionPercent = 48;
		
		studentManager.add(student, new DatabaseLogger());
		
		student.id = 10;
		student.firstName = "Mesut";
		student.lastName = "Soyumert";
		student.email = "mesut@soyumert.com";
		student.Address = "Ankara";
		student.activeMembership = "email";
		student.cardInfo = "1234 5678 9012 3456";
		student.informationPreference = "dont sent email";
		student.trainingName = "Yazýlým Geliþtirici Yetiþtirme Kampý (JAVA + REACT)";
		student.trainingCompletionPercent = 48;
		
		studentManager.delete(student, new DatabaseLogger());
		
		student.id = 10;
		student.firstName = "Mesut";
		student.lastName = "Soyumert";
		student.email = "mesut@soyumert.com";
		student.Address = "Ankara";
		student.activeMembership = "email";
		student.cardInfo = "6543 2109 8765 4321";
		student.informationPreference = "sent email";
		student.trainingName = "Yazýlým Geliþtirici Yetiþtirme Kampý (JAVA + REACT)";
		student.trainingCompletionPercent = 48;
		
		studentManager.update(student, new DatabaseLogger());
		
		Instructor instructor = new Instructor();
		InstructorManager instructorManager = new InstructorManager();
		
		instructor.id = 15;
		instructor.firstName = "Engin";
		instructor.lastName = "Demiroð";
		instructor.email = "engin@demirog.com";
		instructor.salary = 500000;
		instructor.TrainingName = "Yazýlým Geliþtirici Yetiþtirme Kampý (JAVA + REACT)";
		
		instructorManager.add(instructor, new FileLogger());
		
		instructor.id = 15;
		instructor.firstName = "Engin";
		instructor.lastName = "Demiroð";
		instructor.email = "engin@demirog.com";
		instructor.salary = 500000;
		instructor.TrainingName = "Yazýlým Geliþtirici Yetiþtirme Kampý (JAVA + REACT)";
		
		instructorManager.delete(instructor, new FileLogger());
		
		instructor.id = 15;
		instructor.firstName = "Engin";
		instructor.lastName = "Demiroð";
		instructor.email = "engin@demirog.com";
		instructor.salary = 500000;
		instructor.TrainingName = "Yazýlým Geliþtirici Yetiþtirme Kampý (JAVA + REACT)";
		
		instructorManager.update(instructor, new FileLogger());
	}
}