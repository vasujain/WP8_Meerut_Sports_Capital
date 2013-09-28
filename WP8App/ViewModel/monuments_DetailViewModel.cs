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
    /// Implementation of monuments_Detail ViewModel.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public partial class monuments_DetailViewModel : BindableBase, Imonuments_DetailViewModel, INavigable
    {       

		private readonly IDialogService _dialogService;
		private readonly INavigationService _navigationService;
		private readonly ISpeechService _speechService;
		private readonly IShareService _shareService;
		private readonly ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="monuments_DetailViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public monuments_DetailViewModel(IDialogService dialogService, INavigationService navigationService, ISpeechService speechService, IShareService shareService, ILiveTileService liveTileService)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		

		private monumentsCollectionSchema _currentmonumentsCollectionSchema;

        /// <summary>
        /// CurrentmonumentsCollectionSchema property.
        /// </summary>		
        public monumentsCollectionSchema CurrentmonumentsCollectionSchema
        {
            get
            {
				return _currentmonumentsCollectionSchema;
            }
            set
            {
                SetProperty(ref _currentmonumentsCollectionSchema, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechmonuments_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechmonuments_DetailStaticControlCommandDelegate() 
        {
	
				_speechService.TextToSpeech(CurrentmonumentsCollectionSchema.Subtitle);
        }
		

        private ICommand _textToSpeechmonuments_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechmonuments_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechmonuments_DetailStaticControlCommand
        {
            get { return _textToSpeechmonuments_DetailStaticControlCommand = _textToSpeechmonuments_DetailStaticControlCommand ?? new DelegateCommand(TextToSpeechmonuments_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechAboutThisPlaceStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechAboutThisPlaceStaticControlCommandDelegate() 
        {
	
				_speechService.TextToSpeech(CurrentmonumentsCollectionSchema.Description + " " + CurrentmonumentsCollectionSchema.Description);
        }
		

        private ICommand _textToSpeechAboutThisPlaceStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechAboutThisPlaceStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechAboutThisPlaceStaticControlCommand
        {
            get { return _textToSpeechAboutThisPlaceStaticControlCommand = _textToSpeechAboutThisPlaceStaticControlCommand ?? new DelegateCommand(TextToSpeechAboutThisPlaceStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the Sharemonuments_DetailStaticControlCommand command.
        /// </summary>
        public  void Sharemonuments_DetailStaticControlCommandDelegate() 
        {
	
				_shareService.Share(CurrentmonumentsCollectionSchema.Subtitle, " ");
        }
		

        private ICommand _sharemonuments_DetailStaticControlCommand;

        /// <summary>
        /// Gets the Sharemonuments_DetailStaticControlCommand command.
        /// </summary>
        public ICommand Sharemonuments_DetailStaticControlCommand
        {
            get { return _sharemonuments_DetailStaticControlCommand = _sharemonuments_DetailStaticControlCommand ?? new DelegateCommand(Sharemonuments_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareAboutThisPlaceStaticControlCommand command.
        /// </summary>
        public  void ShareAboutThisPlaceStaticControlCommandDelegate() 
        {
	
				_shareService.Share(CurrentmonumentsCollectionSchema.Description, CurrentmonumentsCollectionSchema.Description);
        }
		

        private ICommand _shareAboutThisPlaceStaticControlCommand;

        /// <summary>
        /// Gets the ShareAboutThisPlaceStaticControlCommand command.
        /// </summary>
        public ICommand ShareAboutThisPlaceStaticControlCommand
        {
            get { return _shareAboutThisPlaceStaticControlCommand = _shareAboutThisPlaceStaticControlCommand ?? new DelegateCommand(ShareAboutThisPlaceStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartmonuments_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartmonuments_DetailStaticControlCommandDelegate() 
        {
	
				_liveTileService.PinToStart(typeof(Imonuments_DetailViewModel), CreateTileInfomonuments_DetailStaticControl());
        }
		

        private ICommand _pinToStartmonuments_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartmonuments_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartmonuments_DetailStaticControlCommand
        {
            get { return _pinToStartmonuments_DetailStaticControlCommand = _pinToStartmonuments_DetailStaticControlCommand ?? new DelegateCommand(PinToStartmonuments_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartAboutThisPlaceStaticControlCommand command.
        /// </summary>
        public  void PinToStartAboutThisPlaceStaticControlCommandDelegate() 
        {
	
				_liveTileService.PinToStart(typeof(Imonuments_DetailViewModel), CreateTileInfoAboutThisPlaceStaticControl());
        }
		

        private ICommand _pinToStartAboutThisPlaceStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartAboutThisPlaceStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartAboutThisPlaceStaticControlCommand
        {
            get { return _pinToStartAboutThisPlaceStaticControlCommand = _pinToStartAboutThisPlaceStaticControlCommand ?? new DelegateCommand(PinToStartAboutThisPlaceStaticControlCommandDelegate); }
        }
		public object NavigationContext
        {
            set
            {              
                if (!(value is monumentsCollectionSchema)) { return; }
                
                CurrentmonumentsCollectionSchema = value as monumentsCollectionSchema;
            }
        }
        /// <summary>
        /// Initializes a <see cref="TileInfo" /> object for the monuments_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="TileInfo" /> object.</returns>
        public TileInfo CreateTileInfomonuments_DetailStaticControl()
        {
            var tileInfo = new TileInfo
            {
                CurrentId = CurrentmonumentsCollectionSchema.Id.ToString(),
                Title = CurrentmonumentsCollectionSchema.Subtitle,
                BackTitle = CurrentmonumentsCollectionSchema.Subtitle,
                BackContent = string.Empty,
                Count = 0,
                BackgroundImagePath = CurrentmonumentsCollectionSchema.Image,
                BackBackgroundImagePath = CurrentmonumentsCollectionSchema.Image,
                LogoPath = "Logo-01a40c2e-7820-4d8b-864d-12a1eec805ac.png"
            };
            return tileInfo;
        }
        /// <summary>
        /// Initializes a <see cref="TileInfo" /> object for the AboutThisPlaceStaticControl control.
        /// </summary>
		/// <returns>A <see cref="TileInfo" /> object.</returns>
        public TileInfo CreateTileInfoAboutThisPlaceStaticControl()
        {
            var tileInfo = new TileInfo
            {
                CurrentId = CurrentmonumentsCollectionSchema.Id.ToString(),
                Title = CurrentmonumentsCollectionSchema.Description,
                BackTitle = CurrentmonumentsCollectionSchema.Description,
                BackContent = CurrentmonumentsCollectionSchema.Description,
                Count = 0,
                BackgroundImagePath = string.Empty,
                BackBackgroundImagePath = string.Empty,
                LogoPath = "Logo-01a40c2e-7820-4d8b-864d-12a1eec805ac.png"
            };
            return tileInfo;
        }
    }
}