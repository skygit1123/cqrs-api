using System.Threading;
using System.Threading.Tasks;
using MaterialApi.DataAccess;
using MaterialApi.Entities;
using MediatR;

namespace MaterialApi.Domain.Commands
{
    public class CreateWorkerCommandHandler : IRequestHandler<CreateWorkerCommand, Worker>
    {
        private readonly IMaterialContext _repository;
        public CreateWorkerCommandHandler(IMaterialContext repository)
        {
            _repository = repository;
        }

        public Task<Worker> Handle(CreateWorkerCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_repository.Create(request.Worker));
        }
    }
}