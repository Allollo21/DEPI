namespace Examination_System
{
    #region Utilities Documentation
    /// <summary>
    /// Provides static methods for handling user input with type conversion and validation.
    /// </summary>
    #endregion

    public static class Utilities
    {
        #region Delegate Documentation
        /// <summary>
        /// Delegate for custom validation functions.
        /// </summary>
        /// <typeparam name="T">The type of value to validate.</typeparam>
        /// <param name="value">The value to validate.</param>
        /// <returns>True if validation passes, false otherwise.</returns>
        #endregion

        public delegate bool Validate<T>(T value);

        #region InputAndCast Documentation
        /// <summary>
        /// Prompts the user for input, converts it to the specified type T, and returns the parsed value.
        /// </summary>
        /// <typeparam name="T">The type to convert the input to (int, double, or string).</typeparam>
        /// <param name="prompt">The message displayed to the user.</param>
        /// <param name="allowEmpty">If true, allows empty input and returns defaultValue. Defaults to false.</param>
        /// <param name="defaultValue">The value returned for empty input when allowed. Defaults to default(T).</param>
        /// <returns>The parsed value of type T.</returns>
        /// <remarks>Supports int, double, and string types. Invalid inputs prompt the user to retry.</remarks>
        #endregion

        // Prompts user for input and converts it to the specified type
        public static T InputAndCast<T>(string prompt, bool allowEmpty = false, T? defaultValue = default)
        {
            while (true)
            {
                #region Step 1: Prompt User
                Console.Write(prompt);
                string? input = Console.ReadLine();
                #endregion

                #region Step 2: Handle Empty Input
                if (allowEmpty && string.IsNullOrWhiteSpace(input))
                {
                    return defaultValue!;
                }
                #endregion

                #region Step 3: Convert Input
                if (typeof(T) == typeof(int))
                {
                    if (int.TryParse(input, out int result) && !string.IsNullOrWhiteSpace(input))
                    {
                        return (T)(object)result;
                    }
                }
                else if (typeof(T) == typeof(double))
                {
                    if (double.TryParse(input, out double result) && !string.IsNullOrWhiteSpace(input))
                    {
                        return (T)(object)result;
                    }
                }
                else if (typeof(T) == typeof(string))
                {
                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        return (T)(object)input;
                    }
                }
                else
                {
                    #region Step 4: Handle Unsupported Types
                    Console.WriteLine("Invalid Data Type. Not Allowed!");
                    return defaultValue!;
                    #endregion
                }
                #endregion

                #region Step 5: Handle Invalid Input
                Console.WriteLine("Invalid input, try again.");
                #endregion
            }
        }

        #region InputWithValidation Documentation
        /// <summary>
        /// Prompts for input, applies a custom validation function, and returns the validated value.
        /// </summary>
        /// <typeparam name="T">The type to convert the input to (int, double, or string).</typeparam>
        /// <param name="prompt">The message displayed to the user.</param>
        /// <param name="validator">A delegate function to validate the input.</param>
        /// <param name="allowEmpty">If true, allows empty input and returns defaultValue. Defaults to false.</param>
        /// <param name="defaultValue">The value returned for empty input when allowed. Defaults to default(T).</param>
        /// <returns>The validated value of type T.</returns>
        /// <remarks>Uses InputAndCast&lt;T&gt; for input retrieval and applies the provided validator.</remarks>
        #endregion

        // Prompts user for input and applies custom validation
        public static T InputWithValidation<T>(string prompt, Validate<T> validator, bool allowEmpty = false, T? defaultValue = default)
        {
            while (true)
            {
                #region Step 1: Retrieve Input
                T value = InputAndCast<T>(prompt, allowEmpty, defaultValue);
                #endregion

                #region Step 2: Handle Empty Input
                if (allowEmpty && EqualityComparer<T>.Default.Equals(value, defaultValue))
                {
                    return defaultValue!;
                }
                #endregion

                #region Step 3: Apply Validation
                if (validator(value))
                {
                    return value;
                }
                #endregion

                #region Step 4: Handle Validation Failure
                Console.WriteLine("Input validation failed, try again.");
                #endregion
            }
        }
    }
}