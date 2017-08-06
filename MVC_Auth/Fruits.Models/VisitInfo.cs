using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruits.Models
{
	public class VisitInfo
	{
		public string Ip { get; set; }
		public DateTime VisitDate { get; set; }
		public Guid Guid { get; set; }
		public VisitInfo()
		{
			VisitDate = DateTime.Now;
			Guid = Guid.NewGuid();
		}
	}
}
