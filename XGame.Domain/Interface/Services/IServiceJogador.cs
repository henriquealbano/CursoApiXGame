﻿using System;
using XGame.Domain.Arguments.Jogador;

namespace XGame.Domain.Interface.Services
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);

    }
}
