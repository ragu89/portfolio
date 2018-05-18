using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace Portfolio.ViewModels.Interfaces
{
    interface IEventsViewModel
    {
        ObservableCollection<Event> Events { get; set; }
        ICommand LoadEventsCommand { get; }
    }
}
