using System.Collections.Generic;

namespace MiA.Model
{
  public class Model
  {
    public List<Assignment> Assignments { get; set; }

    public List<Performer> Performers { get; set; }

    public Model()
    {
      Assignments = new List<Assignment>();
      Performers = new List<Performer>();
    }
  }
}