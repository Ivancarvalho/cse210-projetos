using System;
using System.Collections.Generic;

// PARA EXCEDER OS REQUISITOS (100%):
// 1. Implementei uma biblioteca com 12 passagens (versículo único e intervalo de versículos),
//    sendo 6 da Bíblia (Almeida Revista e Corrigida, de João Ferreira de Almeida) e 6 do
//    Livro de Mórmon (tradução oficial em português), selecionando uma aleatoriamente a cada
//    execução do programa.
// 2. Aprimorei a lógica de ocultação na classe Escritura para filtrar e sortear exclusivamente
//    entre as palavras que ainda estão visíveis, evitando repetições em palavras já ocultadas.

class Program
{
    static void Main(string[] args)
    {
        List<Escritura> biblioteca = new List<Escritura>
        {
            // Bíblia - Almeida Revista e Corrigida
            new Escritura(
                new Referencia("Provérbios", 3, 5, 6),
                "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas."
            ),
            new Escritura(
                new Referencia("Salmos", 23, 1),
                "O Senhor é o meu pastor; nada me faltará."
            ),
            new Escritura(
                new Referencia("Josué", 1, 9),
                "Não to mandei eu? Esforça-te e tem bom ânimo; não pasmes, nem te espantes, porque o Senhor, teu Deus, é contigo, por onde quer que andares."
            ),
            new Escritura(
                new Referencia("João", 3, 16),
                "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna."
            ),
            new Escritura(
                new Referencia("Mateus", 11, 28),
                "Vinde a mim, todos os que estais cansados e oprimidos, e eu vos aliviarei."
            ),
            new Escritura(
                new Referencia("Filipenses", 4, 13),
                "Posso todas as coisas naquele que me fortalece."
            ),

            // Livro de Mórmon
            new Escritura(
                new Referencia("1 Néfi", 3, 7),
                "E aconteceu que eu, Néfi, disse a meu pai: Eu irei e cumprirei as ordens do Senhor, porque sei que o Senhor nunca dá ordens aos filhos dos homens sem antes preparar um caminho pelo qual suas ordens possam ser cumpridas."
            ),
            new Escritura(
                new Referencia("2 Néfi", 2, 25),
                "Adão caiu para que os homens existissem; e os homens existem para que tenham alegria."
            ),
            new Escritura(
                new Referencia("Mosias", 2, 17),
                "E eis que vos digo estas coisas para que aprendais sabedoria; para que saibais que, quando estais a serviço de vosso próximo, estais somente a serviço de vosso Deus."
            ),
            new Escritura(
                new Referencia("Alma", 37, 37),
                "Aconselha-te com o Senhor em tudo que fizeres e ele dirigir-te-á para o bem; sim, quando te deitares à noite, repousa no Senhor, para que ele possa velar por ti em teu sono; e quando te levantares pela manhã, tem o teu coração cheio de agradecimento a Deus; e se fizeres essas coisas, serás elevado no último dia."
            ),
            new Escritura(
                new Referencia("Éter", 12, 27),
                "E se os homens vierem a mim, mostrar-lhes-ei sua fraqueza. E dou a fraqueza aos homens a fim de que sejam humildes; e minha graça basta a todos os que se humilham perante mim; porque caso se humilhem perante mim e tenham fé em mim, então farei com que as coisas fracas se tornem fortes para eles."
            ),
            new Escritura(
                new Referencia("Morôni", 10, 4),
                "E quando receberdes estas coisas, eu vos exorto a perguntardes a Deus, o Pai Eterno, em nome de Cristo, se estas coisas não são verdadeiras; e se perguntardes com um coração sincero e com real intenção, tendo fé em Cristo, ele vos manifestará a verdade delas pelo poder do Espírito Santo."
            )
        };

        Random random = new Random();
        Escritura escrituraAtual = biblioteca[random.Next(biblioteca.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(escrituraAtual.ObterTexto());
            Console.WriteLine();

            if (escrituraAtual.EstaCompletamenteOculta())
            {
                break;
            }

            Console.WriteLine("Pressione Enter para ocultar mais palavras ou digite 'sair' para encerrar:");
            string entrada = Console.ReadLine();

            if (entrada != null && entrada.Trim().ToLower() == "sair")
            {
                break;
            }

            escrituraAtual.OcultarPalavrasAleatorias(3);
        }
    }
}
