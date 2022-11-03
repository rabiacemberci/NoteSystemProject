namespace NoteSystem
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coursename = new System.Windows.Forms.TextBox();
            this.coursegrade = new System.Windows.Forms.TextBox();
            this.gpabutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.terminformation = new System.Windows.Forms.TextBox();
            this.coursecode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.allclear = new System.Windows.Forms.Button();
            this.ectscredits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Calculator = new System.Windows.Forms.GroupBox();
            this.logp = new System.Windows.Forms.Label();
            this.CGPA = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eCTSCreditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letterGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseInformationBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.oop2projectDataSet6 = new NoteSystem.oop2projectDataSet6();
            this.courseInformationBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.oop2projectDataSet3 = new NoteSystem.oop2projectDataSet3();
            this.oop2projectDataSet = new NoteSystem.oop2projectDataSet();
            this.courseInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseInformationTableAdapter = new NoteSystem.oop2projectDataSetTableAdapters.CourseInformationTableAdapter();
            this.courseInformationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oop2projectDataSet1 = new NoteSystem.oop2projectDataSet1();
            this.courseInformationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.courseInformationTableAdapter1 = new NoteSystem.oop2projectDataSet1TableAdapters.CourseInformationTableAdapter();
            this.oop2projectDataSet2 = new NoteSystem.oop2projectDataSet2();
            this.courseInformationBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.courseInformationTableAdapter2 = new NoteSystem.oop2projectDataSet2TableAdapters.CourseInformationTableAdapter();
            this.courseInformationTableAdapter3 = new NoteSystem.oop2projectDataSet3TableAdapters.CourseInformationTableAdapter();
            this.oop2projectDataSet4 = new NoteSystem.oop2projectDataSet4();
            this.courseInformationBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.courseInformationTableAdapter4 = new NoteSystem.oop2projectDataSet4TableAdapters.CourseInformationTableAdapter();
            this.oop2projectDataSet5 = new NoteSystem.oop2projectDataSet5();
            this.courseInformationBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.courseInformationTableAdapter5 = new NoteSystem.oop2projectDataSet5TableAdapters.CourseInformationTableAdapter();
            this.courseInformationTableAdapter6 = new NoteSystem.oop2projectDataSet6TableAdapters.CourseInformationTableAdapter();
            this.SEARCH = new System.Windows.Forms.Button();
            this.searchterm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.searchname = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new NoteSystem.oop2projectDataSet3TableAdapters.TableAdapterManager();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lettergrade = new System.Windows.Forms.TextBox();
            this.lettergradebutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.insert = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtu2 = new System.Windows.Forms.TextBox();
            this.txtu3 = new System.Windows.Forms.TextBox();
            this.txtu4 = new System.Windows.Forms.TextBox();
            this.txtu5 = new System.Windows.Forms.TextBox();
            this.txtu6 = new System.Windows.Forms.TextBox();
            this.txtu7 = new System.Windows.Forms.TextBox();
            this.txtu8 = new System.Windows.Forms.TextBox();
            this.txtu1 = new System.Windows.Forms.TextBox();
            this.txts8 = new System.Windows.Forms.TextBox();
            this.txts7 = new System.Windows.Forms.TextBox();
            this.txts6 = new System.Windows.Forms.TextBox();
            this.txts5 = new System.Windows.Forms.TextBox();
            this.txts4 = new System.Windows.Forms.TextBox();
            this.txts3 = new System.Windows.Forms.TextBox();
            this.txts2 = new System.Windows.Forms.TextBox();
            this.txts1 = new System.Windows.Forms.TextBox();
            this.txtc2 = new System.Windows.Forms.TextBox();
            this.txtc3 = new System.Windows.Forms.TextBox();
            this.txtc4 = new System.Windows.Forms.TextBox();
            this.txtc5 = new System.Windows.Forms.TextBox();
            this.txtc6 = new System.Windows.Forms.TextBox();
            this.txtc7 = new System.Windows.Forms.TextBox();
            this.txtc8 = new System.Windows.Forms.TextBox();
            this.txtc1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lgpa = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lp1 = new System.Windows.Forms.Label();
            this.lp7 = new System.Windows.Forms.Label();
            this.lp6 = new System.Windows.Forms.Label();
            this.lp2 = new System.Windows.Forms.Label();
            this.lp8 = new System.Windows.Forms.Label();
            this.lp3 = new System.Windows.Forms.Label();
            this.lp4 = new System.Windows.Forms.Label();
            this.lp5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lg1 = new System.Windows.Forms.Label();
            this.lg2 = new System.Windows.Forms.Label();
            this.lg3 = new System.Windows.Forms.Label();
            this.lg8 = new System.Windows.Forms.Label();
            this.lg4 = new System.Windows.Forms.Label();
            this.lg7 = new System.Windows.Forms.Label();
            this.lg5 = new System.Windows.Forms.Label();
            this.lg6 = new System.Windows.Forms.Label();
            this.courseInformationBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.oop2projectDataSet7 = new NoteSystem.oop2projectDataSet7();
            this.courseInformationTableAdapter7 = new NoteSystem.oop2projectDataSet7TableAdapters.CourseInformationTableAdapter();
            this.oop2projectDataSet8 = new NoteSystem.oop2projectDataSet8();
            this.courseInformationBindingSource9 = new System.Windows.Forms.BindingSource(this.components);
            this.courseInformationTableAdapter8 = new NoteSystem.oop2projectDataSet8TableAdapters.CourseInformationTableAdapter();
            this.groupBox2.SuspendLayout();
            this.Calculator.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource6)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Grade";
            // 
            // coursename
            // 
            this.coursename.Location = new System.Drawing.Point(104, 22);
            this.coursename.Name = "coursename";
            this.coursename.Size = new System.Drawing.Size(167, 20);
            this.coursename.TabIndex = 2;
            // 
            // coursegrade
            // 
            this.coursegrade.Location = new System.Drawing.Point(104, 55);
            this.coursegrade.Name = "coursegrade";
            this.coursegrade.Size = new System.Drawing.Size(100, 20);
            this.coursegrade.TabIndex = 3;
            // 
            // gpabutton
            // 
            this.gpabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpabutton.Location = new System.Drawing.Point(20, 21);
            this.gpabutton.Name = "gpabutton";
            this.gpabutton.Size = new System.Drawing.Size(116, 33);
            this.gpabutton.TabIndex = 4;
            this.gpabutton.Text = "GPA";
            this.gpabutton.UseVisualStyleBackColor = true;
            this.gpabutton.Click += new System.EventHandler(this.gpabutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.terminformation);
            this.groupBox2.Controls.Add(this.coursecode);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.allclear);
            this.groupBox2.Controls.Add(this.ectscredits);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.coursegrade);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.coursename);
            this.groupBox2.Location = new System.Drawing.Point(18, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 213);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Information";
            // 
            // terminformation
            // 
            this.terminformation.Location = new System.Drawing.Point(104, 160);
            this.terminformation.Name = "terminformation";
            this.terminformation.Size = new System.Drawing.Size(100, 20);
            this.terminformation.TabIndex = 5;
            // 
            // coursecode
            // 
            this.coursecode.Location = new System.Drawing.Point(104, 129);
            this.coursecode.Name = "coursecode";
            this.coursecode.Size = new System.Drawing.Size(100, 20);
            this.coursecode.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Term Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Course Code";
            // 
            // allclear
            // 
            this.allclear.Location = new System.Drawing.Point(205, 184);
            this.allclear.Name = "allclear";
            this.allclear.Size = new System.Drawing.Size(75, 23);
            this.allclear.TabIndex = 11;
            this.allclear.Text = "All Clear";
            this.allclear.UseVisualStyleBackColor = true;
            this.allclear.Click += new System.EventHandler(this.allclear_Click);
            // 
            // ectscredits
            // 
            this.ectscredits.Location = new System.Drawing.Point(104, 100);
            this.ectscredits.Name = "ectscredits";
            this.ectscredits.Size = new System.Drawing.Size(100, 20);
            this.ectscredits.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ECTSCredits";
            // 
            // Calculator
            // 
            this.Calculator.Controls.Add(this.logp);
            this.Calculator.Controls.Add(this.gpabutton);
            this.Calculator.Location = new System.Drawing.Point(501, 28);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(154, 112);
            this.Calculator.TabIndex = 16;
            this.Calculator.TabStop = false;
            this.Calculator.Text = "Calculator";
            // 
            // logp
            // 
            this.logp.AutoSize = true;
            this.logp.Location = new System.Drawing.Point(62, 69);
            this.logp.Name = "logp";
            this.logp.Size = new System.Drawing.Size(0, 13);
            this.logp.TabIndex = 71;
            // 
            // CGPA
            // 
            this.CGPA.AutoSize = true;
            this.CGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CGPA.Location = new System.Drawing.Point(35, 29);
            this.CGPA.Name = "CGPA";
            this.CGPA.Size = new System.Drawing.Size(75, 26);
            this.CGPA.TabIndex = 17;
            this.CGPA.Text = "CGPA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(18, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(652, 159);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseCodeDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.eCTSCreditsDataGridViewTextBoxColumn,
            this.termInformationDataGridViewTextBoxColumn,
            this.letterGradeDataGridViewTextBoxColumn,
            this.courseGradeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseInformationBindingSource7;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 140);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // courseCodeDataGridViewTextBoxColumn
            // 
            this.courseCodeDataGridViewTextBoxColumn.DataPropertyName = "CourseCode";
            this.courseCodeDataGridViewTextBoxColumn.HeaderText = "CourseCode";
            this.courseCodeDataGridViewTextBoxColumn.Name = "courseCodeDataGridViewTextBoxColumn";
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            // 
            // eCTSCreditsDataGridViewTextBoxColumn
            // 
            this.eCTSCreditsDataGridViewTextBoxColumn.DataPropertyName = "ECTSCredits";
            this.eCTSCreditsDataGridViewTextBoxColumn.HeaderText = "ECTSCredits";
            this.eCTSCreditsDataGridViewTextBoxColumn.Name = "eCTSCreditsDataGridViewTextBoxColumn";
            // 
            // termInformationDataGridViewTextBoxColumn
            // 
            this.termInformationDataGridViewTextBoxColumn.DataPropertyName = "TermInformation";
            this.termInformationDataGridViewTextBoxColumn.HeaderText = "TermInformation";
            this.termInformationDataGridViewTextBoxColumn.Name = "termInformationDataGridViewTextBoxColumn";
            // 
            // letterGradeDataGridViewTextBoxColumn
            // 
            this.letterGradeDataGridViewTextBoxColumn.DataPropertyName = "LetterGrade";
            this.letterGradeDataGridViewTextBoxColumn.HeaderText = "LetterGrade";
            this.letterGradeDataGridViewTextBoxColumn.Name = "letterGradeDataGridViewTextBoxColumn";
            // 
            // courseGradeDataGridViewTextBoxColumn
            // 
            this.courseGradeDataGridViewTextBoxColumn.DataPropertyName = "CourseGrade";
            this.courseGradeDataGridViewTextBoxColumn.HeaderText = "CourseGrade";
            this.courseGradeDataGridViewTextBoxColumn.Name = "courseGradeDataGridViewTextBoxColumn";
            // 
            // courseInformationBindingSource7
            // 
            this.courseInformationBindingSource7.DataMember = "CourseInformation";
            this.courseInformationBindingSource7.DataSource = this.oop2projectDataSet6;
            // 
            // oop2projectDataSet6
            // 
            this.oop2projectDataSet6.DataSetName = "oop2projectDataSet6";
            this.oop2projectDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseInformationBindingSource4
            // 
            this.courseInformationBindingSource4.DataMember = "CourseInformation";
            this.courseInformationBindingSource4.DataSource = this.oop2projectDataSet3;
            // 
            // oop2projectDataSet3
            // 
            this.oop2projectDataSet3.DataSetName = "oop2projectDataSet3";
            this.oop2projectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oop2projectDataSet
            // 
            this.oop2projectDataSet.DataSetName = "oop2projectDataSet";
            this.oop2projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseInformationBindingSource
            // 
            this.courseInformationBindingSource.DataMember = "CourseInformation";
            this.courseInformationBindingSource.DataSource = this.oop2projectDataSet;
            // 
            // courseInformationTableAdapter
            // 
            this.courseInformationTableAdapter.ClearBeforeFill = true;
            // 
            // courseInformationBindingSource1
            // 
            this.courseInformationBindingSource1.DataMember = "CourseInformation";
            this.courseInformationBindingSource1.DataSource = this.oop2projectDataSet;
            // 
            // oop2projectDataSet1
            // 
            this.oop2projectDataSet1.DataSetName = "oop2projectDataSet1";
            this.oop2projectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseInformationBindingSource2
            // 
            this.courseInformationBindingSource2.DataMember = "CourseInformation";
            this.courseInformationBindingSource2.DataSource = this.oop2projectDataSet1;
            // 
            // courseInformationTableAdapter1
            // 
            this.courseInformationTableAdapter1.ClearBeforeFill = true;
            // 
            // oop2projectDataSet2
            // 
            this.oop2projectDataSet2.DataSetName = "oop2projectDataSet2";
            this.oop2projectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseInformationBindingSource3
            // 
            this.courseInformationBindingSource3.DataMember = "CourseInformation";
            this.courseInformationBindingSource3.DataSource = this.oop2projectDataSet2;
            // 
            // courseInformationTableAdapter2
            // 
            this.courseInformationTableAdapter2.ClearBeforeFill = true;
            // 
            // courseInformationTableAdapter3
            // 
            this.courseInformationTableAdapter3.ClearBeforeFill = true;
            // 
            // oop2projectDataSet4
            // 
            this.oop2projectDataSet4.DataSetName = "oop2projectDataSet4";
            this.oop2projectDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseInformationBindingSource5
            // 
            this.courseInformationBindingSource5.DataMember = "CourseInformation";
            this.courseInformationBindingSource5.DataSource = this.oop2projectDataSet4;
            // 
            // courseInformationTableAdapter4
            // 
            this.courseInformationTableAdapter4.ClearBeforeFill = true;
            // 
            // oop2projectDataSet5
            // 
            this.oop2projectDataSet5.DataSetName = "oop2projectDataSet5";
            this.oop2projectDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseInformationBindingSource6
            // 
            this.courseInformationBindingSource6.DataMember = "CourseInformation";
            this.courseInformationBindingSource6.DataSource = this.oop2projectDataSet5;
            // 
            // courseInformationTableAdapter5
            // 
            this.courseInformationTableAdapter5.ClearBeforeFill = true;
            // 
            // courseInformationTableAdapter6
            // 
            this.courseInformationTableAdapter6.ClearBeforeFill = true;
            // 
            // SEARCH
            // 
            this.SEARCH.Location = new System.Drawing.Point(325, 182);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(125, 23);
            this.SEARCH.TabIndex = 20;
            this.SEARCH.Text = "SEARCH TERM";
            this.SEARCH.UseVisualStyleBackColor = true;
            // 
            // searchterm
            // 
            this.searchterm.Location = new System.Drawing.Point(456, 185);
            this.searchterm.Name = "searchterm";
            this.searchterm.Size = new System.Drawing.Size(35, 20);
            this.searchterm.TabIndex = 21;
            this.searchterm.TextChanged += new System.EventHandler(this.searchtext_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "SEARCH NAME";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // searchname
            // 
            this.searchname.Location = new System.Drawing.Point(456, 156);
            this.searchname.Name = "searchname";
            this.searchname.Size = new System.Drawing.Size(119, 20);
            this.searchname.TabIndex = 23;
            this.searchname.TextChanged += new System.EventHandler(this.searchgrade_TextChanged);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CourseInformationTableAdapter = this.courseInformationTableAdapter3;
            this.tableAdapterManager1.UpdateOrder = NoteSystem.oop2projectDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 426);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lettergrade);
            this.tabPage1.Controls.Add(this.lettergradebutton);
            this.tabPage1.Controls.Add(this.searchterm);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.SEARCH);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.searchname);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Instructions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lettergrade
            // 
            this.lettergrade.Location = new System.Drawing.Point(456, 68);
            this.lettergrade.Name = "lettergrade";
            this.lettergrade.Size = new System.Drawing.Size(35, 20);
            this.lettergrade.TabIndex = 25;
            // 
            // lettergradebutton
            // 
            this.lettergradebutton.Location = new System.Drawing.Point(325, 66);
            this.lettergradebutton.Name = "lettergradebutton";
            this.lettergradebutton.Size = new System.Drawing.Size(125, 23);
            this.lettergradebutton.TabIndex = 24;
            this.lettergradebutton.Text = "LETTER GRADE";
            this.lettergradebutton.UseVisualStyleBackColor = true;
            this.lettergradebutton.Click += new System.EventHandler(this.lettergradebutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.view);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Location = new System.Drawing.Point(599, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 229);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instructions";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(16, 190);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 13;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(16, 19);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 8;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(16, 106);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 12;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(16, 135);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 23);
            this.view.TabIndex = 7;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.View_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(16, 48);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 9;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(16, 77);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 10;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtu2);
            this.tabPage2.Controls.Add(this.txtu3);
            this.tabPage2.Controls.Add(this.txtu4);
            this.tabPage2.Controls.Add(this.txtu5);
            this.tabPage2.Controls.Add(this.txtu6);
            this.tabPage2.Controls.Add(this.txtu7);
            this.tabPage2.Controls.Add(this.txtu8);
            this.tabPage2.Controls.Add(this.txtu1);
            this.tabPage2.Controls.Add(this.txts8);
            this.tabPage2.Controls.Add(this.txts7);
            this.tabPage2.Controls.Add(this.txts6);
            this.tabPage2.Controls.Add(this.txts5);
            this.tabPage2.Controls.Add(this.txts4);
            this.tabPage2.Controls.Add(this.txts3);
            this.tabPage2.Controls.Add(this.txts2);
            this.tabPage2.Controls.Add(this.txts1);
            this.tabPage2.Controls.Add(this.txtc2);
            this.tabPage2.Controls.Add(this.txtc3);
            this.tabPage2.Controls.Add(this.txtc4);
            this.tabPage2.Controls.Add(this.txtc5);
            this.tabPage2.Controls.Add(this.txtc6);
            this.tabPage2.Controls.Add(this.txtc7);
            this.tabPage2.Controls.Add(this.txtc8);
            this.tabPage2.Controls.Add(this.txtc1);
            this.tabPage2.Controls.Add(this.Calculator);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(771, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calculators";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(418, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "POINTS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "LETTER GRADES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "GRADE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "ECTS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "COURSE NAME";
            // 
            // txtu2
            // 
            this.txtu2.Location = new System.Drawing.Point(123, 54);
            this.txtu2.Name = "txtu2";
            this.txtu2.Size = new System.Drawing.Size(46, 20);
            this.txtu2.TabIndex = 52;
            // 
            // txtu3
            // 
            this.txtu3.Location = new System.Drawing.Point(123, 80);
            this.txtu3.Name = "txtu3";
            this.txtu3.Size = new System.Drawing.Size(46, 20);
            this.txtu3.TabIndex = 51;
            // 
            // txtu4
            // 
            this.txtu4.Location = new System.Drawing.Point(123, 110);
            this.txtu4.Name = "txtu4";
            this.txtu4.Size = new System.Drawing.Size(46, 20);
            this.txtu4.TabIndex = 50;
            // 
            // txtu5
            // 
            this.txtu5.Location = new System.Drawing.Point(123, 136);
            this.txtu5.Name = "txtu5";
            this.txtu5.Size = new System.Drawing.Size(46, 20);
            this.txtu5.TabIndex = 49;
            // 
            // txtu6
            // 
            this.txtu6.Location = new System.Drawing.Point(123, 162);
            this.txtu6.Name = "txtu6";
            this.txtu6.Size = new System.Drawing.Size(46, 20);
            this.txtu6.TabIndex = 48;
            // 
            // txtu7
            // 
            this.txtu7.Location = new System.Drawing.Point(123, 188);
            this.txtu7.Name = "txtu7";
            this.txtu7.Size = new System.Drawing.Size(46, 20);
            this.txtu7.TabIndex = 47;
            // 
            // txtu8
            // 
            this.txtu8.Location = new System.Drawing.Point(123, 222);
            this.txtu8.Name = "txtu8";
            this.txtu8.Size = new System.Drawing.Size(46, 20);
            this.txtu8.TabIndex = 46;
            // 
            // txtu1
            // 
            this.txtu1.Location = new System.Drawing.Point(123, 28);
            this.txtu1.Name = "txtu1";
            this.txtu1.Size = new System.Drawing.Size(46, 20);
            this.txtu1.TabIndex = 44;
            // 
            // txts8
            // 
            this.txts8.Location = new System.Drawing.Point(179, 223);
            this.txts8.Name = "txts8";
            this.txts8.Size = new System.Drawing.Size(100, 20);
            this.txts8.TabIndex = 36;
            // 
            // txts7
            // 
            this.txts7.Location = new System.Drawing.Point(179, 191);
            this.txts7.Name = "txts7";
            this.txts7.Size = new System.Drawing.Size(100, 20);
            this.txts7.TabIndex = 35;
            // 
            // txts6
            // 
            this.txts6.Location = new System.Drawing.Point(179, 163);
            this.txts6.Name = "txts6";
            this.txts6.Size = new System.Drawing.Size(100, 20);
            this.txts6.TabIndex = 34;
            // 
            // txts5
            // 
            this.txts5.Location = new System.Drawing.Point(179, 137);
            this.txts5.Name = "txts5";
            this.txts5.Size = new System.Drawing.Size(100, 20);
            this.txts5.TabIndex = 33;
            // 
            // txts4
            // 
            this.txts4.Location = new System.Drawing.Point(179, 111);
            this.txts4.Name = "txts4";
            this.txts4.Size = new System.Drawing.Size(100, 20);
            this.txts4.TabIndex = 32;
            // 
            // txts3
            // 
            this.txts3.Location = new System.Drawing.Point(179, 81);
            this.txts3.Name = "txts3";
            this.txts3.Size = new System.Drawing.Size(100, 20);
            this.txts3.TabIndex = 31;
            // 
            // txts2
            // 
            this.txts2.Location = new System.Drawing.Point(179, 55);
            this.txts2.Name = "txts2";
            this.txts2.Size = new System.Drawing.Size(100, 20);
            this.txts2.TabIndex = 30;
            // 
            // txts1
            // 
            this.txts1.Location = new System.Drawing.Point(179, 29);
            this.txts1.Name = "txts1";
            this.txts1.Size = new System.Drawing.Size(100, 20);
            this.txts1.TabIndex = 29;
            // 
            // txtc2
            // 
            this.txtc2.Location = new System.Drawing.Point(6, 54);
            this.txtc2.Name = "txtc2";
            this.txtc2.Size = new System.Drawing.Size(111, 20);
            this.txtc2.TabIndex = 28;
            // 
            // txtc3
            // 
            this.txtc3.Location = new System.Drawing.Point(6, 80);
            this.txtc3.Name = "txtc3";
            this.txtc3.Size = new System.Drawing.Size(111, 20);
            this.txtc3.TabIndex = 27;
            // 
            // txtc4
            // 
            this.txtc4.Location = new System.Drawing.Point(6, 110);
            this.txtc4.Name = "txtc4";
            this.txtc4.Size = new System.Drawing.Size(111, 20);
            this.txtc4.TabIndex = 26;
            // 
            // txtc5
            // 
            this.txtc5.Location = new System.Drawing.Point(6, 136);
            this.txtc5.Name = "txtc5";
            this.txtc5.Size = new System.Drawing.Size(111, 20);
            this.txtc5.TabIndex = 25;
            // 
            // txtc6
            // 
            this.txtc6.Location = new System.Drawing.Point(6, 162);
            this.txtc6.Name = "txtc6";
            this.txtc6.Size = new System.Drawing.Size(111, 20);
            this.txtc6.TabIndex = 24;
            // 
            // txtc7
            // 
            this.txtc7.Location = new System.Drawing.Point(6, 188);
            this.txtc7.Name = "txtc7";
            this.txtc7.Size = new System.Drawing.Size(111, 20);
            this.txtc7.TabIndex = 23;
            // 
            // txtc8
            // 
            this.txtc8.Location = new System.Drawing.Point(6, 222);
            this.txtc8.Name = "txtc8";
            this.txtc8.Size = new System.Drawing.Size(111, 20);
            this.txtc8.TabIndex = 22;
            // 
            // txtc1
            // 
            this.txtc1.Location = new System.Drawing.Point(6, 28);
            this.txtc1.Name = "txtc1";
            this.txtc1.Size = new System.Drawing.Size(111, 20);
            this.txtc1.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lgpa);
            this.groupBox4.Controls.Add(this.CGPA);
            this.groupBox4.Location = new System.Drawing.Point(501, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 112);
            this.groupBox4.TabIndex = 72;
            this.groupBox4.TabStop = false;
            // 
            // lgpa
            // 
            this.lgpa.AutoSize = true;
            this.lgpa.Location = new System.Drawing.Point(62, 64);
            this.lgpa.Name = "lgpa";
            this.lgpa.Size = new System.Drawing.Size(0, 13);
            this.lgpa.TabIndex = 70;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.lp1);
            this.groupBox6.Controls.Add(this.lp7);
            this.groupBox6.Controls.Add(this.lp6);
            this.groupBox6.Controls.Add(this.lp2);
            this.groupBox6.Controls.Add(this.lp8);
            this.groupBox6.Controls.Add(this.lp3);
            this.groupBox6.Controls.Add(this.lp4);
            this.groupBox6.Controls.Add(this.lp5);
            this.groupBox6.Location = new System.Drawing.Point(411, 28);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(67, 217);
            this.groupBox6.TabIndex = 74;
            this.groupBox6.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 70;
            // 
            // lp1
            // 
            this.lp1.AutoSize = true;
            this.lp1.Location = new System.Drawing.Point(13, 8);
            this.lp1.Name = "lp1";
            this.lp1.Size = new System.Drawing.Size(0, 13);
            this.lp1.TabIndex = 69;
            // 
            // lp7
            // 
            this.lp7.AutoSize = true;
            this.lp7.Location = new System.Drawing.Point(13, 170);
            this.lp7.Name = "lp7";
            this.lp7.Size = new System.Drawing.Size(0, 13);
            this.lp7.TabIndex = 62;
            // 
            // lp6
            // 
            this.lp6.AutoSize = true;
            this.lp6.Location = new System.Drawing.Point(13, 142);
            this.lp6.Name = "lp6";
            this.lp6.Size = new System.Drawing.Size(0, 13);
            this.lp6.TabIndex = 63;
            // 
            // lp2
            // 
            this.lp2.AutoSize = true;
            this.lp2.Location = new System.Drawing.Point(13, 32);
            this.lp2.Name = "lp2";
            this.lp2.Size = new System.Drawing.Size(0, 13);
            this.lp2.TabIndex = 68;
            // 
            // lp8
            // 
            this.lp8.AutoSize = true;
            this.lp8.Location = new System.Drawing.Point(13, 195);
            this.lp8.Name = "lp8";
            this.lp8.Size = new System.Drawing.Size(0, 13);
            this.lp8.TabIndex = 64;
            // 
            // lp3
            // 
            this.lp3.AutoSize = true;
            this.lp3.Location = new System.Drawing.Point(13, 60);
            this.lp3.Name = "lp3";
            this.lp3.Size = new System.Drawing.Size(0, 13);
            this.lp3.TabIndex = 67;
            // 
            // lp4
            // 
            this.lp4.AutoSize = true;
            this.lp4.Location = new System.Drawing.Point(13, 90);
            this.lp4.Name = "lp4";
            this.lp4.Size = new System.Drawing.Size(0, 13);
            this.lp4.TabIndex = 65;
            // 
            // lp5
            // 
            this.lp5.AutoSize = true;
            this.lp5.Location = new System.Drawing.Point(13, 115);
            this.lp5.Name = "lp5";
            this.lp5.Size = new System.Drawing.Size(0, 13);
            this.lp5.TabIndex = 66;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.lg1);
            this.groupBox5.Controls.Add(this.lg2);
            this.groupBox5.Controls.Add(this.lg3);
            this.groupBox5.Controls.Add(this.lg8);
            this.groupBox5.Controls.Add(this.lg4);
            this.groupBox5.Controls.Add(this.lg7);
            this.groupBox5.Controls.Add(this.lg5);
            this.groupBox5.Controls.Add(this.lg6);
            this.groupBox5.Location = new System.Drawing.Point(285, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(120, 217);
            this.groupBox5.TabIndex = 73;
            this.groupBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 70;
            // 
            // lg1
            // 
            this.lg1.AutoSize = true;
            this.lg1.Location = new System.Drawing.Point(33, 8);
            this.lg1.Name = "lg1";
            this.lg1.Size = new System.Drawing.Size(0, 13);
            this.lg1.TabIndex = 53;
            // 
            // lg2
            // 
            this.lg2.AutoSize = true;
            this.lg2.Location = new System.Drawing.Point(27, 33);
            this.lg2.Name = "lg2";
            this.lg2.Size = new System.Drawing.Size(0, 13);
            this.lg2.TabIndex = 54;
            // 
            // lg3
            // 
            this.lg3.AutoSize = true;
            this.lg3.Location = new System.Drawing.Point(27, 59);
            this.lg3.Name = "lg3";
            this.lg3.Size = new System.Drawing.Size(0, 13);
            this.lg3.TabIndex = 55;
            // 
            // lg8
            // 
            this.lg8.AutoSize = true;
            this.lg8.Location = new System.Drawing.Point(27, 197);
            this.lg8.Name = "lg8";
            this.lg8.Size = new System.Drawing.Size(0, 13);
            this.lg8.TabIndex = 61;
            // 
            // lg4
            // 
            this.lg4.AutoSize = true;
            this.lg4.Location = new System.Drawing.Point(27, 89);
            this.lg4.Name = "lg4";
            this.lg4.Size = new System.Drawing.Size(0, 13);
            this.lg4.TabIndex = 56;
            // 
            // lg7
            // 
            this.lg7.AutoSize = true;
            this.lg7.Location = new System.Drawing.Point(27, 169);
            this.lg7.Name = "lg7";
            this.lg7.Size = new System.Drawing.Size(0, 13);
            this.lg7.TabIndex = 60;
            // 
            // lg5
            // 
            this.lg5.AutoSize = true;
            this.lg5.Location = new System.Drawing.Point(27, 115);
            this.lg5.Name = "lg5";
            this.lg5.Size = new System.Drawing.Size(0, 13);
            this.lg5.TabIndex = 58;
            // 
            // lg6
            // 
            this.lg6.AutoSize = true;
            this.lg6.Location = new System.Drawing.Point(27, 139);
            this.lg6.Name = "lg6";
            this.lg6.Size = new System.Drawing.Size(0, 13);
            this.lg6.TabIndex = 59;
            // 
            // courseInformationBindingSource8
            // 
            this.courseInformationBindingSource8.DataMember = "CourseInformation";
            this.courseInformationBindingSource8.DataSource = this.oop2projectDataSet7;
            // 
            // oop2projectDataSet7
            // 
            this.oop2projectDataSet7.DataSetName = "oop2projectDataSet7";
            this.oop2projectDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseInformationTableAdapter7
            // 
            this.courseInformationTableAdapter7.ClearBeforeFill = true;
            // 
            // oop2projectDataSet8
            // 
            this.oop2projectDataSet8.DataSetName = "oop2projectDataSet8";
            this.oop2projectDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseInformationBindingSource9
            // 
            this.courseInformationBindingSource9.DataMember = "CourseInformation";
            this.courseInformationBindingSource9.DataSource = this.oop2projectDataSet8;
            // 
            // courseInformationTableAdapter8
            // 
            this.courseInformationTableAdapter8.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Course Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Calculator.ResumeLayout(false);
            this.Calculator.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource6)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oop2projectDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInformationBindingSource9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox coursename;
        private System.Windows.Forms.TextBox coursegrade;
        private System.Windows.Forms.Button gpabutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Calculator;
        private System.Windows.Forms.Label CGPA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private oop2projectDataSet oop2projectDataSet;
        private System.Windows.Forms.BindingSource courseInformationBindingSource;
        private oop2projectDataSetTableAdapters.CourseInformationTableAdapter courseInformationTableAdapter;
        private System.Windows.Forms.BindingSource courseInformationBindingSource1;
        private oop2projectDataSet1 oop2projectDataSet1;
        private System.Windows.Forms.BindingSource courseInformationBindingSource2;
        private oop2projectDataSet1TableAdapters.CourseInformationTableAdapter courseInformationTableAdapter1;
        private oop2projectDataSet2 oop2projectDataSet2;
        private System.Windows.Forms.BindingSource courseInformationBindingSource3;
        private oop2projectDataSet2TableAdapters.CourseInformationTableAdapter courseInformationTableAdapter2;
        private oop2projectDataSet3 oop2projectDataSet3;
        private System.Windows.Forms.BindingSource courseInformationBindingSource4;
        private oop2projectDataSet3TableAdapters.CourseInformationTableAdapter courseInformationTableAdapter3;
        private System.Windows.Forms.TextBox ectscredits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox terminformation;
        private System.Windows.Forms.TextBox coursecode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private oop2projectDataSet4 oop2projectDataSet4;
        private System.Windows.Forms.BindingSource courseInformationBindingSource5;
        private oop2projectDataSet4TableAdapters.CourseInformationTableAdapter courseInformationTableAdapter4;
        private oop2projectDataSet5 oop2projectDataSet5;
        private System.Windows.Forms.BindingSource courseInformationBindingSource6;
        private oop2projectDataSet5TableAdapters.CourseInformationTableAdapter courseInformationTableAdapter5;
        private oop2projectDataSet6 oop2projectDataSet6;
        private System.Windows.Forms.BindingSource courseInformationBindingSource7;
        private oop2projectDataSet6TableAdapters.CourseInformationTableAdapter courseInformationTableAdapter6;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eCTSCreditsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn letterGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SEARCH;
        private System.Windows.Forms.TextBox searchterm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchname;
        private oop2projectDataSet3TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button allclear;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button save;
        private oop2projectDataSet7 oop2projectDataSet7;
        private System.Windows.Forms.BindingSource courseInformationBindingSource8;
        private oop2projectDataSet7TableAdapters.CourseInformationTableAdapter courseInformationTableAdapter7;
        private oop2projectDataSet8 oop2projectDataSet8;
        private System.Windows.Forms.BindingSource courseInformationBindingSource9;
        private oop2projectDataSet8TableAdapters.CourseInformationTableAdapter courseInformationTableAdapter8;
        private System.Windows.Forms.Label lp1;
        private System.Windows.Forms.Label lp2;
        private System.Windows.Forms.Label lp3;
        private System.Windows.Forms.Label lp5;
        private System.Windows.Forms.Label lp4;
        private System.Windows.Forms.Label lp8;
        private System.Windows.Forms.Label lp6;
        private System.Windows.Forms.Label lp7;
        private System.Windows.Forms.Label lg8;
        private System.Windows.Forms.Label lg7;
        private System.Windows.Forms.Label lg6;
        private System.Windows.Forms.Label lg5;
        private System.Windows.Forms.Label lg4;
        private System.Windows.Forms.Label lg3;
        private System.Windows.Forms.Label lg2;
        private System.Windows.Forms.Label lg1;
        private System.Windows.Forms.TextBox txtu2;
        private System.Windows.Forms.TextBox txtu3;
        private System.Windows.Forms.TextBox txtu4;
        private System.Windows.Forms.TextBox txtu5;
        private System.Windows.Forms.TextBox txtu6;
        private System.Windows.Forms.TextBox txtu7;
        private System.Windows.Forms.TextBox txtu8;
        private System.Windows.Forms.TextBox txtu1;
        private System.Windows.Forms.TextBox txts8;
        private System.Windows.Forms.TextBox txts7;
        private System.Windows.Forms.TextBox txts6;
        private System.Windows.Forms.TextBox txts5;
        private System.Windows.Forms.TextBox txts4;
        private System.Windows.Forms.TextBox txts3;
        private System.Windows.Forms.TextBox txts2;
        private System.Windows.Forms.TextBox txts1;
        private System.Windows.Forms.TextBox txtc2;
        private System.Windows.Forms.TextBox txtc3;
        private System.Windows.Forms.TextBox txtc4;
        private System.Windows.Forms.TextBox txtc5;
        private System.Windows.Forms.TextBox txtc6;
        private System.Windows.Forms.TextBox txtc7;
        private System.Windows.Forms.TextBox txtc8;
        private System.Windows.Forms.TextBox txtc1;
        private System.Windows.Forms.Label logp;
        private System.Windows.Forms.Label lgpa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button lettergradebutton;
        private System.Windows.Forms.TextBox lettergrade;
    }
}

