using Microsoft.EntityFrameworkCore;
using proyectoef.Models;

namespace proyectoef;


public class TareasContext : DbContext
{
    public DbSet<Categoria> Categorias {get; set;}
    public DbSet<Tarea> Tareas {get; set;}

    public TareasContext(DbContextOptions<TareasContext> options) : base (options) { }

    protected  void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Categoria> categoriasInit = new List<Categoria>();
        categoriasInit.Add(new Categoria() { CategoriaId = Guid.Parse("0c949bab-51b8-454e-b1c8-ae6e9f87c37c"), Nombre = "Activiades Pendientes", Peso = 20 });
        categoriasInit.Add(new Categoria() { CategoriaId = Guid.Parse("0c949bab-51b8-454e-b1c8-ae6e9f87c302"), Nombre = "Activiades Personales", Peso = 50 });


        modelBuilder.Entity<Categoria>(categoria =>
        {
            categoria.ToTable("Categoria");
            categoria.HasKey(p=>p.CategoriaId);

            categoria.Property(p=> p.Nombre).IsRequired().HasMaxLength(150);

            categoria.Property(p=> p.Descripcion);

            categoria.Property(p=> p.Peso);

            categoria.HasData(categoriasInit);
        });

        List<Tarea> tareasInit = new List<Tarea>();
        tareasInit.Add(new Tarea() { TareaId = Guid.Parse("0c949bab-51b8-454e-b1c8-ae6e9f87c310"), CategoriaId = Guid.Parse("0c949bab-51b8-454e-b1c8-ae6e9f87c37c"), PrioridadTarea = Prioridad.Media, Titulo = "Pago servicio público", FechaCreacion = DateTime.Now });
        tareasInit.Add(new Tarea() { TareaId = Guid.Parse("0c949bab-51b8-454e-b1c8-ae6e9f87c311"), CategoriaId = Guid.Parse("0c949bab-51b8-454e-b1c8-ae6e9f87c302"), PrioridadTarea = Prioridad.Baja, Titulo = "Terminar de ver Peli en Netflix", FechaCreacion = DateTime.Now });

        modelBuilder.Entity<Tarea>(tarea =>
        {
            tarea.ToTable("Tarea");
            tarea.HasKey(p=>p.TareaId);

            tarea.HasOne(p=> p.Categoria).WithMany(p=> p.Tareas).HasForeignKey(p => p.CategoriaId);

            tarea.Property(p=> p.Titulo).IsRequired().HasMaxLength(200);

            tarea.Property(p=> p.Descripcion);

            tarea.Property(p=> p.PrioridadTarea);

            tarea.Property(p=> p.FechaCreacion);

             tarea.Property(p=> p.Puntos);

            tarea.Ignore(p => p.Resumen);

            tarea.HasData(tareasInit);
        });

    }
}