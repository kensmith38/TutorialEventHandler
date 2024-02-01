namespace TutorialEventHandler
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            buttonPerformTask = new Button();
            label2 = new Label();
            textBoxProjectId = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBoxTaskList = new ComboBox();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 25);
            label1.TabIndex = 0;
            label1.Text = "Tutorial - EventHandler";
            // 
            // buttonPerformTask
            // 
            buttonPerformTask.Location = new Point(251, 91);
            buttonPerformTask.Name = "buttonPerformTask";
            buttonPerformTask.Size = new Size(94, 23);
            buttonPerformTask.TabIndex = 1;
            buttonPerformTask.Text = "Perform task";
            buttonPerformTask.UseVisualStyleBackColor = true;
            buttonPerformTask.Click += buttonPerformTask_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 64);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Project ID:";
            // 
            // textBoxProjectId
            // 
            textBoxProjectId.Location = new Point(112, 61);
            textBoxProjectId.Name = "textBoxProjectId";
            textBoxProjectId.Size = new Size(63, 23);
            textBoxProjectId.TabIndex = 3;
            textBoxProjectId.Text = "X100439";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 134);
            label3.Name = "label3";
            label3.Size = new Size(363, 84);
            label3.TabIndex = 4;
            label3.Text = "When the task is completed we would like to:\r\n1. Log the completed task\r\n2. Send email to notify project manager\r\n3?? Maybe we think of something else in the future";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 94);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 5;
            label4.Text = "Task desc:";
            // 
            // comboBoxTaskList
            // 
            comboBoxTaskList.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTaskList.FormattingEnabled = true;
            comboBoxTaskList.Items.AddRange(new object[] { "Estimate cost", "Order supplies" });
            comboBoxTaskList.Location = new Point(111, 91);
            comboBoxTaskList.Name = "comboBoxTaskList";
            comboBoxTaskList.Size = new Size(121, 23);
            comboBoxTaskList.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(428, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 241);
            panel1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 78);
            label6.Name = "label6";
            label6.Size = new Size(663, 150);
            label6.TabIndex = 10;
            label6.Text = resources.GetString("label6.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 19);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 9;
            label5.Text = "Design points";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 305);
            Controls.Add(panel1);
            Controls.Add(comboBoxTaskList);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxProjectId);
            Controls.Add(label2);
            Controls.Add(buttonPerformTask);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonPerformTask;
        private Label label2;
        private TextBox textBoxProjectId;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxTaskList;
        private Panel panel1;
        private Label label5;
        private Label label6;
    }
}
