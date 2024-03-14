Console.WriteLine("## PACS - Sistema de Controle de Acesso ##\n");

// DEFININDO TELA INICIAL PARA ACESSAR O SISTEMA
Console.WriteLine("SELECIONE UMA DAS OPÇÕES ABAIXO:");
Console.WriteLine("################################");
Console.WriteLine("1 - ACESSAR O SISTEMA");
Console.WriteLine("2 - CADASTRAR USUARIO");
Console.WriteLine("3 - VERIFICAR MEU ACESSO");
Console.WriteLine("4 - SAIR\n");

try {
    // CAPTURANDO ESCOLHA DO USUARIO
    int? opcaoSelecionadaDoMenuInicial = Convert.ToInt32(Console.ReadLine());

    // VERIFICAR SE A OPÇAO É VÁLIDA
    if(opcaoSelecionadaDoMenuInicial == 1) {
        // FAÇA ISSO
        Console.Clear();
        Console.WriteLine("## PACS - Sistema de Controle de Acesso ##\n");

        Console.WriteLine("INSIRA A SUA CHAVE SECRETA PARA ACESSAR O SISTEMA");
        
        // REALIZANDO UM TRATAMENTO DE ERRO PARA QUE O SISTEMA NÃO APRESENTE O
        // ERRO DIRETAMENTE PARA O USUÁRIO
        try{
            long? secretKey = Convert.ToInt64(Console.ReadLine());

            if(secretKey == 3964686216615814260) {
                Console.Clear();
                Console.WriteLine("ACESSO LIBERADO!");
            } else {
                Console.Clear();
                Console.WriteLine("ACESSO NEGADO!");
            }
        } catch(Exception e) {
            Console.WriteLine($"TIPO DE CARACTER INVÁLIDO. ERROR => {e.Message}");
        }

    } else if(opcaoSelecionadaDoMenuInicial == 2) {
        
        Console.Clear();
        Console.WriteLine("INSIRA A SUA CHAVE DE ADMINISTRADOR PARA CADASTRAR USUÁRIO");
        Console.WriteLine("##########################################################");
        
        try {
            
            // PEGANDO (GET) O VALOR DIGITADO PELO O USUARIO
            long? keyAdmUser = Convert.ToInt64(Console.ReadLine());
            
            if(keyAdmUser == 123456) {
                Console.Clear();
                Console.WriteLine("ACESSO LIBERADO PARA CADASTRAR USUARIOS");
                
                // DESENVOLVER SISTEMA PARA CADASTRAR USUARIO
            } else {
                Console.Clear();
            }

        } catch(Exception e) {
            Console.WriteLine("TUDO ERRADO!");
        }

    } else if(opcaoSelecionadaDoMenuInicial == 3) {
        // FAÇA ISSO
        Console.Clear();
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