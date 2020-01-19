using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CloudyWing.FormValidators {
    using Core;

    public class BulkValidator : Collection<IFormValidator>, IFormValidator {
        private readonly IList<string> errorMessages = new List<string>();

        public BulkValidator(bool isStoppedIfFail = false) {
            IsStoppedIfFail = isStoppedIfFail;
        }

        public BulkValidator(Action<ValidatorConfiguration> configure, bool isStoppedIfFail = false) {
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

        public IReadOnlyCollection<string> ErrorMessages => new ReadOnlyCollection<string>(errorMessages);

        public bool IsValid { get; private set; } = false;

        public bool IsStoppedIfFail { get; }

        public bool Validate() {
            errorMessages.Clear();

            foreach (IFormValidator item in Items) {
                if (!item.Validate()) {
                    if (item is BulkValidator innerItems) {
                        foreach (var _message in innerItems.ErrorMessages) {
                            errorMessages.Add(_message);
                        }
                    } else {
                        errorMessages.Add(item.ErrorMessage);
                    }
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