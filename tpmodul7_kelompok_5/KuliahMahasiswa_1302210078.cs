using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
public class KuliahMahasiswa_1302210078
{
    public List<Courses> courses { get; set; }

    public KuliahMahasiswa_1302210078(List<Courses> Course)
	{
		this.courses = Course;
	}
	
    public KuliahMahasiswa_1302210078() { }
}

public class Courses
{
	public string name { get; set; }
	public string code { get; set; }

	public Courses() { }
	public Courses(string name, string code)
	{
		this.name = name;
		this.code = code;
	}

}
public class Dosen1
{
    public List<CodeDosen> Dosen { get; set; }

    public Dosen1() { }
    public Dosen1(List<CodeDosen> CoDos)
    {
        this.Dosen = CoDos;
    }
}
public class CodeDosen
{
    public string CoDos { get; set; }
    public CodeDosen() { }
    public CodeDosen(string coDos)
    {
        CoDos = coDos;
    }
}