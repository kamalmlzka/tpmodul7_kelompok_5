using System.Text.Json;

public class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa_1302210104<int> ObjMhs = readJSON<int>("tp7_1_1302210104.json");
        Console.WriteLine("Nama " + ObjMhs.nama.depan + " " + ObjMhs.nama.belakang + " dengan nim " + ObjMhs.nim + " dari fakultas " + ObjMhs.fakultas);
    }
    public static DataMahasiswa_1302210104<T> readJSON<T>(string filename)
    {
        string posisifolder = "C:\\Users\\ASUS\\OneDrive\\Documents\\Iqnaz\\KPL\\TPMOD7\\tpmodul7_kelompok_5\\tpmodul7_kelompok_5";
        string hasilbaca = File.ReadAllText(posisifolder + "\\" + filename);
        return JsonSerializer.Deserialize<DataMahasiswa_1302210104<T>>(hasilbaca);
    }
}