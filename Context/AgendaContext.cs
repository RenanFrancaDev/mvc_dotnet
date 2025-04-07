using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using modulo_mvc.Models;

namespace modulo_mvc.Context
{
    public class AgendaContext : DbContext
    {
        //Construtor
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        public DbSet<Contato> Contatos { get; set; }
    }
}