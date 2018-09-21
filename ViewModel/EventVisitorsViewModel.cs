using System.Collections.Generic;
using EventPlaining.Models;

namespace EventPlaining.ViewModel
{
    public class EventVisitorsViewModel
    {
        public Event Events { get; set; }
        public IEnumerable<NotSubmitedVisitor> NotSubmitedVisitors { get; set; }
        
        
    }
}