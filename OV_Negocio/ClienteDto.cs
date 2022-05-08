using System;
using System.Collections.Generic;
using OV_Datos;
using OV_Entidad;

namespace OV_Negocio
{
    public class ClienteDto
    {
        public List<Cliente> consultar(Dictionary<string, string> clienteParams)
        {
            if (!clienteParams.ContainsKey("USUARIO")) throw new Exception("La propiedad de usuario debe estar presente");

            if (!clienteParams.ContainsKey("PASSWORD")) throw new Exception("La propiedad de password debe estar presente");

            string spNameConsultarClientes = storedProcedures.consultarClientes.ToString();

            return DbAdapter.LoadDataFromSp<Cliente>(spNameConsultarClientes, clienteParams);
        }
    }
}
