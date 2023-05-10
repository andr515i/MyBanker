using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
	internal class Visa : Card, ICardColor
	{

		private string? cardColor = null;

		public string CardColor
		{
			get { return cardColor; }
			set { cardColor = value; }
		}
		public Visa(string CustName, int CustAge) : base(CustName, CustAge)
		{
			cardNumber = prefixes[21];

			while (cardNumber.Length < 16)
			{
				cardNumber += rnd.Next(10).ToString();
			}
			while (accountNumber.Length < 14)
			{
				accountNumber += rnd.Next(10).ToString();
			}
		}
		public Visa(string CustName, int CustAge, string cardCol) : base(CustName, CustAge)
		{
			cardNumber = prefixes[21];

			while (cardNumber.Length < 16)
			{
				cardNumber += rnd.Next(10).ToString();
			}
			while (accountNumber.Length < 14)
			{
				accountNumber += rnd.Next(10).ToString();
			}

			CardColor = cardCol;
		}


		public void ChangeColor(string newColor)
		{
			CardColor = newColor;
		}

		public override string ToString()
		{
			return $"{GetType()} | Navn: {CustomerName} | Alder: {CustomerAge} | Kortnummer: {CardNumber} | Kontonummer: {AccountNumber} | card color: {CardColor}";
		}

	}
}
