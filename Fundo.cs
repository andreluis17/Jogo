/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 29/09/2022
 * Time: 21:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo_v2
{
	
	public class Fundo : PictureBox
	{
		public Fundo()
		{
			this.SizeMode = PictureBoxSizeMode.StretchImage;
		}
	}
}
