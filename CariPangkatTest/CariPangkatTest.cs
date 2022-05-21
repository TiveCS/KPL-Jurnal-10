using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using modul10_1302204090;

namespace CariPangkatTest
{
	[TestClass]
	public class CariPangkatTest
	{
		// Test untuk perhitungan normal
		[TestMethod]
		public void NormalNumberTest()
		{
			// Hitung angka biasa
			int res = CariNilaiPangkatClass.CariNilaiPangkat(2, 3);
			Assert.AreEqual(8, res);
		}

		// Test jika kasus b == 0 atau b < 0
		[TestMethod]
		public void ZeroOrMinusTest()
		{
			// Test b == 0
			int res = CariNilaiPangkatClass.CariNilaiPangkat(9, 0);
			Assert.AreEqual(1, res);

			// Test b < 0
			res = CariNilaiPangkatClass.CariNilaiPangkat(9, -1);
			Assert.AreEqual(-1, res);
		}

		// Test jika perhitungan pangkat melebihi kapasitas int
		[TestMethod]
		public void MaxIntegerOverflowTest()
		{
			int res = CariNilaiPangkatClass.CariNilaiPangkat(100, 10);
			Assert.AreEqual(-3, res);
		}

		// Test jika a > 100 atau b > 10
		[TestMethod]
		public void NumberBoundaryTest()
		{
			// Test jika a > 100, maka -2
			int res = CariNilaiPangkatClass.CariNilaiPangkat(101, 2);
			Assert.AreEqual(-2, res);

			// Test jika b > 10, maka -1
			res = CariNilaiPangkatClass.CariNilaiPangkat(20, 11);
			Assert.AreEqual(-2, res);
		}
	}
}
