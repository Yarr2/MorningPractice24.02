namespace MorningPractice24._02;

public class Playlist
{
    private string _name;
    public string Name { get => _name; }
    private List<Song> _songs = new List<Song>{};

    public Playlist(string name)
    {
        _name = name;
    }

    public void AddSong(Song song)
    {
        _songs.Add(song);
    }

    public int GetSongCount()
    {
        return _songs.Count;
    }

    public int GetTotalDuration()
    {
        int result = 0;
        foreach (Song song in _songs)
        {
            result += song.DurationSeconds;
        }
        return result;
    }

    public Song FindSongByArtist(string artist)
    {
        foreach (Song song in _songs)
        {
            if (song.Artist == artist)
            {
                return song;
            }
        }

        return null;
    }
}