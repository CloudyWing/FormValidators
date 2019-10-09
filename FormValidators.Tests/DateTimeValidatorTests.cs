using System;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class DateTimeValidatorTests {
        [SetUp]
        public void Setup() {
        }

        [TestCase(null, true)]
        [TestCase("", true)]
        [TestCase(" ", true)]
        [TestCase("1912/3/4", true)]
        [TestCase("1912/03/04", true)]
        [TestCase("1912/03/04 12:34", true)]
        [TestCase("1912/03/04 25:00", false)]
        [TestCase("1912/03/04 00:61", false)]
        [TestCase("1913/02/29 00:00", false)]
        [TestCase("error", false)]
        public void Validate_Format_AreEqual(string value, bool isValid) {
            DateTimeValidator validator = new DateTimeValidator("", value);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [TestCase("1912/3/2", true)]
        [TestCase("1912/3/3", true)]
        [TestCase("1912/3/1", false)]
        public void Validate_Min_AreEqual(string value, bool isValid) {
            DateTimeValidator validator = DateTimeValidator.CreateMinDateTime("", value, new DateTime(1912, 3, 2));
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [TestCase("1912/3/1", true)]
        [TestCase("1912/3/2", true)]
        [TestCase("1912/3/3", false)]
        public void Validate_Max_AreEqual(string value, bool isValid) {
            DateTimeValidator validator = DateTimeValidator.CreateMaxDateTime("", value, new DateTime(1912, 3, 2));
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [TestCase("1912/3/2", true)]
        [TestCase("1912/3/3", true)]
        [TestCase("1912/3/4", true)]
        [TestCase("1912/3/1", false)]
        [TestCase("1912/3/5", false)]
        public void Validate_Range_AreEqual(string value, bool isValid) {
            DateTimeValidator validator = new DateTimeValidator("", value, new DateTime(1912, 3, 2), new DateTime(1912, 3, 4));
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [Test]
        public void ErrorMessage_BaseFormat_AreEqual() {
            string column = "測試欄位";

            DateTimeValidator validator = new DateTimeValidator(column, "error");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.DefaultErrorMessageFormat, column),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_CustomFormat_AreEqual() {
            string column = "測試欄位";

            DateTimeValidator validator = new DateTimeValidator(column, "error", "{0}DateTime");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomErrorMessageFormat, column),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_MinFormat_AreEqual() {
            string column = "測試欄位";
            DateTime minDateTime = new DateTime(1912, 3, 5);

            DateTimeValidator validator = DateTimeValidator.CreateMinDateTime(column, "1912/03/04", minDateTime);
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.MinValueErrorMessageFormat, column, minDateTime),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_MinCustomFormat_AreEqual() {
            string column = "測試欄位";
            DateTime minDateTime = new DateTime(1912, 3, 5);

            DateTimeValidator validator = DateTimeValidator.CreateMinDateTime(column, "1912/03/04", minDateTime, customRangeMessageFormat: "{0}_{1}DateTime");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomRangeMessageFormat, column, minDateTime),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_MaxFormat_AreEqual() {
            string column = "測試欄位";
            DateTime maxDateTime = new DateTime(1912, 3, 3);

            DateTimeValidator validator = DateTimeValidator.CreateMaxDateTime(column, "1912/03/04", maxDateTime);
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.MaxValueErrorMessageFormat, column, maxDateTime),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_MaxCustomFormat_AreEqual() {
            string column = "測試欄位";
            DateTime maxDateTime = new DateTime(1912, 3, 3);

            DateTimeValidator validator = DateTimeValidator.CreateMaxDateTime(column, "1912/03/04", maxDateTime, customRangeMessageFormat: "{0}_{1}DateTime");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomRangeMessageFormat, column, maxDateTime),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_RangeFormat_AreEqual() {
            string column = "測試欄位";
            DateTime minDateTime = new DateTime(1912, 3, 5);
            DateTime maxDateTime = new DateTime(1912, 3, 3);

            DateTimeValidator validator = new DateTimeValidator(column, "1912/03/04", minDateTime, maxDateTime);
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.RangeErrorMessageFormat, column, minDateTime, maxDateTime),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_RangeCustomFormat_AreEqual() {
            string column = "測試欄位";
            DateTime minDateTime = new DateTime(1912, 3, 5);
            DateTime maxDateTime = new DateTime(1912, 3, 3);

            DateTimeValidator validator = new DateTimeValidator(column, "1912/03/04", minDateTime, maxDateTime, customRangeMessageFormat: "{0}_{1}_{2}DateTime");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomRangeMessageFormat, column, minDateTime, maxDateTime),
                validator.ErrorMessage
            );
        }
    }
}