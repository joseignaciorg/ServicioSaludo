using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioSaludo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ISaludosService
    {
        [OperationContract]
        string Saludar(Saludo saludo);

        bool Soportado(string idioma); //soportado aqui tampoco va a ser serializada al no tener el atributo operationcontract (desde el cliente no lo vamos a poder llamar)
    }
}
