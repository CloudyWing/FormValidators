using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CloudyWing.FormValidators {
    public class BatchFormValidator : Collection<IFormValidatable>, IFormValidatable {
        public BatchFormValidator(bool isStoppedIfFail = false) {
            IsStoppedIfFail = isStoppedIfFail;
        }

        private IList<string> errorMessages = new List<string>();

        /// <summary>
        /// Gets the error message, use separator br.
        /// </summary>
        /// <value>
        /// The error message.
        /// </value>
        public string ErrorMessage => ErrorMessageWithBR;

        public string ErrorMessageWithBR => GetErrorMessage("<br />");

        public string ErrorMessageWithNewLine => GetErrorMessage(Environment.NewLine);

        public string ErrorMessageWithLF => GetErrorMessage("\n");

        public bool IsValid { get; private set; } = false;

        public bool IsStoppedIfFail { get; private set; }

        public bool Validate() {
            errorMessages.Clear();

            foreach (IFormValidatable item in Items) {
                if (!item.Validate()) {
                    errorMessages.Add(item.ErrorMessage);
                    if (IsStoppedIfFail) {
                        break;
                    }
                }
            }
            IsValid = !errorMessages.Any();

            return IsValid;
        }

        private string GetErrorMessage(string separator) => string.Join(separator, errorMessages);
    }
}
