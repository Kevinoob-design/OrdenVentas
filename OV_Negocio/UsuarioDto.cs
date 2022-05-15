using System;
using System.Collections.Generic;
using OV_Datos;
using OV_Entidad;

namespace OV_Negocio
{
    public class UsuarioDto : BaseDto
    {
        public bool Login(Dictionary<string, string> usuarioParams)
        {
            if (!usuarioParams.ContainsKey("USUARIO")) throw new Exception("La propiedad de usuario debe estar presente");

            if (!usuarioParams.ContainsKey("PASSWORD")) throw new Exception("La propiedad de password debe estar presente");

            string spNameLogin = StoredProcedures.login.ToString();

            List<Usuario> usuario = DbAdapter.LoadDataFromSp<Usuario>(spNameLogin, usuarioParams);

            return usuario.Count > 0 ? true : false;
        }
    }
}
