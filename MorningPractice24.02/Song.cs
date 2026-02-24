namespace MorningPractice24._02;

public class Song
{
    private string _title;

    public string Title
    {
        get => _title;
        set => _title = value ?? throw new ArgumentNullException(nameof(value));
    }

    private string _artist;
    public string Artist { get => _artist; }

    private int _durationSeconds;
    public int DurationSeconds { get => _durationSeconds; }

    public Song(string title, string artist, int durationSeconds)
    {
        Title = title;
        _artist = artist;
        if (durationSeconds > 0)
        {
            _durationSeconds = durationSeconds;
            return;
        }
        _durationSeconds = 0;
    }

    public string GetFormattedDuration()
    {
        return $"{_durationSeconds / 60}:{_durationSeconds % 60}";
    }


}