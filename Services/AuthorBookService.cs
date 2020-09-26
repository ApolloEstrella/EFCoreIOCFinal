using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{

    public class AuthorBookService : IAuthorBookService
    {
        private readonly mssql_serverContext _serverContext;
        public AuthorBookService(mssql_serverContext serverContext)
        {
            _serverContext = serverContext;

        }

        public void AddAuthor()
        {
            using (var transaction = _serverContext.Database.BeginTransaction())
            {
                try
                {
                    var author = new Author { Lastname = "Poe Jr.", Firstname = "Fernando" };
                    _serverContext.Authors.Add(author);
                    _serverContext.SaveChanges();

                    _serverContext.Books.Add(new Book { AuthorId = author.Id, Title = "Isang Bala Ka Lang" });
                    _serverContext.Books.Add(new Book { AuthorId = author.Id, Title = "Kapag Puno na ang Salop" });
                    _serverContext.Books.Add(new Book { AuthorId = author.Id, Title = "Hari ng Tundo" });
                    _serverContext.SaveChanges();

                    // Commit transaction if all commands succeed, transaction will auto-rollback
                    // when disposed if either commands fails
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    var x = e;
                    transaction.Rollback();
                }
            }
        }
    }
}
