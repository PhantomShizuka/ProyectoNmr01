namespace ProyectoNmr01
{
    partial class Inicio
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
            this.LblSeleccion = new System.Windows.Forms.Label();
            this.CbxFormulario = new System.Windows.Forms.ComboBox();
            this.BtnEjecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblSeleccion
            // 
            this.LblSeleccion.AutoSize = true;
            this.LblSeleccion.Location = new System.Drawing.Point(12, 9);
            this.LblSeleccion.Name = "LblSeleccion";
            this.LblSeleccion.Size = new System.Drawing.Size(63, 13);
            this.LblSeleccion.TabIndex = 0;
            this.LblSeleccion.Text = "Seleccione:";
            this.LblSeleccion.DoubleClick += new System.EventHandler(this.LblSeleccion_DoubleClick);
            // 
            // CbxFormulario
            // 
            this.CbxFormulario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxFormulario.FormattingEnabled = true;
            this.CbxFormulario.Items.AddRange(new object[] {
            "Formulario 1",
            "Formulario 2",
            "Formulario 3",
            "Formulario 4"});
            this.CbxFormulario.Location = new System.Drawing.Point(15, 34);
            this.CbxFormulario.Name = "CbxFormulario";
            this.CbxFormulario.Size = new System.Drawing.Size(121, 21);
            this.CbxFormulario.TabIndex = 1;
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.Location = new System.Drawing.Point(15, 74);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(121, 23);
            this.BtnEjecutar.TabIndex = 2;
            this.BtnEjecutar.Text = "Ejecutar";
            this.BtnEjecutar.UseVisualStyleBackColor = true;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 114);
            this.Controls.Add(this.BtnEjecutar);
            this.Controls.Add(this.CbxFormulario);
            this.Controls.Add(this.LblSeleccion);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSeleccion;
        private System.Windows.Forms.ComboBox CbxFormulario;
        private System.Windows.Forms.Button BtnEjecutar;
    }
}