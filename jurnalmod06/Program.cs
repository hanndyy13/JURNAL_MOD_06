using System;

public class SayaUserTube
{
    private int id;
    private List<SayaUserVideo> uploadedVideo;
    private string username;

    public SayaUserTube(string username)
    {
        if(string.IsNullOrEmpty(username) || username.Length > 100)
        {
            throw new Exception("Username tidak boleh kosong dan maksimal 100 karakter");
        }
        
        this.username = username;
        this.uploadedVideo = new List<SayaUserVideo>();
    }

    public void GetTotalVideoPlayCount()
    {
        int totalPlayCount = 0;
        foreach (SayaUserVideo video in uploadedVideo)
        {
            totalPlayCount += video.getPlayCount();
        }
        Console.WriteLine("Total Play Count: " + totalPlayCount);
    }

    public void UploadVideo(SayaUserVideo video)
    {
        uploadedVideo.Add(video);
    }

    public void PrintAllVideoPlayCount()
    {
        foreach (SayaUserVideo video in uploadedVideo)
        {
            video.PrintVideoDetail();
            if(video.getPlayCount() == 9)
            {
                break;
            }
        }
    }
}

public class SayaUserVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaUserVideo(int id, string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 200)
        {
            throw new Exception("Judul tidak boleh kosong dan maksimal 200 karakter");
        }
        this.id = id;
        this.title = title;
    }

    public void IncreasePlayCount(int count)
    {
        if(count < 0 || count > 25000000)
        {
            throw new Exception("Jumlah play count maksimal 25.000.000");
        }
        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Jumlah play count melebihi batas maksimal");
        }
        
    }

    public int getPlayCount()
    {
        return playCount;
    }

    public void PrintVideoDetail()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }
}

class Program
{
    static void Main()
    {
        SayaUserTube userTube = new SayaUserTube("Muhammad Endihan A. N");
        SayaUserVideo video1 = new SayaUserVideo(1, "Review Film Jurrasic Park oleh Muhammad Endihan");

        for (int i = 0; i < 10; i++)
        {
            video1.IncreasePlayCount(25000000);
        }
        video1.PrintVideoDetail();
    }
}