void NomeSistema(){
    Console.WriteLine("## PACS - Sistema de Controle de Acesso ##\n");
}

void MenuIncial(){
    Console.WriteLine("SELECIONE UMA DAS OPÇÕES ABAIXO:");
    Console.WriteLine("################################");
    Console.WriteLine("1 - ACESSAR O SISTEMA");
    Console.WriteLine("2 - CADASTRAR USUARIO");
    Console.WriteLine("3 - VERIFICAR MEU ACESSO");
    Console.WriteLine("4 - SAIR\n");
}

void LimparTela(){
    Console.Clear();
}

NomeSistema();
MenuIncial();

Dictionary<string, long> dBAcessos = new Dictionary<string, long>();

dBAcessos.Add("ch1", 1231213132231);
dBAcessos.Add("ch2", 9834567895264);
dBAcessos.Add("ch3", 4895758132469);
dBAcessos.Add("ch4", 2457478964521);

try {
    // CAPTURANDO ESCOLHA DO USUARIO
    int? opcaoSelecionadaDoMenuInicial = Convert.ToInt32(Console.ReadLine());

    // VERIFICAR SE A OPÇAO É VÁLIDA
    if(opcaoSelecionadaDoMenuInicial == 1) {

        LimparTela();
        NomeSistema();
        Console.WriteLine("INSIRA A SUA CHAVE SECRETA PARA ACESSAR O SISTEMA");
        
        // REALIZANDO UM TRATAMENTO DE ERRO PARA QUE O SISTEMA NÃO APRESENTE O
        // ERRO DIRETAMENTE PARA O USUÁRIO
        try{
            long? secretKey = Convert.ToInt64(Console.ReadLine());

            foreach(KeyValuePair<string, long> vkp in dBAcessos) {
                Console.WriteLine($"Chave {vkp.Key}: {vkp.Value}");
            }
            
        } catch(Exception e) {
            Console.WriteLine($"TIPO DE CARACTER INVÁLIDO. ERROR => {e.Message}");
        }

    } else if(opcaoSelecionadaDoMenuInicial == 2) {
        
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
            Console.WriteLine("TUDO ERRADO!");
        }

    } else if(opcaoSelecionadaDoMenuInicial == 3) {
        // FAÇA ISSO
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



    } else if(opcaoSelecionadaDoMenuInicial == 4) {
        // FAÇA ISSO
        Console.WriteLine("TCHAU :)");
        Environment.Exit(0);
    } 
} catch (Exception e) {
    Console.WriteLine("OPÇÃO SELECIONADA ESTÁ INCORRETA! " + e.Message);
}

Console.ReadKey();