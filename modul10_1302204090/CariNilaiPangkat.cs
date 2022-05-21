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
			// Cek jika b == 0, maka return 1
			if (b == 0) return 1;

			// Cek jika b < 0, maka return -1
			if (b < 0) return -1;

			// Cek jika b > 10 atau a > 100, return -1
			if (b > 10 || a > 100) return -2;


			// Proses perhitungan pangkat
			int result = 1;
			for (int i = 0; i < b; i++)
			{
				try
				{
					// Menghitung sambil mengecek jika terjadi Exception
					result = checked(result * a);
				}
				catch (OverflowException)
				{
					// Return -3 saat terjadi OverflowException (value lebih dari kapasitas)
					return -3;
				}

			}

			return result;
		}

	}
}
