using System.Data.SqlClient;
namespace UserInputDB
{
    internal class Program
    {
        static SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Integrated Security = True");
        static SqlCommand cmd = new SqlCommand("", conn);

        static void Main(string[] args)
        {
            while (true)
            {
                createDBandTable();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1) Create");
                Console.WriteLine("2) Edit");
                Console.WriteLine("3) Delete");
                Console.WriteLine("4) Show one");
                Console.WriteLine("5) Show all");
                Console.WriteLine("n to quit");
                string input = Console.ReadLine();
                if (input.Equals("1"))
                    insertData();
                else if (input.Equals("2"))
                    Edit();
                else if (input.Equals("3"))
                    Delete();
                else if (input.Equals("4"))
                    ShowOne();
                else if (input.Equals("5"))
                    ShowAll();
                else if (input.Equals("n"))
                    break;
            }
        }

        static void ShowAll()
        {
            try
            {
                conn.Open();
                cmd.CommandText = "select * from people";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine();
                    Console.WriteLine("ID: " + reader["Id"]);
                    Console.WriteLine("Firstname: " + reader["firstname"]); ;
                    Console.WriteLine("Secondname: " + reader["secondname"]);
                    Console.WriteLine("Age: " + reader["age"]);
                    Console.WriteLine("Grade: " + reader["grade"]);
                    Console.WriteLine();
                }
                conn.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void ShowOne()
        {
            Console.Write("Column to Search: ");
            string columnToSearch = Console.ReadLine();
            Console.Write("Value you want to find: ");
            string value = Console.ReadLine();
            if (columnToSearch.Equals("firstname") || columnToSearch.Equals("secondname"))
            {
                cmd.CommandText = "select * from people where " + columnToSearch + "=" + "'" + value + "'";
            }
            else if (columnToSearch.Equals("Id") || columnToSearch.Equals("age") || columnToSearch.Equals("grade"))
                cmd.CommandText = "select * from people where " + columnToSearch + "=" + value;
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine();
                    Console.WriteLine("ID: " + reader["Id"]);
                    Console.WriteLine("Firstname: " + reader["firstname"]); ;
                    Console.WriteLine("Secondname: " + reader["secondname"]);
                    Console.WriteLine("Age: " + reader["age"]);
                    Console.WriteLine("Grade: " + reader["grade"]);
                    Console.WriteLine();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void Delete()
        {
            Console.Write("Column to Search: ");
            string columnToSearch = Console.ReadLine();
            Console.Write("Value you want to find: ");
            string value = Console.ReadLine();
            if (columnToSearch.Equals("firstname") || columnToSearch.Equals("secondname"))
            {
                cmd.CommandText = "delete from people where " + columnToSearch + "=" + "'" + value + "'";
            }
            else if (columnToSearch.Equals("Id") || columnToSearch.Equals("age") || columnToSearch.Equals("grade"))
                cmd.CommandText = "delete from people where " + columnToSearch + "=" + value;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void Edit()
        {
            Console.Write("Column to edit: ");
            string columnToSearch = Console.ReadLine();
            Console.Write("Value you want to find: ");
            string value = Console.ReadLine();
            Console.Write("new Value: ");
            string newVal = Console.ReadLine();
            if (columnToSearch.Equals("firstname") || columnToSearch.Equals("secondname"))
                cmd.CommandText = "update people set " + columnToSearch + "=" + newVal + "where " + columnToSearch + "=" + "'" + value + "'";
            else if (columnToSearch.Equals("Id") || columnToSearch.Equals("age") || columnToSearch.Equals("grade"))
                cmd.CommandText = "update people set " + columnToSearch + "=" + newVal + "where " + columnToSearch + "=" + value;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        static void insertData()
        {
            Console.Write("Firstname: ");
            string firstname = Console.ReadLine();
            Console.Write("Secondname: ");
            string secondname = Console.ReadLine();
            Console.Write("Age: ");
            string age = Console.ReadLine();
            Console.Write("Grade: ");
            string grade = Console.ReadLine();
            cmd.CommandText = "insert into people values('" + firstname + "', '" + secondname + "', '" + age + "', '" + grade + "')";
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void createDBandTable()
        {
            try
            {
                conn.Open();
                cmd.CommandText = "select Count(*) from sys.databases where name = 'dbWithUserInput'";
                bool exists = cmd.ExecuteScalar().ToString().Equals("0") ? false : true;
                if (!exists)
                {
                    cmd.CommandText = "create database dbWithUserInput";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    conn.ConnectionString = "Server=(localdb)\\MSSQLLocalDB; Integrated Security = True; database = dbWithUserInput";
                    conn.Open();
                    cmd.CommandText = "CREATE TABLE [dbo].[people]([Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), [firstname] NCHAR(20), [secondname] NCHAR(20), [age] int, [grade] int)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO people VALUES('Luca','Staffner', 17, 1);";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.ConnectionString = "Server=(localdb)\\MSSQLLocalDB; Integrated Security = True; database = dbWithUserInput";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}