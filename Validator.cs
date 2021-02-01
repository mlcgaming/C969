using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969 {
    public static class Validator {
        #region Common Functions
        /// <summary>
        /// Tests if the control's Text is empty or only whitespace. Returns TRUE if only whitespace or empty. Returns FALSE if other text is present
        /// </summary>
        /// <param name="control">Control to test TEXT value</param>
        /// <returns></returns>
        public static bool IsControlEmptyOrWhitespace(Control control) {
            string entry = control.Text;

            if(entry.Replace(" ", "").Length > 0) {
                return false;
            }
            else {
                return true;
            }
        }
        /// <summary>
        /// Checks supplied string for special characters.
        /// </summary>
        /// <param name="text">String of text to check for special characters</param>
        /// <returns>TRUE if NO special characters are found. FALSE if ANY special characters are found.</returns>
        public static bool IsTextFreeOfSpecialCharacters(string text) {
            // Test to make sure name doesn't contain numbers and special characters
            char[] invalidChars = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '!', '?', '>', '<', '/', '\\',
                    '@', '#', '$', '%', '^', '&', '*', '(', ')', '{', '}', '|', '[', ']', '\'', '"', ';', ':', ',', '.' };

            for(int i = 0; i < invalidChars.Length; i++) {
                if(text.Contains(invalidChars[i])) {
                    return false;
                }
            }

            return true;
        }
        #endregion
    }
}
