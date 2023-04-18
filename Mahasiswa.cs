namespace modul9_1302213005
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public int NIM { get; set; }

        public List<string> Courses { get; set; }

        public int Year { get; set; }
        public Mahasiswa(string nama, int nim, List<string> courses, int year)
        {
            this.Nama = nama;
            this.NIM = nim;
            Courses = courses;
            Year = year;
        }
    }
}
