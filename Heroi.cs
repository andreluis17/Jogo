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
	
	public class Heroi: Personagem
	{
		public Heroi()
		{
			this.Width = 200;
			this.Height = 150;
			this.Left = 50;
			this.Top = 200;
			this.speed = 25;
		}
		
		//Variaveis
		
		public int xp = 0;
		public int nivel = 0;
		public int sentido = 1;
		public int contCenario = 1;
			
		public string imagemDir = "heroi.gif";
		public string imagemEsq = "heroi_esquerda.gif";
		
		
	
		
		//Movimentos herois
		
		//Movimento para direita
		
		public void Dir()
		{
		
			Left += speed;
			if (sentido != 1)
			{
				sentido = 1;
				Load(imagemDir);
			}
		
			if (Left > MainForm.fundo.Width){
				
				Left = 0;
				contCenario ++;
				if(contCenario > 3) {contCenario = 3; Left = MainForm.fundo.Width - this.Width;}
				MainForm.fundo.Load("fundo" + contCenario + ".jpg");
			}	
		}
		
		//Movimento para esquerda
		
		public void Esq()
		{
		
			Left -= speed;
			if (sentido != -1)
			{
				sentido = -1;
				Load(imagemEsq);
			}
			
			//troca cenario
			
			if (Left < 1)
			{
				Left = MainForm.fundo.Width - this.Width;
				contCenario --;
			
				if (contCenario < 1) {contCenario = 1; Left = 0; }
				MainForm.fundo.Load("fundo" + contCenario + ".jpg");
			}
		}
		
		//Movimento para cima
		
		public void Cima()
		{
			Top -= speed;
			if(Top < 0)
			   Top = 0;
		}
		
		//Movimento para baixo
		
		public void Baixo()
		{
			Top += speed;
			if(Top > MainForm.fundo.Height - this.Height)
				Top = MainForm.fundo.Height - this.Height;
		}
		
		//Tiro
		
		public void Tiro()
		{
		    
			if (sentido == 1)
			{
			 sentido = 1;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         	  
			Bala bala = new Bala();
			bala.Parent = MainForm.fundo;
			bala.Top = this.Top+40;
			bala.Left = this.Left+200;
			}
			
			//sentido contrario & Caderante
			
			if(sentido == -1)
			{
			sentido = -1;
			Bala2 bala2 = new Bala2();
			bala2.Parent = MainForm.fundo;
			bala2.Top = this.Top+40;
			bala2.Left = this.Left;	
			}
		}
	}
}


