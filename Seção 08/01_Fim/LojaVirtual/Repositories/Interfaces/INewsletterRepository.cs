using LojaVirtual.Models;
using System.Collections.Generic;

namespace LojaVirtual.Repositories.Interfaces
{
    public interface INewsletterRepository
    {
        void Cadastrar(NewsletterEmail newsletter);

        IEnumerable<NewsletterEmail> ObterTodasNewsletter();
    }
}
