//public class OrderServices(
//    IMediator mediator,
//    IOrderQueries queries,
//    IIdentityService identityService,
//    ILogger<OrderServices> logger);

//{
//    public IMediator Mediator { get; set; } = mediator;
//    public ILogger<OrderServices> Logger { get; } = logger;
//    public IOrderQueries Queries { get; } = queries;
//    public IIdentityService IdentityService { get; } = identityService;
//}
using MediatR;
using Microsoft.Extensions.Logging;

namespace YourNamespace
{
    public class OrderServices
    {
        public IMediator Mediator { get; set; }
        public ILogger<OrderServices> Logger { get; }
        public IOrderQueries Queries { get; }
        public IIdentityService IdentityService { get; }

        public OrderServices(
            IMediator mediator,
            IOrderQueries queries,
            IIdentityService identityService,
            ILogger<OrderServices> logger)
        {
            Mediator = mediator;
            Logger = logger;
            Queries = queries;
            IdentityService = identityService;
        }
    }
}

