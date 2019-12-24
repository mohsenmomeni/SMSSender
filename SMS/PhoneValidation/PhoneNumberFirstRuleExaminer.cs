using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SMS.PhoneValidation
{
    public class PhoneNumberFirstRuleExaminer
    {
        private List<IPhoneNumberRule> rules = new List<IPhoneNumberRule>();
        public PhoneNumberFirstRuleExaminer()
        {
            var phoneNumberRules = 
                FindDerivedTypes(Assembly.GetExecutingAssembly(), typeof(IPhoneNumberRule));
            foreach (var item in phoneNumberRules)
            {
                rules.Add((IPhoneNumberRule)Activator.CreateInstance(item));
            }
        }

        public IEnumerable<Type> FindDerivedTypes(Assembly assembly, Type baseType)
        {
            return assembly.GetTypes().Where(t => t != baseType &&
                                                  baseType.IsAssignableFrom(t));
        }

        public string ApplyRules(string phoneNumber)
        {
            foreach (var item in rules)
            {
                if (item.IsApplyable(phoneNumber))
                {
                    return item.RefineNumber(phoneNumber);
                }
            }
            return phoneNumber;
        }
    }
}
