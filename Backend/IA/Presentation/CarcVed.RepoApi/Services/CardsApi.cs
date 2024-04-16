using Grpc.Core;

namespace CarcVed.RepoApi.Services
{
    public class CardsApiService : CardsApi.CardsApiBase
    {
        private readonly ILogger<CardsApiService> _logger;
        public CardsApiService(ILogger<CardsApiService> logger)
        {
            _logger = logger;
        }

        public override Task<CardsReply> GetCards(CardsRequest request, ServerCallContext context)
        {
            return Task.FromResult(new CardsReply
            {
                Message = "Some message"
            });
        }
    }
}