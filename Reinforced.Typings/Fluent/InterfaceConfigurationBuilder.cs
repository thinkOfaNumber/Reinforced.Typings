﻿using Reinforced.Typings.Attributes;
using Reinforced.Typings.Fluent.Interfaces;

namespace Reinforced.Typings.Fluent
{
    /// <summary>
    ///     Configuration builder for interface
    /// </summary>
    /// <typeparam name="TInterface"></typeparam>
    public class InterfaceConfigurationBuilder<TInterface> : TypeConfigurationBuilder<TInterface>,
        IInterfaceConfigurationBuilder
    {
        internal InterfaceConfigurationBuilder()
        {
            AttributePrototype = new TsInterfaceAttribute
            {
                AutoExportProperties = false,
                AutoExportMethods = false
            };
        }

        private TsInterfaceAttribute AttributePrototype { get; set; }

        TsInterfaceAttribute IExportConfiguration<TsInterfaceAttribute>.AttributePrototype
        {
            get { return AttributePrototype; }
        }
    }
}