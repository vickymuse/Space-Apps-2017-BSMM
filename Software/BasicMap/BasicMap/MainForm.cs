/*
 * Created by SharpDevelop.
 * User: Juan Agustin
 * Date: 29/04/2017
 * Time: 21:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Globalization;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace BasicMap
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		GMarkerGoogle puntero;
        GMapOverlay punteroOverlay;
              

		string[] separadoX;
        
        double LatInicial = -32.968317;
        double LngInicial = -60.658769;
        double x;
        double y;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			SerialPort puerto = new SerialPort();			
			puertosload();
			            			
            gMapControl1.MapProvider = GMapProviders.GoogleChinaSatelliteMap;

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.MinZoom = 10;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 17;
            gMapControl1.AutoScroll = true;
 			gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            
            punteroOverlay = new GMapOverlay("Puntero");
           
            gMapControl1.Overlays.Add(punteroOverlay);
            
           gMapControl1.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
           //gMapControl1.MapProvider = GMapProviders.GoogleMap;
		}
		
		void ConectarClick(object sender, EventArgs e)
		{
			try{
				puerto.PortName=Convert.ToString(puertosbox.Text) ;
				if(!puerto.IsOpen)
				puerto.Open();
				puertosbox.Enabled=false;
				conectar.Enabled=false;
			}
			catch{
				MessageBox.Show("Error al conectar","Error de conexion");
				puertosload();
			}
		}
		
		void GMapControl1Load(object sender, EventArgs e)
		{
			
		}
		
		
		void puertosload(){
		    string[] puertosdisponibles = null;
			puertosbox.Items.Clear();
			puertosdisponibles = SerialPort.GetPortNames();
	        puertosbox.Items.AddRange(puertosdisponibles);
		}
		
		void DesconectarClick(object sender, EventArgs e)
		{
			try{
			if(puerto.IsOpen)
				puerto.Close();
				puertosbox.Enabled=true;
				conectar.Enabled=true;
			}
			catch{
				MessageBox.Show("Error al conectar","Error de conexion");
			}	
			puertosload();
		
		}
		
		void PuertoDataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			separadoX=puerto.ReadLine().ToString().Split('_');
			
		
			
			
			try{
			punteroOverlay.Markers.RemoveAt(2);
			}catch{}
			try{
			 x = Convert.ToDouble(separadoX[0], CultureInfo.InvariantCulture);
			 y = Convert.ToDouble(separadoX[1], CultureInfo.InvariantCulture);
            puntero = new GMarkerGoogle(new PointLatLng(x,y), GMarkerGoogleType.red);
            punteroOverlay.Markers.Add(puntero);
            gMapControl1.Position= new PointLatLng(x, y);
            
           // label1.Invoke((MethodInvoker)(() => label1.Text=Convert.ToString(x)));
            //label2.Invoke((MethodInvoker)(() =>label2.Text="Hola"));
            //this.Refresh();
            label1.Text=Convert.ToString(x);
            label2.Text=Convert.ToString(y);
            this.Refresh();
			}
			catch{}
			
			
            
		}
		
		
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			cambio();
		}
		
		void cambio(){
			if(radioButton1.Checked){
				gMapControl1.MapProvider = GMapProviders.GoogleMap;
			}
			if(radioButton2.Checked){
				gMapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;
			}
			if(radioButton3.Checked){
				gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;
			}
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			cambio();
		}
		
		void RadioButton3CheckedChanged(object sender, EventArgs e)
		{
			cambio();
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			label1.Text=x.ToString();
			label2.Text=y.ToString();
		}
	}
}
