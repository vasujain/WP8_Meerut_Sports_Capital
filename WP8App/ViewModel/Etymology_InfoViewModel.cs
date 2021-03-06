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
    /// Implementation of Etymology_Info ViewModel.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public partial class Etymology_InfoViewModel : BindableBase, IEtymology_InfoViewModel
    {       

		private readonly IDialogService _dialogService;
		private readonly INavigationService _navigationService;
		private readonly Ietymology _etymology;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="Etymology_InfoViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="etymology">The Etymology.</param>
        public Etymology_InfoViewModel(IDialogService dialogService, INavigationService navigationService, Ietymology etymology)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_etymology = etymology;
        }
		

		private string _currentEtymology_InfoHtmlControl;

        /// <summary>
        /// CurrentEtymology_InfoHtmlControl property.
        /// </summary>		
        public string CurrentEtymology_InfoHtmlControl
        {
            get
            {
                if(_currentEtymology_InfoHtmlControl == null)
					_currentEtymology_InfoHtmlControl = _etymology.Get();
				return _currentEtymology_InfoHtmlControl;     
            }
            set
            {
                SetProperty(ref _currentEtymology_InfoHtmlControl, value);
            }
        }
    }
}
