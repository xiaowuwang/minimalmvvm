using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMinimalMVVM.Model
{
    class TextConverterModel
    {
        private readonly Func<string, string> _convertion;

        public TextConverterModel(Func<string, string> convertion)
        {
            _convertion = convertion;
        }

        public string ConvertText(string inputText)
        {
            return _convertion(inputText);
        }
    }
}
