using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CQRSDesignPattern.Models;
using CQRSDesignPattern.Services;
using MediatR;

namespace CQRSDesignPatternDemo.Features.Players.Queries
{
    public class GetAllPlayersQuery : IRequest<IEnumerable<Player>>
    {
        public class GetAllPlayersQueryHandler : IRequestHandler<GetAllPlayersQuery, IEnumerable<Player>>
        {
            private readonly IPlayersService _playerService;

            public GetAllPlayersQueryHandler(IPlayersService playerService)
            {
                _playerService = playerService;
            }

            public async Task<IEnumerable<Player>> Handle(GetAllPlayersQuery query, CancellationToken cancellationToken)
            {
                return await _playerService.GetPlayersList();
            }
        }
    }
}
