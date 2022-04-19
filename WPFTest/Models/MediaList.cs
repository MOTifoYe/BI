namespace WPFTest.Models
{
    internal class MediaList
    {
        public MediaList(string vocalist, string album)
        {
            Id = ++id;
            Vocalist = vocalist;
            Album = album;
        }

        private static int id = 0;
        public int Id { get; }
        public string Vocalist { get; }
        public string Album { get; }
        

    }
}
