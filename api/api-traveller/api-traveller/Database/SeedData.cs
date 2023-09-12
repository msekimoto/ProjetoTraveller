using Microsoft.EntityFrameworkCore;

namespace api_traveller.Controllers
{
    public partial class HoteisController
    {
        public static class SeedData
        {
            public static void Initialize(IServiceProvider serviceProvider)
            {
                using (var context = new GulliverContext(serviceProvider.GetRequiredService<DbContextOptions<GulliverContext>>()))
                {
                    if (context.Hoteis.Any())
                    {
                        return;
                    }

                    context.Hoteis.AddRange
                    (
                        new Hotel
                        {
                            Id = 1,
                            Cidade = "Sao Paulo",
                            Nome = "Ibis",
                        },

                        new Hotel
                        {
                            Id = 2,
                            Cidade = "Sao Paulo",
                            Nome = "West Plaza",
                        },

                        new Hotel { Id = 3, Cidade = "Sao Paulo", Nome = "Ibira+" },

                        new Hotel { Id = 4, Cidade = "Sao Paulo", Nome = "Tivoli" }
                    );

                    context.SaveChanges();

                    context.Disponibilidades.AddRange
                    (
                        new Disponibilidade
                        {
                            Hotel = context.Hoteis.First(b => b.Id == 1),
                            Id = 11,
                            Data = DateTime.Now.AddDays(1),
                            Preco = new Random().Next(100, 300)
                        },
                        new Disponibilidade
                        {
                            Hotel = context.Hoteis.First(b => b.Id == 1),
                            Id = 12,
                            Data = DateTime.Now.AddDays(2),
                            Preco = new Random().Next(100, 300)
                        },
                        new Disponibilidade
                        {
                            Hotel = context.Hoteis.First(b => b.Id == 1),
                            Id = 13,
                            Data = DateTime.Now.AddDays(3),
                            Preco = new Random().Next(100, 300)
                        },
                        new Disponibilidade
                        {
                            Hotel = context.Hoteis.First(b => b.Id == 1),
                            Id = 14,
                            Data = DateTime.Now.AddDays(4),
                            Preco = new Random().Next(100, 300)
                        },
                        new Disponibilidade
                        {
                            Hotel = context.Hoteis.First(b => b.Id == 2),
                            Id = 21,
                            Data = DateTime.Now.AddDays(1),
                            Preco = new Random().Next(100, 300)
                        },
                        new Disponibilidade
                        {
                            Hotel = context.Hoteis.First(b => b.Id == 2),
                            Id = 22,
                            Data = DateTime.Now.AddDays(2),
                            Preco = new Random().Next(100, 300)
                        },
                        new Disponibilidade
                        {
                            Hotel = context.Hoteis.First(b => b.Id == 2),
                            Id = 23,
                            Data = DateTime.Now.AddDays(3),
                            Preco = new Random().Next(100, 300)
                        },
                        new Disponibilidade
                        {
                            Hotel = context.Hoteis.First(b => b.Id == 2),
                            Id = 24,
                            Data = DateTime.Now.AddDays(4),
                            Preco = new Random().Next(100, 300)
                        }
                    );

                    context.SaveChanges();

                    //int i = 30;
                    //while (i < 3000)
                    //{
                    //    context.Hoteis.Add(new Hotel { Id = i, Cidade = "Sao Paulo", Nome = "Ibis" + i, });
                    //    i++;
                    //}
                    //context.SaveChanges();
                }
            }
        }
    }
}
