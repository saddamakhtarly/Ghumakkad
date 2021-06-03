using Ghumakkad.Models;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Ghumakkad.ViewModels
{
    public class EventTimelinePageViewModel : BaseViewModel
    {
        #region Private Properties
        private bool _isClicked;
        //private bool _framClicked;
        private List<EventNumber> _eventsList;

        



        #endregion

        #region Public Properties

        #endregion

        #region Command
        public DelegateCommand ReviewCommand => new DelegateCommand(ReviewTapped);
        public DelegateCommand<EventNumber> FramClickCommand => new DelegateCommand<EventNumber>(FramClickTapped);

      

        #region Constructors
        public EventTimelinePageViewModel(INavigationService service) : base(service)
        {
            Title = "Event Timeline";
            EventsList = new List<EventNumber>
            {
                new EventNumber{Title="Introduction", Description="Lorem Ipsum is simply dummy text of the", TimeShow1="\uf2f2", TimeShow2=" 12:30 PM - 01:30 PM",  LiveButton="Share Live" , FramOne="1" },
                new EventNumber{Title="Introduction", Description="Lorem Ipsum is simply dummy text of the", TimeShow1="\uf2f2", TimeShow2=" 12:30 PM - 01:30 PM",  LiveButton="Share Live" , FramOne="2" },
                new EventNumber{Title="Introduction", Description="Lorem Ipsum is simply dummy text of the", TimeShow1="\uf2f2", TimeShow2=" 12:30 PM - 01:30 PM",  LiveButton="Share Live" , FramOne="3" },
                new EventNumber{Title="Introduction", Description="Lorem Ipsum is simply dummy text of the", TimeShow1="\uf2f2", TimeShow2=" 12:30 PM - 01:30 PM",  LiveButton="Share Live" , FramOne="4" }
            };
        }

        //Only run first time after Constructor
        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
        }
        #endregion

        #region Get Set
        public bool IsClicked
        {
            get => _isClicked;
            set => SetProperty(ref _isClicked, value);
        }

        //public bool FramClicked
        //{
        //    get => _framClicked;
        //    set => SetProperty(ref _framClicked, value);
        //}
        public List<EventNumber> EventsList
        {
            get => _eventsList;
            set => SetProperty(ref _eventsList, value);
        }
        #endregion

        #region Public Implementation

        #endregion

        #region Private Implementation
        private void ReviewTapped()
        {
            if (IsClicked)
            {
                IsClicked = false;
            }
            else
                IsClicked = true;
        }
        private void FramClickTapped(EventNumber eventNumber)
        {
            if (eventNumber != null)
            {
                //EventsList.All(e => { e.FramClicked = false; return true; });
                //eventNumber.FramClicked = true;
                eventNumber.FramClicked = !eventNumber.FramClicked;
            }
            
        }
        #endregion
        #endregion
    }
}
