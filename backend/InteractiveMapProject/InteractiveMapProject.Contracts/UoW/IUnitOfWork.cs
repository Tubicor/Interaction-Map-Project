using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Repsitories;

namespace InteractiveMapProject.Contracts.UoW;

public interface IUnitOfWork
{
    IRepository<Professional> Professionals { get; }
    Task SaveChangesAsync();
}