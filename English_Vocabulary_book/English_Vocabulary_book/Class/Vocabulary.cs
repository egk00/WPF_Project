using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace English_Vocabulary_book.Class
{
    public class Vocabulary
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Word{ get; set; }

        [MaxLength(50)]
        public string PartsOfSpeech { get; set; }

        [MaxLength(50)]
        public string Mean { get; set; }
    }
}
