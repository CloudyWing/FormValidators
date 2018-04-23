using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CloudyWing.FormValidators {

    public class FormValidatorCollection : Collection<IFormValidatable>, IFormValidatable {

        private IList<string> errorMessages = new List<string>();
        private bool isValid;

        /// <summary>
        /// Gets the error message, use separator br.
        /// </summary>
        /// <value>
        /// The error message.
        /// </value>
        public string ErrorMessage => ErrorMessageWithBR;

        public bool IsValid => isValid;

        public string ErrorMessageWithBR => GetErrorMessage("<br />");

        public string ErrorMessageWithNewLine => GetErrorMessage(Environment.NewLine);

        public string ErrorMessageWithLF => GetErrorMessage("\n");

        public bool Validate() {
            errorMessages.Clear();

            foreach (IFormValidatable item in Items) {
                if (!item.Validate()) {
                    errorMessages.Add(item.ErrorMessage);
                }
            }
            isValid = !errorMessages.Any();

            return isValid;
        }

        public string GetErrorMessage(string separator) => string.Join(separator, errorMessages);
    }
}
