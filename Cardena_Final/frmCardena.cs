using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cardena_Final
{
    public partial class frmCardena : Form
    {
        public frmCardena()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-FR5FQ7D\SQLEXPRESS; database=TI2021; Integrated Security=true");
        private static string cadenaconex = (@"server=DESKTOP-FR5FQ7D\SQLEXPRESS; database=TI2021; Integrated Security=true");
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if(Convert.ToInt32(txtHoras_dic.Text) <= 30)
                {
                    if(Convert.ToInt32(txtHoras_rec.Text) <= 30)
                    {
                        if(Convert.ToInt32(txtHoras_otr.Text) <= 30)
                        {
                            int v = (Convert.ToInt32(txtHoras_dic.Text) - Convert.ToInt32(txtHoras_Perd.Text)) + Convert.ToInt32(txtHoras_rec.Text) + Convert.ToInt32(txtHoras_otr.Text);
                            this.txtHoras_tota.Text =Convert.ToString(v);
                            if(Convert.ToInt32(txtHoras_tota.Text) <= 120)
                            {
                                conexion.Open();
                                string insertar = "INSERT INTO Cardena (Curso, Anio, mes, horas_dictadas, horas_perdidas, horas_recuperadas, horas_otras, horas_totales )" +
                                    "VALUES(@Curso, @Anio, @mes, @horas_dictadas, @horas_perdidas, @horas_recuperadas, @horas_otras, @horas_totales )";
                                SqlCommand comando = new SqlCommand(insertar, conexion);
                                comando.Parameters.Add(new SqlParameter("@Curso", this.comboBoxCurso.Text));
                                comando.Parameters.Add(new SqlParameter("@Anio", this.txtAnio.Text));
                                comando.Parameters.Add(new SqlParameter("@mes", this.txtMes.Text));
                                comando.Parameters.Add(new SqlParameter("@horas_dictadas", this.txtHoras_dic.Text));
                                comando.Parameters.Add(new SqlParameter("@horas_perdidas", this.txtHoras_Perd.Text));
                                comando.Parameters.Add(new SqlParameter("@horas_recuperadas", this.txtHoras_rec.Text));
                                comando.Parameters.Add(new SqlParameter("@horas_otras", this.txtHoras_otr.Text));
                                comando.Parameters.Add(new SqlParameter("@horas_totales", this.txtHoras_tota.Text)); ;
                                comando.ExecuteNonQuery();
                                conexion.Close();
                                MessageBox.Show("Filas Insertadas Correctamente");
                                this.dataGridViewFinal.DataSource = getDatos();
                                txtHoras_dic.Clear();
                                txtAnio.Clear();
                                txtHoras_otr.Clear();
                                txtHoras_rec.Clear();
                                txtHoras_tota.Clear();
                                txtHoras_Perd.Clear();
                                txtMes.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Asegurece que la las horas ingresadas sean menores o iguales a 30");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Asegurece que la las horas ingresadas sean menores o iguales a 30");
                    }
                }
                else
                {
                    MessageBox.Show("Asegurece que la las horas ingresadas sean menores o iguales a 30");
                }

            }catch(Exception E)
            {
                MessageBox.Show(E.Message);
                conexion.Close();
            }
        }

        public static DataTable getDatos()
        {
            string sql = "select Curso, Anio, mes, horas_dictadas, horas_perdidas, horas_recuperadas, horas_otras, horas_totales " + "from Cardena order by Curso";

            SqlConnection ingreso = new SqlConnection(cadenaconex);
            SqlCommand comando = new SqlCommand(sql, ingreso);
            //cuando se pone el adaptador no es necesario abrir y cerrar la coneccion porque el la abre y cierra para sacar la informacion
            SqlDataAdapter ad = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        private void frmCardena_Load(object sender, EventArgs e)
        {
            comboBoxCurso.Items.Add("Primer Curso");
            comboBoxCurso.Items.Add("Segundo Curso");
            comboBoxCurso.Items.Add("Tercer Curso");
            comboBoxCurso.Items.Add("Cuarto Curso");
            comboBoxCurso.Items.Add("Quinto Curso");
            comboBoxCurso.Items.Add("Sexto Curso");
            this.dataGridViewFinal.DataSource = getDatos();
        }

        private void dataGridViewFinal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxCurso.Text = dataGridViewFinal.CurrentRow.Cells[0].Value.ToString();
            txtAnio.Text = dataGridViewFinal.CurrentRow.Cells[1].Value.ToString();
            txtMes.Text = dataGridViewFinal.CurrentRow.Cells[2].Value.ToString();
            txtHoras_dic.Text = dataGridViewFinal.CurrentRow.Cells[3].Value.ToString();
            txtHoras_Perd.Text = dataGridViewFinal.CurrentRow.Cells[4].Value.ToString();
            txtHoras_rec.Text = dataGridViewFinal.CurrentRow.Cells[5].Value.ToString();
            txtHoras_otr.Text = dataGridViewFinal.CurrentRow.Cells[6].Value.ToString();
            txtHoras_tota.Text = dataGridViewFinal.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿ESTAS SEGURO QUE DESEAS ACTUALIZAR?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int v = (Convert.ToInt32(txtHoras_dic.Text) - Convert.ToInt32(txtHoras_Perd.Text)) + Convert.ToInt32(txtHoras_rec.Text) + Convert.ToInt32(txtHoras_otr.Text);
                    this.txtHoras_tota.Text = Convert.ToString(v);
                    conexion.Open();
                    string actualizar = "UPDATE Cardena SET Anio=@Anio, mes=@mes, horas_dictadas=@horas_dictadas," +
                        " horas_perdidas=@horas_perdidas, horas_recuperadas=@horas_recuperadas, horas_otras=@horas_otras, " +
                        "horas_totales=@horas_totales WHERE Curso=Curso";
                    SqlCommand cmd2 = new SqlCommand(actualizar, conexion);
                    cmd2.Parameters.AddWithValue("@Curso", comboBoxCurso.Text);
                    cmd2.Parameters.AddWithValue("@Anio", this.txtAnio.Text);
                    cmd2.Parameters.AddWithValue("@mes", this.txtMes.Text);
                    cmd2.Parameters.AddWithValue("@horas_dictadas", this.txtHoras_dic.Text);
                    cmd2.Parameters.AddWithValue("@horas_perdidas", this.txtHoras_Perd.Text);
                    cmd2.Parameters.AddWithValue("@horas_recuperadas", this.txtHoras_rec.Text);
                    cmd2.Parameters.AddWithValue("@horas_otras", this.txtHoras_otr.Text);
                    cmd2.Parameters.AddWithValue("@horas_totales", this.txtHoras_tota.Text);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido actualizados");
                    conexion.Close();
                    DataTable dt = getDatos();
                    this.dataGridViewFinal.DataSource = getDatos();
                    txtHoras_dic.Clear();
                    txtAnio.Clear();
                    txtHoras_otr.Clear();
                    txtHoras_rec.Clear();
                    txtHoras_Perd.Clear();
                    txtHoras_tota.Clear();
                    txtMes.Clear();

            }
                else
                {
                    MessageBox.Show("NO SE ELIMINO NINGUN DATO", "CANCELACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException E)
            {
                MessageBox.Show( E.Message);
                conexion.Close();
            }
        }
    }
}
