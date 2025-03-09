using PaymentApıCA.Domain.Entities;

namespace PaymentApıCA.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }
    
    DbSet<Domain.Entities.Payment> Payments { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
