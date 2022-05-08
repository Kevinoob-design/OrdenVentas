using System;
using System.Collections.Generic;
using OV_Datos;
using OV_Entidad;

namespace OV_Negocio
{
    public class UsuarioDto
    {
        public bool login(Dictionary<string, string> usuarioParams)
        {
            if (!usuarioParams.ContainsKey("USUARIO")) throw new Exception("La propiedad de usuario debe estar presente");

            if (!usuarioParams.ContainsKey("PASSWORD")) throw new Exception("La propiedad de password debe estar presente");

            List<Usuario> usuario = DbAdapter.LoadDataFromSp<Usuario>("consultarUsuario", usuarioParams);

            return usuario.Count > 0 ? true : false;
        }
    }
}
