namespace HRDept.Inf.MsSqlImpl
{
    public class SqlQueries
    {
        public static string AddEmployee = @"";

        public static string AddDepartment = @"insert into department (id,lead_id, name) values (@Id,1,@Name)";

        public static string AddBaseDepartment =
            @"insert into department (id,lead_id, name) values (@Id,@Lead_id,@Name)";

        public static string AddVacancy = @"";

        public static string UpdateEmployee = @"";

        public static string FireEmployee = @"";

        public static string GetEmployee = @"";

        public static string GetVacancy = @"";
    }
}
