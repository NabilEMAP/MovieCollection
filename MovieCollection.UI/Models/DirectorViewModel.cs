namespace MovieCollection.UI.Models
{
    public class DirectorViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string IsActive { get; set; }
        public string PicturePath { get; set; }

        public string Fullname
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
    }
}
