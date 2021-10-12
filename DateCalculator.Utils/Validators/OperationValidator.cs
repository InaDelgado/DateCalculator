using DateCalculator.Utils.Exceptions;

namespace DateCalculator.Utils.Validators
{
    public static class OperationValidator
    {
        public static bool IsValid(string operation)
        {
            if (string.IsNullOrWhiteSpace(operation) || !IsValidOperation(operation))
                throw new InvalidInputOperationException();

            return true;
        }

        private static bool IsValidOperation(string operation)
        => (operation.ToLower().Equals(ConstsUtils.INCREASE) || operation.ToLower().Equals(ConstsUtils.DECREASE));
    }
}
