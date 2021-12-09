using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //Para trabajar con  hilos.
using System.Threading;       //Para trabajar con  hilos.
using System.Windows.Forms;

namespace DesktopApp.SplashScreen
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            //Creando el hilo
            Thread myThread = new Thread(new ThreadStart(SplashStart));

            //Iniciar el hilo
            myThread.Start();

        }

        // Funcion a llamar como delegado en la clases de sistema ThreadStar()
        public void SplashStart()
        {
            // Dormir la forma principal por 5seg, solo fines de prueba, aqui iria lo que queremos cargar.
            Thread.Sleep(5000);

            this.Invoke((MethodInvoker)delegate {

                this.Close();

            });

        }



    }
}
