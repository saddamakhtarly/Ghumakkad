using Ghumakkad.Views;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ghumakkad.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        #region Private Properties

        #endregion

        #region Public Properties

        #endregion

        #region Command
        public DelegateCommand NextPage => new DelegateCommand(EventTimelinePageMethod);

        
        #endregion

        #region Constructors
        public LoginPageViewModel(INavigationService service) : base(service)
        {
        }

        //Only run first time after Constructor
        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
        }
        #endregion

        #region Get Set

        #endregion

        #region Public Implementation

        #endregion

        #region Private Implementation
        private async void EventTimelinePageMethod()
        {
            await NavigationService.NavigateAsync($"{nameof(EventTimelinePage)}");
        }
        #endregion
    }
}
