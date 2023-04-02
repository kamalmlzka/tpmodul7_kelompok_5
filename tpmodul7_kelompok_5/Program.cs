using System.Text.Json;
public class Program
{
    public static DataMahasiswa_1302210104<T> readJSON<T>(string filename)
    {
        string posisifolder = ".";
        string hasilbaca = File.ReadAllText(posisifolder + "\\" + filename);
        return JsonSerializer.Deserialize<DataMahasiswa_1302210104<T>>(hasilbaca);
    }

    public static KuliahMahasiswa_1302210078 readJSON(string filename)
    {
        string posisifolder = ".";
        string hasilbaca = File.ReadAllText(posisifolder + "\\" + filename);
        return JsonSerializer.Deserialize<KuliahMahasiswa_1302210078>(hasilbaca);
    }
    public static Dosen1 readJSONdosen(string filename)
    {
        string posisifolder = ".";
        string hasilbaca = File.ReadAllText(posisifolder + "\\" + filename);
        return JsonSerializer.Deserialize<Dosen1>(hasilbaca);

    }

    private static void Main(string[] args)
    { 
        DataMahasiswa_1302210104<int> ObjMhs = readJSON<int>("tp7_1_1302210104.json");
        for (int i = 0; i < ObjMhs.nama.Count; i++)
        {
            Console.WriteLine("Nama " + ObjMhs.nama[i].depan + " " + ObjMhs.nama[i].belakang + " dengan nim " + ObjMhs.nim[i] + " dari fakultas " + ObjMhs.fakultas);
        }
        Console.WriteLine();

        KuliahMahasiswa_1302210078 KM = readJSON("tp7_2_1302210078.json");
        Dosen1 Dospeng = readJSONdosen("tp7_3_1302213058.json");
        for (int i = 0; i < KM.courses.Count;i++)
        {
            Console.WriteLine("MK " + (i + 1) + " " + KM.courses[i].code + " - " + KM.courses[i].name + " (SE-45-03) " +"["+ Dospeng.Dosen[i].CoDos + "]");
        }
        for (int i = 0; i < Dospeng.Dosen.Count; i++) { }

    }
    
    
}