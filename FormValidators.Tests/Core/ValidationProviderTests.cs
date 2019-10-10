﻿using System;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Core.Tests {
    [TestFixture()]
    public class ValidationProviderTests {
        private ValidationProvider provider;

        [SetUp]
        public void Setup() {
            provider = new ValidationProvider();
        }

        [Test()]
        public void Required_Message_AreEqual() {
            const string column = "Required";
            const string message = "測試{0}";

            IFormValidatable validator = provider.Required(message)(column, null);
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, string.Format(message, column));
        }

        [Test()]
        public void Integer_Message_AreEqual() {
            const string column = "Integer";
            const string message = "測試{0}";

            IFormValidatable validator = provider.Integer(message)(column, "N/A");
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, string.Format(message, column));
        }

        [Test()]
        public void MinInt_Message_AreEqual() {
            const string column = "MinInt";
            const string message = "測試{0}{1}";
            const int min = 3;

            IFormValidatable validator = provider.MinInt(min, message)(column, "2");
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, string.Format(message, column, min));
        }

        [Test()]
        public void MaxInt_Message_AreEqual() {
            const string column = "MaxInt";
            const string message = "測試{0}{1}";
            const int max = 3;

            IFormValidatable validator = provider.MaxInt(max, message)(column, "4");
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, string.Format(message, column, max));
        }

        [Test()]
        public void IntRange_Message_AreEqual() {
            const string column = "IntRange";
            const string message = "測試{0}{1}{2}";
            const int min = 2;
            const int max = 4;

            IFormValidatable validator = provider.IntRange(min, max, message)(column, "1");
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, string.Format(message, column, min, max));
        }

        [Test()]
        public void DateTime_Message_AreEqual() {
            const string column = "DateTime";
            const string message = "測試{0}";

            IFormValidatable validator = provider.DateTime(message)(column, "NotDateTime");
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, string.Format(message, column));
        }

        [Test()]
        public void MinDateTime_Message_AreEqual() {
            const string column = "MinDateTime";
            const string message = "測試{0}{1}";
            DateTime min = DateTime.Today;

            IFormValidatable validator = provider.MinDateTime(min, message)(column, min.AddDays(-1).ToString("yyyy/MM/dd"));
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, string.Format(message, column, min));
        }

        [Test()]
        public void MaxDateTime_Message_AreEqual() {
            const string column = "MaxDateTime";
            const string message = "測試{0}{1}";
            DateTime max = DateTime.Today;

            IFormValidatable validator = provider.MaxDateTime(max, message)(column, max.AddDays(1).ToString("yyyy/MM/dd"));
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, string.Format(message, column, max));
        }

        [Test()]
        public void DateTimeRange_Message_AreEqual() {
            const string column = "DateTimeRange";
            const string message = "測試{0}{1}{2}";
            DateTime min = DateTime.Today.AddDays(-1);
            DateTime max = DateTime.Today.AddDays(1);

            IFormValidatable validator = provider.DateTimeRange(min, max, message)(column, max.AddDays(1).ToString("yyyy/MM/dd"));
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, string.Format(message, column, min, max));
        }

        [Test()]
        public void Regex_Message_AreEqual() {
            const string column = "Regex";
            const string message = "測試{0}";

            IFormValidatable validator = provider.Regex(@"\d", message)(column, "a");
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, string.Format(message, column));
        }

        [Test()]
        public void Email_Message_AreEqual() {
            const string column = "Email";
            const string message = "測試{0}";

            IFormValidatable validator = provider.Email(message)(column, "NotEmail");
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, string.Format(message, column));
        }

        [Test()]
        public void MobilePhone_Message_AreEqual() {
            const string column = "MobilePhone";
            const string message = "測試{0}";

            IFormValidatable validator = provider.MobilePhone(message)(column, "NotPhone");
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, string.Format(message, column));
        }

        [Test()]
        public void IdCard_Message_AreEqual() {
            const string column = "IdCard";
            const string message = "測試{0}";

            IFormValidatable validator = provider.IdCard(IdCardTypes.All, message)(column, "NotIdCard");
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, string.Format(message, column));
        }

        [Test()]
        public void Compare_Message_AreEqual() {
            const string column = "Compare";
            const string message = "測試{0}";

            IFormValidatable validator = provider.Compare("123", message)(column, "321");
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, string.Format(message, column));
        }
    }
}