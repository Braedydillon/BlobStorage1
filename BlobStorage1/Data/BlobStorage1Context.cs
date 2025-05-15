using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlobStorage1.Models;

namespace BlobStorage1.Data
{
    public class BlobStorage1Context : DbContext
    {
        public BlobStorage1Context (DbContextOptions<BlobStorage1Context> options)
            : base(options)
        {
        }

        public DbSet<BlobStorage1.Models.Event> Event { get; set; } = default!;
    }
}
