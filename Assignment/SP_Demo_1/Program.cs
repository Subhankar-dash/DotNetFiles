using System.Data.SqlClient;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
SqlConnection Conn = null;
SqlCommand Cmd = null;
try
{
    Conn = new SqlConnection("Data Source=.;Initial Catalog=Office;Integrated Security=SSPI");
    Conn.Open();

    Cmd = Conn.CreateCommand();
    Cmd.CommandType = System.Data.CommandType.StoredProcedure;
    //Cmd.CommandText = "sp_getAllEmployees";
    Cmd.CommandText = "sp_getSumOfSalaryByDeptNo";

    

    //var reader = Cmd.ExecuteReader();
    //while (reader.Read())
    //{
    //    Console.WriteLine($"{reader["EmpNo"]} {reader["EmpName"]}");
    //}
    //reader.Close();



    SqlParameter pDeptNo = new SqlParameter();
    pDeptNo.ParameterName = "@DeptNo";
    pDeptNo.DbType = System.Data.DbType.Int32;
    pDeptNo.Direction = System.Data.ParameterDirection.Input;
    pDeptNo.Value = 20;
    Cmd.Parameters.Add(pDeptNo);

    SqlParameter pSumSal = new SqlParameter();
    pSumSal.ParameterName = "@SumSalary";
    pSumSal.DbType = System.Data.DbType.Int32;
    pSumSal.Direction = System.Data.ParameterDirection.ReturnValue;
    Cmd.Parameters.Add(pSumSal);
    object result = Cmd.ExecuteScalar();

    Console.WriteLine($"result {pSumSal.Value}");
    Console.WriteLine(result);


    Conn.Close();


}

finally
{

    Conn.Dispose();
}

Cmd.CommandText = "sp_getSumOfSalaryByDeptNo";


try
{
    Conn.Open();

    SqlParameter pDeptNo = new SqlParameter();
    pDeptNo.ParameterName = "@DeptNo";
    pDeptNo.DbType = System.Data.DbType.Int32;
    pDeptNo.Direction = System.Data.ParameterDirection.Input;
    pDeptNo.Value = 20;
    Cmd.Parameters.Add(pDeptNo);

    SqlParameter pSumSal = new SqlParameter();
    pSumSal.ParameterName = "@DeptNo";
    pSumSal.DbType = System.Data.DbType.Int32;
    pSumSal.Direction = System.Data.ParameterDirection.ReturnValue;
    pSumSal.Value = 20;
    Cmd.Parameters.Add(pSumSal);
    object result = Cmd.ExecuteReader().ToString();

    Console.WriteLine($"result {pSumSal.Value}");

    
    Conn.Close();
}
catch (Exception ex)
{
    Console.WriteLine($"Error {ex.Message}");
}
finally
{
    Conn.Dispose();
}
//Cmd.CommandText = "sp_InsertDept";

//// Now using the Parameters
//SqlParameter pDeptNo = new SqlParameter();
//pDeptNo.ParameterName = "@DeptNo";
//pDeptNo.DbType = System.Data.DbType.Int32;
//pDeptNo.Direction = System.Data.ParameterDirection.Input; // DEfault is Input
//pDeptNo.Value = 90;
//Cmd.Parameters.Add(pDeptNo);

//SqlParameter pDeptName = new SqlParameter();
//pDeptName.ParameterName = "@DeptName";
//pDeptName.DbType = System.Data.DbType.String;
//pDeptName.Direction = System.Data.ParameterDirection.Input; // DEfault is Input
//pDeptName.Size = 100;
//pDeptName.Value = "Dept_90";
//Cmd.Parameters.Add(pDeptName);

//SqlParameter pLocation = new SqlParameter();
//pLocation.ParameterName = "@Location";
//pLocation.DbType = System.Data.DbType.String;
//pLocation.Direction = System.Data.ParameterDirection.Input; // DEfault is Input
//pLocation.Size = 100;
//pLocation.Value = "Pune";
//Cmd.Parameters.Add(pLocation);


//SqlParameter pCapaity = new SqlParameter();
//pCapaity.ParameterName = "@Capacity";
//pCapaity.DbType = System.Data.DbType.Int32;
//pCapaity.Direction = System.Data.ParameterDirection.Input; // DEfault is Input
//pCapaity.Value = 900;
//Cmd.Parameters.Add(pCapaity);

//int result = Cmd.ExecuteNonQuery();
//if(result > 0)
//    Console.WriteLine("Record Added");
//Console.WriteLine("Failed");


// USing Input and Output Parameter

//    Cmd.CommandText = "sp_getSumOfSalByDeptNoWitOutput";
//    SqlParameter pDeptNo = new SqlParameter();
//    pDeptNo.ParameterName = "@DeptNo";
//    pDeptNo.DbType = System.Data.DbType.Int32;
//    pDeptNo.Direction = System.Data.ParameterDirection.Input; // DEfault is Input
//    pDeptNo.Value = 10;
//    Cmd.Parameters.Add(pDeptNo);


//    SqlParameter pResultSalary = new SqlParameter();
//    pResultSalary.ParameterName = "@ResultSalary";
//    pResultSalary.DbType = System.Data.DbType.Int32;
//    pResultSalary.Direction = System.Data.ParameterDirection.Output; // DEfault is Input
//    Cmd.Parameters.Add(pResultSalary);
//    // Only Execute the SP
//    object result = Cmd.ExecuteScalar();

//    Console.WriteLine($"Sum of the Salary for DeptNo = {pDeptNo.Value} = {pResultSalary.Value}");

//    Conn.Close();
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Error {ex.Message}");
//}
//finally
//{

//    Conn.Dispose();
//}