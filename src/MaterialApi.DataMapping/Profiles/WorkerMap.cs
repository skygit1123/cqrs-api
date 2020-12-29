using AutoMapper;
using MaterialApi.Entities;
using MaterialApi.Model;

namespace MaterialApi.DataMapping
{
    public class WorkerMap : Profile
    {
        public WorkerMap()
        {
            CreateMap<Worker, WorkerDto>();
        }
    }
}