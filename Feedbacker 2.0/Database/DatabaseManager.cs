using System.ComponentModel;
using System.Data.SQLite;
using System.Diagnostics;

namespace Feedbacker_2._0.Database
{
    public class DatabaseManager
    {

        private SortedBindingList<Course> courses = new SortedBindingList<Course>(TypeDescriptor.GetProperties(typeof(Course))["Name"], ListSortDirection.Ascending);

        public DatabaseManager()
        {

        }

        internal SortedBindingList<Course> Courses { get => courses; set => courses = value; }

        /// <summary>
        /// Drops all tables from the database by executing SQL commands to remove courses, assignments, and responses tables.
        /// </summary>
        /// <param name="connection">The SQLite connection to the database.</param>
        private void dropAllTables(SQLiteConnection connection)
        {
            using var command = new SQLiteCommand(connection);

            command.CommandText = "DROP TABLE IF EXISTS courses";
            command.ExecuteNonQuery();

            command.CommandText = "DROP TABLE IF EXISTS assignments";
            command.ExecuteNonQuery();

            command.CommandText = "DROP TABLE IF EXISTS responses";
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Saves the current state of the application's database to a SQLite database file.
        /// Drops existing tables, creates new tables, and inserts data into the new tables.
        /// </summary>
        /// <param name="filePath">The file path where the database should be saved.</param>
        public void saveDatabaseToFile(string filePath)
        {
            using SQLiteConnection connection = establishDatabaseConnection(filePath);
            dropAllTables(connection);
            createDatabaseTables(connection);
            insertAllDataToDatabase(connection);
        }

        /// <summary>
        /// Establishes a new SQLite database connection using the provided file path.
        /// </summary>
        /// <param name="filePath">The file path for the SQLite database.</param>
        /// <returns>An opened SQLiteConnection instance connected to the specified database file.</returns>
        private SQLiteConnection establishDatabaseConnection(string filePath)
        {
            string connectionString = $@"URI=file:{filePath}";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            return connection;
        }

        /// <summary>
        /// Inserts data from the application's data model into the SQLite database.
        /// Populates the courses, assignments, and responses tables with relevant information.
        /// </summary>
        /// <param name="connection">The SQLite connection to the database.</param>
        public void insertAllDataToDatabase(SQLiteConnection connection)
        {
            using var command = new SQLiteCommand(connection);

            foreach (Course course in courses)
            {
                command.CommandText = @$"INSERT INTO courses(CourseName, CourseDescription)
                VALUES(
                    '{course.Name}',
                    '{course.Description}')";
                command.ExecuteNonQuery();
                foreach (Assignment assignment in course.Assignments)
                {

                    command.CommandText = @$"INSERT INTO assignments(CourseId, AssignmentTitle, AssignmentDescription, AssignmentPosition) 
                        VALUES(
                            (SELECT Id FROM courses WHERE CourseName = '{course.Name}'),
                            '{assignment.Name}',
                            '{assignment.Description}',
                            {assignment.Position})";
                    command.ExecuteNonQuery();
                    foreach (Response response in assignment.Responses)
                    {
                        command.CommandText = @$"INSERT INTO responses(AssignmentId, ResponseTitle, ResponseText) 
                            VALUES(
                                (SELECT Id FROM assignments WHERE AssignmentTitle = '{assignment.Name}'),
                                '{response.Name}',
                                '{response.Message}')";
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        /// <summary>
        /// Creates new tables in the SQLite database to store courses, assignments, and responses.
        /// </summary>
        /// <param name="connection">The SQLite connection to the database.</param>
        public void createDatabaseTables(SQLiteConnection connection)
        {
            using var command = new SQLiteCommand(connection);

            command.CommandText = @"CREATE TABLE courses (
                Id INTEGER NOT NULL, 
                CourseName TEXT NOT NULL, 
                CourseDescription TEXT, 
                PRIMARY KEY(Id AUTOINCREMENT))";
            command.ExecuteNonQuery();

            command.CommandText = @"CREATE TABLE assignments (
                Id INTEGER NOT NULL, 
                CourseId INTEGER NOT NULL, 
                AssignmentTitle TEXT NOT NULL, 
                AssignmentDescription TEXT, 
                AssignmentPosition INTEGER, 
                FOREIGN KEY(CourseId) REFERENCES courses(Id), 
                PRIMARY KEY(Id AUTOINCREMENT))";
            command.ExecuteNonQuery();

            command.CommandText = @"CREATE TABLE responses (
                Id INTEGER NOT NULL, 
                AssignmentId  INTEGER NOT NULL, 
                ResponseTitle TEXT NOT NULL, 
                ResponseText TEXT, 
                FOREIGN KEY(AssignmentId) REFERENCES assignments(Id), 
                PRIMARY KEY(Id AUTOINCREMENT))";
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Loads data from an SQLite database file into the application's data model.
        /// Reads information about courses, assignments, and responses from the database file.
        /// </summary>
        /// <param name="filePath">The file path of the SQLite database to load.</param>
        public void loadDatabaseFromFile(string filePath)
        {
            //TODO: refactor this method into 3 parts.

            using SQLiteConnection connection = establishDatabaseConnection(filePath);
            string stm = "SELECT * FROM courses";
            using var cmd = new SQLiteCommand(stm, connection);
            SQLiteDataReader reader;
            //making sure there are no errors. IE table does not exist yet.
            try
            {
                reader = cmd.ExecuteReader();

            }
            catch (SQLiteException exception)
            {
                Debug.WriteLine(exception.Message);
                return;
            }

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                //string description = rdr.GetString(2);
                string description = "description";
                Course course = new Course(id, name, description);
                Courses.Add(course);
            }
            reader.Close();

            foreach (Course course in Courses)
            {
                string stm2 = $"SELECT * FROM assignments WHERE CourseId='{course.Id}'";
                using var cmd2 = new SQLiteCommand(stm2, connection);
                SQLiteDataReader rdr2;
                //making sure there are no errors. IE table does not exist yet.
                try
                {
                    rdr2 = cmd2.ExecuteReader();

                }
                catch (SQLiteException exception)
                {
                    Debug.WriteLine(exception.Message);
                    return;
                }
                while (rdr2.Read())
                {
                    int id2 = rdr2.GetInt32(0);
                    string name2 = rdr2.GetString(2);
                    int position = rdr2.GetInt32(4);

                    //TODO: attach course inside course.addAssignment();
                    Assignment assignment = new Assignment(id2, name2, "Description", position, course);
                    course.Assignments.Add(assignment);
                }
                rdr2.Close();
            }

            foreach (Course course in courses)
            {
                foreach (Assignment assignment in course.Assignments)
                {
                    string stm3 = $"SELECT * FROM responses WHERE AssignmentId='{assignment.Id}'";
                    using var cmd3 = new SQLiteCommand(stm3, connection);
                    SQLiteDataReader rdr3;
                    //making sure there are no errors. IE table does not exist yet.
                    try
                    {
                        rdr3 = cmd3.ExecuteReader();

                    }
                    catch (SQLiteException exception)
                    {
                        Debug.WriteLine(exception.Message);
                        return;
                    }
                    while (rdr3.Read())
                    {
                        int id3 = rdr3.GetInt32(0);
                        string name3 = rdr3.GetString(2);
                        string message = rdr3.GetString(3);

                        //TODO: attach assignment inside assignment.addResponse();
                        Response response = new Response(id3, name3, message, assignment);
                        assignment.Responses.Add(response);
                    }
                    rdr3.Close();
                }

            }

        }
    }
}
