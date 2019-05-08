using GoodsStore.Core.Interfaces.AppInfrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;


namespace GoodsStore.Core.AppInfrastructure
{
    public class GoodsStoreTypeFinder : ITypeFinder
    {
        #region Propeties

        public string AssemblySkipLoadingPattern { get; set; } = "^System|^mscorlib|^Microsoft|^AjaxControlToolkit|^Antlr3|^Autofac|^AutoMapper|^Castle|^ComponentArt|^CppCodeProvider|^DotNetOpenAuth|^EntityFramework|^EPPlus|^FluentValidation|^ImageResizer|^itextsharp|^log4net|^MaxMind|^MbUnit|^MiniProfiler|^Mono.Math|^MvcContrib|^Newtonsoft|^NHibernate|^nunit|^Org.Mentalis|^PerlRegex|^QuickGraph|^Recaptcha|^Remotion|^RestSharp|^Rhino|^Telerik|^Iesi|^TestDriven|^TestFu|^UserAgentStringLibrary|^VJSharpCodeProvider|^WebActivator|^WebDev|^WebGrease";


        #endregion

        #region implementation of ITypeFinder
        public IEnumerable<Type> FindClassesOfType<T>()
        {
            return FindClassesOfType(typeof(T));
        }

        public IEnumerable<Type> FindClassesOfType(Type assignTypeFrom)
        {
            var assemblies = GetAssemblies();
            var result = new List<Type>();
            try
            {
                foreach (var a in assemblies)
                {
                    Type[] types = null;
                    types = a.GetTypes();

                    if (types == null)
                    {
                        continue;
                    }

                    foreach (var t in types)
                    {
                        if (!assignTypeFrom.IsAssignableFrom(t) && (!assignTypeFrom.IsGenericTypeDefinition || !DoesTypeImplementOpenGeneric(t, assignTypeFrom)))
                        {
                            continue;
                        }

                        if (t.IsInterface)
                        {
                            continue;
                        }

                        result.Add(t);
                    }
                }
            }
            catch (ReflectionTypeLoadException ex)
            {
                var msg = string.Empty;
                foreach (var e in ex.LoaderExceptions)
                {
                    msg += e.Message + Environment.NewLine;
                }

                var fail = new Exception(msg, ex);
                Debug.WriteLine(fail.Message, fail);

                throw fail;
            }
            return result;
        }

        public IList<Assembly> GetAssemblies()
        {
            var appPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            return Directory.GetFiles(appPath).Where(el => new FileInfo(el).Extension == ".dll")
                .Select(Assembly.LoadFrom).Where(a => !Matches(a.FullName)).ToList();
        }
        #endregion

        #region Utilities
        protected virtual bool Matches(string assemblyFullName)
        {
            return Regex.IsMatch(assemblyFullName, AssemblySkipLoadingPattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
        }

        protected virtual bool DoesTypeImplementOpenGeneric(Type type, Type openGeneric)
        {
            try
            {
                var genericTypeDefinition = openGeneric.GetGenericTypeDefinition();
                foreach (var implementedInterface in type.FindInterfaces((objType, objCriteria) => true, null))
                {
                    if (!implementedInterface.IsGenericType)
                        continue;

                    var isMatch = genericTypeDefinition.IsAssignableFrom(implementedInterface.GetGenericTypeDefinition());
                    return isMatch;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}