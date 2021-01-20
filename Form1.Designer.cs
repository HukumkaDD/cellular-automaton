using System;

namespace GenProgram_v2._0
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
            this.fwindowsScale = new System.Windows.Forms.NumericUpDown();
            this.drawTest1 = new GenProgram_v2._0.DrawTest(ref config);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.energyMove = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbEnergyMoveCenter = new System.Windows.Forms.CheckBox();
            this.cbEnergyMoveDown = new System.Windows.Forms.CheckBox();
            this.cbEnergyMoveUp = new System.Windows.Forms.CheckBox();
            this.cbEnergyMoveLeft = new System.Windows.Forms.CheckBox();
            this.cbEnergyMoveRight = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbScaleField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEnergyCell = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaxEnergyCell = new System.Windows.Forms.TextBox();
            this.lFieldSize = new System.Windows.Forms.Label();
            this.tbFieldSize = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lFirstPopulation = new System.Windows.Forms.Label();
            this.tbCurrentPopulation = new System.Windows.Forms.TextBox();
            this.tbPrimaryPopulation = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.tbEntityShiftEnergy = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEntityMoveEnergy = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbEntityEnergyOut = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEntityEnergyIn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEntityEnergyRadius = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEntityCapacityEnergy = new System.Windows.Forms.TextBox();
            this.tbEntityMinEnergy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEntityAverageEnergy = new System.Windows.Forms.TextBox();
            this.tbEntityMaxEnergy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fwindowsScale)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fwindowsScale
            // 
            this.fwindowsScale.DecimalPlaces = 2;
            this.fwindowsScale.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.fwindowsScale.Location = new System.Drawing.Point(942, 697);
            this.fwindowsScale.Name = "fwindowsScale";
            this.fwindowsScale.Size = new System.Drawing.Size(54, 20);
            this.fwindowsScale.TabIndex = 3;
            this.fwindowsScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // drawTest1
            // 
            this.drawTest1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawTest1.Location = new System.Drawing.Point(0, 0);
            this.drawTest1.MouseHoverUpdatesOnly = false;
            this.drawTest1.Name = "drawTest1";
            this.drawTest1.Size = new System.Drawing.Size(625, 625);
            this.drawTest1.TabIndex = 1;
            this.drawTest1.Text = "drawTest1";
            this.drawTest1.Click += new System.EventHandler(this.drawTest1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.drawTest1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 627);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.energyMove);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(645, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 287);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Частота обновления";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Location = new System.Drawing.Point(13, 148);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 88);
            this.panel4.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "60 к/сек",
            "30 к/сек",
            "15 к/сек",
            "10 к/сек",
            "5 к/сек",
            "2 к/сек",
            "1 к/сек"});
            this.comboBox1.Location = new System.Drawing.Point(17, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // energyMove
            // 
            this.energyMove.AutoSize = true;
            this.energyMove.Location = new System.Drawing.Point(31, 15);
            this.energyMove.Name = "energyMove";
            this.energyMove.Size = new System.Drawing.Size(105, 13);
            this.energyMove.TabIndex = 4;
            this.energyMove.Text = "Смещение энергии";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbEnergyMoveCenter);
            this.panel3.Controls.Add(this.cbEnergyMoveDown);
            this.panel3.Controls.Add(this.cbEnergyMoveUp);
            this.panel3.Controls.Add(this.cbEnergyMoveLeft);
            this.panel3.Controls.Add(this.cbEnergyMoveRight);
            this.panel3.Location = new System.Drawing.Point(13, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 88);
            this.panel3.TabIndex = 6;
            // 
            // cbEnergyMoveCenter
            // 
            this.cbEnergyMoveCenter.AutoSize = true;
            this.cbEnergyMoveCenter.Location = new System.Drawing.Point(57, 59);
            this.cbEnergyMoveCenter.Name = "cbEnergyMoveCenter";
            this.cbEnergyMoveCenter.Size = new System.Drawing.Size(57, 17);
            this.cbEnergyMoveCenter.TabIndex = 4;
            this.cbEnergyMoveCenter.Text = "Центр";
            this.cbEnergyMoveCenter.UseVisualStyleBackColor = true;
            this.cbEnergyMoveCenter.CheckedChanged += new System.EventHandler(this.cbEnergyMoveCenter_CheckedChanged);
            // 
            // cbEnergyMoveDown
            // 
            this.cbEnergyMoveDown.AutoSize = true;
            this.cbEnergyMoveDown.Location = new System.Drawing.Point(21, 36);
            this.cbEnergyMoveDown.Name = "cbEnergyMoveDown";
            this.cbEnergyMoveDown.Size = new System.Drawing.Size(51, 17);
            this.cbEnergyMoveDown.TabIndex = 3;
            this.cbEnergyMoveDown.Text = "Вниз";
            this.cbEnergyMoveDown.UseVisualStyleBackColor = true;
            this.cbEnergyMoveDown.CheckedChanged += new System.EventHandler(this.cbEnergyMoveDown_CheckedChanged);
            // 
            // cbEnergyMoveUp
            // 
            this.cbEnergyMoveUp.AutoSize = true;
            this.cbEnergyMoveUp.Location = new System.Drawing.Point(21, 13);
            this.cbEnergyMoveUp.Name = "cbEnergyMoveUp";
            this.cbEnergyMoveUp.Size = new System.Drawing.Size(56, 17);
            this.cbEnergyMoveUp.TabIndex = 2;
            this.cbEnergyMoveUp.Text = "Вверх";
            this.cbEnergyMoveUp.UseVisualStyleBackColor = true;
            this.cbEnergyMoveUp.CheckedChanged += new System.EventHandler(this.cbEnergyMoveUp_CheckedChanged);
            // 
            // cbEnergyMoveLeft
            // 
            this.cbEnergyMoveLeft.AutoSize = true;
            this.cbEnergyMoveLeft.Location = new System.Drawing.Point(102, 36);
            this.cbEnergyMoveLeft.Name = "cbEnergyMoveLeft";
            this.cbEnergyMoveLeft.Size = new System.Drawing.Size(57, 17);
            this.cbEnergyMoveLeft.TabIndex = 1;
            this.cbEnergyMoveLeft.Text = "Влево";
            this.cbEnergyMoveLeft.UseVisualStyleBackColor = true;
            this.cbEnergyMoveLeft.CheckedChanged += new System.EventHandler(this.cbEnergyMoveLeft_CheckedChanged);
            // 
            // cbEnergyMoveRight
            // 
            this.cbEnergyMoveRight.AutoSize = true;
            this.cbEnergyMoveRight.Location = new System.Drawing.Point(102, 13);
            this.cbEnergyMoveRight.Name = "cbEnergyMoveRight";
            this.cbEnergyMoveRight.Size = new System.Drawing.Size(63, 17);
            this.cbEnergyMoveRight.TabIndex = 0;
            this.cbEnergyMoveRight.Text = "Вправо";
            this.cbEnergyMoveRight.UseVisualStyleBackColor = true;
            this.cbEnergyMoveRight.CheckedChanged += new System.EventHandler(this.cbEnergyMoveRight_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.tabControl1);
            this.panel5.Location = new System.Drawing.Point(645, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(351, 334);
            this.panel5.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(349, 332);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.tbScaleField);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tbEnergyCell);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbMaxEnergyCell);
            this.tabPage1.Controls.Add(this.lFieldSize);
            this.tabPage1.Controls.Add(this.tbFieldSize);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(341, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Поле";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Red;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(299, 273);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 17);
            this.label18.TabIndex = 11;
            this.label18.Text = "   ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Red;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(299, 255);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 17);
            this.label17.TabIndex = 10;
            this.label17.Text = "   ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Red;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(299, 237);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 17);
            this.label16.TabIndex = 9;
            this.label16.Text = "   ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Red;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(299, 219);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "   ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Масштаб клетки";
            // 
            // tbScaleField
            // 
            this.tbScaleField.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbScaleField.Location = new System.Drawing.Point(203, 46);
            this.tbScaleField.Name = "tbScaleField";
            this.tbScaleField.ReadOnly = true;
            this.tbScaleField.Size = new System.Drawing.Size(116, 20);
            this.tbScaleField.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Энергия клетки(изначально)";
            // 
            // tbEnergyCell
            // 
            this.tbEnergyCell.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEnergyCell.Location = new System.Drawing.Point(203, 98);
            this.tbEnergyCell.Name = "tbEnergyCell";
            this.tbEnergyCell.ReadOnly = true;
            this.tbEnergyCell.Size = new System.Drawing.Size(116, 20);
            this.tbEnergyCell.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Максимальная энергия клетки";
            // 
            // tbMaxEnergyCell
            // 
            this.tbMaxEnergyCell.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbMaxEnergyCell.Location = new System.Drawing.Point(203, 72);
            this.tbMaxEnergyCell.Name = "tbMaxEnergyCell";
            this.tbMaxEnergyCell.ReadOnly = true;
            this.tbMaxEnergyCell.Size = new System.Drawing.Size(116, 20);
            this.tbMaxEnergyCell.TabIndex = 2;
            // 
            // lFieldSize
            // 
            this.lFieldSize.AutoSize = true;
            this.lFieldSize.Location = new System.Drawing.Point(15, 23);
            this.lFieldSize.Name = "lFieldSize";
            this.lFieldSize.Size = new System.Drawing.Size(73, 13);
            this.lFieldSize.TabIndex = 1;
            this.lFieldSize.Text = "Размер поля";
            this.lFieldSize.Click += new System.EventHandler(this.lFieldSize_Click);
            // 
            // tbFieldSize
            // 
            this.tbFieldSize.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbFieldSize.Location = new System.Drawing.Point(203, 20);
            this.tbFieldSize.Name = "tbFieldSize";
            this.tbFieldSize.ReadOnly = true;
            this.tbFieldSize.Size = new System.Drawing.Size(116, 20);
            this.tbFieldSize.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.lFirstPopulation);
            this.tabPage3.Controls.Add(this.tbCurrentPopulation);
            this.tabPage3.Controls.Add(this.tbPrimaryPopulation);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(341, 306);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Сущность(параметры)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Текущая популяция";
            // 
            // lFirstPopulation
            // 
            this.lFirstPopulation.AutoSize = true;
            this.lFirstPopulation.Location = new System.Drawing.Point(15, 23);
            this.lFirstPopulation.Name = "lFirstPopulation";
            this.lFirstPopulation.Size = new System.Drawing.Size(112, 13);
            this.lFirstPopulation.TabIndex = 3;
            this.lFirstPopulation.Text = "Исходная популяция";
            // 
            // tbCurrentPopulation
            // 
            this.tbCurrentPopulation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCurrentPopulation.Location = new System.Drawing.Point(203, 46);
            this.tbCurrentPopulation.Name = "tbCurrentPopulation";
            this.tbCurrentPopulation.ReadOnly = true;
            this.tbCurrentPopulation.Size = new System.Drawing.Size(116, 20);
            this.tbCurrentPopulation.TabIndex = 4;
            // 
            // tbPrimaryPopulation
            // 
            this.tbPrimaryPopulation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPrimaryPopulation.Location = new System.Drawing.Point(203, 20);
            this.tbPrimaryPopulation.Name = "tbPrimaryPopulation";
            this.tbPrimaryPopulation.ReadOnly = true;
            this.tbPrimaryPopulation.Size = new System.Drawing.Size(116, 20);
            this.tbPrimaryPopulation.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.tbEntityShiftEnergy);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tbEntityMoveEnergy);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tbEntityEnergyOut);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbEntityEnergyIn);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tbEntityEnergyRadius);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbEntityCapacityEnergy);
            this.tabPage2.Controls.Add(this.tbEntityMinEnergy);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbEntityAverageEnergy);
            this.tabPage2.Controls.Add(this.tbEntityMaxEnergy);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(341, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сущность(энергия)";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(18, 111);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 2);
            this.panel6.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Соотношениее энергий(движение)";
            // 
            // tbEntityShiftEnergy
            // 
            this.tbEntityShiftEnergy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEntityShiftEnergy.Location = new System.Drawing.Point(203, 263);
            this.tbEntityShiftEnergy.Name = "tbEntityShiftEnergy";
            this.tbEntityShiftEnergy.ReadOnly = true;
            this.tbEntityShiftEnergy.Size = new System.Drawing.Size(116, 20);
            this.tbEntityShiftEnergy.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Энергия для передвижения";
            // 
            // tbEntityMoveEnergy
            // 
            this.tbEntityMoveEnergy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEntityMoveEnergy.Location = new System.Drawing.Point(203, 237);
            this.tbEntityMoveEnergy.Name = "tbEntityMoveEnergy";
            this.tbEntityMoveEnergy.ReadOnly = true;
            this.tbEntityMoveEnergy.Size = new System.Drawing.Size(116, 20);
            this.tbEntityMoveEnergy.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Выделение энергии";
            // 
            // tbEntityEnergyOut
            // 
            this.tbEntityEnergyOut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEntityEnergyOut.Location = new System.Drawing.Point(203, 185);
            this.tbEntityEnergyOut.Name = "tbEntityEnergyOut";
            this.tbEntityEnergyOut.ReadOnly = true;
            this.tbEntityEnergyOut.Size = new System.Drawing.Size(116, 20);
            this.tbEntityEnergyOut.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Поглощение энергии";
            // 
            // tbEntityEnergyIn
            // 
            this.tbEntityEnergyIn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEntityEnergyIn.Location = new System.Drawing.Point(203, 158);
            this.tbEntityEnergyIn.Name = "tbEntityEnergyIn";
            this.tbEntityEnergyIn.ReadOnly = true;
            this.tbEntityEnergyIn.Size = new System.Drawing.Size(116, 20);
            this.tbEntityEnergyIn.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Радиус выделения энергии";
            // 
            // tbEntityEnergyRadius
            // 
            this.tbEntityEnergyRadius.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEntityEnergyRadius.Location = new System.Drawing.Point(203, 211);
            this.tbEntityEnergyRadius.Name = "tbEntityEnergyRadius";
            this.tbEntityEnergyRadius.ReadOnly = true;
            this.tbEntityEnergyRadius.Size = new System.Drawing.Size(116, 20);
            this.tbEntityEnergyRadius.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Энергетическая вместимость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Минимальная энергия";
            // 
            // tbEntityCapacityEnergy
            // 
            this.tbEntityCapacityEnergy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEntityCapacityEnergy.Location = new System.Drawing.Point(203, 132);
            this.tbEntityCapacityEnergy.Name = "tbEntityCapacityEnergy";
            this.tbEntityCapacityEnergy.ReadOnly = true;
            this.tbEntityCapacityEnergy.Size = new System.Drawing.Size(116, 20);
            this.tbEntityCapacityEnergy.TabIndex = 12;
            // 
            // tbEntityMinEnergy
            // 
            this.tbEntityMinEnergy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEntityMinEnergy.Location = new System.Drawing.Point(203, 20);
            this.tbEntityMinEnergy.Name = "tbEntityMinEnergy";
            this.tbEntityMinEnergy.ReadOnly = true;
            this.tbEntityMinEnergy.Size = new System.Drawing.Size(116, 20);
            this.tbEntityMinEnergy.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Максимальная энергия";
            // 
            // tbEntityAverageEnergy
            // 
            this.tbEntityAverageEnergy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEntityAverageEnergy.Location = new System.Drawing.Point(203, 46);
            this.tbEntityAverageEnergy.Name = "tbEntityAverageEnergy";
            this.tbEntityAverageEnergy.ReadOnly = true;
            this.tbEntityAverageEnergy.Size = new System.Drawing.Size(116, 20);
            this.tbEntityAverageEnergy.TabIndex = 8;
            // 
            // tbEntityMaxEnergy
            // 
            this.tbEntityMaxEnergy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEntityMaxEnergy.Location = new System.Drawing.Point(203, 72);
            this.tbEntityMaxEnergy.Name = "tbEntityMaxEnergy";
            this.tbEntityMaxEnergy.ReadOnly = true;
            this.tbEntityMaxEnergy.Size = new System.Drawing.Size(116, 20);
            this.tbEntityMaxEnergy.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Средняя энергия";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 653);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fwindowsScale);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.fwindowsScale)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DrawTest drawTest1;
        private System.Windows.Forms.NumericUpDown fwindowsScale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbEnergyMoveDown;
        private System.Windows.Forms.CheckBox cbEnergyMoveUp;
        private System.Windows.Forms.CheckBox cbEnergyMoveLeft;
        private System.Windows.Forms.CheckBox cbEnergyMoveRight;
        private System.Windows.Forms.Label energyMove;
        private System.Windows.Forms.CheckBox cbEnergyMoveCenter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbFieldSize;
        private System.Windows.Forms.Label lFieldSize;
        private System.Windows.Forms.Label lFirstPopulation;
        private System.Windows.Forms.TextBox tbPrimaryPopulation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEntityCapacityEnergy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEntityMaxEnergy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEntityAverageEnergy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEntityMinEnergy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCurrentPopulation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEnergyCell;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaxEnergyCell;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEntityEnergyRadius;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbEntityEnergyOut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEntityEnergyIn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbEntityShiftEnergy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbEntityMoveEnergy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbScaleField;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}

