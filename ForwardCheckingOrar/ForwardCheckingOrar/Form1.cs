using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForwardCheckingOrar
{
    public partial class Form1 : Form
    {
        private List<Sala> sali = new List<Sala>();
        private List<(string grupa, List<(int Start, int End)> intervale)> grupe = new List<(string, List<(int Start, int End)>)>();
        private List<(string Grupa, string Sala, (int Start, int End) Interval)> orar = new List<(string Grupa, string Sala, (int Start, int End) Interval)>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdaugaSala_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSala.Text))
            {
                sali.Add(new Sala { Nume = txtSala.Text });
                txtSala.Clear();

                // actualizare pentru adaugarea unei noi sali
                RefreshListBox();
            }
            else
            {
                MessageBox.Show("Nume invalid pentru sala",
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdaugaGrupa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtGrupa.Text) && !string.IsNullOrWhiteSpace(txtIntervale.Text))
            {
                var intervale = new List<(int Start, int End)>();
                var intervalStrings = txtIntervale.Text.Split(',');

                foreach (var intervalString in intervalStrings)
                {
                    var bounds = intervalString.Trim().Split('-');
                    if (bounds.Length == 2 && int.TryParse(bounds[0], out int start) && int.TryParse(bounds[1], out int end))
                    {
                        intervale.Add((start, end));
                    }
                    else
                    {
                        MessageBox.Show($"Intervalul \"{intervalString}\" nu este valid. Formatul trebuie sa fie Start-End, ex: 11-12.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                grupe.Add((txtGrupa.Text, intervale));
                listGrupe.Items.Add($"{txtGrupa.Text} (Intervale: {string.Join(", ", intervale.Select(i => $"({i.Start}, {i.End})"))})");

                txtGrupa.Clear();
                txtIntervale.Clear();
            }
            else
            {
                MessageBox.Show("Campuri incomplete!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenereazaOrar_Click(object sender, EventArgs e)
        {
            var rezultat = GenerareOrar(sali, grupe);

            // afisare rezultat
            gridOrar.Rows.Clear();
            foreach (var item in rezultat)
            {
                gridOrar.Rows.Add(item.Grupa, item.Sala, $"{item.Interval.Start}-{item.Interval.End}");
            }
        }

        private List<(string Grupa, string Sala, (int Start, int End) Interval)> GenerareOrar(List<Sala> sali, List<(string grupa, List<(int Start, int End)> intervale)> grupe)
        {
            var orar = new List<(string Grupa, string Sala, (int Start, int End) Interval)>();

            if (RezolvaOrar(orar, grupe, sali))
            {
                return orar;
            }
            else
            {
                MessageBox.Show("Nu s-a gasit nicio solutie valida.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<(string Grupa, string Sala, (int Start, int End) Interval)>();
            }
        }

        private bool RezolvaOrar(List<(string Grupa, string Sala, (int Start, int End) Interval)> orar, List<(string grupa, List<(int Start, int End)> intervale)> grupe, List<Sala> sali)
        {
            if (grupe.Count == 0) return true;

            var grupaCurenta = grupe[0];
            var grupeRamase = grupe.GetRange(1, grupe.Count - 1);

            foreach (var interval in grupaCurenta.intervale)
            {
                foreach (var sala in sali)
                {
                    if (EsteValid(orar, grupaCurenta.grupa, sala, interval.Start, interval.End))
                    {
                        // se adauga alocarea curenta in orar
                        orar.Add((grupaCurenta.grupa, sala.Nume, interval));

                        // se rezerva salile din orar
                        RezervaSala(sala, interval.Start, interval.End);

                        // recursiv pentru restul grupelor
                        if (RezolvaOrar(orar, grupeRamase, sali))
                            return true;

                        // backtracking pentru inlaturarea alocarii curente
                        orar.RemoveAll(o => o.Grupa == grupaCurenta.grupa && o.Sala == sala.Nume && o.Interval == interval);
                        sala.IntervaleRezervate.RemoveAll(i => i.Start == interval.Start && i.End == interval.End);
                    }
                }
            }

            return false;
        }

        private bool EsteValid(List<(string Grupa, string Sala, (int Start, int End) Interval)> orar, string grupa, Sala sala, int intervalStart, int intervalEnd)
        {
            // verificare interval
            foreach (var rezervare in sala.IntervaleRezervate)
            {
                if (rezervare.Start < intervalEnd && intervalStart < rezervare.End)
                    return false;
            }

            // verificare grupa la un alt interval
            foreach (var o in orar)
            {
                if (o.Grupa == grupa && o.Interval.Start < intervalEnd && intervalStart < o.Interval.End)
                    return false;
            }

            return true;
        }

        private void RezervaSala(Sala sala, int intervalStart, int intervalEnd)
        {
            sala.IntervaleRezervate.Add((intervalStart, intervalEnd));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sali.Clear();
            grupe.Clear();
            listSali.Items.Clear();
            listGrupe.Items.Clear();

            sali.Add(new Sala { Nume = "C0-1" });
            foreach (var sala in sali)
            {
                listSali.Items.Add(sala);
            }

            grupe.Add(("1408A", new List<(int Start, int End)> { (11, 13), (13, 15) }));
            grupe.Add(("1409A", new List<(int Start, int End)> { (13, 15), (15, 17) }));
            grupe.Add(("1410A", new List<(int Start, int End)> { (15, 17), (17, 19) }));

            foreach (var grupa in grupe)
            {
                listGrupe.Items.Add($"{grupa.Item1} (Intervale: {string.Join(", ", grupa.Item2)})");
            }
        }

        private void exemplu2_Click(object sender, EventArgs e)
        {
            sali.Clear();
            grupe.Clear();
            listSali.Items.Clear();
            listGrupe.Items.Clear();

            sali.Add(new Sala { Nume = "C0-1" });
            sali.Add(new Sala { Nume = "C0-2" });
            foreach (var sala in sali)
            {
                listSali.Items.Add(sala);
            }

            grupe.Add(("1408A", new List<(int Start, int End)> { (11, 13), (13, 15) }));
            grupe.Add(("1409A", new List<(int Start, int End)> { (13, 15) }));
            grupe.Add(("1410A", new List<(int Start, int End)> { (11, 13), (13, 15) }));

            foreach (var grupa in grupe)
            {
                listGrupe.Items.Add($"{grupa.Item1} (Intervale: {string.Join(", ", grupa.Item2)})");
            }
        }

        private void exemplu3_Click(object sender, EventArgs e)
        {
            sali.Clear();
            grupe.Clear();
            listSali.Items.Clear();
            listGrupe.Items.Clear();

            sali.Add(new Sala { Nume = "C0-1" });
            sali.Add(new Sala { Nume = "C0-2" });
            sali.Add(new Sala { Nume = "C0-3" });
            sali.Add(new Sala { Nume = "C0-4" });
            foreach (var sala in sali)
            {
                listSali.Items.Add(sala);
            }

            grupe.Add(("1408A", new List<(int Start, int End)> { (11, 13), (13, 15) }));
            grupe.Add(("1408B", new List<(int Start, int End)> { (11, 13), (13, 15) }));
            grupe.Add(("1409A", new List<(int Start, int End)> { (13, 15) }));
            grupe.Add(("1409B", new List<(int Start, int End)> { (13, 15) }));
            grupe.Add(("1410A", new List<(int Start, int End)> { (11, 13), (13, 15) }));

            foreach (var grupa in grupe)
            {
                listGrupe.Items.Add($"{grupa.Item1} (Intervale: {string.Join(", ", grupa.Item2)})");
            }
        }

        private void sterge1_Click(object sender, EventArgs e)
        {
            grupe.Clear();
            listGrupe.Items.Clear();
        }

        private void sterge2_Click(object sender, EventArgs e)
        {
            sali.Clear();
            listSali.Items.Clear();
        }

        private void btnRezervaSala_Click(object sender, EventArgs e)
        {
            if (listSali.SelectedItem is Sala salaSelectata &&
                int.TryParse(txtIntervalStart.Text, out int start) &&
                int.TryParse(txtIntervalEnd.Text, out int end))
            {
                if (salaSelectata.IntervaleRezervate.Any(i => i.Start < end && start < i.End))
                {
                    MessageBox.Show($"Sala {salaSelectata.Nume} este deja rezervata in acest interval",
                        "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                salaSelectata.IntervaleRezervate.Add((start, end));
                RefreshListBox();
            }
            else
            {
                MessageBox.Show("Selectati o sala si introduceti un interval valid",
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshListBox()
        {
            listSali.Items.Clear();

            foreach (var sala in sali)
            {
                listSali.Items.Add(sala);
            }
        }

        private void btnStergeOrar_Click(object sender, EventArgs e)
        {
            gridOrar.Rows.Clear();
            orar.Clear();
            foreach (var sala in sali)
            {
                sala.IntervaleRezervate.Clear();
            }
        }
    }
}
