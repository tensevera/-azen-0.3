using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Řazení
{
    public partial class Řazení : Form
    {
        const int maxCislo = 99;        //generujeme číslo od 0 do maxCislo (včetně)
        int[] Pole;                     //globální pole, které obsahuje vygenerované hodnoty
        const int velikostBunky = 36;   //velikosti buněk gridu
        Random r = new Random();

        public Řazení()
        {
            InitializeComponent();
        }

        private void tlStart_Click(object sender, EventArgs e)
        {
            Pole = new int[Convert.ToInt32(velikostPole.Value)];    //nastavíme poli správnou délku
            //pole narandomujeme
            for (int i = 0; i < Pole.Length; i++)
                Pole[i] = r.Next(maxCislo + 1);

            //nastavíme vstupní grid
            vstupniPole.Left = 15;
            vstupniPole.Visible = true;
            //nastavíme velikost vstupnímu gridu
            //nastavíme sloupce a šířku
            vstupniPole.ColumnCount = Pole.Length;
            for (int i = 0; i < vstupniPole.ColumnCount; i++)
            {
                vstupniPole.Columns[i].Width = velikostBunky;
            }
            vstupniPole.Width = vstupniPole.ColumnCount * velikostBunky + 3;
            //nastavíme řádky a výšku
            vstupniPole.RowCount = 1;
            vstupniPole.Rows[0].Height = velikostBunky;
            vstupniPole.Height = velikostBunky + 3;

            //vypíšeme do vstupního gridu
            for (int i = 0; i < Pole.Length; i++)
                vstupniPole.Rows[0].Cells[i].Value = Pole[i];

            //skryjeme 
            tlStart.Visible = false;
            velikostPole.Visible = false;

            //zobrazíme skrytá tlačítka
            tlNoveHodnoty.Visible = true;
            tlDoleSmaz.Visible = true;
            tlKopirujDolu.Visible = true;
            tlSeradVyberMinima.Visible = true;
            bt_bubblesort.Visible = true;
            bt_Combsort.Visible = true;
            bt_quicksort.Visible = true;
            bt_HeapSort.Visible = true;

            //připravíme vystupni pole
            vystupniPole.Visible = true;
            //nastavíme velikost výstupnímu gridu
            //nastavíme sloupce a šířku
            vystupniPole.ColumnCount = Pole.Length;
            for (int i = 0; i < vystupniPole.ColumnCount; i++)
            {
                vystupniPole.Columns[i].Width = velikostBunky;
            }
            vystupniPole.Width = vystupniPole.ColumnCount * velikostBunky + 3;
            //nastavíme řádky a výšku
            vystupniPole.RowCount = 1;
            vystupniPole.Rows[0].Height = velikostBunky;
            vystupniPole.Height = velikostBunky + 3;
        }

        private void vstupniPole_SelectionChanged(object sender, EventArgs e)   //aby nebylo modré označení
        {
            vstupniPole.ClearSelection();
        }

        private void vystupniPole_SelectionChanged(object sender, EventArgs e)
        {
            vystupniPole.ClearSelection();
        }

        private void tlNoveHodnoty_Click(object sender, EventArgs e)
        {
            //vygenerujeme nové hodnoty
            for (int i = 0; i < Pole.Length; i++)
                Pole[i] = r.Next(maxCislo + 1);
            //vypíšeme do vstupního gridu
            for (int i = 0; i < Pole.Length; i++)
                vstupniPole.Rows[0].Cells[i].Value = Pole[i];
        }


        private void tlDoleSmaz_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Pole.Length; i++)
                vystupniPole.Rows[0].Cells[i].Value = null;
        }

        private void tlKopirujDolu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Pole.Length; i++)
                vystupniPole.Rows[0].Cells[i].Value = vstupniPole.Rows[0].Cells[i].Value;
        }

        private void tlSeradVyberMinima_Click(object sender, EventArgs e)
        {
            int[] Kopie = new int[Pole.Length];     //vytvořím kopii vstupního pole a to seřadím
            for (int i = 0; i < Pole.Length; i++)   //nemohu Kopie=Pole - byl by to jen ukazatel; šlo by CopyTo
                Kopie[i] = Pole[i];
            //zavolám řazení na Kopii
            seradVyberMinima(Kopie);            //předávám hodnotou – referenční typ
            //Kopii vypíši do dolního gridu
            for (int i = 0; i < Kopie.Length; i++)
                vystupniPole.Rows[0].Cells[i].Value = Kopie[i];
        }

        private void seradVyberMinima(int[] P)   //řazením výběrem minima
        {
            int posun = 0; //hranice posunu
            do {
                int nejmensi = posun;
                for (int x = posun+1; x < P.Length; x++)
                {
                    if (P[x] < P[nejmensi])
                    {
                        nejmensi = x;
                    }
                }
                int docas = P[nejmensi];
                P[nejmensi] = P[posun];
                P[posun] = docas;
                posun++;
            } while (posun < P.Length - 1);
        }

        private void bt_bubblesort_Click(object sender, EventArgs e) //bubble sort click
        {
            int[] Kopie = new int[Pole.Length];     //vytvořím kopii vstupního pole a to seřadím
            for (int i = 0; i < Pole.Length; i++)   //nemohu Kopie=Pole - byl by to jen ukazatel; šlo by CopyTo
                Kopie[i] = Pole[i];
            //zavolám řazení na Kopii
            seradbubble(Kopie);            //předávám hodnotou – referenční typ
            //Kopii vypíši do dolního gridu
            for (int i = 0; i < Kopie.Length; i++)
                vystupniPole.Rows[0].Cells[i].Value = Kopie[i];
        }
        private void seradbubble(int[] P) //BUBBLE SORT
        {
            bool serazeno;
            int konec = P.Length - 1;
            do
            {
                serazeno = true;
                for (int x = 0; x < konec; x++)
                {
                    if (P[x] > P[x + 1])
                    {
                        int docas = P[x];
                        P[x] = P[x + 1];
                        P[x + 1] = docas;
                        serazeno = false;
                    }
                }
                konec--;
            } while (serazeno == false && konec > 0);
        }

        private void bt_Combsort_Click(object sender, EventArgs e)
        {
            int[] Kopie = new int[Pole.Length];     //vytvořím kopii vstupního pole a to seřadím
            for (int i = 0; i < Pole.Length; i++)   //nemohu Kopie=Pole - byl by to jen ukazatel; šlo by CopyTo
                Kopie[i] = Pole[i];
            //zavolám řazení na Kopii
            seradCombSortem(Kopie);            //předávám hodnotou – referenční typ
            //Kopii vypíši do dolního gridu
            for (int i = 0; i < Kopie.Length; i++)
                vystupniPole.Rows[0].Cells[i].Value = Kopie[i];
        }
        private void seradCombSortem(int[] P) //Comb SORT -- OBČAS NEFUNGUJE (víc hodnot)
        {
            int mezera = Convert.ToInt32(Math.Floor(P.Length/1.3)); //mezera
            do
            {
                for (int i = 0; i < P.Length - mezera; i++) //pokud aktuální pozice je větší než pozice + mezera
                {
                    if (P[i] > P[i+mezera]) //vyměnit
                    {
                        int docas = P[i];
                        P[i] = P[i + mezera];
                        P[i + mezera] = docas;
                    }
                }
                mezera = Convert.ToInt32(Math.Floor(mezera / 1.3)); //mezera se zmenší
            } while (mezera >= 1);
        }

        private void bt_quicksort_Click(object sender, EventArgs e)
        {
            int[] Kopie = new int[Pole.Length];     //vytvořím kopii vstupního pole a to seřadím
            for (int i = 0; i < Pole.Length; i++)   //nemohu Kopie=Pole - byl by to jen ukazatel; šlo by CopyTo
                Kopie[i] = Pole[i];
            //zavolám řazení na Kopii
            seradQuickSortem(Kopie);            //předávám hodnotou – referenční typ
            //Kopii vypíši do dolního gridu
            for (int i = 0; i < Kopie.Length; i++)
                vystupniPole.Rows[0].Cells[i].Value = Kopie[i];
        }
        private void seradQuickSortem(int[] P) //QUICKSORT
        {
            rozdeleni(P, P.Length - 1, -1); //prvotní určení zlomového bodu                              
           for (int i = konec; i >= 0; i--)
           {
                rozdeleni(P, i+1, -1);
           }
           for (int i = konec + 1; i<P.Length-1; i++)
           {
                rozdeleni(P, P.Length - 1, i);
           }
                                            
        }
        int konec;
        private void rozdeleni(int[] P,int vrchol, int zacatek)
        {
            int prostredek = P[vrchol]; //prostřední hodnotu udá jako poslední číslo řady
            int mensich = zacatek; //počet menších čísel
            for (int i = zacatek + 1; i < vrchol; i++) //od zadaného bodu do konce řady seřadí pole 
            {
                if (P[i] < prostredek)
                {
                    mensich++;
                    int docasc = P[i];
                    P[i] = P[mensich];
                    P[mensich] = docasc;
                }
            }  
            int docas = P[vrchol]; //zařazení prostředního bodu
            P[vrchol] = P[mensich+1];
            P[mensich + 1] = docas;
            konec = mensich;
        }

        private void bt_HeapSort_Click(object sender, EventArgs e)
        {
            int[] Kopie = new int[Pole.Length];     //vytvořím kopii vstupního pole a to seřadím
            for (int i = 0; i < Pole.Length; i++)   //nemohu Kopie=Pole - byl by to jen ukazatel; šlo by CopyTo
                Kopie[i] = Pole[i];
            //zavolám řazení na Kopii
            seradHeapSortem(Kopie);            //předávám hodnotou – referenční typ
            //Kopii vypíši do dolního gridu
            for (int i = 0; i < Kopie.Length; i++)
                vystupniPole.Rows[0].Cells[i].Value = Kopie[i];
        }
        private void seradHeapSortem(int[] P)
        {
            int n = Convert.ToInt32(velikostPole.Value); //velikost pole
            for (int i = n / 2 - 1; i >= 0; i--) //vybudujeme strom ( přeházíme pole)
            {
                heap(P, n, i);
            }
            for ( int i = n -1; i > 0; i--) //dostáváme hodnoty zpět
            {
                int mezi = P[0]; //přidáme kořen na konec
                P[0] = P[i];
                P[i] = mezi;
                heap(P, i, 0); //znovu seřadíme
            }
            void heap(int[] pole, int x, int y) //seřazení stromu (y = kořen, x = délka)
            {
                int největší = y; //kořen
                int l = 2 * y + 1; //levá
                int p = 2 * y + 2; //pravá
                if ( l < x &&  pole[l] > pole[největší]) //levý syn je větší jak kořen
                {
                    největší = l;
                }
                if (p < x && pole[p] > pole[největší]) //pravý syn je větší jak kořen
                {
                    největší = p;
                }
                if (největší != y) //kořen není největší
                {
                    int mezi = pole[y];
                    pole[y] = pole[největší];
                    pole[největší] = mezi;
                    heap(pole, x, největší); //seřadíme haldu
                }
            }
        }

        private void velikostPole_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
