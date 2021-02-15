using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //AOP Autofac bize AOP saðlýyor bu arada
            //Autofac,Ninject,CastleWindsor,StructreMap,LightInject,DryInject -->IoC Conteiner
            services.AddControllers();
            //singleton bellekte bir tane productmaneger oluþturuyor.Ýçerde data tutmuyorsak o zman singleton kullanýrýz.
            services.AddSingleton<IProductService,ProductManager>(); //Bana arka planda bir referans oluþtur demek .IProductService þeklinde baðýmlýlýk görürsen onun karþýlýðý ProductManager dir demek istedik burda,
            services.AddSingleton<IProductDal, EfProductDal>();
            //Arka planda new lemesi gerekiyor tanýmlamasý için .BU yüzden bu iþlemleri yaptýk.ARka planda newleyip çözümlüyor böylece.Yani arka planda new Productmanager() vs gibi iþlem yapýyor
            //ve de constructor þeklinde Tanýmladýðýmýz için eriþemez baþka classlar.Bu yüzden web api de erðiþemediði için IOC ile eriþmeyi saðladýk
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
