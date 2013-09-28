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
    /// Implementation of PhotoAlbum_Detail ViewModel.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public partial class PhotoAlbum_DetailViewModel : BindableBase, IPhotoAlbum_DetailViewModel, INavigable
    {       

		private readonly IDialogService _dialogService;
		private readonly INavigationService _navigationService;
		private readonly ISpeechService _speechService;
		private readonly IShareService _shareService;
		private readonly ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="PhotoAlbum_DetailViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public PhotoAlbum_DetailViewModel(IDialogService dialogService, INavigationService navigationService, ISpeechService speechService, IShareService shareService, ILiveTileService liveTileService)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		

		private RssSearchResult _currentRssSearchResult;

        /// <summary>
        /// CurrentRssSearchResult property.
        /// </summary>		
        public RssSearchResult CurrentRssSearchResult
        {
            get
            {
				return _currentRssSearchResult;
            }
            set
            {
                SetProperty(ref _currentRssSearchResult, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechPhotoAlbum_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechPhotoAlbum_DetailStaticControlCommandDelegate() 
        {
	
				_speechService.TextToSpeech(CurrentRssSearchResult.Title);
        }
		

        private ICommand _textToSpeechPhotoAlbum_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechPhotoAlbum_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechPhotoAlbum_DetailStaticControlCommand
        {
            get { return _textToSpeechPhotoAlbum_DetailStaticControlCommand = _textToSpeechPhotoAlbum_DetailStaticControlCommand ?? new DelegateCommand(TextToSpeechPhotoAlbum_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the SharePhotoAlbum_DetailStaticControlCommand command.
        /// </summary>
        public  void SharePhotoAlbum_DetailStaticControlCommandDelegate() 
        {
	
				_shareService.Share(CurrentRssSearchResult.Title, " ", CurrentRssSearchResult.FeedUrl);
        }
		

        private ICommand _sharePhotoAlbum_DetailStaticControlCommand;

        /// <summary>
        /// Gets the SharePhotoAlbum_DetailStaticControlCommand command.
        /// </summary>
        public ICommand SharePhotoAlbum_DetailStaticControlCommand
        {
            get { return _sharePhotoAlbum_DetailStaticControlCommand = _sharePhotoAlbum_DetailStaticControlCommand ?? new DelegateCommand(SharePhotoAlbum_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartPhotoAlbum_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartPhotoAlbum_DetailStaticControlCommandDelegate() 
        {
	
				_liveTileService.PinToStart(typeof(IPhotoAlbum_DetailViewModel), CreateTileInfoPhotoAlbum_DetailStaticControl());
        }
		

        private ICommand _pinToStartPhotoAlbum_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartPhotoAlbum_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartPhotoAlbum_DetailStaticControlCommand
        {
            get { return _pinToStartPhotoAlbum_DetailStaticControlCommand = _pinToStartPhotoAlbum_DetailStaticControlCommand ?? new DelegateCommand(PinToStartPhotoAlbum_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GoToSourcePhotoAlbum_DetailStaticControlCommand command.
        /// </summary>
        public  void GoToSourcePhotoAlbum_DetailStaticControlCommandDelegate() 
        {
	
				_navigationService.NavigateTo(new Uri(CurrentRssSearchResult.FeedUrl));
        }
		

        private ICommand _goToSourcePhotoAlbum_DetailStaticControlCommand;

        /// <summary>
        /// Gets the GoToSourcePhotoAlbum_DetailStaticControlCommand command.
        /// </summary>
        public ICommand GoToSourcePhotoAlbum_DetailStaticControlCommand
        {
            get { return _goToSourcePhotoAlbum_DetailStaticControlCommand = _goToSourcePhotoAlbum_DetailStaticControlCommand ?? new DelegateCommand(GoToSourcePhotoAlbum_DetailStaticControlCommandDelegate); }
        }
		public object NavigationContext
        {
            set
            {              
                if (!(value is RssSearchResult)) { return; }
                
                CurrentRssSearchResult = value as RssSearchResult;
            }
        }
        /// <summary>
        /// Initializes a <see cref="TileInfo" /> object for the PhotoAlbum_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="TileInfo" /> object.</returns>
        public TileInfo CreateTileInfoPhotoAlbum_DetailStaticControl()
        {
            var tileInfo = new TileInfo
            {
                CurrentId = CurrentRssSearchResult.Title,
                Title = CurrentRssSearchResult.Title,
                BackTitle = CurrentRssSearchResult.Title,
                BackContent = string.Empty,
                Count = 0,
                BackgroundImagePath = CurrentRssSearchResult.ImageUrl,
                BackBackgroundImagePath = CurrentRssSearchResult.ImageUrl,
                LogoPath = "Logo-01a40c2e-7820-4d8b-864d-12a1eec805ac.png"
            };
            return tileInfo;
        }
    }
}