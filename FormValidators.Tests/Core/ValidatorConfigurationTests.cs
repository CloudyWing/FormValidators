using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Core.Tests {
    [TestFixture()]
    public class ValidatorConfigurationTests {
        private BulkValidator validators;
        private ValidatorConfiguration config;

        [SetUp]
        public void SetUp() {
            validators = new BulkValidator();
            config = new ValidatorConfiguration(validators);
        }

        [Test()]
        public void Add_Bulk_Result() {
            BulkValidator expected = new BulkValidator() {
                new RequiredValidator("Column1", "Value1"),
                new DateTimeValidator("Column1", "Value1"),
                new RequiredValidator("Column2", "Value2"),
                new RequiredValidator("Column1", "Value3"),
                new DateTimeValidator("Column3", "Value3")
            };
            expected.Validate();

            config.Add("Column1", "Value1", opt => opt.Required(), opt => opt.DateTime());
            config.Add("Column2", "Value2", opt => opt.Required());

            var funcs = new List<Func<ValidationProvider, Func<string, string, IFormValidator>>> {
                opt => opt.Required(),
                opt => opt.DateTime()
            };

            config.Add("Column3", "Value3", funcs);
            validators.Validate();

            Assert.AreEqual(expected.IsValid, validators.IsValid);
            Assert.AreEqual(expected.ErrorMessage, validators.ErrorMessage);
            Assert.That(validators, Has.Count.EqualTo(expected.Count));
        }

        [Test()]
        public void AddIf_ConditionIsTrue_Count() {
            const string message = "TestAddIfTrue";
            const string column = "欄位";

            config.AddIf(true, column, null, opt => opt.Required(message));

            Assert.AreEqual(validators.Count, 1);
        }

        [Test()]
        public void AddIf_ConditionIsFalse_Count() {
            const string message = "TestAddIfFalse";
            const string column = "欄位";

            config.AddIf(false, column, null, opt => opt.Required(message));

            Assert.AreEqual(validators.Count, 0);
        }

        [Test()]
        public void Add_TrueAssert_Result() {
            const string message = "TestTrueAssert";
            BulkValidator expected = new BulkValidator() {
                new TrueAssertValidator(false, message)
            };

            config.AddTrueAssert(false, message);

            Assert.AreEqual(expected.IsValid, validators.IsValid);
            Assert.AreEqual(expected.ErrorMessage, validators.ErrorMessage);
            Assert.That(validators, Has.Count.EqualTo(expected.Count));
        }

        [Test()]
        public void Add_FalseAssert_Result() {
            const string message = "TestFalseAssert";
            BulkValidator expected = new BulkValidator() {
                new FalseAssertValidator(false, message)
            };

            config.AddFalseAssert(true, message);

            Assert.AreEqual(expected.IsValid, validators.IsValid);
            Assert.AreEqual(expected.ErrorMessage, validators.ErrorMessage);
            Assert.That(validators, Has.Count.EqualTo(expected.Count));
        }
    }
}