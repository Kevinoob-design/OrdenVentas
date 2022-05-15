using System;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections;

namespace OrdenVentas.utilidades
{
  class Reporte
  {

    #region "variables"

    private static string m_Logotipo;

    #endregion

    #region "constructor"

    /// <summary>
    /// Inicializa una nueva instancia de clase <see cref="Reporte"/>
    /// </summary>
    /// <param name="Logotipo">Ruta y nombre del logotipo que se muestra en el encabezado</param>
    public Reporte(string Logotipo){
      try
      {
        // asignar valor
        m_Logotipo = Logotipo;
      }
      catch (Exception Ex) 
      {
        // heredar
        throw Ex;
      }
    }

    #endregion 

    #region "reporte"

    /// <summary>
    /// Generar el reporte PDF con las caracteristícas e información proporcionada
    /// </summary>
    /// <param name="ReporteNombre">Ruta y nombre del archivo a crear</param>
    /// <param name="PapelTamanio">Tipo de papel <see cref="iTextSharp.text.Rectangle"/></param>
    /// <param name="Encabezado">Encabezado del reporte</param>
    /// <param name="SubEncabezado">Subencabezado del reporte</param>
    /// <param name="PiePagina">Pie de página del reporte</param>
    /// <param name="EncabezadoColumnas">Arreglo de columnas que contiene el reporte</param>
    /// <param name="dtbDatos"><see cref="DataTable"/> con la información a imprimir</param>
    public void Generar(string ReporteNombre, Rectangle PapelTamanio, string Encabezado, string SubEncabezado, string PiePagina, ArrayList EncabezadoColumnas, DataTable dtbDatos)
    {
      FileStream fsTmp = new FileStream(ReporteNombre, FileMode.Create);
      Document docTmp = new Document(PapelTamanio, 36, 36, 72, 27);
      PdfWriter m_writerTmp;
      IPdfPageEvent m_peTmp;
      PdfPTable tablaTmp = new PdfPTable(EncabezadoColumnas.Count);
      PdfPCell celdaTmp;
      Font fuenteTmp = new Font();
      int[] iTamanio = new int[EncabezadoColumnas.Count];
      ReporteColumna udtCIDTmp;
      try
      {

        // No hay información a imprimir.
        if (dtbDatos.Rows.Count == 0) {
          throw new System.Exception("No hay información para imprimir.");
        }

        // asignar documento y evento
        m_writerTmp = PdfWriter.GetInstance(docTmp, fsTmp);
        m_peTmp = new ReportePagina(Encabezado, SubEncabezado, PiePagina, EncabezadoColumnas, m_Logotipo, true);
        m_writerTmp.PageEvent = m_peTmp;

        // adicionar propiedades
        docTmp.AddTitle(Comun.AppNombre());
        docTmp.AddAuthor("Vidal TI Consultor");
        docTmp.AddCreator(Comun.AppNombre());

        // abrir documento
        docTmp.Open();

        // asignar ancho
        tablaTmp.WidthPercentage = 100;

        // obtener ancho de columnas
        for (int i = 0; i <= EncabezadoColumnas.Count - 1; i++)
        {
          // obtener columna
          udtCIDTmp = (ReporteColumna)EncabezadoColumnas[i];

          // obtener tamaño de la columna
          iTamanio[i] = udtCIDTmp.Tamanio;

          // destruir
          udtCIDTmp = null;
        }

        // fijar ancho de columnas
        tablaTmp.SetWidths(iTamanio);

        // por cada registro
        foreach (DataRow drwTmp in dtbDatos.Rows)
        {
          // por cada columna
          for (int i = 0; i <= EncabezadoColumnas.Count - 1; i++)
          {
            // obtener columna
            udtCIDTmp = (ReporteColumna)EncabezadoColumnas[i];

            // crear fuente
            fuenteTmp = new Font();
            fuenteTmp = FontFactory.GetFont(udtCIDTmp.Fuente, udtCIDTmp.FuenteTamanio, Font.NORMAL);

            // asignar información
            if (udtCIDTmp.Formato.Length > 0)
            {
              // con formato
              if (!Convert.IsDBNull(drwTmp[i])){
                celdaTmp = new PdfPCell(new Phrase(String.Format("{0:" + udtCIDTmp.Formato + "}", drwTmp[i]), fuenteTmp));
              } else 
              {
                celdaTmp = new PdfPCell(new Phrase(" ", fuenteTmp));
              }
            } else 
            {
              // sin formato
              if (!Convert.IsDBNull(drwTmp[i]))
              {
                celdaTmp = new PdfPCell(new Phrase(drwTmp[i].ToString(), fuenteTmp));
              }
              else
              {
                celdaTmp = new PdfPCell(new Phrase(" ", fuenteTmp));
              }
            }

            // adicionar
            celdaTmp.Border = PdfPCell.NO_BORDER;
            celdaTmp.HorizontalAlignment = udtCIDTmp.AlineacionValor;
            celdaTmp.VerticalAlignment = Element.ALIGN_MIDDLE;
            tablaTmp.AddCell(celdaTmp);

            // resetear
            udtCIDTmp = null;
          }
        }
        // adicionar línea en blanco
        celdaTmp = new PdfPCell(new Phrase(" ", fuenteTmp))
        {
          Border = PdfPCell.NO_BORDER,
          Colspan = EncabezadoColumnas.Count,
          HorizontalAlignment = Element.ALIGN_RIGHT,
          VerticalAlignment = Element.ALIGN_TOP
        };
        tablaTmp.AddCell(celdaTmp);

        // adicionar tabla con la información
        docTmp.Add(tablaTmp);
      }
      catch (Exception Ex) 
      {
        // heredar
        throw Ex;
      } finally {
        // cerrar
        if (docTmp.IsOpen()) docTmp.Close();
        fsTmp.Close();
      }
    }

    #endregion
  }
}