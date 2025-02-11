using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antivirus
{
    internal class Virus
    {
        //Atributos de un Virus
        private String NombreVirus;
        private byte[] SecuenciaVirus;

        //Constructor
        public Virus(String Nombre, byte[] secuencia) { 
        
            NombreVirus = Nombre;
            SecuenciaVirus = secuencia;
        
        }

        //Metodos de los atributos
        public String getNombreVirus() { return NombreVirus; }
        public void getNombreVirus(String nombre) { NombreVirus = nombre; }
        public byte[] getSecuencia() { return SecuenciaVirus; }

    }
}
