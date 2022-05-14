namespace OV_Entidad
{
    public struct Articulo
    {
        public int IDARTICULO { get; set; }
        public int IDCATEGORIA { get; set; }
        public string CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public double PRECIO_VENTA { get; set; }
        public int STOCK { get; set; }
        public string DESCRIPCION { get; set; }
        public bool ESTADO { get; set; }
    }
}
