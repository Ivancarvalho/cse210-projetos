using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Arquitetura Limpa na Prática com .NET 8", "Código Fonte TV", 1420);
        video1.AdicionarComentario(new Comentario("Lucas Almeida", "Explicação direta ao ponto sobre separação de camadas."));
        video1.AdicionarComentario(new Comentario("Mariana Costa", "Apliquei esse padrão na API da empresa hoje e ficou muito mais fácil de testar."));
        video1.AdicionarComentario(new Comentario("Rafael Mendes", "Excelente exemplo usando MediatR e CQRS."));
        videos.Add(video1);

        Video video2 = new Video("Review Completo: Teclado Mecânico Custom", "Tech Hardware BR", 845);
        video2.AdicionarComentario(new Comentario("fernando_dev", "O som desses switches táteis é muito satisfatório."));
        video2.AdicionarComentario(new Comentario("Camila Rocha", "Comprei o mesmo modelo depois desse review, vale cada centavo."));
        video2.AdicionarComentario(new Comentario("André Santos", "Faltou só mostrar como fica a iluminação no escuro."));
        video2.AdicionarComentario(new Comentario("Beatriz Lima", "Ótima análise da construção e do cabo removível."));
        videos.Add(video2);

        Video video3 = new Video("Como Otimizar Consultas SQL em Grandes Bases", "Dados & Performance", 1960);
        video3.AdicionarComentario(new Comentario("Diego Martins", "A dica sobre índices compostos reduziu nossa query de 12s para 80ms."));
        video3.AdicionarComentario(new Comentario("Juliana Nunes", "Melhor aula sobre plano de execução que já assisti."));
        video3.AdicionarComentario(new Comentario("Thiago Oliveira", "Muito bem estruturado, parabéns pelo conteúdo."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.ExibirDetalhes();
        }
    }
}