using System;
using System.Collections.Generic;

namespace CloudyWing.FormValidators.Core;

/// <summary>
/// The validator configuration.
/// </summary>
public class ValidatorConfiguration {
    private readonly BulkValidator validators;
    private readonly ValidationProvider provider = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="ValidatorConfiguration" /> class.
    /// </summary>
    /// <param name="validators">The validators.</param>
    public ValidatorConfiguration(BulkValidator validators) {
        this.validators = validators;
    }

    /// <summary>
    /// Adds the validators.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="validatorCreators">The validator creators.</param>
    public void Add(
        string column, string value,
        params Func<ValidationProvider, Func<string, string, IFormValidator>>[] validatorCreators
    ) {
        AddIf(true, column, value, validatorCreators);
    }

    /// <summary>
    /// Adds the validators.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="validatorCreators">The validator creators.</param>
    public void Add(
        string column, string value,
        IEnumerable<Func<ValidationProvider, Func<string, string, IFormValidator>>> validatorCreators
    ) {
        AddIf(true, column, value, validatorCreators);
    }

    /// <summary>
    /// Adds validators if condition is <c>true</c>.
    /// </summary>
    /// <param name="condition">if set to <c>true</c> [condition].</param>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="validatorCreators">The validator creators.</param>
    public void AddIf(
       bool condition, string column, string value,
       params Func<ValidationProvider, Func<string, string, IFormValidator>>[] validatorCreators
   ) {
        AddIf(condition, column, value,
            validatorCreators as IEnumerable<Func<ValidationProvider, Func<string, string, IFormValidator>>>
        );
    }

    /// <summary>
    /// Adds validators if condition is <c>true</c>.
    /// </summary>
    /// <param name="condition"></param>
    /// <param name="column"></param>
    /// <param name="value"></param>
    /// <param name="validatorCreators"></param>
    public void AddIf(
        bool condition, string column, string value,
        IEnumerable<Func<ValidationProvider, Func<string, string, IFormValidator>>> validatorCreators
    ) {
        if (condition) {
            foreach (var function in validatorCreators) {
                validators.Add(function(provider)(column, value));
            }
        }
    }

    /// <summary>
    /// Adds the true assert validator.
    /// </summary>
    /// <param name="isTrue">if set to <c>true</c> [is true].</param>
    /// <param name="message">The message.</param>
    public void AddTrueAssert(bool isTrue, string message) {
        validators.Add(new TrueAssertValidator(isTrue, message));
    }

    /// <summary>
    /// Adds the true assert validator.
    /// </summary>
    /// <param name="truePredicate">The true predicate.</param>
    /// <param name="message">The message.</param>
    public void AddTrueAssert(Func<bool> truePredicate, string message) {
        validators.Add(new TrueAssertValidator(truePredicate, message));
    }

    /// <summary>
    /// Adds the false assert validator.
    /// </summary>
    /// <param name="isFalse">if set to <c>true</c> [is false].</param>
    /// <param name="message">The message.</param>
    public void AddFalseAssert(bool isFalse, string message) {
        validators.Add(new FalseAssertValidator(isFalse, message));
    }

    /// <summary>
    /// Adds the false assert validator.
    /// </summary>
    /// <param name="falsePredicate">The false predicate.</param>
    /// <param name="message">The message.</param>
    public void AddFalseAssert(Func<bool> falsePredicate, string message) {
        validators.Add(new FalseAssertValidator(falsePredicate, message));
    }

    /// <summary>
    /// Adds the bulk validator.
    /// </summary>
    /// <param name="configure">The configure.</param>
    /// <param name="isStoppedIfFail">if set to <c>true</c> [is stopped if fail].</param>
    public void AddBulk(Action<ValidatorConfiguration> configure, bool isStoppedIfFail = false) {
        validators.Add(new BulkValidator(configure, isStoppedIfFail));
    }
}
