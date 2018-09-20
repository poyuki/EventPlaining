using System.Collections.Generic;
using EventPlaining.Models;

namespace EventPlaining.ViewModel
{
    public class IndexViewModel
    {
        public IEnumerable<Event> Events { get; set; }
    }
}