using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace GsfCoffee.Localization
{
    public static class GsfCoffeeLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(GsfCoffeeConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(GsfCoffeeLocalizationConfigurer).GetAssembly(),
                        "GsfCoffee.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
