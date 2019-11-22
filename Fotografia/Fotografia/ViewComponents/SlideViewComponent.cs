using Fotografia.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fotografia.ViewComponents
{
    [ViewComponent(Name ="Slides")]
    public class SlideViewComponent : ViewComponent
    {
        //private readonly IConfiguracaoService _service;
        //public SlideViewComponent(IConfiguracaoService service)
        //{
        //}
        public async Task<IViewComponentResult> InvokeAsync()
        {
        List<Slide> slides = new List<Slide>()
        {
            new Slide
            {
                Imagem = "slide1.jpg",
                Titlo= "Imagem #1",
                Descricao = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                "when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            },
            new Slide
            {
                Imagem = "slide2.jpg",
                Titlo= "Imagem #2",
                Descricao = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                "when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            },
            new Slide
            {
                Imagem = "slide3.jpg",
                Titlo= "Imagem #3",
                Descricao = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                "when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            },
            new Slide
            {
                Imagem = "slide4.jpg",
                Titlo= "Imagem #4",
                Descricao = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                "when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            }
        };
            return View(slides);
        }
    }
}
