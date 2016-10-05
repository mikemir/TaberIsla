using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depcom.TaberIsla.WinForm.Utils.Extensions
{
    public static class ValidatorExtensions
    {

        public static bool IsEmpty(this TextBoxBase txt)
        {
            var result = false;

            result = string.IsNullOrWhiteSpace(txt.Text);

            return result;
        }
        public static bool IsContentOnlyNumbers(this TextBoxBase txt, params char[] charsTosSkipped)
        {
            var result = true;

            foreach (var item in txt.Text)
            {
                if (!char.IsNumber(item) && !charsTosSkipped.Any(ch => ch == item))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public static bool LengthEquals(this TextBoxBase txt, int max)
        {
            var result = false;

            result = txt.Text.Length == max;

            return result;
        }

        public static bool IsDuiValid(this TextBoxBase txt)
        {
            var result = false;

            result = !txt.IsEmpty() && txt.IsContentOnlyNumbers('-') && txt.LengthEquals(10);

            return result;
        }

        public static bool IsTelephone(this TextBoxBase txt)
        {
            var result = false;

            result = !txt.IsEmpty() && txt.IsContentOnlyNumbers('-') && txt.LengthEquals(9);

            return result;
        }
    }
}
