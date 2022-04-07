using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBuster_DesignPattern
{
    public class Movie
    {
        private string _title { get; set; }
        private List<string> _scenes { get; set; } = new List<string>();
        private List<string> _validFormats { get; set; }

        public Movie(string title, List<string> scenes, List<string> validFormats)
        {
            _scenes = scenes;
            _validFormats = validFormats;
            _title = title;
        }

        public List<string> GetScenes()
        {
            return _scenes;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string ShowFormats()
        {
            return string.Join(", ", _validFormats);
        }

        public bool HasFormat(string format)
        {

            if (_validFormats.Contains(format.ToUpper()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
