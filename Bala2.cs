/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 29/11/2022
 * Time: 22:10
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
	/// Description of Bala2.
	/// </summary>
	public class Bala2: Personagem
	{
		public Bala2()
		{
			Load("atk_boss_v0.gif");
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Width = 50;
			Height = 50;

			//movimento timer & Caderante
			
			timer3.Enabled = true;
			timer3.Interval = 100;
			timer3.Tick += Movimento;	
		}

		public Timer timer3 = new Timer();
		public int dano;
		
		//Movimento & Caderante
			public void Movimento(object sender, System.EventArgs e)
        {
			Left -= 15;
			if(Left > MainForm.fundo.Width)
			{
				timer3.Enabled = false;
				Dispose();
			}
			for (int i=0; i<MainForm.ListaInimigos.Items.Count; i++)
			{
				Inimigo inimigo = (Inimigo) MainForm.ListaInimigos.Items[i];
				if(Bounds.IntersectsWith(inimigo.Bounds))
				{
					timer3.Enabled = false;
					Dispose();
					inimigo.Destruir();
				}
			}
        }
		//
	}
}
