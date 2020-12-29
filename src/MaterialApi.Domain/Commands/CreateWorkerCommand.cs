using AutoMapper;
using MaterialApi.Entities;
using MaterialApi.Model;
using MediatR;

namespace MaterialApi.Domain.Commands
{
    public class CreateWorkerCommand : IRequest<Worker>
    {
        private readonly IMapper _mapper;
        public CreateWorkerCommand(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Worker Worker { get; private set; }

        public CreateWorkerCommand(WorkerDto worker)
        {
            Worker = _mapper.Map<Worker>(worker);
        }
    }
}