using System.Threading;
using System.Threading.Tasks;

namespace CoreDesk.Server.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}