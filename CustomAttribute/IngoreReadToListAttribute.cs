using System;

namespace FamilyAssistant.CustomAttribute
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class IngoreReadToListAttribute : Attribute
    {
        
    }
}