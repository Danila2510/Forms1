using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        public Book GetNewBook(object textBox3)
        {
            if(!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox3.text))
            {
                return new Book(textBox1.Text, textBox3.Text);
            }
            return null;

        }

        internal Book GetNewBook()
        {
            throw new NotImplementedException();
        }
    }
}
