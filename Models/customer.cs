namespace AMBA_PRELIM_LAB2.Models
{
    public class customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }

        // Read-only property
        public string FullName => $"{FirstName} {LastName}";
    }
}

