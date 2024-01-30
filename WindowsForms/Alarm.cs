using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
	public class Alarm
	{
		public DateTime Date { get; set; }
		public DateTime Time { get; set; }
		public Byte WeekDays { get; set; }
		public string Filename { get; set; }
		public Alarm(DateTime time, string filename, byte weekdays = 0)
		{
			this.Time = time;
			this.Filename = filename;
			this.WeekDays = weekdays;
		}
		public override string ToString()
		{
			return $"{Date.ToString()} {Time.ToString()} {WeekDays} {Filename.Split('\\').Last()}";
		}
	}
}
