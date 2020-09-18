using LearningBlazorServer.Data;
using LearningBlazorServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningBlazorServer.Services
{
    public class AuthorService : IAuthorService
    {
        List<Author> authors;

        public AuthorService()
        {
            authors = new List<Author>();
            authors.Add(new Author { Id = "339349348348", FirstName = "Danny", LastName = "Ansari", ISBN = "343 579 2324 999", Address = "Menlo Park" });
            authors.Add(new Author { Id = "834833934934", FirstName = "Rachael", LastName = "Hansen", ISBN = "866 836 231 522", Address = "Settle" });
        }

        public Author GetAuthorById(string Id)
        {
            return authors.Where<Author>(author => author.Id == Id).FirstOrDefault();
        }

        public List<Author> GetAuthors()
        {
            return authors;
        }
    }
}
