using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators {
    /// <summary>
    /// The bulk validator.
    /// </summary>
    public class BulkValidator : Collection<IFormValidator>, IFormValidator {
        private readonly IList<string> errorMessages = new List<string>();

        /// <summary>Initializes a new instance of the <see cref="BulkValidator" /> class.</summary>
        /// <param name="isStoppedIfFail">if set to <c>true</c> [is stopped if fail].</param>
        public BulkValidator(bool isStoppedIfFail = false) {
            IsStoppedIfFail = isStoppedIfFail;
        }

        /// <summary>Initializes a new instance of the <see cref="BulkValidator" /> class.</summary>
        /// <param name="configure">The configure.</param>
        /// <param name="isStoppedIfFail">if set to <c>true</c> [is stopped if fail].</param>
        public BulkValidator(Action<ValidatorConfiguration> configure, bool isStoppedIfFail = false) {
            IsStoppedIfFail = isStoppedIfFail;
            configure(new ValidatorConfiguration(this));
        }

        /// <summary>Gets the error message, separated by br.</summary>
        /// <value>The error message.</value>
        public string ErrorMessage => ErrorMessageWithBreak;

        /// <summary>Gets the error message, separated by br.</summary>
        /// <value>The error message separated by br.</value>
        public string ErrorMessageWithBreak => GetErrorMessage("<br />");

        /// <summary>Gets the error message, separated by newlines.</summary>
        /// <value>The error message separated by new line.</value>
        public string ErrorMessageWithNewLine => GetErrorMessage(Environment.NewLine);

        /// <summary>Gets the error message, separated by <c>\n</c>.</summary>
        /// <value>The error message separated by <c>\n</c>.</value>
        public string ErrorMessageWithLF => GetErrorMessage("\n");

        /// <summary>Gets the error messages.</summary>
        /// <value>The error messages.</value>
        public IReadOnlyCollection<string> ErrorMessages => new ReadOnlyCollection<string>(errorMessages);

        /// <summary>Returns true if ... is valid.</summary>
        /// <value>
        ///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public bool IsValid { get; private set; } = false;

        /// <summary>Gets a value indicating whether this instance is stopped if fail.</summary>
        /// <value>
        ///   <c>true</c> if this instance is stopped if fail; otherwise, <c>false</c>.</value>
        public bool IsStoppedIfFail { get; }

        /// <inheritdoc/>
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

        private string GetErrorMessage(string separator) {
            return string.Join(separator, errorMessages);
        }
    }
}
