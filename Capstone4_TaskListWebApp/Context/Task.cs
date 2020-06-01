using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone4_TaskListWebApp.Context
{
	public class Task
	{
		//Properties: 
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }
		[MaxLength(30)]
		public string Title { get; set; }
		DateTime Deadline { get; set; }
		public int WorkerId { get; set; }
		[MaxLength(500)]
		public string Description { get; set; }
		//Constructor:
		public Task() { }
	}
}
