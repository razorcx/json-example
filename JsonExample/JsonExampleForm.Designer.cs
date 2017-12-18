namespace JsonExample
{
	partial class JsonExampleForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JsonExampleForm));
			this.richTextBoxReadJson = new System.Windows.Forms.RichTextBox();
			this.buttonReadJson = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonWriteJson = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// richTextBoxReadJson
			// 
			this.richTextBoxReadJson.Location = new System.Drawing.Point(13, 126);
			this.richTextBoxReadJson.Name = "richTextBoxReadJson";
			this.richTextBoxReadJson.Size = new System.Drawing.Size(350, 519);
			this.richTextBoxReadJson.TabIndex = 0;
			this.richTextBoxReadJson.Text = "";
			// 
			// buttonReadJson
			// 
			this.buttonReadJson.Location = new System.Drawing.Point(248, 79);
			this.buttonReadJson.Name = "buttonReadJson";
			this.buttonReadJson.Size = new System.Drawing.Size(115, 41);
			this.buttonReadJson.TabIndex = 1;
			this.buttonReadJson.Text = "Read Json";
			this.buttonReadJson.UseVisualStyleBackColor = true;
			this.buttonReadJson.Click += new System.EventHandler(this.buttonReadJson_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::JsonExample.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(13, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(159, 51);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// buttonWriteJson
			// 
			this.buttonWriteJson.Location = new System.Drawing.Point(13, 79);
			this.buttonWriteJson.Name = "buttonWriteJson";
			this.buttonWriteJson.Size = new System.Drawing.Size(115, 41);
			this.buttonWriteJson.TabIndex = 9;
			this.buttonWriteJson.Text = "Write Json";
			this.buttonWriteJson.UseVisualStyleBackColor = true;
			this.buttonWriteJson.Click += new System.EventHandler(this.buttonWriteJson_Click);
			// 
			// JsonExampleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 657);
			this.Controls.Add(this.buttonWriteJson);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonReadJson);
			this.Controls.Add(this.richTextBoxReadJson);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "JsonExampleForm";
			this.Text = "Json Example";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBoxReadJson;
		private System.Windows.Forms.Button buttonReadJson;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonWriteJson;
	}
}

