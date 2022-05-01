using System;

namespace OV_Entidad
{
    public struct Venta
    {
        public int IDVENTA { get; set; }
        public int IDCLIENTE { get; set; }
        public int IDUSUARIO { get; set; }
        public string TIPO_COMPROBANTE { get; set; }
        public string SERIE_COMPROBANTE { get; set; }
        public string NUM_COMPROBANTE { get; set; }
        public DateTime FECHA_HORA { get; set; }
        public float IMPUESTO { get; set; }
        public float TOTAL { get; set; }
        public string ESTADO { get; set; }
    }
}
