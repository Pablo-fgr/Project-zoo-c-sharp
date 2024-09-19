using Microsoft.EntityFrameworkCore;
using PAV_TPFinal_56340_Dominio.Entidades;
using PAV_TPFinal_56340_Dominio.Repositorios;
using System.Linq.Expressions;

namespace PAV_TPFinal_56340_Infraestructura_Datos.Repositorios;

public class Repositorio : IRepositorio
{
    private readonly PavTpFinalContext _context;
    public Repositorio(PavTpFinalContext context)
    {
        ArgumentNullException.ThrowIfNull(context);
        _context = context;
    }

    public void Actualizar<TEntity>(TEntity entidad) where TEntity : EntityBase
    {
        _context.Update(entidad);
        _context.SaveChanges();
    }

    public void Agregar<TEntity>(TEntity entidad) where TEntity : EntityBase
    {
        _context.Set<TEntity>().Add(entidad);
        _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }

    public void Eliminar<TEntity>(TEntity entidad) where TEntity : EntityBase
    {
        _context.Set<TEntity>().Remove(entidad);
        _context.SaveChanges();
    }

    private IQueryable<TEntity> Incluir<TEntity>(IQueryable<TEntity> consulta, string[] incluidos)
        where TEntity : EntityBase
    {
        var incluidosConsulta = consulta;

        foreach(var incluido in incluidos)
        {
            incluidosConsulta = incluidosConsulta.Include(incluido);
        }

        return incluidosConsulta;
    }

    public List<TEntity> Listar<TEntity>(Expression<Func<TEntity,bool>> predicado, params string[] incluidos)
        where TEntity : EntityBase
    {
        return Incluir(_context.Set<TEntity>(),incluidos).Where(predicado).ToList();
    }

    public List<TEntity> ListarTodos<TEntity>(params string[] incluidos) where TEntity : EntityBase
    {
        return Incluir(_context.Set<TEntity>(),incluidos).ToList();
    }

    public TEntity? ObtenerElPrimero<TEntity>(Expression<Func<TEntity,bool>> predicado, params string[] incluidos)
        where TEntity : EntityBase
    {
        return Incluir(_context.Set<TEntity>(),incluidos).FirstOrDefault(predicado);
    }

    public TEntity? ObtenerPorId<TEntity>(Guid id, params string[] incluidos) where TEntity : EntityBase
    {
        return Incluir(_context.Set<TEntity>(),incluidos).SingleOrDefault(e => e.Id == id);
    }
}
