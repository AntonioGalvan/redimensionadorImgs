
namespace RendimensionImagenes
{
    partial class Resizer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resizer));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbxDecoracion = new System.Windows.Forms.PictureBox();
            this.pbxOrigen = new System.Windows.Forms.PictureBox();
            this.pnlOrigen = new System.Windows.Forms.Panel();
            this.pnlOrigenPath = new System.Windows.Forms.Panel();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.pnlDestinoPath = new System.Windows.Forms.Panel();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.pnlDestino = new System.Windows.Forms.Panel();
            this.pbxDestino = new System.Windows.Forms.PictureBox();
            this.btnComprimir = new System.Windows.Forms.Button();
            this.cbxResolucion = new System.Windows.Forms.ComboBox();
            this.pnlCompresor = new System.Windows.Forms.Panel();
            this.rdbMagick = new System.Windows.Forms.RadioButton();
            this.rdbClasico = new System.Windows.Forms.RadioButton();
            this.lblCompresor = new System.Windows.Forms.Label();
            this.lblResolucion = new System.Windows.Forms.Label();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.pbxExit = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblCalidad = new System.Windows.Forms.Label();
            this.cbxCalidad = new System.Windows.Forms.ComboBox();
            this.lblExito = new System.Windows.Forms.Label();
            this.btnNuevaImagen = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pbxTrash = new System.Windows.Forms.PictureBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDecoracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOrigen)).BeginInit();
            this.pnlOrigen.SuspendLayout();
            this.pnlOrigenPath.SuspendLayout();
            this.pnlDestinoPath.SuspendLayout();
            this.pnlDestino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDestino)).BeginInit();
            this.pnlCompresor.SuspendLayout();
            this.pnlExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTrash)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Keep Calm Med", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTitle.Location = new System.Drawing.Point(115, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(246, 37);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Visuals Resizer";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(9, 10);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(101, 70);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 9;
            this.pbxLogo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(276, 35);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pbxDecoracion
            // 
            this.pbxDecoracion.Image = ((System.Drawing.Image)(resources.GetObject("pbxDecoracion.Image")));
            this.pbxDecoracion.Location = new System.Drawing.Point(563, -2);
            this.pbxDecoracion.Margin = new System.Windows.Forms.Padding(2);
            this.pbxDecoracion.Name = "pbxDecoracion";
            this.pbxDecoracion.Size = new System.Drawing.Size(191, 419);
            this.pbxDecoracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDecoracion.TabIndex = 12;
            this.pbxDecoracion.TabStop = false;
            // 
            // pbxOrigen
            // 
            this.pbxOrigen.BackColor = System.Drawing.Color.Transparent;
            this.pbxOrigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxOrigen.Image = ((System.Drawing.Image)(resources.GetObject("pbxOrigen.Image")));
            this.pbxOrigen.Location = new System.Drawing.Point(9, 10);
            this.pbxOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.pbxOrigen.Name = "pbxOrigen";
            this.pbxOrigen.Size = new System.Drawing.Size(27, 28);
            this.pbxOrigen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOrigen.TabIndex = 13;
            this.pbxOrigen.TabStop = false;
            this.pbxOrigen.Click += new System.EventHandler(this.pbxOrigen_Click);
            // 
            // pnlOrigen
            // 
            this.pnlOrigen.BackColor = System.Drawing.Color.LightCoral;
            this.pnlOrigen.Controls.Add(this.pbxOrigen);
            this.pnlOrigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlOrigen.Location = new System.Drawing.Point(67, 116);
            this.pnlOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOrigen.Name = "pnlOrigen";
            this.pnlOrigen.Size = new System.Drawing.Size(44, 47);
            this.pnlOrigen.TabIndex = 14;
            // 
            // pnlOrigenPath
            // 
            this.pnlOrigenPath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlOrigenPath.Controls.Add(this.txtOrigen);
            this.pnlOrigenPath.Location = new System.Drawing.Point(128, 116);
            this.pnlOrigenPath.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOrigenPath.Name = "pnlOrigenPath";
            this.pnlOrigenPath.Size = new System.Drawing.Size(370, 47);
            this.pnlOrigenPath.TabIndex = 15;
            // 
            // txtOrigen
            // 
            this.txtOrigen.AllowDrop = true;
            this.txtOrigen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrigen.Enabled = false;
            this.txtOrigen.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigen.Location = new System.Drawing.Point(13, 14);
            this.txtOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrigen.Multiline = true;
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(345, 26);
            this.txtOrigen.TabIndex = 0;
            this.txtOrigen.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtOrigen_DragDrop);
            this.txtOrigen.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtOrigen_DragEnter);
            this.txtOrigen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtOrigen_MouseDown);
            // 
            // pnlDestinoPath
            // 
            this.pnlDestinoPath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlDestinoPath.Controls.Add(this.txtDestino);
            this.pnlDestinoPath.Location = new System.Drawing.Point(128, 181);
            this.pnlDestinoPath.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDestinoPath.Name = "pnlDestinoPath";
            this.pnlDestinoPath.Size = new System.Drawing.Size(370, 47);
            this.pnlDestinoPath.TabIndex = 17;
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDestino.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDestino.Enabled = false;
            this.txtDestino.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(13, 14);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(2);
            this.txtDestino.Multiline = true;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(345, 26);
            this.txtDestino.TabIndex = 1;
            // 
            // pnlDestino
            // 
            this.pnlDestino.BackColor = System.Drawing.Color.LightCoral;
            this.pnlDestino.Controls.Add(this.pbxDestino);
            this.pnlDestino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDestino.Location = new System.Drawing.Point(67, 181);
            this.pnlDestino.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDestino.Name = "pnlDestino";
            this.pnlDestino.Size = new System.Drawing.Size(44, 47);
            this.pnlDestino.TabIndex = 16;
            // 
            // pbxDestino
            // 
            this.pbxDestino.BackColor = System.Drawing.Color.Transparent;
            this.pbxDestino.Image = ((System.Drawing.Image)(resources.GetObject("pbxDestino.Image")));
            this.pbxDestino.Location = new System.Drawing.Point(9, 10);
            this.pbxDestino.Margin = new System.Windows.Forms.Padding(2);
            this.pbxDestino.Name = "pbxDestino";
            this.pbxDestino.Size = new System.Drawing.Size(27, 28);
            this.pbxDestino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDestino.TabIndex = 13;
            this.pbxDestino.TabStop = false;
            this.pbxDestino.Click += new System.EventHandler(this.pbxDestino_Click);
            // 
            // btnComprimir
            // 
            this.btnComprimir.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnComprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprimir.FlatAppearance.BorderSize = 0;
            this.btnComprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprimir.Font = new System.Drawing.Font("Keep Calm Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprimir.ForeColor = System.Drawing.Color.White;
            this.btnComprimir.Location = new System.Drawing.Point(184, 340);
            this.btnComprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnComprimir.Name = "btnComprimir";
            this.btnComprimir.Size = new System.Drawing.Size(200, 45);
            this.btnComprimir.TabIndex = 18;
            this.btnComprimir.Text = "Comprimir";
            this.btnComprimir.UseVisualStyleBackColor = false;
            this.btnComprimir.Click += new System.EventHandler(this.btnComprimir_Click);
            // 
            // cbxResolucion
            // 
            this.cbxResolucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxResolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxResolucion.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxResolucion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbxResolucion.FormattingEnabled = true;
            this.cbxResolucion.ItemHeight = 17;
            this.cbxResolucion.Items.AddRange(new object[] {
            "1920 x 1080",
            "1280 x 720",
            "960 x 540",
            "640 x 480"});
            this.cbxResolucion.Location = new System.Drawing.Point(341, 290);
            this.cbxResolucion.Margin = new System.Windows.Forms.Padding(2);
            this.cbxResolucion.Name = "cbxResolucion";
            this.cbxResolucion.Size = new System.Drawing.Size(157, 25);
            this.cbxResolucion.TabIndex = 19;
            this.cbxResolucion.Visible = false;
            // 
            // pnlCompresor
            // 
            this.pnlCompresor.Controls.Add(this.rdbMagick);
            this.pnlCompresor.Controls.Add(this.rdbClasico);
            this.pnlCompresor.Location = new System.Drawing.Point(69, 290);
            this.pnlCompresor.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCompresor.Name = "pnlCompresor";
            this.pnlCompresor.Size = new System.Drawing.Size(151, 25);
            this.pnlCompresor.TabIndex = 20;
            // 
            // rdbMagick
            // 
            this.rdbMagick.AutoSize = true;
            this.rdbMagick.Font = new System.Drawing.Font("Roboto Lt", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMagick.Location = new System.Drawing.Point(71, 2);
            this.rdbMagick.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMagick.Name = "rdbMagick";
            this.rdbMagick.Size = new System.Drawing.Size(72, 21);
            this.rdbMagick.TabIndex = 0;
            this.rdbMagick.TabStop = true;
            this.rdbMagick.Text = "Magick";
            this.rdbMagick.UseVisualStyleBackColor = true;
            // 
            // rdbClasico
            // 
            this.rdbClasico.AutoSize = true;
            this.rdbClasico.Checked = true;
            this.rdbClasico.Font = new System.Drawing.Font("Roboto Lt", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbClasico.Location = new System.Drawing.Point(3, 2);
            this.rdbClasico.Margin = new System.Windows.Forms.Padding(2);
            this.rdbClasico.Name = "rdbClasico";
            this.rdbClasico.Size = new System.Drawing.Size(73, 21);
            this.rdbClasico.TabIndex = 0;
            this.rdbClasico.TabStop = true;
            this.rdbClasico.Text = "Clásico";
            this.rdbClasico.UseVisualStyleBackColor = true;
            this.rdbClasico.CheckedChanged += new System.EventHandler(this.rdbClasico_CheckedChanged);
            // 
            // lblCompresor
            // 
            this.lblCompresor.AutoSize = true;
            this.lblCompresor.Font = new System.Drawing.Font("Keep Calm Med", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompresor.Location = new System.Drawing.Point(64, 250);
            this.lblCompresor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompresor.Name = "lblCompresor";
            this.lblCompresor.Size = new System.Drawing.Size(133, 25);
            this.lblCompresor.TabIndex = 0;
            this.lblCompresor.Text = "Compresor";
            // 
            // lblResolucion
            // 
            this.lblResolucion.AutoSize = true;
            this.lblResolucion.Font = new System.Drawing.Font("Keep Calm Med", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResolucion.Location = new System.Drawing.Point(337, 250);
            this.lblResolucion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResolucion.Name = "lblResolucion";
            this.lblResolucion.Size = new System.Drawing.Size(130, 25);
            this.lblResolucion.TabIndex = 0;
            this.lblResolucion.Text = "Resolución";
            this.lblResolucion.Visible = false;
            // 
            // pnlExit
            // 
            this.pnlExit.BackColor = System.Drawing.Color.IndianRed;
            this.pnlExit.Controls.Add(this.pbxExit);
            this.pnlExit.Location = new System.Drawing.Point(9, 370);
            this.pnlExit.Margin = new System.Windows.Forms.Padding(2);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(34, 34);
            this.pnlExit.TabIndex = 16;
            this.pnlExit.Click += new System.EventHandler(this.pnlExit_Click);
            // 
            // pbxExit
            // 
            this.pbxExit.BackColor = System.Drawing.Color.Transparent;
            this.pbxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxExit.Image = ((System.Drawing.Image)(resources.GetObject("pbxExit.Image")));
            this.pbxExit.Location = new System.Drawing.Point(8, 6);
            this.pbxExit.Margin = new System.Windows.Forms.Padding(2);
            this.pbxExit.Name = "pbxExit";
            this.pbxExit.Size = new System.Drawing.Size(20, 24);
            this.pbxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxExit.TabIndex = 13;
            this.pbxExit.TabStop = false;
            this.pbxExit.Click += new System.EventHandler(this.pbxExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"JPG\"|*.jpg";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "\"JPG\"|*.jpg";
            // 
            // lblCalidad
            // 
            this.lblCalidad.AutoSize = true;
            this.lblCalidad.Font = new System.Drawing.Font("Keep Calm Med", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalidad.Location = new System.Drawing.Point(337, 250);
            this.lblCalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalidad.Name = "lblCalidad";
            this.lblCalidad.Size = new System.Drawing.Size(91, 25);
            this.lblCalidad.TabIndex = 21;
            this.lblCalidad.Text = "Calidad";
            // 
            // cbxCalidad
            // 
            this.cbxCalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCalidad.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCalidad.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbxCalidad.FormattingEnabled = true;
            this.cbxCalidad.ItemHeight = 17;
            this.cbxCalidad.Items.AddRange(new object[] {
            "25L",
            "50L",
            "80L",
            "90L"});
            this.cbxCalidad.Location = new System.Drawing.Point(341, 290);
            this.cbxCalidad.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCalidad.Name = "cbxCalidad";
            this.cbxCalidad.Size = new System.Drawing.Size(157, 25);
            this.cbxCalidad.TabIndex = 22;
            // 
            // lblExito
            // 
            this.lblExito.AutoSize = true;
            this.lblExito.Font = new System.Drawing.Font("Keep Calm Med", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExito.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblExito.Location = new System.Drawing.Point(64, 353);
            this.lblExito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExito.Name = "lblExito";
            this.lblExito.Size = new System.Drawing.Size(241, 19);
            this.lblExito.TabIndex = 23;
            this.lblExito.Text = "Se ha comprimido con éxito";
            this.lblExito.Visible = false;
            // 
            // btnNuevaImagen
            // 
            this.btnNuevaImagen.BackColor = System.Drawing.Color.LightCoral;
            this.btnNuevaImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaImagen.FlatAppearance.BorderSize = 0;
            this.btnNuevaImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaImagen.Font = new System.Drawing.Font("Keep Calm Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaImagen.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevaImagen.Location = new System.Drawing.Point(365, 332);
            this.btnNuevaImagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevaImagen.Name = "btnNuevaImagen";
            this.btnNuevaImagen.Size = new System.Drawing.Size(132, 61);
            this.btnNuevaImagen.TabIndex = 24;
            this.btnNuevaImagen.Text = "Comprimir Otra";
            this.btnNuevaImagen.UseVisualStyleBackColor = false;
            this.btnNuevaImagen.Visible = false;
            this.btnNuevaImagen.Click += new System.EventHandler(this.btnNuevaImagen_Click);
            // 
            // pbxTrash
            // 
            this.pbxTrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxTrash.Image = ((System.Drawing.Image)(resources.GetObject("pbxTrash.Image")));
            this.pbxTrash.Location = new System.Drawing.Point(502, 123);
            this.pbxTrash.Margin = new System.Windows.Forms.Padding(2);
            this.pbxTrash.Name = "pbxTrash";
            this.pbxTrash.Size = new System.Drawing.Size(28, 33);
            this.pbxTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxTrash.TabIndex = 25;
            this.pbxTrash.TabStop = false;
            this.pbxTrash.Visible = false;
            this.pbxTrash.Click += new System.EventHandler(this.pbxTrash_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Keep Calm Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(658, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Padding = new System.Windows.Forms.Padding(5);
            this.lblNombreUsuario.Size = new System.Drawing.Size(94, 31);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Antonio";
            // 
            // Resizer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 414);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.pbxTrash);
            this.Controls.Add(this.btnNuevaImagen);
            this.Controls.Add(this.lblExito);
            this.Controls.Add(this.lblCalidad);
            this.Controls.Add(this.cbxCalidad);
            this.Controls.Add(this.pnlExit);
            this.Controls.Add(this.lblResolucion);
            this.Controls.Add(this.lblCompresor);
            this.Controls.Add(this.pnlCompresor);
            this.Controls.Add(this.cbxResolucion);
            this.Controls.Add(this.btnComprimir);
            this.Controls.Add(this.pnlDestinoPath);
            this.Controls.Add(this.pnlDestino);
            this.Controls.Add(this.pnlOrigenPath);
            this.Controls.Add(this.pbxDecoracion);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnlOrigen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Resizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resizer";
            this.Load += new System.EventHandler(this.Resizer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDecoracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOrigen)).EndInit();
            this.pnlOrigen.ResumeLayout(false);
            this.pnlOrigenPath.ResumeLayout(false);
            this.pnlOrigenPath.PerformLayout();
            this.pnlDestinoPath.ResumeLayout(false);
            this.pnlDestinoPath.PerformLayout();
            this.pnlDestino.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDestino)).EndInit();
            this.pnlCompresor.ResumeLayout(false);
            this.pnlCompresor.PerformLayout();
            this.pnlExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTrash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbxDecoracion;
        private System.Windows.Forms.PictureBox pbxOrigen;
        private System.Windows.Forms.Panel pnlOrigen;
        private System.Windows.Forms.Panel pnlOrigenPath;
        private System.Windows.Forms.Panel pnlDestinoPath;
        private System.Windows.Forms.Panel pnlDestino;
        private System.Windows.Forms.PictureBox pbxDestino;
        private System.Windows.Forms.Button btnComprimir;
        private System.Windows.Forms.ComboBox cbxResolucion;
        private System.Windows.Forms.Panel pnlCompresor;
        private System.Windows.Forms.RadioButton rdbMagick;
        private System.Windows.Forms.RadioButton rdbClasico;
        private System.Windows.Forms.Label lblCompresor;
        private System.Windows.Forms.Label lblResolucion;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.PictureBox pbxExit;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblCalidad;
        private System.Windows.Forms.ComboBox cbxCalidad;
        private System.Windows.Forms.Label lblExito;
        private System.Windows.Forms.Button btnNuevaImagen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pbxTrash;
        private System.Windows.Forms.Label lblNombreUsuario;
    }
}