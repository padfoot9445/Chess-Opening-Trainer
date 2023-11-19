namespace FileHandler
{
    using Constants;
    using Microsoft.Data.Sqlite;
    class FileHandler
    {
        public string FilePath{ get; init; }
        private protected SqliteConnection connection;
        public FileHandler(string fp){
            FilePath = fp;
            connection = new SqliteConnection($"Data Source={fp}");
            connection.Open();
            Init();
        }
        void Init(){
            foreach(string command in DBConstants.Commands.MAKE_TABLES_COMMANDS){
                ExecuteNonQuery(command);
            }
        }
        void ExecuteNonQuery(string command){
            using(var mCommand = new SqliteCommand(command, connection)){
                    mCommand.ExecuteNonQuery();
            }
        }
        SqliteDataReader ExecuteQuery(string command) => new SqliteCommand(command, connection).ExecuteReader();
    }
}
