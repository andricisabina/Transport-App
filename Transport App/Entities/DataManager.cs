using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Transport_App.Entities
{
    public class DataManager
    {
        private TransportContext _context;

        public DataManager(TransportContext context)
        {
            _context = context;
        }

        public void SerializeDrivers(string filePath)
        {
            var drivers = _context.Drivers.ToList();
            var jsonString = JsonSerializer.Serialize(drivers);
            File.WriteAllText(filePath, jsonString);
        }

        public void DeserializeDrivers(string filePath)
        {
            if (File.Exists(filePath))
            {
                var jsonString = File.ReadAllText(filePath);
                var drivers = JsonSerializer.Deserialize<List<Driver>>(jsonString);

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Drivers ON");

                        foreach (var driver in drivers)
                        {
                            var existingDriver = _context.Drivers.SingleOrDefault(d => d.DriverId == driver.DriverId);
                            if (existingDriver != null)
                            {
                                // Update existing record
                                existingDriver.LastName = driver.LastName;
                                existingDriver.FirstName = driver.FirstName;
                                existingDriver.LicenseNumber = driver.LicenseNumber;
                                existingDriver.PhoneNumber = driver.PhoneNumber;
                                existingDriver.Email = driver.Email;
                            }
                            else
                            {
                                // Add new record
                                _context.Drivers.Add(driver);
                            }
                        }

                        _context.SaveChanges();
                        _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Drivers OFF");
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void SerializeRoutes(string filePath)
        {
            var routes = _context.Routes.ToList();
            var jsonString = JsonSerializer.Serialize(routes);
            File.WriteAllText(filePath, jsonString);
        }

        public void DeserializeRoutes(string filePath)
        {
            if (File.Exists(filePath))
            {
                var jsonString = File.ReadAllText(filePath);
                var routes = JsonSerializer.Deserialize<List<Route>>(jsonString);

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Routes ON");

                        foreach (var route in routes)
                        {
                            var existingRoute = _context.Routes.SingleOrDefault(r => r.RouteId == route.RouteId);
                            if (existingRoute != null)
                            {
                                // Update existing record
                                existingRoute.Origin = route.Origin;
                                existingRoute.Destination = route.Destination;
                                existingRoute.Distance = route.Distance;
                            }
                            else
                            {
                                // Add new record
                                _context.Routes.Add(route);
                            }
                        }

                        _context.SaveChanges();
                        _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Routes OFF");
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void SerializeTransports(string filePath)
        {
            var transports = _context.Transports.ToList();
            var jsonString = JsonSerializer.Serialize(transports);
            File.WriteAllText(filePath, jsonString);
        }

        public void DeserializeTransports(string filePath)
        {
            if (File.Exists(filePath))
            {
                var jsonString = File.ReadAllText(filePath);
                var transports = JsonSerializer.Deserialize<List<Transport>>(jsonString);

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Transports ON");

                        foreach (var transport in transports)
                        {
                            var existingTransport = _context.Transports.SingleOrDefault(t => t.TransportId == transport.TransportId);
                            if (existingTransport != null)
                            {
                                // Update existing record
                                existingTransport.DriverId = transport.DriverId;
                                existingTransport.RouteId = transport.RouteId;
                                existingTransport.Date = transport.Date;
                                existingTransport.LoadDetails = transport.LoadDetails;
                            }
                            else
                            {
                                // Add new record
                                _context.Transports.Add(transport);
                            }
                        }

                        _context.SaveChanges();
                        _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Transports OFF");
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}

