using Gerenciador_de_Tarefas.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Tarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.dbName = "bdGerenciadorTarefas";
            db.Server = "localhost";
            db.user = "root";
            db.password = "password";
            db.ConnectionnMake();
            MessageBox.Show(db.connectionRow, "Connection");
        }
    }
}
