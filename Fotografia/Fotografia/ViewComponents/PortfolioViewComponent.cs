using Fotografia.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fotografia.ViewComponents
{
    [ViewComponent(Name ="Portfolio")]
    public class PortfolioViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Portfolio> portfolios = new List<Portfolio>()
            {
                new Portfolio
                {
                    Imagem = "https://livedemo00.template-help.com/wt_64615_v1/images/gallery-image-1-1200x800-original.jpg",
                    Titlo = "Imagem",
                    Comentario = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Posicao = 1
                },
                new Portfolio
                {
                    Imagem = "https://livedemo00.template-help.com/wt_64615_v1/images/gallery-image-9-1200x800-original.jpg",
                    Titlo = "Imagem",
                    Comentario = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Posicao = 2
                },
                new Portfolio
                {
                    Imagem = "https://livedemo00.template-help.com/wt_64615_v1/images/gallery-image-15-1200x801-original.jpg",
                    Titlo = "Imagem",
                    Comentario = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Posicao = 3
                },
                new Portfolio
                {
                    Imagem = "https://livedemo00.template-help.com/wt_64615_v1/images/gallery-image-10-835x1200-original.jpg",
                    Titlo = "Imagem",
                    Comentario = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Posicao = 4
                },
                new Portfolio
                {
                    Imagem = "https://livedemo00.template-help.com/wt_64615_v1/images/gallery-image-14-1200x800-original.jpg",
                    Titlo = "Imagem",
                    Comentario = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                     Posicao = 5
                },
                new Portfolio
                {
                    Imagem = "https://livedemo00.template-help.com/wt_64615_v1/images/gallery-image-2-1200x800-original.jpg",
                    Titlo = "Imagem",
                    Comentario = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Posicao = 6
                }
            };
            return View(portfolios);
        }
    }
}
