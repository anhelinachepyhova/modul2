using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Logic
{
    public class Car
    {
		private double n_price;
		private string s_color;
		private string s_name;

		private double N_price
		{
			 get
			{
				return n_price * 0.8;
			}
			set
			{
				n_price = value;
			}
		}

		private string S_name
		{ 
			get
			{
				return s_name;
			}
			set
			{
				s_name = value;
			}
		}

		private string S_color
		{
			get
			{
				return s_color;
			}
			set
			{
				s_color = value;
			}
		}

		public void setinfoclass(string name, string color, double price)
		{
			S_name = name;
			S_color = color;
			N_price = price;
		}

		public string getinfo(int num)
		{
			return $"Information {num}. Name car - {S_name} ; color car - {S_color}; price car - {N_price};";
		}

	}
}
