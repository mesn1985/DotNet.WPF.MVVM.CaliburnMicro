using System.Dynamic;
using System.Windows;
using Assignment5.Models;
using Caliburn.Micro;

namespace Assignment5.ViewModels
{
    public class MultiMediaShellViewModel : Conductor<object>
    {
        private WindowManager _windowManager;
        private BindableCollection<MultiMediaModel> _multiMedias;
        public BindableCollection<MultiMediaModel> MultiMedias { get => _multiMedias; }

        public MultiMediaShellViewModel()
        {
            _multiMedias = new BindableCollection<MultiMediaModel>()
            {
                new MultiMediaModel{Artist = "TestArtist1", Genre = "TestGenre1",Title = "TestTitle1", type = MediaType.CD},
                new MultiMediaModel{Artist = "TestArtist2", Genre = "TestGenre2",Title = "TestTitle2", type = MediaType.DVD},
                new MultiMediaModel{Artist = "TestArtist3", Genre = "TestGenre3",Title = "TestTitle3", type = MediaType.CD}
            };
            _windowManager = new WindowManager();
        }

        public void AddMultiMedia()
        {
            dynamic settings = new ExpandoObject();
            settings.WindowStyle = WindowStyle.ThreeDBorderWindow;
            settings.Title = "Add new Media";

            var viewModel = new AddMediaViewModel();
            var addedMedia = _windowManager.ShowDialog(viewModel, null, settings);

            if (addedMedia)
            {
                _multiMedias.Add(viewModel.MultiMedia);
                NotifyOfPropertyChange(()=>MultiMedias);
            }

        }
    }
}
