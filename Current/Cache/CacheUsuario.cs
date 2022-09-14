using System;

namespace Current.Cache
{
    public static class CacheUsuario
    {
        public static Guid? UsuarioID { get; set; }
        public static string Nome { get; set; }
        public static DateTime? DataDeNascimento { get; set; }
        public static string Celular { get; set; }
        public static string Cpf { get; set; }
        public static string Senha { get; set; }

    }
}
