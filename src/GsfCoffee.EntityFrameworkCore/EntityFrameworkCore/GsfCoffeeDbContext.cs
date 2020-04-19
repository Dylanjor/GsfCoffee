using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GsfCoffee.Authorization.Roles;
using GsfCoffee.Authorization.Users;
using GsfCoffee.MultiTenancy;
using GsfCoffee.CoffeeUser;
using GsfCoffee.OrderTable;

namespace GsfCoffee.EntityFrameworkCore
{
    public class GsfCoffeeDbContext : AbpZeroDbContext<Tenant, Role, User, GsfCoffeeDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public GsfCoffeeDbContext(DbContextOptions<GsfCoffeeDbContext> options)
            : base(options)
        {
            
        }
        /// <summary>
        /// 用户表
        /// </summary>
        public DbSet<UserTable> UserTable { get; set; }
        /// <summary>
        /// 退货表
        /// </summary>
        public DbSet<ReturnTable> ReturnTable { get; set; }
        /// <summary>
        /// 订单行
        /// </summary>
        public DbSet<OrderLineTable> OrderLineTable { get; set; }
        /// <summary>
        /// 订单表
        /// </summary>
        public DbSet<OrderHeaderTable> OrderHeaderTable { get; set; }
        /// <summary>
        /// 商品表
        /// </summary>
        public DbSet<CommodityTable> CommodityTable { get; set; }
        /// <summary>
        /// 购物车表
        /// </summary>
        public DbSet<ShoppingCartTable> ShoppingCartTable { get; set; }
        /// <summary>
        /// 商品类别表
        /// </summary>
        public DbSet<ProductSpecificationsTable> ProductSpecificationsTable { get; set; }
    }
}
