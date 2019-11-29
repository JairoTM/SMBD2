using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Manejador_BD_JTM
{
    public partial class Form1 : Form
    {
        bool banderaCerrado = false;
        string nombreAtributoAeditar;
        string rutaRaiz;
        string rutaSelectedResp;
        string rutaSelectedRespArchivo;
        string nombreAnterior;
        string tipoNodo;
        char[] nombre_Atributos_Char;
        char[] nombre_ArchivoR_Atributos_Char;
        char tipoDatoAgregar;
        private string rutaSelected;
        DataTable TablaDeAtributos;
        DataTable TablaDeRegistros;

        ImageList myImageList = new ImageList();
        FileInfo Archivo_DD_atributos;
        List<Atributo> Lista_Atributos_Actual = new List<Atributo>();
        string nombreTabla = string.Empty;
        FileInfo ArchivoTabla;
        long  pos, Direccion_Atributo;
        int longitudDato;
        Tabla tablaActual = new Tabla();//tabla para la base de datos actual
        BaseDatos baseD_actua = new BaseDatos();//base de datos actual
        public Form1()
        {

            InitializeComponent();
            inicializa();
            TablaDeAtributos = new DataTable("Atributos");
            TablaDeRegistros = new DataTable("Registros");
            creaColumnas();
            dgv_Atributos.DataSource = TablaDeAtributos;
            dgvRegistros.DataSource = TablaDeRegistros;
        }
        //
        private void inicializa()
        {
            rutaRaiz = string.Empty;
            nombreAnterior = string.Empty;
            tipoNodo = string.Empty;
            rutaSelected = string.Empty;
        }
        //
        private TreeNode creaArbol(DirectoryInfo directoryInfo)
        {

            TreeNode treeNode = new TreeNode(directoryInfo.Name);
            //   if(Directory.Exists(direc))
            foreach (var item in directoryInfo.GetDirectories())
            {

                treeNode.Nodes.Add(creaArbol(item));

            }
            foreach (var item in directoryInfo.GetFiles())
            {
                treeNode.ImageIndex = 1;
                // item.
                treeNode.Nodes.Add(new TreeNode(item.Name));
            }
            return treeNode;
        }
        protected void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            // Determine by checking the Text property.  
            // MessageBox.Show(e.Node.Text);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.tvCarpetasArchivos, "Para renombrar un archivo o carpeta, realiza 2 clics sobre el elemento a renombrar");
            //  toolTip1.SetToolTip(this.checkBox1, "My checkBox1");
        }
        private void iniciaTree(string ruta)
        {
            if (ruta.Count() > 0)
            {
                string rutaCarpeta = @ruta;
                // tvCarpetasArchivos.Nodes.Clear();
                DirectoryInfo directoryInfo = new DirectoryInfo(rutaCarpeta);
                tvCarpetasArchivos.Nodes.Add(creaArbol(directoryInfo));
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //if(tvCarpetasArchivos.SelectedNode.)

        }
        private void CreaBD()
        {

            tvCarpetasArchivos.ImageList = myImageList;
            myImageList.Images.Add(Image.FromFile("carpeta-close.png"));
            myImageList.Images.Add(Image.FromFile("archivo.png"));
            tvCarpetasArchivos.ImageIndex = 0;
            string rutaDiectorio = string.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                rutaDiectorio = fbd.SelectedPath;
            }
            folderBrowserDialog1.SelectedPath = rutaRaiz;
            rutaRaiz = rutaDiectorio;
            iniciaTree(rutaDiectorio);
        }
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void CrearBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreaBD();

        }

        private void TvCarpetasArchivos_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            nombreAnterior = e.Node.Text;
            cambiarNombre cambiarNombrev = new cambiarNombre();
            cambiarNombrev.ePasar += new cambiarNombre.pasar(renombrar);
            cambiarNombrev.ShowDialog();
           

        }
        public void renombrar(string nombre)
        {

            string diagona = @"\";
            string nombrePasado = string.Empty;
            string nombreFuturo = string.Empty;
            if (rutaRaiz.Contains(nombreAnterior))//renombra la raiz
            {

                nombrePasado = @rutaRaiz;
                nombreFuturo = @rutaRaiz.Replace(nombreAnterior, "") + nombre;
                rutaRaiz = nombreFuturo;
            }
            else
            {
                nombrePasado = @rutaRaiz + diagona + nombreAnterior;
                nombreFuturo = @rutaRaiz + diagona + nombre;
            }
            FileAttributes attr = File.GetAttributes(nombrePasado);

            //detect whether its a directory or file
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {


                try
                {
                    Directory.Move(nombrePasado, nombreFuturo);
                    MessageBox.Show("Se ha renombrado la base de datos");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }



            }
            else

            {
                if (File.Exists(nombreFuturo))
                    File.Delete(nombreFuturo);

                // Move the file.--renombrar si necesidad de dar la extencion
                File.Move(nombrePasado, nombreFuturo + ".bin");
                if (File.Exists(nombrePasado))
                {
                    MessageBox.Show("Archivo original existe aún");
                }
                else
                {
                    MessageBox.Show("Se ha renombrado una tabla");
                }
            }




            banderaCerrado = true;

        }
        private void creaArchivo(string ruta)
        {
            string diagona = @"\";
            FileInfo archivoF = new FileInfo(rutaSelectedResp + ruta + ".bin");
            using (BinaryWriter writer = new BinaryWriter(archivoF.Open(FileMode.OpenOrCreate, FileAccess.Write)))//abre o crea un archivo
            {

            }

        }
        private void RefrescarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            refre();


        }
        private void refre()
        {
            tvCarpetasArchivos.Nodes.Clear();
            if (Directory.Exists(rutaRaiz))
                iniciaTree(rutaRaiz);
        }
        private void TvCarpetasArchivos_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TablaDeRegistros.Clear();
            TablaDeAtributos.Clear();
            string diagona = @"\";
            string rutaSelected = @rutaRaiz + diagona/*+ e.Node.Text*/;
            rutaSelectedResp = @rutaRaiz + diagona;
            rutaSelectedRespArchivo = /*@rutaRaiz + diagona +*/ e.Node.Text;

            if (e.Node.Text.Contains(".bin"))
            {
                ArchivoTabla = new FileInfo(rutaSelected + e.Node.Text);
                lbTablaSelec.Text = "Tabla seleccionada: " + e.Node.Text;
                cbTipoDeLlave.Enabled = true;
                cbTipoDatoAtributo.Enabled = true;
                btAgregarAtritbuto.Enabled = true;
                nombreTabla = e.Node.Text;
                LeerAtributosTabla();
            }
            else
            {
                lbTablaSelec.Text = "Ninguna tabla seleccionada ";
                cbTipoDeLlave.Enabled = false;
                cbTipoDatoAtributo.Enabled = false;
                btAgregarAtritbuto.Enabled = false;
            }
            //MessageBox.Show(rutaSelected);

        }

        private void BttCreaTabla_Click(object sender, EventArgs e)
        {
            cambiarNombre cambiarNombrev = new cambiarNombre();
            cambiarNombrev.ePasar += new cambiarNombre.pasar(creaArchivo);
            cambiarNombrev.ShowDialog();
            refre();
        }
        public void nuevoArchivo(string nombre)
        {

        }

        private void CargarBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inicializa();
            tvCarpetasArchivos.Nodes.Clear();
            CreaBD();

        }

        private void TvCarpetasArchivos_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {

        }

        private void EliminarBD_Click(object sender, EventArgs e)
        {
            // if()
            System.IO.Directory.Delete(rutaSelectedResp, true);
            refre();

        }
        #region Atributos
        private void creaColumnas()
        {
            TablaDeAtributos.Columns.Add("Nombre", System.Type.GetType("System.String"));
            TablaDeAtributos.Columns.Add("Enlace", System.Type.GetType("System.String"));
            TablaDeAtributos.Columns.Add("Tipo", System.Type.GetType("System.String"));
            TablaDeAtributos.Columns.Add("Longitud", System.Type.GetType("System.Int32"));
            TablaDeAtributos.Columns.Add("Dir.Atributo", System.Type.GetType("System.Int64"));
            TablaDeAtributos.Columns.Add("Llave", System.Type.GetType("System.String"));
           

        }
        private void llenaTabla()
        {
            TablaDeAtributos.Clear();
            if(Lista_Atributos_Actual.Count!=0)
            for (int i = 0; i < Lista_Atributos_Actual.Count; i++)
            {

                    TablaDeAtributos.Rows.Add(new object[]
                    {
                         Lista_Atributos_Actual[i].nombeAtributo_String,
                        Lista_Atributos_Actual[i].nombre_ArchivoLlaveForaneaString,
                         Lista_Atributos_Actual[i].tipoDeDato,
                        Lista_Atributos_Actual[i].longitudDato,
                        Lista_Atributos_Actual[i].DireccionAtributo,
                        Lista_Atributos_Actual[i].tipocve
                       


                    }) ;

                    }
            
        }
       
        private void LeerAtributosTabla()
        {
            long direccion_atributo, dir_indice, dir_siguienteAtributo;
            int tipo_clave, longitud_atributo;
            char[] nombre_Atributos_Char, nombre_Archivo_LlaveF;

            char tipo;
            using (BinaryReader r = new BinaryReader(File.Open(ArchivoTabla.FullName, FileMode.Open)))//para leer
            {
                Lista_Atributos_Actual.Clear();
                int tamanioArchivo = (int)r.BaseStream.Length;
                if (tamanioArchivo > 8)
                {
                    

                    long dirSig = 0;
                    r.BaseStream.Seek(0, SeekOrigin.Begin);
                    while (dirSig != -1)//mientras la direcci[on de siguiente atributo no sea null                                    { }
                    {
                        //dir_indice = r.ReadInt64();//8
                        Atributo auxAtributo = new Atributo();
                        nombre_Atributos_Char = r.ReadChars(35);//35
                        nombre_Archivo_LlaveF = r.ReadChars(35);//35
                        tipo = r.ReadChar();//1 tipo de atributo entero o char
                        longitud_atributo = r.ReadInt32();//4
                        tipo_clave = r.ReadInt32();//4
                        direccion_atributo = r.ReadInt64();//8
                        dir_siguienteAtributo = r.ReadInt64();//8
                        dirSig = dir_siguienteAtributo;
                        for (int i = 0; i < nombre_Atributos_Char.Count(); i++)
                        {
                            if (nombre_Atributos_Char[i] != Convert.ToChar("\0"))
                            {
                                auxAtributo.nombeAtributo_String += nombre_Atributos_Char[i];
                            }
                        }
                        for (int i = 0; i < nombre_Archivo_LlaveF.Count(); i++)
                        {
                            if (nombre_Archivo_LlaveF[i] != Convert.ToChar("\0"))
                            {
                                auxAtributo.nombre_ArchivoLlaveForaneaString += nombre_Archivo_LlaveF[i];
                            }
                        }
                        auxAtributo.tipoDeDato = tipo;
                        auxAtributo.longitudDato = longitud_atributo;
                        auxAtributo.DireccionAtributo = direccion_atributo;
                        auxAtributo.tipocve = tipo_clave;
                        
                        auxAtributo.DireccionSigAtributo = dir_siguienteAtributo;
                        
                        if(auxAtributo.tipoDeDato=='E')
                        TablaDeRegistros.Columns.Add(auxAtributo.nombeAtributo_String, System.Type.GetType("System.Int32"));
                        else if  (auxAtributo.tipoDeDato == 'F')
                            TablaDeRegistros.Columns.Add(auxAtributo.nombeAtributo_String);
                        else
                            TablaDeRegistros.Columns.Add(auxAtributo.nombeAtributo_String, System.Type.GetType("System.String"));


                        Lista_Atributos_Actual.Add(auxAtributo);
                    }
                    r.Close();
                    llenaTabla();
                    }
                else
                {
                    if (tamanioArchivo == 0)
                    {
                        r.Close();
                        MessageBox.Show("Tabla vacia");
                        inicializaTabla();
                    }
                    else
                    {
                        MessageBox.Show("Tabla vacia");

                    }

                }
            }
        }
        private Atributo creaAtributo()
        {
            Atributo atributoAux = new Atributo();

            nombre_Atributos_Char = convertirChar(tbNombreAtributo.Text);
            nombre_ArchivoR_Atributos_Char = convertirChar(rutaSelectedRespArchivo);
            atributoAux.nombre_ArchivoLlaveForanea = nombre_ArchivoR_Atributos_Char;
            atributoAux.nombeAtributo_String = tbNombreAtributo.Text;
            atributoAux.nombre_ArchivoLlaveForaneaString = rutaSelectedRespArchivo;
            atributoAux.nombre_Atributo = nombre_Atributos_Char;
            atributoAux.longitudDato =Convert.ToInt32( tbTamanio.Text);

            if (cbTipoDatoAtributo.Text == "Entero")
            {
                atributoAux.tipoDeDato = 'E';

            }
            else if(cbTipoDatoAtributo.Text == "Flotante")
            {
                atributoAux.tipoDeDato = 'F';

            }
            else  
            {
                atributoAux.tipoDeDato = 'C';

            }
            if (cbTipoDeLlave.Text == "Ninguna")
            {
                atributoAux.tipocve = 0;
            }
            else if (cbTipoDeLlave.Text == "Primaria")
            {
                atributoAux.tipocve = 1;

            }
            else//Para Foranea
            {
                atributoAux.tipocve = 2;
            }
            atributoAux.DireccionSigAtributo = -1;
            return atributoAux;

        }

        private void CbTipoDeLlave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoDeLlave.Text == "Foranea")
            {
              //  foreach()
                foreach (String  TablaAgregar in Directory.GetFiles(rutaSelectedResp))
                {
                    cbTablaDeLlaveForanea.Items.Add(TablaAgregar);
                }

            }

        }

        private void CbTipoDatoAtributo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Dgv_Atributos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dgv_Atributos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                nombreAtributoAeditar = (string)dgv_Atributos.CurrentCell.Value;
                EditarAtributo(nombreAtributoAeditar);
            }
            catch (InvalidCastException a)
            {
                
            }
        }
        private void EditarAtributo(string nombre_A_Editar)
        {
            foreach (Atributo a1 in Lista_Atributos_Actual)
            {
                if (a1.nombeAtributo_String == nombre_A_Editar)
                {
                    tbNombreAtributo.Text = nombre_A_Editar;
                    if (a1.tipoDeDato == 'E')
                        cbTipoDatoAtributo.SelectedIndex=0;
                    else if (a1.tipoDeDato == 'C')
                        cbTipoDatoAtributo.SelectedIndex = 1;
                    else
                        cbTipoDatoAtributo.SelectedIndex = 2;

                    if (a1.tipocve == 0)
                    {
                        cbTipoDeLlave.SelectedIndex = 0;
                    }
                    else if (a1.tipocve == 1)
                    {
                        cbTipoDeLlave.SelectedIndex = 1;
                    }
                    else
                    {
                        cbTipoDeLlave.SelectedIndex = 2;
                    }
                    tbTamanio.Text =Convert.ToString( a1.longitudDato);
                }
            }
        }
        private void limpiezaEdicion()
        {
            tbNombreAtributo.Clear();
            tbTamanio.Clear();
            
        }
        private void BtEditarAtributo_Click(object sender, EventArgs e)
        {

            using (BinaryWriter writer = new BinaryWriter(ArchivoTabla.Open(FileMode.Open, FileAccess.Write)))
            {
                foreach (Atributo a1 in Lista_Atributos_Actual)
                {
                    if (a1.nombeAtributo_String == nombreAtributoAeditar)
                    {
                        a1.nombeAtributo_String = tbNombreAtributo.Text;
                        a1.nombre_Atributo = convertirChar(tbNombreAtributo.Text);
                        if (cbTipoDatoAtributo.Text == "Entero")
                        {
                            a1.tipoDeDato = 'E';
                           

                        }
                        else if (cbTipoDatoAtributo.Text !="Flotante")
                        {
                            a1.tipoDeDato = 'C';

                        }
                        else
                        {
                            a1.tipoDeDato = 'F';

                        }
                       longitudDato =Convert.ToInt32( tbTamanio.Text);
                        if (cbTipoDeLlave.Text == "Ninguna")
                        {
                            a1.tipocve = 0;
                        }
                        else if (cbTipoDeLlave.Text == "Primaria")
                        {
                            a1.tipocve = 1;

                        }
                        else//Para Foranea
                        {
                            a1.tipocve = 2;
                        }

                        writer.BaseStream.Seek(a1.DireccionAtributo, SeekOrigin.Begin);
                        writer.Write(a1.nombre_Atributo);//35
                        writer.Write(a1.nombre_ArchivoLlaveForanea);//35
                        writer.Write(a1.tipoDeDato);//1
                        writer.Write(a1.longitudDato);//4
                        writer.Write(a1.tipocve);//4
                        writer.Write(a1.DireccionAtributo); //8
                        writer.Write(pos); //direccin del siguiente indice
                        MessageBox.Show("Atributo editado");
                        llenaTabla();
                    }
                }
                writer.Close();

            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            System.IO.File.Delete(rutaSelectedResp+ rutaSelectedRespArchivo);
            refre();
        }

        private char[] convertirChar(string nombre)
        {
            char[] auxChar = new char[35];// 
            for (int i = 0; i < nombre.Count(); i++)//
            {
                auxChar[i] = nombre[i];
            }

            return auxChar;
        }
        private void inicializaTabla()//función para inicializar el archivo
        {
            using (BinaryWriter writer = new BinaryWriter(ArchivoTabla.Open(FileMode.Open, FileAccess.Write)))
            {
                pos = writer.BaseStream.Length;
                if (pos < 0)
                {
                    long cabecera = -1;
                    writer.BaseStream.Seek(0, SeekOrigin.Begin);
                    writer.Write(cabecera);
                    writer.Close();
                    MessageBox.Show("se inicializo la tabla");
                }
                else
                {
                     //aqu[i se cambia la cabecera a la dirección del primer registro

                }
            }


        }
        private void BtAgregarAtritbuto_Click(object sender, EventArgs e)
        {
            Atributo atriGrab = new Atributo();
            atriGrab = creaAtributo();///////////////////////////

            using (BinaryWriter writer = new BinaryWriter(ArchivoTabla.Open(FileMode.Open, FileAccess.Write)))
            {
                pos = writer.BaseStream.Length;
               
               
                //me muevo a la ubicaci[on a grabar
                if (Lista_Atributos_Actual.Count() == 0)
                {
                   
                }
                else//de regrabar la direcci[on del siguiente atributo para poner su direccion siguiente diferente a -1
                {
                    long pos1 = writer.BaseStream.Length;
                    writer.BaseStream.Seek(pos1-8, SeekOrigin.Begin);

                    Lista_Atributos_Actual[Lista_Atributos_Actual.Count - 1].DireccionSigAtributo = pos;
                   
                   /* writer.BaseStream.Seek(Lista_Atributos_Actual[Lista_Atributos_Actual.Count - 1].DireccionAtributo, SeekOrigin.Begin);
                    writer.Write(Lista_Atributos_Actual[Lista_Atributos_Actual.Count - 1].nombre_Atributo);//35
                    writer.Write(Lista_Atributos_Actual[Lista_Atributos_Actual.Count - 1].nombre_ArchivoLlaveForanea);//35
                    writer.Write(Lista_Atributos_Actual[Lista_Atributos_Actual.Count - 1].tipoDeDato);//1
                    writer.Write(Lista_Atributos_Actual[Lista_Atributos_Actual.Count - 1].longitudDato);//4
                    writer.Write(Lista_Atributos_Actual[Lista_Atributos_Actual.Count - 1].tipocve);//4
                    writer.Write(Lista_Atributos_Actual[Lista_Atributos_Actual.Count - 1].DireccionAtributo); //8*/
                    writer.Write(pos); //direccin del siguiente indice

                }
                writer.BaseStream.Seek(pos, SeekOrigin.Begin);
                atriGrab.DireccionAtributo = writer.BaseStream.Length;
                writer.BaseStream.Seek(pos, SeekOrigin.Begin);
                writer.Write(atriGrab.nombre_Atributo);//35
                writer.Write(atriGrab.nombre_ArchivoLlaveForanea);//35
                writer.Write(atriGrab.tipoDeDato);//1
                writer.Write(atriGrab.longitudDato); //4
                writer.Write(atriGrab.tipocve);//4
              

                writer.Write(atriGrab.DireccionAtributo);//8
                writer.Write(atriGrab.DireccionSigAtributo);//8

                Lista_Atributos_Actual.Add(atriGrab);
                writer.Close();
            }


            llenaTabla();
        }
        #endregion
    }
}
