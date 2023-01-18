using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapenexisLearners22.Models;

namespace CapenexisLearners.Data
{
    public class CapenexisLearnersContext : DbContext
    {
        public CapenexisLearnersContext (DbContextOptions<CapenexisLearnersContext> options)
            : base(options)
        {
        }

        public DbSet<CapenexisLearners22.Models.Learner> Learner { get; set; } = default!;


    }
}
