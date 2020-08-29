using Microsoft.EntityFrameworkCore;
using ProyectMangement.Models;

namespace ProyectMangement.Models
{
    public class ProjectManagementContext:DbContext
    {
           public ProjectManagementContext(DbContextOptions<ProjectManagementContext> options)
            : base(options)
        {
        }
           public DbSet<ProyectMangement.Models.Cliente> Cliente { get; set; }



    }
}