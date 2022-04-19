using System.Collections.Generic;
using WPFTest.Models;

namespace WPFTest.ViewModels
{
    internal class MediaViewModel
    {
        public IList<MediaList> MediaLists { get; set; }
        public MediaList SelectedMedia { get; set; }
    }
}
