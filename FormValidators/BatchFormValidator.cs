using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CloudyWing.FormValidators {
    using Core;

    public class BatchFormValidator : Collection<IFormValidatable>, IFormValidatable {
        private readonly IList<string> errorMessages = new List<string>();

        public BatchFormValidator(bool isStoppedIfFail = false) {
            IsStoppedIfFail = isStoppedIfFail;
        }

        public BatchFormValidator(Action<ValidatorConfiguration> configure, bool isStoppedIfFail = false) {
            IsStoppedIfFail = isStoppedIfFail;
            configure(new ValidatorConfiguration(this));
        }

        /// <summary>
        /// Gets the error message, use separator br.
        /// </summary>
        /// <value>
        /// The error message.
        /// </value>
        public string ErrorMessage => ErrorMessageWithBreak;

        public string ErrorMessageWithBreak => GetErrorMessage("<br />");

        public string ErrorMessageWithNewLine => GetErrorMessage(Environment.NewLine);

        public string ErrorMessageWithLF => GetErrorMessage("\n");

        public bool IsValid { get; private set; } = false;

        public bool IsStoppedIfFail { get; }

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