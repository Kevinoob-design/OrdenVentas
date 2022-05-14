﻿using System;
using System.Collections.Generic;
using System.Data;
using OV_Datos;
using OV_Entidad;

namespace OV_Negocio
{
    public class BaseDto
    {
        public DataSet Consultar(StoredProcedures sp, Tables table, Dictionary<string, string> paramsDto = null)
        {
            string tableConsult = table.ToString();
            string spExec = sp.ToString();

            return DbAdapter.LoadBackToDataSetWithSp(tableConsult, spExec, paramsDto);
        }

        public void Guardar(StoredProcedures sp, Dictionary<string, string> paramsDto, string keyId = "")
        {
            if (paramsDto.ContainsKey(keyId)) paramsDto.Remove(keyId);
            string spExec = sp.ToString();

            DbAdapter.ExecSp(spExec, paramsDto);
        }

        public void Actualizar(StoredProcedures sp, Dictionary<string, string> paramsDto, string keyId = "")
        {
            if (!paramsDto.ContainsKey(keyId)) throw new Exception("El ID del cliente es requerido");
            string spExec = sp.ToString();

            DbAdapter.ExecSp(spExec, paramsDto);
        }
    }
}
