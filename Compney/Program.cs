using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compney.Models;

namespace Compney
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compney");
            Console.WriteLine("Choose Your Catagories");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2.Admin Details");
            Console.WriteLine("3.Leaves");
            Console.WriteLine("4.Project");
            Console.WriteLine("5.Get Employee");
            Console.WriteLine("6.Get Business");
            string caseSwitch = Console.ReadLine();
            switch (caseSwitch)
            {
                case "1":

                    Console.WriteLine("Admin Site ");
                    Console.WriteLine("1.Admin");
                    Console.WriteLine("2.Compney");
                    Console.WriteLine("3.Business");
                    Console.WriteLine("4.Employee");

                    string caseString2 = Console.ReadLine();
                    switch (caseString2)
                    {
                        case "1":
                            Console.WriteLine("1.Add Admin");
                            Console.WriteLine("2.Remove Admin");
                            
                            string admin = Console.ReadLine();
                            switch (admin)
                            {
                                case "1":
                                    addAdmin();

                                    break;
                                case "2":
                                    removeAdmin();

                                    break;
                               
                                default:
                                    Console.WriteLine("Value didn’t match earlier.");
                                    break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("1.Add Compney");
                            Console.WriteLine("2.Remove Compney");
                            Console.WriteLine("2.List of compney");
                            string comp = Console.ReadLine();
                            switch (comp)
                            {
                                case "1":
                                    addCompney();

                                    break;
                                case "2":
                                    removeCompney();

                                    break;
                                case "3":
                                    getCompney();

                                    break;
                                default:
                                    Console.WriteLine("Value didn’t match earlier.");
                                    break;
                            };
                            break;
                        case "3":
                            Console.WriteLine("1.Add Business");
                            Console.WriteLine("2.Remove Business");
                            
                            string buss = Console.ReadLine();
                            switch (buss)
                            {
                                case "1":
                                    addBusiness();

                                    break;
                                case "2":
                                    removeBusiness();

                                    break;
                                
                                default:
                                    Console.WriteLine("Value didn’t match earlier.");
                                    break;
                            }
                            break;
                        case "4":
                            Console.WriteLine("1.Add Employee");
                            Console.WriteLine("2.Remove Employee");
                            
                            string emp = Console.ReadLine();
                            switch (emp)
                            {
                                case "1":
                                    addEmployees();

                                    break;
                                case "2":
                                    removeEmployees();

                                    break;
                                
                                    break;
                                default:
                                    Console.WriteLine("Value didn’t match earlier.");
                                    break;
                            }
                            break;

                        default:
                            Console.WriteLine("Value didn’t match earlier.");
                            break;
                    }

                    break;
                case "2":
                    Console.WriteLine("AdminDetails");
                    getAdmin();
                    break;
                case "3":
                    Console.WriteLine("Leaves");
                    Console.WriteLine("1.Add Leaves");
                    Console.WriteLine("2.Remove Leaves");
                    Console.WriteLine("3.Get All Leaves");
                   
                    string caseString4 = Console.ReadLine();
                    switch (caseString4)
                    {
                        case "1":
                            addLeaves();
                            break;
                        case "2":

                            removeLeaves();
                            break;
                        case "3":
                            getLeaves();
                            break;
                        
                        default:
                            Console.WriteLine("Value didn’t match earlier.");
                            break;
                    }
                    break;
                case "4":
                    Console.WriteLine("Project");
                    Console.WriteLine("1.Add Project");
                    Console.WriteLine("2.Remove Project");
                    Console.WriteLine("3.Get All Project");

                    string proj = Console.ReadLine();
                    switch (proj)
                    {
                        case "1":
                            addProject();
                            break;
                        case "2":

                            removeProject();
                            break;
                        case "3":
                            getProject();
                            break;

                        default:
                            Console.WriteLine("Value didn’t match earlier.");
                            break;
                    }
                    break;
                case "5":
                    Console.WriteLine("Get Employee details ");
                    getEmployee();
                    break;
                case"6":
                    Console.WriteLine("Get Business details ");
                    getBusiness();
                    break;
                
                default:
                    Console.WriteLine("Value didn’t match earlier.");
                    break;
            }
            Console.ReadLine();
        }
        static void addEmployees()
        {
            using (var context = new Context())
            {
                Admins ad = new Admins();
                Console.WriteLine("Enter UserName");
                ad.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                ad.Password = Console.ReadLine();
                var check = context.Admins.SingleOrDefault(t => t.UserName == ad.UserName && t.Password == ad.Password);
                if (check != null)
                {
                    try
                    {
                        Employees dp = new Employees();
                        Console.WriteLine("Enter Employee Name");
                        dp.Name = Console.ReadLine();
                        Console.WriteLine("Enter Gender ");
                        dp.Gender = Console.ReadLine();
                        Console.WriteLine("Enter Employ Type ");
                        dp.EmployeType = Convert.ToInt32(Console.ReadLine());
                        context.Employees.Add(dp);
                        context.SaveChanges();


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect UserName or Password");
                }
            }

        }
        static void removeEmployees()
        {
            using (var context = new Context())
            {
                Admins ad = new Admins();
                Console.WriteLine("Enter UserName");
                ad.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                ad.Password = Console.ReadLine();
                var check = context.Admins.SingleOrDefault(t => t.UserName == ad.UserName && t.Password == ad.Password);
                if (check != null)
                {
                    try
                    {
                        Employees hp = new Employees();
                        Console.WriteLine("Enter Employee Id");
                        hp.EmployeeId = Convert.ToInt32(Console.ReadLine());

                        context.Employees.Remove(hp);
                        context.SaveChanges();

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect UserName or Password");
                }
            }

        }
        static void getEmployee()
        {
            using(var context = new Context())
            {
                Employees hp = new Employees();

                foreach (var item in context.Employees.ToList())
                {
                    Console.WriteLine($"ID {item.EmployeeId}  Name {item.Name} Gender{item.Gender} -EmployeType{item.EmployeType} ");
                }
            }

        }
        static void addProject()
        {
            using (var context = new Context())
            {
                Leaves ad = new Leaves();
                Console.WriteLine("Enter Employee Id");
                ad.EmployeeId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter StartDate");
                ad.FromDate = Console.ReadLine();
                var check = context.Leaves.SingleOrDefault(t => t.EmployeeId == ad.EmployeeId && t.FromDate == ad.FromDate);
                if (check == null)
                {
                    try
                    {
                        Projects dp = new Projects();
                        Console.WriteLine("Enter Project Name");
                        dp.ProjectName = Console.ReadLine();
                        Console.WriteLine("Enter Description");
                        dp.Description = Console.ReadLine();
                        Console.WriteLine("Enter Business Id");
                        dp.BusinessId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Id");
                        dp.EmployeeId = Convert.ToInt32(Console.ReadLine());
                        context.Projects.Add(dp);
                        context.SaveChanges();


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("Employee is On leave");
                }
            
            
            }
        }
        static void removeProject()
        {
            using (var context = new Context())
            {
                Projects hp = new Projects();
                Console.WriteLine("Enter Project Id");
                hp.ProjectId = Convert.ToInt32(Console.ReadLine());

                context.Projects.Remove(hp);
                context.SaveChanges();
            }

        }
        static void getProject()
        {
            using(var context = new Context())
            {
                Projects hp = new Projects();

                foreach (var item in context.Projects.ToList())
                {
                    Console.WriteLine($"ID {item.ProjectId}  Name {item.ProjectName} Detail{item.Description} -BusinessId{item.BusinessId}- EmployeeId{item.EmployeeId} ");
                }
            }

        }
        static void addCompney()
        {
            using (var context = new Context())
            {
                Admins ad = new Admins();
                Console.WriteLine("Enter UserName");
                ad.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                ad.Password = Console.ReadLine();
                var check = context.Admins.SingleOrDefault(t => t.UserName == ad.UserName && t.Password == ad.Password);
                if (check != null)
                {
                    try
                    {
                        Compneys dp = new Compneys();
                        Console.WriteLine("Enter Compney Name");
                        dp.CompneyName = Console.ReadLine();
                        
                        
                        context.Compneys.Add(dp);
                        context.SaveChanges();


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect UserName or Password");
                }
            }
        }
        static void removeCompney()
        {
            using (var context = new Context())
            {
                Admins ad = new Admins();
                Console.WriteLine("Enter UserName");
                ad.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                ad.Password = Console.ReadLine();
                var check = context.Admins.SingleOrDefault(t => t.UserName == ad.UserName && t.Password == ad.Password);
                if (check != null)
                {
                    try
                    {
                        Compneys hp = new Compneys();
                        Console.WriteLine("Enter Compneys Id");
                        hp.CompneyId = Convert.ToInt32(Console.ReadLine());

                        context.Compneys.Remove(hp);
                        context.SaveChanges();

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect UserName or Password");
                }
            }
        }
        static void getCompney()
        {
            using(var context = new Context())
            {
                Compneys hp = new Compneys();

                foreach (var item in context.Compneys.ToList())
                {
                    Console.WriteLine($"ID {item.CompneyId}  Name {item.CompneyName}  ");
                }
            }

        }
        static void addBusiness()
        {
            using (var context = new Context())
            {
                Admins ad = new Admins();
                Console.WriteLine("Enter UserName");
                ad.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                ad.Password = Console.ReadLine();
                var check = context.Admins.SingleOrDefault(t => t.UserName == ad.UserName && t.Password == ad.Password);
                if (check != null)
                {
                    try
                    {
                        Business dp = new Business();
                        Console.WriteLine("Enter Business Name");
                        dp.BusinessName = Console.ReadLine();
                        Console.WriteLine("Enter compney Id");
                        dp.CompneyId = Convert.ToInt32(Console.ReadLine());
                        context.Businesses.Add(dp);
                        context.SaveChanges();


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect UserName or Password");
                }
            }
        }
        static void removeBusiness()
        {
            using (var context = new Context())
            {
                Admins ad = new Admins();
                Console.WriteLine("Enter UserName");
                ad.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                ad.Password = Console.ReadLine();
                var check = context.Admins.SingleOrDefault(t => t.UserName == ad.UserName && t.Password == ad.Password);
                if (check != null)
                {
                    try
                    {
                        Business hp = new Business();
                        Console.WriteLine("Enter Business Id");
                        hp.BusinessId = Convert.ToInt32(Console.ReadLine());

                        context.Businesses.Remove(hp);
                        context.SaveChanges();

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect UserName or Password");
                }
            }
        }
        static void getBusiness()
        {
            using(var context = new Context())
            {
                Business hp = new Business();

                foreach (var item in context.Businesses.ToList())
                {
                    Console.WriteLine($"ID {item.BusinessId}  Name {item.BusinessName} CompneyId{item.CompneyId} ");
                }
            }

        }
        static void addLeaves()
        {
            using (var context = new Context())
            {
                Leaves dp = new Leaves();
                Console.WriteLine("Enter Leave Discription");
                dp.Descriptions = Console.ReadLine();
                Console.WriteLine("Enter From Date");
                dp.FromDate = Console.ReadLine();
                Console.WriteLine("Enter To Date");
                dp.ToDate = Console.ReadLine();
                Console.WriteLine("Enter Employee Id");
                dp.EmployeeId = Convert.ToInt32(Console.ReadLine());
                context.Leaves.Add(dp);
                context.SaveChanges();
            }
        }
        static void removeLeaves()
        {
            using(var context = new Context())
            {
                Leaves hp = new Leaves();
                Console.WriteLine("Enter Leave Id");
                hp.LeaveId = Convert.ToInt32(Console.ReadLine());

                context.Leaves.Remove(hp);
                context.SaveChanges();
            }

        }
        static void getLeaves()
        {
            using(var context = new Context())
            {
                Leaves hp = new Leaves();

                foreach (var item in context.Leaves.ToList())
                {
                    Console.WriteLine($"ID {item.LeaveId}  Description {item.Descriptions} FromDate{item.FromDate}-ToDate{item.ToDate} -EmployeeId{item.EmployeeId}");
                }
            }
        }
        static void addAdmin()
        {
            using (var context = new Context())
            {
                Admins ad = new Admins();
                Console.WriteLine("Enter UserName");
                ad.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                ad.Password = Console.ReadLine();
                var check = context.Admins.SingleOrDefault(t => t.UserName == ad.UserName && t.Password == ad.Password);
                if (check != null)
                {
                    try
                    {
                        Admins dp = new Admins();
                        Console.WriteLine("Enter UserName Name");
                        dp.UserName = Console.ReadLine();
                        Console.WriteLine("Enter Password");
                        dp.Password = Console.ReadLine();
                        
                        context.Admins.Add(dp);
                        context.SaveChanges();


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect UserName or Password");
                }
            }
        }
        static void removeAdmin()
        {
            using (var context = new Context())
            {
                Admins ad = new Admins();
                Console.WriteLine("Enter UserName");
                ad.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                ad.Password = Console.ReadLine();
                var check = context.Admins.SingleOrDefault(t => t.UserName == ad.UserName && t.Password == ad.Password);
                if (check != null)
                {
                    try
                    {
                        Admins hp = new Admins();
                        Console.WriteLine("Enter Address Id");
                        hp.Id = Convert.ToInt32(Console.ReadLine());

                        context.Admins.Remove(hp);
                        context.SaveChanges();

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect UserName or Password");
                }
            }
        }
        static void getAdmin()
        {
            using (var context = new Context())
            {
                Admins hp = new Admins();


                foreach (var item in context.Admins.ToList())
                {
                    Console.WriteLine($"ID {item.Id}  Name {item.UserName} Password{item.Password} ");
                }
            }

        }


    }
}
