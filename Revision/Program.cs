using System.Collections;
using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using Revision.DbContexts;

namespace Revision;

class Program
{
    static void Main(string[] args)
    {
        using CompanyDbContext dbContext = new CompanyDbContext();
    }
}