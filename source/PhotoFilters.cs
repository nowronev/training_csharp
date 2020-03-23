using System;

namespace Delegates
{
  public class PhotoFilters
  {
    public void ApplyBrigtness(Photo photo)
    {
      Console.WriteLine("apply brightness");
    }
    public void ApplyContrast(Photo photo)
    {
      Console.WriteLine("apply contrast");
    }
  }
}
