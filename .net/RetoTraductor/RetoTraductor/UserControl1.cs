using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetoTraductor
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> englishToSpanishDictionary = new Dictionary<string, string>
            {
                {"hello", "hola"},
                {"yes", "sí"},
                {"no", "no"},
                {"dog", "perro"},
                {"cat", "gato"},
                {"house", "casa"},
                {"car", "coche"},
                {"book", "libro"},
                {"computer", "computadora"},
                {"glass", "vaso"}
            };

            string englishWord = textBox1.Text;

            if (englishToSpanishDictionary.ContainsKey(englishWord.ToLower()))
            {
                label1.Text = englishToSpanishDictionary[englishWord.ToLower()];
            }
            else
            {
                label1.Text = "The word is not found in the dictionary.";
            }
        }
    }
}
