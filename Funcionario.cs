
public class Funcionario()
{

    private int id_Funcionario;
    private string nome_Funcionario;
    private string funcao_Funcionario;
    private double salario_Funcionario;

    public int Id_Funcionario
    {
        get => id_Funcionario;
        set => id_Funcionario = value;
    }
    public string Nome_Funcionario
    {
        get => nome_Funcionario;
        set => nome_Funcionario = value;
    }
    public double Salario_Funcionario
    {
        get => salario_Funcionario;
        set => salario_Funcionario = (double)value;
    }
    public string Funcao_Funcionario
    {
        get => funcao_Funcionario;
        set => funcao_Funcionario = value;

    }

    public int CadastraFuncionario(int _id,
     string _nome, double _salario, string _funcao)
    {
        Id_Funcionario = _id;
        Nome_Funcionario = _nome;
        Salario_Funcionario = _salario;
        Funcao_Funcionario = _funcao;
        return 0;
    }

}