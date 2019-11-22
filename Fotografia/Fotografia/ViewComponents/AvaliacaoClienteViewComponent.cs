using Fotografia.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fotografia.ViewComponents
{
    [ViewComponent(Name ="AvaliacaoCliente")]
    public class AvaliacaoClienteViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<AvaliacaoCliente> avaliacoes = new List<AvaliacaoCliente>()
            {
                new AvaliacaoCliente
                {
                    NomeCliente = "Guilherme Andrade Lacerda",
                    Titlo = "Simplesmente Perfeito",
                    ImagemCliente = "https://livedemo00.template-help.com/wt_64615_v1/images/user-6-46x46.jpg",
                    Comentario = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Avaliacao = 5
                },
                new AvaliacaoCliente
                {
                    NomeCliente = "Guilherme Andrade Lacerda",
                    Titlo = "Simplesmente Perfeito",
                    ImagemCliente = "https://livedemo00.template-help.com/wt_64615_v1/images/user-6-46x46.jpg",
                    Comentario = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Avaliacao = 4
                },
                new AvaliacaoCliente
                {
                    NomeCliente = "Guilherme Andrade Lacerda",
                    Titlo = "Simplesmente Perfeito",
                    ImagemCliente = "https://livedemo00.template-help.com/wt_64615_v1/images/user-6-46x46.jpg",
                    Comentario = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Avaliacao = 3
                }
            };
            return View(avaliacoes);
        }
    }
}
