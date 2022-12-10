/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 29/11/2022
 * Time: 21:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo_v2
{
	/// <summary>
	/// Description of Bala.
	/// </summary>
	public class Bala: Personagem
	{
		public Bala()
		{
			Load("atk_boss_v0.gif");
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Width = 50;
			Height = 50;	
			
			//Timer movimento
			
			timer.Enabled = true;
			timer.Interval = 100;
			timer.Tick += Movimento;
		}

		public Timer timer = new Timer();
		public int dano;
		
		//Movimento
		public void Movimento(object sender, System.EventArgs e)
        {
			Left += 15;
			if(Left > MainForm.fundo.Width)
			{
				timer.Enabled = false;
				Dispose();
			}
			for (int i=0; i<MainForm.ListaInimigos.Items.Count; i++)
			{
				Inimigo inimigo = (Inimigo) MainForm.ListaInimigos.Items[i];
				if(Bounds.IntersectsWith(inimigo.Bounds))
				{
					timer.Enabled = false;
					Dispose();
					inimigo.Destruir();
				}
			}
        }
		//
		

		
		

		
	}
}

		
	
		

