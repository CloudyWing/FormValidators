using System;
using System.Collections.Generic;
using CloudyWing.FormValidators.Core;
using FluentAssertions;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests.Core {
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

            validators.IsValid.Should().Be(expected.IsValid);
            validators.ErrorMessage.Should().Be(expected.ErrorMessage);
            validators.Count.Should().Be(expected.Count);
        }

        [Test()]
        public void AddIf_ConditionIsTrue_Count() {
            string message = "TestAddIfTrue";
            string column = "欄位";

            config.AddIf(true, column, null, opt => opt.Required(message));

            validators.Count.Should().Be(1);
        }

        [Test()]
        public void AddIf_ConditionIsFalse_Count() {
            string message = "TestAddIfFalse";
            string column = "欄位";

            config.AddIf(false, column, null, opt => opt.Required(message));

            validators.Count.Should().Be(0);
        }

        [Test()]
        public void AddTrueAssert_Result() {
            string message = "TestTrueAssert";
            BulkValidator expected = new BulkValidator() {
                new TrueAssertValidator(false, message)
            };

            config.AddTrueAssert(false, message);

            validators.IsValid.Should().Be(expected.IsValid);
            validators.ErrorMessage.Should().Be(expected.ErrorMessage);
            validators.Count.Should().Be(expected.Count);
        }

        [Test()]
        public void AddFalseAssert_Result() {
            string message = "TestFalseAssert";
            BulkValidator expected = new BulkValidator() {
                new FalseAssertValidator(false, message)
            };

            config.AddFalseAssert(true, message);

            validators.IsValid.Should().Be(expected.IsValid);
            validators.ErrorMessage.Should().Be(expected.ErrorMessage);
            validators.Count.Should().Be(expected.Count);
        }

        [Test()]
        public void AddBulk_Result() {
            BulkValidator expected = new BulkValidator {
                new BulkValidator(cfg => {
                    cfg.Add("Column1", "Value1", opt => opt.Required(), opt => opt.DateTime());
                    cfg.Add("Column2", "Value2", opt => opt.Required());
                })
            };
            expected.Validate();

            config.AddBulk(cfg => {
                cfg.Add("Column1", "Value1", opt => opt.Required(), opt => opt.DateTime());
                cfg.Add("Column2", "Value2", opt => opt.Required());
            });
            validators.Validate();

            validators.IsValid.Should().Be(expected.IsValid);
            validators.ErrorMessage.Should().Be(expected.ErrorMessage);
            validators.Count.Should().Be(expected.Count);
        }
    }
}
