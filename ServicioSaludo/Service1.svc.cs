using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.UI.WebControls;

namespace ServicioSaludo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class SaludosService : ISaludosService
    {
        public string Saludar(Saludo saludo)
        {
            if (Soportado(saludo.Idioma))
                return $"Hola {saludo.Nombre} en {saludo.Idioma}";
            throw new FaultException(new FaultReason("Idioma no soportado"));
        }
        

        public bool Soportado(string idioma)
        {
            return Saludo.soportado.Contains(idioma);
        }
    }
}
