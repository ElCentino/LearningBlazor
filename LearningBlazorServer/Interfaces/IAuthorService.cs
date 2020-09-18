using LearningBlazorServer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningBlazorServer.Interfaces
{
    public interface IAuthorService
    {
        List<Author> GetAuthors();
        Author GetAuthorById(string Id);
    }
}
