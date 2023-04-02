public class Nama
{
    public string depan { get; set; }
    public string belakang { get; set; }

    public Nama(string depan, string belakang)
    {
        this.depan = depan;
        this.belakang = belakang;
    }
    public Nama() { }
}

public class DataMahasiswa_1302210104<T>
{
    public List<Nama> nama { get; set; }
    public List<T> nim { get; set; }
    public string fakultas { get; set; }

    public DataMahasiswa_1302210104(List<Nama> nama, List<T> nim, string fakultas)
    {
        this.nama = nama;
        this.nim = nim;
        this.fakultas = fakultas;
    }

    public DataMahasiswa_1302210104() { }
}