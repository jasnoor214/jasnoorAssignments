using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstefdemo.Models
{
   class course
    {
       public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public CourseLevel level {  get; set; }

        public List<student> Students { get; set; }

        public author Author { get; set; }

        public int AuthorId {  get; set; }

    }
public enum CourseLevel
    {
        Beginner=1,
        Average=2,
        Difficult=3
    }

}
