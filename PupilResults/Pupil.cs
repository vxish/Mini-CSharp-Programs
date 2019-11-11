using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PupilResults
{
    class Pupil
    {
        public string Name { get; }

        private int science;
        
        

        public int Science
        {
            get { return science; }

            set {  

                if (value <0 || value > 100)
                {
                    throw new FormatException(value + " Not vaild % for Science");
                }
                    science = value;
                }
        }

        private int maths;
        public int Maths
        {
            get { return maths; }

            set {
                if (value < 0 || value > 100)
                {
                    throw new FormatException(value + " Not vaild % for Maths");
                }
                maths = value;
                }
        }

        private int english;
        public int English
        {
            get { return english; }

            set {
                if (value < 0 || value > 100)
                {
                    throw new FormatException(value + " Not vaild % for English");
                }
                english = value; }
        }

        public double Average
        {
            get
            {
                return (Science + Maths + English) / 3.0;
            }
        }

        public Pupil (string name, int science, int maths, int english)
        {
            Name = name;
            Maths = maths;
            English = english;
            Science = science;
        }

        public Pupil (string name)
        {
            Name = name;
            Maths = 0;
            English = 0;
            Science = 0;

        }
        public string ToString()
        {
            return "Science: " + Science + "\nMaths: " + Maths +
           "\nEnglish: " + English + "\nAverage: " + Average;

        }

    }
}

