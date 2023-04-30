namespace ToDoList.Models
{
    public class TaskItem
    {
        public int ID { get; set; }
        public String Description { get; set; }

        public DateTime DueDate { get; set; }

        public int Priority { get; set; }
        public bool IsComplete { get; set; }



    }
}
