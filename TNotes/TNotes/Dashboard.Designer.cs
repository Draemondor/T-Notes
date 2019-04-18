namespace WindowsFormsApp1
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.TextBox();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnSemester = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.btnLabs = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.yearIcon = new System.Windows.Forms.PictureBox();
            this.CoursesIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.projectsIcon = new System.Windows.Forms.PictureBox();
            this.labsIcon = new System.Windows.Forms.PictureBox();
            this.professorIcon = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label_Tnotes = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.Headder = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.CreateYourNote = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Home.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.Home.Location = new System.Drawing.Point(75, 112);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(115, 25);
            this.Home.TabIndex = 2;
            this.Home.Text = "Dashboard";
            this.Home.TextChanged += new System.EventHandler(this.Home_TextChanged);
            // 
            // btnYear
            // 
            this.btnYear.AutoSize = true;
            this.btnYear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(142)))), ((int)(((byte)(30)))));
            this.btnYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btnYear.Location = new System.Drawing.Point(-1, 237);
            this.btnYear.Name = "btnYear";
            this.btnYear.Padding = new System.Windows.Forms.Padding(0, 0, 42, 0);
            this.btnYear.Size = new System.Drawing.Size(246, 75);
            this.btnYear.TabIndex = 14;
            this.btnYear.Text = "Year";
            this.btnYear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYear.UseVisualStyleBackColor = true;
            // 
            // btnSemester
            // 
            this.btnSemester.AutoSize = true;
            this.btnSemester.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnSemester.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(142)))), ((int)(((byte)(30)))));
            this.btnSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btnSemester.Location = new System.Drawing.Point(-1, 311);
            this.btnSemester.Name = "btnSemester";
            this.btnSemester.Size = new System.Drawing.Size(246, 75);
            this.btnSemester.TabIndex = 15;
            this.btnSemester.Text = "Semester";
            this.btnSemester.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSemester.UseVisualStyleBackColor = true;
            // 
            // btnCourses
            // 
            this.btnCourses.AutoSize = true;
            this.btnCourses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnCourses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(142)))), ((int)(((byte)(30)))));
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btnCourses.Location = new System.Drawing.Point(-1, 163);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.btnCourses.Size = new System.Drawing.Size(246, 75);
            this.btnCourses.TabIndex = 16;
            this.btnCourses.Text = "Courses";
            this.btnCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCourses.UseVisualStyleBackColor = true;
            // 
            // btnProfessor
            // 
            this.btnProfessor.AutoSize = true;
            this.btnProfessor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnProfessor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(142)))), ((int)(((byte)(30)))));
            this.btnProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btnProfessor.Location = new System.Drawing.Point(-1, 385);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnProfessor.Size = new System.Drawing.Size(246, 75);
            this.btnProfessor.TabIndex = 17;
            this.btnProfessor.Text = "Professor";
            this.btnProfessor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfessor.UseVisualStyleBackColor = true;
            // 
            // btnLabs
            // 
            this.btnLabs.AutoSize = true;
            this.btnLabs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnLabs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(142)))), ((int)(((byte)(30)))));
            this.btnLabs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLabs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btnLabs.Location = new System.Drawing.Point(-1, 459);
            this.btnLabs.Name = "btnLabs";
            this.btnLabs.Padding = new System.Windows.Forms.Padding(0, 0, 48, 0);
            this.btnLabs.Size = new System.Drawing.Size(246, 75);
            this.btnLabs.TabIndex = 18;
            this.btnLabs.Text = "Labs";
            this.btnLabs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLabs.UseVisualStyleBackColor = true;
            // 
            // btnProjects
            // 
            this.btnProjects.AutoSize = true;
            this.btnProjects.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnProjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(142)))), ((int)(((byte)(30)))));
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btnProjects.Location = new System.Drawing.Point(-1, 533);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Padding = new System.Windows.Forms.Padding(0, 0, 17, 0);
            this.btnProjects.Size = new System.Drawing.Size(246, 75);
            this.btnProjects.TabIndex = 19;
            this.btnProjects.Text = "Projects";
            this.btnProjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjects.UseVisualStyleBackColor = true;
            // 
            // yearIcon
            // 
            this.yearIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yearIcon.BackgroundImage")));
            this.yearIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.yearIcon.Location = new System.Drawing.Point(32, 257);
            this.yearIcon.Name = "yearIcon";
            this.yearIcon.Size = new System.Drawing.Size(32, 32);
            this.yearIcon.TabIndex = 22;
            this.yearIcon.TabStop = false;
            // 
            // CoursesIcon
            // 
            this.CoursesIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CoursesIcon.BackgroundImage")));
            this.CoursesIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CoursesIcon.Location = new System.Drawing.Point(32, 183);
            this.CoursesIcon.Name = "CoursesIcon";
            this.CoursesIcon.Size = new System.Drawing.Size(32, 32);
            this.CoursesIcon.TabIndex = 21;
            this.CoursesIcon.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(32, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // projectsIcon
            // 
            this.projectsIcon.Image = ((System.Drawing.Image)(resources.GetObject("projectsIcon.Image")));
            this.projectsIcon.Location = new System.Drawing.Point(32, 554);
            this.projectsIcon.Name = "projectsIcon";
            this.projectsIcon.Size = new System.Drawing.Size(32, 32);
            this.projectsIcon.TabIndex = 25;
            this.projectsIcon.TabStop = false;
            // 
            // labsIcon
            // 
            this.labsIcon.Image = ((System.Drawing.Image)(resources.GetObject("labsIcon.Image")));
            this.labsIcon.Location = new System.Drawing.Point(35, 476);
            this.labsIcon.Name = "labsIcon";
            this.labsIcon.Size = new System.Drawing.Size(32, 32);
            this.labsIcon.TabIndex = 26;
            this.labsIcon.TabStop = false;
            // 
            // professorIcon
            // 
            this.professorIcon.Image = ((System.Drawing.Image)(resources.GetObject("professorIcon.Image")));
            this.professorIcon.Location = new System.Drawing.Point(35, 406);
            this.professorIcon.Name = "professorIcon";
            this.professorIcon.Size = new System.Drawing.Size(32, 32);
            this.professorIcon.TabIndex = 28;
            this.professorIcon.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(1, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(85, 84);
            this.Logo.TabIndex = 29;
            this.Logo.TabStop = false;
            // 
            // label_Tnotes
            // 
            this.label_Tnotes.AutoSize = true;
            this.label_Tnotes.BackColor = System.Drawing.Color.Transparent;
            this.label_Tnotes.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tnotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.label_Tnotes.Location = new System.Drawing.Point(92, 30);
            this.label_Tnotes.Name = "label_Tnotes";
            this.label_Tnotes.Size = new System.Drawing.Size(120, 37);
            this.label_Tnotes.TabIndex = 30;
            this.label_Tnotes.Text = "T-Notes";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.pictureBox3.Location = new System.Drawing.Point(245, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(911, 90);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(900, 30);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(173)))), ((int)(((byte)(223)))));
            this.txtLastName.Location = new System.Drawing.Point(932, 30);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(212, 23);
            this.txtLastName.TabIndex = 34;
            this.txtLastName.Text = "Search";
            // 
            // Headder
            // 
            this.Headder.AutoSize = true;
            this.Headder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Headder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headder.ForeColor = System.Drawing.Color.White;
            this.Headder.Location = new System.Drawing.Point(258, 34);
            this.Headder.Name = "Headder";
            this.Headder.Size = new System.Drawing.Size(252, 20);
            this.Headder.TabIndex = 35;
            this.Headder.Text = "Note-taking application that works.";
            // 
            // btnAddNew
            // 
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(142)))), ((int)(((byte)(30)))));
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.btnAddNew.Location = new System.Drawing.Point(262, 135);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(145, 29);
            this.btnAddNew.TabIndex = 36;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnCreateAnAccount_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(35, 331);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 391);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(142)))), ((int)(((byte)(30)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.buttonUpdate.Location = new System.Drawing.Point(413, 135);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(145, 29);
            this.buttonUpdate.TabIndex = 39;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(142)))), ((int)(((byte)(30)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.buttonDelete.Location = new System.Drawing.Point(564, 135);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(145, 29);
            this.buttonDelete.TabIndex = 40;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(142)))), ((int)(((byte)(30)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.buttonSave.Location = new System.Drawing.Point(999, 567);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(145, 29);
            this.buttonSave.TabIndex = 41;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.AutoSize = true;
            this.buttonModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(142)))), ((int)(((byte)(30)))));
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.buttonModify.Location = new System.Drawing.Point(848, 567);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(145, 29);
            this.buttonModify.TabIndex = 42;
            this.buttonModify.Text = "Modify";
            this.buttonModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonModify.UseVisualStyleBackColor = true;
            // 
            // CreateYourNote
            // 
            this.CreateYourNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreateYourNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateYourNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.CreateYourNote.Location = new System.Drawing.Point(734, 138);
            this.CreateYourNote.Name = "CreateYourNote";
            this.CreateYourNote.Size = new System.Drawing.Size(410, 25);
            this.CreateYourNote.TabIndex = 47;
            this.CreateYourNote.Text = "Create Your Notes";
            this.CreateYourNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(734, 170);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(410, 391);
            this.richTextBox1.TabIndex = 46;
            this.richTextBox1.Text = "";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(262, 567);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 30);
            this.pictureBox6.TabIndex = 48;
            this.pictureBox6.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1156, 608);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.CreateYourNote);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.Headder);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label_Tnotes);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.professorIcon);
            this.Controls.Add(this.labsIcon);
            this.Controls.Add(this.projectsIcon);
            this.Controls.Add(this.yearIcon);
            this.Controls.Add(this.CoursesIcon);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnProjects);
            this.Controls.Add(this.btnLabs);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnSemester);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T-Notes | Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Home;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnSemester;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Button btnLabs;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.PictureBox yearIcon;
        private System.Windows.Forms.PictureBox CoursesIcon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox projectsIcon;
        private System.Windows.Forms.PictureBox labsIcon;
        private System.Windows.Forms.PictureBox professorIcon;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label_Tnotes;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label Headder;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.TextBox CreateYourNote;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}