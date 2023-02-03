using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //txtnumfinal.Text = "1,2,3,4,5";
            //txtestrelafinal.Text = "1,2";
        }

        //random dos numeros e estrelas
        private void buttongenerate_Click(object sender, EventArgs e)
        {
            //random dos numeros
            txtnumfinal.Clear();
            List<int> numbers = new List<int>();
            Random rand = new Random();
            while (numbers.Count < 5)
            {
                int randomnumber = rand.Next(1, 24);
                if (!numbers.Contains(randomnumber))
                {
                    numbers.Add(randomnumber);
                    txtnumfinal.AppendText(randomnumber + " ");
                }
            }

            //random das estrelas
            txtestrelafinal.Clear();
            List<int> numbers2 = new List<int>();
            Random rand2 = new Random();
            while (numbers2.Count < 2)
            {
                int randomnumbers2 = rand2.Next(1, 9);
                if (!numbers2.Contains(randomnumbers2))
                {
                    numbers2.Add(randomnumbers2);
                    txtestrelafinal.AppendText(randomnumbers2+ " ");    
                }
            }
                
            //Verificação das lista1
            ListViewItem item = listView1.FindItemWithText(txtnumfinal.Text);

            if (listView1.Items.Count == 0) 
            {

            }else if (item != null)
            {
                MessageBox.Show("Acertou os Numeros", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Errou os Numeros", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ListViewItem item2 = listView1.FindItemWithText(txtestrelafinal.Text);

            if (listView1.Items.Count == 0)
            {

            }
            else if (item2 != null)
            {
                MessageBox.Show("Acertou as Estrelas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Errou as Estrelas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Verificação das lista2
            ListViewItem item3 = listView2.FindItemWithText(txtnumfinal.Text);

            if (listView2.Items.Count == 0)
            {

            }
            else if (item3 != null)
            {
                MessageBox.Show("Acertou os Numeros", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Errou os Numeros", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ListViewItem item4 = listView2.FindItemWithText(txtestrelafinal.Text);

            if (listView2.Items.Count == 0)
            {

            }
            else if (item4 != null)
            {
                MessageBox.Show("Acertou as Estrelas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Errou as Estrelas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Verificação das lista3
            ListViewItem item5 = listView3.FindItemWithText(txtnumfinal.Text);

            if (listView3.Items.Count == 0)
            {

            }
            else if (item5 != null)
            {
                MessageBox.Show("Acertou os Numeros", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Errou os Numeros", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ListViewItem item6 = listView3.FindItemWithText(txtestrelafinal.Text);

            if (listView3.Items.Count == 0)
            {

            }
            else if (item6 != null)
            {
                MessageBox.Show("Acertou as Estrelas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Errou as Estrelas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Verificação das lista4
            ListViewItem item7 = listView4.FindItemWithText(txtnumfinal.Text);

            if (listView4.Items.Count == 0)
            {

            }
            else if (item7 != null)
            {
                MessageBox.Show("Acertou os Numeros", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Errou os Numeros", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ListViewItem item8 = listView4.FindItemWithText(txtestrelafinal.Text);

            if (listView4.Items.Count == 0)
            {

            }
            else if (item8 != null)
            {
                MessageBox.Show("Acertou as Estrelas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Errou as Estrelas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Verificação das lista5
            ListViewItem item9 = listView5.FindItemWithText(txtnumfinal.Text);

            if (listView5.Items.Count == 0)
            {

            }
            else if (item9 != null)
            {
                MessageBox.Show("Acertou os Numeros", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Errou os Numeros", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ListViewItem item10 = listView5.FindItemWithText(txtestrelafinal.Text);

            if (listView5.Items.Count == 0)
            {

            }
            else if (item10 != null)
            {
                MessageBox.Show("Acertou as Estrelas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Errou as Estrelas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Aposta é enviada para listview e podemos ver a nossa aposta
        int MyCount = 0;
        private void buttonaposta1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtboxn1.Text);
            item.SubItems.Add(txtboxes1.Text);
            listView1.Items.Add(item);
            MyCount += 2;
            counterlabel.Text = MyCount.ToString();
        }

        //Aposta é enviada para listview e podemos ver a nossa aposta
        private void buttonaposta2_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtboxn2.Text);
            item.SubItems.Add(txtboxes2.Text);
            listView2.Items.Add(item);
            MyCount += 2;
            counterlabel.Text = MyCount.ToString();
        }

        //Aposta é enviada para listview e podemos ver a nossa aposta
        private void buttonaposta3_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtboxn3.Text);
            item.SubItems.Add(txtboxes3.Text);
            listView3.Items.Add(item);
            MyCount += 2;
            counterlabel.Text = MyCount.ToString();
        }

        //Aposta é enviada para listview e podemos ver a nossa aposta
        private void buttonaposta4_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtboxn4.Text);
            item.SubItems.Add(txtboxes4.Text);
            listView4.Items.Add(item);
            MyCount += 2;
            counterlabel.Text = MyCount.ToString();
        }

        //Aposta é enviada para listview e podemos ver a nossa aposta
        private void buttonaposta5_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtboxn5.Text);
            item.SubItems.Add(txtboxes5.Text);
            listView5.Items.Add(item);
            MyCount += 2;
            counterlabel.Text = MyCount.ToString();
        }
    }
}