using System.Linq;
using System.Reflection;
using System.Text;


using System;

class HarvestingFieldsTest
{
    static void Main(string[] args)
    {
        var sbResult = new StringBuilder();
        var harvestingFields = typeof(HarvestingFields);
        while (true)
        {
            var command = Console.ReadLine();
            if (command == "HARVEST")
            {
                break;
            }
            if (command == "private")
            {
                var allFields = harvestingFields.GetFields(
                        BindingFlags.NonPublic |
                        BindingFlags.Instance);
                foreach (var field in allFields.Where(x => x.IsPrivate))
                {
                    sbResult.Append($"{Environment.NewLine}private {field.FieldType.ToString().Split('.').Last()} {field.Name}");
                }
            }
            else if (command == "protected")
            {
                var allFields = harvestingFields.GetFields(
                    BindingFlags.NonPublic |
                    BindingFlags.Instance);
                foreach (var field in allFields.Where(x => !x.IsPrivate))
                {
                    sbResult.Append($"{Environment.NewLine}protected {field.FieldType.ToString().Split('.').Last()} {field.Name}");
                }
            }
            else if (command == "public")
            {
                var allFields = harvestingFields.GetFields();
                foreach (var field in allFields)
                {
                    sbResult.Append($"{Environment.NewLine}public {field.FieldType.ToString().Split('.').Last()} {field.Name}");
                }
            }
            else
            {
                var allFields = harvestingFields.GetFields(
                        BindingFlags.Public |
                        BindingFlags.NonPublic |
                        BindingFlags.Instance);
                foreach (var field in allFields)
                {
                    sbResult.Append($"{Environment.NewLine}{GetAccessModifierByFieldInfo(field)} {field.FieldType.ToString().Split('.').Last()} {field.Name}");
                }
            }
        }
        Console.WriteLine(sbResult);
    }
    public static string GetAccessModifierByFieldInfo(FieldInfo field)
    {
        if (field.IsPrivate)
        {
            return "private";
        }
        else if (field.IsFamily)
        {
            return "protected";
        }
        else
        {
            return "public";
        }
    }
}

