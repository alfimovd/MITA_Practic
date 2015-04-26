using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using ADService.DataAccess;
using ADService.DataAccess.Model;

namespace ADService.RecreateDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check DB exists...");
            if (Database.Exists("ADServiceDb"))
            {
                Console.WriteLine("DB exists. Deleting...");
                Database.Delete("ADServiceDb");
            }
            else
            {
                Console.WriteLine("DB does not exist. Skip deleting.");
            }

            using (var db = new Db())
            {
                Console.WriteLine("Creating DB..");
                // Наполнение
                var transports = db.Transports.ToArray();

                var branch = new Branch()
                {
                    Address = "Красноярск",
                    Title = "Main",
                };
                db.Branches.Add(branch);
                db.SaveChanges();

                var tesla = new TransportManufacturer()
                {
                    Title = "Tesla",
                    Description = "electro cars"
                };
                db.TransportManufacturers.Add(tesla);
                db.SaveChanges();

                var modelS = new TransportModel()
                {
                    Title = "model S",
                    Description = "",
                    Manufacturer = tesla
                };
                var modelA = new TransportModel()
                {
                    Title = "model A",
                    Description = "",
                    Manufacturer = tesla
                };
                db.TransportModels.Add(modelS);
                db.TransportModels.Add(modelA);
                db.SaveChanges();

                var serviceCategory1 = new ServiceCategory()
                {
                    Title = "Обслуживание"
                };
                var serviceCategory2 = new ServiceCategory()
                {
                    Title = "Ремонт"
                };
                db.ServiceCategories.Add(serviceCategory1);
                db.ServiceCategories.Add(serviceCategory2);
                db.SaveChanges();

                var service1 = new Service()
                {
                    Title = "Помыть",
                    Category = serviceCategory1
                };
                var service2 = new Service()
                {
                    Title = "Заменить батарею",
                    Category = serviceCategory1
                };
                var service3 = new Service()
                {
                    Title = "Настройка",
                    Category = serviceCategory2
                };
                var service4 = new Service()
                {
                    Title = "Регулировка",
                    Category = serviceCategory2
                };
                db.Services.Add(service1);
                db.Services.Add(service2);
                db.Services.Add(service3);
                db.Services.Add(service4);
                db.SaveChanges();

                var servicePrice1 = new BranchService()
                {
                    Branch = branch,
                    Service = service1,
                    Price = 100.0,
                };
                var servicePrice2 = new BranchService()
                {
                    Branch = branch,
                    Service = service2,
                    Price = 200.0
                };
                var servicePrice3 = new BranchService()
                {
                    Branch = branch,
                    Service = service3,
                    Price = 300.0
                };
                var servicePrice4 = new BranchService()
                {
                    Branch = branch,
                    Service = service4,
                    Price = 400.0
                };
                db.BranchServices.Add(servicePrice1);
                db.BranchServices.Add(servicePrice2);
                db.BranchServices.Add(servicePrice3);
                db.BranchServices.Add(servicePrice4);
                db.SaveChanges();

                var componentCategory1 = new ComponentCategory()
                {
                    Title = "Силовая установка"
                };
                var componentCategory2 = new ComponentCategory()
                {
                    Title = "Подвеска",
                };
                db.ComponentCategories.Add(componentCategory1);
                db.ComponentCategories.Add(componentCategory2);
                db.SaveChanges();

                var component1 = new Component()
                {
                    Title = "Батарея",
                    Category = componentCategory1,
                };
                component1.TransportModels.Add(modelA);
                component1.TransportModels.Add(modelS);
                var component2 = new Component()
                {
                    Title = "Провода",
                    Category = componentCategory1
                };
                component2.TransportModels.Add(modelA);
                component2.TransportModels.Add(modelS);
                var component3 = new Component()
                {
                    Title = "Рычаг",
                    Category = componentCategory2
                };
                component3.TransportModels.Add(modelA);
                component3.TransportModels.Add(modelS);
                var component4 = new Component()
                {
                    Title = "Тяга",
                    Category = componentCategory2
                };
                component4.TransportModels.Add(modelA);
                component4.TransportModels.Add(modelS);
                db.Components.Add(component1);
                db.Components.Add(component2);
                db.Components.Add(component3);
                db.Components.Add(component4);
                db.SaveChanges();

                var exist = new Supplier()
                {
                    Title = "Exist",
                };
                db.Suppliers.Add(exist);
                db.SaveChanges();

                var componentPrice1 = new SupplierComponent()
                {
                    Price = 1000.0,
                    Amount = 10,
                    Component = component1,
                    Supplier = exist,
                    DeliveryTime = new TimeSpan(1, 0, 0),
                };
                var componentPrice2 = new SupplierComponent()
                {
                    Price = 5000.0,
                    Amount = 10,
                    Component = component2,
                    Supplier = exist,
                    DeliveryTime = new TimeSpan(1, 0, 0),
                };
                var componentPrice3 = new SupplierComponent()
                {
                    Price = 100.0,
                    Amount = 10,
                    Component = component3,
                    Supplier = exist,
                    DeliveryTime = new TimeSpan(1, 0, 0),
                };
                var componentPrice4 = new SupplierComponent()
                {
                    Price = 100.0,
                    Amount = 10,
                    Component = component4,
                    Supplier = exist,
                    DeliveryTime = new TimeSpan(1, 0, 0),
                };
                db.SupplierComponents.Add(componentPrice1);
                db.SupplierComponents.Add(componentPrice2);
                db.SupplierComponents.Add(componentPrice3);
                db.SupplierComponents.Add(componentPrice4);
                db.SaveChanges();

                Console.WriteLine("Creating employees and users..");
                var admin = new Manager
                {
                    Branch = branch,
                    FirstName = "Admin",
                    MiddleName = "Admin",
                    LastName = "Admin",
                    User = new User()
                    {
                        LastLoginTime = DateTime.Now,
                        Login = "admin",
                        Password = PasswordManager.CreateHash("admin"),
                        Role = Role.Admin
                    }
                };
                db.Managers.Add(admin);


                var Client = new Client()
                {
                    FirstName = "Client",
                    LastName = "Client",
                    MiddleName = "Client",
                    Email = "Client@Client.ru",
                    Phone = "888888888888",
                    RegistrationDate = DateTime.Now,
                };
                db.Clients.Add(Client);

                var transport1 = new Transport()
                {
                    Client = Client,
                    BodyNumber = "0000000000000",
                    EngimeNumber = "00000000000",
                    MileAge = 10000,
                    VIN = "ADDSFEFWE243565",
                    Model = modelA
                };
                var transport2 = new Transport()
                {
                    Client = Client,
                    BodyNumber = "0000000000000",
                    EngimeNumber = "111111111",
                    MileAge = 1000,
                    VIN = "ADDSFEFdfgdE243565",
                    Model = modelS
                };
                db.Transports.Add(transport1);
                db.Transports.Add(transport2);

                db.SaveChanges();
                Console.WriteLine("Done");
                Console.ReadLine();
            }
        }
    }
}
