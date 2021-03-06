﻿using System;
using System.Collections.Generic;

namespace CloudyWing.FormValidators.Core {
    public class ValidatorConfiguration {
        private readonly BulkValidator validators;
        private readonly ValidationProvider provider = new ValidationProvider();

        public ValidatorConfiguration(BulkValidator validators) {
            this.validators = validators;
        }

        public void Add(
            string column, string value,
            params Func<ValidationProvider, Func<string, string, IFormValidator>>[] validationFunctions
        ) {
            AddIf(true, column, value, validationFunctions);
        }

        public void Add(
            string column, string value,
            IEnumerable<Func<ValidationProvider, Func<string, string, IFormValidator>>> validationFunctions
        ) {
            AddIf(true, column, value, validationFunctions);
        }

        public void AddIf(
           bool condition, string column, string value,
           params Func<ValidationProvider, Func<string, string, IFormValidator>>[] validationFunctions
       ) {
            AddIf(condition, column, value,
                validationFunctions as IEnumerable<Func<ValidationProvider, Func<string, string, IFormValidator>>>
            );
        }

        public void AddIf(
            bool condition, string column, string value,
            IEnumerable<Func<ValidationProvider, Func<string, string, IFormValidator>>> validationFunctions
        ) {
            if (condition) {
                foreach (var function in validationFunctions) {
                    validators.Add(function(provider)(column, value));
                }
            }
        }

        public void AddTrueAssert(bool isTrue, string message)
            => validators.Add(new TrueAssertValidator(isTrue, message));

        public void AddTrueAssert(Func<bool> truePredicate, string message)
            => validators.Add(new TrueAssertValidator(truePredicate, message));

        public void AddFalseAssert(bool isFalse, string message)
            => validators.Add(new FalseAssertValidator(isFalse, message));

        public void AddFalseAssert(Func<bool> falsePredicate, string message)
            => validators.Add(new FalseAssertValidator(falsePredicate, message));

        public void AddBulk(Action<ValidatorConfiguration> configure, bool isStoppedIfFail = false)
            => validators.Add(new BulkValidator(configure, isStoppedIfFail));
    }
}