namespace form_ejercicio10_agregar_nombre_gmail
{
    partial class Form1
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.dgv_Datos = new System.Windows.Forms.DataGridView();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.Col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(36, 99);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(65, 20);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(152, 99);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(195, 26);
            this.txt_nombre.TabIndex = 1;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(906, 115);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(141, 45);
            this.btn_Agregar.TabIndex = 3;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(509, 99);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(195, 26);
            this.txt_correo.TabIndex = 5;
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Location = new System.Drawing.Point(393, 99);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(57, 20);
            this.lbl_Correo.TabIndex = 4;
            this.lbl_Correo.Text = "Correo";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(906, 188);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(141, 45);
            this.btn_Eliminar.TabIndex = 6;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(906, 340);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(141, 45);
            this.btn_Cerrar.TabIndex = 7;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // dgv_Datos
            // 
            this.dgv_Datos.AllowUserToAddRows = false;
            this.dgv_Datos.AllowUserToDeleteRows = false;
            this.dgv_Datos.AllowUserToOrderColumns = true;
            this.dgv_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_nombre,
            this.Col_Correo});
            this.dgv_Datos.Location = new System.Drawing.Point(116, 232);
            this.dgv_Datos.Name = "dgv_Datos";
            this.dgv_Datos.ReadOnly = true;
            this.dgv_Datos.RowHeadersWidth = 62;
            this.dgv_Datos.RowTemplate.Height = 28;
            this.dgv_Datos.Size = new System.Drawing.Size(540, 196);
            this.dgv_Datos.TabIndex = 8;
            this.dgv_Datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Datos_CellContentClick);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(906, 262);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(141, 45);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Col_nombre
            // 
            this.Col_nombre.HeaderText = "Nombre";
            this.Col_nombre.MinimumWidth = 8;
            this.Col_nombre.Name = "Col_nombre";
            this.Col_nombre.ReadOnly = true;
            this.Col_nombre.Width = 150;
            // 
            // Col_Correo
            // 
            this.Col_Correo.HeaderText = "Correo Electronico";
            this.Col_Correo.MinimumWidth = 8;
            this.Col_Correo.Name = "Col_Correo";
            this.Col_Correo.ReadOnly = true;
            this.Col_Correo.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 500);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.dgv_Datos);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.lbl_Correo);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.DataGridView dgv_Datos;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Correo;
    }
}

