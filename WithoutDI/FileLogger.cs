public class FileLogger
{
   public void log (string message)
    {
        var directory = new FileInfo("log.txt").Directory;
        directory?.Create();
        File.AppendAllText("log.txt", message + Environment.NewLine);
    }
}