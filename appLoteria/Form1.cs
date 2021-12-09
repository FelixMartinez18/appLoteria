using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appLoteria
{
    public partial class Form1 : Form
    {
        //hare una baraja para introducir las cartas que salieron
        Stack<int> cartas = new Stack<int>();
        //usare un objeto de tipo aleatorio para sacar las cartas sin repetir
        Random rnd = new Random();
        //usare un contador para posicionar en el imagenlist
        int i = 0;        
        
        const int CANTIDAD_CARTAS = 54;
        private PictureBox[] carta;
        private PictureBox[] tabla;


        public Form1()
        {
            InitializeComponent();
            carta = new PictureBox[CANTIDAD_CARTAS];
            tabla = new PictureBox[25];
            inicializartabla();
        }
        private void inicializartabla()
        {
            int r = 0, c = 0;

            int[] carta = new int[34];

            for (int i = 0; i < carta.Length; i++)
            {
                carta[i] = i + 1;
            }
            //Recorrer el arreglo para SWAP - Triangular INTERCAMBIAR un elemeto al azar
            Random rnd = new Random();
            int a, aux;
            for (int i = 0; i < carta.Length; i++)
            {
                a = rnd.Next(carta.Length);
                aux = carta[i];
                carta[i] = carta[a];
                carta[a] = aux;

            }

            for (int i = 0; i < tabla.Length; i++)
            {
                tabla[i] = new PictureBox();
                tabla[i].Location = new System.Drawing.Point(35 + (c * 90), 25 + (r * 125));
                tabla[i].Name = "pictureBox1";
                tabla[i].Size = new System.Drawing.Size(85, 120);
                tabla[i].TabIndex = 0 + i;
                tabla[i].SizeMode = PictureBoxSizeMode.StretchImage;
                tabla[i].TabStop = false;
                tabla[i].Image = Image.FromFile(@"cartas\" + (carta[i]) + ".jpg");
                this.Controls.Add(tabla[i]);
                c++;
                if (c == 5)
                {
                    r++;
                    c = 0;
                }
            }
        }
        private void From_Load(object sender, EventArgs e)
        {
            //Voy a poner un formato listview y a "relacionarlo" con el imagenlist (que va a contener las cartas)
            this.listView1.View = View.LargeIcon;
            this.imageList1.ImageSize = new Size(143, 185);
            this.listView1.LargeImageList = this.imageList1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //primero voy a poner el label para saber cuantas cartas faltan por salir 
            label1.Text = (54 - cartas.Count()).ToString();

            //utilizare una variable auxiliar para saber cuando sacar otra carta
            bool bandera = false;

            //antes de introducir o hacer algo para mostrar alguna carta, voy a validar si ya salieron las 54 
            if (cartas.Count() == 54)
            {
                bandera = true;
                //Muestra un mensaje donde ya salieron todas las cartas
                MessageBox.Show("Son todas las cartas", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Ahora hare un un bucle para hacerlo mientras la variable auxilar es false
            //Esto me permitira mostrar la carta y meterla en la baraja (para que no se repita)
            while (!bandera){
                //Ahora hare un numero aleatorio del 1 al 54 con el obejtivo de random
                int num = rnd.Next(1, 54);
                //Ahora vamos a ver que el numero aleatorio NO este dentro de la baraja de "cartas"
                //El metodo contain regresara un true o false dependiendo si lo encuentra en la baraja
                if (!cartas.Contains(num)){
                    //Ahora cargaremos la imagen en el picturebox
                    //nuestra variable num nos ayudara a encontrar la carta en una ruta de la carpeta
                    //porque cada imagen tiene nombre el numero que le corresponde a la loteria
                    //vamos a sacar la ruta de nuestra carpeta con las imagenes
                    pbcartas.Image = Image.FromFile(@"C:\Users\derek\source\repos\appLoteria\appLoteria\bin\Debug\cartas" + num + ".jpg"); //ruta
                    //Ahora ajustare la imagen en el picturebox
                    pbcartas.SizeMode = PictureBoxSizeMode.StretchImage;
                    //agregaremos un numero de carta en la baraja para saber que no esta disponible en la baraja
                    cartas.Push(num);
                    //vamos añadir cada carta que va saliendo en la imagenlist (para mostrarle el historial)
                    //utlilizare la misma ruta para añardir la carta que salga
                    this.imageList1.Images.Add(Image.FromFile(@"C:\Users\derek\source\repos\appLoteria\appLoteria\bin\Debug\cartas" + num + ".jpg"));
                    //creare el objeto de listviewitem
                    ListViewItem item = new ListViewItem();
                    //le voy a dar una posicion del objeto con el contador
                    item.ImageIndex = i;
                    //agregare el elemento al listview
                    this.listView1.Items.Add(item);
                    //ya agregada nuestra carta, cambiemos nuestra variable auxiliar para no permitir sacar otra carta
                    bandera = true;
                    //iremos aumentando nuestro contador (posicion listview)
                    i++;                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ahora veremos el segundo boton para reiniciar todo el juego
            //para eso limpiaremos la baraja, el imagenlist, listview picturebox, reiniciaremos el contador y limpiare el label
            cartas.Clear();
            imageList1.Images.Clear();
            listView1.Items.Clear();
            pbcartas.Image = null;
            i = 0;
            label1.Text = "";
            //Ahora a probarlo
        }
    }
}
//Profe hice todo lo que pude esto es el resultado lo que esta fallando es la linea 111 y inicia bien y todo pero cuando le doy a siguiente carta se corrompe y nose como solucionarlo 