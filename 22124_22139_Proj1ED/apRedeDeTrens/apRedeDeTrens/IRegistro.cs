//Nome: Clara Andrade Sant'Anna Santos RA:22124
//Nome: Julia Enriquetto de Brito      RA:22139 

public interface IRegistro
{
    void LerRegistro(BinaryReader arquivo, long qualRegistro);
    int TamRegistro { get;  }
    void GravarRegistro(BinaryWriter arquivo);
}
