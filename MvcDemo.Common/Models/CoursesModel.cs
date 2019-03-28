using System.Collections.Generic;

namespace MvcDemo.Common.Models
{
    public class CoursesModel
    {
        public IEnumerable<CoursePortalModel> Courses { get; set; }
        public PortalModel Client { get; set; }
    }
}
