using System;
using System.Windows.Forms;

namespace OrdenVentas.utilidades
{
  class Comun
  {

    /// <summary>
    /// Wscala del logotipo 
    /// </summary>
    public static int AppLogoEscala = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["AppLogoEscala"]);

    /// <summary>
    /// Ruta y nombre del logotipo 
    /// </summary>
    public static string AppLogotipo = System.Configuration.ConfigurationManager.AppSettings["AppLogotipo"];

    /// <summary>
    /// Ruta donde se guarda el reporte 
    /// </summary>
    public static string AppRutaReporte = System.Configuration.ConfigurationManager.AppSettings["AppRutaReporte"];

    /// <summary>
    /// Verificar si está en ejecucíón la aplicación
    /// </summary>
    /// <returns>Verdadero si está en ejecución y Falso si no está en ejecución</returns>
    public static bool AppEjecucion()
    {
      try
      {
        // verificar si está en ejecución la aplicación
        if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).GetUpperBound(0) > 0)
          return true;
        else
          return false;
      }
      catch (Exception Ex)
      {
        // heredar
        throw Ex;
      }
    }

    ///
    /// <summary>
    /// Obtener la ruta desde donde se está ejecutando la aplicación
    /// </summary>
    /// <returns>Ruta desde donde se está ejecutando la aplicación</returns>
    public static string AppRuta()
    {
      // obtener la ruta donde se esta ejecutando la aplicación
      string sRuta = Application.StartupPath;
      try
      {
        // verificar
        if (sRuta.LastIndexOf("bin") > 0)
        {
          // recortar ruta
          sRuta = sRuta.Substring(0, sRuta.LastIndexOf("bin"));
        }
        else
        {
          // adicionar diagonal final
          sRuta += @"\";
        }
        // final
        return sRuta;
      }
      catch (Exception Ex)
      {
        // heredar
        throw Ex;
      }
    }

    /// <summary>
    /// Obtener el nombre de la aplicación
    /// </summary>
    /// <returns>Nombre de la aplicación</returns>
    public static string AppNombre()
    {
      try
      {
        // nombre de la aplicación
        return "Generar reportes PDF con iTextSharp";
      }
      catch (Exception Ex)
      {
        // heredar
        throw Ex;
      }
    }

  }
}
