using DateCalculator.Models;

namespace DateCalculator.System
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
        => (operation.ToLower().Equals(Consts.INCREASE) || operation.ToLower().Equals(Consts.DECREASE));
    }
}
