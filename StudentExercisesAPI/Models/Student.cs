namespace StudentExercisesAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int CohortId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }

    }
}
