using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotesExamesApp
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } // Correspond à "name" dans le fichier CSV
        public int TeacherId { get; set; } // Correspond à "teacher_id"

        public Subject(int id, string name, int teacherId)
        {
            Id = id;
            Name = name;
            TeacherId = teacherId;
        }

        public override string ToString()
        {
            return $"{Id},{Name},{TeacherId}";
        }
    }
}
