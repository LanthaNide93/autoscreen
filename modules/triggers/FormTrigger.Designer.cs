﻿namespace AutoScreenCapture
{
    partial class FormTrigger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrigger));
            this.labelEditorName = new System.Windows.Forms.Label();
            this.textBoxTriggerName = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTriggerCondition = new System.Windows.Forms.Label();
            this.comboBoxCondition = new System.Windows.Forms.ComboBox();
            this.labelTriggerAction = new System.Windows.Forms.Label();
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.labelEditor = new System.Windows.Forms.Label();
            this.comboBoxEditor = new System.Windows.Forms.ComboBox();
            this.checkBoxEnabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelEditorName
            // 
            this.labelEditorName.AutoSize = true;
            this.labelEditorName.Location = new System.Drawing.Point(12, 9);
            this.labelEditorName.Name = "labelEditorName";
            this.labelEditorName.Size = new System.Drawing.Size(38, 13);
            this.labelEditorName.TabIndex = 0;
            this.labelEditorName.Text = "Name:";
            // 
            // textBoxTriggerName
            // 
            this.textBoxTriggerName.Location = new System.Drawing.Point(80, 6);
            this.textBoxTriggerName.MaxLength = 50;
            this.textBoxTriggerName.Name = "textBoxTriggerName";
            this.textBoxTriggerName.Size = new System.Drawing.Size(351, 20);
            this.textBoxTriggerName.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(359, 109);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.Click_buttonOK);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(440, 109);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.Click_buttonCancel);
            // 
            // labelTriggerCondition
            // 
            this.labelTriggerCondition.AutoSize = true;
            this.labelTriggerCondition.Location = new System.Drawing.Point(12, 35);
            this.labelTriggerCondition.Name = "labelTriggerCondition";
            this.labelTriggerCondition.Size = new System.Drawing.Size(54, 13);
            this.labelTriggerCondition.TabIndex = 0;
            this.labelTriggerCondition.Text = "Condition:";
            // 
            // comboBoxCondition
            // 
            this.comboBoxCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCondition.FormattingEnabled = true;
            this.comboBoxCondition.Location = new System.Drawing.Point(80, 32);
            this.comboBoxCondition.Name = "comboBoxCondition";
            this.comboBoxCondition.Size = new System.Drawing.Size(435, 21);
            this.comboBoxCondition.TabIndex = 2;
            // 
            // labelTriggerAction
            // 
            this.labelTriggerAction.AutoSize = true;
            this.labelTriggerAction.Location = new System.Drawing.Point(12, 60);
            this.labelTriggerAction.Name = "labelTriggerAction";
            this.labelTriggerAction.Size = new System.Drawing.Size(40, 13);
            this.labelTriggerAction.TabIndex = 0;
            this.labelTriggerAction.Text = "Action:";
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Location = new System.Drawing.Point(80, 57);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(435, 21);
            this.comboBoxAction.TabIndex = 3;
            // 
            // labelEditor
            // 
            this.labelEditor.AutoSize = true;
            this.labelEditor.Location = new System.Drawing.Point(12, 85);
            this.labelEditor.Name = "labelEditor";
            this.labelEditor.Size = new System.Drawing.Size(37, 13);
            this.labelEditor.TabIndex = 0;
            this.labelEditor.Text = "Editor:";
            // 
            // comboBoxEditor
            // 
            this.comboBoxEditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditor.FormattingEnabled = true;
            this.comboBoxEditor.Location = new System.Drawing.Point(80, 82);
            this.comboBoxEditor.Name = "comboBoxEditor";
            this.comboBoxEditor.Size = new System.Drawing.Size(435, 21);
            this.comboBoxEditor.TabIndex = 4;
            // 
            // checkBoxEnabled
            // 
            this.checkBoxEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEnabled.AutoSize = true;
            this.checkBoxEnabled.Location = new System.Drawing.Point(450, 8);
            this.checkBoxEnabled.Name = "checkBoxEnabled";
            this.checkBoxEnabled.Size = new System.Drawing.Size(65, 17);
            this.checkBoxEnabled.TabIndex = 7;
            this.checkBoxEnabled.TabStop = false;
            this.checkBoxEnabled.Text = "Enabled";
            this.checkBoxEnabled.UseVisualStyleBackColor = true;
            // 
            // FormTrigger
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(527, 141);
            this.Controls.Add(this.checkBoxEnabled);
            this.Controls.Add(this.comboBoxEditor);
            this.Controls.Add(this.labelEditor);
            this.Controls.Add(this.comboBoxAction);
            this.Controls.Add(this.labelTriggerAction);
            this.Controls.Add(this.comboBoxCondition);
            this.Controls.Add(this.labelTriggerCondition);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelEditorName);
            this.Controls.Add(this.textBoxTriggerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTrigger";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormTrigger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditorName;
        private System.Windows.Forms.TextBox textBoxTriggerName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelTriggerCondition;
        private System.Windows.Forms.ComboBox comboBoxCondition;
        private System.Windows.Forms.Label labelTriggerAction;
        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.Label labelEditor;
        private System.Windows.Forms.ComboBox comboBoxEditor;
        private System.Windows.Forms.CheckBox checkBoxEnabled;
    }
}