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

		public Car(double n_price, string s_color, string s_name)
		{
			this.n_price = n_price;
			this.s_color = s_color;
			this.s_name = s_name;
		}

		public double setsale()
		{
			return this.n_price * 0.8;
		}

		public string getinfo(int num)
		{
			return $"Information {num}. Name car - {this.s_name} ; color car - {this.s_color}; price car - {this.n_price}; new price car - {setsale()}";
		}

	}
}
