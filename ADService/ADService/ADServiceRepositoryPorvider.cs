using System.ComponentModel.Composition;
using Mita.DataAccess;
using Mita.DataAccess.EF;

namespace ADService.DataAccess
{
    [Export(typeof(IRepositoryProvider))]
    public class ADServiceRepositoryPorvider : EntityRepositoryProvider<Db>
    {
    }
}
