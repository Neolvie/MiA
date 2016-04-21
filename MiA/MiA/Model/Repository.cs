using Sungero.Charts.Model;

namespace MiA.Model
{
  public class Repository
  {
    public static Sungero.Charts.Model.Model GetMockModel()
    {
      var model = new Sungero.Charts.Model.Model();


      return model;
    }

    public static Assignment GetMockAssignment()
    {
      var asg = new Assignment();

      return asg;
    }

    public static Performer GetMockPerformer()
    {
      var performer = new Performer();

      return performer;
    }
  }
}