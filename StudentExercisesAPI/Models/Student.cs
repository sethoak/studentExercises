namespace StudentExercisesAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int cohortId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string slackHandle { get; set; }

    }
}
