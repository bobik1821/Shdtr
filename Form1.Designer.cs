
namespace ShaDeter
{
    partial class F_MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.load = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.Create = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.open_draw_window = new System.Windows.Forms.ToolStripMenuItem();
            this.close_open_window = new System.Windows.Forms.ToolStripMenuItem();
            this.Инструмент = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tool = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.brash = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.p_Color = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.Инструмент.SuspendLayout();
            this.panel1.SuspendLayout();
            this.brash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.View});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.load,
            this.save,
            this.Create});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(48, 20);
            this.File.Text = "файл";
            // 
            // load
            // 
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(154, 22);
            this.load.Text = "загрузить";
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // save
            // 
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(154, 22);
            this.save.Text = "сохранить как";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Create
            // 
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(154, 22);
            this.Create.Text = "создать новый";
            this.Create.Click += new System.EventHandler(this.create_new_Click);
            // 
            // View
            // 
            this.View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_draw_window,
            this.close_open_window});
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(38, 20);
            this.View.Text = "вид";
            // 
            // open_draw_window
            // 
            this.open_draw_window.Name = "open_draw_window";
            this.open_draw_window.Size = new System.Drawing.Size(211, 22);
            this.open_draw_window.Text = "открыть окно рисования";
            this.open_draw_window.Click += new System.EventHandler(this.open_draw_window_Click);
            // 
            // close_open_window
            // 
            this.close_open_window.Name = "close_open_window";
            this.close_open_window.Size = new System.Drawing.Size(211, 22);
            this.close_open_window.Text = "закрыть окно рисования";
            this.close_open_window.Click += new System.EventHandler(this.close_open_window_Click);
            // 
            // Инструмент
            // 
            this.Инструмент.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.tool});
            this.Инструмент.Location = new System.Drawing.Point(0, 428);
            this.Инструмент.Name = "Инструмент";
            this.Инструмент.Size = new System.Drawing.Size(893, 22);
            this.Инструмент.TabIndex = 1;
            this.Инструмент.Text = "statusStrip1";
            this.Инструмент.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // tool
            // 
            this.tool.Name = "tool";
            this.tool.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tool.Size = new System.Drawing.Size(72, 17);
            this.tool.Text = "инструмент";
            this.tool.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.brash);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 404);
            this.panel1.TabIndex = 2;
            // 
            // brash
            // 
            this.brash.Controls.Add(this.numericUpDown1);
            this.brash.Controls.Add(this.p_Color);
            this.brash.Controls.Add(this.label2);
            this.brash.Controls.Add(this.label1);
            this.brash.Location = new System.Drawing.Point(0, 22);
            this.brash.Name = "brash";
            this.brash.Size = new System.Drawing.Size(133, 137);
            this.brash.TabIndex = 0;
            this.brash.TabStop = false;
            this.brash.Text = "Кисть";
            this.brash.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(8, 102);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // p_Color
            // 
            this.p_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p_Color.Location = new System.Drawing.Point(3, 32);
            this.p_Color.Name = "p_Color";
            this.p_Color.Size = new System.Drawing.Size(69, 31);
            this.p_Color.TabIndex = 2;
            this.p_Color.Click += new System.EventHandler(this.p_Color_Click);
            this.p_Color.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цвет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Радиус";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // F_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Инструмент);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Инструмент.ResumeLayout(false);
            this.Инструмент.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.brash.ResumeLayout(false);
            this.brash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem load;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem Create;
        private System.Windows.Forms.ToolStripMenuItem View;
        private System.Windows.Forms.ToolStripMenuItem open_draw_window;
        private System.Windows.Forms.ToolStripMenuItem close_open_window;
        private System.Windows.Forms.StatusStrip Инструмент;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tool;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox brash;
        private System.Windows.Forms.Panel p_Color;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

