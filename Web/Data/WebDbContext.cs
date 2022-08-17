using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Data
{
    public class WebDbContext : DbContext
    {
        //options에는 연결정보가 포함되어있다. 데이타베이스와의 연결에 관한 각종 설정
        public WebDbContext(DbContextOptions options) : base(options) { }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
