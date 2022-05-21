using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul10_1302204090
{
	public class CariNilaiPangkatClass
	{
		public static int CariNilaiPangkat(int a, int b)
		{
			if (b == 0) return 1;
			if (b < 0) return -1;

			if (b > 10 || a > 100) return -2;


			int result = 1;
			for (int i = 0; i < b; i++)
			{
				try
				{
					result = checked(result * a);
				}
				catch (OverflowException)
				{
					return -3;
				}

			}

			return result;
		}

	}
}
