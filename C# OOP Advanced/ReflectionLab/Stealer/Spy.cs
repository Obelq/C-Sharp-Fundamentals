using System;
using System.Linq;
using System.Reflection;
using System.Text;


public class Spy
{
    public string StealFieldInfo(string className, params string[] fieldNames)
    {
        var sbResult = new StringBuilder($"Class under investigation: {className}");
        var type = Type.GetType(className);
        var classFields = type.GetFields(BindingFlags.Instance |
                                         BindingFlags.NonPublic |
                                         BindingFlags.Public |
                                         BindingFlags.Static);

        var classInstance = Activator.CreateInstance(type, new object[]{});

        foreach (var field in classFields.Where(f => fieldNames.Contains(f.Name)))
        {
            sbResult.Append($"{Environment.NewLine}{field.Name} = {field.GetValue(classInstance)}");
        }

        return sbResult.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        var sbResult = new StringBuilder();
        var typeOfClass = Type.GetType(className);
        var publicFields = typeOfClass.GetFields();

        foreach (var field in publicFields)
        {
            sbResult.Append($"{field.Name} must be private!{Environment.NewLine}");
        }

        var nonPublicGetters = typeOfClass.GetMethods(BindingFlags.Instance |
                                                     BindingFlags.NonPublic);
        foreach (var method in nonPublicGetters.Where(x => x.Name.Contains("get")))
        {
            sbResult.Append($"{method.Name} have to be public!{Environment.NewLine}");
        }

        var publicSetters = typeOfClass.GetMethods();

        foreach (var method in publicSetters.Where(x => x.Name.Contains("set")))
        {
            sbResult.Append($"{method.Name} have to be private!{Environment.NewLine}");
        }

        return sbResult.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        var typeOfClass = Type.GetType(className);
        var privateMethods = typeOfClass.GetMethods(BindingFlags.Instance |
                                                    BindingFlags.NonPublic);
        var sbResult = new StringBuilder($"All Private Methods of Class: {className}");
        sbResult.Append($"{Environment.NewLine}Base Class: {typeOfClass.BaseType.Name}");
        foreach (var privateMethod in privateMethods)
        {
            sbResult.Append($"{Environment.NewLine}{privateMethod.Name}");
        }
        return sbResult.ToString().Trim();
    }

    public string CollectGettersAndSetters(string className)
    {
        var sbResult = new StringBuilder();

        var classType = Type.GetType(className);

        var methods = classType.GetMethods(BindingFlags.Instance |
                                           BindingFlags.NonPublic|
                                           BindingFlags.Public);

        foreach (var getter in methods.Where(x => x.Name.Contains("get")))
        {
            sbResult.Append($"{Environment.NewLine}{getter.Name} will return {getter.ReturnType}");
        }
        foreach (var setter in methods.Where(x => x.Name.Contains("set")))
        {
            sbResult.Append($"{Environment.NewLine}{setter.Name} will set field of {setter.GetParameters().First().ParameterType}");
        }
        return sbResult.ToString();
    }
}
