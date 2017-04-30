/*
 * Created by SharpDevelop.
 * User: Juan Agustin
 * Date: 29/04/2017
 * Time: 21:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BasicMap
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
			this.puerto = new System.IO.Ports.SerialPort(this.components);
			this.conectar = new System.Windows.Forms.Button();
			this.desconectar = new System.Windows.Forms.Button();
			this.puertosbox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Coordenadas = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.Coordenadas.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// gMapControl1
			// 
			this.gMapControl1.Bearing = 0F;
			this.gMapControl1.CanDragMap = true;
			this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
			this.gMapControl1.GrayScaleMode = false;
			this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
			this.gMapControl1.LevelsKeepInMemmory = 5;
			this.gMapControl1.Location = new System.Drawing.Point(12, 12);
			this.gMapControl1.MarkersEnabled = true;
			this.gMapControl1.MaxZoom = 2;
			this.gMapControl1.MinZoom = 2;
			this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
			this.gMapControl1.Name = "gMapControl1";
			this.gMapControl1.NegativeMode = false;
			this.gMapControl1.PolygonsEnabled = true;
			this.gMapControl1.RetryLoadTile = 0;
			this.gMapControl1.RoutesEnabled = true;
			this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
			this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
			this.gMapControl1.ShowTileGridLines = false;
			this.gMapControl1.Size = new System.Drawing.Size(587, 394);
			this.gMapControl1.TabIndex = 0;
			this.gMapControl1.Zoom = 0D;
			this.gMapControl1.Load += new System.EventHandler(this.GMapControl1Load);
			// 
			// puerto
			// 
			this.puerto.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoDataReceived);
			// 
			// conectar
			// 
			this.conectar.Location = new System.Drawing.Point(6, 46);
			this.conectar.Name = "conectar";
			this.conectar.Size = new System.Drawing.Size(164, 23);
			this.conectar.TabIndex = 1;
			this.conectar.Text = "Conectar";
			this.conectar.UseVisualStyleBackColor = true;
			this.conectar.Click += new System.EventHandler(this.ConectarClick);
			// 
			// desconectar
			// 
			this.desconectar.Location = new System.Drawing.Point(5, 75);
			this.desconectar.Name = "desconectar";
			this.desconectar.Size = new System.Drawing.Size(165, 23);
			this.desconectar.TabIndex = 2;
			this.desconectar.Text = "Desconectar";
			this.desconectar.UseVisualStyleBackColor = true;
			this.desconectar.Click += new System.EventHandler(this.DesconectarClick);
			// 
			// puertosbox
			// 
			this.puertosbox.FormattingEnabled = true;
			this.puertosbox.Location = new System.Drawing.Point(6, 19);
			this.puertosbox.Name = "puertosbox";
			this.puertosbox.Size = new System.Drawing.Size(164, 21);
			this.puertosbox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 40);
			this.label1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 40);
			this.label2.TabIndex = 5;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(6, 17);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 6;
			this.radioButton1.Text = "Mapa";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.desconectar);
			this.groupBox1.Controls.Add(this.conectar);
			this.groupBox1.Controls.Add(this.puertosbox);
			this.groupBox1.Location = new System.Drawing.Point(619, 298);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(176, 108);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Conexión";
			// 
			// Coordenadas
			// 
			this.Coordenadas.Controls.Add(this.radioButton3);
			this.Coordenadas.Controls.Add(this.radioButton2);
			this.Coordenadas.Controls.Add(this.radioButton1);
			this.Coordenadas.Location = new System.Drawing.Point(619, 185);
			this.Coordenadas.Name = "Coordenadas";
			this.Coordenadas.Size = new System.Drawing.Size(176, 107);
			this.Coordenadas.TabIndex = 8;
			this.Coordenadas.TabStop = false;
			this.Coordenadas.Text = "Vistas";
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(6, 77);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(104, 24);
			this.radioButton3.TabIndex = 8;
			this.radioButton3.Text = "Terreno";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(6, 47);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 7;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Satélite";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Location = new System.Drawing.Point(619, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(176, 167);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Posición";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 425);
			this.Controls.Add(this.Coordenadas);
			this.Controls.Add(this.gMapControl1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.Name = "MainForm";
			this.Text = "Demo Live tracking";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.Coordenadas.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.GroupBox Coordenadas;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox puertosbox;
		private System.Windows.Forms.Button desconectar;
		private System.Windows.Forms.Button conectar;
		private System.IO.Ports.SerialPort puerto;
		private GMap.NET.WindowsForms.GMapControl gMapControl1;
	}
}
