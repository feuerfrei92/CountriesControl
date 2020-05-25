using System;
using System.ComponentModel.Composition;
using System.Linq;
using System.Reflection;
using SimpleInjector.Advanced;

class ImportPropertySelectionBehavior : IPropertySelectionBehavior
{
    public bool SelectProperty(Type implementationType, PropertyInfo prop)
    {
        return prop.GetCustomAttributes(typeof(ImportAttribute)).Any();
    }
}
