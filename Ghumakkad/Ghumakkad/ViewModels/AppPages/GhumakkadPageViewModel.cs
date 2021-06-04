using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ghumakkad.ViewModels
{
   public class GhumakkadPageViewModel: BaseViewModel
    {
        #region Private Properties

        #endregion

        #region Public Properties

        #endregion

        #region Command

        #endregion

        #region Constructors
        public GhumakkadPageViewModel(INavigationService service) : base(service)
        {
            Title = "Ghumakkad";
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

        #endregion
    }
}
