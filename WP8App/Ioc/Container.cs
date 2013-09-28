// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   UnityContainer.tt
using Microsoft.Practices.Unity;
using WPAppStudio.Ioc.Interfaces;
using WPAppStudio.Repositories;
using WPAppStudio.Repositories.Base;
using WPAppStudio.Services;
using WPAppStudio.Services.Interfaces;
using WPAppStudio.ViewModel;
using WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.Ioc
{
    //
    // Unity 2.1
    // http://msdn.microsoft.com/en-us/library/hh237493.aspx
    //
    // patterns & practices - Unity
    // http://unity.codeplex.com/
    //
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public class Container : IContainer
    {
        private readonly IUnityContainer _currentContainer;

        public Container()
        {
            _currentContainer = new UnityContainer();

            _currentContainer.RegisterType<ILiveTileService, LiveTileService>();
			_currentContainer.RegisterType<ILockScreenService, LockScreenService>();
            _currentContainer.RegisterType<IDialogService, DialogService>();
            _currentContainer.RegisterType<IReminderService, ReminderService>();
            _currentContainer.RegisterType<IShareService, ShareService>();
            _currentContainer.RegisterType<ISpeechService, SpeechService>();
            _currentContainer.RegisterType<INavigationService, NavigationService>();
			_currentContainer.RegisterType<IJsonDataSource, JsonDataSource>();
			_currentContainer.RegisterType<IXmlDataSource, XmlDataSource>();
			_currentContainer.RegisterType<IYoutubeDataSource, YoutubeDataSource>();
			
            _currentContainer.RegisterType<Iinfo_InfoViewModel, info_InfoViewModel>();
            _currentContainer.RegisterType<IPhotoAlbum_DetailViewModel, PhotoAlbum_DetailViewModel>();
            _currentContainer.RegisterType<ISpecialPlaces_DetailViewModel, SpecialPlaces_DetailViewModel>();
            _currentContainer.RegisterType<Imonuments_DetailViewModel, monuments_DetailViewModel>();
            _currentContainer.RegisterType<ITravelToMeerut_InfoViewModel, TravelToMeerut_InfoViewModel>();
            _currentContainer.RegisterType<IWeather_InfoViewModel, Weather_InfoViewModel>();
            _currentContainer.RegisterType<IEtymology_InfoViewModel, Etymology_InfoViewModel>();
            _currentContainer.RegisterType<IMythology_InfoViewModel, Mythology_InfoViewModel>();
            _currentContainer.RegisterType<IGeography_InfoViewModel, Geography_InfoViewModel>();
            _currentContainer.RegisterType<IEconomy_InfoViewModel, Economy_InfoViewModel>();
            _currentContainer.RegisterType<IDemographics_InfoViewModel, Demographics_InfoViewModel>();
            _currentContainer.RegisterType<IFilmTelevision_InfoViewModel, FilmTelevision_InfoViewModel>();
            _currentContainer.RegisterType<IEducation_InfoViewModel, Education_InfoViewModel>();
            _currentContainer.RegisterType<IMedia_InfoViewModel, Media_InfoViewModel>();
            _currentContainer.RegisterType<IHistory_InfoViewModel, History_InfoViewModel>();
			
			if (!System.ComponentModel.DesignerProperties.IsInDesignTool)
            {
				_currentContainer.RegisterType<Iinfo, info>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<ImonumentsCollection, monumentsCollection>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IspecialplacesCollection, specialplacesCollection>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Ialbum, album>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Itravel, travel>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Iweather, weather>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Ietymology, etymology>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IMythology, Mythology>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IGeography, Geography>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IEconomy, Economy>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IDemographics, Demographics>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Ifilm, film>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IEducation, Education>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Imedia, media>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IHistory, History>(new ContainerControlledLifetimeManager());
			}
			else
			{
				_currentContainer.RegisterType<Iinfo, Fakeinfo>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<ImonumentsCollection, FakemonumentsCollection>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IspecialplacesCollection, FakespecialplacesCollection>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Ialbum, Fakealbum>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Itravel, Faketravel>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Iweather, Fakeweather>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Ietymology, Fakeetymology>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IMythology, FakeMythology>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IGeography, FakeGeography>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IEconomy, FakeEconomy>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IDemographics, FakeDemographics>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Ifilm, Fakefilm>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IEducation, FakeEducation>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Imedia, Fakemedia>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IHistory, FakeHistory>(new ContainerControlledLifetimeManager());
			
			}	
        }

        public T Resolve<T>()
        {
            return _currentContainer.Resolve<T>();
        }
    }
}