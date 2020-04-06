using System;
using System.Collections.Generic;
using System.Text;

namespace FruitFly.Repository.Models
{
	public class Referencepoint
	{
		public int ReferencepointId { get; set; }

		public int Category { get; set; } // ClusterID

		public int RSSI1 { get; set; }

		public int RSSI2 { get; set; }

		public int RSSI3 { get; set; }

		public int X { get; set; }

		public int Y { get; set; }

		public int HeatmapId { get; set; }
		public Heatmap Heatmap { get; set; }

	}
}
