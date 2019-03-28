using MvcDemo.DataAccess;
using System;
using System.Linq;
using MvcDemo.Common.Entities;
using MvcDemo.Common.Models;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new MvcDemoContext())
            {

                /*
                // Display all Blogs from the database
                var queryClients = from b in db.Portals
                            orderby b.PortalName
                            select b;

                Console.WriteLine("All clients(portals) in the database:");
                foreach (var item in queryClients)
                {
                    Console.WriteLine(string.Format("PortalId: {0} - {1}", item.Id, item.PortalName));
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                

                //Portals can have multiple Courses.
                var queryCourses = from b in db.CoursePortals
                            where b.PortalId == 449
                            orderby b.CoursePortalName
                            select b;

                Console.WriteLine("All courses for client 449 in the database:");
                foreach (var item in queryCourses)
                {
                    Console.WriteLine(string.Format("CoursePortalId: {0} - {1}", item.Id, item.CoursePortalName));
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();

    */
                var results = from r in db.Registrations
                              join u in db.Users on r.UserId equals u.Id
                              where (r.CoursePortalId == 100003)
                              select new UserModel
                              {
                                  Id = u.Id,
                                  FirstName = u.FirstName,
                                  LastName = u.LastName,
                                  RegistrationTime = r.RegistrationTime
                              };

                foreach (var item in results)
                {
                    Console.WriteLine(string.Format("UserId: {0} - {1} - {2} - {3}", item.Id, item.FirstName, item.LastName, item.RegistrationTime));
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();

            }
        }
    }
}
