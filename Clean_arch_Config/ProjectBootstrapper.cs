using CLean_arch_Application.Orders;
using CLean_arch_Application.Products;
using Clean_arch_Constracts;
using clean_arch_Domain.Orders.Repository;
using clean_arch_Domain.Products.Repository;
using Clean_arch_Infrastructure;
using Clean_arch_Infrastructure.persistent.Memory;
using Clean_arch_Infrastructure.persistent.Memory.Orders;
using Clean_arch_Infrastructure.persistent.Memory.Products;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch_Config
{
    public class ProjectBootstrapper
    {
        public static void Init(IServiceCollection services)
        {
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();

            services.AddScoped<IsmsService, SmsService>();
            services.AddSingleton<Context>();
        }
    }
}
