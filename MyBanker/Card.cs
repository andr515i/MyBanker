using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
	public abstract class Card
	{

		protected string customerName;

		public string CustomerName
		{
			get { return customerName; }

		}

		protected int customerAge;

		public int CustomerAge
		{
			get { return customerAge; }

		}
		protected string accountNumber;

		public string AccountNumber
		{
			get { return accountNumber; }

		}



		protected string cardNumber;

		public string CardNumber
		{
			get { return cardNumber; }

		}
		protected Random rnd = new Random();
		protected Dictionary<int, string> prefixes = new Dictionary<int, string>();

		public Card(string CustName, int CustAge)
		{
			customerName = CustName;
			customerAge = CustAge;
			accountNumber = "3520";
			AddPrefixes();		


		}

		private void AddPrefixes()
		{
			//debit card
			prefixes.Add(1, "2400");
			// maestro
			prefixes.Add(2, "5018");
			prefixes.Add(3, "5020");
			prefixes.Add(4, "5038");
			prefixes.Add(5, "5893");
			prefixes.Add(6, "6304");
			prefixes.Add(7, "6759");
			prefixes.Add(8, "6761");
			prefixes.Add(9, "6762");
			prefixes.Add(10, "6763");
			// mastercard
			prefixes.Add(11, "51");
			prefixes.Add(12, "52");
			prefixes.Add(13, "53");
			prefixes.Add(14, "54");
			prefixes.Add(15, "55");
			//Electron
			prefixes.Add(16, "4026");
			prefixes.Add(17, "417500");
			prefixes.Add(18, "4508");
			prefixes.Add(19, "4844");
			prefixes.Add(20, "4917");
			// visa
			prefixes.Add(21, "4");


		}
		public override string ToString()
		{
			return $"{GetType()} | Navn: {CustomerName} | Alder: {CustomerAge} | Kortnummer: {CardNumber} | Kontonummer: {AccountNumber} ";
		}

	}

}
