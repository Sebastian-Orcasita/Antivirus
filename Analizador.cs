using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antivirus
{
    //Clase encargada de buscar los virus en el archivo
    internal class Analizador
    {
        //Declaración
        private Virus[] ListaVirus;
        private byte[] data;

        //Constructor
        public Analizador() {

            crearListaVirus();
        
        }

        //Metodo donde se implementa el automata
        public void buscarVirus(byte[] bytesArchivo)
        {

            data = bytesArchivo;
            string estado = "q0";
            //Recorremos el vector de bytes
            for (int i = 0; i < data.Length; i++)
            {

                //USAMA
                if(data[i] == ListaVirus[0].getSecuencia()[0])
                {
                    estado = "q1";

                    if(data[i + 1] == ListaVirus[0].getSecuencia()[1])
                    {
                        estado = "q2";

                        if (data[i +2] == ListaVirus[0].getSecuencia()[2])
                        {
                            estado = "q3";

                            if (data[i + 3] == ListaVirus[0].getSecuencia()[3]) 
                            {
                                estado = "q4";
                                //USAMA
                                Console.WriteLine(estado + " USAMA");
                            }
                        }
                    }

                } 

            }
        }

        private void crearListaVirus() {

            //Inicializando
            ListaVirus = new Virus[5];

            //Crean la instancia de la clase VIRUS para cada uno de los elementos
            Virus usama = new Virus("USAMA", new byte[] { 15, 30, 15, 49 });
            Virus ebola = new Virus("Ébola", new byte[] { 15, 30, 15, 49 });
            Virus amtrax = new Virus("Amtrax", new byte[] { 15, 30, 15, 49 });
            Virus ah1n1 = new Virus("AH1N1", new byte[] { 15, 30, 15, 49 });
            Virus covid = new Virus("Covid 19", new byte[] { 15, 30, 15, 49 });

            //Almacenando los virus en una lista
            ListaVirus[0] = usama;
            ListaVirus[1] = ebola;
            ListaVirus[2] = amtrax;
            ListaVirus[3] = ah1n1;
            ListaVirus[4] = covid;


        }

    }
}
