using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S5_CodeFirstEFCore.Models
{
    public class CopaLibertadoresDBContext: DbContext
    {
        public CopaLibertadoresDBContext(DbContextOptions<CopaLibertadoresDBContext>options):base(options)
        {
            

        }

        public  DbSet<Player> Player{get; set;}
        public DbSet<SoccerPosition> SoccerPositions { get; set; }
    }

}
