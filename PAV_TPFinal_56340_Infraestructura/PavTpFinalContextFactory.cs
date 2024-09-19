using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PAV_TPFinal_56340_Infraestructura_Datos;

public class PavTpFinalContextFactory : IDesignTimeDbContextFactory<PavTpFinalContext>
{
    public PavTpFinalContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PavTpFinalContext>();
        optionsBuilder.UseSqlServer(PavTpFinalContext.CadenaDeConexion);

        return new PavTpFinalContext(optionsBuilder.Options);
    }
}
