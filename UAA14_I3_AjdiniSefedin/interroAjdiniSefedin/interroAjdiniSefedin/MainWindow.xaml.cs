using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace interroAjdiniSefedin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txt1.PreviewTextInput += new TextCompositionEventHandler(TextBlock_TextInput);
            txt2.PreviewTextInput += new TextCompositionEventHandler(TextBlock_TextInput);
            CheckAdd.Checked += new RoutedEventHandler(CheckAdd_Checked);
            CheckSous.Checked += new RoutedEventHandler(CheckSous_Checked);
            btnCalcul.Click += new RoutedEventHandler(Button_Click);
            btnReset.Click += new RoutedEventHandler(Button_Click);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MethodeDuProjet mesOutils = new MethodeDuProjet();
            SecondePage SecondePageOutil = new SecondePage();
            ushort[] t1 = [];
            ushort[] t2 = [];
            ushort[] tRes;
            bool ok;
            string nombreBinaire = "";

            if (ok = true)
            {
                mesOutils.RemplirTableau(nombreBinaire);
                mesOutils.Additionne(t1, t2, out tRes, out ok);

                SecondePageOutil.LblResultat.Text = tRes.ToString();
                SecondePageOutil.Show();
            }
            
            if (ok = false)
            {
                mesOutils.RemplirTableau(nombreBinaire);
                mesOutils.Soustrait(t1, t2, out tRes);

                SecondePageOutil.LblResultat.Text = tRes.ToString();
                SecondePageOutil.Show();
            }
        }

        private void TextBlock_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void CheckAdd_Checked(object sender, RoutedEventArgs e)
        {

        }
        
        private void CheckSous_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
