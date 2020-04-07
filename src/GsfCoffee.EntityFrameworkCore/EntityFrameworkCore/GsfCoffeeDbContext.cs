﻿using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GsfCoffee.Authorization.Roles;
using GsfCoffee.Authorization.Users;
using GsfCoffee.MultiTenancy;

namespace GsfCoffee.EntityFrameworkCore
{
    public class GsfCoffeeDbContext : AbpZeroDbContext<Tenant, Role, User, GsfCoffeeDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public GsfCoffeeDbContext(DbContextOptions<GsfCoffeeDbContext> options)
            : base(options)
        {
        }
    }
}