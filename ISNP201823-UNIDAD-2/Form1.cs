using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ISNP201823_UNIDAD_2
{
    public partial class PELICULAS : Form
    {
        private List<Pelicula> peliculasList;
        private int currentIndex = 0;
        private bool isAddingNew = false;

        public PELICULAS()
        {
            InitializeComponent();
            LoadPeliculas();
            txtPelicula.Enabled = false;
            txtGenero.Enabled = false;
            textBox3.Enabled = false;
        }

        private void LoadPeliculas()
        {
            peliculasList = ObtenerPeliculas();
            ShowPelicula(currentIndex);
        }

        private void ShowPelicula(int index)
        {
            if (peliculasList.Count > 0 && index >= 0 && index < peliculasList.Count)
            {
                Pelicula pelicula = peliculasList[index];
                txtPelicula.Text = pelicula.Titulo;
                txtGenero.Text = pelicula.Genero;
                textBox3.Text = pelicula.Sinopsis;
                lblReguistro.Text = $"{index + 1} de {peliculasList.Count}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentIndex < peliculasList.Count - 1)
            {
                currentIndex++;
                ShowPelicula(currentIndex);
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            ShowPelicula(currentIndex);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (currentIndex < peliculasList.Count - 1)
            {
                currentIndex++;
                ShowPelicula(currentIndex);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                ShowPelicula(currentIndex);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            currentIndex = peliculasList.Count - 1;
            ShowPelicula(currentIndex);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPelicula.Text = string.Empty;
            txtGenero.Text = string.Empty;
            textBox3.Text = string.Empty;
            txtPelicula.Enabled = true;
            txtGenero.Enabled = true;
            textBox3.Enabled = true;
            btnEliminar.Text = "Agregar";
            isAddingNew = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < peliculasList.Count)
            {
                txtPelicula.Enabled = true;
                txtGenero.Enabled = true;
                textBox3.Enabled = true;
                btnEliminar.Text = "Agregar";
                isAddingNew = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (isAddingNew)
            {
                Pelicula nuevaPelicula = new Pelicula
                {
                    Titulo = txtPelicula.Text,
                    Genero = txtGenero.Text,
                    Sinopsis = textBox3.Text
                };
                peliculasList.Add(nuevaPelicula);
                currentIndex = peliculasList.Count - 1;
                ShowPelicula(currentIndex);
                btnEliminar.Text = "Eliminar";
                isAddingNew = false;
                txtPelicula.Enabled = false;
                txtGenero.Enabled = false;
                textBox3.Enabled = false;
            }
            else
            {
                if (currentIndex >= 0 && currentIndex < peliculasList.Count)
                {
                    var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta película?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        peliculasList.RemoveAt(currentIndex);
                        if (currentIndex >= peliculasList.Count)
                        {
                            currentIndex = peliculasList.Count - 1;
                        }
                        ShowPelicula(currentIndex);
                    }
                }
            }
        }

        private void txtPelicula_TextChanged(object sender, EventArgs e) { }

        private void txtGenero_TextChanged(object sender, EventArgs e) { }

        private void textBox3_TextChanged_1(object sender, EventArgs e) { }

        private List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>
            {
              new Pelicula { Titulo = "El Padrino", Genero = "Crimen, Drama", Sinopsis = "La historia de la familia Corleone, una de las más poderosas del mundo de la mafia." },
              new Pelicula { Titulo = "Pulp Fiction", Genero = "Crimen, Drama", Sinopsis = "Las vidas de dos asesinos, un boxeador, una pareja de criminales y otros se entrelazan en Los Ángeles." },
              new Pelicula { Titulo = "Forrest Gump", Genero = "Drama, Romance", Sinopsis = "La vida de un hombre con una baja inteligencia que, sin embargo, logra vivir una vida llena de logros." },
              new Pelicula { Titulo = "Matrix", Genero = "Acción, Ciencia Ficción", Sinopsis = "Un hacker descubre que la realidad es una simulación y lucha para liberarse junto a un grupo rebelde." },
              new Pelicula { Titulo = "Inception", Genero = "Acción, Ciencia Ficción, Suspenso", Sinopsis = "Un ladrón experto en infiltrarse en los sueños lucha con una misión en un laberinto mental." },
              new Pelicula { Titulo = "Gladiador", Genero = "Acción, Drama, Épico", Sinopsis = "Un general romano busca venganza tras ser traicionado y vendido como esclavo." },
              new Pelicula { Titulo = "El Señor de los Anillos: La Comunidad del Anillo", Genero = "Aventura, Fantasía", Sinopsis = "Un hobbit recibe el encargo de destruir un anillo poderoso para salvar la Tierra Media." },
              new Pelicula { Titulo = "La Lista de Schindler", Genero = "Biografía, Drama, Historia", Sinopsis = "Un empresario alemán salva a cientos de judíos durante el Holocausto." },
              new Pelicula { Titulo = "Star Wars: Episodio IV - Una Nueva Esperanza", Genero = "Aventura, Fantasía, Ciencia Ficción", Sinopsis = "Un joven se une a una alianza rebelde para luchar contra el malvado Imperio." }

            };
        }

        private void lblReguistro_Click(object sender, EventArgs e) { }
    }

    public class Pelicula
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Sinopsis { get; set; }
    }
}
