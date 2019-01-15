namespace Aplication.ConectionString
{
    public static class ConectionString
    {
        //const string BaseDatos = "DistriPeluDb";

        //const string Servidor = @"DESKTOP-9HIFL63\NICOPC";

        //const string BaseDatos = "DistriPeluDB2018";

        //const string Servidor = @"DESKTOP-IS9FM4M\SQLTOUCEDA";

        const string BaseDatos = "Repositorio";

        const string Servidor = @"DESKTOP-I9AA7DR\SQLEXPRESS";

        //const string Servidor = @".";

        public static string GetWithWindows => $"Data Source={Servidor}; " +
                $"Initial Catalog={BaseDatos}; " +
                $"Integrated Security = true;";
    }
}
