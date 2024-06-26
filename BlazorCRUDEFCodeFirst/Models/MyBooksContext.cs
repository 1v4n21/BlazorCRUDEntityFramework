﻿using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDEFCodeFirst.Models
{
    //Clase que actua para acceder a la BD y crearla mediante EntityFramework
    //Le implementamos DbContext
    public class MyBooksContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Cadena donde queremos que se cree nuestra BD
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BlazorCRUDEFCodeSecond;User ID=ivan;Password=123abc;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }

    /*
     * Comandos a ejecutar despues de crear esta clase
     * 
     * ->   Add-Migration Initial
     * ->   Update-Database
     */
}
