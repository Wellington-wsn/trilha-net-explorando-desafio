namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() { }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    public List<Pessoa> Hospedes = new List<Pessoa>();

    public void NovoHospede()
    {
        Console.WriteLine("Nome do hóspede:");
        string nome = Console.ReadLine();

        Console.WriteLine("sobrenome do hóspede:");
        string sobrenome = Console.ReadLine();

        Hospedes.Add(new Pessoa(nome, sobrenome));
        Console.WriteLine("Cadastrado Completo!");
    }

}