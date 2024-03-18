namespace ControleAcesso.Cadastrar;

class Cadastrar {

    private long chaveUsuario { get; set; }
    private string? loginUsuario { get; set; }
    private string? listDeValores;
    private bool status;
    
    Dictionary<string, long?> dbChaves = new Dictionary<string, long?>();

    public void setloginUsuario(string? loginUsuario) {
        this.loginUsuario = loginUsuario;
    }

    public string getloginUsuario() {
        return this.loginUsuario;
    }

    // SET VARIAVEL CHAVEUSUARIO
    public void setchaveUsuario(long chave) {
        this.chaveUsuario = chave;
    }

    // PEGAR E INSERIR CHAVE DO USUARIO NO DICIONARIO
    public long getchaveUsuario() {
        return this.chaveUsuario;
    }

    public bool VerificarUsuarioExistente(string loginUsuario){
        if(this.dbChaves.ContainsKey(loginUsuario)){
            this.status = true;
        } else {
            this.status = false;
        }
        return this.status;
    }

    public bool ChecarCredenciaisUsuario() {
        foreach(KeyValuePair<string, long?> kwp in dbChaves) {
            if(kwp.Key == this.loginUsuario) {
                this.status = kwp.Value == this.chaveUsuario ? true : false;
            }
        }
        return this.status;
    }
    public void AddUsuarioNaLista(long chave) {
        this.dbChaves.Add($"chave#{this.chaveUsuario}",chave);
        Console.WriteLine("Chave Cadastrada com Sucesso!\n");
    }

    public void ListarUsuariosCadastrados() {

        foreach(KeyValuePair<string, long?> kwp in this.dbChaves){
            this.listDeValores += $"Usuario: {kwp.Key}";
        }

        Console.WriteLine(this.listDeValores);

    }
}