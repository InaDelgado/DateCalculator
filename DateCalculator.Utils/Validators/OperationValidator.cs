namespace DateCalculator.Utils.Validators
{
    public static class OperationValidator
    {
        public static bool IsValid(string operation)
        => !string.IsNullOrWhiteSpace(operation) && IsIncreaseDecreaseOperation(operation);

        private static bool IsIncreaseDecreaseOperation(string operation)
        => (operation.Equals(ConstsUtils.INCREASE) || operation.Equals(ConstsUtils.DECREASE));
    }
}
