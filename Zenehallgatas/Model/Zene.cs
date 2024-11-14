using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenehallgatas.Model
{
    public class Zene
    {
        private int id;
        private string title;
        private string performer;
        private int releaseDate;
        private int length;
        private int priority;

        public Zene()
        {
            this.id = -1;
            this.title = String.Empty;
            this.performer= String.Empty;
            this.releaseDate = -1;
            this.length = 0;
            this.priority = 0;
        }

        public Zene(int id,string title, string performer, int releaseDate,int length, int priority)
        {
            this.id = id;
            this.title = title;
            this.performer = performer;
            this.releaseDate = releaseDate;
            this.length = length;
            this.priority = priority;
        }

        public object[] toGridView()
        {
            return new object[] {
                id.ToString(),
                title,
                performer,
                releaseDate,
                length.ToString(),
                priority.ToString()
            };
        }

        override
        public string ToString()
        {
            return id.ToString() + " "+title+" "+performer+" "+releaseDate+" "+length.ToString()+" "+priority.ToString();
        }

        public int Id { get { return id; } }
        public string Title { get => title; set => title = value; }
        public string Performer { get => performer; set => performer = value; }
        public int ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public int Length { get => length; set => length = value; }
        public int Priority { get => priority; set => priority = value; }

    }
}
