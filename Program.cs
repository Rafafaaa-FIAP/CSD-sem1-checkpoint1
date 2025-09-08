namespace CheckPoint1;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== CHECKPOINT 1 - FUNDAMENTOS C# - Turma  3ESPY ===\n");

        // ENTREGA ATÉ DIA 08/09 AS 23:59
        // Você deve criar um repositório público ou branch no github e me enviar o link pelo
        // teams antes do fim do prazo.
        // IMPORTANTE:
        // - Não haverá reposição do checkpoint.
        // - Fique atento ao prazo, nenhum trabalho será aceito após a data e vou me basear
        // - O link do seu git deve ser enviado no teams. A data e hora do recebimento do git será utilizada para verificar se foi enviado no prazo.
        // 
        
        // TODO: Implemente as chamadas de teste para demonstrar funcionamento
        // NÃO é obrigatório testar todos os caminhos/casos - apenas mostrar que funciona
        // Use valores de teste simples para validar cada implementação

        //  Treinem rodar o debugger.
        //  F9 - Coloca o breakpoint
        //  F10 - Passa sobre o método no passo a passo
        //  F11 - Entra nos métodos no passo a passo
        //  shift  + F11 - Volta do método

        
        
        Console.WriteLine("1. Testando DemonstrarTiposDados...");
        // Exemplo: Console.WriteLine(DemonstrarTiposDados());
        Console.WriteLine(DemonstrarTiposDados());

        Console.WriteLine("\n2. Testando CalculadoraBasica (SWITCH)...");
        // Exemplo: Console.WriteLine(CalculadoraBasica(10, 5, '+'));
        Console.WriteLine(CalculadoraBasica(10, 5, '+'));
        Console.WriteLine(CalculadoraBasica(2, 0, '/'));
        Console.WriteLine(CalculadoraBasica(2, 3, '.'));

        Console.WriteLine("\n3. Testando ValidarIdade (IF/ELSE)...");
        // Exemplo: Console.WriteLine(ValidarIdade(25));
        Console.WriteLine(ValidarIdade(-1));
        Console.WriteLine(ValidarIdade(5));
        Console.WriteLine(ValidarIdade(15));
        Console.WriteLine(ValidarIdade(23));
        Console.WriteLine(ValidarIdade(70));
        Console.WriteLine(ValidarIdade(130));

        Console.WriteLine("\n4. Testando ConverterString...");
        // Exemplo: Console.WriteLine(ConverterString("123", "int"));
        Console.WriteLine(ConverterString("123", "int"));
        Console.WriteLine(ConverterString("A", "int"));
        Console.WriteLine(ConverterString("10,5", "double"));
        Console.WriteLine(ConverterString("B", "double"));
        Console.WriteLine(ConverterString("True", "bool"));
        Console.WriteLine(ConverterString("C", "bool"));

        Console.WriteLine("\n5. Testando ClassificarNota (SWITCH)...");
        // Exemplo: Console.WriteLine(ClassificarNota(8.5));
        Console.WriteLine(ClassificarNota(-1));
        Console.WriteLine(ClassificarNota(2));
        Console.WriteLine(ClassificarNota(6));
        Console.WriteLine(ClassificarNota(8));
        Console.WriteLine(ClassificarNota(10));

        Console.WriteLine("\n6. Testando GerarTabuada (FOR)...");
        // Exemplo: Console.WriteLine(GerarTabuada(5));
        Console.WriteLine(GerarTabuada(0));
        Console.WriteLine(GerarTabuada(5));

        Console.WriteLine("\n7. Testando JogoAdivinhacao (WHILE)...");
        // Exemplo: Console.WriteLine(JogoAdivinhacao(50, new int[]{25, 75, 50}));
        Console.WriteLine(JogoAdivinhacao(50, new int[] { 25, 75, 50 }));
        Console.WriteLine(JogoAdivinhacao(75, new int[] { 25, 75, 50 }));

        Console.WriteLine("\n8. Testando ValidarSenha (DO-WHILE)...");
        // Exemplo: Console.WriteLine(ValidarSenha("MinhaSenh@123"));
        Console.WriteLine(ValidarSenha("senha"));
        Console.WriteLine(ValidarSenha("minhasenha"));
        Console.WriteLine(ValidarSenha("minhasenha123"));
        Console.WriteLine(ValidarSenha("MinhaSenha123"));
        Console.WriteLine(ValidarSenha("MinhaSenh@123"));

        Console.WriteLine("\n9. Testando AnalisarNotas (FOREACH)...");
        // Exemplo: Console.WriteLine(AnalisarNotas(new double[]{8.5, 7.0, 9.2, 6.5, 10.0}));
        Console.WriteLine(AnalisarNotas(new double[] { 8.5, 7.0, 9.2, 6.5, 10.0 }));

        Console.WriteLine("\n10. Testando ProcessarVendas (FOREACH múltiplo)...");
        // Exemplo: Console.WriteLine(ProcessarVendas(...));
        Console.WriteLine(ProcessarVendas(null, null, null, null));
        Console.WriteLine(ProcessarVendas(new double[] { }, new string[] { }, new double[] { }, new string[] { }));
        Console.WriteLine(ProcessarVendas(new double[] { 1000, 500, 200, 300 }, new string[] { "A", "B", "A", "C" }, new double[] { 10, 7, 5 }, new string[] { "A", "B", "C" }));

        Console.WriteLine("\n=== RESUMO: TODAS AS ESTRUTURAS FORAM TESTADAS ===");
        Console.WriteLine("✅ IF/ELSE: Testado na validação de idade");
        Console.WriteLine("✅ SWITCH: Testado na calculadora e classificação de notas");
        Console.WriteLine("✅ FOR: Testado na tabuada");
        Console.WriteLine("✅ WHILE: Testado no jogo de adivinhação");
        Console.WriteLine("✅ DO-WHILE: Testado na validação de senha");
        Console.WriteLine("✅ FOREACH: Testado na análise de notas e processamento de vendas");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    // =====================================================================
    // QUESTÃO 1 - VARIÁVEIS E TIPOS DE DADOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Complete o método para demonstrar diferentes tipos de dados
    /// - Declare uma variável de cada tipo primitivo (int, double, bool, char, string)
    /// - Use inferência de tipos (var) onde apropriado
    /// - Retorne uma string concatenando todos os valores
    /// </summary>
    private static string DemonstrarTiposDados()
    {
        // TODO: Implementar
        // Exemplo de retorno: "Inteiro: 42, Decimal: 3.14, Booleano: True, Caractere: A, Texto: Olá"

        int _inteiro = 42;
        double _decimal = 3.14;
        bool _booleano = true;
        char _caracter = 'A';
        string _texto = "Olá";

        var ret = $"Inteiro: {_inteiro}, Decimal: {_decimal}, Booleano: {_booleano}, Caractere: {_caracter}, Texto: {_texto}";

        return ret;
    }

    // =====================================================================
    // QUESTÃO 2 - OPERADORES ARITMÉTICOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Implemente uma calculadora básica usando SWITCH
    /// - Receba dois números e um operador (+, -, *, /)
    /// - Use SWITCH para selecionar a operação
    /// - Trate divisão por zero retornando 0
    /// - Para operadores inválidos, retorne -1
    /// </summary>
    private static double CalculadoraBasica(double num1, double num2, char operador)
    {
        // TODO: Implementar OBRIGATORIAMENTE usando SWITCH
        // Exemplo de estrutura:
        // switch (operador)
        // {
        //     case '+': return num1 + num2;
        //     case '-': return num1 - num2;
        //     // etc...
        // }

        switch (operador)
        {
            case '+': return num1 + num2;
            case '-': return num1 - num2;
            case '*': return num1 * num2;
            case '/': return num2 == 0 ? 0 : num1 / num2;
            default: return -1;
        }
    }

    // =====================================================================
    // QUESTÃO 3 - OPERADORES RELACIONAIS E LÓGICOS (10 pontos)  
    // =====================================================================

    /// <summary>
    /// TODO: Valide se uma idade é válida para diferentes contextos usando IF/ELSE
    /// - Use IF/ELSE encadeados (não switch)
    /// - Retorna "Criança" se idade < 12
    /// - Retorna "Adolescente" se idade >= 12 e < 18  
    /// - Retorna "Adulto" se idade >= 18 e <= 65
    /// - Retorna "Idoso" se idade > 65
    /// - Retorna "Idade inválida" se idade < 0 ou > 120
    /// Use operadores relacionais e lógicos
    /// </summary>
    private static string ValidarIdade(int idade)
    {
        // TODO: Implementar OBRIGATORIAMENTE usando IF/ELSE (não switch)
        // Exemplo de estrutura:
        // if (idade < 0 || idade > 120)
        //     return "Idade inválida";
        // else if (idade < 12)
        //     return "Criança";
        // Continue com else if...

        if (idade < 0 || idade > 120)
            return "Idade inválida";
        else if (idade < 12)
            return "Criança";
        else if (idade >= 12 && idade < 18)
            return "Adolescente";
        else if (idade >= 18 && idade <= 65)
            return "Adulto";
        else
            return "Idoso";
    }

    // =====================================================================
    // QUESTÃO 4 - CONVERSÃO DE TIPOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Converta uma string para diferentes tipos
    /// - Tente converter 'valor' para int, double e bool
    /// - Se a conversão for bem-sucedida, retorne "Tipo: Valor convertido"
    /// - Se falhar, retorne "Conversão impossível para [tipo]"
    /// - Use TryParse para conversões seguras
    /// </summary>
    private static string ConverterString(string valor, string tipoDesejado)
    {
        // TODO: Implementar conversões usando TryParse
        // tipoDesejado pode ser: "int", "double", "bool"

        if (tipoDesejado == "int")
            if (int.TryParse(valor, out int resultado))
                return $"{tipoDesejado}: {resultado}";
            else
                return $"Conversão impossível para {tipoDesejado}";
        else if (tipoDesejado == "double")
            if (double.TryParse(valor, out double resultado))
                return $"{tipoDesejado}: {resultado}";
            else
                return $"Conversão impossível para {tipoDesejado}";
        else if (tipoDesejado == "bool")
            if (bool.TryParse(valor, out bool resultado))
                return $"{tipoDesejado}: {resultado}";
            else
                return $"Conversão impossível para {tipoDesejado}";
        else
            return "Tipo inválido";
    }

    // =====================================================================
    // QUESTÃO 5 - ESTRUTURA CONDICIONAL SWITCH (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Classifique uma nota usando switch expression (C# 8+) ou switch tradicional
    /// - 9.0 a 10.0: "Excelente"
    /// - 7.0 a 8.9: "Bom" 
    /// - 5.0 a 6.9: "Regular"
    /// - 0.0 a 4.9: "Insuficiente"
    /// - Fora da faixa: "Nota inválida"
    /// </summary>
    private static string ClassificarNota(double nota)
    {
        // TODO: Implementar usando switch (pode usar switch expression se conhecer)

        switch (nota)
        {
            case double n when n >= 9.0 && n <= 10.0: return "Excelente";
            case double n when n >= 7.0 && n <= 8.9: return "Bom";
            case double n when n >= 5.0 && n <= 6.9: return "Regular";
            case double n when n >= 0.0 && n <= 4.9: return "Insuficiente";
            default: return "Nota inválida";
        }
    }

    // =====================================================================
    // QUESTÃO 6 - ESTRUTURA FOR (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOR
    /// Gere a tabuada de um número de 1 a 10
    /// - Use FOR para iterar de 1 a 10
    /// - Retorne string formatada: "2 x 1 = 2\n2 x 2 = 4\n..." 
    /// - Se número for <= 0, retorne "Número inválido"
    /// </summary>
    private static string GerarTabuada(int numero)
    {
        // TODO: Implementar OBRIGATORIAMENTE com FOR

        if (numero <= 0)
            return "Número inválido";

        string resultado = "";
        for (int i = 1; i <= 10; i++)
        {
            resultado += $"{numero} x {i} = {numero * i}\n";
        }
        return resultado;
    }

    // =====================================================================
    // QUESTÃO 7 - ESTRUTURA WHILE (15 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR WHILE
    /// Simule um jogo de adivinhar número com tentativas limitadas
    /// - numeroSecreto: número a ser adivinhado (1-100)
    /// - tentativas: array com os palpites do jogador
    /// - Use WHILE para percorrer as tentativas
    /// - Para cada tentativa: "Tentativa X: muito alto/baixo/correto"
    /// - Pare no acerto ou quando acabar as tentativas
    /// - Retorne string com histórico completo
    /// </summary>
    private static string JogoAdivinhacao(int numeroSecreto, int[] tentativas)
    {
        // TODO: Implementar OBRIGATORIAMENTE com WHILE
        // Exemplo: "Tentativa 1: 50 - muito baixo\nTentativa 2: 75 - muito alto\nTentativa 3: 63 - correto!"

        string resultado = "";
        int contador = 0;
        bool correto = false;
        while (contador < tentativas.Length && !correto)
        {
            int num = tentativas[contador];
            contador++;

            resultado += $"Tentativa {contador}: {num} - ";
            if (num < numeroSecreto)
                resultado += "muito baixo\n";
            else if (num > numeroSecreto)
                resultado += "muito alto\n";
            else
            {
                resultado += "correto!";
                correto = true;
            }
        }
        return resultado;
    }

    // =====================================================================
    // QUESTÃO 8 - ESTRUTURA DO-WHILE (15 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR DO-WHILE
    /// Valide uma senha seguindo critérios de segurança
    /// - A senha deve ter pelo menos 8 caracteres
    /// - Deve ter pelo menos 1 número
    /// - Deve ter pelo menos 1 letra maiúscula  
    /// - Deve ter pelo menos 1 caractere especial (!@#$%&*)
    /// - Use DO-WHILE para verificar cada critério
    /// - Retorne string explicando quais critérios não foram atendidos
    /// - Se senha válida, retorne "Senha válida"
    /// </summary>
    private static string ValidarSenha(string senha)
    {
        // TODO: Implementar OBRIGATORIAMENTE com DO-WHILE
        // Use do-while para verificar cada critério da senha

        string resultado = "";

        bool temNumero = false;
        bool temMaiuscula = false;
        bool temEspecial = false;
        string especiais = "!@#$%&*";

        int i = 0;
        do
        {
            if (char.IsDigit(senha[i]))
                temNumero = true;
            if (char.IsUpper(senha[i]))
                temMaiuscula = true;
            if (especiais.Contains(senha[i]))
                temEspecial = true;
            i++;
        }
        while (i < senha.Length);

        if (senha.Length < 8)
            resultado += "- A senha deve ter pelo menos 8 caracteres\n";
        if (!temNumero)
            resultado += "- Deve ter pelo menos 1 número\n";
        if (!temMaiuscula)
            resultado += "- Deve ter pelo menos 1 letra maiúscula\n";
        if (!temEspecial)
            resultado += "- Deve ter pelo menos 1 caractere especial (!@#$%&*)\n";

        if (string.IsNullOrEmpty(resultado))
            return "Senha válida";
        else
            return resultado;
    }

    // =====================================================================
    // QUESTÃO 9 - ESTRUTURA FOREACH (15 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOREACH
    /// Analise um array de notas de alunos
    /// - Use FOREACH para percorrer todas as notas
    /// - Calcule: média, quantidade de aprovados (>=7), maior nota, menor nota
    /// - Conte quantas notas estão em cada faixa: A(9-10), B(8-8.9), C(7-7.9), D(5-6.9), F(<5)
    /// - Retorne string formatada com todas as estatísticas
    /// - Se array vazio/null: "Nenhuma nota para analisar"
    /// </summary>
    private static string AnalisarNotas(double[] notas)
    {
        // TODO: Implementar OBRIGATORIAMENTE com FOREACH
        // Retorno exemplo: "Média: 7.5\nAprovados: 15\nMaior: 9.8\nMenor: 3.2\nA: 3, B: 4, C: 8, D: 2, F: 1"

        if (notas == null || notas.Length == 0)
            return "Nenhuma nota para analisar";

        double media = 0;
        double qtdAprovados = 0;
        double maior = 0;
        double menor = 0;
        double qtdA = 0;
        double qtdB = 0;
        double qtdC = 0;
        double qtdD = 0;
        double qtdF = 0;

        foreach (double n in notas)
        {
            media += n;

            if (n > maior)
                maior = n;

            if (n < menor || menor == 0)
                menor = n;

            if (n < 5)
                qtdF++;
            else if (n < 7)
                qtdD++;
            else
            {
                qtdAprovados++;

                if (n < 8)
                    qtdC++;
                else if (n < 9)
                    qtdB++;
                else
                    qtdA++;
            }
        }

        media = media / notas.Length;

        return $"Média: {media}\nAprovados: {qtdAprovados}\nMaior: {maior}\nMenor: {menor}\nA: {qtdA}, B: {qtdB}, C: {qtdC}, D: {qtdD}, F: {qtdF}";
    }

    // =====================================================================
    // QUESTÃO 10 - MULTIPLE FOREACH (DESAFIO) (20 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOREACH (múltiplos)
    /// Processe vendas por categoria e calcule comissões
    /// - vendas: array com valores de vendas
    /// - categorias: array com categorias correspondentes ("A", "B", "C")
    /// - comissoes: array com percentuais de comissão por categoria (ex: A=10%, B=7%, C=5%)
    /// - Use FOREACH para percorrer vendas e categorias simultaneamente
    /// - Use FOREACH separado para encontrar a comissão da categoria
    /// - Calcule total de vendas e total de comissões por categoria
    /// - Retorne string com relatório detalhado
    /// </summary>
    private static string ProcessarVendas(double[] vendas, string[] categorias, double[] comissoes, string[] nomesCategorias)
    {
        // TODO: Implementar com múltiplos FOREACH
        // Exemplo: "Categoria A: Vendas R$ 1500,00, Comissão R$ 150,00\nCategoria B: Vendas R$ 800,00, Comissão R$ 56,00"

        if (vendas == null || categorias == null || comissoes == null || nomesCategorias == null)
            return "Dados inválidos";
        if (vendas.Length == 0 || categorias.Length == 0)
            return "Nenhuma venda para processar";

        Dictionary<string, double> totalVendas = new Dictionary<string, double>();
        Dictionary<string, double> totalComissoes = new Dictionary<string, double>();

        foreach (string cat in nomesCategorias)
        {
            totalVendas[cat] = 0;
            totalComissoes[cat] = 0;
        }

        int i = 0;
        foreach (double venda in vendas)
        {
            string categoria = categorias[i];
            double percentual = 0;

            int j = 0;
            foreach (string nome in nomesCategorias)
            {
                if (nome == categoria)
                {
                    percentual = comissoes[j];
                    break;
                }
                j++;
            }

            double comissao = venda * percentual / 100.0;

            totalVendas[categoria] += venda;
            totalComissoes[categoria] += comissao;

            i++;
        }

        string relatorio = "";
        foreach (string cat in nomesCategorias)
        {
            relatorio += $"Categoria {cat}: Vendas R$ {totalVendas[cat]:F2}, Comissão R$ {totalComissoes[cat]:F2}\n";
        }

        return relatorio.TrimEnd();
    }

    // =====================================================================
    // MÉTODOS AUXILIARES (NÃO ALTERAR - APENAS PARA REFERÊNCIA)
    // =====================================================================

    /// <summary>
    /// Método de exemplo demonstrando diferença entre estático e de instância
    /// ESTÁTICO: Pertence à classe, não precisa criar objeto para usar
    /// </summary>
    private static void ExemploMetodoEstatico()
    {
        Console.WriteLine("Sou um método estático - chamado direto da classe");
    }

    /// <summary>
    /// Método de exemplo de instância (comentado pois não pode ser chamado do Main estático)
    /// DE INSTÂNCIA: Pertence ao objeto, precisa criar instância da classe
    /// </summary>
    /*
    void ExemploMetodoInstancia()
    {
        Console.WriteLine("Sou um método de instância - preciso de um objeto para ser chamado");
    }
    */
}