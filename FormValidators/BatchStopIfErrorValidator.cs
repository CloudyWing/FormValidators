using System.Collections.ObjectModel;

namespace CloudyWing.FormValidators {

    public class BatchStopIfErrorValidator : Collection<IFormValidatable>, IFormValidatable {

        /// <summary>
        /// Gets the error message, use separator br.
        /// </summary>
        /// <value>
        /// The error message.
        /// </value>
        public string ErrorMessage { get; private set; }

        public bool IsValid { get; private set; }

        public bool Validate() {
            ErrorMessage = "";
            IsValid = true;

            foreach (IFormValidatable item in Items) {
                if (!item.Validate()) {
                    ErrorMessage = item.ErrorMessage;
                    IsValid = false;
                    break;
                }
            }

            return IsValid;
        }
    }
}
