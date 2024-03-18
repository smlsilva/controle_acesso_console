namespace ControleAcesso.Cadastrar;

class Cadastrar {

    private long chaveUsuario { get; set; }
    private string? listDeValores;
    
    Dictionary<string, long?> dbChaves = new Dictionary<string, long?>();

    // SET VARIAVEL CHAVEUSUARIO
    public void setchaveUsuario(long chave) {
        this.chaveUsuario = chave;
    }

    // PEGAR E INSERIR CHAVE DO USUARIO NO DICIONARIO
    public long getchaveUsuario() {
        return this.chaveUsuario;
    }

    public void AddChaveDeUsuario(long chave) {
        this.dbChaves.Add($"chave#{this.chaveUsuario}",chave);
        Console.WriteLine("Chave Cadastrada com Sucesso!\n");
    }

    public void ListarChavesCadastradas() {

        foreach(KeyValuePair<string, long?> kwp in this.dbChaves){
            this.listDeValores += $"Chave {kwp.Key}: {kwp.Value}";
        }

        Console.WriteLine(this.listDeValores);

    }
}