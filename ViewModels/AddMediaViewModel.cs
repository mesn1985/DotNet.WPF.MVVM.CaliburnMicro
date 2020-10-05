using System;
using Assignment5.Models;
using Caliburn.Micro;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Assignment5.Extensions;

namespace Assignment5.ViewModels
{ 
    public class AddMediaViewModel : Conductor<object>
    {
        private readonly IEnumerable<MediaType> _mediaTypes;
        public IEnumerable<MediaType> MediaTypes
        {
            get => _mediaTypes; 

        }
        public MultiMediaModel MultiMedia { get; set; }
        public AddMediaViewModel()
        {
            _mediaTypes = Enum.
                          GetValues(typeof(MediaType))
                            .Cast<MediaType>().ToList();
            MultiMedia = new MultiMediaModel();
        }

        public void AddMultiMedia()
        {
            if(!MultiMedia.isValid())
                MessageBox.Show("Please fill out all fields");
            else
                TryClose(true);
            
        }
    }
}
