using System.Data;
using System.Linq;

namespace ADM
{
    public partial class Form1 : Form
    {
        DataSet LOPO = new DataSet();
        Access acceso = new();
        public Form1()
        {
            InitializeComponent();
        }

        public void Cargar_Data_Set()
        {
            DataTable tabla_alumnos = acceso.Leer("OBTENER_ALUMNO");
            DataTable tabla_asignaturas = acceso.Leer("OBTENER_ASIGNATURA");
            DataTable tabla_AlumAsig = acceso.Leer("OBTENER_ALUM_ASIG");


            tabla_alumnos.TableName = "Alumnos";
            tabla_asignaturas.TableName = "Asignaturas";
            tabla_AlumAsig.TableName = "AlumAsig";


            LOPO.Tables.Add(tabla_alumnos);
            LOPO.Tables.Add(tabla_asignaturas);
            LOPO.Tables.Add(tabla_AlumAsig);

            DataRelation relation_Alum_AlumAsig = new DataRelation
            (
                "FK_ALUM_ALUMASIG",
                tabla_alumnos.Columns["LEGAJO"],
                tabla_AlumAsig.Columns["LEGAJO"]
            );

            LOPO.Relations.Add(relation_Alum_AlumAsig);

            DataRelation relation_Asignatura_AlumAsig = new DataRelation
            (
                "FK_ASIG_ALUMASIG",
                tabla_asignaturas.Columns["ID"],
                tabla_AlumAsig.Columns["ID"]
            );
            LOPO.Relations.Add(relation_Asignatura_AlumAsig);
        }
        public void Master_Detail()
        {
            try
            {
                BindingSource bdAlumnos = new BindingSource();
                BindingSource bdAsignatura = new BindingSource();
                BindingSource bd_Asignaturas_Cursadas = new BindingSource();
                BindingSource bd_Materias_Por_Cursar = new BindingSource();

                bdAlumnos.DataSource = LOPO;
                bdAlumnos.DataMember = "Alumnos";

                bdAsignatura.DataSource = LOPO;
                bdAsignatura.DataMember = "Asignaturas";

                bd_Asignaturas_Cursadas.DataSource = bdAlumnos;
                bd_Asignaturas_Cursadas.DataMember = "FK_ALUM_ALUMASIG";

                bd_Materias_Por_Cursar.DataSource = 

                Grilla_Alumnos.DataSource = bdAlumnos;
                Grilla_Asignatura.DataSource = bdAsignatura;
                Grilla_Materias_Cursadas.DataSource = bd_Asignaturas_Cursadas;


                bdAlumnos.CurrentChanged += (ob , sender) =>
                {
                    if ( bdAlumnos.Current is DataRowView fila_alumno )
                    {
                        int legajo = Convert.ToInt32(fila_alumno["LEGAJO"]);

                        var cursadas = LOPO.Tables["AlumAsig"]
                                    .AsEnumerable()
                                    .Where(Entry => Entry.Field<int>("LEGAJO") == legajo)
                                    .Select( Entry => Entry.Field<int>("ID"))
                                    .ToArray();

                        DataView dv = new DataView(LOPO.Tables["Asignaturas"]);

                        if ( cursadas.Length > 0 )
                        {
                            dv.RowFilter = $" ID NOT IN ({string.Join(",",cursadas)})";
                        }
                        else
                        {
                            dv.RowFilter = "";
                        }
                        Grilla_Materias_Por_Cursar.DataSource = dv;
                    }



                };



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar_Data_Set();
            Master_Detail();
        }
    }
}
