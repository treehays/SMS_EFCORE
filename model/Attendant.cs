using SMS.model;

public class Attendant : User
{
    // public int Id { get; set; }
    public string Post { get; set; }
    public Attendant(int id,string staffId, string firstName, string lastName, string email, string phoneNumber, string pin, string post) : base(id,staffId, firstName, lastName, email, phoneNumber, pin)
    {
        Post = post;
    }

}