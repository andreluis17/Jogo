/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 29/09/2022
 * Time: 21:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo_v2
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			button1.Left = (this.Width - button1.Width)/2;
			
		}
		
		//Variaveis e importações de classe
		
		//public static Inimigo inimigo = new Inimigo();
		public static Heroi heroi = new Heroi();
		public static Fundo fundo = new Fundo();
		public static Bala bala = new Bala();
	    Random rnd = new Random();
		
		public static ListBox ListaInimigos = new ListBox();

		void Button1Click(object sender, System.EventArgs e)
		{
			// botão start
			
			button1.Visible = false;
			button1.Enabled = false;
			this.KeyPreview = true;
			pictureBox1.Visible = false;
			timer1.Enabled = true;
			
			// fundo
			
			fundo.Parent = this;
			fundo.Load("fundo1.jpg");
			fundo.Width = Width;
			fundo.Height = 500;
			
			// heroi
			
			heroi.Parent = fundo;
			
			//configurar inimigo
			
			//inimigo.Parent = fundo;
			
			
			
			
		}
		
		//Movimento heroi
		
		void MainFormKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			e.Handled = e.SuppressKeyPress = true; // não fazer som do window
			
			if (e.KeyCode==Keys.A) heroi.Esq();
			if (e.KeyCode==Keys.S) heroi.Baixo();
			if (e.KeyCode==Keys.D) heroi.Dir();
			if (e.KeyCode==Keys.W) heroi.Cima();
			if (e.KeyCode==Keys.Space)heroi.Tiro();		
		}
		
		
		
		//Colisâo heroi
		
		void Timer1Tick(object sender, EventArgs e)
		{
			for(int i=0; i<MainForm.ListaInimigos.Items.Count; i++)
			{Inimigo inimigo = (Inimigo) MainForm.ListaInimigos.Items[i];
				if(heroi.Bounds.IntersectsWith(inimigo.Bounds))
				{
					inimigo.Destruir();
					timer1.Enabled = false;
					heroi.Dispose();
					MessageBox.Show("Xablau");
				}
			}
			
			if(rnd.Next(10)<2) GerarInimigos();
			Text = "Inimigos: " + ListaInimigos.Items.Count;
		}
		
		void GerarInimigos()
		{
			Inimigo inimigo = new Inimigo();
			inimigo.Parent = fundo;
			ListaInimigos.Items.Add(inimigo);
		}
	}	
}
	
