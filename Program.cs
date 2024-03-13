Console.WriteLine("## PACS - Sistema de Controle de Acesso ##\n");

// DEFININDO TELA INICIAL PARA ACESSAR O SISTEMA
Console.WriteLine("SELECIONE UMA DAS OPÇÕES ABAIXO:");
Console.WriteLine("################################");
Console.WriteLine("1 - ACESSAR O SISTEMA");
Console.WriteLine("2 - CADASTRAR USUARIO");
Console.WriteLine("3 - VERIFICAR MEU ACESSO");
Console.WriteLine("4 - SAIR\n");

// CAPTURANDO ESCOLHA DO USUARIO
int? opcaoSelecionadaDoMenuInicial = Convert.ToInt32(Console.ReadLine());

// VERIFICAR SE A OPÇAO É VÁLIDA

if(opcaoSelecionadaDoMenuInicial == 1) {
    // FAÇA ISSO
    Console.Clear();
    Console.WriteLine("## PACS - Sistema de Controle de Acesso ##\n");

    Console.WriteLine("INSIRA A SUA CHAVE SECRETA PARA ACESSAR O SISTEMA");
    
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
        Console.WriteLine($"TIPO DE CARACTER INVÁLIDO. ERROR => {e}");
    }

} else if(opcaoSelecionadaDoMenuInicial == 2) {
    // FAÇA ISSO
    Console.WriteLine("OPÇÃO SELECIONADA COM SUCESSO");
} else if(opcaoSelecionadaDoMenuInicial == 3) {
    // FAÇA ISSO
    Console.WriteLine("OPÇÃO SELECIONADA COM SUCESSO");
} else if(opcaoSelecionadaDoMenuInicial == 4) {
    // FAÇA ISSO
    Console.WriteLine("OPÇÃO SELECIONADA COM SUCESSO");
} 

Console.ReadKey();