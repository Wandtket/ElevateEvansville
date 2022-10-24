namespace ElevateEvansville_API
{
    public class ElevateEvansvilleConnection
    {
        public string Catalog { get; internal set; }

        public string Server { get; internal set; }

        public string UserID { get; internal set; }

        public string Password { get; internal set; }

        public string ConnectionString => $"Server={Server},1433;Initial Catalog={Catalog};Persist Security Info=False;User ID={UserID};Password={Password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";

        internal ElevateEvansvilleConnection() { }
    }


    public class Connections
    {
        /// <summary>
        /// Connection information for Kentucky production databases.
        /// </summary>
        public static ElevateEvansvilleConnection Azure = new ElevateEvansvilleConnection()
        {
            Catalog = "ElevateEvansville",
            Server = "tcp:wandtket.database.windows.net",
            UserID = "Wandtket",
            Password = ")u9f3]>{Z1hsxIHN,}gw",
        };
    }
}
