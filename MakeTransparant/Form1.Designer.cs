namespace MakeTransparent
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
        private void InitializeComponent() {
            InputPng = new TextBox();
            InputPathLabel = new Label();
            InputPngError = new Label();
            OutputPngPath = new TextBox();
            label1 = new Label();
            OutputPngError = new Label();
            Execute = new Button();
            ExecuteError = new Label();
            Success = new Label();
            SuspendLayout();
            // 
            // InputPng
            // 
            InputPng.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InputPng.BackColor = SystemColors.ControlDark;
            InputPng.Location = new Point(12, 26);
            InputPng.Name = "InputPng";
            InputPng.Size = new Size(776, 23);
            InputPng.TabIndex = 0;
            InputPng.TextChanged += InputPng_TextChanged;
            InputPng.MouseLeave += InputPng_MouseLeave;
            // 
            // InputPathLabel
            // 
            InputPathLabel.AutoSize = true;
            InputPathLabel.ForeColor = Color.White;
            InputPathLabel.Location = new Point(12, 8);
            InputPathLabel.Name = "InputPathLabel";
            InputPathLabel.Size = new Size(89, 15);
            InputPathLabel.TabIndex = 1;
            InputPathLabel.Text = "Input PNG Path";
            // 
            // InputPngError
            // 
            InputPngError.AutoSize = true;
            InputPngError.ForeColor = Color.LightCoral;
            InputPngError.Location = new Point(107, 8);
            InputPngError.Name = "InputPngError";
            InputPngError.Size = new Size(43, 15);
            InputPngError.TabIndex = 2;
            InputPngError.Text = "ERROR";
            InputPngError.Visible = false;
            // 
            // OutputPngPath
            // 
            OutputPngPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OutputPngPath.BackColor = SystemColors.ControlDark;
            OutputPngPath.Location = new Point(12, 77);
            OutputPngPath.Name = "OutputPngPath";
            OutputPngPath.Size = new Size(776, 23);
            OutputPngPath.TabIndex = 3;
            OutputPngPath.MouseLeave += OutputPngPath_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 4;
            label1.Text = "Output PNG Path";
            // 
            // OutputPngError
            // 
            OutputPngError.AutoSize = true;
            OutputPngError.ForeColor = Color.LightCoral;
            OutputPngError.Location = new Point(117, 59);
            OutputPngError.Name = "OutputPngError";
            OutputPngError.Size = new Size(43, 15);
            OutputPngError.TabIndex = 5;
            OutputPngError.Text = "ERROR";
            OutputPngError.Visible = false;
            // 
            // Execute
            // 
            Execute.Location = new Point(16, 118);
            Execute.Name = "Execute";
            Execute.Size = new Size(111, 42);
            Execute.TabIndex = 6;
            Execute.Text = "Execute";
            Execute.UseVisualStyleBackColor = true;
            Execute.Click += Execute_Click;
            // 
            // ExecuteError
            // 
            ExecuteError.AutoSize = true;
            ExecuteError.ForeColor = Color.LightCoral;
            ExecuteError.Location = new Point(133, 132);
            ExecuteError.Name = "ExecuteError";
            ExecuteError.Size = new Size(43, 15);
            ExecuteError.TabIndex = 7;
            ExecuteError.Text = "ERROR";
            ExecuteError.Visible = false;
            // 
            // Success
            // 
            Success.AutoSize = true;
            Success.ForeColor = Color.LightGreen;
            Success.Location = new Point(16, 163);
            Success.Name = "Success";
            Success.Size = new Size(48, 15);
            Success.TabIndex = 8;
            Success.Text = "Success";
            Success.Visible = false;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 238);
            Controls.Add(Success);
            Controls.Add(ExecuteError);
            Controls.Add(Execute);
            Controls.Add(OutputPngError);
            Controls.Add(label1);
            Controls.Add(OutputPngPath);
            Controls.Add(InputPngError);
            Controls.Add(InputPathLabel);
            Controls.Add(InputPng);
            Name = "Form1";
            Text = "Make Transparent";
            DragDrop += Form1_DragDrop;
            DragEnter += Form1_DragEnter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputPng;
        private Label InputPathLabel;
        private Label InputPngError;
        private TextBox OutputPngPath;
        private Label label1;
        private Label OutputPngError;
        private Button Execute;
        private Label ExecuteError;
        private Label Success;
    }
}
