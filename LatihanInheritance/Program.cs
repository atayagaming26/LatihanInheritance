Siswa siswaObj = new Siswa("ataya", "ataya@gmail.com", "1111", "Siswa", "XPG2");
Guru guruObj = new Guru("bobi", "bobi@gmail.com", "232323", "Guru", " TIK");

siswaObj.TampilkanInfo();
siswaObj.SubmitTugas();

Console.WriteLine();

guruObj.TampilkanInfo();
guruObj.NilaiTugas();



class User
{
    public string Nama;

    public string Email;

    public string Password;

    public string Role;

    public User(string nama, string email, string password, string role)
    {
        Nama= nama;
        Email= email;
        Password= password;
        Role= role;
    }
    
    public void TampilkanInfo()
    {
        Console.WriteLine("Menampilkan info user...");
        Console.WriteLine($"Nama: {Nama}");
        Console.WriteLine($"Role: {Role}");
    }
}

class Siswa : User
{
    public string ClassName;

    public Siswa(string nama, string email, string password, string role, string classsname) : base(nama, email, password, role)
    {
        ClassName= classsname;
    }
    public void SubmitTugas()
    {
        Console.WriteLine($"Siswa {Nama} sudah mengumpulkan semua tugas");
    }

}

class Guru : User
{
    public string Mapel;
    public Guru(string nama, string email, string password, string role, string mapel) : base(nama, email, password, role)
    {

        Mapel= mapel;
    }

    public void NilaiTugas()
    {
        Console.WriteLine($"Guru {Nama} sudah menilai semua tugas{Mapel}");
    }
}
