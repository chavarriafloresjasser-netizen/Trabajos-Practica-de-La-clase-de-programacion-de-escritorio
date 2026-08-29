namespace Estudiantes2M7
{
    partial class FormInicioRegistroEstudiante
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelCarnet = new Label();
            labelNombreCompleto = new Label();
            labelSexo = new Label();
            labelFechaNacimiento = new Label();
            labelCorreo = new Label();
            textBoxCarnet = new TextBox();
            textBoxNombreCompleto = new TextBox();
            textBoxCorreo = new TextBox();
            dateTimePickerFechaNacimiento = new DateTimePicker();
            comboBoxSexo = new ComboBox();
            dataGridViewEstudiantes = new DataGridView();
            buttonGuardar = new Button();
            errorProvider1 = new ErrorProvider(components);
            buttonLimpiar = new Button();
            buttonSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstudiantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // labelCarnet
            // 
            labelCarnet.AutoSize = true;
            labelCarnet.Location = new Point(22, 18);
            labelCarnet.Name = "labelCarnet";
            labelCarnet.Size = new Size(42, 15);
            labelCarnet.TabIndex = 0;
            labelCarnet.Text = "Carnet";
            // 
            // labelNombreCompleto
            // 
            labelNombreCompleto.AutoSize = true;
            labelNombreCompleto.Location = new Point(22, 83);
            labelNombreCompleto.Name = "labelNombreCompleto";
            labelNombreCompleto.Size = new Size(105, 15);
            labelNombreCompleto.TabIndex = 1;
            labelNombreCompleto.Text = "Nombre completo";
            // 
            // labelSexo
            // 
            labelSexo.AutoSize = true;
            labelSexo.Location = new Point(22, 161);
            labelSexo.Name = "labelSexo";
            labelSexo.Size = new Size(32, 15);
            labelSexo.TabIndex = 2;
            labelSexo.Text = "Sexo";
            // 
            // labelFechaNacimiento
            // 
            labelFechaNacimiento.AutoSize = true;
            labelFechaNacimiento.Location = new Point(22, 236);
            labelFechaNacimiento.Name = "labelFechaNacimiento";
            labelFechaNacimiento.Size = new Size(117, 15);
            labelFechaNacimiento.TabIndex = 3;
            labelFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(22, 297);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(43, 15);
            labelCorreo.TabIndex = 4;
            labelCorreo.Text = "Correo";
            // 
            // textBoxCarnet
            // 
            textBoxCarnet.Location = new Point(184, 10);
            textBoxCarnet.Name = "textBoxCarnet";
            textBoxCarnet.Size = new Size(228, 23);
            textBoxCarnet.TabIndex = 5;
            // 
            // textBoxNombreCompleto
            // 
            textBoxNombreCompleto.Location = new Point(184, 75);
            textBoxNombreCompleto.Name = "textBoxNombreCompleto";
            textBoxNombreCompleto.Size = new Size(228, 23);
            textBoxNombreCompleto.TabIndex = 6;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(184, 289);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(228, 23);
            textBoxCorreo.TabIndex = 7;
            // 
            // dateTimePickerFechaNacimiento
            // 
            dateTimePickerFechaNacimiento.Location = new Point(184, 236);
            dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            dateTimePickerFechaNacimiento.Size = new Size(268, 23);
            dateTimePickerFechaNacimiento.TabIndex = 8;
            // 
            // comboBoxSexo
            // 
            comboBoxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSexo.FormattingEnabled = true;
            comboBoxSexo.Items.AddRange(new object[] { "M", "F" });
            comboBoxSexo.Location = new Point(184, 153);
            comboBoxSexo.Name = "comboBoxSexo";
            comboBoxSexo.Size = new Size(239, 23);
            comboBoxSexo.TabIndex = 9;
            // 
            // dataGridViewEstudiantes
            // 
            dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstudiantes.Location = new Point(492, 23);
            dataGridViewEstudiantes.Name = "dataGridViewEstudiantes";
            dataGridViewEstudiantes.Size = new Size(285, 344);
            dataGridViewEstudiantes.TabIndex = 10;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(22, 357);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(85, 36);
            buttonGuardar.TabIndex = 11;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(156, 357);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(85, 36);
            buttonLimpiar.TabIndex = 12;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(301, 357);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(85, 36);
            buttonSalir.TabIndex = 13;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // FormInicioRegistroEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSalir);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonGuardar);
            Controls.Add(dataGridViewEstudiantes);
            Controls.Add(comboBoxSexo);
            Controls.Add(dateTimePickerFechaNacimiento);
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxNombreCompleto);
            Controls.Add(textBoxCarnet);
            Controls.Add(labelCorreo);
            Controls.Add(labelFechaNacimiento);
            Controls.Add(labelSexo);
            Controls.Add(labelNombreCompleto);
            Controls.Add(labelCarnet);
            Name = "FormInicioRegistroEstudiante";
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstudiantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCarnet;
        private Label labelNombreCompleto;
        private Label labelSexo;
        private Label labelFechaNacimiento;
        private Label labelCorreo;
        private TextBox textBoxCarnet;
        private TextBox textBoxNombreCompleto;
        private TextBox textBoxCorreo;
        private DateTimePicker dateTimePickerFechaNacimiento;
        private ComboBox comboBoxSexo;
        private DataGridView dataGridViewEstudiantes;
        private Button buttonGuardar;
        private ErrorProvider errorProvider1;
        private Button buttonSalir;
        private Button buttonLimpiar;
    }
}
