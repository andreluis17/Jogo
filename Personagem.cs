/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 29/09/2022
 * Time: 21:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo_v2
{
	
	public class Personagem : PictureBox
	{
		public Personagem()
		{
			this.BackColor = Color.Transparent;
			this.SizeMode = PictureBoxSizeMode.StretchImage;
			this.Load(imagem);
		}
		
		public int hp = 100;
	    public int ataque = 30;
		public int escudo = 50;
		public int speed = 15;
		public string imagem = "heroi.gif";
	}
}
