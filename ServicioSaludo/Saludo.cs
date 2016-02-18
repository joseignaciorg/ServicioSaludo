using System;
using System.Runtime.Serialization;

namespace ServicioSaludo
{
    [DataContract]
    public class Saludo
    {
        public static String[] soportado = {"es", "en", "fr"}; //soportado no se va a enviar al cliente en el xml al no llevar DataMember y por lo tanto no estar dentro del contrato

        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public String Idioma { get; set; }
    }
}