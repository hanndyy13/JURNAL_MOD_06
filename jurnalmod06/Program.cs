using System;

public class SayaUserTube
{
    private int id;
    private List<SayaUserVideo> uploadedVideo;
    private string username;

    public SayaUserTube(string username)
    {
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
        this.id = id;
        this.title = title;
    }

    public int IncreasePlayCount(int count)
    {
        playCount += count;
        return playCount;
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
        SayaUserVideo video2 = new SayaUserVideo(2, "Review Film Jurrasic Park II oleh Muhammad Endihan");
        SayaUserVideo video3 = new SayaUserVideo(3, "Review Film Jurrasic Park III oleh Muhammad Endihan");
        SayaUserVideo video4 = new SayaUserVideo(4, "Review Film Jurrasic Park IV oleh Muhammad Endihan");
        SayaUserVideo video5 = new SayaUserVideo(5, "Review Film Jurrasic Park V oleh Muhammad Endihan");
        SayaUserVideo video6 = new SayaUserVideo(6, "Review Film Jurrasic Park New Generation oleh Muhammad Endihan");
        SayaUserVideo video7 = new SayaUserVideo(7, "Review Film Jurrasic Park Appocalpyse oleh Muhammad Endihan");
        SayaUserVideo video8 = new SayaUserVideo(8, "Review Film Jurrasic Park Last War oleh Muhammad Endihan");
        SayaUserVideo video9 = new SayaUserVideo(9, "Review Film Jurrasic Park Knight Kingdom oleh Muhammad Endihan");
        SayaUserVideo video10 = new SayaUserVideo(10, "Review Film Jurrasic Park The King Of Jurrasic oleh Muhammad Endihan");
        video1.IncreasePlayCount(100);
        video2.IncreasePlayCount(200);
        userTube.UploadVideo(video1);
        userTube.UploadVideo(video2);
        userTube.GetTotalVideoPlayCount();
        userTube.PrintAllVideoPlayCount();
    }
}