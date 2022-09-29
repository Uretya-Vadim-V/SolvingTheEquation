namespace SolvingTheEquation
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.methodBisection = new System.Windows.Forms.RadioButton();
            this.methodNewton = new System.Windows.Forms.RadioButton();
            this.methodChord = new System.Windows.Forms.RadioButton();
            this.methods = new System.Windows.Forms.GroupBox();
            this.minimumX = new System.Windows.Forms.TextBox();
            this.maximumX = new System.Windows.Forms.TextBox();
            this.options = new System.Windows.Forms.GroupBox();
            this.eps = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.epsilon = new System.Windows.Forms.TextBox();
            this.step = new System.Windows.Forms.TextBox();
            this.build = new System.Windows.Forms.Button();
            this.solving = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.ComboBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.approximate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accurate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.methods.SuspendLayout();
            this.options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph.BorderlineColor = System.Drawing.Color.ForestGreen;
            this.graph.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.graph.BorderlineWidth = 10;
            this.graph.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.graph.BorderSkin.BorderColor = System.Drawing.Color.DarkOrange;
            this.graph.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.graph.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.DarkGreen;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BorderWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "NameFunction";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.Enabled = false;
            legend2.Name = "GraphRoot";
            this.graph.Legends.Add(legend1);
            this.graph.Legends.Add(legend2);
            this.graph.Location = new System.Drawing.Point(440, 12);
            this.graph.Name = "graph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "NameFunction";
            series1.LegendText = "Function";
            series1.Name = "Function";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "GraphRoot";
            series2.Name = "Series2";
            this.graph.Series.Add(series1);
            this.graph.Series.Add(series2);
            this.graph.Size = new System.Drawing.Size(730, 377);
            this.graph.TabIndex = 0;
            this.graph.Text = "chart1";
            // 
            // methodBisection
            // 
            this.methodBisection.AutoSize = true;
            this.methodBisection.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodBisection.ForeColor = System.Drawing.Color.White;
            this.methodBisection.Location = new System.Drawing.Point(32, 36);
            this.methodBisection.Name = "methodBisection";
            this.methodBisection.Size = new System.Drawing.Size(201, 30);
            this.methodBisection.TabIndex = 1;
            this.methodBisection.TabStop = true;
            this.methodBisection.Text = "Метод бисекции";
            this.methodBisection.UseVisualStyleBackColor = true;
            // 
            // methodNewton
            // 
            this.methodNewton.AutoSize = true;
            this.methodNewton.Checked = true;
            this.methodNewton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodNewton.ForeColor = System.Drawing.Color.White;
            this.methodNewton.Location = new System.Drawing.Point(32, 72);
            this.methodNewton.Name = "methodNewton";
            this.methodNewton.Size = new System.Drawing.Size(195, 30);
            this.methodNewton.TabIndex = 2;
            this.methodNewton.TabStop = true;
            this.methodNewton.Text = "Метод Ньютона\r\n";
            this.methodNewton.UseVisualStyleBackColor = true;
            // 
            // methodChord
            // 
            this.methodChord.AutoSize = true;
            this.methodChord.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodChord.ForeColor = System.Drawing.Color.White;
            this.methodChord.Location = new System.Drawing.Point(32, 108);
            this.methodChord.Name = "methodChord";
            this.methodChord.Size = new System.Drawing.Size(154, 30);
            this.methodChord.TabIndex = 3;
            this.methodChord.TabStop = true;
            this.methodChord.Text = "Метод хорд";
            this.methodChord.UseVisualStyleBackColor = true;
            // 
            // methods
            // 
            this.methods.Controls.Add(this.methodBisection);
            this.methods.Controls.Add(this.methodChord);
            this.methods.Controls.Add(this.methodNewton);
            this.methods.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methods.ForeColor = System.Drawing.Color.White;
            this.methods.Location = new System.Drawing.Point(12, 12);
            this.methods.Name = "methods";
            this.methods.Size = new System.Drawing.Size(420, 155);
            this.methods.TabIndex = 4;
            this.methods.TabStop = false;
            this.methods.Text = "Решить используя:";
            // 
            // minimumX
            // 
            this.minimumX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minimumX.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumX.ForeColor = System.Drawing.Color.Black;
            this.minimumX.Location = new System.Drawing.Point(49, 33);
            this.minimumX.Multiline = true;
            this.minimumX.Name = "minimumX";
            this.minimumX.Size = new System.Drawing.Size(355, 26);
            this.minimumX.TabIndex = 5;
            this.minimumX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minimumX_KeyPress);
            // 
            // maximumX
            // 
            this.maximumX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maximumX.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumX.ForeColor = System.Drawing.Color.Black;
            this.maximumX.Location = new System.Drawing.Point(49, 61);
            this.maximumX.Multiline = true;
            this.maximumX.Name = "maximumX";
            this.maximumX.Size = new System.Drawing.Size(355, 26);
            this.maximumX.TabIndex = 6;
            this.maximumX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maximumX_KeyPress);
            // 
            // options
            // 
            this.options.Controls.Add(this.eps);
            this.options.Controls.Add(this.h);
            this.options.Controls.Add(this.b);
            this.options.Controls.Add(this.label1);
            this.options.Controls.Add(this.epsilon);
            this.options.Controls.Add(this.step);
            this.options.Controls.Add(this.minimumX);
            this.options.Controls.Add(this.maximumX);
            this.options.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options.ForeColor = System.Drawing.Color.White;
            this.options.Location = new System.Drawing.Point(12, 173);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(422, 157);
            this.options.TabIndex = 7;
            this.options.TabStop = false;
            this.options.Text = "Параметры:";
            // 
            // eps
            // 
            this.eps.AutoSize = true;
            this.eps.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eps.Location = new System.Drawing.Point(20, 117);
            this.eps.Name = "eps";
            this.eps.Size = new System.Drawing.Size(23, 26);
            this.eps.TabIndex = 12;
            this.eps.Text = "E";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.Location = new System.Drawing.Point(20, 89);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(24, 26);
            this.h.TabIndex = 11;
            this.h.Text = "h";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.Location = new System.Drawing.Point(20, 61);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(24, 26);
            this.b.TabIndex = 10;
            this.b.Text = "b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "a";
            // 
            // epsilon
            // 
            this.epsilon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.epsilon.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epsilon.ForeColor = System.Drawing.Color.Black;
            this.epsilon.Location = new System.Drawing.Point(49, 117);
            this.epsilon.Multiline = true;
            this.epsilon.Name = "epsilon";
            this.epsilon.Size = new System.Drawing.Size(355, 26);
            this.epsilon.TabIndex = 8;
            this.epsilon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.epsilon_KeyPress);
            // 
            // step
            // 
            this.step.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.step.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step.ForeColor = System.Drawing.Color.Black;
            this.step.Location = new System.Drawing.Point(49, 89);
            this.step.Multiline = true;
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(355, 26);
            this.step.TabIndex = 7;
            this.step.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.step_KeyPress);
            // 
            // build
            // 
            this.build.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.build.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.build.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.build.ForeColor = System.Drawing.Color.White;
            this.build.Location = new System.Drawing.Point(12, 336);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(200, 53);
            this.build.TabIndex = 9;
            this.build.Text = "Построить";
            this.build.UseVisualStyleBackColor = false;
            this.build.Click += new System.EventHandler(this.build_Click);
            // 
            // solving
            // 
            this.solving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.solving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solving.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solving.ForeColor = System.Drawing.Color.White;
            this.solving.Location = new System.Drawing.Point(234, 336);
            this.solving.Name = "solving";
            this.solving.Size = new System.Drawing.Size(200, 53);
            this.solving.TabIndex = 10;
            this.solving.Text = "Решить";
            this.solving.UseVisualStyleBackColor = false;
            this.solving.Click += new System.EventHandler(this.solving_Click);
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.number.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.FormattingEnabled = true;
            this.number.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.number.Location = new System.Drawing.Point(667, 341);
            this.number.MaxDropDownItems = 13;
            this.number.MaxLength = 2;
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(65, 30);
            this.number.TabIndex = 11;
            this.number.Text = "1";
            this.number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            this.data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data.BackgroundColor = System.Drawing.Color.White;
            this.data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.approximate,
            this.accurate,
            this.Check,
            this.countN});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle2;
            this.data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.data.Location = new System.Drawing.Point(12, 395);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data.RowHeadersVisible = false;
            this.data.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.data.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.data.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(1158, 146);
            this.data.StandardTab = true;
            this.data.TabIndex = 12;
            // 
            // approximate
            // 
            this.approximate.DividerWidth = 5;
            this.approximate.HeaderText = "Уточняемый";
            this.approximate.MinimumWidth = 6;
            this.approximate.Name = "approximate";
            this.approximate.ReadOnly = true;
            this.approximate.Width = 250;
            // 
            // accurate
            // 
            this.accurate.DividerWidth = 5;
            this.accurate.HeaderText = "Уточнённый";
            this.accurate.MinimumWidth = 6;
            this.accurate.Name = "accurate";
            this.accurate.ReadOnly = true;
            this.accurate.Width = 250;
            // 
            // Check
            // 
            this.Check.DividerWidth = 5;
            this.Check.HeaderText = "f(уточнённый)";
            this.Check.MinimumWidth = 6;
            this.Check.Name = "Check";
            this.Check.ReadOnly = true;
            this.Check.Width = 250;
            // 
            // countN
            // 
            this.countN.HeaderText = "Количество итераций";
            this.countN.MinimumWidth = 6;
            this.countN.Name = "countN";
            this.countN.ReadOnly = true;
            this.countN.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.data);
            this.Controls.Add(this.number);
            this.Controls.Add(this.solving);
            this.Controls.Add(this.build);
            this.Controls.Add(this.options);
            this.Controls.Add(this.methods);
            this.Controls.Add(this.graph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Построение и решение уравнений";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.methods.ResumeLayout(false);
            this.methods.PerformLayout();
            this.options.ResumeLayout(false);
            this.options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.RadioButton methodBisection;
        private System.Windows.Forms.RadioButton methodNewton;
        private System.Windows.Forms.RadioButton methodChord;
        private System.Windows.Forms.GroupBox methods;
        private System.Windows.Forms.TextBox minimumX;
        private System.Windows.Forms.TextBox maximumX;
        private System.Windows.Forms.GroupBox options;
        private System.Windows.Forms.Label eps;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox epsilon;
        private System.Windows.Forms.TextBox step;
        private System.Windows.Forms.Button build;
        private System.Windows.Forms.Button solving;
        private System.Windows.Forms.ComboBox number;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DataGridViewTextBoxColumn approximate;
        private System.Windows.Forms.DataGridViewTextBoxColumn accurate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn countN;
    }
}

