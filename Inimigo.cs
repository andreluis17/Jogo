/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 06/10/2022
 * Time: 22:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo_v2
{
	
	public class Inimigo : Personagem
	{
		public Inimigo()
		{
			Load("atk_boss_v0.gif");
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Width = 50;
			Height = 50;
			Top =  rnd.Next(0,200) * 3;
			Left = 1110;
			
			//Movimento timer
			
			timer.Enabled = true;
			timer.Interval = 350;
			timer.Tick += Movimento;
		}

		public Timer timer = new Timer();
		Random rnd = new Random();
		public int dano;
		
		//Movimento
		
		public void Movimento(object sender, System.EventArgs e)
        {
			Left -= 15;
			//if (Left < -1000)
			//{
			//	timer.Enabled = false;
			//	Destruir();
			//}
        }

		public void Destruir()
		{
			Dispose();
			timer.Enabled =false;
			MainForm.ListaInimigos.Items.Remove(this);
		}
		
		
		
	}
}
