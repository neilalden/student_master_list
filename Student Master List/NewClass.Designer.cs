namespace Student_Master_List
{
    partial class NewClass
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bSCSIABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classesDataSet = new Student_Master_List.ClassesDataSet();
            this.bSCSIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bSCS_IATableAdapter = new Student_Master_List.ClassesDataSetTableAdapters.BSCS_IATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bSCSIABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSCSIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "College :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Course :";
            // 
            // bSCSIABindingSource1
            // 
            this.bSCSIABindingSource1.DataMember = "BSCS-IA";
            this.bSCSIABindingSource1.DataSource = this.classesDataSet;
            // 
            // classesDataSet
            // 
            this.classesDataSet.DataSetName = "ClassesDataSet";
            this.classesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bSCSIABindingSource
            // 
            this.bSCSIABindingSource.DataMember = "BSCS-IA";
            this.bSCSIABindingSource.DataSource = this.classesDataSet;
            // 
            // bSCS_IATableAdapter
            // 
            this.bSCS_IATableAdapter.ClearBeforeFill = true;
            // 
            // NewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Class";
            this.Load += new System.EventHandler(this.NewClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bSCSIABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSCSIABindingSource)).EndInit();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCollege;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbCourse;
        private ClassesDataSet classesDataSet;
        private System.Windows.Forms.BindingSource bSCSIABindingSource;
        private ClassesDataSetTableAdapters.BSCS_IATableAdapter bSCS_IATableAdapter;
        private System.Windows.Forms.BindingSource bSCSIABindingSource1;
    }
}