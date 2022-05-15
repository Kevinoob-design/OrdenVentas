using System;
using System.Collections.Generic;
using System.Data;
using OV_Datos;
using OV_Entidad;

namespace OV_Negocio
{
    public class BaseDto
    {
        public List<T> Consultar<T>(StoredProcedures sp, Dictionary<dynamic, string> paramsDto = null) where T : new()
        {
            string spExec = sp.ToString();

            return DbAdapter.LoadDataFromSp<T>(spExec, paramsDto);
        }
        public DataSet ConsultarToDs(StoredProcedures sp, Tables table, Dictionary<dynamic, string> paramsDto = null)
        {
            string tableConsult = table.ToString();
            string spExec = sp.ToString();

            return DbAdapter.LoadBackToDataSetWithSp(tableConsult, spExec, paramsDto);
        }

        public void Guardar(StoredProcedures sp, Dictionary<dynamic, string> paramsDto, string keyId = "")
        {
            if (paramsDto.ContainsKey(keyId)) paramsDto.Remove(keyId);
            string spExec = sp.ToString();

            DbAdapter.ExecSp(spExec, paramsDto);
        }

        public void Actualizar(StoredProcedures sp, Dictionary<dynamic, string> paramsDto, string keyId = "")
        {
            if (!paramsDto.ContainsKey(keyId)) throw new Exception("El ID del cliente es requerido");
            string spExec = sp.ToString();

            DbAdapter.ExecSp(spExec, paramsDto);
        }
    }
}
