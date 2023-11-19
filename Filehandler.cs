namespace FileHandler{
using Microsoft.Data.SQLite;
    class FileHandler{
        public required string FilePath{get; init;}
        public FileHandler(string filepath){
            FilePath = filepath;
            foreach(string command in Constants.DbConstants.Commands.INITIALIZE_DB){

}
}
    }
}