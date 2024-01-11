using System;
using System.Net;
using ASP.Net_MVC_Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ASP.Net_MVC_Core.DataBase
{

	public class StudentContext:DbContext
	{

        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            if (!optionbuilder.IsConfigured)
            {
                // string sqlConnetionSanbox = $"Data Source={SystemEnv.ServerSanboxAddress}; database={SystemEnv.SanboxDatabaseName}; User Id={SystemEnv.UserNameSanbox}; Password={SystemEnv.PasswordSanbox}; TrustServerCertificate=True";
                string sqlConnetionSanbox = $"Data Source=127.0.0.1,1433; database=StudentManagement; User Id=hoangdm; Password=1234; TrustServerCertificate=True";
                optionbuilder.UseSqlServer(sqlConnetionSanbox);
            }
        }
        public DbSet<Student>D_STUDENT { get; set; }
        public DbSet<Address> D_ADDRESS { get; set; }
        public DbSet<StudentMark> D_STUDENT_MARK{ get; set; }

    }

}

