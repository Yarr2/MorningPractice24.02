namespace MorningPractice24._02;

class Program
{
    static void Main(string[] args)
    {
        var playlist = new Playlist("Road Trip");
        playlist.AddSong(new Song("Bohemian Rhapsody", "Queen", 354));
        playlist.AddSong(new Song("Hotel California", "Eagles", 391));
        Console.WriteLine(playlist.GetSongCount()); // 2
        Console.WriteLine(playlist.GetTotalDuration()); // 745
        var found = playlist.FindSongByArtist("Queen");
        Console.WriteLine(found.GetFormattedDuration()); // 5:54
    }
}