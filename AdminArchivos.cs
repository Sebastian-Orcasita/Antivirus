using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Antivirus
{

    //Clase encargada de obtener los bytes de un archivo en cualquier formato
    internal class AdminArchivos
    {

        private byte[] bytesArchivo;
        private string nombreArchivo;

        // Constructor de la clase AdminArchivos
        public AdminArchivos(string nombreArchivo) {

            this.nombreArchivo = nombreArchivo;
        
        }

        // Método que lee y devuelve los bytes de un archivo
        public byte[] leerBytes() {

            //Funcionalidad de la clase File que permite obtener bytes de un archivo
            bytesArchivo = File.ReadAllBytes(nombreArchivo);

            //Devuelve los bytes del archivo
            return bytesArchivo;
        
        }
    }
}
