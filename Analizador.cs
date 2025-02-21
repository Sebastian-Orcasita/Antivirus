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
        private Virus[] ListaVirus = null;
        private byte[] data = null;

        //Contadores
        int contadorVirusUSAMA = 0;
        int contadorVirusAMTRAX = 0;
        int contadorVirusEBOLA = 0;
        int contadorVirusAH1N1 = 0;
        int contadorVirusCOVID = 0;

        //Constructor
        public Analizador(byte[] bytesArchivo) {

            //Recibe los bytes del archivo seleccionado por el usuario
            data = bytesArchivo;

            //Crea la lista de virus que se van a buscar en el archivo
            crearListaVirus();
        
        }

        //Metodo donde se implementa el automata finito
        public string buscarVirus()
        {

           

            string estado = "q0";
            
            //Recorremos el vector de bytes del archivo seleccionado una sola vez
            for (int i = 0; i < data.Length-3; i++)
            {

                //Buscar USAMA
                if (data[i] == ListaVirus[0].getSecuencia()[0])
                {

                    estado = "q1";

                    if(data[i + 1] == ListaVirus[0].getSecuencia()[1])
                    {
                        estado = "q7";

                        if (data[i + 2] == ListaVirus[0].getSecuencia()[2])
                        {
                            estado = "q8";

                            if (data[i + 3] == ListaVirus[0].getSecuencia()[3]) 
                            {
                                estado = "q9";
                                contadorVirusUSAMA++;
                            }
                        }
                    }

                }

                //Buscar ÉBOLA
                if (data[i] == ListaVirus[1].getSecuencia()[0])
                {

                    estado = "q3";

                    if (data[i + 1] == ListaVirus[1].getSecuencia()[1])
                    {
                        estado = "q15";

                        if (data[i + 2] == ListaVirus[1].getSecuencia()[2])
                        {
                            estado = "q14";

                            if (data[i + 3] == ListaVirus[1].getSecuencia()[3])
                            {
                                estado = "q16";
                                contadorVirusEBOLA++;
                            }
                        }
                    }

                }

                //Buscara AMTRAX
                if (data[i] == ListaVirus[2].getSecuencia()[0])
                {

                    estado = "q2";

                    if (data[i + 1] == ListaVirus[2].getSecuencia()[1])
                    {
                        estado = "q5";

                        if (data[i + 2] == ListaVirus[2].getSecuencia()[2])
                        {
                            estado = "q10";

                            if (data[i + 3] == ListaVirus[2].getSecuencia()[3])
                            {
                                estado = "q11";
                                contadorVirusAMTRAX++;
                            }
                        }
                    }

                }

                //Buscar AH1N1
                if (data[i] == ListaVirus[3].getSecuencia()[0])
                {

                    estado = "q2";

                    if (data[i + 1] == ListaVirus[3].getSecuencia()[1])
                    {
                        estado = "q6";

                        if (data[i + 2] == ListaVirus[3].getSecuencia()[2])
                        {
                            estado = "q12";

                            if (data[i + 3] == ListaVirus[3].getSecuencia()[3])
                            {
                                estado = "q13";
                                contadorVirusAH1N1++;
                            }
                        }
                    }

                }

                //Buscar COVID
                if (data[i] == ListaVirus[4].getSecuencia()[0])
                {

                    estado = "q4";

                    if (data[i + 1] == ListaVirus[4].getSecuencia()[1])
                    {
                        estado = "q17";

                        if (data[i + 2] == ListaVirus[4].getSecuencia()[2])
                        {
                            estado = "q18";

                            if (data[i + 3] == ListaVirus[4].getSecuencia()[3])
                            {
                                estado = "q19";
                                contadorVirusCOVID++;
                            }
                        }
                    }

                }

            }
            return estado;
        }
        //metodo para crear una lista de virus 
        private void crearListaVirus() {

            //Inicializando
            ListaVirus = new Virus[5];


            //Crean la instancia de la clase VIRUS para cada uno de los elementos
            Virus usama = new Virus("USAMA", new byte[] { 15, 30, 15, 49 });
            Virus ebola = new Virus("Ébola", new byte[] { 29, 32, 53, 29 });
            Virus amtrax = new Virus("Amtrax", new byte[] { 72, 72, 15, 29 });
            Virus ah1n1 = new Virus("AH1N1", new byte[] { 72, 32, 32, 20 });
            Virus covid = new Virus("Covid 19", new byte[] { 30, 25, 20, 19 });

            //Almacenando los virus en una lista
            ListaVirus[0] = usama;
            ListaVirus[1] = ebola;
            ListaVirus[2] = amtrax;
            ListaVirus[3] = ah1n1;
            ListaVirus[4] = covid;

        }
        // metodo para obtener la cantidad de veces que se encontró el virus USAMA
        public int getCountUsama() {

            return contadorVirusUSAMA;

        }
        // metodo para obtener la cantidad de veces que se encontró el virus AMTRAX
        public int getCountAMTRAX()
        {

            return contadorVirusAMTRAX;

        }
        // metodo para obtener la cantidad de veces que se encontró el virus EBOLA
        public int getCountEBOLA()
        {

            return contadorVirusEBOLA;

        }
        // metodo para obtener la cantidad de veces que se encontró el virus AH1N1
        public int getCountAH1N1()
        {

            return contadorVirusAH1N1;

        }
        // metodo para obtener la cantidad de veces que se encontró el virus COVID
        public int getCountCOVID()
        {

            return contadorVirusCOVID;

        }
    }
}
