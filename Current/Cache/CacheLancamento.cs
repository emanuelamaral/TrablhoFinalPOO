using System;

namespace Current.Cache
{
    public static class CacheLancamento
    {
        public static Guid? LancamentoID { get; set; }
        public static string NomeLancamento { get; set; }
        public static decimal Valor { get; set; }
        public static string TipoDeLancamento { get; set; }
        public Usuario usuario { get; set; }

    }
}
