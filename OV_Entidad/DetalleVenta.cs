using System;

namespace OV_Entidad
{
    public struct DetalleVenta
    {
        public int IDDETALLE { get; set; }
        public int IDVENTA { get; set; }
        public int IDARTICULO { get; set; }
        public float PRECIO { get; set; }
        public float DESCUENTO { get; set; }
    }
}
