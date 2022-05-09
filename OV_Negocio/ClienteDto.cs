using System;
using System.Collections.Generic;
using System.Data;
using OV_Datos;
using OV_Entidad;

namespace OV_Negocio
{
    public class ClienteDto
    {
        public DataSet consultar(Dictionary<string, string> clienteParams = null)
        {
            string tableConsultarClientes = Tables.CLIENTES.ToString();
            string spNameConsultarClientes = StoredProcedures.consultarClientes.ToString();

            return DbAdapter.LoadBackToDataSetWithSp(tableConsultarClientes, spNameConsultarClientes, clienteParams);
        }

        public void guardar(Dictionary<string, string> clienteParams)
        {
            if (clienteParams.ContainsKey("ID")) clienteParams.Remove("ID");

            string spNameConsultarClientes = StoredProcedures.guardarCliente.ToString();

            DbAdapter.ExecSp(spNameConsultarClientes, clienteParams);
        }

        public void actualizar(Dictionary<string, string> clienteParams)
        {
            if (!clienteParams.ContainsKey("ID")) throw new Exception("El ID del cliente es requerido");

            string spNameConsultarClientes = StoredProcedures.actualizarCliente.ToString();

            DbAdapter.ExecSp(spNameConsultarClientes, clienteParams);
        }
    }
}
