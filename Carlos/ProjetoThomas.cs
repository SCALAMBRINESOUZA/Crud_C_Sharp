using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Carlos
{

    
    public partial class ProjetoThomas : Form
    {

        private static SQLiteConnection SQLiteConnection;
        public ProjetoThomas()
        {
            InitializeComponent();
            try
            {
                
                if (File.Exists("acme.sqlite"))
                {
                    ProjetoThomas.DbAcme();
                    MessageBox.Show("Conexão estabelecida");
                }
                else
                {
                 
                    using (var cmd = DbAcme().CreateCommand())
                    {
                        cmd.CommandText = "CREATE TABLE IF NOT EXISTS TB_VOO(Id_Voo INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, Data_Voo Varchar , Custo Numeric(10,2), Distancia int, Captura Char(1), Nivel_Dor )";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Tabela criada com sucesso");

                    }


                }
            }
            catch
            {
                throw;
            }
        }

        private static SQLiteConnection DbAcme()
        {
            SQLiteConnection = new SQLiteConnection("Data Source = acme.sqlite");
            SQLiteConnection.Open();
            return SQLiteConnection;
        }


        private void BtnSal_Click(object sender, EventArgs e)
        {
            int ids = Convert.ToInt32(lstInf.SelectedItems[0].SubItems[0].Text);

                using (var cmd = DbAcme().CreateCommand())
                {

                    cmd.CommandText = "update TB_VOO set Data_Voo = ? , Captura = ?, Nivel_Dor = ? WHERE Id_Voo = '" + ids + "' ";

                    cmd.Parameters.AddWithValue("@Data_Voo", txtData.Text);

                    if (rbtNao.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Captura", "N");

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Captura", "S");
                    }



                    cmd.Parameters.AddWithValue("@Nivel_Dor", txtNivDor.Text);

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    lstInf.Items.Clear();
                    AtualizarLista();
                }
            
        }
        private void Form1_Load(object sender, EventArgs e)
            {
            
            try
            {
                using (var cmd = DbAcme().CreateCommand())
                {
                      cmd.CommandText = "SELECT Id_Voo, Data_Voo, Captura, Nivel_Dor FROM TB_VOO";
                      SQLiteDataReader dr = cmd.ExecuteReader();

                for (int i = 0; i < dr.FieldCount; i++)
                {
                    ColumnHeader ch = new ColumnHeader();
                    ch.TextAlign = HorizontalAlignment.Center;
                    ch.Width = 87;
                    ch.Text = dr.GetName(i);
                    lstInf.Columns.Add(ch);
                }

                    ListViewItem item;

                    while (dr.Read())
                    {
                        item = new ListViewItem();
                        item.Text = dr.GetValue(0).ToString();


                        for (int i = 1; i < dr.FieldCount; i++)
                        {
                            item.SubItems.Add(dr.GetValue(i).ToString());
                        }
                        lstInf.Items.Add(item);
                    }



                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            btnSal.Enabled = false ;
            btnCanc.Enabled = false;

        }
        private void BtnExc_Click(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt32(lstInf.SelectedItems[0].SubItems[0].Text);

           
                using (var cmd = DbAcme().CreateCommand())
                {
                    cmd.CommandText = "delete from TB_VOO where Id_Voo ='" + id + "'";

                    cmd.ExecuteNonQuery();
                    lstInf.Items.Clear();
                    AtualizarLista();
                }
            }
        
        private void BtnInc_Click(object sender, EventArgs e)
        {
                                   

            try
            {
                using (var cmd = DbAcme().CreateCommand())
                {
                    
                    if (rbtNao.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Captura", "N");

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Captura", "S");
                    }

                    cmd.CommandText = "INSERT INTO TB_Voo(Data_Voo, Captura, Nivel_Dor ) values (@Data_Voo, @Captura, @Nivel_Dor)";
                    cmd.Parameters.AddWithValue("@Data_Voo", txtData.Text);
                    cmd.Parameters.AddWithValue("@Nivel_Dor", txtNivDor.Text);
                    cmd.ExecuteNonQuery();

                    

                    txtData.Text = "";
                    txtNivDor.Text = "";
                    rbtNao.Checked = false;
                    rbtSim.Checked = false;

                    lstInf.Items.Clear();
                    AtualizarLista();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            


        
        }

        private void LstInf_DoubleClick(object sender, EventArgs e)
        {
            btnCanc.Enabled = true;
            btnSal.Enabled = true;



            using (var cmd = DbAcme().CreateCommand())
            {


                SQLiteDataReader dr;

                int ida = Convert.ToInt32(lstInf.SelectedItems[0].SubItems[0].Text);

               
                    cmd.CommandText = "SELECT Data_Voo, Captura, Nivel_Dor FROM TB_VOO WHERE Id_Voo = '" + ida + "'";
                    cmd.Parameters.AddWithValue("@Data_Voo", txtData.Text);
                    cmd.Parameters.AddWithValue("@Nivel_Dor", txtNivDor.Text);

                    cmd.CommandType = CommandType.Text;

                    dr = cmd.ExecuteReader();
                    dr.Read();
                    txtData.Text = dr.GetString(0);
                    if (lstInf.SelectedItems[0].SubItems[2].Text == "S")
                    {
                        rbtSim.Checked = true;
                    }
                    else
                    {
                        rbtSim.Checked = false;
                        rbtNao.Checked = true;

                    }

                    txtNivDor.Text = dr.GetString(2);
            }
                lstInf.Items.Clear();
                AtualizarLista();

                      
        }

        private void AtualizarLista()
        {
            ListViewItem item;

            using (var cmd = DbAcme().CreateCommand())
            {
                cmd.CommandText = "SELECT Id_Voo, Data_Voo, Captura, Nivel_Dor FROM TB_VOO";
                SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new ListViewItem();
                    item.Text = dr.GetValue(0).ToString();


                    for (int i = 1; i < dr.FieldCount; i++)
                    {
                        item.SubItems.Add(dr.GetValue(i).ToString());
                    }
                    lstInf.Items.Add(item);
                }



            }
        }
            private void BtnCanc_Click(object sender, EventArgs e)
        {
            btnCanc.Enabled = false;
            btnSal.Enabled = false;

            txtData.Clear();
            rbtNao.Checked = false;
            rbtSim.Checked = false;
            txtNivDor.Clear();
        }

        private void LstInf_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
