using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassinClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Warcraft> warcraft = new List<Warcraft>();
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox.Image = Image.FromFile("warcraft.jpg");
            Warcraft warcraft1 = new Heroes("Antal", "30", "human", "Kamehame");
            Warcraft warcraft2 = new Heroes("John", "38", "elf", "Fire Ball");
            Warcraft warcraft3 = new Archer("Kriszti", "24", "elf", "ice crossbow");
            Warcraft warcraft4 = new Archer("Mariaa", "21", "orcs", "fire longbow");
            Warcraft warcraft5 = new Horseman("Jozsika", "50", "orcs", "Abtenauer");
            Warcraft warcraft6 = new Horseman("Adam", "90", "elf", "Altai horse");
            Warcraft warcraft7 = new Horseman("Tomi", "31", "Human", "Auxois");
            Warcraft warcraft8 = new Heroes("Piroska", "28", "Human", "Galick gun");
            Warcraft warcraft9 = new Heroes("Andrea", "120", "elf", "healing");

            warcraft.Add(warcraft1);
            warcraft.Add(warcraft2);
            warcraft.Add(warcraft3);
            warcraft.Add(warcraft4);
            warcraft.Add(warcraft5);
            warcraft.Add(warcraft6);
            warcraft.Add(warcraft7);
            warcraft.Add(warcraft8);
            warcraft.Add(warcraft9);

            cmbBox.Items.Add("Heroes");
            cmbBox.Items.Add("Archers");
            cmbBox.Items.Add("Horsemen");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBox.SelectedItem.ToString())
            {
                case "Heroes":
                    List<Heroes> heroes = new List<Heroes>();

                    foreach (var item in warcraft.OfType<Heroes>())
                    {
                        heroes.Add(item);
                    }

                    listBoxNaam.DataSource = null;
                    listBoxNaam.DataSource = heroes;
                    break;

                case "Archers":
                    List<Archer> archers = new List<Archer>();

                    foreach (var item in warcraft.OfType<Archer>())
                    {
                        archers.Add(item);
                    }

                    listBoxNaam.DataSource = null;
                    listBoxNaam.DataSource = archers;
                    break;

                default:
                case "Horsemen":
                    List<Horseman> horsemen = new List<Horseman>();

                    foreach (var item in warcraft.OfType<Horseman>())
                    {
                        horsemen.Add(item);
                    }

                    listBoxNaam.DataSource = null;
                    listBoxNaam.DataSource = horsemen;
                    break;
            }
        }

        private void listBoxNaam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Warcraft selected = (Warcraft)listBoxNaam.SelectedItem;

            if (listBoxNaam.DataSource != null)
            {
                labelInfo.Text = selected.Beschrijft();
            }
            else
            {
                labelInfo.Text = "";
            }
        }

        private void cmboxLifeStyle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtNaam.Text != " " && numericUpDown1.Value != 0 && rdbElf.Checked && rdbHero.Checked)
            {
                Warcraft hero = new Heroes(txtNaam.Text, numericUpDown1.Value.ToString(), rdbElf.Text.ToString(), txtSpec.Text);
                warcraft.Add(hero);
                List<Heroes> heroes = new List<Heroes>();

                foreach (var item in warcraft.OfType<Heroes>())
                {
                    heroes.Add(item);
                }
                listBoxNaam.DataSource = null;
                listBoxNaam.DataSource = heroes;
                MessageBox.Show($"New hero\n" +
               $"Naam: {txtNaam.Text}\n" +
               $"Level: {numericUpDown1.Value}\n" +
               $"Type: {rdbElf.Text}\n" +
               $"Specifiek: {txtSpec.Text}");
                txtNaam.Clear();
                txtSpec.Clear();
                numericUpDown1.Value = 0;
                rdbElf.Checked = false;
                rdbHero.Checked = false;
            }
            else if (txtNaam.Text != " " && numericUpDown1.Value != 0 && rdbHuman.Checked && rdbHero.Checked)
            {
                Warcraft hero = new Heroes(txtNaam.Text, numericUpDown1.Value.ToString(), rdbHuman.Text.ToString(), txtSpec.Text);
                warcraft.Add(hero);
                List<Heroes> heroes = new List<Heroes>();

                foreach (var item in warcraft.OfType<Heroes>())
                {
                    heroes.Add(item);
                }
                listBoxNaam.DataSource = null;
                listBoxNaam.DataSource = heroes;
                MessageBox.Show($"New hero\n" +
                $"Naam: {txtNaam.Text}\n" +
                $"Level: {numericUpDown1.Value}\n" +
                $"Type: {rdbHuman.Text}\n" +
                $"Specifiek: {txtSpec.Text}");
                txtNaam.Clear();
                txtSpec.Clear();
                numericUpDown1.Value = 0;
                rdbHuman.Checked = false;
                rdbHero.Checked = false;
            }
            else if (txtNaam.Text != " " && numericUpDown1.Value != 0 && rdbOrcs.Checked && rdbHero.Checked)
            {
                Warcraft hero = new Heroes(txtNaam.Text, numericUpDown1.Value.ToString(), rdbOrcs.Text.ToString(), txtSpec.Text);
                warcraft.Add(hero);
                List<Heroes> heroes = new List<Heroes>();

                foreach (var item in warcraft.OfType<Heroes>())
                {
                    heroes.Add(item);
                }
                listBoxNaam.DataSource = null;
                listBoxNaam.DataSource = heroes;
                MessageBox.Show($"New hero\n" +
                $"Naam: {txtNaam.Text}\n" +
                $"Level: {numericUpDown1.Value}\n" +
                $"Type: {rdbOrcs.Text}\n" +
                $"Specifiek: {txtSpec.Text}");
                txtNaam.Clear();
                txtSpec.Clear();
                numericUpDown1.Value = 0;
                rdbOrcs.Checked = false;
                rdbHero.Checked = false;
            }
            else if (txtNaam.Text != " " && numericUpDown1.Value != 0 && rdbUndead.Checked && rdbHero.Checked)
            {
                Warcraft hero = new Heroes(txtNaam.Text, numericUpDown1.Value.ToString(), rdbUndead.Text.ToString(), txtSpec.Text);
                warcraft.Add(hero);
                List<Heroes> heroes = new List<Heroes>();

                foreach (var item in warcraft.OfType<Heroes>())
                {
                    heroes.Add(item);
                }

                MessageBox.Show($"New hero\n" +
                    $"Naam: {txtNaam.Text}\n" +
                    $"Level: {numericUpDown1.Value}\n" +
                    $"Type: {rdbUndead.Text}\n" +
                    $"Specifiek: {txtSpec.Text}");
                txtNaam.Clear();
                txtSpec.Clear();
                numericUpDown1.Value = 0;
                rdbUndead.Checked = false;
                rdbHero.Checked = false;
            }
            else if (txtNaam.Text != " " && numericUpDown1.Value != 0 && rdbElf.Checked && rdbArcher.Checked)
            {
                Warcraft archer = new Archer(txtNaam.Text, numericUpDown1.Value.ToString(), rdbElf.Text.ToString(), txtSpec.Text);
                warcraft.Add(archer);
                List<Archer> archers = new List<Archer>();

                foreach (var item in warcraft.OfType<Archer>())
                {
                    archers.Add(item);
                }
                listBoxNaam.DataSource = null;
                listBoxNaam.DataSource = archers;
                MessageBox.Show($"New archer\n" +
                   $"Naam: {txtNaam.Text}\n" +
                   $"Level: {numericUpDown1.Value}\n" +
                   $"Type: {rdbElf.Text}\n" +
                   $"Specifiek: {txtSpec.Text}");
                txtNaam.Clear();
                txtSpec.Clear();
                numericUpDown1.Value = 0;
                rdbElf.Checked = false;
                rdbArcher.Checked = false;
            }
            else if (txtNaam.Text != " " && numericUpDown1.Value != 0 && rdbHuman.Checked && rdbArcher.Checked)
            {
                Warcraft archer = new Archer(txtNaam.Text, numericUpDown1.Value.ToString(), rdbHuman.Text.ToString(), txtSpec.Text);
                warcraft.Add(archer);
                List<Archer> archers = new List<Archer>();

                foreach (var item in warcraft.OfType<Archer>())
                {
                    archers.Add(item);
                }
                listBoxNaam.DataSource = null;
                listBoxNaam.DataSource = archers;
                MessageBox.Show($"New archer\n" +
                   $"Naam: {txtNaam.Text}\n" +
                   $"Level: {numericUpDown1.Value}\n" +
                   $"Type: {rdbHuman.Text}\n" +
                   $"Specifiek: {txtSpec.Text}");
                txtNaam.Clear();
                txtSpec.Clear();
                numericUpDown1.Value = 0;
                rdbHuman.Checked = false;
                rdbArcher.Checked = false;
            }
            else if (txtNaam.Text != " " && numericUpDown1.Value != 0 && rdbOrcs.Checked && rdbArcher.Checked)
            {
                Warcraft archer = new Archer(txtNaam.Text, numericUpDown1.Value.ToString(), rdbOrcs.Text.ToString(), txtSpec.Text);
                warcraft.Add(archer);
                List<Archer> archers = new List<Archer>();

                foreach (var item in warcraft.OfType<Archer>())
                {
                    archers.Add(item);
                }
                listBoxNaam.DataSource = null;
                listBoxNaam.DataSource = archers;
                MessageBox.Show($"New archer\n" +
                   $"Naam: {txtNaam.Text}\n" +
                   $"Level: {numericUpDown1.Value}\n" +
                   $"Type: {rdbOrcs.Text}\n" +
                   $"Specifiek: {txtSpec.Text}");
                txtNaam.Clear();
                txtSpec.Clear();
                numericUpDown1.Value = 0;
                rdbOrcs.Checked = false;
                rdbArcher.Checked = false;
            }
            else if (txtNaam.Text != " " && numericUpDown1.Value != 0 && rdbUndead.Checked && rdbArcher.Checked)
            {
                Warcraft archer = new Archer(txtNaam.Text, numericUpDown1.Value.ToString(), rdbUndead.Text.ToString(), txtSpec.Text);
                warcraft.Add(archer);
                List<Archer> archers = new List<Archer>();

                foreach (var item in warcraft.OfType<Archer>())
                {
                    archers.Add(item);
                }
                listBoxNaam.DataSource = null;
                listBoxNaam.DataSource = archers;
                MessageBox.Show($"New archer\n" +
                   $"Naam: {txtNaam.Text}\n" +
                   $"Level: {numericUpDown1.Value}\n" +
                   $"Type: {rdbUndead.Text}\n" +
                   $"Specifiek: {txtSpec.Text}");
                txtNaam.Clear();
                txtSpec.Clear();
                numericUpDown1.Value = 0;
                rdbUndead.Checked = false;
                rdbArcher.Checked = false;
            }
            else if (txtNaam.Text != " " && numericUpDown1.Value != 0 && rdbUndead.Checked && rdbHorseman.Checked)
            {
                Warcraft horseman = new Archer(txtNaam.Text, numericUpDown1.Value.ToString(), rdbUndead.Text.ToString(), txtSpec.Text);
                warcraft.Add(horseman);
                List<Archer> horsemen = new List<Archer>();

                foreach (var item in warcraft.OfType<Archer>())
                {
                    horsemen.Add(item);
                }
                listBoxNaam.DataSource = null;
                listBoxNaam.DataSource = horsemen;
                MessageBox.Show($"New horseman\n" +
                   $"Naam: {txtNaam.Text}\n" +
                   $"Level: {numericUpDown1.Value}\n" +
                   $"Type: {rdbUndead.Text}\n" +
                   $"Specifiek: {txtSpec.Text}");
                txtNaam.Clear();
                txtSpec.Clear();
                numericUpDown1.Value = 0;
                rdbUndead.Checked = false;
                rdbHorseman.Checked = false;
            }
            else if (txtNaam.Text != " " && numericUpDown1.Value != 0 && rdbOrcs.Checked && rdbHorseman.Checked)
            {
                Warcraft horseman = new Archer(txtNaam.Text, numericUpDown1.Value.ToString(), rdbOrcs.Text.ToString(), txtSpec.Text);
                warcraft.Add(horseman);
                List<Archer> horsemen = new List<Archer>();

                foreach (var item in warcraft.OfType<Archer>())
                {
                    horsemen.Add(item);
                }
                listBoxNaam.DataSource = null;
                listBoxNaam.DataSource = horsemen;
                MessageBox.Show($"New horseman\n" +
                   $"Naam: {txtNaam.Text}\n" +
                   $"Level: {numericUpDown1.Value}\n" +
                   $"Type: {rdbOrcs.Text}\n" +
                   $"Specifiek: {txtSpec.Text}");
                txtNaam.Clear();
                txtSpec.Clear();
                numericUpDown1.Value = 0;
                rdbOrcs.Checked = false;
                rdbHorseman.Checked = false;
            }
            else if (txtNaam.Text != " " && numericUpDown1.Value != 0 && rdbElf.Checked && rdbHorseman.Checked)
            {
                Warcraft horseman = new Archer(txtNaam.Text, numericUpDown1.Value.ToString(), rdbElf.Text.ToString(), txtSpec.Text);
                warcraft.Add(horseman);
                List<Archer> horsemen = new List<Archer>();

                foreach (var item in warcraft.OfType<Archer>())
                {
                    horsemen.Add(item);
                }
                listBoxNaam.DataSource = null;
                listBoxNaam.DataSource = horsemen;
                MessageBox.Show($"New horseman\n" +
                   $"Naam: {txtNaam.Text}\n" +
                   $"Level: {numericUpDown1.Value}\n" +
                   $"Type: {rdbElf.Text}\n" +
                   $"Specifiek: {txtSpec.Text}");
                txtNaam.Clear();
                txtSpec.Clear();
                numericUpDown1.Value = 0;
                rdbElf.Checked = false;
                rdbHorseman.Checked = false;
            }
            else if (txtNaam.Text != " " && numericUpDown1.Value != 0 && rdbHuman.Checked && rdbHorseman.Checked)
            {
                Warcraft horseman = new Archer(txtNaam.Text, numericUpDown1.Value.ToString(), rdbHuman.Text.ToString(), txtSpec.Text);
                warcraft.Add(horseman);
                List<Archer> horsemen = new List<Archer>();

                foreach (var item in warcraft.OfType<Archer>())
                {
                    horsemen.Add(item);
                }
                listBoxNaam.DataSource = null;
                listBoxNaam.DataSource = horsemen;
                MessageBox.Show($"New horseman\n" +
                   $"Naam: {txtNaam.Text}\n" +
                   $"Level: {numericUpDown1.Value}\n" +
                   $"Type: {rdbHuman.Text}\n" +
                   $"Specifiek: {txtSpec.Text}");
                txtNaam.Clear();
                txtSpec.Clear();
                numericUpDown1.Value = 0;
                rdbHuman.Checked = false;
                rdbHorseman.Checked = false;
            }
            else
            {
                MessageBox.Show("Vuil alles in aub.");
            }
        }
        
    }
}
