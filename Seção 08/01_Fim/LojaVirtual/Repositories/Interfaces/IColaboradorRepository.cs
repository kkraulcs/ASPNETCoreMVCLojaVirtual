using LojaVirtual.Models;
using System.Collections.Generic;

namespace LojaVirtual.Repositories.Interfaces
{
    public interface IColaboradorRepository
    {
        Colaborador Login(string Email, string Senha);

        void Cadastrar(Colaborador colaborador);

        void Atualizar(Colaborador colaborador);

        void Excluir(int Id);

        Colaborador ObterColaborador(int Id);

        IEnumerable<Colaborador> ObterTodosColaboradores();
    }
}
