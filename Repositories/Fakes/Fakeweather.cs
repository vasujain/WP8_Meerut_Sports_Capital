// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   FakeDataSource.tt
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WPAppStudio.Entities;
using WPAppStudio.Entities.Base;
using WPAppStudio.Repositories.Base;
using WPAppStudio.Shared;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// Fake weather_Html data source.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public class Fakeweather : Iweather 
    {
		/// <summary>
        /// Retrieves the data from a fake.
        /// </summary>
        /// <returns>An observable collection of weather_Html items.</returns>
        public string Get()
        {			
            return "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        }
	}
}
