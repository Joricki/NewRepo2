using System.Data.SqlClient;

namespace EducationApp
{

    public class PersonalData
    {
        public static string IdStudentOrTeacnher { get; private set; }
        public static string Fam { get; private set; }
        public static string Name { get; private set; }
        public static string FatherName { get; private set; }
        public static string Role { get; private set; } = "Преподаватель";
        public bool SetPersonalData(string login, string password)
        {
            var db = new DB();

            string sqlExpression = "SELECT " +
                                    " CASE WHEN пр.[ID Преподавателя] IS NOT NULL THEN пр.[ID Преподавателя] ELSE с.[ID Студента] END AS [ID Студента или преподавателя], " +
                                    " CASE WHEN пр.Фамилия IS NOT NULL THEN пр.Фамилия ELSE с.Фамилия END AS [Фамилия], " +
                                    " CASE WHEN пр.Имя IS NOT NULL THEN пр.Имя ELSE с.Имя END AS Имя, " +
                                    " CASE WHEN пр.Отчество IS NOT NULL THEN пр.Отчество ELSE с.Отчество END AS Отчество, " +
                                    " Роль " +
                                    " FROM Пользователи п " +
                                    " LEFT JOIN Студенты с ON с.[ID Пользователя] = п.[ID Пользователя] " +
                                    " LEFT JOIN Преподаватели пр ON п.[ID Пользователя] = пр.[ID Пользователя] " +
                                    " WHERE п.логин=@Login AND п.Пароль=@Password";

            using (SqlConnection connection = new SqlConnection(db.StringConn))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlExpression, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            IdStudentOrTeacnher = reader["ID Студента или преподавателя"].ToString();
                            Fam = reader["Фамилия"].ToString();
                            Name = reader["Имя"].ToString();
                            FatherName = reader["Отчество"].ToString();
                            Role = reader["Роль"].ToString();
                            return true;
                        }
                    }
                    return false;
                }
            }
        }
    }
}
