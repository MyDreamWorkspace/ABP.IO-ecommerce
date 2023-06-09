﻿using Acme.BookStore.BookManagement.Authors;
using Acme.BookStore.BookManagement.Books;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.BookStore.BookManagement.EntityFrameworkCore
{
    [ConnectionStringName("BookManagement")]
    public class BookManagementDbContext : AbpDbContext<BookManagementDbContext>, IBookManagementDbContext
    {
        public DbSet<Book> Books { get; set; }
        
        public DbSet<Author> Authors { get; set; }
        
        public static string TablePrefix { get; set; } = BookManagementConsts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = BookManagementConsts.DefaultDbSchema;

        public BookManagementDbContext(DbContextOptions<BookManagementDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureBookManagement(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });
        }
    }
}