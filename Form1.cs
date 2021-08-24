using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_2_grupo3_parejas
{
    public partial class Form1 : Form
    {
        // Use this Random object to choose random icons for the squares
        Random random = new Random();

        // Each of these letters is an interesting icon
        // in the Webdings font,
        // and each icon appears twice in this list
        List<string> icons = new List<string>()
    {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
    };
        /// <summary>
        /// Asignar cada icono de la lista de iconos a un cuadrado aleatorio  
        /// </summary>
        private void AssignIconsToSquares()
        {
            // El TableLayoutPanel tiene 16 etiquetas,
            // y la lista de iconos tiene 16 iconos,
            // por lo que un icono se extrae al azar de la lista
            // y agregado a cada etiqueta
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <resumen>
        /// El evento Click de cada etiqueta es manejado por este controlador de eventos
        /// </summary>
        /// <param name = "sender"> La etiqueta en la que se hizo clic </param>
        /// <param name = "e"></param>
        private void label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // Si la etiqueta en la que se hizo clic es negra, el jugador hizo clic
                // un icono que ya ha sido revelado --
                // ignora el clic
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                clickedLabel.ForeColor = Color.Black;
            }
        }
    }
}
/// <summary>
/// Every label's Click event is handled by this event handler
/// </summary>
/// <param name="sender">The label that was clicked</param>
/// <param name="e"></param>
private void label_Click(object sender, EventArgs e)
{
    Label clickedLabel = sender as Label;

    if (clickedLabel != null)
    {
        // If the clicked label is black, the player clicked
        // an icon that's already been revealed --
        // ignore the click
        if (clickedLabel.ForeColor == Color.Black)
            return;

        // If firstClicked is null, this is the first icon 
        // in the pair that the player clicked,
        // so set firstClicked to the label that the player 
        // clicked, change its color to black, and return
        if (firstClicked == null)
        {
            firstClicked = clickedLabel;
            firstClicked.ForeColor = Color.Black;

            return;
        }
    }
}
paso 5
    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_2_grupo3_parejas
{
    public partial class Form1 : Form
    {
        // firstClicked apunta al primer control Label
        // que el jugador hace clic, pero será nulo
        // si el jugador aún no ha hecho clic en una etiqueta
        Label firstClicked = null;

        // secondClicked apunta al segundo control Label
        // que el jugador hace clic
        Label secondClicked = null;



        // Utilice este objeto aleatorio para elegir iconos aleatorios para los cuadrados
        Random random = new Random();

        // Cada una de estas letras es un icono interesante
        // en la fuente Webdings,
        // y cada icono aparece dos veces en esta lista
        List<string> icons = new List<string>()
    {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
    };
        /// <summary>
        /// Asignar cada icono de la lista de iconos a un cuadrado aleatorio  
        /// </summary>
        private void AssignIconsToSquares()
        {
            // El TableLayoutPanel tiene 16 etiquetas,
            // y la lista de iconos tiene 16 iconos,
            // por lo que un icono se extrae al azar de la lista
            // y agregado a cada etiqueta
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <resumen>
        /// El evento Click de cada etiqueta es manejado por este controlador de eventos
        /// </summary>
        /// <param name = "sender"> La etiqueta en la que se hizo clic </param>
        /// <param name = "e"></param>
        private void label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // Si la etiqueta en la que se hizo clic es negra, el jugador hizo clic
                // un icono que ya ha sido revelado --
                // ignora el clic
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                // Si firstClicked es nulo, este es el primer icono
                // en el par en el que el jugador hizo clic,
                // así que establezca firstClicked en la etiqueta que el jugador
                // hace clic, cambia su color a negro y regresa
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
            }
        }
    }
}
