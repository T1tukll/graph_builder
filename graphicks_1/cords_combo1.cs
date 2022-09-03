/*
 *	Titov, Kotov
 *	Lipetsk 2022
 */

namespace graphicks_1 {
	class cord {
		public int Xcnt { get; set; }
		public int Ycnt { get; set; }
		public int Xold { get; set; }
		public int Yold { get; set; }
		public int Xdig { get; set; }
		public int Ydig { get; set; }
		public double Y { get; set; }
	}

	class FnAutos {
		public int Gstep;
		public double Fstep;

		public double Scale;

		public double MinBord;
		public double MaxBord;
		
	}

	class area {
		public int H;
		public int W;
    }
}
