
using SMS.model;

public class Admin : User
    {
        // public int Id { get; set; }
        public string Post { get; set; }
        // public decimal Wallet { get; set; }
        public Admin(int id,string staffId, string firstName, string lastName, string email, string phoneNumber, string pin, string post) : base(id,staffId, firstName, lastName, email, phoneNumber, pin)
        {
            Post = post;
        }
       
    }
