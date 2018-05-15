using System;

namespace ef.Models
{
	public class Dinner
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTimeOffset EventDate { get; set; }

		public string Description { get; set; }
		public string HostedBy { get; set; }
		public string ContactPhone { get; set; }
		public string Address { get; set; }
		public string Country { get; set; }
	}
}