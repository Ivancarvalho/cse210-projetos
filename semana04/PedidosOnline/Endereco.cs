using System;

public class Endereco
{
    private string _rua;
    private string _cidade;
    private string _estado;
    private string _pais;

    public Endereco(string rua, string cidade, string estado, string pais)
    {
        _rua = rua;
        _cidade = cidade;
        _estado = estado;
        _pais = pais;
    }

    public bool EhNosEUA()
    {
        string paisNormalizado = _pais.Trim().ToUpper();
        return paisNormalizado == "USA" || paisNormalizado == "EUA" || paisNormalizado == "UNITED STATES" || paisNormalizado == "ESTADOS UNIDOS";
    }

    public string ObterEnderecoCompleto()
    {
        return $"{_rua}\n{_cidade}, {_estado}\n{_pais}";
    }
}