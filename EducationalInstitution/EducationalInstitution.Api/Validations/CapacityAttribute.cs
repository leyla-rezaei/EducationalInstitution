using System.ComponentModel.DataAnnotations;

public class CapacityAttribute : ValidationAttribute
{
    private readonly int _minCapacity;
    private readonly int _maxCapacity;

    public CapacityAttribute(int minCapacity, int maxCapacity)
    {
        _minCapacity = minCapacity;
        _maxCapacity = maxCapacity;
    }

    public override bool IsValid(object? value)
    {
        if (value == null)
        {
            return true;
        }

        if (!(value is string capacityString))
        {
            return false;
        }

        if (!int.TryParse(capacityString, out int capacity))
        {
            return false;
        }

        if (capacity < _minCapacity || capacity > _maxCapacity)
        {
            return false;
        }

        return true;
    }

    public override string FormatErrorMessage(string name)
    {
        return $" must be between {_minCapacity} and {_maxCapacity}.";
    }
}