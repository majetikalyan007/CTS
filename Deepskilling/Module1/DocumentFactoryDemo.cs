using System;

public interface IDocument
{
    void Open();
}

public class WordFile : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening Word Document");
    }
}

public class PdfFile : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening PDF Document");
    }
}

public class ExcelFile : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening Excel Document");
    }
}

public abstract class FileCreator
{
    public abstract IDocument CreateFile();
}

public class WordCreator : FileCreator
{
    public override IDocument CreateFile()
    {
        return new WordFile();
    }
}

public class PdfCreator : FileCreator
{
    public override IDocument CreateFile()
    {
        return new PdfFile();
    }
}

public class ExcelCreator : FileCreator
{
    public override IDocument CreateFile()
    {
        return new ExcelFile();
    }
}

class Program
{
    static void Main()
    {
        FileCreator firstChoice = new WordCreator();
        IDocument wordDocument = firstChoice.CreateFile();
        wordDocument.Open();

        FileCreator secondChoice = new PdfCreator();
        IDocument pdfDocument = secondChoice.CreateFile();
        pdfDocument.Open();

        FileCreator thirdChoice = new ExcelCreator();
        IDocument excelDocument = thirdChoice.CreateFile();
        excelDocument.Open();
    }
}