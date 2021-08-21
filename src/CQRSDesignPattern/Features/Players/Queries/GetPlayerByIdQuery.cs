using System.Threading;
using System.Threading.Tasks;
using CQRSDesignPattern.Models;
using CQRSDesignPattern.Services;
using MediatR;

namespace CQRSDesignPattern.Features.Players.Queries
{
    public class GetPlayerByIdQuery : IRequest<Player>
    {
        public int Id { get; set; }

        public class GetPlayerByIdQueryHandler : IRequestHandler<GetPlayerByIdQuery, Player>
        {
            private readonly IPlayersService _playerService;

            public GetPlayerByIdQueryHandler(IPlayersService playerService)
            {
                _playerService = playerService;
            }

            public async Task<Player> Handle(GetPlayerByIdQuery query, CancellationToken cancellationToken)
            {
                return await _playerService.GetPlayerById(query.Id);
            }
        }
    }
}
