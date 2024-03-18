using ControleAcesso.Cadastrar;

void Programa(){
    try
    {
        LimparTela();
        Console.WriteLine("## PACS - Sistema de Controle de Acesso ##\n");
        MenuInicial();
        int? opcaoSelecionadaDoMenuInicial = Convert.ToInt32(Console.ReadLine());

        switch(opcaoSelecionadaDoMenuInicial) {
            case 1:
                LimparTela();
                LoginAdm();
                break;
            case 2:
                LimparTela();
                Console.WriteLine("INSIRA A SUA CHAVE DE ADMINISTRADOR PARA CADASTRAR USUÁRIO");
                Console.WriteLine("##########################################################");
                
                try {
                    
                    // PEGANDO (GET) O VALOR DIGITADO PELO O USUARIO
                    long? keyAdmUser = Convert.ToInt64(Console.ReadLine());
                    
                    if(keyAdmUser == 123456) {
                        LimparTela();
                        Console.WriteLine("ACESSO LIBERADO PARA CADASTRAR USUARIOS");
                        
                        // DESENVOLVER SISTEMA PARA CADASTRAR USUARIO
                    } else {
                        LimparTela();
                    }

                } catch(Exception e) {
                    Console.WriteLine("TUDO ERRADO!" + e.Message);
                }
                break;
            case 3:
                LimparTela();
                Console.WriteLine("INFORME A SUA CHAVE SECRETA PARA VERIFICAR O SEU ACESSO");

                try {
                    long? secretKeyUser = Convert.ToInt64(Console.ReadLine());

                    // VERIFICANDO SE A CHAVE ESTÁ COM ACESSO OU NÃO
                    if(secretKeyUser == 123121321313) {
                        Console.WriteLine("ACESSO LIBERADO");
                    } else {
                        Console.WriteLine("ACESSO NÃO ENCONTRADO");
                    }

                } catch(Exception e) {
                    Console.WriteLine("Chave incorreta digite novamente " + e.Message);
                }
                break;
            case 4:
                Console.WriteLine("TCHAU :)");
                Environment.Exit(0);
                break;
            default:
                break;
        }
    }
    catch (Exception error)
    {
        Console.WriteLine($"Error => {error.Message}");
    }
    
}

void LoginAdm() {
    try{
        Console.WriteLine("Coloque o seu Login:");
        string? loginAdm = Console.ReadLine();

        Console.WriteLine("\nInsira a sua senha:");
        long secretKey = Convert.ToInt64(Console.ReadLine());

        Cadastrar cadastro = new Cadastrar();
        cadastro.setloginUsuario(loginAdm);

        if(!cadastro.VerificarUsuarioExistente(cadastro.getloginUsuario())) {
            Console.WriteLine("Login não encontrado!\n");

            Console.WriteLine("PRESSIONE ALGUMA TECLA PARA SEGUIR");
            Console.ReadKey();

            Programa();
        } else {
            // VERIFICAR SENHA PARA ENTRAR NO SISTEMA
            cadastro.setchaveUsuario(secretKey);
            if(cadastro.ChecarCredenciaisUsuario()){
                LimparTela();
                Console.WriteLine("ACESSO LIBERADO!");
            } else {
                LimparTela();
                Console.WriteLine("USUARIO OU SENHA ESTÃO INCORRETOS!");

                Console.WriteLine("PRESSIONE A TECLA 'R' PARA CONTINUAR");
                Console.ReadKey();

                LoginAdm();
            }
        }
    } catch(Exception e) {
        Console.WriteLine($"TIPO DE CARACTER INVÁLIDO. ERROR => {e.Message}");
    }
}

void MenuInicial(){
    Console.WriteLine("SELECIONE UMA DAS OPÇÕES ABAIXO:");
    Console.WriteLine("################################");
    Console.WriteLine("1 - ACESSAR O SISTEMA");
    Console.WriteLine("2 - CADASTRAR USUARIO");
    Console.WriteLine("3 - VERIFICAR MEU ACESSO");
    Console.WriteLine("4 - SAIR\n");
}

void ListarChaves() {
    Console.WriteLine("DESEJA LISTAR TODAS AS CHAVES CADASTRADAS ?");
    Console.WriteLine("################################");
    Console.WriteLine("1 - SIM");
    Console.WriteLine("2 - NÃO");
}

void LimparTela(){
    Console.Clear();
}

Programa();

Console.ReadKey();