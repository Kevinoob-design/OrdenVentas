using System;

namespace OrdenVentas.utilidades
{
  class ReporteColumna
  {

    #region "variables"

    private string m_Etiqueta;
    private int m_Tamanio;
    private bool m_Negrita;
    private int m_AlineacionEtiqueta;
    private int m_AlineacionValor;
    private string m_Formato;
    private string m_Fuente;
    private float m_FuenteTamanio;

    #endregion

    #region "constructor"

    /// <summary>
    /// Inicializa una nueva instancia de clase <see cref="ReporteColumna"/>, para el intercambio de información entre clases
    /// </summary>
    /// <param name="Etiqueta">Etiqueta de la columna</param>
    /// <param name="Tamanio">Tamaño de la columna, en una escala de 1 a 100 si la orientación es vertical y de 1 a 150 si es horizontal</param>
    /// <param name="Negrita">true = Negrita, false = Normal</param>
    /// <param name="AlineacionEtiqueta">Alineación de la Etiqueta <see cref="iTextSharp.text.Element"/></param>
    /// <param name="AlineacionValor">Alineación del Contenido o Valor <see cref="iTextSharp.text.Element"/></param>
    /// <param name="Formato">Formato del Contenido o Valor</param>
    /// <param name="Fuente">Fuente o Tipo de letra <see cref="iTextSharp.text.FontFactory"/></param>
    /// <param name="FuenteTamanio">Tamaño de la fuente o letra</param>
    public ReporteColumna(string Etiqueta, int Tamanio, bool Negrita, int AlineacionEtiqueta, int AlineacionValor, string Formato, string Fuente, float FuenteTamanio)
    {
      try
      {
        // asignar valores
        m_Etiqueta = Etiqueta;
        m_Tamanio = Tamanio;
        m_Negrita = Negrita;
        m_AlineacionEtiqueta = AlineacionEtiqueta;
        m_AlineacionValor = AlineacionValor;
        m_Formato = Formato;
        m_Fuente = Fuente;
        m_FuenteTamanio = FuenteTamanio;
      }
      catch (Exception Ex)
      {
        // heredar
        throw Ex;
      }
    }

    #endregion

    #region "propiedades"

    public string Etiqueta
    {
      get { return m_Etiqueta; }
      set { m_Etiqueta = value; }
    }

    public int Tamanio
    {
      get { return m_Tamanio; }
      set { m_Tamanio = value; }
    }

    public bool Negrita
    {
      get { return m_Negrita; }
      set { m_Negrita = value; }
    }

    public int AlineacionEtiqueta
    {
      get { return m_AlineacionEtiqueta; }
      set { m_AlineacionEtiqueta = value; }
    }

    public int AlineacionValor
    {
      get { return m_AlineacionValor; }
      set { m_AlineacionValor = value; }
    }

    public string Formato
    {
      get { return m_Formato; }
      set { m_Formato = value; }
    }

    public string Fuente
    {
      get { return m_Fuente; }
      set { m_Fuente = value; }
    }

    public float FuenteTamanio
    {
      get { return m_FuenteTamanio; }
      set { m_FuenteTamanio = value; }
    }

    #endregion
  }
}
