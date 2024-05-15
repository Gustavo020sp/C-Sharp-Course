using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private readonly SalesWebMvcContext? Context;

        public SeedingService(SalesWebMvcContext? _context)
        {
            Context = _context;
        }

        public void Seed(IApplicationBuilder applicationBuilder)
        {
            Seed(applicationBuilder, Context);
        }

        public void Seed(IApplicationBuilder applicationBuilder, SalesWebMvcContext? context)
        {

            if (Context.Department.Any() || Context.Seller.Any() || Context.SalesRecords.Any())
            {
                return;
            }

            Department d1 = new Department { Id = 1, Name = "Electronics" };
            Department d2 = new Department { Id = 2, Name = "Fashion" };
            Department d3 = new Department { Id = 3, Name = "Toys" };
            Department d4 = new Department { Id = 4, Name = "Clothes" };

            Seller s1 = new Seller { Name = "John Cena", Email = "john@gmail.com", BirthDate = new DateTime(1995 / 10 / 15), BaseSalary = 5000, Department = d1 };
            Seller s2 = new Seller { Name = "Maria Green", Email = "maria@gmail.com", BirthDate = new DateTime(1990 / 05 / 10), BaseSalary = 5500, Department = d2,  };
            Seller s3 = new Seller { Name = "Elto John", Email = "elto@gmail.com",  BirthDate = new DateTime(2000 / 10 / 03), BaseSalary = 8900, Department = d3,  };
            Seller s4 = new Seller { Name = "Josh Blue", Email = "josh@gmail.com", BirthDate = new DateTime(2003 / 03 / 06), BaseSalary = 10200, Department = d4,  };
            Seller s5 = new Seller { Name = "Milena White", Email = "milena@gmail.com",  BirthDate = new DateTime(2003 / 06 / 06), BaseSalary = 15200, Department = d4,  };
            Seller s6 = new Seller { Name = "Gustavo White", Email = "gustavo@gmail.com", BirthDate = new DateTime(1995 / 10 / 13), BaseSalary = 15200, Department = d4,  };

            // SalesRecord 1
            SalesRecord sr1 = new SalesRecord { Id = 1, Date = new DateTime(2024, 04, 01), Amount = 3000.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s1 };

            // SalesRecord 2
            SalesRecord sr2 = new SalesRecord { Id = 2, Date = new DateTime(2024, 04, 03), Amount = 2500.0, Salestatus = Models.Enums.SaleStatus.Pending, Seller = s2 };

            // SalesRecord 3
            SalesRecord sr3 = new SalesRecord { Id = 3, Date = new DateTime(2024, 04, 05), Amount = 4500.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s3 };

            // SalesRecord 4
            SalesRecord sr4 = new SalesRecord { Id = 4, Date = new DateTime(2024, 04, 07), Amount = 6000.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s4 };

            // SalesRecord 5
            SalesRecord sr5 = new SalesRecord { Id = 5, Date = new DateTime(2024, 02, 09), Amount = 3500.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s5 };

            // SalesRecord 6
            SalesRecord sr6 = new SalesRecord { Id = 6, Date = new DateTime(2024, 04, 11), Amount = 4000.0, Salestatus = Models.Enums.SaleStatus.Canceled, Seller = s1 };

            // SalesRecord 7
            SalesRecord sr7 = new SalesRecord { Id = 7, Date = new DateTime(2024, 04, 13), Amount = 3200.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s2 };

            // SalesRecord 8
            SalesRecord sr8 = new SalesRecord { Id = 8, Date = new DateTime(2024, 04, 15), Amount = 5000.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s3 };

            // SalesRecord 9
            SalesRecord sr9 = new SalesRecord { Id = 9, Date = new DateTime(2024, 04, 17), Amount = 2800.0, Salestatus = Models.Enums.SaleStatus.Pending, Seller = s4 };

            // SalesRecord 10
            SalesRecord sr10 = new SalesRecord { Id = 10, Date = new DateTime(2024, 04, 19), Amount = 4200.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s5 };

            // SalesRecord 11
            SalesRecord sr11 = new SalesRecord { Id = 11, Date = new DateTime(2024, 04, 21), Amount = 3700.0, Salestatus = Models.Enums.SaleStatus.Canceled, Seller = s1 };

            // SalesRecord 12
            SalesRecord sr12 = new SalesRecord { Id = 12, Date = new DateTime(2024, 04, 23), Amount = 4800.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s2 };

            // SalesRecord 13
            SalesRecord sr13 = new SalesRecord { Id = 13, Date = new DateTime(2024, 04, 25), Amount = 5100.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s3 };

            // SalesRecord 14
            SalesRecord sr14 = new SalesRecord { Id = 14, Date = new DateTime(2024, 04, 27), Amount = 3900.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s4 };

            // SalesRecord 15
            SalesRecord sr15 = new SalesRecord { Id = 15, Date = new DateTime(2024, 01, 29), Amount = 4400.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s5 };

            // SalesRecord 16
            SalesRecord sr16 = new SalesRecord { Id = 16, Date = new DateTime(2024, 04, 02), Amount = 3200.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s1 };

            // SalesRecord 17
            SalesRecord sr17 = new SalesRecord { Id = 17, Date = new DateTime(2024, 03, 04), Amount = 3700.0, Salestatus = Models.Enums.SaleStatus.Pending, Seller = s2 };

            // SalesRecord 18
            SalesRecord sr18 = new SalesRecord { Id = 18, Date = new DateTime(2024, 04, 06), Amount = 4100.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s3 };

            // SalesRecord 19
            SalesRecord sr19 = new SalesRecord { Id = 19, Date = new DateTime(2024, 04, 08), Amount = 2900.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s4 };

            // SalesRecord 20
            SalesRecord sr20 = new SalesRecord { Id = 20, Date = new DateTime(2024, 04, 10), Amount = 3600.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s5 };

            // SalesRecord 21
            SalesRecord sr21 = new SalesRecord { Id = 21, Date = new DateTime(2024, 01, 12), Amount = 4800.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s6 };

            // SalesRecord 22
            SalesRecord sr22 = new SalesRecord { Id = 22, Date = new DateTime(2024, 04, 14), Amount = 5200.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s2 };

            // SalesRecord 23
            SalesRecord sr23 = new SalesRecord { Id = 23, Date = new DateTime(2024, 04, 16), Amount = 4100.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s3 };

            // SalesRecord 24
            SalesRecord sr24 = new SalesRecord { Id = 24, Date = new DateTime(2024, 04, 18), Amount = 3000.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s4 };

            // SalesRecord 25
            SalesRecord sr25 = new SalesRecord { Id = 25, Date = new DateTime(2024, 04, 20), Amount = 4700.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s5 };

            // SalesRecord 26
            SalesRecord sr26 = new SalesRecord { Id = 26, Date = new DateTime(2024, 04, 22), Amount = 3400.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s6 };

            // SalesRecord 27
            SalesRecord sr27 = new SalesRecord { Id = 27, Date = new DateTime(2024, 04, 24), Amount = 4100.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s2 };

            // SalesRecord 28
            SalesRecord sr28 = new SalesRecord { Id = 28, Date = new DateTime(2024, 04, 26), Amount = 3900.0, Salestatus = Models.Enums.SaleStatus.Canceled, Seller = s3 };

            // SalesRecord 29
            SalesRecord sr29 = new SalesRecord { Id = 29, Date = new DateTime(2024, 04, 28), Amount = 4200.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s6 };

            // SalesRecord 30
            SalesRecord sr30 = new SalesRecord { Id = 30, Date = new DateTime(2024, 04, 30), Amount = 4800.0, Salestatus = Models.Enums.SaleStatus.Billed, Seller = s5 };

            if (Context is not null)
            {
                Context.Department.AddRange(d1, d2, d3, d4);
                Context.Seller.AddRange(s1, s2, s3, s4, s5);
                Context.SalesRecords.AddRange(sr1, sr2, sr3, sr4, sr6, sr7, sr8, sr9, sr10, sr11, sr12, sr13, sr14, sr15, sr16, sr18, sr19, sr20, sr21, sr22, sr23, sr24, sr25, sr26, sr27, sr28, sr29, sr30);
                Context.SaveChanges();
            }

        }
    }
}
