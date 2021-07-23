using ApiCatalogoJogos.InputModel;
using ApiCatalogoJogos.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Services
{
    public interface IJogoService : IDisposable
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade); // obter uma lista de jogos
        Task<JogoViewModel> Obter(Guid id); // obter um jogo
        Task<JogoViewModel> Inserir(JogoInputModel jogo); // inserir um jogo
        Task Atualizar(Guid id, JogoInputModel jogo); // atualizar o jogo inteiro
        Task Atualizar(Guid id, double preco); // atualizar apenas o preço
        Task Remover(Guid id); // remover o jogo

    }
}
