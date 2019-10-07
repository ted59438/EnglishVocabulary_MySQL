using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnglishVocabularyLearning
{
    public class ParameterOBJ
    {
        public string name;
        public object value;

        public ParameterOBJ(string  name, object value)
        {
            this.name = name;
            this.value = value;            
        }
    }
}
