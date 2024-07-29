class Program
{
    static void Main(string[] args)
    {
        Person student1 = new Person(); // Person sınıfını kullanarak bir nesne oluşturma
        student1.Name = "Ali Berkay"; // public property sayesinde isim ataması yaptık.
        student1.Surname = "Berber";  // public property sayesinde soyad ataması yaptık.
        student1.DateTime = new DateTime(1997,6,17,18,30,50); // public property sayesinde doğum tarihi ataması yaptık.

        System.Console.WriteLine($"Benim adım {student1.Name} {student1.Surname} ve doğum tarihim ve saaatim  {student1.DateTime}"); // Oluşturduğumuz nesneyi public propertyler sayesinde console yazdırdık

        Person student2 = new Person(); // Person sınıfını kullanarak bir nesne oluşturma
        student2.Name = "Ali"; // public property sayesinde isim ataması yaptık.
        student2.Surname = "Veli"; // public property sayesinde soyad ataması yaptık.
        student2.DateTime = new DateTime(1998,12,12,10,6,12); // public property sayesinde doğum tarihi ataması yaptık.

        System.Console.WriteLine($"Benim adım {student2.Name} {student2.Surname} ve doğum tarihim ve saaatim  {student2.DateTime}"); // Oluşturduğumuz nesneyi public propertyler sayesinde console yazdırdık

        Person teacher1 = new Person(); // Person sınıfını kullanarak bir nesne oluşturma

        teacher1.Name = "Travis"; // public property sayesinde isim ataması yaptık.
        teacher1.Surname = "Scott"; // public property sayesinde soyad ataması yaptık.
        teacher1.DateTime = new DateTime(1993,6,10,8,45,30); // public property sayesinde doğum tarihi ataması yaptık.

        System.Console.WriteLine($"Benim adım {teacher1.Name} {teacher1.Surname} ve doğum tarihim ve saaatim  {teacher1.DateTime}");  // Oluşturduğumuz nesneyi public propertyler sayesinde console yazdırdık


        Person teacher2 = new Person(); // Person sınıfını kullanarak bir nesne oluşturma

        teacher2.Name = "Jack"; // public property sayesinde isim ataması yaptık.
        teacher2.Surname = "Harlow"; // public property sayesinde soyad ataması yaptık.
        teacher2.DateTime = new DateTime(2000,01,01,05,30,45); // public property sayesinde doğum tarihi ataması yaptık.

        System.Console.WriteLine($"Benim adım {teacher2.Name} {teacher2.Surname} ve doğum tarihim ve saaatim  {teacher2.DateTime}"); // Oluşturduğumuz nesneyi public propertyler sayesinde console yazdırdık

    }   
}


class Person
{
    private string name;
    private string surname;
    private DateTime dateTime;

    public string Name{
        get{ return name ;} // oluşturulan nesne değeri sorgularsa name değerini döner
        set{ name = value;} // oluşturulan nesneye bir değer atamak için 
    }
    public string Surname {
        get{ return surname;} // oluşturulan nesne değeri sorgularsa surname değerini döner
        set{ surname = value;} // oluşturulan nesneye bir değer atamak için 
    }
    public DateTime DateTime{
        get{return dateTime;} // oluşturulan nesne değeri sorgularsa dateTime değerini döner
        set{dateTime = value;} // oluşturulan nesneye bir değer atamak için 
    }
}
