using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
	internal interface ICardColor
	{
		 string CardColor
		{
			get
			{
				return "black";
			}
		}

		abstract void ChangeColor(string newColor);
	}
}
