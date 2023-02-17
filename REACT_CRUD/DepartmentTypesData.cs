using REACT_CRUD.Entity;
using System.Data;

namespace REACT_CRUD
{
    public class DepartmentTypesData
    {
        public static Guid HumanResources = Guid.Parse("C8678960-F943-4BE6-BCA3-2A28218D1556");
        public static Guid InformationTechnology = Guid.Parse("8E0DD012-46E8-4CA7-8612-CFC780D26FFC");
        public static Guid AccountingFinance = Guid.Parse("1DEEF805-3402-4FA2-A68E-EE500347F895");
        public static Guid Marketing = Guid.Parse("2669004F-85A5-4A5F-9EC0-34FFB84F0E87");
        public static Guid OperationsManagement = Guid.Parse("4BBF626E-E5D0-48A5-B590-A9DDF4CDA0AA");


        public static Dictionary<Guid?, DepartmentType> DepartmentTypes = new Dictionary<Guid?, DepartmentType>
        {
            {
                HumanResources,
                new DepartmentType
                {
                    Id = HumanResources,
                    Name = "Human Resources",
                    Description = "Human Resources",
                    CreatedDateTime =  new DateTimeOffset(new DateTime(2022, 4, 1,0,0,0, DateTimeKind.Unspecified), TimeSpan.Zero),
                    UpdatedDateTime =  new DateTimeOffset(new DateTime(2022, 4, 1,0,0,0, DateTimeKind.Unspecified), TimeSpan.Zero),
                }
            },
            {
                InformationTechnology,
                new DepartmentType
                {
                    Id = InformationTechnology,
                    Name = "Information Technology",
                    Description = "Information Technology",
                    CreatedDateTime =  new DateTimeOffset(new DateTime(2022, 4, 1,0,0,0, DateTimeKind.Unspecified), TimeSpan.Zero),
                    UpdatedDateTime =  new DateTimeOffset(new DateTime(2022, 4, 1,0,0,0, DateTimeKind.Unspecified), TimeSpan.Zero),
                }
            },
            {
                AccountingFinance,
                new DepartmentType
                {
                    Id = AccountingFinance,
                    Name = "Accounting & Finance",
                    Description = "Accounting & Finance",
                    CreatedDateTime =  new DateTimeOffset(new DateTime(2022, 4, 1,0,0,0, DateTimeKind.Unspecified), TimeSpan.Zero),
                    UpdatedDateTime =  new DateTimeOffset(new DateTime(2022, 4, 1,0,0,0, DateTimeKind.Unspecified), TimeSpan.Zero),
                }
            },
            {
                Marketing,
                new DepartmentType
                {
                    Id = Marketing,
                    Name = "Marketing",
                    Description = "Marketing",
                    CreatedDateTime =  new DateTimeOffset(new DateTime(2022, 4, 1,0,0,0, DateTimeKind.Unspecified), TimeSpan.Zero),
                    UpdatedDateTime =  new DateTimeOffset(new DateTime(2022, 4, 1,0,0,0, DateTimeKind.Unspecified), TimeSpan.Zero),
                }
            },
            {
                OperationsManagement,
                new DepartmentType
                {
                    Id = OperationsManagement,
                    Name = "Operations Management",
                    Description = "Operations Management",
                    CreatedDateTime =  new DateTimeOffset(new DateTime(2022, 4, 1,0,0,0, DateTimeKind.Unspecified), TimeSpan.Zero),
                    UpdatedDateTime =  new DateTimeOffset(new DateTime(2022, 4, 1,0,0,0, DateTimeKind.Unspecified), TimeSpan.Zero),
                }
            },
        };
    }
}
