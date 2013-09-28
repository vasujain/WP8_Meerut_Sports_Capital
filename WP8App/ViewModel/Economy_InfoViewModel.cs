// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ViewModel.tt
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using WPAppStudio;
using WPAppStudio.Controls;
using WPAppStudio.Entities;
using WPAppStudio.Entities.Base;
using WPAppStudio.Localization;
using WPAppStudio.Repositories;
using WPAppStudio.Services;
using WPAppStudio.Services.Interfaces;
using WPAppStudio.Shared;
using WPAppStudio.ViewModel.Base;
using WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of Economy_Info ViewModel.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public partial class Economy_InfoViewModel : BindableBase, IEconomy_InfoViewModel
    {       

		private readonly IDialogService _dialogService;
		private readonly INavigationService _navigationService;
		private readonly IEconomy _economy;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="Economy_InfoViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="economy">The Economy.</param>
        public Economy_InfoViewModel(IDialogService dialogService, INavigationService navigationService, IEconomy economy)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_economy = economy;
        }
		

		private string _currentEconomy_InfoHtmlControl;

        /// <summary>
        /// CurrentEconomy_InfoHtmlControl property.
        /// </summary>		
        public string CurrentEconomy_InfoHtmlControl
        {
            get
            {
                if(_currentEconomy_InfoHtmlControl == null)
					_currentEconomy_InfoHtmlControl = _economy.Get();
				return _currentEconomy_InfoHtmlControl;     
            }
            set
            {
                SetProperty(ref _currentEconomy_InfoHtmlControl, value);
            }
        }
    }
}